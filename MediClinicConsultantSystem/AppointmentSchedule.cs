using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MediClinicChannelingSystem;

namespace MediClinicConsultantSystem
{
    public partial class AppointmentSchedule : Form
    {
        string ConsultantIDGlobal; //to assign the currently logged in consultant's ConsultantID, so that it can be used for the database
        string ConsultantOfficeIDGlobal; //to assign the currently selected Office's ConsultantOfficeID, so that it can be used for the database
        SqlConnection con;
        int MondaySessionCount = 1;
        int TuesdaySessionCount = 1;
        int WednesdaySessionCount = 1;
        int ThursdaySessionCount = 1;
        int FridaySessionCount = 1;
        int SaturdaySessionCount = 1;
        int SundaySessionCount = 1;
        /*
        These SessionCounts are used to keep track of the dynamically created user controls, that are in each day column      
        of the TableLayoutPanel (tblpnlSchedule)
        */
        public AppointmentSchedule()
        {
            InitializeComponent();
            DBConnection obj = new DBConnection();
            con = obj.getConnection();
        }

        private string AppointmentScheduleIDGen()//the AppointmentScheduleID is generated using this method
        {
            string ASID = string.Empty;
            string NewASID = string.Empty;
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT AppointmentScheduleID FROM AppointmentScheduleTable", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool rowFound = reader.HasRows;
                    if (rowFound)
                    {
                        while (reader.Read())
                        {
                            ASID = reader[0].ToString().Trim();//it gets the last rows value
                        }
                        string ConsultantOfficeIDString = ASID.Substring(1);//only the integer values

                        int ID = Int32.Parse(ConsultantOfficeIDString);
                        int NewID = 0;
                        if (ID >= 0 && ID < 9)
                        {
                            NewID = ID + 1;
                            NewASID = "S000" + NewID;
                        }
                        else if (ID >= 9 && ID <99)
                        {
                            NewID = ID + 1;
                            NewASID = "S00" + NewID;
                        }
                        else if (ID >= 99 && ID < 999)
                        {
                            NewID = ID + 1;
                            NewASID = "S0" + NewID;
                        }
                        else if(ID >=999 && ID < 9999)
                        {
                            NewID = ID + 1;
                            NewASID = "S" + NewID;
                        }
                    }
                    else
                    {
                        NewASID = "S0001";
                    }
                    reader.Close();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("AppointmentScheduleID Generation Error\nError:" + e);
            }
            return NewASID;
        }

        public void SettingConsultantInformation(string ConsultantID, string ConsultantOfficeID)
        {
            ConsultantIDGlobal = ConsultantID;
            ConsultantOfficeIDGlobal = ConsultantOfficeID;
        }

        private void AddItem(string ScheduleDay, int SessionNumber, int ColumnPosition)//to add each user controls dynamically
        {
            //get a reference to the previous existent row's details of the current column
            RowStyle temp = tblpnlSchedule.RowStyles[tblpnlSchedule.RowCount - 1];

            //assigning the name, and it's groupbox title to the dynamically created user control to both visually and programmically keep track of the user control
            //the groupbox title is generated using the current session number (or SessionCount)
            UserControl TimeScheduleControl = new AppointmentTimeSchedule() { Name = ScheduleDay + SessionNumber, GroupBoxTitle = "Session " + SessionNumber };

            //this is to ensure that all the newly created user control is placed in their correct position (the next empty row in their respective columns)
            if (SessionNumber >= tblpnlSchedule.RowCount)//this creates a new row in the TableLayout Panel to to accomodate the user control
            {
                //increase panel rows count by one
                tblpnlSchedule.RowCount++;
                //add a new RowStyle as a copy of the previous row's style
                tblpnlSchedule.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                //adds your control
                tblpnlSchedule.Controls.Add(TimeScheduleControl, ColumnPosition, tblpnlSchedule.RowCount - 1);
            }
            tblpnlSchedule.Controls.Add(TimeScheduleControl, ColumnPosition, SessionNumber); //this places the user control in the already existing row, rather than creating a new row
        }

