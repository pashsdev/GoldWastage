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
    public partial class Entry : Form
    {
        private string _constr = string.Empty;
        private Int64 _entryID = 0;
        private Common.Mode _mode = Common.Mode.Add;

        public Entry(Int64 entryID, Common.Mode mode)
        {
            InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            _mode = mode;
            _entryID = entryID;
            LoadCustomers();
            LoadItem();
            LoadReceivedFrom();
            LoadFromEntry();
            if (mode == Common.Mode.Add)
            {
                txtEntryNo.Text = GetEntryNo();
                DtEntry.Value = DateTime.Now;
            }
            else
            {
                LoadEntry(_entryID);
                grpType.Enabled = false;
            }
            
        }

        private void LoadCustomers()
        {
            ParameterList parameterList = new ParameterList();
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetCustomers", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].NewRow();
                dataRow["CustomerId"] = 0;
                dataRow["CustomerName"] = "--Select--";
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
                dataRow["ItemName"] = "--Select--";
                dataSet.Tables[0].Rows.InsertAt(dataRow, 0);
                CmbItem.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadFromEntry()
        {
            ParameterList parameterList = new ParameterList();
            parameterList.Add("@Mode", _mode, SqlDbType.Int);
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetFromEntry", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].NewRow();
                dataRow["CustomerEntryID"] = 0;
                dataRow["EntryNo"] = "--Select--";
                dataSet.Tables[0].Rows.InsertAt(dataRow, 0);
                CmbInEntryno.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadReceivedFrom()
        {
            ParameterList parameterList = new ParameterList();
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetReceivedFrom", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                CmbReceivedFrom.DataSource = dataSet.Tables[0];
            }
        }

        private string GetEntryNo()
        {
            string entryNo = string.Empty;
            ParameterList parameterList = new ParameterList();
            if (radIn.Checked)
            {
                parameterList.Add("@Type", "IN", SqlDbType.VarChar);
            }
            if (radOut.Checked)
            {
                parameterList.Add("@Type", "OUT", SqlDbType.VarChar);
            }
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetEntryNo", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                entryNo = dataSet.Tables[0].Rows[0]["EntryNo"].ToString();
            }

            return entryNo;
        }

        private void LoadEntry(Int64 entryID)
        {
            ParameterList parameterList = new ParameterList();
            parameterList.Add("@EntryID", entryID, SqlDbType.BigInt);
            DataSet dataSet = SqlHelper.ExecuteDataSet(_constr, "GetEntry", CommandType.StoredProcedure, parameterList);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                
                DateTime dateTime;
                DateTime.TryParse(dataSet.Tables[0].Rows[0]["EntryDate"].ToString(), out dateTime);
                DtEntry.Value = dateTime;
                CmbCustomer.SelectedValue = dataSet.Tables[0].Rows[0]["CustomerID"];
                CmbItem.SelectedValue = dataSet.Tables[0].Rows[0]["ItemID"];
                CmbReceivedFrom.SelectedValue = dataSet.Tables[0].Rows[0]["ReceivedFrom"];
                txtWeight.Text = dataSet.Tables[0].Rows[0]["Weight"].ToString();
                if (dataSet.Tables[0].Rows[0]["InEntryID"] != null && !string.IsNullOrEmpty(dataSet.Tables[0].Rows[0]["InEntryID"].ToString()))
                {
                    CmbInEntryno.SelectedValue = dataSet.Tables[0].Rows[0]["InEntryID"].ToString();
                }
                if (!CmbInEntryno.Visible)
                {
                    txtEntryNo.Text = dataSet.Tables[0].Rows[0]["EntryNo"].ToString();
                    if (dataSet.Tables[0].Rows[0]["Type"].ToString().ToLower() == "in")
                    {
                        radIn.Checked = true;
                    }
                    if (dataSet.Tables[0].Rows[0]["Type"].ToString().ToLower() == "out")
                    {
                        radOut.Checked = true;
                    }
                }
            }
        }

        private bool ValidateCustomer()
        {
            bool retValue = false;

            if (CmbCustomer.SelectedIndex <= 0)
            {
                errorProvider1.SetError(CmbCustomer, "Select Customer!");
                retValue = false;
            }
            else
            {
                errorProvider1.Clear();
                retValue = true;
            }

            if (CmbItem.SelectedIndex <= 0)
            {
                errorProvider1.SetError(CmbItem, "Select Item!");
                retValue = false;
            }
            else
            {
                errorProvider1.Clear();
                retValue = true;
            }

            double wastage = 0;
            double.TryParse(txtWeight.Text, out wastage);
            if (wastage <= 0)
            {
                errorProvider1.SetError(txtWeight, "Enter Wastage!");
                retValue = false;
            }
            else
            {
                errorProvider1.Clear();
                retValue = true;
            }

            return retValue;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomer())
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
                parameterList.Add("@Mode", _mode, SqlDbType.Int);
                parameterList.Add("@EntryNo", txtEntryNo.Text, SqlDbType.VarChar);
                parameterList.Add("@EntryDate", DtEntry.Value, SqlDbType.DateTime);
                parameterList.Add("@CustomerId", CmbCustomer.SelectedValue, SqlDbType.BigInt);
                parameterList.Add("@ItemID", CmbItem.SelectedValue, SqlDbType.BigInt);
                parameterList.Add("@ReceivedFrom", CmbReceivedFrom.SelectedValue, SqlDbType.VarChar);
                if (radIn.Checked)
                {
                    parameterList.Add("@Type", "IN", SqlDbType.VarChar);
                }
                if (radOut.Checked)
                {
                    parameterList.Add("@Type", "OUT", SqlDbType.VarChar);
                    parameterList.Add("@OutFrom", CmbInEntryno.SelectedValue, SqlDbType.BigInt);
                }
                parameterList.Add("@ReceivedFrom", CmbReceivedFrom.SelectedValue, SqlDbType.VarChar);
                parameterList.Add("@Weight", txtWeight.Text, SqlDbType.Decimal);
                parameterList.Add("@EntryID", _entryID, SqlDbType.BigInt);

                SqlHelper.ExecuteNonQuery(_constr, "UpdateCustomerEntry", CommandType.StoredProcedure, parameterList);

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

        private void radOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radOut.Checked)
            {
                lblFromEntryNo.Visible = true;
                CmbInEntryno.Visible = true;

                lblReceivedFrom.Visible = false;
                CmbReceivedFrom.Visible = false;

                CmbCustomer.Enabled = false;
                CmbItem.Enabled = false;
                CmbReceivedFrom.Enabled = false;
                if (_mode != Common.Mode.Add)
                {
                    CmbInEntryno.Enabled = false;
                }
            }
            else
            {
                lblFromEntryNo.Visible = false;
                CmbInEntryno.Visible = false;

                lblReceivedFrom.Visible = true;
                CmbReceivedFrom.Visible = true;

                CmbCustomer.Enabled = true;
                CmbItem.Enabled = true;
                CmbReceivedFrom.Enabled = true;
            }
            if (_mode == Common.Mode.Add)
            {
                txtEntryNo.Text = GetEntryNo();
            }
        }

        private void CmbInEntryno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 inEntryID = 0;
            if (CmbInEntryno.SelectedIndex > 0)
            {
                Int64.TryParse(CmbInEntryno.SelectedValue.ToString(), out inEntryID);
                LoadEntry(inEntryID);
            }
        }
    }
}
