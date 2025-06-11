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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=DANIYALHAIDER\\SQLEXPRESS;Initial Catalog=DBproject;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(connection);

            try
            {
                con.Open();

                string role = comboBox1.SelectedItem.ToString();
                string userID = tbID.Text.Trim();
                string email = tbEmail.Text.Trim();

                SqlCommand cmd;

                if (role == "Customer")
                {
                    string query = @"
                SELECT U.UserID, U.Name, U.Email, C.CustomerID 
                FROM Users U
                JOIN Customers C ON U.UserID = C.UserID
                WHERE U.UserID = @id AND U.Email = @em AND U.Role = @role";

                    cmd = new SqlCommand(query, con);
                }
                else
                {
                    
                    string query = "SELECT * FROM Users WHERE UserID = @id AND Email = @em AND Role = @role";
                    cmd = new SqlCommand(query, con);
                }

                cmd.Parameters.AddWithValue("@id", userID);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@role", role);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login Successful as " + role);

                    int userId = Convert.ToInt32(dr["UserID"]);

                    if (role == "Customer")
                    {
                        int customerId = Convert.ToInt32(dr["CustomerID"]);

                        CustomerForm cf = new CustomerForm();
                        cf.CurrentUserID = userId;
                        cf.CurrentCustomerID = customerId;
                        cf.Show();
                    }
                    else if (role == "Employee")
                    {
                        EmployeeForm ef = new EmployeeForm();
                        ef.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
