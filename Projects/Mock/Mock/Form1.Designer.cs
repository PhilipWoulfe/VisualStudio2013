namespace Mock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mcyclesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mcyclesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.showAllButton = new System.Windows.Forms.Button();
            this.allForSaleButton = new System.Windows.Forms.Button();
            this.lessEq500CCButton = new System.Windows.Forms.Button();
            this.greater500Button = new System.Windows.Forms.Button();
            this.soldButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mcyclesDataGridView = new System.Windows.Forms.DataGridView();
            this.forSaleToolStrip = new System.Windows.Forms.ToolStrip();
            this.forSaleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lessEq500ToolStrip = new System.Windows.Forms.ToolStrip();
            this.lessEq500ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.great500ToolStrip = new System.Windows.Forms.ToolStrip();
            this.great500ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.soldToolStrip = new System.Windows.Forms.ToolStrip();
            this.soldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcyclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikesDataSet = new Mock.BikesDataSet();
            this.mcyclesTableAdapter = new Mock.BikesDataSetTableAdapters.mcyclesTableAdapter();
            this.tableAdapterManager = new Mock.BikesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mcyclesBindingNavigator)).BeginInit();
            this.mcyclesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcyclesDataGridView)).BeginInit();
            this.forSaleToolStrip.SuspendLayout();
            this.lessEq500ToolStrip.SuspendLayout();
            this.great500ToolStrip.SuspendLayout();
            this.soldToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcyclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mcyclesBindingNavigator
            // 
            this.mcyclesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mcyclesBindingNavigator.BindingSource = this.mcyclesBindingSource;
            this.mcyclesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mcyclesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mcyclesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mcyclesBindingNavigatorSaveItem});
            this.mcyclesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mcyclesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mcyclesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mcyclesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mcyclesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mcyclesBindingNavigator.Name = "mcyclesBindingNavigator";
            this.mcyclesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mcyclesBindingNavigator.Size = new System.Drawing.Size(946, 25);
            this.mcyclesBindingNavigator.TabIndex = 0;
            this.mcyclesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mcyclesBindingNavigatorSaveItem
            // 
            this.mcyclesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mcyclesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mcyclesBindingNavigatorSaveItem.Image")));
            this.mcyclesBindingNavigatorSaveItem.Name = "mcyclesBindingNavigatorSaveItem";
            this.mcyclesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mcyclesBindingNavigatorSaveItem.Text = "Save Data";
            this.mcyclesBindingNavigatorSaveItem.Click += new System.EventHandler(this.mcyclesBindingNavigatorSaveItem_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(57, 403);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(98, 27);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.selectALlToolStripButton_Click);
            // 
            // allForSaleButton
            // 
            this.allForSaleButton.Location = new System.Drawing.Point(161, 403);
            this.allForSaleButton.Name = "allForSaleButton";
            this.allForSaleButton.Size = new System.Drawing.Size(98, 27);
            this.allForSaleButton.TabIndex = 3;
            this.allForSaleButton.Text = "All For Sale";
            this.allForSaleButton.UseVisualStyleBackColor = true;
            this.allForSaleButton.Click += new System.EventHandler(this.forSaleToolStripButton_Click);
            // 
            // lessEq500CCButton
            // 
            this.lessEq500CCButton.Location = new System.Drawing.Point(265, 403);
            this.lessEq500CCButton.Name = "lessEq500CCButton";
            this.lessEq500CCButton.Size = new System.Drawing.Size(98, 27);
            this.lessEq500CCButton.TabIndex = 4;
            this.lessEq500CCButton.Text = "<= 500cc";
            this.lessEq500CCButton.UseVisualStyleBackColor = true;
            this.lessEq500CCButton.Click += new System.EventHandler(this.lessEq500ToolStripButton_Click);
            // 
            // greater500Button
            // 
            this.greater500Button.Location = new System.Drawing.Point(369, 403);
            this.greater500Button.Name = "greater500Button";
            this.greater500Button.Size = new System.Drawing.Size(98, 27);
            this.greater500Button.TabIndex = 5;
            this.greater500Button.Text = "> 500cc";
            this.greater500Button.UseVisualStyleBackColor = true;
            this.greater500Button.Click += new System.EventHandler(this.great500ToolStripButton_Click);
            // 
            // soldButton
            // 
            this.soldButton.Location = new System.Drawing.Point(473, 403);
            this.soldButton.Name = "soldButton";
            this.soldButton.Size = new System.Drawing.Size(98, 27);
            this.soldButton.TabIndex = 6;
            this.soldButton.Text = "Sold";
            this.soldButton.UseVisualStyleBackColor = true;
            this.soldButton.Click += new System.EventHandler(this.soldToolStripButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(704, 403);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 27);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.mcyclesBindingNavigatorSaveItem_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(808, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 27);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(57, 470);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(98, 27);
            this.firstButton.TabIndex = 9;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(161, 470);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(98, 27);
            this.previousButton.TabIndex = 10;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(265, 470);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(98, 27);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(369, 470);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(98, 27);
            this.lastButton.TabIndex = 12;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(808, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 27);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mcyclesDataGridView
            // 
            this.mcyclesDataGridView.AutoGenerateColumns = false;
            this.mcyclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mcyclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.mcyclesDataGridView.DataSource = this.mcyclesBindingSource;
            this.mcyclesDataGridView.Location = new System.Drawing.Point(59, 61);
            this.mcyclesDataGridView.Name = "mcyclesDataGridView";
            this.mcyclesDataGridView.Size = new System.Drawing.Size(812, 293);
            this.mcyclesDataGridView.TabIndex = 13;
            // 
            // forSaleToolStrip
            // 
            this.forSaleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forSaleToolStripButton});
            this.forSaleToolStrip.Location = new System.Drawing.Point(0, 50);
            this.forSaleToolStrip.Name = "forSaleToolStrip";
            this.forSaleToolStrip.Size = new System.Drawing.Size(946, 25);
            this.forSaleToolStrip.TabIndex = 15;
            this.forSaleToolStrip.Text = "forSaleToolStrip";
            this.forSaleToolStrip.Visible = false;
            // 
            // forSaleToolStripButton
            // 
            this.forSaleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forSaleToolStripButton.Name = "forSaleToolStripButton";
            this.forSaleToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.forSaleToolStripButton.Text = "ForSale";
            this.forSaleToolStripButton.Click += new System.EventHandler(this.forSaleToolStripButton_Click);
            // 
            // lessEq500ToolStrip
            // 
            this.lessEq500ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessEq500ToolStripButton});
            this.lessEq500ToolStrip.Location = new System.Drawing.Point(0, 75);
            this.lessEq500ToolStrip.Name = "lessEq500ToolStrip";
            this.lessEq500ToolStrip.Size = new System.Drawing.Size(946, 25);
            this.lessEq500ToolStrip.TabIndex = 16;
            this.lessEq500ToolStrip.Text = "lessEq500ToolStrip";
            this.lessEq500ToolStrip.Visible = false;
            // 
            // lessEq500ToolStripButton
            // 
            this.lessEq500ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lessEq500ToolStripButton.Name = "lessEq500ToolStripButton";
            this.lessEq500ToolStripButton.Size = new System.Drawing.Size(64, 22);
            this.lessEq500ToolStripButton.Text = "LessEq500";
            this.lessEq500ToolStripButton.Click += new System.EventHandler(this.lessEq500ToolStripButton_Click);
            // 
            // great500ToolStrip
            // 
            this.great500ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.great500ToolStripButton});
            this.great500ToolStrip.Location = new System.Drawing.Point(0, 100);
            this.great500ToolStrip.Name = "great500ToolStrip";
            this.great500ToolStrip.Size = new System.Drawing.Size(946, 25);
            this.great500ToolStrip.TabIndex = 17;
            this.great500ToolStrip.Text = "great500ToolStrip";
            this.great500ToolStrip.Visible = false;
            // 
            // great500ToolStripButton
            // 
            this.great500ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.great500ToolStripButton.Name = "great500ToolStripButton";
            this.great500ToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.great500ToolStripButton.Text = "Great500";
            this.great500ToolStripButton.Click += new System.EventHandler(this.great500ToolStripButton_Click);
            // 
            // soldToolStrip
            // 
            this.soldToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soldToolStripButton});
            this.soldToolStrip.Location = new System.Drawing.Point(0, 125);
            this.soldToolStrip.Name = "soldToolStrip";
            this.soldToolStrip.Size = new System.Drawing.Size(946, 25);
            this.soldToolStrip.TabIndex = 18;
            this.soldToolStrip.Text = "soldToolStrip";
            this.soldToolStrip.Visible = false;
            // 
            // soldToolStripButton
            // 
            this.soldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.soldToolStripButton.Name = "soldToolStripButton";
            this.soldToolStripButton.Size = new System.Drawing.Size(34, 22);
            this.soldToolStripButton.Text = "Sold";
            this.soldToolStripButton.Click += new System.EventHandler(this.soldToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stock ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stock ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn2.HeaderText = "Year";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn3.HeaderText = "Make";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Engine size";
            this.dataGridViewTextBoxColumn4.HeaderText = "Engine size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date Sold";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Sold";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Sold";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Sold";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Selling Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Selling Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // mcyclesBindingSource
            // 
            this.mcyclesBindingSource.DataMember = "mcycles";
            this.mcyclesBindingSource.DataSource = this.bikesDataSet;
            // 
            // bikesDataSet
            // 
            this.bikesDataSet.DataSetName = "BikesDataSet";
            this.bikesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mcyclesTableAdapter
            // 
            this.mcyclesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mcyclesTableAdapter = this.mcyclesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mock.BikesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 563);
            this.Controls.Add(this.mcyclesDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.soldButton);
            this.Controls.Add(this.greater500Button);
            this.Controls.Add(this.lessEq500CCButton);
            this.Controls.Add(this.allForSaleButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.mcyclesBindingNavigator);
            this.Controls.Add(this.soldToolStrip);
            this.Controls.Add(this.great500ToolStrip);
            this.Controls.Add(this.lessEq500ToolStrip);
            this.Controls.Add(this.forSaleToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mcyclesBindingNavigator)).EndInit();
            this.mcyclesBindingNavigator.ResumeLayout(false);
            this.mcyclesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcyclesDataGridView)).EndInit();
            this.forSaleToolStrip.ResumeLayout(false);
            this.forSaleToolStrip.PerformLayout();
            this.lessEq500ToolStrip.ResumeLayout(false);
            this.lessEq500ToolStrip.PerformLayout();
            this.great500ToolStrip.ResumeLayout(false);
            this.great500ToolStrip.PerformLayout();
            this.soldToolStrip.ResumeLayout(false);
            this.soldToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcyclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BikesDataSet bikesDataSet;
        private System.Windows.Forms.BindingSource mcyclesBindingSource;
        private BikesDataSetTableAdapters.mcyclesTableAdapter mcyclesTableAdapter;
        private BikesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mcyclesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mcyclesBindingNavigatorSaveItem;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button allForSaleButton;
        private System.Windows.Forms.Button lessEq500CCButton;
        private System.Windows.Forms.Button greater500Button;
        private System.Windows.Forms.Button soldButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView mcyclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStrip forSaleToolStrip;
        private System.Windows.Forms.ToolStripButton forSaleToolStripButton;
        private System.Windows.Forms.ToolStrip lessEq500ToolStrip;
        private System.Windows.Forms.ToolStripButton lessEq500ToolStripButton;
        private System.Windows.Forms.ToolStrip great500ToolStrip;
        private System.Windows.Forms.ToolStripButton great500ToolStripButton;
        private System.Windows.Forms.ToolStrip soldToolStrip;
        private System.Windows.Forms.ToolStripButton soldToolStripButton;
    }
}

