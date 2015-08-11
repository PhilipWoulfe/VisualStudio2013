namespace CarsDatabase
{
    partial class frmCars
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
            System.Windows.Forms.Label vehicleRegNoLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label dateRegisteredLabel;
            System.Windows.Forms.Label rentalPerDayLabel;
            System.Windows.Forms.Label availableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCars));
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.recordTextBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.hireDataSet = new CarsDatabase.HireDataSet();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarTableAdapter = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            this.vehicleRegNoTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.dateRegisteredTextBox = new System.Windows.Forms.TextBox();
            this.rentalPerDayTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.tblCarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tmep = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblCarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            vehicleRegNoLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            engineSizeLabel = new System.Windows.Forms.Label();
            dateRegisteredLabel = new System.Windows.Forms.Label();
            rentalPerDayLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).BeginInit();
            this.tblCarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleRegNoLabel
            // 
            vehicleRegNoLabel.AutoSize = true;
            vehicleRegNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            vehicleRegNoLabel.Location = new System.Drawing.Point(53, 101);
            vehicleRegNoLabel.Name = "vehicleRegNoLabel";
            vehicleRegNoLabel.Size = new System.Drawing.Size(123, 20);
            vehicleRegNoLabel.TabIndex = 25;
            vehicleRegNoLabel.Text = "Vehicle Reg No:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            makeLabel.Location = new System.Drawing.Point(53, 137);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(52, 20);
            makeLabel.TabIndex = 27;
            makeLabel.Text = "Make:";
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            engineSizeLabel.Location = new System.Drawing.Point(53, 173);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(98, 20);
            engineSizeLabel.TabIndex = 29;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // dateRegisteredLabel
            // 
            dateRegisteredLabel.AutoSize = true;
            dateRegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dateRegisteredLabel.Location = new System.Drawing.Point(53, 209);
            dateRegisteredLabel.Name = "dateRegisteredLabel";
            dateRegisteredLabel.Size = new System.Drawing.Size(130, 20);
            dateRegisteredLabel.TabIndex = 31;
            dateRegisteredLabel.Text = "Date Registered:";
            // 
            // rentalPerDayLabel
            // 
            rentalPerDayLabel.AutoSize = true;
            rentalPerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            rentalPerDayLabel.Location = new System.Drawing.Point(53, 245);
            rentalPerDayLabel.Name = "rentalPerDayLabel";
            rentalPerDayLabel.Size = new System.Drawing.Size(120, 20);
            rentalPerDayLabel.TabIndex = 33;
            rentalPerDayLabel.Text = "Rental Per Day:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            availableLabel.Location = new System.Drawing.Point(53, 280);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(76, 20);
            availableLabel.TabIndex = 35;
            availableLabel.Text = "Available:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(465, 87);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(85, 39);
            this.updateButton.TabIndex = 13;
            this.updateButton.TabStop = false;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.tblCarBindingNavigatorSaveItem_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(465, 130);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 39);
            this.addButton.TabIndex = 14;
            this.addButton.TabStop = false;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(465, 173);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 39);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(465, 216);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 39);
            this.searchButton.TabIndex = 16;
            this.searchButton.TabStop = false;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(465, 259);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 39);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(465, 302);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 39);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(32, 357);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(76, 39);
            this.firstButton.TabIndex = 19;
            this.firstButton.TabStop = false;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // recordTextBox
            // 
            this.recordTextBox.AcceptsReturn = true;
            this.recordTextBox.Location = new System.Drawing.Point(196, 367);
            this.recordTextBox.Name = "recordTextBox";
            this.recordTextBox.ReadOnly = true;
            this.recordTextBox.Size = new System.Drawing.Size(105, 20);
            this.recordTextBox.TabIndex = 21;
            this.recordTextBox.TabStop = false;
            this.recordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recordTextBox.TextChanged += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(114, 357);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(76, 39);
            this.previousButton.TabIndex = 22;
            this.previousButton.TabStop = false;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(389, 357);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(76, 39);
            this.lastButton.TabIndex = 24;
            this.lastButton.TabStop = false;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(307, 357);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(76, 39);
            this.nextButton.TabIndex = 23;
            this.nextButton.TabStop = false;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "tblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vehicleRegNoTextBox
            // 
            this.vehicleRegNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.vehicleRegNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vehicleRegNoTextBox.Location = new System.Drawing.Point(221, 101);
            this.vehicleRegNoTextBox.Name = "vehicleRegNoTextBox";
            this.vehicleRegNoTextBox.Size = new System.Drawing.Size(173, 26);
            this.vehicleRegNoTextBox.TabIndex = 0;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.makeTextBox.Location = new System.Drawing.Point(221, 137);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(173, 26);
            this.makeTextBox.TabIndex = 1;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.engineSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.engineSizeTextBox.Location = new System.Drawing.Point(221, 173);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(173, 26);
            this.engineSizeTextBox.TabIndex = 2;
            // 
            // dateRegisteredTextBox
            // 
            this.dateRegisteredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "DateRegistered", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "01/01/1980", "D"));
            this.dateRegisteredTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateRegisteredTextBox.Location = new System.Drawing.Point(221, 209);
            this.dateRegisteredTextBox.Name = "dateRegisteredTextBox";
            this.dateRegisteredTextBox.Size = new System.Drawing.Size(173, 26);
            this.dateRegisteredTextBox.TabIndex = 3;
            // 
            // rentalPerDayTextBox
            // 
            this.rentalPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.rentalPerDayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rentalPerDayTextBox.Location = new System.Drawing.Point(221, 245);
            this.rentalPerDayTextBox.Name = "rentalPerDayTextBox";
            this.rentalPerDayTextBox.Size = new System.Drawing.Size(173, 26);
            this.rentalPerDayTextBox.TabIndex = 4;
            this.rentalPerDayTextBox.TextChanged += new System.EventHandler(this.rentalPerDayTextBox_TextChanged);
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.availableCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.availableCheckBox.Location = new System.Drawing.Point(221, 281);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availableCheckBox.TabIndex = 5;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblCarBindingNavigator
            // 
            this.tblCarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCarBindingNavigator.BindingSource = this.tblCarBindingSource;
            this.tblCarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmep,
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
            this.tblCarBindingNavigatorSaveItem});
            this.tblCarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCarBindingNavigator.MoveFirstItem = this.tmep;
            this.tblCarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCarBindingNavigator.Name = "tblCarBindingNavigator";
            this.tblCarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCarBindingNavigator.Size = new System.Drawing.Size(574, 25);
            this.tblCarBindingNavigator.TabIndex = 25;
            this.tblCarBindingNavigator.Text = "bindingNavigator1";
            this.tblCarBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tmep
            // 
            this.tmep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tmep.Image = ((System.Drawing.Image)(resources.GetObject("tmep.Image")));
            this.tmep.Name = "tmep";
            this.tmep.RightToLeftAutoMirrorImage = true;
            this.tmep.Size = new System.Drawing.Size(23, 22);
            this.tmep.Text = "Move first";
            this.tmep.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
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
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
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
            // tblCarBindingNavigatorSaveItem
            // 
            this.tblCarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCarBindingNavigatorSaveItem.Image")));
            this.tblCarBindingNavigatorSaveItem.Name = "tblCarBindingNavigatorSaveItem";
            this.tblCarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblCarBindingNavigatorSaveItem.Text = "Save Data";
            this.tblCarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCarBindingNavigatorSaveItem_Click);
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 416);
            this.Controls.Add(vehicleRegNoLabel);
            this.Controls.Add(this.vehicleRegNoTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(dateRegisteredLabel);
            this.Controls.Add(this.dateRegisteredTextBox);
            this.Controls.Add(rentalPerDayLabel);
            this.Controls.Add(this.rentalPerDayTextBox);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.tblCarBindingNavigator);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.recordTextBox);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Name = "frmCars";
            this.Text = "Task A Philip Woulfe 2015/08/04";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).EndInit();
            this.tblCarBindingNavigator.ResumeLayout(false);
            this.tblCarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.TextBox recordTextBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        private System.Windows.Forms.BindingSource tblCarBindingSource1;
        private System.Windows.Forms.TextBox vehicleRegNoTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.TextBox dateRegisteredTextBox;
        private System.Windows.Forms.TextBox rentalPerDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.BindingNavigator tblCarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tmep;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblCarBindingNavigatorSaveItem;
    }
}

