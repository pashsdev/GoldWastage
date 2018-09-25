using PG.Helper;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gold_Wastage
{
    public partial class CustomerWastageListing : Form
    {
        string _constr = string.Empty;
        public CustomerWastageListing()
        {
            InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            LoadCustomers();
            LoadItem();
        }

        private void LoadCustomers()
        {
            ParameterList parameterList = new ParameterList();
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetCustomers", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].NewRow();
                dataRow["CustomerId"] = 0;
                dataRow["CustomerName"] = "--All--";
                dataSet.Tables[0].Rows.InsertAt(dataRow, 0);
                CmbCustomer.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadItem()
        {
            ParameterList parameterList = new ParameterList();
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetItems", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].NewRow();
                dataRow["ItemID"] = 0;
                dataRow["ItemName"] = "--All--";
                dataSet.Tables[0].Rows.InsertAt(dataRow, 0);
                CmbItem.DataSource = dataSet.Tables[0];
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            grid.AutoGenerateColumns = false;
            ParameterList parameterList = new ParameterList();
            if (CmbCustomer.SelectedIndex > 0)
            {
                parameterList.Add("@CustomerId", CmbCustomer.SelectedValue, SqlDbType.BigInt);
            }
            if (CmbItem.SelectedIndex > 0)
            {
                parameterList.Add("@ItemID", CmbItem.SelectedValue, SqlDbType.BigInt);
            }
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetCustomerWastageListing", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 )
            {
                grid.DataSource = dataSet.Tables[0];
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CustomerWastage customerWastage = new CustomerWastage(0, Common.Mode.Add);
            customerWastage.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Int64 mappingID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvColMappingID"].Value.ToString(), out mappingID);
                CustomerWastage customerWastage = new CustomerWastage(mappingID, Common.Mode.Edit);
                customerWastage.ShowDialog();
            }            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Int64 mappingID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvColMappingID"].Value.ToString(), out mappingID);
                CustomerWastage customerWastage = new CustomerWastage(mappingID, Common.Mode.Delete);
                customerWastage.ShowDialog();
            }

        }
    }
}
