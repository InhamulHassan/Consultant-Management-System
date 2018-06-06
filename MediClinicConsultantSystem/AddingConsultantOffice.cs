using MediClinicChannelingSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediClinicConsultantSystem
{
    public partial class AddingConsultantOffice : Form
    {
        String ConsultantIDGlobal;
        int GlobalCounter = 0; //The GlobalCounter is used to keep track of the currently selected Afflited Hospital's HospitalID (which is in the index of the SelecetedHosptal Lis)
        SqlConnection con;
        List<String> SelectedHospitals = new List<string>(); //this list is used to store all the consultant's affliated hospitals
        public AddingConsultantOffice()
        {
            InitializeComponent();
            DBConnection obj = new DBConnection(); //opens the connection wit the database using a class object
            con = obj.getConnection();
        }

        private string ConsultantOfficeIDGen()
        {
            string CID = string.Empty;
            string NewCID = string.Empty;
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT ConsultantOfficeID FROM ConsultantOfficeTable", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool rowFound = reader.HasRows;
                    if (rowFound)
                    {
                        while (reader.Read())
                        {
                            CID = reader[0].ToString();//it gets the last rows value
                        }
                        string ConsultantOfficeIDString = CID.Substring(1);//only the integer values

                        int ID = Int32.Parse(ConsultantOfficeIDString);
                        int NewID = 0;
                        if (ID >= 0 && ID < 9)
                        {
                            NewID = ID + 1;
                            NewCID = "C0000" + NewID;
                        }
                        else if (ID >= 9 && ID < 99)
                        {
                            NewID = ID + 1;
                            NewCID = "C000" + NewID;
                        }
                        else if (ID >= 99 && ID < 999)
                        {
                            NewID = ID + 1;
                            NewCID = "C00" + NewID;
                        }
                        else if (ID >= 999 && ID < 9999)
                        {
                            NewID = ID + 1;
                            NewCID = "C0" + NewID;
                        }
                        else if (ID >= 9999 && ID < 99999)
                        {
                            NewID = ID + 1;
                            NewCID = "C" + NewID;
                        }
                    }
                    else
                    {
                        NewCID = "C00001";
                    }
                    reader.Close();
                    con.Close(); 
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("ConsltantOfficeID Generation Error\nError:" + e);
            }
            return NewCID;
        }

        public void ConsultantAffliationsInfo(string ConsultantID)
        {
            //the consultant's ID is sent to this method from the previous form
            //this method is used to retrieve a list of the hospital affliated with the current logged in consultant
            string HospitalID = string.Empty;
            ConsultantIDGlobal = ConsultantID; //the consultant's ID is set as a global value so that it can be used by other methods
            try
            {
                if(con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand("SELECT HospitalID FROM HospitalAffliationsTable WHERE ConsultantID = @cid", con))
                {
                    cmd.Parameters.AddWithValue("@cid", ConsultantID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool Found = reader.HasRows;
                    if (Found)
                    {
                        while (reader.Read())
                        {
                            HospitalID = reader[0].ToString().Trim(); //retreiving the hospital ID of the affliated hospitals one by one
                            SelectedHospitals.Add(HospitalID); //adding the Hospital IDs into a list so that it can be gone through one by one 
                        }
                    }
                    reader.Close();
                    con.Close(); 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when retreiving the Consultant's Aflliated Hospitals\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayingHospitalDetails(string HospitalID)
        {
            //this method will go through each affliated hospital, so that it can be used to fill the form with the specific details
            try
            {
                if (con.State != ConnectionState.Open) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                
                using (SqlCommand cmd = new SqlCommand("SELECT HospitalName, HospitalAddress, LocatedCity FROM HospitalTable WHERE HospitalID = @hid", con))
                {
                    cmd.Parameters.AddWithValue("@hid", HospitalID); //this is the Hospital ID that was stored in the List
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool Found = reader.HasRows;
                    if (Found)
                    {
                        while (reader.Read())
                        {
                            string HospitalName = reader[0].ToString().Trim();
                            string Address = reader[1].ToString().Trim();
                            string LocatedCity = reader[2].ToString().Trim();



                            lblCurrentSelectedOffice.Text = HospitalName;
                            txtOfficeName.Text = HospitalName;
                            txtAddress.Text = Address;
                            txtAddress.Enabled = false; //this is to ensure that the user does not edit the predefined values already in the database
                            txtLocatedCity.Text = LocatedCity;
                            txtLocatedCity.Enabled = false; //this is to ensure that the user does not edit the predefined values already in the database
                        }
                    }
                    reader.Close();
                    con.Close();  
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(null, "An error occured when displaying the details of the selected hospitals\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddClinicDetails()
        {
            btnFinish.Show();
            pnlClinicName.Show();
            lblCurrentSelectedOffice.Text = "Private Clinic";
            txtAddress.Enabled = true;
            txtLocatedCity.Enabled = true;
        }

        private void AddToDatabase(string HospitalID)
        {
            try
            {
                string query = @"INSERT INTO ConsultantOfficeTable
                                (ConsultantOfficeID, OfficeName, ConsultantID, HospitalID, TimeSlotPerClient, FirstConsultationFee, FollowupConsulationFee, Address, LocatedCity)
                                VALUES (@coid, @oname, @cid, @hid, @tspc, @fcf, @fucp, @add, @lc)";
                
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@coid", ConsultantOfficeIDGen());
                    cmd.Parameters.AddWithValue("@oname", txtOfficeName.Text);
                    cmd.Parameters.AddWithValue("@cid", ConsultantIDGlobal);
                    if (HospitalID == "NULL")
                    {
                        cmd.Parameters.AddWithValue("@hid", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@hid", HospitalID);
                    }
                    cmd.Parameters.AddWithValue("@tspc", cmbSlotTime.selectedValue);
                    cmd.Parameters.AddWithValue("@fcf", txtInitialFee.Text);
                    cmd.Parameters.AddWithValue("@fucp", txtFollowupFee.Text);
                    cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@lc", txtLocatedCity.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close(); 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when linking the Consultant and the Hospital(s) Affliations\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddingConsultantOffice_Load(object sender, EventArgs e)
        {
            pnlClinicName.Hide();//this hides the panel that tells the user to enter the private clinic details)
            DisplayingHospitalDetails(SelectedHospitals[0]); //this would ensure that the List is started with its first index
        }

        private bool FormValidation()
        {
            bool Success = false;
            if(string.IsNullOrEmpty(txtOfficeName.Text))
            {
                errorProvider1.SetError(txtOfficeName, "Please enter the Office/Clinic name in the left field");
                Success = false;
            }
            else
            {
                errorProvider1.SetError(txtOfficeName, string.Empty);
                Success = true;
            }

            if (string.IsNullOrEmpty(txtInitialFee.Text))
            {
                errorProvider1.SetError(txtInitialFee, "Please provide the Initial Consultation Fee in the left field");
                Success = false;
            }
            else
            {
                errorProvider1.SetError(txtInitialFee, string.Empty);
                if (Success != false)// if the previous one wasn't a success, then set the success as true because if it has any single one error then it should not execute
                    Success = true;
            }

            if (string.IsNullOrEmpty(txtFollowupFee.Text))
            {
                errorProvider1.SetError(txtFollowupFee, "Please provide the Followup Consultation Fee in the left field");
                Success = false;
            }
            else
            {
                errorProvider1.SetError(txtFollowupFee, string.Empty);
                if (Success != false)// if the previous one wasn't a success, then set the success as true because if it has any single one error then it should not execute
                    Success = true;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Please enter the Office/Clinic address in the field to the left");
                Success = false;
            }
            else
            {
                errorProvider1.SetError(txtAddress, string.Empty);
                if (Success != false)// if the previous one wasn't a success, then set the success as true because if it has any single one error then it should not execute
                    Success = true;
            }

            if (string.IsNullOrEmpty(txtLocatedCity.Text))
            {
                errorProvider1.SetError(txtLocatedCity, "Please enter the Name of the City where the Office/Clinic's is located in the field to the left");
                Success = false;
            }
            else
            {
                errorProvider1.SetError(txtLocatedCity, string.Empty);
                if (Success != false)// if the previous one wasn't a success, then set the success as true because if it has any single one error then it should not execute
                    Success = true;
            }

            return Success;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(FormValidation())
            {
                if (GlobalCounter >= SelectedHospitals.Count) //this is to esure that if the index reaches its last value another method is run to add clinic details
                {
                    AddToDatabase("NULL");
                    txtAddress.Text = null;
                    txtOfficeName.Text = null;
                    txtLocatedCity.Text = null;
                }
                else
                {
                    AddToDatabase(SelectedHospitals[GlobalCounter]); //this method would add the inserted values into the database
                    GlobalCounter++; //the GlobalCounter global variable is used to increment the index value of the list, so that it could be followed sequentially
                    if(GlobalCounter < SelectedHospitals.Count)
                    {
                        DisplayingHospitalDetails(SelectedHospitals[GlobalCounter]); //this method retrieves the Selected Hospital using the GlobalCounter's number as index (used to keep track of the current Selected hospital)
                    }
                    //The (GlobalCounter) is used to send the correct HospitalID to the database
                }

                if (GlobalCounter > (SelectedHospitals.Count - 1))
                {
                    AddClinicDetails();
                    txtAddress.Text = null;
                    txtOfficeName.Text = null;
                    txtLocatedCity.Text = null;
                }

                txtInitialFee.Text = null;
                txtFollowupFee.Text = null;
                txtFollowupFee.Text = null;
                txtInitialFee.Text = null;
            }
           
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInitialFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) 
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFollowupFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
