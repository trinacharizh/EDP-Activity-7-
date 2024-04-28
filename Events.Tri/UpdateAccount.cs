using Events.Tri;
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
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }

        private void signuptext_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement UserManagement = new UserManagement();
            UserManagement.Show();
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string user_id = this.usrid.Text;
                string username = this.upun.Text;
                string password_hash = this.uppw.Text;
                string first_name = this.upfn.Text;
                string last_name = this.upln.Text;
                string email = this.upem.Text;
                string status = this.upst.Text;

                string sql = "UPDATE users SET username = @username, password_hash = @password_hash, first_name = @first_name, last_name = @last_name,  email = @email, status = @status WHERE user_id = @user_id";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password_hash", password_hash);
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@user_id", user_id);

                int rowsAffected = command.ExecuteNonQuery(); // Execute the update query

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Success!");
                    var UserManagement = new UserManagement();
                    UserManagement.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No user found with the specified ID."); // Handle the case where no user was updated
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

