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
    public partial class CustomerWastage : Form
    {
        string _constr = string.Empty;
        private Int64 _mappingID = 0;
        private Common.Mode _mode = Common.Mode.Add;
        public CustomerWastage(Int64 mappingID, Common.Mode mode)
        {
            InitializeComponent();
            _mode = mode;
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            _mappingID = mappingID;
            LoadCustomers();
            LoadItem();
            if (_mode != Common.Mode.Add)
            {
                LoadCustomerWastage();
            }
        }

        private void LoadCustomerWastage()
        {
            ParameterList parameterList = new ParameterList();
            if (_mappingID > 0)
            {
                parameterList.Add("@MappingID", _mappingID, SqlDbType.BigInt);
            }
            IDataReader dataReader = SqlHelper.ExecuteReader(_constr, "GetCustomerWastageListing", CommandType.StoredProcedure, parameterList);
            SqlDataReaderHelper sqlDataReaderHelper = new SqlDataReaderHelper(dataReader);
            while (dataReader.Read())
            {
                CmbCustomer.SelectedValue = dataReader["CustomerID"].ToString();
                CmbItem.SelectedValue = dataReader["ItemID"].ToString();
                txtWastage.Text = dataReader["Wastage"].ToString();
                txtPer.Text = dataReader["Per"].ToString();
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

        private bool ValidateCustomer()
        {
            bool retValue = false;
            double wastage = 0;
            double.TryParse(txtWastage.Text, out wastage);
            double per = 0;
            double.TryParse(txtPer.Text, out per);

            if (CmbCustomer.SelectedIndex <= 0)
            {
                errorProvider1.SetError(CmbCustomer, "Select Customer!");
                retValue = false;
            }
            else if (CmbItem.SelectedIndex <= 0)
            {
                errorProvider1.SetError(CmbItem, "Select Item!");
                retValue = false;
            }
            else if (wastage <= 0)
            {
                errorProvider1.SetError(txtWastage, "Enter Wastage!");
                retValue = false;
            }
            else if (per <= 0)
            {
                errorProvider1.SetError(txtPer, "Enter Per Unit!");
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
            parameterList.Add("@MappingID", _mappingID, SqlDbType.BigInt);
            parameterList.Add("@CustomerID", CmbCustomer.SelectedValue, SqlDbType.BigInt);
            parameterList.Add("@ItemID", CmbItem.SelectedValue, SqlDbType.VarChar);
            IDataReader dataReader = SqlHelper.ExecuteReader(_constr, "CheckCustomerWastageDuplicate", CommandType.StoredProcedure, parameterList);
            SqlDataReaderHelper sqlDataReaderHelper = new SqlDataReaderHelper(dataReader);
            if (dataReader.Read())
            {
                MessageBox.Show(this, "Customer wastage added for this customer", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (CmbCustomer.SelectedIndex > 0)
                {
                    parameterList.Add("@CustomerId", CmbCustomer.SelectedValue, SqlDbType.BigInt);
                }
                if (CmbItem.SelectedIndex > 0)
                {
                    parameterList.Add("@ItemID", CmbItem.SelectedValue, SqlDbType.BigInt);
                }
                parameterList.Add("@MappingID", _mappingID, SqlDbType.BigInt);
                parameterList.Add("@Wastage", txtWastage.Text, SqlDbType.Decimal);
                parameterList.Add("@Per", txtPer.Text, SqlDbType.Decimal);
                parameterList.Add("@Mode", _mode, SqlDbType.Int);
                SqlHelper.ExecuteNonQuery(_constr, "UpdateCustomerWastage", CommandType.StoredProcedure, parameterList);

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
