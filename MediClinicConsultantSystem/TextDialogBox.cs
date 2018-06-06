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
    public partial class TextDialogBox : Form
    {
        SqlConnection con;
        string Pointer = string.Empty;
        string GlobalRecordID = string.Empty;
        public TextDialogBox()
        {
            InitializeComponent();
            DBConnection obj = new DBConnection();
            con = obj.getConnection();
        }

        public void FormSetup(string TypeOfForm, string RecordID)
        {
            GlobalRecordID = RecordID;
            if(TypeOfForm == "HealthProblems")
            {
                lblHeading.Text = "Type in the patient's health problems";
                Pointer = "Health";
            }
            if(TypeOfForm == "PrescriptionDetails")
            {
                lblHeading.Text = "Type in the Prescription Details";
                Pointer = "Prescription";
            }
        }

        private void AddHealthProblems()
        {
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("UPDATE PatientRecordsTable SET ProblemDescription = @pd WHERE Record_ID = @rid", con))
                {
                    cmd.Parameters.AddWithValue("@pd", SqlDbType.VarChar).Value = txtText.Text;
                    cmd.Parameters.AddWithValue("@rid", SqlDbType.VarChar).Value = GlobalRecordID;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when updating the patient records with their health problems\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPrescriptionDetails()
        {
            try
            {
                if (con.State == ConnectionState.Closed) //this selection will open the database connecion if it is not already opened
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("UPDATE PatientRecordsTable SET PrescriptionDetails = @prd WHERE Record_ID = @rid", con))
                {
                    cmd.Parameters.AddWithValue("@prd", SqlDbType.VarChar).Value = txtText.Text;
                    cmd.Parameters.AddWithValue("@rid", SqlDbType.VarChar).Value = GlobalRecordID;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "An error occured when updating the patient records with the prescription details\nError: " + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtText_Enter(object sender, EventArgs e)
        {
            txtText.ForeColor = Color.WhiteSmoke;
            txtText.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Pointer == "Health")
            {
                AddHealthProblems();
            }
            if (Pointer == "Prescription")
            {
                AddPrescriptionDetails();
            }
            this.Close();
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtText.MaxLength = 250;
            if(txtText.TextLength > 250)
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
