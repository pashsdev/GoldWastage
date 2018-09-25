using PG.Helper;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gold_Wastage
{
    public partial class CustomerListing : Form
    {
        string _constr = string.Empty;
        public CustomerListing()
        {
           InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            ParameterList parameterList = new ParameterList();
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetCustomers", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].NewRow();
                dataRow["CustomerId"] = 0;
                dataRow["CustomerName"] = "--All--";
                dataRow["Mobile"] = "--All--";
                dataSet.Tables[0].Rows.InsertAt(dataRow, 0);
                CmbCustomer.DataSource = dataSet.Tables[0];
                CmbMobile.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadGrid()
        {
            grid.AutoGenerateColumns = false;
            ParameterList parameterList = new ParameterList();
            if (CmbCustomer.SelectedIndex > 0)
            {
                parameterList.Add("@CustomerId", CmbCustomer.SelectedValue, SqlDbType.BigInt);
            }
            if (CmbMobile.SelectedIndex > 0)
            {
                string mobile = ((DataRowView)CmbMobile.Items[CmbMobile.SelectedIndex])["Mobile"].ToString();
                parameterList.Add("@Mobile", mobile, SqlDbType.VarChar);
            }
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetCustomers", CommandType.StoredProcedure, parameterList);
            //SqlDataReaderHelper sqlDataReader = new SqlDataReaderHelper(dataReader);
            if (dataSet.Tables.Count > 0)
            {
                grid.DataSource = dataSet.Tables[0];
            }
            else
            {
                grid.DataSource = null;
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Int64 customerID = 0;
            
            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvcolCustomerID"].Value.ToString(), out customerID);
                Customer customer = new Customer(customerID,Common.Mode.Edit);
                customer.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Int64 customerID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvcolCustomerID"].Value.ToString(), out customerID);
                Customer customer = new Customer(customerID, Common.Mode.Delete);
                customer.ShowDialog();
            }
        }
    }
}