        private bool RemoveItem(int ColumnPosition)//to remove each user controls dynamically from their respective column
        {
            bool Success = false; //this is to return the bool of whether the SessionCount needs to be decremented
            //this checks the RowCount to ensure that the user cotrol that is to be removed is not the first one 
            if (tblpnlSchedule.RowCount > 2)
            {
                Success = true;//the bool Success is true because there is more than one user control in this specified column, so its SessionCount should be decremented
                Control C = tblpnlSchedule.GetControlFromPosition(ColumnPosition, tblpnlSchedule.RowCount - 1); //this gets the last instance of the user control using the row position
                RowStyle temp = tblpnlSchedule.RowStyles[tblpnlSchedule.RowCount - 1];  //this gets the last instance of row in TableLayout, so that it can be removed
                tblpnlSchedule.RowCount--; //the TableLayout Panel's row count is reduced by 1
                tblpnlSchedule.RowStyles.RemoveAt(tblpnlSchedule.RowCount); //the last instance of the row is removed
                tblpnlSchedule.Controls.Remove(C); //the selected control is removed
            }
            else
            {
                Success = false; //the bool Success is false because there is only one user control in the TableLayout panel, so it is not removed from the panel (hence the SessionCount needs not be reduced)
                //display some error
            }
            return Success;
        }

