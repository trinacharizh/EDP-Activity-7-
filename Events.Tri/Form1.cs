using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events.Tri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signups_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = this.usrname.Text;
            string password_hash = this.pwword.Text;
            string first_name = this.firstname.Text;
            string last_name = this.lastname.Text;
            string email = this.email.Text;


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string sql = "INSERT INTO users (username, password_hash, first_name, last_name, email) VALUES (@username, @password_hash, @first_name, @last_name, @email)";

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password_hash", password_hash);
                command.Parameters.AddWithValue("@email", email);

                int rowsAffected = command.ExecuteNonQuery(); // Execute the insert query

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Success!");
                    var Dashboard = new Dashboard();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please try again."); // Handle potential errors
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void signuptext_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pwword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usrname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}






