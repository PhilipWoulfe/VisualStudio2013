using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarsDatabase
{
    /// <summary>
    /// GUI for frmSearch
    /// </summary>
    public partial class frmSearch : Form
    {
        /// <summary>
        /// Connection to SQL Database
        /// </summary>
        SqlConnection connection;

        /// <summary>
        /// The class constructor
        /// </summary>
        public frmSearch()
        {
            InitializeComponent();
        }


        // Load Form 2
        /// <summary>
        /// Populate cboField and cboOperator on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            
            // add entries to combobox
            this.cboField.Items.AddRange(new object[] {
                "Make",
                "EngineSize",
                "RentalPerDay",
                "Available"});

            // add entries to combobox
            this.cboOperator.Items.AddRange(new object[] {
                "=",
                ">",
                ">=",
                "<",
                "<="});

        }
        
        /// <summary>
        /// Closes the application on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            // clsoe this form
            this.Close();
        }

        /// <summary>
        /// Runs query on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click(object sender, EventArgs e)
        {
            // declare variables
            String field = cboField.Text;
            String op = cboOperator.Text;
            String value = valueTextBox.Text;


            // check if blank
            if (field != "" && op != "" && value != "")
            {
                try
                {
                    // Connect to Database
                    connection = new SqlConnection(@"Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|/hire.mdf;Integrated Security=True;Connect Timeout=30");

                }

                catch (Exception c)
                {
                    // show error
                    MessageBox.Show(c.Message);
                }

                // Run query through connection
                String queryString = "Select VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available from tblCar WHERE " + field + op + "'" + value + "'";
                
                // create new data adaptor
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
               
                // create new datatable
                DataTable cars = new DataTable();

                try
                {
                    // fill dataTable with data adaptor
                    adapter.Fill(cars);
                }
                catch (Exception ex)
                {
                    // display error
                    MessageBox.Show(ex.Message);
                }

                // assihn datatable to dataGrid
                dataGridView1.DataSource = cars;


            }
            else
            {
                // show error
                MessageBox.Show("No field can be blank.");
            }
        }
    }
}
