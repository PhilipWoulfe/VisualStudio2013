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
    public partial class Form2 : Form
    {

        SqlConnection vid = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\USERS\\BLUE7\\DOCUMENTS\\PHILIP\\VISUALSTUDIO2013\\PROJECTS\\CARSDATABASE\\CARSDATABASE\\BIN\\DEBUG\\HIRE.MDF;Integrated Security=True;Connect Timeout=30");

        public Form2()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);

        }

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
            this.operatorComboBox.Items.AddRange(new object[] {
                "=",
                ">",
                ">=",
                "<",
                "<="});

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runButton_Click(object sender, EventArgs e)
        {

            try
            {


               
                


                String str = "Select VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available from tblCar WHERE " + fieldComboBox.Text + operatorComboBox.Text + "'" + valueTextBox.Text + "'";
                
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
    }
}
