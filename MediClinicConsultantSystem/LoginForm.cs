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
    public partial class LoginForm : Form
    {
        SqlConnection con;
        public LoginForm()
        {
            InitializeComponent();
            DBConnection obj = new DBConnection();
            con = obj.getConnection();
        }

        public bool FirstTimeLogin(string ConsultantID)
        {
            //this method checks the HospitalAffliations table using the Consultant's ID and returns a true value if the query returns any rows, thus redirecting the user directly to the home screen
            //if it does not find any rows in that table for that consultant, it will direct the user through the Initial Setup Process (since this means that the user is logging in for the first time, and has not gone through the initial setup process)
            bool ConsultantIDFound = false;
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ConsultantOfficeTable WHERE ConsultantID = @cid", con))
                {
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.VarChar).Value = ConsultantID;
                    SqlDataReader reader = cmd.ExecuteReader();
                    ConsultantIDFound = reader.HasRows; //assigns this bool value with a true/false depending on whetehr this query returns any rows
                    //the connection/reader is not closed because it is referenced inside the reader of the sqlconnection below(in the login click part)
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(null, "An error occured when checking the Consultant's Ofiice Table\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ConsultantIDFound;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtKeyCode_Enter(object sender, EventArgs e)
        {
            //this is to ensure that the hint (text placeholder on the textbox's background doesn't affect the input
            txtKeyCode.Text = null;
            txtKeyCode.isPassword = true;
        }


        private void txtLoginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this ensures that any alphanumeric key typed in the Login ID textbox is in uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtLoginID_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Tab)
            //{
            //    e.Handled = true;
            //    txtKeyCode.Focus();
            //}
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    btnLogin.Select();
            //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLoginInfo.Text = null;//this will clear the Login ID notification text
            lblKeyInfo.Text = null; //this will clear the Security Key notification 
            string Login = txtLoginID.Text;//getting the characters entered in the LoginID textbox
            string Key = txtKeyCode.Text;//getting the characters entered in the PassKey textbox
            if(String.IsNullOrEmpty(Key))
            {
                //setting the error notification tex for empty field
                lblKeyInfo.ForeColor = Color.FloralWhite;
                lblKeyInfo.Text = "The Key Code field is empty. Please provide a valid Key Code to proceed.";
            }
            if (String.IsNullOrEmpty(Login))
            {
                //setting the error notification tex for empty field
                lblLoginInfo.ForeColor = Color.FloralWhite;
                lblLoginInfo.Text = "The Login ID field is empty. Please provide a valid Login ID to proceed.";
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                    {
                        con.Open();
                    }

                    //checking the login details, if LoginID is found in the database, it checks if the PinCode matches then sends the ConsultantID of the logged in consultant to the next form
                    using (SqlCommand cmd = new SqlCommand("SELECT PinCode, ConsultantID FROM ConsultantLoginTable WHERE LoginID = @userid", con))
                    {
                        cmd.Parameters.AddWithValue("@userid", Login);
                        SqlDataReader reader = cmd.ExecuteReader();
                        bool loginfound = reader.HasRows; //checks whether the loginID is correct by comparing it to the already present list of login ID in the database
                        if (loginfound) //if the loginID is found, it compares the PinCode (password) in the database query against the entered Pincode, and continues if they match  
                        {
                            while (reader.Read())
                            {
                                string PinCode = reader[0].ToString().Trim();
                                if (Key.Equals(PinCode))
                                {
                                    string ConsultantID = reader[1].ToString().Trim();
                                    HomeScreen home = new HomeScreen();
                                    home.StartTimer(); //this is used to set the login time
                                    ConsultantMainScreen main = new ConsultantMainScreen();

                                    if (FirstTimeLogin(ConsultantID))
                                    {
                                        home.ConsultantInfo(ConsultantID); //this is to send the next form the ConsultantID, so that it can use it to search the database for consultant's information
                                        home.ConsultantOfficeInfo(ConsultantID); //this is to send the next form the ConsultantID, so that it can use it to search the database for consultant's hospital affliation's information
                                        home.Show();
                                        this.Hide();
                                        home.Closed += (s, args) => Close();//this event will close only the current form
                                    }
                                    else
                                    {
                                        main.ConsultantInfo(ConsultantID);
                                        main.Show();
                                        this.Hide();
                                        main.Closed += (s, args) => Close();//this event will close only the current form
                                    }
                                }
                                else //if the passcodes do not match, an error notifcation will be displayed
                                {
                                    lblKeyInfo.ForeColor = Color.Tomato;
                                    lblKeyInfo.Text = "The Key Code you entered is incorrect. Please Try Again!";
                                }
                            }
                        }
                        else //if the loginID is not found in the database an error notification is displayed
                        {
                            lblLoginInfo.ForeColor = Color.Tomato;
                            lblLoginInfo.Text = "The Login ID '" + Login + "' is incorrect. Please Try Again!";
                        }
                        con.Close(); 
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(null, "An error occured when logging into the Consultant System\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

    }
}
