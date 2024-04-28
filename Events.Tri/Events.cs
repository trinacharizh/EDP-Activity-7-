using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Events : Form
    {
        MySqlConnection conn;
        string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";
        public Events()
        {
            InitializeComponent();

            // Initialize MySQL connection
            conn = new MySqlConnection(myConnString);
        }

        private void CreateEvent()
        {
            try
            {
                // Open the connection
                conn.Open();

                // MySQL query to insert data into the 'events' table
                string query = "INSERT INTO events (EventName, EventDate, Location, OrganizerID, VenueID) " +
                               "VALUES (@ename, @evedate, @loc, @orgid, @venid)";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@ename", ename.Text);
                    // Convert the selected date from DateTimePicker to string in MySQL format
                    cmd.Parameters.AddWithValue("@evedate", evedate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@loc", loc.Text);
                    cmd.Parameters.AddWithValue("@orgid", orgid.Text);
                    cmd.Parameters.AddWithValue("@venid", venid.Text);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Inform the user that registration was successful
                    MessageBox.Show("Event Created!");
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

        /* private void Events_Load(object sender, EventArgs e)
         {
             // Initialize MySqlConnection
             conn = new MySqlConnection(myConnString);

             // Load data into DataGridView
             LoadEventsData();
         }
         */
        /*
        private void LoadEventsData()
        {
            try
            {
                // Open the connection
                conn.Open();

                // Query to fetch data from the events table
                string query = "SELECT * FROM events";

                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Load data from the query into the DataTable
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }

                // Bind the DataTable to the DataGridView
                UpdateAcc.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

       */


        /*
        private void LoadEventsData()
        {
            try
            {
                // Open the connection
                conn.Open();

                // Query to fetch data from the events table
                string query = "SELECT * FROM events";

                // Create a MySqlCommand object
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();

                  // Load data from the query into the DataTable
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                // Bind the DataTable to the DataGridView
                UpdateAcc.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        private void LoadEvents(string searchText)
        {
            try
            {
                // Open the connection
                conn.Open();

                // Query to fetch data from the user table
                string query = "SELECT * FROM events";

                // If search text is provided, add a filter to the query
                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " WHERE EventName LIKE @searchText OR Location LIKE @searchText";
                }

                // Create a MySqlCommand object
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // If search text is provided, set parameters
                if (!string.IsNullOrEmpty(searchText))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }

                //Create a DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Load data from the query into the DataTable
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                // Bind the DataTable to the DataGridView
                UpdateAcc.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
      */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void EventForm_Load(object sender, EventArgs e)
        {
            // Initialize MySqlConnection
            conn = new MySqlConnection(myConnString);

            // Load data into DataGridView
            LoadEventsData();
        }
        */

       /* private void btnSearch_Click(object sender, EventArgs e)
        {
            // Trigger search based on the text in the TextBox
            LoadEvents(txtSearch.Text.Trim());


        } */


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void Events_Load_1(object sender, EventArgs e)
        {
            LoadData();//whole form 
        }

        private void LoadData()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;

            string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

            try
            {
                // MySQL query to select all data from the table 'events'
                string query = "SELECT * FROM events";

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
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void eve_Click(object sender, EventArgs e)
        {
            // Events txt 
        }

        private void esearch_TextChanged(object sender, EventArgs e)
        {
            //input search 
        }

        private void aesearch_Click(object sender, EventArgs e)
        {
            // search button 
        }

        private void Tlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // LIST from database 
        }

        private void bgindigo_Click(object sender, EventArgs e)
        {
            // bg indigo 
        }

        private void ename_TextChanged(object sender, EventArgs e)
        {
            // input ename 
        }

        private void edate_TextChanged(object sender, EventArgs e)
        {
            // input edate
        }

        private void loc_TextChanged(object sender, EventArgs e)
        {
            // input location 
        }

        private void venid_TextChanged(object sender, EventArgs e)
        {
            // input ven id 
        }

        private void orgid_TextChanged(object sender, EventArgs e)
        {
            // input org id 
        }

        private void vidd_Click(object sender, EventArgs e)
        {
            // v txt 
        }

        private void evecreate_Click(object sender, EventArgs e)
        {
            // create event and add to databes 
            CreateEvent();

        }

        private void dbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }
    }
}


