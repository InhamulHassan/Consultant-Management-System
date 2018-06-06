using MediClinicChannelingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediClinicConsultantSystem
{
    public partial class HomeScreen : Form
    {

        SqlConnection con;
        String ConsultantIDGlobal;  //declaring a global value for the ConsultantID, so that it can be used to retrieve other table data
        string FullName; //this variable is used for constructing the Consultant's full name using his first/last name

        public HomeScreen()
        {
            InitializeComponent();
            DBConnection obj = new DBConnection(); //setting up the database connection
            con = obj.getConnection();// initializing the connection to the connection object
        }

        public void StartTimer()
        {
            System.Windows.Forms.Timer tmr = null;
            tmr = new System.Windows.Forms.Timer(); //creating a new Timer object to have a running clock 
            tmr.Interval = 1000; //setting the time interval to 1 second (or 1000 milliseconds)
            tmr.Tick += new EventHandler(timer1_Tick); //this creates a new tick event handler to keep the time running
            tmr.Enabled = true;//enabling the timer object
        }

        private void FillMyInfo()
        {
            List<string> DoctorQualifications = new List<string>();
            List<string> DoctorSpecialities = new List<string>();
            List<string> AffliatedHospitals = new List<string>();
            string Qualifications = string.Empty;
            string Specialities = string.Empty;
            string Hospitals = string.Empty;
            string FullName = string.Empty;
            string PracticingFrom = string.Empty;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = @"SELECT ConsultantTable.FirstName + ' ' + ConsultantTable.LastName AS FullName, ConsultantTable.Practicing_From, ConsultantOfficeTable.OfficeName + ' - ' + ConsultantOfficeTable.LocatedCity AS OfficeDetails, QualificationsListTable.QualificationName, SpecialitiesListTable.SpecialityName
                                                FROM ConsultantTable
                                                INNER JOIN ConsultantOfficeTable ON ConsultantTable.ConsultantID = ConsultantOfficeTable.ConsultantID
											    INNER JOIN DoctorQualifications ON ConsultantTable.ConsultantID = DoctorQualifications.ConsultantID
											    INNER JOIN DoctorSpecialities ON ConsultantTable.ConsultantID = DoctorSpecialities.ConsultantID
                                                INNER JOIN QualificationsListTable ON DoctorQualifications.QualificationID = QualificationsListTable.QualificationID
											    INNER JOIN SpecialitiesListTable ON DoctorSpecialities.SpecialityID = SpecialitiesListTable.SpecialityID
                                                WHERE ConsultantTable.ConsultantID =  @cid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantIDGlobal;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            FullName = reader[0].ToString().Trim();
                            PracticingFrom = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                            AffliatedHospitals.Add(reader[2].ToString().Trim());
                            DoctorQualifications.Add(reader[3].ToString().Trim());
                            DoctorSpecialities.Add(reader[4].ToString().Trim());
                        }
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when filling the My Info Form\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach(string DistinctElement in AffliatedHospitals.Distinct())
            {
                Hospitals += DistinctElement + ", ";
            }
            foreach (string DistinctElement in DoctorQualifications.Distinct())
            {
                Qualifications += DistinctElement + ", ";
            }
            foreach (string DistinctElement in DoctorSpecialities.Distinct())
            {
                Specialities += DistinctElement + ", ";
            }

            lblConsultantPersonalDetails.Text = string.Format("Full Name                     {0}\nPracticing From        {1}", FullName, PracticingFrom);
            lblConsultantDetailsInfo.Text = string.Format("Affliated Hospital(s)     {0}\nQualification(s)                {1}\nSpecialized In                   {2}", Hospitals.Remove(Hospitals.Length - 2, 2), Qualifications.Remove(Qualifications.Length - 2, 2), Specialities.Remove(Specialities.Length - 2, 2));
        }

        private void SetDateTime()
        {
            string suffix = (DateTime.Now.Day % 10 == 1 && DateTime.Now.Day != 11) ? "st"
                : (DateTime.Now.Day % 10 == 2 && DateTime.Now.Day != 12) ? "nd"
                    : (DateTime.Now.Day % 10 == 3 && DateTime.Now.Day != 13) ? "rd"
                        : "th";

            //the (?:) operator is the shorthand versio of the if-else statement
            //the above condition is used to set the suffux of the dat (ie. 22nd, 31st)
            string CurrentDate = string.Format("{0:dddd} {2} {0:dd}{1} {3} {0:MMMM yyyy}", DateTime.Now, suffix, "the", "of");
            /*
             dddd = represents the day of the week(eg. Tuesday)
             dd = represents the date of the month(eg. 21) 
             MMMM = represents the name of the Month(eg. December)
             yyyy = represents the year(2017)

             the numbers 1,2,3 insede the curly braces are the parametric objects that is included to the right side of the string date literals above
             */

            string LogTime = string.Format("{0:h:mm:ss tt}", DateTime.Now);

            lblDateToday.Text = "Today is " + CurrentDate;
            lblLogTime.Text = "Time of Login: " + LogTime;
        }

        private void EmptyDataSetMessage(bool Visibility, Panel ParentName)
        {
            if(Visibility)
            {
                Label Message = new Label();
                Message.Name = "Label";
                Message.Text = "No Records Found";
                Message.TextAlign = ContentAlignment.MiddleCenter;
                Message.Location = new Point(0, 257);
                Message.AutoSize = false;
                Message.Parent = pnlAppointmentDetails;
                Message.Size = new Size(1046, 54);
                Message.Font = new Font("Century Gothic", 18, FontStyle.Regular);
                Message.ForeColor = SystemColors.Control;
                Message.BackColor = Color.FromArgb(44, 44, 43);
                Message.Visible = true;
                ParentName.Controls.Add(Message);
                Message.BringToFront();
            }
            else
            {
                for (int lbl = this.Controls.Count - 1; lbl >= 0; lbl--)
                {
                    if (ParentName.Controls[lbl] is Label) ParentName.Controls[lbl].Dispose();
                }
            }
        }

        private void LogoutWindow()
        {
            //this method is used to logout of the chosen form
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
            obj.Closed += (s, args) => Close();
        }

        private void PopulatePatientComboBox()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = "SELECT Record_ID, PatientFirstName + ' ' + PatientLastName AS PatientFullName FROM PatientRecordsTable WHERE ConsultantID = @cid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantIDGlobal;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AppointmentTable");

                    cmbPatientName.DataSource = ds;
                    cmbPatientName.DisplayMember = "AppointmentTable.PatientFullName";
                    cmbPatientName.ValueMember = "AppointmentTable.Record_ID";
                    cmbPatientName.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbPatientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing the Patient Names\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbPatientName.Text = "Select a Patient";
        }

        private void PopulateHospitalFilterComboBox()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = "SELECT ConsultantOfficeID, OfficeName FROM ConsultantOfficeTable WHERE ConsultantID = @cid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantIDGlobal;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ConsultantOfficeTable");

                    cmbHospitalFilter.DataSource = ds;
                    cmbHospitalFilter.DisplayMember = "ConsultantOfficeTable.OfficeName";
                    cmbHospitalFilter.ValueMember = "ConsultantOfficeTable.ConsultantOfficeID";
                    cmbHospitalFilter.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbHospitalFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing the Patient Names\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbHospitalFilter.Text = "Select a Hospital";
        }

        private void PopulateHospitalFilteredDataView(string ConsultantOfficeID)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = @"SELECT ConsultantOfficeTable.OfficeName + ' - ' + ConsultantOfficeTable.LocatedCity AS HospitalName, AppointmentTable.PatientName, AppointmentTable.PatientContactInfo, AppointmentTable.AppointmentDate, DATEADD(MINUTE, (ConsultantOfficeTable.TimeSlotPerClient * SUBSTRING(AppointmentTable.AppointmentID, 11, 2)),  AppointmentScheduleTable.StartTime) AS AppointmentStartTime, AppointmentStatusList.StatusDescription
                                                FROM AppointmentTable
						                        INNER JOIN AppointmentStatusList ON AppointmentTable.AppointmentStatusID = AppointmentStatusList.AppointmentStatusID
						                        INNER JOIN AppointmentScheduleTable ON AppointmentTable.AppointmentScheduleID = AppointmentScheduleTable.AppointmentScheduleID
                                                INNER JOIN ConsultantOfficeTable ON AppointmentTable.ConsultantOfficeID = ConsultantOfficeTable.ConsultantOfficeID
                                                WHERE AppointmentTable.ConsultantOfficeID = @coid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@coid", SqlDbType.VarChar).Value = ConsultantOfficeID;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AppointmentTable");
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        EmptyDataSetMessage(true, pnlAppointmentDetails);
                        dataGridAppointments.DataSource = null;
                    }
                    else
                    {
                        EmptyDataSetMessage(false, pnlAppointmentDetails);
                        dataGridAppointments.DataSource = ds;
                        dataGridAppointments.DataMember = "AppointmentTable";
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing all the Appointments\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateSelectedPatientDataView(string RecordID)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = @"SELECT PatientRecordsTable.Record_ID, AppointmentTable.PatientName, PatientRecordsTable.PatientAge, PatientRecordsTable.ContactNumber, ConsultantOfficeTable.OfficeName + ' - ' + ConsultantOfficeTable.LocatedCity AS HospitalName, PatientRecordsTable.ProblemDescription, PatientRecordsTable.PrescriptionDetails
                                            FROM AppointmentTable
                                            INNER JOIN PatientRecordsTable ON AppointmentTable.AppointmentID = PatientRecordsTable.AppointmentID
                                            INNER JOIN ConsultantOfficeTable ON AppointmentTable.ConsultantOfficeID = ConsultantOfficeTable.ConsultantOfficeID
                                            WHERE PatientRecordsTable.Record_ID = @rid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@rid", SqlDbType.VarChar).Value = RecordID;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AppointmentTable");

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        EmptyDataSetMessage(true, pnlRecords);
                        datagridPatientRecords.DataSource = null;
                    }
                    else
                    {
                        EmptyDataSetMessage(false, pnlRecords);
                        datagridPatientRecords.DataSource = ds;
                        datagridPatientRecords.DataMember = "AppointmentTable";
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing the PatientRecords\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulatePatientRecords()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = @"SELECT PatientRecordsTable.Record_ID, AppointmentTable.PatientName, PatientRecordsTable.PatientAge, PatientRecordsTable.ContactNumber, ConsultantOfficeTable.OfficeName + ' - ' + ConsultantOfficeTable.LocatedCity AS HospitalName, PatientRecordsTable.ProblemDescription, PatientRecordsTable.PrescriptionDetails
                                            FROM AppointmentTable
                                            INNER JOIN PatientRecordsTable ON AppointmentTable.AppointmentID = PatientRecordsTable.AppointmentID
                                            INNER JOIN ConsultantOfficeTable ON AppointmentTable.ConsultantOfficeID = ConsultantOfficeTable.ConsultantOfficeID
                                            WHERE PatientRecordsTable.ConsultantID = @cid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantIDGlobal;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AppointmentTable");

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        EmptyDataSetMessage(true, pnlRecords);
                        datagridPatientRecords.DataSource = null;
                    }
                    else
                    {
                        EmptyDataSetMessage(false, pnlRecords);
                        datagridPatientRecords.DataSource = ds;
                        datagridPatientRecords.DataMember = "AppointmentTable";
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing all the Patient Records\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAppointments()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = @"SELECT ConsultantOfficeTable.OfficeName + ' - ' + ConsultantOfficeTable.LocatedCity AS HospitalName, AppointmentTable.PatientName, AppointmentTable.PatientContactInfo, AppointmentTable.AppointmentDate, DATEADD(MINUTE, (ConsultantOfficeTable.TimeSlotPerClient * SUBSTRING(AppointmentTable.AppointmentID, 11, 2)),  AppointmentScheduleTable.StartTime) AS AppointmentStartTime, AppointmentStatusList.StatusDescription
                                                FROM AppointmentTable
						                        INNER JOIN AppointmentStatusList ON AppointmentTable.AppointmentStatusID = AppointmentStatusList.AppointmentStatusID
						                        INNER JOIN AppointmentScheduleTable ON AppointmentTable.AppointmentScheduleID = AppointmentScheduleTable.AppointmentScheduleID
                                                INNER JOIN ConsultantOfficeTable ON AppointmentTable.ConsultantOfficeID = ConsultantOfficeTable.ConsultantOfficeID
                                                WHERE AppointmentTable.ConsultantID = @cid";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantIDGlobal;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AppointmentTable");

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        EmptyDataSetMessage(true, pnlAppointmentDetails);
                        dataGridAppointments.DataSource = null;
                    }
                    else
                    {
                        EmptyDataSetMessage(false, pnlAppointmentDetails);
                        dataGridAppointments.DataSource = ds;
                        dataGridAppointments.DataMember = "AppointmentTable";
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing all the Appointments\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAppointmentByDate(DateTime StartDate, DateTime EndDate)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string ConnectionString = @"SELECT ConsultantOfficeTable.OfficeName + ' - ' + ConsultantOfficeTable.LocatedCity AS HospitalName, AppointmentTable.PatientName, AppointmentTable.PatientContactInfo, AppointmentTable.AppointmentDate, DATEADD(MINUTE, (ConsultantOfficeTable.TimeSlotPerClient * SUBSTRING(AppointmentTable.AppointmentID, 11, 2)),  AppointmentScheduleTable.StartTime) AS AppointmentStartTime, AppointmentStatusList.StatusDescription
                                                FROM AppointmentTable
						                        INNER JOIN AppointmentStatusList ON AppointmentTable.AppointmentStatusID = AppointmentStatusList.AppointmentStatusID
						                        INNER JOIN AppointmentScheduleTable ON AppointmentTable.AppointmentScheduleID = AppointmentScheduleTable.AppointmentScheduleID
                                                INNER JOIN ConsultantOfficeTable ON AppointmentTable.ConsultantOfficeID = ConsultantOfficeTable.ConsultantOfficeID
                                                WHERE AppointmentTable.AppointmentDate >= @start AND AppointmentTable.AppointmentDate <= @end ORDER BY AppointmentTable.AppointmentDate ASC";
                using (SqlCommand cmd = new SqlCommand(ConnectionString, con))
                {
                    cmd.Parameters.AddWithValue("@start", SqlDbType.Date).Value = StartDate;
                    cmd.Parameters.AddWithValue("@end", SqlDbType.Date).Value = EndDate;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AppointmentTable");

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        EmptyDataSetMessage(true, pnlAppointmentDetails);
                        dataGridAppointments.DataSource = null;
                    }
                    else
                    {
                        EmptyDataSetMessage(false, pnlAppointmentDetails);
                        dataGridAppointments.DataSource = ds;
                        dataGridAppointments.DataMember = "AppointmentTable";
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing all the Appointments by date\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ConsultantInfo(string ConsultantID)
        {
            ConsultantIDGlobal = ConsultantID; //setting the ConsultantID retrieved from using the Login Form's ConsultantLoginTable
            string FirstName;
            string LastName;
            string PracticingFromDate;
            try
            {
                //retrieving the data from the ConsultantTable and displaying them in the form
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, Practicing_From FROM ConsultantTable WHERE ConsultantID = @cid", con))
                {
                    cmd.Parameters.AddWithValue("@cid", ConsultantID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool consultantFound = reader.HasRows;
                    if (consultantFound)
                    {
                        while (reader.Read())
                        {
                            FirstName = reader[0].ToString().Trim();
                            LastName = reader[1].ToString().Trim();
                            PracticingFromDate = reader[2].ToString().Trim();

                            FullName = FirstName + " " + LastName;
                            lblConsultantName.Text = "Dr. " + FullName;
                        }
                    }
                    con.Close(); 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when retreiving the Consultant Details\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ConsultantOfficeInfo(string ConsultantID)
        {
            string ConsultantOfficeID = string.Empty;
            string OfficeName = string.Empty;
            string LocatedCity = string.Empty;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT ConsultantOfficeID, OfficeName, LocatedCity FROM ConsultantOfficeTable WHERE ConsultantID = @cid", con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantID;
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool Found = reader.HasRows;
                    if (Found)
                    {
                        while (reader.Read())
                        {
                            ConsultantOfficeID = reader[0].ToString().Trim(); //the consultant Office ID is set as a global value so that it can be used by other methods
                            OfficeName = reader[1].ToString().Trim(); //the office name is either the hospital's name or the private clnic's name
                            LocatedCity = reader[2].ToString().Trim();//this is the city where the office is located

                            string HospitalInfo = OfficeName + " - " + LocatedCity;

                            Button HospitalButton = Hospitals(HospitalInfo, ConsultantOfficeID); 
                            flwpnlHospitals.Controls.Add(HospitalButton);
                        }
                    }
                    reader.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when listing the Affliated Hospitals\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this will close the current form
            Close();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            //this is used to either maximize or normalize a window
            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            //maximises window
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //this is used to minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string CurrentTime = string.Format("{0:h:mm:ss tt}", DateTime.Now);
            lblCurrentTime.Text = CurrentTime;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedule.Show();
            pnlSchedule.BringToFront();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            pnlRecords.Show();
            pnlRecords.BringToFront();
        }

        private void btnAppoinments_Click(object sender, EventArgs e)
        {
            pnlAppointmentDetails.Show();
            pnlAppointmentDetails.BringToFront();
        }

        private void btnMyDetails_Click(object sender, EventArgs e)
        {
            pnlMyInfo.Show();
            pnlMyInfo.BringToFront();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            SetDateTime(); //this helps to display the date and the time on the home screen when it loads
            FillMyInfo();
            PopulatePatientComboBox();
            PopulateHospitalFilterComboBox();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout function in the second panel
            LogoutWindow();
        }

        Button Hospitals(string HospitalName, string ConsultantOfficeID)
        {
            Button btn = new Button(); //this dynamically creates a new button control
            btn.Click += new EventHandler(button_Click); //this creates a new event handler method for that button
            btn.Name = ConsultantOfficeID; //this sets the button control's name as the ConsultantOfficeID, so that it can be used to reference the seleceted office (or hospital)
            btn.FlatStyle = FlatStyle.Flat; //this sets the button's style as Flat             
            btn.Text = HospitalName; //this defines the button's displayed text
            btn.Height = 52; //this sets the button height
            btn.Width = 1000; //this sets the button width
            btn.ForeColor = SystemColors.ControlLight;//this sets the button's fore color
            Color backColor = Color.FromArgb(44, 42, 43); //this defines the button back color 
            btn.BackColor = backColor;//this sets the button's back color
            btn.FlatAppearance.BorderColor = Color.LightSeaGreen; //this sets the button's border color
            btn.FlatAppearance.BorderSize = 3;  //this sets the button's border size
            btn.FlatAppearance.MouseDownBackColor = Color.DarkTurquoise; //this sets the button's color when the mouse clicks it
            btn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen; //this sets the button's color when the mouse hovers over it
            btn.Font = new Font("Book Antiqua", 14, FontStyle.Regular); //this sets the font of the button's displayed text
            btn.TextAlign = ContentAlignment.MiddleCenter; //this sets the text alignment of the button's displayed text
            btn.Padding = new Padding(5); //this sets the buttons paddings
            return btn;//this return the button's custome preferences to the calling method
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button AffliiatedHospitalButton = sender as Button;
            AppointmentSchedule schedule = new AppointmentSchedule();
            schedule.SettingConsultantInformation(ConsultantIDGlobal, AffliiatedHospitalButton.Name);
            schedule.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlMainScreen.Show();
            pnlAppointmentDetails.Hide();
            pnlRecords.Hide();
            pnlSchedule.Hide();
        }

        private void cmbPatientName_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= -1)
            {
                Graphics g = e.Graphics;
                Brush brush = (e.State.HasFlag(DrawItemState.Selected)) ?
                               new SolidBrush(Color.LightSeaGreen) : new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(cmbPatientName.GetItemText(cmbPatientName.Items[e.Index]).ToString(), e.Font,
                           tBrush, e.Bounds, StringFormat.GenericDefault);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void cmbPatientName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string RecordID = cmbPatientName.SelectedValue.ToString();
            PopulateSelectedPatientDataView(RecordID);
        }

        private void datagridPatientRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = datagridPatientRecords.Rows[e.RowIndex];// get you required index
                                                                          // check the cell value under your specific column and then you can toggle your colors
            row.DefaultCellStyle.BackColor = Color.FromArgb(44, 42, 43);
            row.DefaultCellStyle.ForeColor = Color.LightGray;
            if(e.ColumnIndex == 0)
            {
                datagridPatientRecords.Columns[0].Visible = false;
            }
            if(e.ColumnIndex == 5)
            {
                datagridPatientRecords.Rows[e.RowIndex].Cells[5].ToolTipText = datagridPatientRecords.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            if (e.ColumnIndex == 6)
            {
                datagridPatientRecords.Rows[e.RowIndex].Cells[6].ToolTipText = datagridPatientRecords.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void datagridPatientRecords_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell.ColumnIndex == 0 || e.Cell.ColumnIndex == 1 || e.Cell.ColumnIndex == 2 || e.Cell.ColumnIndex == 3 || e.Cell.ColumnIndex == 4)
            {
                e.Cell.Style.SelectionBackColor = Color.FromArgb(44, 42, 43);
                e.Cell.Style.SelectionForeColor = Color.LightGray;
            }
        }

        private void datagridPatientRecords_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string RecordID = datagridPatientRecords.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            TextDialogBox obj = new TextDialogBox();
            if(e.ColumnIndex == 5)
            {
                obj.FormSetup("HealthProblems", RecordID);
            }
            if(e.ColumnIndex == 6)
            {
                obj.FormSetup("PrescriptionDetails", RecordID);
            }
            obj.ShowDialog(this);
            PopulateSelectedPatientDataView(RecordID);
        }

        private void pnlRecords_VisibleChanged(object sender, EventArgs e)
        {
            PopulatePatientRecords();
        }

        private void cmbHospitalFilter_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= -1)
            {
                Graphics g = e.Graphics;
                Brush brush = (e.State.HasFlag(DrawItemState.Selected)) ?
                               new SolidBrush(Color.LightSeaGreen) : new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(cmbHospitalFilter.GetItemText(cmbHospitalFilter.Items[e.Index]).ToString(), e.Font,
                           tBrush, e.Bounds, StringFormat.GenericDefault);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void pnlAppointmentDetails_VisibleChanged(object sender, EventArgs e)
        {
            PopulateAppointments();
        }

        private void dataGridAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridAppointments.Rows[e.RowIndex];// get you required index
                                                                        // check the cell value under your specific column and then you can toggle your colors
            row.DefaultCellStyle.BackColor = Color.FromArgb(44, 42, 43);
            row.DefaultCellStyle.ForeColor = Color.LightGray;

            DataGridViewCell cell = dataGridAppointments.Rows[e.RowIndex].Cells[5];

            if (e.ColumnIndex == 4)
            {
                Color CellForeColor = Color.LightGray;

                switch (cell.Value.ToString().Trim())
                {
                    case "Pending for Approval":
                        CellForeColor = Color.LightYellow;
                        break;

                    case "Approved and Booked":
                        CellForeColor = Color.LightGreen;
                        break;
                    case "Cancelled by Patient":
                        CellForeColor = Color.IndianRed;
                        break;
                    case "Visited":
                        CellForeColor = Color.Green;
                        break;
                    case "Patient failed to attend":
                        CellForeColor = Color.Gray;
                        break;
                }
                cell.Style.ForeColor = CellForeColor;
            }
        }

        private void btnShowAllPatients_Click(object sender, EventArgs e)
        {
            PopulatePatientRecords();
        }

        private void cmbHospitalFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ConsultantOfficeID = cmbHospitalFilter.SelectedValue.ToString();
            PopulateHospitalFilteredDataView(ConsultantOfficeID);
        }

        private void cmbFilterByDate_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = (e.State.HasFlag(DrawItemState.Selected)) ?
                               new SolidBrush(Color.LightSeaGreen) : new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(cmbHospitalFilter.GetItemText(cmbFilterByDate.Items[e.Index]).ToString(), e.Font,
                           tBrush, e.Bounds, StringFormat.GenericDefault);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void cmbFilterByDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DateTime DateToday = DateTime.Today;
            DateTime FilterStartDate = DateToday;
            DateTime FilterEndDate = DateToday;
            switch (cmbFilterByDate.SelectedIndex)
            {
                case 0: //filter today's appointments
                    FilterStartDate = DateToday; //start date as today
                    FilterEndDate = DateToday; //end date as today
                    break;
                case 1://filter appointments this week
                    FilterStartDate = DateToday.AddDays(-(int)DateToday.DayOfWeek); //this gets the first day of the week's day as an integer(the date) then it subtracts from today's date
                    FilterEndDate = FilterStartDate.AddDays(7);//this adds a week to the start date to get the end date 
                    break;
                case 2://filter appointments this month
                    FilterStartDate = DateToday.AddDays(-(DateToday.Day));//this gets the first day of the month's day as an integer(the date) then it subtracts from today's date
                    FilterEndDate = FilterStartDate.AddDays(DateTime.DaysInMonth(DateToday.Year, DateToday.Month)); //this gets the number of days in this month and add it start date to get the end date
                    break;
                case 3://filter newer appointments 
                    FilterStartDate = DateToday; //start date as today
                    FilterEndDate = DateTime.Parse("12/31/9999 11:59:59 PM"); ; //end date as the maximum date value that sql database accepts
                    break;
                case 4://filter older appointments
                    FilterStartDate = DateTime.Parse("1/1/1753 12:00:00 AM"); //start date as the minimum date value that sql database accepts
                    FilterEndDate = DateToday; //end date as today
                    break;
            }
            PopulateAppointmentByDate(FilterStartDate, FilterEndDate);
        }

        private void btnShowAllAppointments_Click(object sender, EventArgs e)
        {
            PopulateAppointments();
        }
    }
}
