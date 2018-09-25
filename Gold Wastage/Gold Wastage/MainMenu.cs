using PG.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gold_Wastage
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListing customerListing = new CustomerListing();
            customerListing.ShowDialog();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemListing itemListing = new ItemListing();
            itemListing.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryListing entryListing = new EntryListing();
            entryListing.ShowDialog();
        }

        private void customerItemMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerWastageListing customerWastageListing = new CustomerWastageListing();
            customerWastageListing.ShowDialog();
        }

        private void ledgerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger();
            ledger.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fileName = string.Format("bak_{0}.bak", DateTime.Now.Date.ToString("MM-dd-yyyy"));
            string filePath = Path.Combine(Application.StartupPath, "backup.txt");
            if (File.Exists(filePath))
            {
                if (!BackupAvailable(fileName))
                {
                    DoBackup(fileName);
                    BackuptoGDrive(fileName);
                }
            }
        }

        private bool BackupAvailable(string fileName)
        {
            bool retValue = false;

            string path = Path.Combine(Application.StartupPath, "Backup");
            string filePath = Path.Combine(path, fileName);
            if (Directory.Exists(path) && File.Exists(filePath))
            {
                retValue = true;
            }

            return retValue;
        }

        private void DoBackup(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Backup");
            string filePath = Path.Combine(path, fileName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string constr = ConfigurationSettings.AppSettings["constr"].ToString();
            ParameterList parameterList = new ParameterList();
            parameterList.Add("@fileName ", filePath, SqlDbType.VarChar);
            SqlHelper.ExecuteNonQuery(constr, "BackupDB", CommandType.StoredProcedure, parameterList);
        }

        private void BackuptoGDrive(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Backup");
            string filePath = Path.Combine(path, fileName);
            string zipFileName = string.Concat(Path.GetFileNameWithoutExtension(fileName), ".zip");
            string zipFilePath = Path.Combine(path, zipFileName);
            ZipUtility.CreateZipFile(Path.Combine(path, zipFileName), string.Empty, filePath, string.Empty);
            ZipUtility.UploadBackup(zipFilePath);
        }
    }
}
