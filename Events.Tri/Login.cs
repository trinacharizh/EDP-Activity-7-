
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Events.Tri
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
           
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = this.user.Text;
            string password_hash = this.pass.Text;


            MySql.Data.MySqlClient.MySqlConnection conn;

            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password_hash = @password_hash";

                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password_hash", password_hash);

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        MessageBox.Show("Login successful!");

                        // Check if the logged-in user is admin
                        if (username.ToLower() == "admin")
                        {
                            // Redirect to user management
                            var UserManagement = new UserManagement();
                            UserManagement.Show();
                        }
                        else
                        {
                            // Regular user dashboard
                            var Dashboard = new Dashboard();
                            Dashboard.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /*
                            if (result > 0)
                            {
                                MessageBox.Show("Login successful!");
                                var Dashboard = new Dashboard();
                                Dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                */
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword ForgotPassword = new ForgotPassword();
            ForgotPassword.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
     
