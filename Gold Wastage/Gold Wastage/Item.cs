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
    public partial class Item : Form
    {
        private string _constr = string.Empty;
        private Int64 _itemID = 0;
        private Common.Mode _mode = Common.Mode.Add;
        public Item()
        {
            InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
        }

        public Item(Int64 itemID, Common.Mode mode)
        {
            InitializeComponent();
            _mode = mode;
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            _itemID = itemID;
            LoadItem();
        }

        private void LoadItem()
        {
            ParameterList parameterList = new ParameterList();
            if (_itemID> 0)
            {
                parameterList.Add("@ItemId", _itemID, SqlDbType.BigInt);
            }
            IDataReader dataReader = SqlHelper.ExecuteReader(_constr, "GetItems", CommandType.StoredProcedure, parameterList);
            SqlDataReaderHelper sqlDataReaderHelper = new SqlDataReaderHelper(dataReader);
            while (dataReader.Read())
            {
                txtItem.Text = sqlDataReaderHelper.GetString("ItemName");// dataReader["ItemName"].ToString();
            }

            if (_mode == Common.Mode.Delete)
            {
                BtnSave.Text = "Delete";
            }
            if (_mode == Common.Mode.Edit)
            {
                BtnSave.Text = "Update";
            }
        }

        private bool ValidateItem()
        {
            bool retValue = false;

            if (string.IsNullOrEmpty(txtItem.Text.Trim()))
            {
                errorProvider1.SetError(txtItem, "Enter Item!");
                retValue = false;
            }
            else
            {
                errorProvider1.Clear();
                retValue = true;
            }

            return retValue;
        }

        private bool CheckDuplicate()
        {
            bool retValue = false;
            ParameterList parameterList = new ParameterList();
            parameterList.Add("@ItemName", txtItem.Text, SqlDbType.VarChar);
            parameterList.Add("@ItemID", _itemID, SqlDbType.BigInt);
            IDataReader dataReader = SqlHelper.ExecuteReader(_constr, "CheckItemDuplicate", CommandType.StoredProcedure, parameterList);
            SqlDataReaderHelper sqlDataReaderHelper = new SqlDataReaderHelper(dataReader);
            if (dataReader.Read())
            {
                MessageBox.Show(this, string.Concat(txtItem.Text, " Item already exists"), "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retValue = true;
            }

            return retValue;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateItem())
            {
                return;
            }

            if (CheckDuplicate())
            {
                return;
            }

            string message = "Do you want to {0}?";
            if (_mode == Common.Mode.Delete)
            {
                message = string.Format(message, "Delete");
            }
            if (_mode == Common.Mode.Edit || _mode == Common.Mode.Add)
            {
                message = string.Format(message, "Save");
            }
            if (MessageBox.Show(this, message, "Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ParameterList parameterList = new ParameterList();
                parameterList.Add("@ItemId", _itemID, SqlDbType.BigInt);
                parameterList.Add("@ItemName", txtItem.Text, SqlDbType.VarChar);
                parameterList.Add("@Mode", _mode, SqlDbType.Int);
                SqlHelper.ExecuteNonQuery(_constr, "UpdateItem", CommandType.StoredProcedure, parameterList);

                message = "Saved Sucessfully!";
                if (_mode == Common.Mode.Delete)
                {
                    message = "Deleted Sucessfully!";
                }
                if (_mode == Common.Mode.Edit)
                {
                    message = "Updated Sucessfully!";
                }

                MessageBox.Show(this, message, "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
