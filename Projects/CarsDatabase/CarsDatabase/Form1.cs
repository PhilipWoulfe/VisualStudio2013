using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CarsDatabase
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            update();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            //// Create a new row.
            //HireDataSet.tblCarRow newtblCarRow;

            //try
            //{

            //    newtblCarRow = hireDataSet.tblCar.NewtblCarRow();
            //    newtblCarRow.VehicleRegNo = vehicleRegNoTextBox.ToString(); ;
            //    newtblCarRow.Make = makeTextBox.ToString();
            //    newtblCarRow.EngineSize = engineSizeTextBox.ToString();
            //    MessageBox.Show(dateRegisteredTextBox.ToString());
            //    newtblCarRow.DateRegistered = DateTime.ParseExact(dateRegisteredTextBox.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture); ;
            //    newtblCarRow.RentalPerDay = (decimal)(int.Parse(rentalPerDayTextBox.ToString().Substring(rentalPerDayTextBox.ToString().IndexOf("£"))));
            //    newtblCarRow.Available = bool.Parse(availableCheckBox.ToString());

            //    // Add the row to the Region table 
            //    this.hireDataSet.tblCar.Rows.Add(newtblCarRow);

            //    // Save the new row to the database 
            //    this.tblCarTableAdapter.Update(this.hireDataSet.tblCar);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "Error");
            //}

            
            
            
            try
            {
                this.tblCarBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hireDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            update();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            update();

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.RemoveCurrent();
            update();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveFirst();
            update();
            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MovePrevious();
            update();
        }

        // unused method
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveNext();
            update();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveLast();
            update();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.CancelEdit();
            update();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.tblCarBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            update();
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void update()
        {
            try
            {
                textBox6.Text = bindingNavigatorPositionItem.Text + " " + bindingNavigatorCountItem.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            //if (!rentalPerDayTextBox.Text.StartsWith("£"))
            //{
            //    rentalPerDayTextBox.Text = "£" + rentalPerDayTextBox.Text;
            //}
            
            
        }

        private void rentalPerDayTextBox_TextChanged(object sender, EventArgs e)
        {




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
