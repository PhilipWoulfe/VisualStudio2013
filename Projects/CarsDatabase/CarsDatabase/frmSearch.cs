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
        // Connect to Database
        SqlConnection vid = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\USERS\\BLUE7\\DOCUMENTS\\PHILIP\\VISUALSTUDIO2013\\PROJECTS\\CARSDATABASE\\CARSDATABASE\\BIN\\DEBUG\\HIRE.MDF;Integrated Security=True;Connect Timeout=30");

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
            this.fieldComboBox.Items.AddRange(new object[] {
                "VehicleRegNo",
                "Make",
                "EngineSize",
                "DateRegistered",
                "RentalPerDay",
                "Available"});

            

            fieldComboBox.SelectedIndex = 0;
            operatorComboBox.SelectedIndex = 0;
            
            
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "Select TOP 1" + fieldComboBox.Text + " from tblCar";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = vid;

            try
            {

                vid.Open();

                returnValue = cmd.ExecuteScalar();
                valueTextBox.Text = returnValue.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                vid.Close();
            }

            
            loadDataSet();

            
            

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

        private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fieldComboBox.Text == "VehicleRegNo" || fieldComboBox.Text == "Make" || fieldComboBox.Text == "Available")
            {
                // Clear combo box
                this.operatorComboBox.Items.Clear();

                // populate with symbols
                this.operatorComboBox.Items.AddRange(new object[] {
                "="
                });
            } else if (fieldComboBox.Text == "EngineSize" || fieldComboBox.Text == "DateRegistered" || fieldComboBox.Text == "RentalPerDay")
            {
                // clear combo box
                this.operatorComboBox.Items.Clear();

                // populate with symbols
                this.operatorComboBox.Items.AddRange(new object[] {
                "=",
                ">",
                ">=",
                "<",
                "<="});
            }
        }

        // load information into data grid view
        private void loadDataSet()
        {
            String field = fieldComboBox.Text;
            String op = operatorComboBox.Text;
            String value = valueTextBox.Text;

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
