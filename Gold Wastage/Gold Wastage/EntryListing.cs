using PG.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gold_Wastage
{
    public partial class EntryListing : Form
    {
        string _constr = string.Empty;
        public EntryListing()
        {
            InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            LoadCustomer();
            LoadItem();
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
                CmbItem.DataSource = dataSet.Tables[0];
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
            if (CmbItem.SelectedIndex > 0)
            {
                parameterList.Add("@ItemID", CmbItem.SelectedValue, SqlDbType.BigInt);
            }

            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetCustomerEntryListing", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0)
            {
                grid.DataSource = dataSet.Tables[0];
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry(0, Common.Mode.Add);
            entry.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Int64 entryID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvColCustomerEntryID"].Value.ToString(), out entryID);
                Entry entry = new Entry(entryID, Common.Mode.Edit);
                entry.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Int64 entryID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvColCustomerEntryID"].Value.ToString(), out entryID);
                Entry entry = new Entry(entryID, Common.Mode.Delete);
                entry.ShowDialog();
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
