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
    public partial class Dashboard : Form
    {
        // MySqlConnection object for MySQL connection
        MySqlConnection conn;

        // MySQL connection string
        string myConnString = "server=localhost;user=root;password=trina;database=events_organizer;";

        public Dashboard()
        {
            InitializeComponent();
            // Initialize MySQL connection
            conn = new MySqlConnection(myConnString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report Report = new Report();
            Report.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            UserManagement user = new UserManagement();
            user.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            Organizers Organizers = new Organizers();
            Organizers.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountAndDisplayEvents();
        }
        private void CountAndDisplayEvents()
        {
            try
            {
                // Open the connection
                conn.Open();

                // MySQL query to count the number of events
                string query = "SELECT COUNT(*) FROM events";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute the query and get the result
                    int eventCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    eventcount.Text = eventCount.ToString();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Events Events = new Events();
            Events.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Attendees Attendees = new Attendees();
            Attendees.Show();
            this.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Venues Venues = new Venues();
            Venues.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void eventcount_Click(object sender, EventArgs e)
        {

        }
    }
}

