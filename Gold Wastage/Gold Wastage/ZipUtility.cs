using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Gold_Wastage
{
    class ZipUtility
    {
        static string[] _scopes = { DriveService.Scope.Drive };
        static string _applicationName = "TestApp";

        public static void CreateZipFile(string zipFilePath, string password, string fileName, string basePath)
        {
            System.IO.FileStream fsOut = System.IO.File.Create(zipFilePath);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

            zipStream.SetLevel(4); //0-9, 9 being the highest level of compression

            zipStream.Password = password;  // optional. Null is the same as not setting. Required if using AES.

            // This setting will strip the leading part of the folder path in the entries, to
            // make the entries relative to the starting folder.
            // To include the full path for each entry up to the drive root, assign folderOffset = 0.
            //int folderOffset = folderName.Length + (folderName.EndsWith("\\") ? 0 : 1);

            CompressFile(fileName, zipStream, basePath);

            zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
            zipStream.Close();
        }

        public static void UploadBackup(string filePath)
        {
            DriveService service = GetServices(_applicationName);
            IList<Google.Apis.Drive.v3.Data.File> files = GetFiles(service);
            File file = createDirectory(service, "Backup", "Backup files", "");
            UploadFile(service, filePath, file.Id);
        }

        private static void CompressFile(string filePath, ZipOutputStream zipStream, string basePath)
        {

            System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
            string zipCleanName = filePath;
            if (!string.IsNullOrEmpty(basePath))
            {
                zipCleanName = filePath.Replace(basePath, string.Empty);
            }
            else
            {
                zipCleanName = ZipEntry.CleanName(System.IO.Path.GetFileName(filePath));
            }
            //string entryName = filePath.Substring(folderOffset); // Makes the name in zip based on the folder
            string entryName = ZipEntry.CleanName(zipCleanName); // Removes drive from name and fixes slash direction
            ZipEntry newEntry = new ZipEntry(entryName);
            newEntry.DateTime = fi.LastWriteTime; // Note the zip format stores 2 second granularity

            // Specifying the AESKeySize triggers AES encryption. Allowable values are 0 (off), 128 or 256.
            // A password on the ZipOutputStream is required if using AES.
            //   newEntry.AESKeySize = 256;

            // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003, WinZip 8, Java, and other older code,
            // you need to do one of the following: Specify UseZip64.Off, or set the Size.
            // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, you do not need either,
            // but the zip will be in Zip64 format which not all utilities can understand.
            //   zipStream.UseZip64 = UseZip64.Off;
            newEntry.Size = fi.Length;

            zipStream.PutNextEntry(newEntry);

            // Zip the file in buffered chunks
            // the "using" will close the stream even if an exception occurs
            byte[] buffer = new byte[4096];
            using (System.IO.FileStream streamReader = System.IO.File.OpenRead(filePath))
            {
                StreamUtils.Copy(streamReader, zipStream, buffer);
            }
            zipStream.CloseEntry();
        }

        private static DriveService GetServices(string applicationName)
        {
            DriveService service;
            UserCredential credential;

            using (var stream =
                new System.IO.FileStream("credentials.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    _scopes,
                    "admin",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            return service;
        }

        private static IList<Google.Apis.Drive.v3.Data.File> GetFiles(DriveService service)
        {
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    Console.WriteLine("{0} ({1})", file.Name, file.Id);
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }
            return files;
        }

        private static Google.Apis.Drive.v3.Data.File createDirectory(DriveService service, string title, string description, string parent)
        {
            IList<Google.Apis.Drive.v3.Data.File> files = GetFiles(service);

            Google.Apis.Drive.v3.Data.File backupDirectory = null;
            if (files.Where(x => x.Name.ToLower() == "backup").Count() > 0)
            {
                backupDirectory = files.Where(x => x.Name.ToLower() == "backup").FirstOrDefault();
            }
            else
            {
                // Create metaData for a new Directory
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = title;
                body.Description = description;
                body.MimeType = "application/vnd.google-apps.folder";
                //body.Parents = new List<ParentReference>() { new ParentReference() { Id = _parent } };
                try
                {
                    FilesResource.CreateRequest request = service.Files.Create(body);
                    backupDirectory = request.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }
            return backupDirectory;
        }

        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }

        private static File UpdateFile(DriveService service, string uploadFilePath, string fileID)
        {

            if (System.IO.File.Exists(uploadFilePath))
            {
                File body = new File();
                body.Name = System.IO.Path.GetFileName(uploadFilePath);
                body.Description = "File uploaded by Drive Sample";
                body.MimeType = GetMimeType(uploadFilePath);
                //body.Parents = new List<string>() { _parent };

                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(uploadFilePath);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.UpdateRequest request = service.Files.Update(body, fileID);
                    request.Fields = "id";
                    File responseFile = request.Execute();
                    return responseFile;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                    return null;
                }
            }
            else
            {
                Console.WriteLine("File does not exist: " + uploadFilePath);
                return null;
            }

        }

        private static void UploadFile(DriveService service, string uploadFilePath, string parentfileID)
        {

            if (System.IO.File.Exists(uploadFilePath))
            {
                File body = new File();
                body.Name = System.IO.Path.GetFileName(uploadFilePath);
                body.Description = "File uploaded by Drive Sample";
                body.MimeType = GetMimeType(uploadFilePath);
                body.Parents = new List<string>() { parentfileID };

                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(uploadFilePath);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    IList<File> files = GetFiles(service);
                    File file = files.Where(x => x.Name.ToLower() == body.Name).FirstOrDefault();
                    if (file != null)
                    {
                        UpdateFile(service, uploadFilePath, file.Id);
                    }
                    else
                    {
                        FilesResource.CreateMediaUpload request = service.Files.Create(body, stream, GetMimeType(uploadFilePath));
                        request.Fields = "id";
                        request.ProgressChanged += Request_ProgressChanged;
                        request.ResponseReceived += Request_ResponseReceived;
                        request.Upload();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("File does not exist: " + uploadFilePath);
            }

        }

        private static void Request_ResponseReceived(File obj)
        {
        }

        private static void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        {

        }
    }
}
