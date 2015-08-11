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
    public partial class frmCars : Form
    {

        
        // Create Form
        public frmCars()
        {
            InitializeComponent();
            update();
        }

        
        // Unused
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Save Database
        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            try
            {
                this.tblCarBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hireDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
            update();

        }

        // Fill Form 2
        private void Form1_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            update();

        }

        // Unused
        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        // Delete method
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.RemoveCurrent();
            update();
        }

        // Go to first record
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveFirst();
            update();
            
        }

        // Go to previous record
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MovePrevious();
            update();
        }

        // unused method
        private void button10_Click(object sender, EventArgs e)
        {

        }

        // Go to Next Record
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveNext();
            update();
        }

        // Go to Last Record
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveLast();
            update();
        }

        // Exit Application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cancel Method
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.CancelEdit();
            update();
        }

        // Add record
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.tblCarBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            update();
        }

        // Unused
        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        // Method to update the count x of x text box
        private void update()
        {
            try
            {
                recordTextBox.Text = bindingNavigatorPositionItem.Text + " " + bindingNavigatorCountItem.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Unused
        private void rentalPerDayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Open form 2
        private void button4_Click(object sender, EventArgs e)
        {
            frmSearch form = new frmSearch();
            form.Show();
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
