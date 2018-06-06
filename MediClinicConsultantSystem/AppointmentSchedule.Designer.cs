namespace MediClinicConsultantSystem
{
    partial class AppointmentSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentSchedule));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tblpnlSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnRemoveThursday = new System.Windows.Forms.Button();
            this.btnRemoveSunday = new System.Windows.Forms.Button();
            this.btnRemoveSaturday = new System.Windows.Forms.Button();
            this.btnRemoveFriday = new System.Windows.Forms.Button();
            this.btnRemoveWednesday = new System.Windows.Forms.Button();
            this.btnRemoveTuesday = new System.Windows.Forms.Button();
            this.btnRemoveMonday = new System.Windows.Forms.Button();
            this.btnAddSaturday = new System.Windows.Forms.Button();
            this.btnAddSunday = new System.Windows.Forms.Button();
            this.btnAddFriday = new System.Windows.Forms.Button();
            this.btnAddThursday = new System.Windows.Forms.Button();
            this.btnAddWednesday = new System.Windows.Forms.Button();
            this.btnAddTuesday = new System.Windows.Forms.Button();
            this.btnAddMonday = new System.Windows.Forms.Button();
            this.Wednesday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.Tuesday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.Thursday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.Friday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.Saturday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.Sunday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.Monday1 = new MediClinicConsultantSystem.AppointmentTimeSchedule();
            this.pnlHeader.SuspendLayout();
            this.tblpnlSchedule.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1033, 32);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Back_32;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = false;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 50D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(-11, -5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.OnHovercolor = System.Drawing.Color.Turquoise;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(78, 44);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSaveSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveSchedule.BorderRadius = 0;
            this.btnSaveSchedule.ButtonText = "Save Schedule";
            this.btnSaveSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveSchedule.Iconimage = null;
            this.btnSaveSchedule.Iconimage_right = null;
            this.btnSaveSchedule.Iconimage_right_Selected = null;
            this.btnSaveSchedule.Iconimage_Selected = null;
            this.btnSaveSchedule.IconMarginLeft = 0;
            this.btnSaveSchedule.IconMarginRight = 0;
            this.btnSaveSchedule.IconRightVisible = true;
            this.btnSaveSchedule.IconRightZoom = 0D;
            this.btnSaveSchedule.IconVisible = true;
            this.btnSaveSchedule.IconZoom = 90D;
            this.btnSaveSchedule.IsTab = false;
            this.btnSaveSchedule.Location = new System.Drawing.Point(827, 479);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSaveSchedule.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveSchedule.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveSchedule.selected = false;
            this.btnSaveSchedule.Size = new System.Drawing.Size(195, 48);
            this.btnSaveSchedule.TabIndex = 8;
            this.btnSaveSchedule.Text = "Save Schedule";
            this.btnSaveSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveSchedule.Textcolor = System.Drawing.Color.White;
            this.btnSaveSchedule.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // tblpnlSchedule
            // 
            this.tblpnlSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnlSchedule.AutoScroll = true;
            this.tblpnlSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblpnlSchedule.ColumnCount = 7;
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlSchedule.Controls.Add(this.Wednesday1, 2, 1);
            this.tblpnlSchedule.Controls.Add(this.Tuesday1, 1, 1);
            this.tblpnlSchedule.Controls.Add(this.Thursday1, 3, 1);
            this.tblpnlSchedule.Controls.Add(this.Friday1, 4, 1);
            this.tblpnlSchedule.Controls.Add(this.Saturday1, 5, 1);
            this.tblpnlSchedule.Controls.Add(this.Sunday1, 6, 1);
            this.tblpnlSchedule.Controls.Add(this.Monday1, 0, 1);
            this.tblpnlSchedule.Controls.Add(this.label1, 2, 0);
            this.tblpnlSchedule.Controls.Add(this.label2, 1, 0);
            this.tblpnlSchedule.Controls.Add(this.label3, 3, 0);
            this.tblpnlSchedule.Controls.Add(this.label4, 4, 0);
            this.tblpnlSchedule.Controls.Add(this.label5, 5, 0);
            this.tblpnlSchedule.Controls.Add(this.label6, 6, 0);
            this.tblpnlSchedule.Controls.Add(this.label7, 0, 0);
            this.tblpnlSchedule.Location = new System.Drawing.Point(12, 22);
            this.tblpnlSchedule.Name = "tblpnlSchedule";
            this.tblpnlSchedule.RowCount = 2;
            this.tblpnlSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlSchedule.Size = new System.Drawing.Size(1033, 198);
            this.tblpnlSchedule.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(283, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wednesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(143, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tuesday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(423, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thursday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(567, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Friday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(707, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saturday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(847, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Monday";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblpnlSchedule);
            this.panel1.Location = new System.Drawing.Point(2, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 198);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(11, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(629, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "(Note: Session interval can only be removed if there is more than one instance of" +
    " that Session in the day column).\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(11, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(671, 105);
            this.label10.TabIndex = 11;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnRemoveThursday
            // 
            this.btnRemoveThursday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveThursday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveThursday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveThursday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveThursday.FlatAppearance.BorderSize = 0;
            this.btnRemoveThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveThursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveThursday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveThursday.Location = new System.Drawing.Point(435, 38);
            this.btnRemoveThursday.Name = "btnRemoveThursday";
            this.btnRemoveThursday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveThursday.TabIndex = 9;
            this.btnRemoveThursday.Text = "Remove Session";
            this.btnRemoveThursday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveThursday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveThursday.UseVisualStyleBackColor = false;
            this.btnRemoveThursday.Click += new System.EventHandler(this.btnRemoveThursday_Click);
            // 
            // btnRemoveSunday
            // 
            this.btnRemoveSunday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveSunday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveSunday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveSunday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveSunday.FlatAppearance.BorderSize = 0;
            this.btnRemoveSunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveSunday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveSunday.Location = new System.Drawing.Point(859, 38);
            this.btnRemoveSunday.Name = "btnRemoveSunday";
            this.btnRemoveSunday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveSunday.TabIndex = 9;
            this.btnRemoveSunday.Text = "Remove Session";
            this.btnRemoveSunday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveSunday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveSunday.UseVisualStyleBackColor = false;
            this.btnRemoveSunday.Click += new System.EventHandler(this.btnRemoveSunday_Click);
            // 
            // btnRemoveSaturday
            // 
            this.btnRemoveSaturday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveSaturday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveSaturday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveSaturday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveSaturday.FlatAppearance.BorderSize = 0;
            this.btnRemoveSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSaturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveSaturday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveSaturday.Location = new System.Drawing.Point(719, 38);
            this.btnRemoveSaturday.Name = "btnRemoveSaturday";
            this.btnRemoveSaturday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveSaturday.TabIndex = 9;
            this.btnRemoveSaturday.Text = "Remove Session";
            this.btnRemoveSaturday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveSaturday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveSaturday.UseVisualStyleBackColor = false;
            this.btnRemoveSaturday.Click += new System.EventHandler(this.btnRemoveSaturday_Click);
            // 
            // btnRemoveFriday
            // 
            this.btnRemoveFriday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveFriday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveFriday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveFriday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveFriday.FlatAppearance.BorderSize = 0;
            this.btnRemoveFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFriday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveFriday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveFriday.Location = new System.Drawing.Point(579, 38);
            this.btnRemoveFriday.Name = "btnRemoveFriday";
            this.btnRemoveFriday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveFriday.TabIndex = 9;
            this.btnRemoveFriday.Text = "Remove Session";
            this.btnRemoveFriday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveFriday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveFriday.UseVisualStyleBackColor = false;
            this.btnRemoveFriday.Click += new System.EventHandler(this.btnRemoveFriday_Click);
            // 
            // btnRemoveWednesday
            // 
            this.btnRemoveWednesday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveWednesday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveWednesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveWednesday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveWednesday.FlatAppearance.BorderSize = 0;
            this.btnRemoveWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveWednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveWednesday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveWednesday.Location = new System.Drawing.Point(294, 38);
            this.btnRemoveWednesday.Name = "btnRemoveWednesday";
            this.btnRemoveWednesday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveWednesday.TabIndex = 9;
            this.btnRemoveWednesday.Text = "Remove Session";
            this.btnRemoveWednesday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveWednesday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveWednesday.UseVisualStyleBackColor = false;
            this.btnRemoveWednesday.Click += new System.EventHandler(this.btnRemoveWednesday_Click);
            // 
            // btnRemoveTuesday
            // 
            this.btnRemoveTuesday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveTuesday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveTuesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveTuesday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveTuesday.FlatAppearance.BorderSize = 0;
            this.btnRemoveTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveTuesday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveTuesday.Location = new System.Drawing.Point(155, 38);
            this.btnRemoveTuesday.Name = "btnRemoveTuesday";
            this.btnRemoveTuesday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveTuesday.TabIndex = 9;
            this.btnRemoveTuesday.Text = "Remove Session";
            this.btnRemoveTuesday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveTuesday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveTuesday.UseVisualStyleBackColor = false;
            this.btnRemoveTuesday.Click += new System.EventHandler(this.btnRemoveTuesday_Click);
            // 
            // btnRemoveMonday
            // 
            this.btnRemoveMonday.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveMonday.BackgroundImage = global::MediClinicConsultantSystem.Properties.Resources.icons8_Delete_Row48_48;
            this.btnRemoveMonday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveMonday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveMonday.FlatAppearance.BorderSize = 0;
            this.btnRemoveMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMonday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveMonday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveMonday.Location = new System.Drawing.Point(15, 38);
            this.btnRemoveMonday.Name = "btnRemoveMonday";
            this.btnRemoveMonday.Size = new System.Drawing.Size(134, 75);
            this.btnRemoveMonday.TabIndex = 9;
            this.btnRemoveMonday.Text = "Remove Session";
            this.btnRemoveMonday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveMonday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveMonday.UseVisualStyleBackColor = false;
            this.btnRemoveMonday.Click += new System.EventHandler(this.btnRemoveMonday_Click);
            // 
            // btnAddSaturday
            // 
            this.btnAddSaturday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSaturday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddSaturday.FlatAppearance.BorderSize = 0;
            this.btnAddSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSaturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddSaturday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddSaturday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSaturday.Location = new System.Drawing.Point(719, 333);
            this.btnAddSaturday.Name = "btnAddSaturday";
            this.btnAddSaturday.Size = new System.Drawing.Size(134, 75);
            this.btnAddSaturday.TabIndex = 4;
            this.btnAddSaturday.Text = "Add Session";
            this.btnAddSaturday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSaturday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSaturday.UseVisualStyleBackColor = false;
            this.btnAddSaturday.Click += new System.EventHandler(this.btnAddSaturday_Click);
            // 
            // btnAddSunday
            // 
            this.btnAddSunday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSunday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddSunday.FlatAppearance.BorderSize = 0;
            this.btnAddSunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddSunday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddSunday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSunday.Location = new System.Drawing.Point(859, 333);
            this.btnAddSunday.Name = "btnAddSunday";
            this.btnAddSunday.Size = new System.Drawing.Size(134, 75);
            this.btnAddSunday.TabIndex = 4;
            this.btnAddSunday.Text = "Add Session";
            this.btnAddSunday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSunday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSunday.UseVisualStyleBackColor = false;
            this.btnAddSunday.Click += new System.EventHandler(this.btnAddSunday_Click);
            // 
            // btnAddFriday
            // 
            this.btnAddFriday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFriday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddFriday.FlatAppearance.BorderSize = 0;
            this.btnAddFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddFriday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddFriday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddFriday.Location = new System.Drawing.Point(579, 333);
            this.btnAddFriday.Name = "btnAddFriday";
            this.btnAddFriday.Size = new System.Drawing.Size(134, 75);
            this.btnAddFriday.TabIndex = 4;
            this.btnAddFriday.Text = "Add Session";
            this.btnAddFriday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddFriday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddFriday.UseVisualStyleBackColor = false;
            this.btnAddFriday.Click += new System.EventHandler(this.btnAddFriday_Click);
            // 
            // btnAddThursday
            // 
            this.btnAddThursday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddThursday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddThursday.FlatAppearance.BorderSize = 0;
            this.btnAddThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddThursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddThursday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddThursday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddThursday.Location = new System.Drawing.Point(435, 333);
            this.btnAddThursday.Name = "btnAddThursday";
            this.btnAddThursday.Size = new System.Drawing.Size(134, 75);
            this.btnAddThursday.TabIndex = 4;
            this.btnAddThursday.Text = "Add Session";
            this.btnAddThursday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddThursday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddThursday.UseVisualStyleBackColor = false;
            this.btnAddThursday.Click += new System.EventHandler(this.btnAddThursday_Click);
            // 
            // btnAddWednesday
            // 
            this.btnAddWednesday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWednesday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddWednesday.FlatAppearance.BorderSize = 0;
            this.btnAddWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddWednesday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddWednesday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddWednesday.Location = new System.Drawing.Point(295, 333);
            this.btnAddWednesday.Name = "btnAddWednesday";
            this.btnAddWednesday.Size = new System.Drawing.Size(134, 75);
            this.btnAddWednesday.TabIndex = 4;
            this.btnAddWednesday.Text = "Add Session";
            this.btnAddWednesday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddWednesday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddWednesday.UseVisualStyleBackColor = false;
            this.btnAddWednesday.Click += new System.EventHandler(this.btnAddWednesday_Click);
            // 
            // btnAddTuesday
            // 
            this.btnAddTuesday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTuesday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddTuesday.FlatAppearance.BorderSize = 0;
            this.btnAddTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddTuesday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddTuesday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTuesday.Location = new System.Drawing.Point(155, 333);
            this.btnAddTuesday.Name = "btnAddTuesday";
            this.btnAddTuesday.Size = new System.Drawing.Size(134, 75);
            this.btnAddTuesday.TabIndex = 4;
            this.btnAddTuesday.Text = "Add Session";
            this.btnAddTuesday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTuesday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddTuesday.UseVisualStyleBackColor = false;
            this.btnAddTuesday.Click += new System.EventHandler(this.btnAddTuesday_Click);
            // 
            // btnAddMonday
            // 
            this.btnAddMonday.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMonday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddMonday.FlatAppearance.BorderSize = 0;
            this.btnAddMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMonday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddMonday.Image = global::MediClinicConsultantSystem.Properties.Resources.icons8_Add_Row_48;
            this.btnAddMonday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMonday.Location = new System.Drawing.Point(15, 333);
            this.btnAddMonday.Name = "btnAddMonday";
            this.btnAddMonday.Size = new System.Drawing.Size(134, 75);
            this.btnAddMonday.TabIndex = 4;
            this.btnAddMonday.Text = "Add Session";
            this.btnAddMonday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMonday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMonday.UseVisualStyleBackColor = false;
            this.btnAddMonday.Click += new System.EventHandler(this.btnAddMonday_Click);
            // 
            // Wednesday1
            // 
            this.Wednesday1.BackColor = System.Drawing.Color.Transparent;
            this.Wednesday1.GroupBoxTitle = "Session 1";
            this.Wednesday1.Location = new System.Drawing.Point(283, 28);
            this.Wednesday1.Name = "Wednesday1";
            this.Wednesday1.Size = new System.Drawing.Size(134, 137);
            this.Wednesday1.TabIndex = 0;
            // 
            // Tuesday1
            // 
            this.Tuesday1.BackColor = System.Drawing.Color.Transparent;
            this.Tuesday1.GroupBoxTitle = "Session 1";
            this.Tuesday1.Location = new System.Drawing.Point(143, 28);
            this.Tuesday1.Name = "Tuesday1";
            this.Tuesday1.Size = new System.Drawing.Size(134, 137);
            this.Tuesday1.TabIndex = 1;
            // 
            // Thursday1
            // 
            this.Thursday1.BackColor = System.Drawing.Color.Transparent;
            this.Thursday1.GroupBoxTitle = "Session 1";
            this.Thursday1.Location = new System.Drawing.Point(423, 28);
            this.Thursday1.Name = "Thursday1";
            this.Thursday1.Size = new System.Drawing.Size(138, 137);
            this.Thursday1.TabIndex = 2;
            // 
            // Friday1
            // 
            this.Friday1.BackColor = System.Drawing.Color.Transparent;
            this.Friday1.GroupBoxTitle = "Session 1";
            this.Friday1.Location = new System.Drawing.Point(567, 28);
            this.Friday1.Name = "Friday1";
            this.Friday1.Size = new System.Drawing.Size(134, 137);
            this.Friday1.TabIndex = 3;
            // 
            // Saturday1
            // 
            this.Saturday1.BackColor = System.Drawing.Color.Transparent;
            this.Saturday1.GroupBoxTitle = "Session 1";
            this.Saturday1.Location = new System.Drawing.Point(707, 28);
            this.Saturday1.Name = "Saturday1";
            this.Saturday1.Size = new System.Drawing.Size(134, 137);
            this.Saturday1.TabIndex = 4;
            // 
            // Sunday1
            // 
            this.Sunday1.BackColor = System.Drawing.Color.Transparent;
            this.Sunday1.GroupBoxTitle = "Session 1";
            this.Sunday1.Location = new System.Drawing.Point(847, 28);
            this.Sunday1.Name = "Sunday1";
            this.Sunday1.Size = new System.Drawing.Size(134, 137);
            this.Sunday1.TabIndex = 5;
            // 
            // Monday1
            // 
            this.Monday1.BackColor = System.Drawing.Color.Transparent;
            this.Monday1.GroupBoxTitle = "Session 1";
            this.Monday1.Location = new System.Drawing.Point(3, 28);
            this.Monday1.Name = "Monday1";
            this.Monday1.Size = new System.Drawing.Size(134, 137);
            this.Monday1.TabIndex = 6;
            // 
            // AppointmentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1033, 531);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemoveThursday);
            this.Controls.Add(this.btnRemoveSunday);
            this.Controls.Add(this.btnRemoveSaturday);
            this.Controls.Add(this.btnRemoveFriday);
            this.Controls.Add(this.btnRemoveWednesday);
            this.Controls.Add(this.btnRemoveTuesday);
            this.Controls.Add(this.btnRemoveMonday);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.btnAddSaturday);
            this.Controls.Add(this.btnAddSunday);
            this.Controls.Add(this.btnAddFriday);
            this.Controls.Add(this.btnAddThursday);
            this.Controls.Add(this.btnAddWednesday);
            this.Controls.Add(this.btnAddTuesday);
            this.Controls.Add(this.btnAddMonday);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppointmentSchedule";
            this.Load += new System.EventHandler(this.AppointmentSchedule_Load);
            this.pnlHeader.ResumeLayout(false);
            this.tblpnlSchedule.ResumeLayout(false);
            this.tblpnlSchedule.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnAddMonday;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveSchedule;
        private System.Windows.Forms.TableLayoutPanel tblpnlSchedule;
        private AppointmentTimeSchedule Wednesday1;
        private AppointmentTimeSchedule Tuesday1;
        private AppointmentTimeSchedule Thursday1;
        private AppointmentTimeSchedule Friday1;
        private AppointmentTimeSchedule Saturday1;
        private AppointmentTimeSchedule Sunday1;
        private AppointmentTimeSchedule Monday1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTuesday;
        private System.Windows.Forms.Button btnAddWednesday;
        private System.Windows.Forms.Button btnAddThursday;
        private System.Windows.Forms.Button btnAddFriday;
        private System.Windows.Forms.Button btnAddSaturday;
        private System.Windows.Forms.Button btnAddSunday;
        private System.Windows.Forms.Button btnRemoveMonday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveTuesday;
        private System.Windows.Forms.Button btnRemoveWednesday;
        private System.Windows.Forms.Button btnRemoveThursday;
        private System.Windows.Forms.Button btnRemoveFriday;
        private System.Windows.Forms.Button btnRemoveSaturday;
        private System.Windows.Forms.Button btnRemoveSunday;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}