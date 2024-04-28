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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            string oldpass = this.oldpass.Text;
            string newpass = this.newpass.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string sql = "UPDATE users SET password_hash = @newpass WHERE password_hash = @oldpass";

                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                    command.Parameters.AddWithValue("@oldpass", oldpass);
                    command.Parameters.AddWithValue("@newpass", newpass);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password Changed Successfully");
                        this.Hide();
                        LoginPage login = new LoginPage();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password change failed. Please ensure your old password is correct.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
