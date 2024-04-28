using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Organizers : Form
    {
        // MySqlConnection object for MySQL connection
        MySqlConnection conn;

        // MySQL connection string
        string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

        public Organizers()
        {
            InitializeComponent();


            // Initialize MySQL connection
            conn = new MySqlConnection(myConnString);
        }


        private void RegisterOrganizer()
        {
            try
            {
                // Open the connection
                conn.Open();

                // MySQL query to insert data into the 'attendees' table
                string query = "INSERT INTO organizers (OrganizerName, Email, PhoneNumber) " +
                               "VALUES (@oname, @email, @phone)";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@oname", oname.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);


                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Inform the user that registration was successful
                    MessageBox.Show("Organizer Registered!");
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

        private void Organizers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void eve_Click(object sender, EventArgs e)
        {

        }

        private void en_Click(object sender, EventArgs e)
        {

        }

        private void vname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Olist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadData()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;

            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                // MySQL query to select all data from the table 'attendees'
                string query = "SELECT * FROM organizers";

                conn = new MySqlConnection(myConnString);
                conn.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    // Create a new DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the data from the MySQL query
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for the DataGridView
                    Olist.DataSource = dataTable;

                    // Auto resize columns to fit content
                    Olist.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void orgreg_Click(object sender, EventArgs e)
        {
            RegisterOrganizer();
        }

        private void dbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }
    }
}
