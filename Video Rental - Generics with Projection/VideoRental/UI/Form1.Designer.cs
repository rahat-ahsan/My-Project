namespace VideoRental.UI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRentVideo = new System.Windows.Forms.TabPage();
            this.btnRent = new System.Windows.Forms.Button();
            this.cboRentCustomerName = new System.Windows.Forms.ComboBox();
            this.lvwVideoStatus = new System.Windows.Forms.ListView();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lvwBookings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomersLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCustomersAdd = new System.Windows.Forms.Button();
            this.btnCustomersUpdate = new System.Windows.Forms.Button();
            this.btnCustomersDelete = new System.Windows.Forms.Button();
            this.txtCustomersFName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCustomersName = new System.Windows.Forms.ComboBox();
            this.groupBoxVideo = new System.Windows.Forms.GroupBox();
            this.nmrDaysToBeRent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboVideoGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVideoAdd = new System.Windows.Forms.Button();
            this.btnVideoUpdate = new System.Windows.Forms.Button();
            this.btnVideoDelete = new System.Windows.Forms.Button();
            this.txtVideoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVideoVideo = new System.Windows.Forms.ComboBox();
            this.groupBoxGenre = new System.Windows.Forms.GroupBox();
            this.btnGenreAdd = new System.Windows.Forms.Button();
            this.btnGenreUpdate = new System.Windows.Forms.Button();
            this.btnGenereDelete = new System.Windows.Forms.Button();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGenreGenre = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabRentVideo.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.tabMaintenance.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
            this.groupBoxVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDaysToBeRent)).BeginInit();
            this.groupBoxGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRentVideo);
            this.tabControl1.Controls.Add(this.tabBookings);
            this.tabControl1.Controls.Add(this.tabMaintenance);
            this.tabControl1.Location = new System.Drawing.Point(18, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 395);
            this.tabControl1.TabIndex = 2;
            // 
            // tabRentVideo
            // 
            this.tabRentVideo.Controls.Add(this.btnRent);
            this.tabRentVideo.Controls.Add(this.cboRentCustomerName);
            this.tabRentVideo.Controls.Add(this.lvwVideoStatus);
            this.tabRentVideo.Location = new System.Drawing.Point(4, 22);
            this.tabRentVideo.Margin = new System.Windows.Forms.Padding(2);
            this.tabRentVideo.Name = "tabRentVideo";
            this.tabRentVideo.Padding = new System.Windows.Forms.Padding(2);
            this.tabRentVideo.Size = new System.Drawing.Size(691, 369);
            this.tabRentVideo.TabIndex = 0;
            this.tabRentVideo.Text = "Rent Video";
            this.tabRentVideo.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(472, 328);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(98, 23);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // cboRentCustomerName
            // 
            this.cboRentCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentCustomerName.FormattingEnabled = true;
            this.cboRentCustomerName.Location = new System.Drawing.Point(5, 328);
            this.cboRentCustomerName.Name = "cboRentCustomerName";
            this.cboRentCustomerName.Size = new System.Drawing.Size(410, 21);
            this.cboRentCustomerName.TabIndex = 1;
            // 
            // lvwVideoStatus
            // 
            this.lvwVideoStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwVideoStatus.FullRowSelect = true;
            this.lvwVideoStatus.GridLines = true;
            this.lvwVideoStatus.HideSelection = false;
            this.lvwVideoStatus.Location = new System.Drawing.Point(2, 2);
            this.lvwVideoStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lvwVideoStatus.MultiSelect = false;
            this.lvwVideoStatus.Name = "lvwVideoStatus";
            this.lvwVideoStatus.Size = new System.Drawing.Size(598, 319);
            this.lvwVideoStatus.TabIndex = 0;
            this.lvwVideoStatus.UseCompatibleStateImageBehavior = false;
            this.lvwVideoStatus.View = System.Windows.Forms.View.Details;
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.btnReturn);
            this.tabBookings.Controls.Add(this.dtpReturnDate);
            this.tabBookings.Controls.Add(this.lvwBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 22);
            this.tabBookings.Margin = new System.Windows.Forms.Padding(2);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(2);
            this.tabBookings.Size = new System.Drawing.Size(691, 369);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(247, 316);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(15, 316);
            this.dtpReturnDate.MinDate = new System.DateTime(2014, 11, 14, 0, 0, 0, 0);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnDate.TabIndex = 1;
            // 
            // lvwBookings
            // 
            this.lvwBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwBookings.FullRowSelect = true;
            this.lvwBookings.GridLines = true;
            this.lvwBookings.HideSelection = false;
            this.lvwBookings.Location = new System.Drawing.Point(6, 6);
            this.lvwBookings.MultiSelect = false;
            this.lvwBookings.Name = "lvwBookings";
            this.lvwBookings.Scrollable = false;
            this.lvwBookings.Size = new System.Drawing.Size(680, 291);
            this.lvwBookings.TabIndex = 0;
            this.lvwBookings.UseCompatibleStateImageBehavior = false;
            this.lvwBookings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BookingId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Video Title";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Genre";
            this.columnHeader7.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rented";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Returned";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 149;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cost";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 86;
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.Controls.Add(this.groupBoxCustomers);
            this.tabMaintenance.Controls.Add(this.groupBoxVideo);
            this.tabMaintenance.Controls.Add(this.groupBoxGenre);
            this.tabMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tabMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Padding = new System.Windows.Forms.Padding(2);
            this.tabMaintenance.Size = new System.Drawing.Size(691, 369);
            this.tabMaintenance.TabIndex = 2;
            this.tabMaintenance.Text = "Maintenance";
            this.tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Controls.Add(this.label8);
            this.groupBoxCustomers.Controls.Add(this.txtCustomersLName);
            this.groupBoxCustomers.Controls.Add(this.label7);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersAdd);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersUpdate);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersDelete);
            this.groupBoxCustomers.Controls.Add(this.txtCustomersFName);
            this.groupBoxCustomers.Controls.Add(this.label6);
            this.groupBoxCustomers.Controls.Add(this.cboCustomersName);
            this.groupBoxCustomers.Location = new System.Drawing.Point(8, 162);
            this.groupBoxCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCustomers.Size = new System.Drawing.Size(206, 195);
            this.groupBoxCustomers.TabIndex = 6;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Customers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Customer";
            // 
            // txtCustomersLName
            // 
            this.txtCustomersLName.Location = new System.Drawing.Point(10, 121);
            this.txtCustomersLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomersLName.Name = "txtCustomersLName";
            this.txtCustomersLName.Size = new System.Drawing.Size(122, 20);
            this.txtCustomersLName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Last Name";
            // 
            // btnCustomersAdd
            // 
            this.btnCustomersAdd.Location = new System.Drawing.Point(142, 153);
            this.btnCustomersAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomersAdd.Name = "btnCustomersAdd";
            this.btnCustomersAdd.Size = new System.Drawing.Size(56, 23);
            this.btnCustomersAdd.TabIndex = 5;
            this.btnCustomersAdd.Text = "Add";
            this.btnCustomersAdd.UseVisualStyleBackColor = true;
            this.btnCustomersAdd.Click += new System.EventHandler(this.btnCustomersAdd_Click);
            // 
            // btnCustomersUpdate
            // 
            this.btnCustomersUpdate.Location = new System.Drawing.Point(76, 154);
            this.btnCustomersUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomersUpdate.Name = "btnCustomersUpdate";
            this.btnCustomersUpdate.Size = new System.Drawing.Size(56, 22);
            this.btnCustomersUpdate.TabIndex = 4;
            this.btnCustomersUpdate.Text = "Update";
            this.btnCustomersUpdate.UseVisualStyleBackColor = true;
            this.btnCustomersUpdate.Click += new System.EventHandler(this.btnCustomersUpdate_Click);
            // 
            // btnCustomersDelete
            // 
            this.btnCustomersDelete.Location = new System.Drawing.Point(9, 153);
            this.btnCustomersDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomersDelete.Name = "btnCustomersDelete";
            this.btnCustomersDelete.Size = new System.Drawing.Size(60, 23);
            this.btnCustomersDelete.TabIndex = 3;
            this.btnCustomersDelete.Text = "Delete";
            this.btnCustomersDelete.UseVisualStyleBackColor = true;
            this.btnCustomersDelete.Click += new System.EventHandler(this.btnCustomersDelete_Click);
            // 
            // txtCustomersFName
            // 
            this.txtCustomersFName.Location = new System.Drawing.Point(9, 81);
            this.txtCustomersFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomersFName.Name = "txtCustomersFName";
            this.txtCustomersFName.Size = new System.Drawing.Size(124, 20);
            this.txtCustomersFName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name";
            // 
            // cboCustomersName
            // 
            this.cboCustomersName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomersName.FormattingEnabled = true;
            this.cboCustomersName.Location = new System.Drawing.Point(10, 41);
            this.cboCustomersName.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustomersName.Name = "cboCustomersName";
            this.cboCustomersName.Size = new System.Drawing.Size(190, 21);
            this.cboCustomersName.TabIndex = 0;
            this.cboCustomersName.SelectedIndexChanged += new System.EventHandler(this.cboCustomersName_SelectedIndexChanged);
            // 
            // groupBoxVideo
            // 
            this.groupBoxVideo.Controls.Add(this.nmrDaysToBeRent);
            this.groupBoxVideo.Controls.Add(this.label5);
            this.groupBoxVideo.Controls.Add(this.cboVideoGenre);
            this.groupBoxVideo.Controls.Add(this.label4);
            this.groupBoxVideo.Controls.Add(this.label3);
            this.groupBoxVideo.Controls.Add(this.btnVideoAdd);
            this.groupBoxVideo.Controls.Add(this.btnVideoUpdate);
            this.groupBoxVideo.Controls.Add(this.btnVideoDelete);
            this.groupBoxVideo.Controls.Add(this.txtVideoName);
            this.groupBoxVideo.Controls.Add(this.label2);
            this.groupBoxVideo.Controls.Add(this.cboVideoVideo);
            this.groupBoxVideo.Location = new System.Drawing.Point(250, 16);
            this.groupBoxVideo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVideo.Name = "groupBoxVideo";
            this.groupBoxVideo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxVideo.Size = new System.Drawing.Size(206, 176);
            this.groupBoxVideo.TabIndex = 1;
            this.groupBoxVideo.TabStop = false;
            this.groupBoxVideo.Text = "Videos";
            // 
            // nmrDaysToBeRent
            // 
            this.nmrDaysToBeRent.Location = new System.Drawing.Point(141, 114);
            this.nmrDaysToBeRent.Margin = new System.Windows.Forms.Padding(2);
            this.nmrDaysToBeRent.Name = "nmrDaysToBeRent";
            this.nmrDaysToBeRent.Size = new System.Drawing.Size(56, 20);
            this.nmrDaysToBeRent.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Days";
            // 
            // cboVideoGenre
            // 
            this.cboVideoGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoGenre.FormattingEnabled = true;
            this.cboVideoGenre.Location = new System.Drawing.Point(6, 78);
            this.cboVideoGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cboVideoGenre.Name = "cboVideoGenre";
            this.cboVideoGenre.Size = new System.Drawing.Size(163, 21);
            this.cboVideoGenre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre";
            // 
            // btnVideoAdd
            // 
            this.btnVideoAdd.Location = new System.Drawing.Point(141, 142);
            this.btnVideoAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoAdd.Name = "btnVideoAdd";
            this.btnVideoAdd.Size = new System.Drawing.Size(56, 23);
            this.btnVideoAdd.TabIndex = 2;
            this.btnVideoAdd.Text = "Add";
            this.btnVideoAdd.UseVisualStyleBackColor = true;
            this.btnVideoAdd.Click += new System.EventHandler(this.btnVideoAdd_Click);
            // 
            // btnVideoUpdate
            // 
            this.btnVideoUpdate.Location = new System.Drawing.Point(74, 144);
            this.btnVideoUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoUpdate.Name = "btnVideoUpdate";
            this.btnVideoUpdate.Size = new System.Drawing.Size(56, 22);
            this.btnVideoUpdate.TabIndex = 3;
            this.btnVideoUpdate.Text = "Update";
            this.btnVideoUpdate.UseVisualStyleBackColor = true;
            this.btnVideoUpdate.Click += new System.EventHandler(this.btnVideoUpdate_Click);
            // 
            // btnVideoDelete
            // 
            this.btnVideoDelete.Location = new System.Drawing.Point(8, 142);
            this.btnVideoDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoDelete.Name = "btnVideoDelete";
            this.btnVideoDelete.Size = new System.Drawing.Size(60, 23);
            this.btnVideoDelete.TabIndex = 4;
            this.btnVideoDelete.Text = "Delete";
            this.btnVideoDelete.UseVisualStyleBackColor = true;
            this.btnVideoDelete.Click += new System.EventHandler(this.btnVideoDelete_Click);
            // 
            // txtVideoName
            // 
            this.txtVideoName.Location = new System.Drawing.Point(8, 114);
            this.txtVideoName.Margin = new System.Windows.Forms.Padding(2);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(124, 20);
            this.txtVideoName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // cboVideoVideo
            // 
            this.cboVideoVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoVideo.FormattingEnabled = true;
            this.cboVideoVideo.Location = new System.Drawing.Point(6, 38);
            this.cboVideoVideo.Margin = new System.Windows.Forms.Padding(2);
            this.cboVideoVideo.Name = "cboVideoVideo";
            this.cboVideoVideo.Size = new System.Drawing.Size(163, 21);
            this.cboVideoVideo.TabIndex = 0;
            this.cboVideoVideo.SelectedIndexChanged += new System.EventHandler(this.cboVideoVideo_SelectedIndexChanged);
            // 
            // groupBoxGenre
            // 
            this.groupBoxGenre.Controls.Add(this.btnGenreAdd);
            this.groupBoxGenre.Controls.Add(this.btnGenreUpdate);
            this.groupBoxGenre.Controls.Add(this.btnGenereDelete);
            this.groupBoxGenre.Controls.Add(this.txtGenreName);
            this.groupBoxGenre.Controls.Add(this.label1);
            this.groupBoxGenre.Controls.Add(this.cboGenreGenre);
            this.groupBoxGenre.Location = new System.Drawing.Point(8, 16);
            this.groupBoxGenre.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGenre.Name = "groupBoxGenre";
            this.groupBoxGenre.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGenre.Size = new System.Drawing.Size(206, 129);
            this.groupBoxGenre.TabIndex = 0;
            this.groupBoxGenre.TabStop = false;
            this.groupBoxGenre.Text = "Genres";
            // 
            // btnGenreAdd
            // 
            this.btnGenreAdd.Location = new System.Drawing.Point(142, 90);
            this.btnGenreAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenreAdd.Name = "btnGenreAdd";
            this.btnGenreAdd.Size = new System.Drawing.Size(56, 23);
            this.btnGenreAdd.TabIndex = 1;
            this.btnGenreAdd.Text = "Add";
            this.btnGenreAdd.UseVisualStyleBackColor = true;
            this.btnGenreAdd.Click += new System.EventHandler(this.btnGenreAdd_Click);
            // 
            // btnGenreUpdate
            // 
            this.btnGenreUpdate.Location = new System.Drawing.Point(74, 91);
            this.btnGenreUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenreUpdate.Name = "btnGenreUpdate";
            this.btnGenreUpdate.Size = new System.Drawing.Size(56, 22);
            this.btnGenreUpdate.TabIndex = 2;
            this.btnGenreUpdate.Text = "Update";
            this.btnGenreUpdate.UseVisualStyleBackColor = true;
            this.btnGenreUpdate.Click += new System.EventHandler(this.btnGenreUpdate_Click);
            // 
            // btnGenereDelete
            // 
            this.btnGenereDelete.Location = new System.Drawing.Point(8, 90);
            this.btnGenereDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenereDelete.Name = "btnGenereDelete";
            this.btnGenereDelete.Size = new System.Drawing.Size(60, 23);
            this.btnGenereDelete.TabIndex = 3;
            this.btnGenereDelete.Text = "Delete";
            this.btnGenereDelete.UseVisualStyleBackColor = true;
            this.btnGenereDelete.Click += new System.EventHandler(this.btnGenereDelete_Click);
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(8, 62);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(192, 20);
            this.txtGenreName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // cboGenreGenre
            // 
            this.cboGenreGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenreGenre.FormattingEnabled = true;
            this.cboGenreGenre.Location = new System.Drawing.Point(8, 24);
            this.cboGenreGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cboGenreGenre.Name = "cboGenreGenre";
            this.cboGenreGenre.Size = new System.Drawing.Size(190, 21);
            this.cboGenreGenre.TabIndex = 0;
            this.cboGenreGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenreGenre_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(551, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Video";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Genre";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Rent Days";
            this.columnHeader11.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 438);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Video Rental Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRentVideo.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.tabMaintenance.ResumeLayout(false);
            this.groupBoxCustomers.ResumeLayout(false);
            this.groupBoxCustomers.PerformLayout();
            this.groupBoxVideo.ResumeLayout(false);
            this.groupBoxVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDaysToBeRent)).EndInit();
            this.groupBoxGenre.ResumeLayout(false);
            this.groupBoxGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRentVideo;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabMaintenance;
        private System.Windows.Forms.GroupBox groupBoxGenre;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGenreGenre;
        private System.Windows.Forms.Button btnGenreAdd;
        private System.Windows.Forms.Button btnGenreUpdate;
        private System.Windows.Forms.Button btnGenereDelete;
        private System.Windows.Forms.GroupBox groupBoxVideo;
        private System.Windows.Forms.ComboBox cboVideoGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVideoAdd;
        private System.Windows.Forms.Button btnVideoUpdate;
        private System.Windows.Forms.Button btnVideoDelete;
        private System.Windows.Forms.TextBox txtVideoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVideoVideo;
        private System.Windows.Forms.NumericUpDown nmrDaysToBeRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomersLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCustomersAdd;
        private System.Windows.Forms.Button btnCustomersUpdate;
        private System.Windows.Forms.Button btnCustomersDelete;
        private System.Windows.Forms.TextBox txtCustomersFName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCustomersName;
        private System.Windows.Forms.ListView lvwVideoStatus;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ComboBox cboRentCustomerName;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ListView lvwBookings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