        private void AddtoDatabase(string DayOfWeek, DateTime StartTime, DateTime EndTime, int SessionCount)//used to add the schedules to the database
        {
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("INSERT INTO AppointmentScheduleTable(AppointmentScheduleID, ConsultantID, ConsultantOfficeID, DayOfWeek, StartTime, EndTime, ScheduleAvailability, SessionNumber) VALUES(@asid, @cid, @coid, @DoW, @st, @et, @sa, @snum)", con))
                {
                    cmd.Parameters.AddWithValue("@asid", SqlDbType.VarChar).Value = AppointmentScheduleIDGen();
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantIDGlobal;
                    cmd.Parameters.AddWithValue("@coid", SqlDbType.VarChar).Value = ConsultantOfficeIDGlobal;
                    cmd.Parameters.AddWithValue("@DoW", SqlDbType.VarChar).Value = DayOfWeek;
                    cmd.Parameters.AddWithValue("@st", SqlDbType.Time).Value = StartTime.ToString("hh:mm:ss");
                    cmd.Parameters.AddWithValue("@et", SqlDbType.Time).Value = EndTime.ToString("hh:mm:ss");
                    cmd.Parameters.AddWithValue("@sa", SqlDbType.Char).Value = "Y";
                    cmd.Parameters.AddWithValue("@snum", SqlDbType.Int).Value = SessionCount;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(null, "An error occured when filling the AppointmentSchedule Table in the Database\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckForPreviousSchedule()
        {
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM AppointmentScheduleTable WHERE ConsultantOfficeID = @coid", con))
                {
                    cmd.Parameters.AddWithValue("@coid", SqlDbType.VarChar).Value = ConsultantOfficeIDGlobal;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("UPDATE AppointmentScheduleTable SET ScheduleAvailability = 'N', SessionNumber = 0 WHERE ConsultantOfficeID = @coid", con))
                        {
                            cmd2.Parameters.AddWithValue("@coid", SqlDbType.VarChar).Value = ConsultantOfficeIDGlobal;
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    reader.Close();
                    con.Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when searching for the Appointment Schedules in the Database\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMonday_Click(object sender, EventArgs e)
        {
            MondaySessionCount++;
            AddItem("Monday", MondaySessionCount, 0);
        }

        private void btnAddTuesday_Click(object sender, EventArgs e)
        {
            TuesdaySessionCount++;
            AddItem("Tuesday", TuesdaySessionCount, 1);
        }

        private void btnAddWednesday_Click(object sender, EventArgs e)
        {
            WednesdaySessionCount++;
            AddItem("Wednesday", WednesdaySessionCount, 2);
        }

        private void btnAddThursday_Click(object sender, EventArgs e)
        {
            ThursdaySessionCount++;
            AddItem("Thursday", ThursdaySessionCount, 3);
        }

        private void btnAddFriday_Click(object sender, EventArgs e)
        {
            FridaySessionCount++;
            AddItem("Friday", FridaySessionCount, 4);
        }

        private void btnAddSaturday_Click(object sender, EventArgs e)
        {
            SaturdaySessionCount++;
            AddItem("Saturday", SaturdaySessionCount, 5);
        }

        private void btnAddSunday_Click(object sender, EventArgs e)
        {
            SundaySessionCount++;
            AddItem("Sunday", SundaySessionCount, 6);
        }

        private void btnRemoveMonday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the first column(of index 0) is removed, this is the MondaySessionCount
            if(RemoveItem(0))
            {
                MondaySessionCount--; //the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
            
        }

        private void btnRemoveTuesday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the second column(of index 1) is removed, this is the TuesdaySessionCount
            if(RemoveItem(1))
            {
                TuesdaySessionCount--; //the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
        }

        private void btnRemoveWednesday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the third column(of index 2) is removed, this is the WednesdaySessionCount
           if( RemoveItem(2))
            {
                WednesdaySessionCount--; //the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
        }

        private void btnRemoveThursday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the fourth column(of index 3) is removed, this is the ThursdaySessionCount
            if(RemoveItem(3))
            {
                ThursdaySessionCount--; //the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
        }

        private void btnRemoveFriday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the fifth column(of index 4) is removed, this is the FridaySessionCount
            if(RemoveItem(4))
            {
                FridaySessionCount--; //the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
        }

        private void btnRemoveSaturday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the sixth column(of index 5) is removed, this is the SaturdaySessionCount
            if(RemoveItem(5))
            {
                SaturdaySessionCount--; //the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
        }

        private void btnRemoveSunday_Click(object sender, EventArgs e)
        {
            //the last instance of the item in the seventh column(of index 6) is removed, this is the SundaySessionCount
            if(RemoveItem(6))
            {
                SundaySessionCount--;//the session count is reduced by 1 (so that we can keep track of the number of user controls that is currently on the display)
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            CheckForPreviousSchedule(); //this method checks the database if it already has any session schedules for this particular Consultant's office, and if there is a previous iteration of the session schedule then it deletes it, 
            //so that the new schedule can be inseret6ed into the database. This is to ensure that no confusion occurs by the Consultant adding more that one iteration of the schedule for an individual office of theirs
            AddEachSession(MondaySessionCount, "Monday");
            AddEachSession(TuesdaySessionCount, "Tuesday");
            AddEachSession(WednesdaySessionCount, "Wednesday");
            AddEachSession(ThursdaySessionCount, "Thursday");
            AddEachSession(FridaySessionCount, "Friday");
            AddEachSession(SaturdaySessionCount, "Saturday");
            AddEachSession(SundaySessionCount, "Sunday");
            this.Hide();
        }

        private void AddEachSession(int SessionCount, string DayOfWeek) //this method helps to add each session's timespan details into the database
        {
            bool IfStartTimeChecked;
            bool IfEndTimeChecked;
            for (int i = 0; i < SessionCount; i++) //this loop will go through each dynamically created user control (if it is created)
            {
                string ControlName = DayOfWeek + (i + 1); //this is used assign give the control's name 
                if (tblpnlSchedule.Controls.ContainsKey(ControlName))//this selection is used to find the dynamically created user control fom the Table Layout Panel using it's name
                {
                    AppointmentTimeSchedule SelectedControls = (AppointmentTimeSchedule)tblpnlSchedule.Controls[ControlName]; //the selected control is assigned to a variable to be used
                    IfStartTimeChecked = SelectedControls.IfStartTimeChecked; //this boolean checks if the StartTime control is checked
                    IfEndTimeChecked = SelectedControls.IfEndTimeChecked; //this boolean checks if the EndTime control is checked

                    if (IfStartTimeChecked || IfEndTimeChecked) //this ensures that only the checked time is sent to the AddToDatabase method to be inserted into the database
                    {
                        DateTime StartTime = DateTime.ParseExact(SelectedControls.StartTime, "hh:mm tt", CultureInfo.CurrentCulture); //this converts the time to a DateTime Format
                        DateTime EndTime = DateTime.ParseExact(SelectedControls.EndTime, "hh:mm tt", CultureInfo.CurrentCulture); //this converts the time to a DateTime Format
                        string StartTimeString = StartTime.ToString("HH:mm");
                        string EndTimeString = EndTime.ToString("HH:mm");
                        DateTime StartTime24Hour = DateTime.ParseExact(StartTimeString, "HH:mm", CultureInfo.CurrentCulture); //this converts the 12-hour format into the 24-hour format
                        DateTime EndTime24Hour = DateTime.ParseExact(EndTimeString, "HH:mm", CultureInfo.CurrentCulture); //this converts the 12-hour format into the 24-hour format
                        //we are incrementing the i by 1 is becuase the for loop starts from 0, and the first sesson will be session one
                        AddtoDatabase(DayOfWeek, StartTime24Hour , EndTime24Hour, i + 1);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
