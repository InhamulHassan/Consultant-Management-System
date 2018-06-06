using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediClinicConsultantSystem
{
    public partial class AppointmentTimeSchedule : UserControl
    {
        public AppointmentTimeSchedule()
        {
            InitializeComponent();
        }
        public String GroupBoxTitle
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }

        public String StartTime
        {
            get { return dateTimeStart.Text; }
        }                  

        public String EndTime
        {
            get { return dateTimeEnd.Text; }
        }

        public bool IfStartTimeChecked
        {
            get { return dateTimeStart.Checked; }
        }

        public bool IfEndTimeChecked
        {
            get { return dateTimeEnd.Checked; }
        }

        private void dateTimeStart_Enter(object sender, EventArgs e)
        {
            if(dateTimeEnd.Checked)
            {
                dateTimeStart.Checked = true;
            }
            else
            {
                dateTimeStart.Checked = false;
            }
        }

        private void dateTimeEnd_Enter(object sender, EventArgs e)
        {
            if (dateTimeStart.Checked)
            {
                dateTimeEnd.Checked = true;
            }
            else
            {
                dateTimeEnd.Checked = false;
            }
        }

        private void dateTimeEnd_MouseLeave(object sender, EventArgs e)
        {
            if (dateTimeEnd.Checked)
            {
                dateTimeStart.Checked = true;
            }
            else
            {
                dateTimeStart.Checked = false;
            }
        }

        private void dateTimeStart_MouseLeave(object sender, EventArgs e)
        {
            if (dateTimeStart.Checked)
            {
                dateTimeEnd.Checked = true;
            }
            else
            {
                dateTimeEnd.Checked = false;
            }
        }
    }
}
