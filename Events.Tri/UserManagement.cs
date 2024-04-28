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
    public partial class UserManagement : Form
    {
        MySqlConnection conn;
        string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";
        public UserManagement()
        {
            InitializeComponent();
        }

        private void Accounts_Click(object sender, EventArgs e)
        {

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // Initialize MySqlConnection
            conn = new MySqlConnection(myConnString);

            // Load data into DataGridView
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                // Open the connection
                conn.Open();

                // Query to fetch data from the user table
                string query = "SELECT * FROM users";

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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUsers(string searchText)
        {
            try
            {
                // Open the connection
                conn.Open();

                // Query to fetch data from the user table
                string query = "SELECT * FROM users";

                // If search text is provided, add a filter to the query
                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " WHERE username LIKE @searchText OR email LIKE @searchText";
                }

                // Create a MySqlCommand object
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // If search text is provided, set parameters
                if (!string.IsNullOrEmpty(searchText))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }

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
        /*try
        {
            // Open the connection
            conn.Open();

            // Query to fetch data from the user table
            string query = "SELECT * FROM users";

            // If search text is provided, add a filter to the query
            if (!string.IsNullOrEmpty(searchText))
            {
                query += " WHERE username LIKE @searchText OR email LIKE @searchText";
            }

            // Create a MySqlCommand object
            MySqlCommand cmd = new MySqlCommand(query, conn);

            // If search text is provided, set parameters
            if (!string.IsNullOrEmpty(searchText))
            {
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
            }

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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve the search text from the textbox
            string searchText = txtSearch.Text.Trim();

            // Call the LoadUsers method to fetch and display the search results
            LoadUsers(searchText);

            // Trigger search based on the text in the TextBox
            // (txtSearch.Text.Trim());

        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // Initialize MySqlConnection
            conn = new MySqlConnection(myConnString);

            // Load data into DataGridView
            LoadUserData();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Trigger search based on the text in the TextBox
            LoadUsers(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UpdateAccount UpdateAccount = new UpdateAccount();
            UpdateAccount.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }
    }
}


