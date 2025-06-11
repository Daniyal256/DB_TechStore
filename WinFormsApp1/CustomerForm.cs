using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class CustomerForm : Form
    {
        private string connectionString = @"Data Source=DANIYALHAIDER\SQLEXPRESS;Initial Catalog=DBproject;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
        public int CurrentUserID { get; set; }
        public int CurrentCustomerID { get; set; }
        private void btnCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Enter a Product ID.");
                return;
            }

            int productId = int.Parse(tbName.Text);
            int quantity = (int)Quantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            DataRowView? selectedRow = null;

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (!row.IsNewRow && row.Cells["ID"].Value != null && Convert.ToInt32(row.Cells["ID"].Value) == productId)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        selectedRow = drv;
                        break;
                    }
                }
            }


            if (selectedRow == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            string productName = selectedRow["Name"].ToString();
            decimal price = Convert.ToDecimal(selectedRow["Price"]);
            decimal subtotal = price * quantity;

            dgvOrders.Rows.Add(productName, quantity, price, subtotal);

            UpdateTotalAmount();
        }
        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (!row.IsNewRow && row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            tbTotal.Text = total.ToString("F2");
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            decimal totalAmount;
            if (!decimal.TryParse(tbTotal.Text, out totalAmount))
            {
                MessageBox.Show("Invalid total amount.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, Status)
                VALUES (@CustomerID, @OrderDate, @TotalAmount, @Status);
                SELECT SCOPE_IDENTITY();", conn);

                    cmd.Parameters.AddWithValue("@CustomerID", this.CurrentCustomerID);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@Status", "Pending");

                    int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show($"Order placed successfully. Order ID: {orderId}");

                    dgvOrders.Rows.Clear();
                    tbTotal.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
        }


        private void InitializeMyOrdersTab()
        {
            // Set up the DataGridView for orders
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns.Add("OrderDate", "Order Date");
            dgvOrders.Columns.Add("TotalAmount", "Total Amount");
            dgvOrders.Columns.Add("Status", "Status");

            // Set up the search and filter functionality
            txtSearchOrders.TextChanged += TxtSearchOrders_TextChanged;
            cmdFilterStatus.Click += CmdFilterStatus_Click;

            // Set up order selection
            dgvOrders.SelectionChanged += DgvMyOrders_SelectionChanged;

            // Load initial data
            LoadCustomerOrders();
        }

        private void LoadCustomerOrders(string statusFilter = "", string searchText = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT OrderID, OrderDate, TotalAmount, Status 
                FROM Orders 
                WHERE CustomerID = @CustomerID";

                    // Add filters if provided
                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        query += " AND Status = @Status";
                    }

                    if (!string.IsNullOrEmpty(searchText) && int.TryParse(searchText, out int orderId))
                    {
                        query += " AND OrderID = @OrderID";
                    }

                    query += " ORDER BY OrderDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", this.CurrentCustomerID);

                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        cmd.Parameters.AddWithValue("@Status", statusFilter);
                    }

                    if (!string.IsNullOrEmpty(searchText) && int.TryParse(searchText, out orderId))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvOrders.Rows.Clear();

                    while (reader.Read())
                    {
                        dgvOrders.Rows.Add(
                            reader["OrderID"],
                            Convert.ToDateTime(reader["OrderDate"]).ToString("d"),
                            Convert.ToDecimal(reader["TotalAmount"]).ToString("C"),
                            reader["Status"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get order header information
                    string orderQuery = @"
                SELECT OrderID, OrderDate, TotalAmount, Status 
                FROM Orders 
                WHERE OrderID = @OrderID AND CustomerID = @CustomerID";

                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn);
                    orderCmd.Parameters.AddWithValue("@OrderID", orderId);
                    orderCmd.Parameters.AddWithValue("@CustomerID", this.CurrentCustomerID);

                    SqlDataReader orderReader = orderCmd.ExecuteReader();

                    if (orderReader.Read())
                    {
                        label13.Text = orderReader["OrderID"].ToString();
                        label12.Text = Convert.ToDateTime(orderReader["OrderDate"]).ToString("d");
                        label11.Text = orderReader["Status"].ToString();
                        label10.Text = "Paid"; // Assuming all orders are paid in your system
                        label9.Text = Convert.ToDecimal(orderReader["TotalAmount"]).ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Order not found.");
                        return;
                    }

                    orderReader.Close();

                    // Get order items
                    string itemsQuery = @"
                SELECT P.Name, OD.Quantity, OD.UnitPrice, (OD.Quantity * OD.UnitPrice) AS LineTotal
                FROM OrderDetails OD
                JOIN Products P ON OD.ProductID = P.ProductID
                WHERE OD.OrderID = @OrderID";

                    SqlCommand itemsCmd = new SqlCommand(itemsQuery, conn);
                    itemsCmd.Parameters.AddWithValue("@OrderID", orderId);

                    SqlDataAdapter adapter = new SqlDataAdapter(itemsCmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // You can display the items in another DataGridView if you want
                    // For now, we'll just show the header info
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order details: " + ex.Message);
            }
        }

        private void TxtSearchOrders_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerOrders("", txtSearchOrders.Text);
        }

        private void CmdFilterStatus_Click(object sender, EventArgs e)
        {
            // You can create a dropdown or other control for status selection
            // For simplicity, we'll just filter by "Pending" status
            LoadCustomerOrders("Pending", "");
        }

        private void DgvMyOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);
                LoadOrderDetails(orderId);
                panelOrderDetails.Visible = true;
            }
            else
            {
                panelOrderDetails.Visible = false;
            }
        }

        // Add this to your form's constructor, after InitializeComponent()
        public CustomerForm()
        {
            InitializeComponent();
            InitializeMyOrdersTab(); // Add this line
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
                    P.ProductID AS ID,
                    P.Name,
                    B.Name AS Brand,
                    C.Name AS Category,
                    P.StockQty AS Stock,
                    P.Price
                FROM Products P
                INNER JOIN Brands B ON P.BrandID = B.BrandID
                INNER JOIN Categories C ON P.CategoryID = C.CategoryID
                WHERE P.StockQty > 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Assume these are set during login and stored as class-level variables
                    int userId = this.CurrentUserID;
                    int customerId = this.CurrentCustomerID;

                    // Get updated values
                    string name = tbName.Text.Trim();
                    string phone = tbPhone.Text.Trim();
                    string email = tbEmail.Text.Trim();
                    string address = tbAddress.Text.Trim();

                    // 1. Update Users table
                    string userUpdateQuery = @"
                UPDATE Users
                SET Name = @Name, Phone = @Phone, Email = @Email
                WHERE UserID = @UserID";

                    SqlCommand cmdUser = new SqlCommand(userUpdateQuery, conn);
                    cmdUser.Parameters.AddWithValue("@Name", name);
                    cmdUser.Parameters.AddWithValue("@Phone", phone);
                    cmdUser.Parameters.AddWithValue("@Email", email);
                    cmdUser.Parameters.AddWithValue("@UserID", userId);
                    cmdUser.ExecuteNonQuery();

                    // 2. Update Customers table
                    string customerUpdateQuery = @"
                UPDATE Customers
                SET Address = @Address
                WHERE CustomerID = @CustomerID";

                    SqlCommand cmdCustomer = new SqlCommand(customerUpdateQuery, conn);
                    cmdCustomer.Parameters.AddWithValue("@Address", address);
                    cmdCustomer.Parameters.AddWithValue("@CustomerID", customerId);
                    cmdCustomer.ExecuteNonQuery();

                    MessageBox.Show("Profile updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating profile: " + ex.Message);
                }
            }
        }

    }
}
