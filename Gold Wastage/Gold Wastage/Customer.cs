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
    public partial class Customer : Form
    {
        private string _constr = string.Empty;
        private Int64 _customerID = 0;
        private Common.Mode _mode = Common.Mode.Add;
        public Customer()
        {
            InitializeComponent();
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
        }

        public Customer(Int64 customerID, Common.Mode mode)
        {
            InitializeComponent();
            _mode = mode;
            _constr = ConfigurationSettings.AppSettings["constr"].ToString();
            _customerID = customerID;
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            ParameterList parameterList = new ParameterList();
            if (_customerID > 0)
            {
                parameterList.Add("@CustomerId", _customerID, SqlDbType.BigInt);
            }
            IDataReader dataReader = SqlHelper.ExecuteReader(_constr, "GetCustomers", CommandType.StoredProcedure, parameterList);
            SqlDataReaderHelper sqlDataReaderHelper = new SqlDataReaderHelper(dataReader);
            while (dataReader.Read())
            {
                txtCustomer.Text = dataReader["CustomerName"].ToString();
                txtEmail.Text = dataReader["Email"].ToString();
                txtMobile.Text = dataReader["Mobile"].ToString();
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

        private bool CheckDuplicate()
        {
            bool retValue = false;
            ParameterList parameterList = new ParameterList();
            parameterList.Add("@CustomerName", txtCustomer.Text, SqlDbType.VarChar);
            parameterList.Add("@Mobile", txtMobile.Text, SqlDbType.VarChar);
            parameterList.Add("@Email", txtEmail.Text, SqlDbType.VarChar);
            parameterList.Add("@CustomerID", _customerID, SqlDbType.BigInt);
            IDataReader dataReader = SqlHelper.ExecuteReader(_constr, "CheckCustomerDuplicate", CommandType.StoredProcedure, parameterList);
            SqlDataReaderHelper sqlDataReaderHelper = new SqlDataReaderHelper(dataReader);
            if (dataReader.Read())
            {
                MessageBox.Show(this, string.Concat(txtCustomer.Text, " Customer already exists"), "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retValue = true;
            }

            return retValue;
        }


        private bool ValidateCustomer()
        {
            bool retValue = false;

            if (string.IsNullOrEmpty(txtCustomer.Text.Trim()))
            {
                errorProvider1.SetError(txtCustomer, "Enter Customer!");
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
                parameterList.Add("@CustomerId", _customerID, SqlDbType.BigInt);
                parameterList.Add("@CustomerName", txtCustomer.Text, SqlDbType.VarChar);
                parameterList.Add("@Mobile", txtMobile.Text, SqlDbType.VarChar);
                parameterList.Add("@Email", txtEmail.Text, SqlDbType.VarChar);
                parameterList.Add("@Mode", _mode, SqlDbType.Int);
                SqlHelper.ExecuteNonQuery(_constr, "UpdateCustomer", CommandType.StoredProcedure, parameterList);

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
