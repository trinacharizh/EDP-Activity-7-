using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using System.IO;

namespace Events.Tri
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            comboBoxReportType.SelectedIndexChanged += comboBoxReportType_SelectedIndexChanged;
            exportbtn.Click += exportbtn_Click;
            // Set the LicenseContext to suppress the license exception
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReportType = comboBoxReportType.SelectedItem.ToString();

            switch (selectedReportType)
            {
                case "Events":
                    DisplayEventsData();
                    break;
                case "Venues":
                    DisplayVenuesData();
                    break;
                case "Events Log":
                    DisplayEventsLogData();
                    break;
                case "Organizers":
                    DisplayOrganizersData();
                    break;
                case "Attendees":
                    DisplayAttendeesData();
                    break;
            }
        }
        private void DisplayEventsData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=trina;database=events_organizer;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM events", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying recent login data: " + ex.Message);
            }
        }

        private void DisplayVenuesData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=trina;database=events_organizer;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM venues", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying recent login data: " + ex.Message);
            }
        }
        private void DisplayEventsLogData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=trina;database=events_organizer;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eventlog", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying recent login data: " + ex.Message);
            }
        }
        private void DisplayOrganizersData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=trina;database=events_organizer;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM organizers", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying recent login data: " + ex.Message);
            }
        }

        private void DisplayAttendeesData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=trina;database=events_organizer;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM attendees", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying recent login data: " + ex.Message);
            }
        }


        private void exportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (.xlsx)|.xlsx|All files (.)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet ws = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Add signature placeholder
                        ws.Cells["A5"].Value = "Signed by:";
                        ws.Cells["B5"].Value = "_______________"; // Placeholder for the user's signature


                        // Save the logo image to a temporary file with a valid image extension
                        string tempLogoPath = Path.GetTempFileName();
                        tempLogoPath = Path.ChangeExtension(tempLogoPath, ".png");
                        logo.Image.Save(tempLogoPath, System.Drawing.Imaging.ImageFormat.Png);

                        // Add the logo image to cell A3 with size 50px
                        ExcelPicture logoPicture = ws.Drawings.AddPicture("Logo", new FileInfo(tempLogoPath));
                        logoPicture.SetPosition(1, 0, 0, 0); // Position at cell A3 with size 50px
                        logoPicture.SetSize(70, 70);

                        // Get the brand name from Label
                        string brandName = systemName.Text;

                        // Insert brand name into cell B3 and set font
                        ws.Cells["B3"].Value = brandName;
                        ws.Cells["B3"].Style.Font.Name = "Palatino Linotype";
                        ws.Cells["B3"].Style.Font.Size = 20.8f;
                        ws.Cells["B3"].Style.Font.Bold = true;
                        ws.Cells["A7"].LoadFromDataTable((DataTable)reportlist.DataSource, true);

                        // Auto-fit columns
                        ws.Cells[ws.Dimension.Address].AutoFitColumns();


                        // Protect the worksheet to make it not editable
                        ws.Protection.IsProtected = true;
                        ws.Protection.AllowSelectLockedCells = true; // Allow selecting locked cells
                        ws.Protection.SetPassword("owner"); // Set a password to protect the worksheet

                        // Create a new worksheet for the graph
                        ExcelWorksheet wsGraph = excelPackage.Workbook.Worksheets.Add("Sheet2");

                        

                      // Generate a sample graph (you can replace this with your actual graph generation code)
                       ExcelChart chart = wsGraph.Drawings.AddChart("Chart", eChartType.Pie); // Change chart type to Pie
                       chart.SetPosition(1, 0, 0, 0);
                       chart.SetSize(700, 500);
                       chart.Title.Text = "Report"; // Change title if necessary

                       // Example data range for the graph (replace with actual data)
                       chart.Series.Add(ws.Cells["A8:A30"], ws.Cells["B8:B30"]);
                        
                       // Save Excel file
                       excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Data exported successfully!");

                        // Protect the worksheet to make it not editable
                        ws.Protection.IsProtected = true;
                        ws.Protection.AllowSelectLockedCells = true; // Allow selecting locked cells
                        ws.Protection.SetPassword("owner"); // Set a password to protect the worksheet


                        // Dispose the SaveFileDialog
                        saveFileDialog.Dispose();

                        // Delete the temporary logo file
                        File.Delete(tempLogoPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        } 
       

        /*
        private void exportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (.xlsx)|.xlsx|All files (.)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet ws = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Save the logo image to a temporary file with a valid image extension
                        string tempLogoPath = System.IO.Path.GetTempFileName();
                        tempLogoPath = System.IO.Path.ChangeExtension(tempLogoPath, ".png");
                        logo.Image.Save(tempLogoPath, System.Drawing.Imaging.ImageFormat.Png);

                        // Add the logo image to cell A3 with size 50px
                        ExcelPicture logoPicture = ws.Drawings.AddPicture("Logo", new System.IO.FileInfo(tempLogoPath));
                        logoPicture.SetPosition(1, 0, 0, 0); // Position at cell A3 with size 50px
                        logoPicture.SetSize(70, 70);

                        // Get the brand name from Label
                        string brandName = systemName.Text;

                        // Insert brand name into cell B3 and set font
                        ws.Cells["B3"].Value = brandName;
                        ws.Cells["B3"].Style.Font.Name = "Palatino Linotype";
                        ws.Cells["B3"].Style.Font.Size = 20.8f;
                        ws.Cells["B3"].Style.Font.Bold = true;

                        // Export DataGridView data to Excel
                        ws.Cells["A7"].LoadFromDataTable((DataTable)reportlist.DataSource, true);
                         
                        // Save Excel file
                        excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Data exported successfully!");

                        // Dispose the SaveFileDialog
                        saveFileDialog.Dispose();

                        // Delete the temporary logo file
                        System.IO.File.Delete(tempLogoPath);
                    }
                }
            }
            catch (LicenseException)
            {
                MessageBox.Show("EPPlus license is invalid. Please make sure you are using a valid license.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        } */
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // data grid 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //events button 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void atten_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events_Report Events_Report = new Events_Report();
            Events_Report.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exportbtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
