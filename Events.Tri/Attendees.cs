using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events.Tri
{
    public partial class Attendees : Form
    {
        // MySqlConnection object for MySQL connection
        MySqlConnection conn;

        // MySQL connection string
        string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

        public Attendees()
        {
            InitializeComponent();

            // Initialize MySQL connection
            conn = new MySqlConnection(myConnString);
        }
        private void RegisterAttendee()
        {
            try
            {
                // Open the connection
                conn.Open();

                // MySQL query to insert data into the 'attendees' table
                string query = "INSERT INTO attendees (FirstName, LastName, EventID, RegistrationDate, Email) " +
                               "VALUES (@Fname, @Lname, @Eid, @RegDate, @Email)";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@Fname", fname.Text);
                    cmd.Parameters.AddWithValue("@Lname", lname.Text);
                    cmd.Parameters.AddWithValue("@Eid", eid.Text);
                    // Convert the selected date from DateTimePicker to string in MySQL format
                    cmd.Parameters.AddWithValue("@RegDate", regdate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Email", email.Text);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Inform the user that registration was successful
                    MessageBox.Show("Registration successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // design black
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // pink up
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //logo pic
        }

        private void dba_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }

        private void loga_Click(object sender, EventArgs e)
        {
            //log out
        }

        private void attend_Click(object sender, EventArgs e)
        {
            //text
        }

        private void UpdateAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Attendees_Load(object sender, EventArgs e)
        {
            LoadData();//whole form 
        }
        private void LoadData()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;

            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                // MySQL query to select all data from the table 'attendees'
                string query = "SELECT * FROM attendees";

                conn = new MySqlConnection(myConnString);
                conn.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    // Create a new DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the data from the MySQL query
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for the DataGridView
                    Alist.DataSource = dataTable;

                    // Auto resize columns to fit content
                    Alist.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void asearch_TextChanged(object sender, EventArgs e)
        {
            // search attendees
        }

        private void absearch_Click(object sender, EventArgs e)
        {
            // button search
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //fn input
        }

        private void fn_Click(object sender, EventArgs e)
        {
            //txt
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            //ln input
        }

        private void eid_TextChanged(object sender, EventArgs e)
        {
            // e id input
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // TXT REG DATE
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // input reg date 
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            // em input
        }

        private void eml_Click(object sender, EventArgs e)
        {
            // txt em
        }

        private void Register_Click(object sender, EventArgs e)
        {
            // Call the RegisterAttendee method to insert the data
            RegisterAttendee();
        }
    }
}
