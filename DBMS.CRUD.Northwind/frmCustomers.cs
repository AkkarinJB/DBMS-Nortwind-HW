using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMS.CRUD.Northwind
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string ContactName { get; set; }
        public string Status { get; set; }


        private void frmCustomers_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = CustomerID;
            txtCompanyName.Text = CompanyName;
            txtContactName.Text = ContactName;
            txtPhone.Text = Phone;
            txtCompanyName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = connectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertCustomers();
            }
            else if (Status == "update")
            {
                UpdateCustomers();
            }
            this.Close();
        }

        private void UpdateCustomers()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "UPDATE Customers " +
             "SET CompanyName = @companyName, ContactName = @contactName, Phone = @phone " +
             "WHERE CustomerID = @customerID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@contactName", txtContactName.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@customerID", txtCustomerID.Text.Trim());
            int n = cmd.ExecuteNonQuery();
        }

        private void InsertCustomers()
        {
            MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("โปรดกรอกรหัสลูกค้า", "เกิดข้อผิดพลาด");
                return;
            }

            // Ensure the SQL query includes all required columns
            string sql = "INSERT INTO customers (CustomerID, CompanyName, ContactName, Phone) " +
                         "VALUES (@CustomerID, @CompanyName, @ContactName, @Phone)";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "สำเร็จ");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด");
            }
        }
    }
}
