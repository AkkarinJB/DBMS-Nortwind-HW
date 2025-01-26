using Microsoft.Data.SqlClient;
using System.Data;
namespace DBMS.CRUD.Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        static string customerID = string.Empty;
        string companyName = string.Empty;
        string contactName = string.Empty;
        string phone = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectNorthwind();
            showdata();

            dgvCustomers.CellMouseUp += dgvCustomers_CellMouseUp;
        }

        private void showdata()
        {
            string sql = "SELECT * FROM Customers";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCustomers.DataSource = ds.Tables[0];
        }
        private void clearForm()
        {
            //txtShipperID.Clear();
            //txtCompanyName.Clear();
            //txtPhone.Clear();
            //txtCompanyName.Focus();
        }

        private void dgvCustomers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                customerID = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                companyName = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                contactName = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
                phone = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCustomers f = new frmCustomers();
            f.Status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            frmCustomers f = new frmCustomers();
            f.Status = "update";
            f.CustomerID = customerID;
            f.CompanyName = companyName;
            f.ContactName = contactName;
            f.Phone = phone;
            f.ShowDialog();
            showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "รหัส :" + customerID.ToString() + Environment.NewLine;
            msg += "บริษัท :" + companyName + Environment.NewLine;
            msg += "โทร :" + phone;
            if (MessageBox.Show(msg, "คุณต้องการลบข้อมูลใช่หรือไม่") == DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผืดพลาด");
                return;
            }
            string sql = "Delete from Customers"
                + " Where CustomerID = @CustomerID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CustomerID", customerID);
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    showdata();
                    clearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void dgvCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
