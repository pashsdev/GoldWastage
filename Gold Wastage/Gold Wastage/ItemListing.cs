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
    public partial class ItemListing : Form
    {
        string _constr = string.Empty;
        public ItemListing()
        {
            InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            LoadItem();
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
            if (CmbItem.SelectedIndex > 0)
            {
                parameterList.Add("@ItemID", CmbItem.SelectedValue, SqlDbType.BigInt);
            }
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetItems", CommandType.StoredProcedure, parameterList);
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
            Item item = new Item();
            item.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Int64 itemID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvcolItemID"].Value.ToString(), out itemID);
                Item item = new Item(itemID, Common.Mode.Edit);
                item.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Int64 itemID = 0;

            if (grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                Int64.TryParse(grid.Rows[rowIndex].Cells["DgvcolItemID"].Value.ToString(), out itemID);
                Item item = new Item(itemID, Common.Mode.Delete);
                item.ShowDialog();
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
