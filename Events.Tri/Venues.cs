using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Events.Tri
{
    public partial class Venues : Form
    {
        // MySqlConnection object for MySQL connection
        MySqlConnection conn;

        // MySQL connection string
        string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

        public Venues()
        {
            InitializeComponent();

            // Initialize MySQL connection
            conn = new MySqlConnection(myConnString);

        }

        private void AddEvent()
        {
            try
            {
                // Open the connection
                conn.Open();

                // MySQL query to insert data into the 'attendees' table
                string query = "INSERT INTO venues (VenueName, Capacity, Location) " +
                               "VALUES (@vname, @capacity, @loc)";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@vname", vname.Text);
                    cmd.Parameters.AddWithValue("@capacity", capacity.Text);
                    cmd.Parameters.AddWithValue("@loc", loc.Text);
                   

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Inform the user that registration was successful
                    MessageBox.Show("Venue Added!");
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

        private void bgindigo_Click(object sender, EventArgs e)
        {

        }

        private void evedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lcn_Click(object sender, EventArgs e)
        {

        }

        private void cap_Click(object sender, EventArgs e)
        {

        }

        private void Venues_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;

            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                // MySQL query to select all data from the table 'attendees'
                string query = "SELECT * FROM venues";

                conn = new MySqlConnection(myConnString);
                conn.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    // Create a new DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the data from the MySQL query
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for the DataGridView
                    Tlist.DataSource = dataTable;

                    // Auto resize columns to fit content
                    Tlist.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Tlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vname_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void addven_Click(object sender, EventArgs e)
        {
            AddEvent();

        }

        private void dbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }

        private void loga_Click(object sender, EventArgs e)
        {

        }

        private void locloc_Click(object sender, EventArgs e)
        {

        }

        private void en_Click(object sender, EventArgs e)
        {

        }

        private void loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void aesearch_Click(object sender, EventArgs e)
        {

        }

        private void esearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void eve_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
