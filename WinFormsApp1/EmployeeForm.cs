using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        private string connectionString = @"Data Source=DANIYALHAIDER\SQLEXPRESS;Initial Catalog=DBproject;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";


        public EmployeeForm()
        {
            InitializeComponent(); 
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //tbName.ReadOnly = true;
            //tbBranch.ReadOnly = true;

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        conn.Open();

            //        string query = @"
            //    SELECT e.Name, b.BranchName
            //    FROM Employees e
            //    JOIN Branches b ON e.BranchID = b.BranchID
            //    WHERE e.UserID = @UserID";

            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@UserID", userId);

            //        SqlDataReader reader = cmd.ExecuteReader();
            //        if (reader.Read())
            //        {
            //            tbName.Text = reader["Name"].ToString();
            //            tbBranch.Text = reader["BranchName"].ToString();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Employee not found.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error loading employee info: " + ex.Message);
            //    }
            //}
        }


        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    P.ProductID,
                    P.Name,
                    P.Price,
                    P.StockQty,
                    C.CategoryName,
                    B.BrandName
                FROM Products P
                LEFT JOIN Categories C ON P.CategoryID = C.CategoryID
                LEFT JOIN Brands B ON P.BrandID = B.BrandID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvProducts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    O.OrderID,
                    U.Name AS CustomerName,
                    U.Email,
                    O.OrderDate,
                    O.TotalAmount,
                    O.Status
                FROM Orders O
                INNER JOIN Customers C ON O.CustomerID = C.CustomerID
                INNER JOIN Users U ON C.UserID = U.UserID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvProducts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm(); // Replace with your actual login form
            login.Show();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional cell click handler
        }
    }
}
