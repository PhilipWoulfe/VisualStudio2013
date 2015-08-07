using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mcyclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mcyclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bikesDataSet.mcycles' table. You can move, or remove it, as needed.
            this.mcyclesTableAdapter.Fill(this.bikesDataSet.mcycles);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.bikesDataSet.RejectChanges();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.FillBy(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void selectALlToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.SelectALl(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void forSaleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.ForSale(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lessEq500ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.LessEq500(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void great500ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.Great500(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void soldToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.Sold(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            mcyclesBindingSource.MoveFirst();
            
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            mcyclesBindingSource.MovePrevious();
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            mcyclesBindingSource.MoveNext();
            
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            mcyclesBindingSource.MoveLast();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.FillBy1(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.FillBy2(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.FillBy3(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
