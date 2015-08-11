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
    public partial class frmSearch : Form
    {

        SqlConnection vid;

        // Create Form
        public frmSearch()
        {
            InitializeComponent();
        }

        // Update Method
        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);

        }

        // Load Form 2
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            this.cboField.Items.AddRange(new object[] {
                "Make",
                "EngineSize",
                "RentalPerDay",
                "Available"});

            this.cboOperator.Items.AddRange(new object[] {
                "=",
                ">",
                ">=",
                "<",
                "<="});

        }

        // Add record to database
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        // Unused
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Close Application
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Run Query
        private void runButton_Click(object sender, EventArgs e)
        {
            loadDataSet();
        }

        // unused
        private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // load information into data grid view
        private void loadDataSet()
        {
            String field = cboField.Text;
            String op = cboOperator.Text;
            String value = valueTextBox.Text;

            try
            {
                // Connect to Database
                vid = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\USERS\\BLUE7\\DOCUMENTS\\PHILIP\\VISUALSTUDIO2013\\PROJECTS\\CARSDATABASE\\CARSDATABASE\\BIN\\DEBUG\\HIRE.MDF;Integrated Security=True;Connect Timeout=30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // check if blank
            if (field != "" && op != "" && value != "")
            {
                try
                {

                    String str = "Select VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available from tblCar WHERE " + field + op + "'" + value + "'";

                    SqlCommand xp = new SqlCommand(str, vid);


                    vid.Open();
                    xp.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = xp;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }

                finally
                {
                    vid.Close();
                }
            }
            else
            {
                MessageBox.Show("No field can be blank.");
            }
        }
    }
}
