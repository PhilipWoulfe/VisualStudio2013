// XMLsample.cs
// compile with: /doc:XMLsample.xml

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
    /// <summary>
    /// Main GUI for the carsDatabaase
    /// </summary>
    public partial class frmCars : Form
    {


        /// <summary>
        /// The class constructor
        /// </summary>
        public frmCars()
        {
            InitializeComponent();
            update();
        }

        /// <summary>
        /// Update database with current dataset on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Validate();

            try
            {
                // end edit
                this.tblCarBindingSource.EndEdit();
                
                // update database
                this.tableAdapterManager.UpdateAll(this.hireDataSet);
            }
            catch (Exception ex)
            {
                // show error
                MessageBox.Show(ex.Message, "Error");
            }
            // update record box
            update();

        }

        /// <summary>
        /// Populate frmCars on load from dataset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            // update record box
            update();

        }

        /// <summary>
        /// Delete current record on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // delete current record
            tblCarBindingSource.RemoveCurrent();
            // update record box
            update();
        }

        /// <summary>
        /// Go to first record on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstButton_Click(object sender, EventArgs e)
        {
            // go to first record
            tblCarBindingSource.MoveFirst();
            // update record box
            update();
            
        }

        /// <summary>
        /// Go to previous record on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousButton_Click(object sender, EventArgs e)
        {
            // go to previous record
            tblCarBindingSource.MovePrevious();
            // update record box
            update();
        }

        /// <summary>
        /// Go to Next Record on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            // go to next record
            tblCarBindingSource.MoveNext();
            // update record box
            update();
        }

        /// <summary>
        /// Go to Last Record on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastButton_Click(object sender, EventArgs e)
        {
            // go to last record
            tblCarBindingSource.MoveLast();
            // update record box
            update();
        }

        /// <summary>
        /// Exits Application on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit program
            this.Close();
        }

        /// <summary>
        /// Cancels current edit on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // cancel update
            this.tblCarBindingSource.CancelEdit();
            update();
        }

        /// <summary>
        /// Adds new blank record to database on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // add new record
                this.tblCarBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                // show error
                MessageBox.Show(ex.Message);
            }

            update();
        }

        /// <summary>
        /// Method to update the count x of x text box
        /// </summary>
        private void update()
        {
            try
            {
                // update record box
                recordTextBox.Text = bindingNavigatorPositionItem.Text + " " + bindingNavigatorCountItem.Text.ToString();
            }
            catch (Exception ex)
            {
                // show error
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Method to open frmSearch on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            // open new form
            frmSearch form = new frmSearch();
            // display form
            form.Show();
        }

    }
}
