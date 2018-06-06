namespace MediClinicConsultantSystem
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainScreen = new System.Windows.Forms.Panel();
            this.pnlAppointmentDetails = new System.Windows.Forms.Panel();
            this.cmbHospitalFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            this.lblCurrentTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDateToday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLogTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.flwpnlHospitals = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridPatientRecords = new System.Windows.Forms.DataGridView();
            this.cmbPatientName = new System.Windows.Forms.ComboBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnMainLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMyDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAppoinments = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecords = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConsultantName = new System.Windows.Forms.Label();
            this.btnShowAllPatients = new System.Windows.Forms.Button();
            this.pnlMyInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConsultantPersonalDetails = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblConsultantDetailsInfo = new System.Windows.Forms.Label();
            this.cmbFilterByDate = new System.Windows.Forms.ComboBox();
            this.btnShowAllAppointments = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMainScreen.SuspendLayout();
            this.pnlAppointmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.pnlSchedule.SuspendLayout();
            this.pnlRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatientRecords)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.btnCompress);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1366, 32);
            this.pnlHeader.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pictureBox2.Image = global::MediClinicConsultantSystem.Properties.Resources.LogoSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCompress
            // 
            this.btnCompress.BackColor = System.Drawing.Color.Transparent;
            this.btnCompress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompress.BackgroundImage")));
            this.btnCompress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompress.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCompress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompress.Location = new System.Drawing.Point(1285, -3);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(40, 37);
            this.btnCompress.TabIndex = 5;
            this.btnCompress.UseVisualStyleBackColor = false;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1241, -3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 37);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1328, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMainScreen
            // 
            this.pnlMainScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.pnlMainScreen.Controls.Add(this.pnlRecords);
            this.pnlMainScreen.Controls.Add(this.pnlAppointmentDetails);
            this.pnlMainScreen.Controls.Add(this.pnlMyInfo);
            this.pnlMainScreen.Controls.Add(this.pnlSchedule);
            this.pnlMainScreen.Controls.Add(this.lblCurrentTime);
            this.pnlMainScreen.Controls.Add(this.lblDateToday);
            this.pnlMainScreen.Controls.Add(this.lblLogTime);
            this.pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMainScreen.Location = new System.Drawing.Point(320, 32);
            this.pnlMainScreen.Name = "pnlMainScreen";
            this.pnlMainScreen.Size = new System.Drawing.Size(1046, 736);
            this.pnlMainScreen.TabIndex = 6;
            // 
            // pnlAppointmentDetails
            // 
            this.pnlAppointmentDetails.Controls.Add(this.btnShowAllAppointments);
            this.pnlAppointmentDetails.Controls.Add(this.cmbFilterByDate);
            this.pnlAppointmentDetails.Controls.Add(this.cmbHospitalFilter);
            this.pnlAppointmentDetails.Controls.Add(this.label4);
            this.pnlAppointmentDetails.Controls.Add(this.label3);
            this.pnlAppointmentDetails.Controls.Add(this.label2);
            this.pnlAppointmentDetails.Controls.Add(this.dataGridAppointments);
            this.pnlAppointmentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppointmentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlAppointmentDetails.Name = "pnlAppointmentDetails";
            this.pnlAppointmentDetails.Size = new System.Drawing.Size(1046, 736);
            this.pnlAppointmentDetails.TabIndex = 3;
            this.pnlAppointmentDetails.Visible = false;
            this.pnlAppointmentDetails.VisibleChanged += new System.EventHandler(this.pnlAppointmentDetails_VisibleChanged);
            // 
            // cmbHospitalFilter
            // 
            this.cmbHospitalFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHospitalFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHospitalFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.cmbHospitalFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHospitalFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHospitalFilter.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHospitalFilter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbHospitalFilter.Location = new System.Drawing.Point(98, 38);
            this.cmbHospitalFilter.MaxDropDownItems = 3;
            this.cmbHospitalFilter.Name = "cmbHospitalFilter";
            this.cmbHospitalFilter.Size = new System.Drawing.Size(292, 27);
            this.cmbHospitalFilter.TabIndex = 4;
            this.cmbHospitalFilter.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbHospitalFilter_DrawItem);
            this.cmbHospitalFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbHospitalFilter_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(416, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By";
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.AllowUserToAddRows = false;
            this.dataGridAppointments.AllowUserToDeleteRows = false;
            this.dataGridAppointments.AllowUserToResizeColumns = false;
            this.dataGridAppointments.AllowUserToResizeRows = false;
            this.dataGridAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.dataGridAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridAppointments.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointments.EnableHeadersVisualStyles = false;
            this.dataGridAppointments.Location = new System.Drawing.Point(0, 88);
            this.dataGridAppointments.MultiSelect = false;
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.ReadOnly = true;
            this.dataGridAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAppointments.RowHeadersVisible = false;
            this.dataGridAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridAppointments.Size = new System.Drawing.Size(1048, 648);
            this.dataGridAppointments.TabIndex = 1;
            this.dataGridAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridAppointments_CellFormatting);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Glacial Indifference", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCurrentTime.Location = new System.Drawing.Point(528, 27);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentTime.Size = new System.Drawing.Size(477, 52);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDateToday
            // 
            this.lblDateToday.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblDateToday.Location = new System.Drawing.Point(0, 111);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(1043, 52);
            this.lblDateToday.TabIndex = 0;
            this.lblDateToday.Text = "Today is Saturday the 11th of November";
            this.lblDateToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogTime
            // 
            this.lblLogTime.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogTime.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLogTime.Location = new System.Drawing.Point(84, 24);
            this.lblLogTime.Name = "lblLogTime";
            this.lblLogTime.Size = new System.Drawing.Size(438, 52);
            this.lblLogTime.TabIndex = 0;
            this.lblLogTime.Text = "bunifuCustomLabel1";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.Controls.Add(this.flwpnlHospitals);
            this.pnlSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchedule.Location = new System.Drawing.Point(0, 0);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(1046, 736);
            this.pnlSchedule.TabIndex = 1;
            this.pnlSchedule.Visible = false;
            // 
            // flwpnlHospitals
            // 
            this.flwpnlHospitals.AutoScroll = true;
            this.flwpnlHospitals.Location = new System.Drawing.Point(6, 66);
            this.flwpnlHospitals.Name = "flwpnlHospitals";
            this.flwpnlHospitals.Size = new System.Drawing.Size(1028, 600);
            this.flwpnlHospitals.TabIndex = 0;
            // 
            // pnlRecords
            // 
            this.pnlRecords.Controls.Add(this.btnShowAllPatients);
            this.pnlRecords.Controls.Add(this.label1);
            this.pnlRecords.Controls.Add(this.datagridPatientRecords);
            this.pnlRecords.Controls.Add(this.cmbPatientName);
            this.pnlRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecords.Location = new System.Drawing.Point(0, 0);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(1046, 736);
            this.pnlRecords.TabIndex = 0;
            this.pnlRecords.Visible = false;
            this.pnlRecords.VisibleChanged += new System.EventHandler(this.pnlRecords_VisibleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Patient\'s Full Name";
            // 
            // datagridPatientRecords
            // 
            this.datagridPatientRecords.AllowUserToAddRows = false;
            this.datagridPatientRecords.AllowUserToDeleteRows = false;
            this.datagridPatientRecords.AllowUserToResizeColumns = false;
            this.datagridPatientRecords.AllowUserToResizeRows = false;
            this.datagridPatientRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridPatientRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridPatientRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.datagridPatientRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridPatientRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datagridPatientRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridPatientRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPatientRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridPatientRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPatientRecords.EnableHeadersVisualStyles = false;
            this.datagridPatientRecords.Location = new System.Drawing.Point(0, 111);
            this.datagridPatientRecords.MultiSelect = false;
            this.datagridPatientRecords.Name = "datagridPatientRecords";
            this.datagridPatientRecords.ReadOnly = true;
            this.datagridPatientRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridPatientRecords.RowHeadersVisible = false;
            this.datagridPatientRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridPatientRecords.Size = new System.Drawing.Size(1048, 622);
            this.datagridPatientRecords.TabIndex = 0;
            this.datagridPatientRecords.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagridPatientRecords_CellFormatting);
            this.datagridPatientRecords.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridPatientRecords_CellMouseDoubleClick);
            this.datagridPatientRecords.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.datagridPatientRecords_CellStateChanged);
            // 
            // cmbPatientName
            // 
            this.cmbPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.cmbPatientName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPatientName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbPatientName.Location = new System.Drawing.Point(10, 55);
            this.cmbPatientName.MaxDropDownItems = 3;
            this.cmbPatientName.Name = "cmbPatientName";
            this.cmbPatientName.Size = new System.Drawing.Size(205, 27);
            this.cmbPatientName.TabIndex = 1;
            this.cmbPatientName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbPatientName_DrawItem);
            this.cmbPatientName.SelectionChangeCommitted += new System.EventHandler(this.cmbPatientName_SelectionChangeCommitted);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlSideBar.Controls.Add(this.btnMainLogout);
            this.pnlSideBar.Controls.Add(this.btnMyDetails);
            this.pnlSideBar.Controls.Add(this.btnAppoinments);
            this.pnlSideBar.Controls.Add(this.btnRecords);
            this.pnlSideBar.Controls.Add(this.btnSchedule);
            this.pnlSideBar.Controls.Add(this.bunifuCustomLabel2);
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.lblConsultantName);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 32);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(320, 736);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnMainLogout
            // 
            this.btnMainLogout.Activecolor = System.Drawing.Color.Teal;
            this.btnMainLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMainLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainLogout.BorderRadius = 0;
            this.btnMainLogout.ButtonText = "Logout";
            this.btnMainLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnMainLogout.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMainLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainLogout.Iconimage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Sign_Out_64;
            this.btnMainLogout.Iconimage_right = null;
            this.btnMainLogout.Iconimage_right_Selected = null;
            this.btnMainLogout.Iconimage_Selected = null;
            this.btnMainLogout.IconMarginLeft = 0;
            this.btnMainLogout.IconMarginRight = 0;
            this.btnMainLogout.IconRightVisible = true;
            this.btnMainLogout.IconRightZoom = 0D;
            this.btnMainLogout.IconVisible = true;
            this.btnMainLogout.IconZoom = 90D;
            this.btnMainLogout.IsTab = false;
            this.btnMainLogout.Location = new System.Drawing.Point(0, 673);
            this.btnMainLogout.Name = "btnMainLogout";
            this.btnMainLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMainLogout.OnHovercolor = System.Drawing.Color.Teal;
            this.btnMainLogout.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMainLogout.selected = false;
            this.btnMainLogout.Size = new System.Drawing.Size(320, 63);
            this.btnMainLogout.TabIndex = 0;
            this.btnMainLogout.Text = "Logout";
            this.btnMainLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMainLogout.Textcolor = System.Drawing.Color.White;
            this.btnMainLogout.TextFont = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMyDetails
            // 
            this.btnMyDetails.Activecolor = System.Drawing.Color.MediumTurquoise;
            this.btnMyDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMyDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyDetails.BorderRadius = 0;
            this.btnMyDetails.ButtonText = "My Info";
            this.btnMyDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDetails.DisabledColor = System.Drawing.Color.Gray;
            this.btnMyDetails.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMyDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMyDetails.Iconimage = global::MediClinicConsultantSystem.Properties.Resources.icons8_More_Info_32;
            this.btnMyDetails.Iconimage_right = null;
            this.btnMyDetails.Iconimage_right_Selected = null;
            this.btnMyDetails.Iconimage_Selected = global::MediClinicConsultantSystem.Properties.Resources.icons8_More_InfoS_32;
            this.btnMyDetails.IconMarginLeft = 0;
            this.btnMyDetails.IconMarginRight = 0;
            this.btnMyDetails.IconRightVisible = true;
            this.btnMyDetails.IconRightZoom = 0D;
            this.btnMyDetails.IconVisible = true;
            this.btnMyDetails.IconZoom = 90D;
            this.btnMyDetails.IsTab = true;
            this.btnMyDetails.Location = new System.Drawing.Point(0, 389);
            this.btnMyDetails.Name = "btnMyDetails";
            this.btnMyDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMyDetails.OnHovercolor = System.Drawing.Color.MediumTurquoise;
            this.btnMyDetails.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMyDetails.selected = false;
            this.btnMyDetails.Size = new System.Drawing.Size(320, 63);
            this.btnMyDetails.TabIndex = 0;
            this.btnMyDetails.Text = "My Info";
            this.btnMyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMyDetails.Textcolor = System.Drawing.Color.White;
            this.btnMyDetails.TextFont = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDetails.Click += new System.EventHandler(this.btnMyDetails_Click);
            // 
            // btnAppoinments
            // 
            this.btnAppoinments.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnAppoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAppoinments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppoinments.BorderRadius = 0;
            this.btnAppoinments.ButtonText = "Appointment Details";
            this.btnAppoinments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppoinments.DisabledColor = System.Drawing.Color.Gray;
            this.btnAppoinments.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAppoinments.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAppoinments.Iconimage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Calendar_32;
            this.btnAppoinments.Iconimage_right = null;
            this.btnAppoinments.Iconimage_right_Selected = null;
            this.btnAppoinments.Iconimage_Selected = global::MediClinicConsultantSystem.Properties.Resources.icons8_CalendarS_32;
            this.btnAppoinments.IconMarginLeft = 0;
            this.btnAppoinments.IconMarginRight = 0;
            this.btnAppoinments.IconRightVisible = true;
            this.btnAppoinments.IconRightZoom = 0D;
            this.btnAppoinments.IconVisible = true;
            this.btnAppoinments.IconZoom = 90D;
            this.btnAppoinments.IsTab = true;
            this.btnAppoinments.Location = new System.Drawing.Point(0, 324);
            this.btnAppoinments.Name = "btnAppoinments";
            this.btnAppoinments.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAppoinments.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnAppoinments.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAppoinments.selected = false;
            this.btnAppoinments.Size = new System.Drawing.Size(320, 63);
            this.btnAppoinments.TabIndex = 0;
            this.btnAppoinments.Text = "Appointment Details";
            this.btnAppoinments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAppoinments.Textcolor = System.Drawing.Color.White;
            this.btnAppoinments.TextFont = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoinments.Click += new System.EventHandler(this.btnAppoinments_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Activecolor = System.Drawing.Color.Turquoise;
            this.btnRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecords.BorderRadius = 0;
            this.btnRecords.ButtonText = "Patient Records";
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecords.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRecords.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecords.Iconimage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Treatment_32;
            this.btnRecords.Iconimage_right = null;
            this.btnRecords.Iconimage_right_Selected = null;
            this.btnRecords.Iconimage_Selected = global::MediClinicConsultantSystem.Properties.Resources.icons8_Treatment2_32;
            this.btnRecords.IconMarginLeft = 0;
            this.btnRecords.IconMarginRight = 0;
            this.btnRecords.IconRightVisible = true;
            this.btnRecords.IconRightZoom = 0D;
            this.btnRecords.IconVisible = true;
            this.btnRecords.IconZoom = 90D;
            this.btnRecords.IsTab = true;
            this.btnRecords.Location = new System.Drawing.Point(0, 258);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRecords.OnHovercolor = System.Drawing.Color.Turquoise;
            this.btnRecords.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRecords.selected = false;
            this.btnRecords.Size = new System.Drawing.Size(320, 63);
            this.btnRecords.TabIndex = 0;
            this.btnRecords.Text = "Patient Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecords.Textcolor = System.Drawing.Color.White;
            this.btnRecords.TextFont = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Activecolor = System.Drawing.Color.Cyan;
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchedule.BorderRadius = 0;
            this.btnSchedule.ButtonText = "Appointment Schedule";
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSchedule.Iconimage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Schedule_32;
            this.btnSchedule.Iconimage_right = null;
            this.btnSchedule.Iconimage_right_Selected = null;
            this.btnSchedule.Iconimage_Selected = global::MediClinicConsultantSystem.Properties.Resources.icons8_ScheduleS_32;
            this.btnSchedule.IconMarginLeft = 0;
            this.btnSchedule.IconMarginRight = 0;
            this.btnSchedule.IconRightVisible = true;
            this.btnSchedule.IconRightZoom = 0D;
            this.btnSchedule.IconVisible = true;
            this.btnSchedule.IconZoom = 90D;
            this.btnSchedule.IsTab = true;
            this.btnSchedule.Location = new System.Drawing.Point(0, 191);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSchedule.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnSchedule.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSchedule.selected = false;
            this.btnSchedule.Size = new System.Drawing.Size(320, 63);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "Appointment Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSchedule.Textcolor = System.Drawing.Color.White;
            this.btnSchedule.TextFont = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Moon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(-1, 108);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(326, 22);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Consultant Support System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediClinicConsultantSystem.Properties.Resources.MCLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblConsultantName
            // 
            this.lblConsultantName.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblConsultantName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.lblConsultantName.Location = new System.Drawing.Point(0, 143);
            this.lblConsultantName.Name = "lblConsultantName";
            this.lblConsultantName.Size = new System.Drawing.Size(320, 30);
            this.lblConsultantName.TabIndex = 2;
            // 
            // btnShowAllPatients
            // 
            this.btnShowAllPatients.FlatAppearance.BorderSize = 0;
            this.btnShowAllPatients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnShowAllPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowAllPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllPatients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllPatients.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowAllPatients.Location = new System.Drawing.Point(932, 50);
            this.btnShowAllPatients.Name = "btnShowAllPatients";
            this.btnShowAllPatients.Size = new System.Drawing.Size(102, 34);
            this.btnShowAllPatients.TabIndex = 3;
            this.btnShowAllPatients.Text = "Show All";
            this.btnShowAllPatients.UseVisualStyleBackColor = true;
            this.btnShowAllPatients.Click += new System.EventHandler(this.btnShowAllPatients_Click);
            // 
            // pnlMyInfo
            // 
            this.pnlMyInfo.Controls.Add(this.lblConsultantDetailsInfo);
            this.pnlMyInfo.Controls.Add(this.lblConsultantPersonalDetails);
            this.pnlMyInfo.Controls.Add(this.label6);
            this.pnlMyInfo.Controls.Add(this.label5);
            this.pnlMyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMyInfo.Name = "pnlMyInfo";
            this.pnlMyInfo.Size = new System.Drawing.Size(1046, 736);
            this.pnlMyInfo.TabIndex = 5;
            this.pnlMyInfo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Moon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Personal Details";
            // 
            // lblConsultantPersonalDetails
            // 
            this.lblConsultantPersonalDetails.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantPersonalDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConsultantPersonalDetails.Location = new System.Drawing.Point(22, 53);
            this.lblConsultantPersonalDetails.Name = "lblConsultantPersonalDetails";
            this.lblConsultantPersonalDetails.Size = new System.Drawing.Size(720, 120);
            this.lblConsultantPersonalDetails.TabIndex = 1;
            this.lblConsultantPersonalDetails.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Moon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(22, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Consultant Details";
            // 
            // lblConsultantDetailsInfo
            // 
            this.lblConsultantDetailsInfo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantDetailsInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConsultantDetailsInfo.Location = new System.Drawing.Point(22, 226);
            this.lblConsultantDetailsInfo.Name = "lblConsultantDetailsInfo";
            this.lblConsultantDetailsInfo.Size = new System.Drawing.Size(949, 330);
            this.lblConsultantDetailsInfo.TabIndex = 1;
            this.lblConsultantDetailsInfo.Text = "label6";
            // 
            // cmbFilterByDate
            // 
            this.cmbFilterByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.cmbFilterByDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterByDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterByDate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterByDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbFilterByDate.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "Newer",
            "Older"});
            this.cmbFilterByDate.Location = new System.Drawing.Point(566, 38);
            this.cmbFilterByDate.MaxDropDownItems = 3;
            this.cmbFilterByDate.Name = "cmbFilterByDate";
            this.cmbFilterByDate.Size = new System.Drawing.Size(201, 27);
            this.cmbFilterByDate.TabIndex = 5;
            this.cmbFilterByDate.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbFilterByDate_DrawItem);
            this.cmbFilterByDate.SelectionChangeCommitted += new System.EventHandler(this.cmbFilterByDate_SelectionChangeCommitted);
            // 
            // btnShowAllAppointments
            // 
            this.btnShowAllAppointments.FlatAppearance.BorderSize = 0;
            this.btnShowAllAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnShowAllAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowAllAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllAppointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAppointments.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowAllAppointments.Location = new System.Drawing.Point(932, 33);
            this.btnShowAllAppointments.Name = "btnShowAllAppointments";
            this.btnShowAllAppointments.Size = new System.Drawing.Size(102, 34);
            this.btnShowAllAppointments.TabIndex = 6;
            this.btnShowAllAppointments.Text = "Show All";
            this.btnShowAllAppointments.UseVisualStyleBackColor = true;
            this.btnShowAllAppointments.Click += new System.EventHandler(this.btnShowAllAppointments_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlMainScreen);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMainScreen.ResumeLayout(false);
            this.pnlAppointmentDetails.ResumeLayout(false);
            this.pnlAppointmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlRecords.ResumeLayout(false);
            this.pnlRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatientRecords)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMyInfo.ResumeLayout(false);
            this.pnlMyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainScreen;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCurrentTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDateToday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogTime;
        private System.Windows.Forms.Panel pnlSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnMyDetails;
        private Bunifu.Framework.UI.BunifuFlatButton btnAppoinments;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecords;
        private Bunifu.Framework.UI.BunifuFlatButton btnSchedule;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConsultantName;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.FlowLayoutPanel flwpnlHospitals;
        private System.Windows.Forms.Panel pnlRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPatientName;
        private System.Windows.Forms.DataGridView datagridPatientRecords;
        private System.Windows.Forms.Panel pnlAppointmentDetails;
        private System.Windows.Forms.ComboBox cmbHospitalFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridAppointments;
        private System.Windows.Forms.Button btnShowAllPatients;
        private System.Windows.Forms.Panel pnlMyInfo;
        private System.Windows.Forms.Label lblConsultantDetailsInfo;
        private System.Windows.Forms.Label lblConsultantPersonalDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFilterByDate;
        private System.Windows.Forms.Button btnShowAllAppointments;
    }
}