using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MediClinicChannelingSystem;

namespace MediClinicConsultantSystem
{
    public partial class ConsultantMainScreen : Form
    {
        SqlConnection con;
        String ConsultantIDGlobal;  //declaring a global value for the ConsultantID, so that it can be used to retrieve other table data
        string FullName;

        public ConsultantMainScreen()
        {
            InitializeComponent();
            DBConnection obj = new DBConnection(); //setting up the database connection
            con = obj.getConnection();
        }

        private void WelcomeMessage()
        {
            //this will show the Welcome Panel as the first panel, this panel will display a welcome message
            pnlWelcome.Show(); 
            pnlAddConsultantDetails.Visible = false;
            lblWelcome.Text = "Dr. " + FullName + ", welcome to the MediClinic Consultant System.\nSince this is your first time using the Consultant Support System\nwe would like to initiate and set up your consultant account.\n Click next to start your digital experience with us.";
        }

        public void LogoutWindow()
        {
            //this method is used to logout of the chosen form
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
            obj.Closed += (s, args) => Close();
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
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
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
            catch(SqlException ex)
            {
                MessageBox.Show(null, "An error occured when retreiving the Consultant Details\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillHospitalList()
        {
            //This method is used to populate the Hospital Affliations ListBox
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT HospitalID, HospitalName, LocatedCity FROM HospitalTable", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "HospitalTable");

                    listHospitals.DisplayMember = "HospitalTable.HospitalName";
                    listHospitals.ValueMember = "HospitalTable.HospitalID";
                    listHospitals.DataSource = ds;
                    con.Close(); 
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(null, "An error occured when filling the Affliated Hospitals List\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSpecialitiesList()
        {
            //This method is used to populate the Medical Specialities ListBox
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT SpecialityID, SpecialityName FROM SpecialitiesListTable", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "SpecialitiesListTable");

                    listSpecilaities.DisplayMember = "SpecialitiesListTable.SpecialityName";
                    listSpecilaities.ValueMember = "SpecialitiesListTable.SpecialityID";
                    listSpecilaities.DataSource = ds;
                    con.Close(); 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when filling the Specialized In List\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillQualificationsList()
        {
            //This method is used to populate the Medical Qualifications ListBox
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT QualificationID, QualificationName FROM QualificationsListTable", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "QualificationsListTable");

                    listQualifications.DisplayMember = "QualificationsListTable.QualificationName";
                    listQualifications.ValueMember = "QualificationsListTable.QualificationID";
                    listQualifications.DataSource = ds;
                    con.Close(); 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when filling the Medical Qualifications List\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ListValidation()
        {
            bool ListItemsSelected = false;
            if (listHospitals.SelectedItems.Count < 1)
            {
                ListItemsSelected = false;
                lblSelectedHospitals.ForeColor = Color.Red;
                lblSelectedHospitals.Text = "Please select One or More Hospital Names from the Hospital Affliations List.";
            }
            else if (listSpecilaities.SelectedItems.Count < 1)
            {
                ListItemsSelected = false;
                lblSelectedSpecialities.ForeColor = Color.Red;
                lblSelectedSpecialities.Text = "Please select One or More Medical Fields from the Specialized In List.";
            }
            else if (listQualifications.SelectedItems.Count < 1)
            {
                ListItemsSelected = false;
                lblSelectedQualifications.ForeColor = Color.Red;
                lblSelectedQualifications.Text = "Please select One or More Medical Qualifications from the Medical Qualifications List.";
            }
            else
            {
                ListItemsSelected = true;
            }
            return ListItemsSelected;
        }

        private bool SetupFirstStep()
        {
            //this method includes the first step involved in setting up the Consultant's Account
            bool FormSuccess = false;
            //this ListValidation is used to ensure that the user selects (atleast one) option from each ListBox before going on to the next step
            if (ListValidation())
            {
                FormSuccess = true;
                var Hospitallist = listHospitals.SelectedItems.Cast<DataRowView>();
                foreach (var item in Hospitallist)
                {
                    string SelecetedItem = item.Row[0].ToString().Trim();
                    //this iteration will work through each selected item in the Hospital Affliations ListBox, and insert them into the Many-to-Many HospitalAffliationsTable
                    try
                    {
                        if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                        {
                            con.Open();
                        }

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO HospitalAffliationsTable(ConsultantID, HospitalID) VALUES (@cid, @hid)", con))
                        {
                            cmd.Parameters.AddWithValue("@cid", ConsultantIDGlobal);
                            cmd.Parameters.AddWithValue("@hid", SelecetedItem);
                            cmd.ExecuteNonQuery();
                            con.Close(); 
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(null, "An error occured when linking the Consultant and the Hospital(s) Affliations\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                var Specialitylist = listSpecilaities.SelectedItems.Cast<DataRowView>();
                foreach (var item in Specialitylist)
                {
                    string SelecetedItem = item.Row[0].ToString();
                    //this iteration will work through each selected item in the Medical Specialities ListBox, and insert them into the Many-to-Many SpecialitiesTable
                    try
                    {
                        if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                        {
                            con.Open();
                        }

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO DoctorSpecialities(ConsultantID, SpecialityID) VALUES (@cid, @sid)", con))
                        {
                            cmd.Parameters.AddWithValue("@cid", ConsultantIDGlobal);
                            cmd.Parameters.AddWithValue("@sid", SelecetedItem);
                            cmd.ExecuteNonQuery();
                            con.Close(); 
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(null, "An error occured when linking the Consultant and the Medical Field(s) Specializations\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                var Qualificationlist = listQualifications.SelectedItems.Cast<DataRowView>();
                foreach (var item in Qualificationlist)
                {
                    string SelecetedItem = item.Row[0].ToString();
                    //this iteration will work through each selected item in the Medical Qualifications ListBox, and insert them into the Many-to-Many QualificationsTable
                    try
                    {
                        if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                        {
                            con.Open();
                        }

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO DoctorQualifications(ConsultantID, QualificationID) VALUES (@cid, @qid)", con))
                        {
                            cmd.Parameters.AddWithValue("@cid", ConsultantIDGlobal);
                            cmd.Parameters.AddWithValue("@qid", SelecetedItem);
                            cmd.ExecuteNonQuery();
                            con.Close(); 
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(null, "An error occured when linking the Consultant and the Medical Qualification(s)\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return FormSuccess;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this will close the current form
            Close();
        }

        private void btnCompress_Click_1(object sender, EventArgs e)
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

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            //this is used to minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConsultantMainScreen_Load(object sender, EventArgs e)
        {
            //after this form loads, the methods below will be run in order
            WelcomeMessage();
            FillHospitalList();
            FillSpecialitiesList();
            FillQualificationsList();
        }

        private void listHospitals_DrawItem(object sender, DrawItemEventArgs e)
        {
            //this event is used to paint (ie. set the backgroud and text color) of the listbox's selected text
            e.DrawBackground();
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1)
            {
                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(e.BackColor);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listHospitals.GetItemText(listHospitals.Items[e.Index]), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            if (isSelected)
            {
                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(Color.MediumSpringGreen);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(Color.Black);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listHospitals.GetItemText(listHospitals.Items[e.Index]), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void listSpecilaities_DrawItem(object sender, DrawItemEventArgs e)
        {
            //this event is used to paint (ie. set the backgroud and text color) of the listbox's selected text
            e.DrawBackground();
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1)
            {
                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(e.BackColor);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listSpecilaities.GetItemText(listSpecilaities.Items[e.Index]), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            if(isSelected)
            {
                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(Color.MediumSpringGreen);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(Color.Black);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listSpecilaities.GetItemText(listSpecilaities.Items[e.Index]), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void listQualifications_DrawItem(object sender, DrawItemEventArgs e)
        {
            //this event is used to paint (ie. set the backgroud and text color) of the listbox's selected text
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            e.DrawBackground();
            if (e.Index > -1)
            {
                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(e.BackColor);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listQualifications.GetItemText(listQualifications.Items[e.Index]), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            if (isSelected)
            {
                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(Color.MediumSpringGreen);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(Color.Black);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listQualifications.GetItemText(listQualifications.Items[e.Index]), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //this will redirect user to the next frm panel
            pnlAddConsultantDetails.Show();
            pnlWelcome.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout function in the first panel
            LogoutWindow();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            //this will run the step by step insertion of the listbox's selected items into their appropriate database tables

            if (SetupFirstStep())
            {
                AddingConsultantOffice child = new AddingConsultantOffice(); //we are creating an object to invoke the AddingConsultantOffice form
                child.ConsultantAffliationsInfo(ConsultantIDGlobal); //this method will send the ConsultantID to the next form(so that it can use it for database insertion)
                child.StartPosition = FormStartPosition.Manual; //this sets the opening form dialog's start position as the location specified below
                child.Location = new Point(320, 0); //this will set the location of the object's dialog form
                HomeScreen obj = new HomeScreen();//this will open the home screen form
                child.ShowDialog(); //this will open the AddingConsultantOffice as a dialog(on top of the current form) 
                obj.StartTimer();
                obj.ConsultantInfo(ConsultantIDGlobal);  //this method will send the ConsultantID to the next form(so that it can use it for database retrieval)
                obj.ConsultantOfficeInfo(ConsultantIDGlobal); //this method will send the ConsultantID to the next form(so that it can use it for database retrieval)
                obj.Show();
                this.Hide();
                obj.Closed += (s, args) => Close(); //this closes only the current form while retaining the other opened forms
            }
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            //logout function in the second panel
            LogoutWindow();
        }

        private void listHospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this event is used to display all the items selected from this listbox to be displayed in a label adjacent to it
            string SelectedHospitals = string.Empty;
            if(listHospitals.SelectedItems.Count > 0)
            {
                //the DataRowView is used to succesfully retrieve the displaymember value of the selected item.
                for (int i = 0; i < listHospitals.SelectedItems.Count; i++)
                {
                    DataRowView drv = (DataRowView)listHospitals.SelectedItems[i];
                    String valueOfItem = drv["HospitalName"].ToString();
                    SelectedHospitals += valueOfItem + ","; //this appends all the individual display member items into a string
                }
            }

            // this is used to display the retrieved displaymembers in a label
            lblSelectedHospitals.ForeColor = SystemColors.Control;
            lblSelectedHospitals.Text = "The Hospital(s) you are affliated with: \n" + SelectedHospitals;
        }

        private void listSpecilaities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this event is used to display all the items selected from this listbox to be displayed in a label adjacent to it
            string SelectedSpecialities = string.Empty;
            if (listSpecilaities.SelectedItems.Count > 0)
            {
                //the DataRowView is used to succesfully retrieve the displaymember value of the selected item.
                for (int i = 0; i < listSpecilaities.SelectedItems.Count; i++)
                {
                    DataRowView drv = (DataRowView)listSpecilaities.SelectedItems[i];
                    String valueOfItem = drv["SpecialityName"].ToString();
                    SelectedSpecialities += valueOfItem + ",";//this appends all the individual display member items into a string
                }
            }

            // this is used to display the retrieved displaymembers in a label
            lblSelectedSpecialities.ForeColor = SystemColors.Control;
            lblSelectedSpecialities.Text = "The Medical Field(s) you are specialized in: \n" + SelectedSpecialities;
        }

        private void listQualifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this event is used to display all the items selected from this listbox to be displayed in a label adjacent to it
            string SelectedQualifications = string.Empty;
            if (listQualifications.SelectedItems.Count > 0)
            {
                //the DataRowView is used to succesfully retrieve the displaymember value of the selected item.
                for (int i = 0; i < listQualifications.SelectedItems.Count; i++)
                {
                    DataRowView drv = (DataRowView)listQualifications.SelectedItems[i];
                    String valueOfItem = drv["QualificationName"].ToString();
                    SelectedQualifications += valueOfItem + ",";//this appends all the individual display member items into a string
                }
            }

            // this is used to display the retrieved displaymembers in a label
            lblSelectedQualifications.ForeColor = SystemColors.Control;
            lblSelectedQualifications.Text = "The Medical Qualifications(s) you are entitled to: \n" + SelectedQualifications;
        }

        private void pnlAddConsultantDetails_VisibleChanged(object sender, EventArgs e)
        {
            //this resets the listboxes
            listHospitals.SelectedItem = null;
            listQualifications.SelectedItem = null;
            listSpecilaities.SelectedItem = null;
        }
    }
}
