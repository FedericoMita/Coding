namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idVehicleRegNoLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label dateRegisteredLabel;
            System.Windows.Forms.Label rentalPerDayLabel;
            System.Windows.Forms.Label availableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCars));
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet = new CarsDatabase.Database1DataSet();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarTableAdapter = new CarsDatabase.Database1DataSetTableAdapters.TblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.Database1DataSetTableAdapters.TableAdapterManager();
            this.tblCarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblCarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idVehicleRegNoTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.dateRegisteredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalPerDayTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.PreviousBTN = new System.Windows.Forms.Button();
            this.FirstBTN = new System.Windows.Forms.Button();
            this.LastBTN = new System.Windows.Forms.Button();
            this.NextBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            idVehicleRegNoLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            engineSizeLabel = new System.Windows.Forms.Label();
            dateRegisteredLabel = new System.Windows.Forms.Label();
            rentalPerDayLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).BeginInit();
            this.tblCarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idVehicleRegNoLabel
            // 
            idVehicleRegNoLabel.AutoSize = true;
            idVehicleRegNoLabel.Location = new System.Drawing.Point(12, 92);
            idVehicleRegNoLabel.Name = "idVehicleRegNoLabel";
            idVehicleRegNoLabel.Size = new System.Drawing.Size(97, 13);
            idVehicleRegNoLabel.TabIndex = 2;
            idVehicleRegNoLabel.Text = "Id Vehicle Reg No:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(72, 118);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 4;
            makeLabel.Text = "Make:";
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Location = new System.Drawing.Point(43, 144);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(66, 13);
            engineSizeLabel.TabIndex = 6;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // dateRegisteredLabel
            // 
            dateRegisteredLabel.AutoSize = true;
            dateRegisteredLabel.Location = new System.Drawing.Point(22, 171);
            dateRegisteredLabel.Name = "dateRegisteredLabel";
            dateRegisteredLabel.Size = new System.Drawing.Size(87, 13);
            dateRegisteredLabel.TabIndex = 8;
            dateRegisteredLabel.Text = "Date Registered:";
            // 
            // rentalPerDayLabel
            // 
            rentalPerDayLabel.AutoSize = true;
            rentalPerDayLabel.Location = new System.Drawing.Point(27, 196);
            rentalPerDayLabel.Name = "rentalPerDayLabel";
            rentalPerDayLabel.Size = new System.Drawing.Size(82, 13);
            rentalPerDayLabel.TabIndex = 10;
            rentalPerDayLabel.Text = "Rental Per Day:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(56, 224);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(53, 13);
            availableLabel.TabIndex = 12;
            availableLabel.Text = "Available:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "TblCar";
            this.tblCarBindingSource.DataSource = this.database1DataSet;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCarBindingNavigator
            // 
            this.tblCarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCarBindingNavigator.BindingSource = this.tblCarBindingSource;
            this.tblCarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblCarBindingNavigatorSaveItem});
            this.tblCarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCarBindingNavigator.Name = "tblCarBindingNavigator";
            this.tblCarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCarBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblCarBindingNavigator.TabIndex = 1;
            this.tblCarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
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
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
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
            this.tblCarBindingNavigatorSaveItem.Text = "Salva dati";
            this.tblCarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCarBindingNavigatorSaveItem_Click);
            // 
            // idVehicleRegNoTextBox
            // 
            this.idVehicleRegNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "IdVehicleRegNo", true));
            this.idVehicleRegNoTextBox.Location = new System.Drawing.Point(115, 89);
            this.idVehicleRegNoTextBox.Name = "idVehicleRegNoTextBox";
            this.idVehicleRegNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idVehicleRegNoTextBox.TabIndex = 3;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(115, 115);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 5;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.engineSizeTextBox.Location = new System.Drawing.Point(115, 141);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.engineSizeTextBox.TabIndex = 7;
            // 
            // dateRegisteredDateTimePicker
            // 
            this.dateRegisteredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCarBindingSource, "DateRegistered", true));
            this.dateRegisteredDateTimePicker.Location = new System.Drawing.Point(115, 167);
            this.dateRegisteredDateTimePicker.Name = "dateRegisteredDateTimePicker";
            this.dateRegisteredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRegisteredDateTimePicker.TabIndex = 9;
            // 
            // rentalPerDayTextBox
            // 
            this.rentalPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true));
            this.rentalPerDayTextBox.Location = new System.Drawing.Point(115, 193);
            this.rentalPerDayTextBox.Name = "rentalPerDayTextBox";
            this.rentalPerDayTextBox.Size = new System.Drawing.Size(100, 20);
            this.rentalPerDayTextBox.TabIndex = 11;
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(115, 219);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availableCheckBox.TabIndex = 13;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UpdateBTN.Location = new System.Drawing.Point(661, 82);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 14;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddBTN.Location = new System.Drawing.Point(661, 108);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 15;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteBTN.Location = new System.Drawing.Point(662, 134);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 16;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SearchBTN.Location = new System.Drawing.Point(662, 160);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 17;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelBTN.Location = new System.Drawing.Point(662, 186);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 18;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ExitBTN.Location = new System.Drawing.Point(662, 215);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 23);
            this.ExitBTN.TabIndex = 19;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // PreviousBTN
            // 
            this.PreviousBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PreviousBTN.Location = new System.Drawing.Point(239, 368);
            this.PreviousBTN.Name = "PreviousBTN";
            this.PreviousBTN.Size = new System.Drawing.Size(75, 23);
            this.PreviousBTN.TabIndex = 20;
            this.PreviousBTN.Text = "Previous";
            this.PreviousBTN.UseVisualStyleBackColor = false;
            this.PreviousBTN.Click += new System.EventHandler(this.PreviousBTN_Click);
            // 
            // FirstBTN
            // 
            this.FirstBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FirstBTN.Location = new System.Drawing.Point(115, 368);
            this.FirstBTN.Name = "FirstBTN";
            this.FirstBTN.Size = new System.Drawing.Size(75, 23);
            this.FirstBTN.TabIndex = 21;
            this.FirstBTN.Text = "First";
            this.FirstBTN.UseVisualStyleBackColor = false;
            this.FirstBTN.Click += new System.EventHandler(this.FirstBTN_Click);
            // 
            // LastBTN
            // 
            this.LastBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LastBTN.Location = new System.Drawing.Point(662, 368);
            this.LastBTN.Name = "LastBTN";
            this.LastBTN.Size = new System.Drawing.Size(75, 23);
            this.LastBTN.TabIndex = 22;
            this.LastBTN.Text = "Last";
            this.LastBTN.UseVisualStyleBackColor = false;
            this.LastBTN.Click += new System.EventHandler(this.LastBTN_Click);
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NextBTN.Location = new System.Drawing.Point(534, 367);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(75, 23);
            this.NextBTN.TabIndex = 23;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = false;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(231, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 47);
            this.label2.TabIndex = 24;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.LastBTN);
            this.Controls.Add(this.FirstBTN);
            this.Controls.Add(this.PreviousBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(rentalPerDayLabel);
            this.Controls.Add(this.rentalPerDayTextBox);
            this.Controls.Add(dateRegisteredLabel);
            this.Controls.Add(this.dateRegisteredDateTimePicker);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(idVehicleRegNoLabel);
            this.Controls.Add(this.idVehicleRegNoTextBox);
            this.Controls.Add(this.tblCarBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "frmCars";
            this.Text = "Task A Federico Mita 05/06/2022";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).EndInit();
            this.tblCarBindingNavigator.ResumeLayout(false);
            this.tblCarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private Database1DataSetTableAdapters.TblCarTableAdapter tblCarTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblCarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idVehicleRegNoTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.DateTimePicker dateRegisteredDateTimePicker;
        private System.Windows.Forms.TextBox rentalPerDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button PreviousBTN;
        private System.Windows.Forms.Button FirstBTN;
        private System.Windows.Forms.Button LastBTN;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Label label2;
    }
}

