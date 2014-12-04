using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace clinique
{
    public partial class CreateAppointment : Form
    {
        public string availableTimeForDoctor = "";
        public string availableRooms = "";
        public String[] result123 = new String[100];
        public String[] result1234 = new String[10];

        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string theDate = dtpAppointmentDate.Value.ToShortDateString();
                Appointment appointment1 = new Appointment(txtPatientName.Text, txtPatientNumber.Text, txtDoctorName.Text, theDate, txtAppointmentTime.Text, txtRoomNumber.Text);

                AppointmentDAL aDAL = new AppointmentDAL(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

                int result = 0;

                try
                {
                    aDAL.OpenConnection();
                    result = aDAL.CreateAppointment(appointment1);
                    if (result == -1)
                    {
                        MessageBox.Show("Successfully Created Appointment!");
                    }
                    
                    int result1 = 0;
                    result1 = aDAL.RemoveRoomAvailability(txtRoomNumber.Text, dtpAppointmentDate.Value.ToShortDateString(), txtAppointmentTime.Text);
                    if(result1 == -1) {
                        //MessageBox.Show("Removed Room avail");
                    }

                    int result2 = 0;
                    result2 = aDAL.RemoveDoctorAvailability(txtDoctorName.Text, dtpAppointmentDate.Value.ToShortDateString(), txtAppointmentTime.Text);
                    if(result2 == -1) {
                        //MessageBox.Show("Removed Doctor avail");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    aDAL.CloseConnection();

                    txtPatientName.Clear();
                    txtPatientNumber.Clear();
                    txtDoctorName.Clear();
                    txtAppointmentTime.Clear();
                    txtRoomNumber.Clear();
                }  
            }
        }

        private bool ValidateForm()
        {
            int val = 0;
            // Define Valid time slots 
            string[] ValidTimes = new string[] { "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };
            // If empty throw error
            if (txtAppointmentTime.Text == "")
            {
                val = -1;
                CreateAppointmentErrorProvider.SetError(txtAppointmentTime, "This field cannot be empty");
                CreateAppointmentErrorProvider.BlinkRate = 0;
            }
            // If invalid throw error 
            for (int i = 0; i < ValidTimes.Length; i++)
            {
                int pos = Array.IndexOf(ValidTimes, txtAppointmentTime.Text);
                if (!(pos > -1))
                {
                    val = -1;
                }
                if (val == -1)
                {
                    CreateAppointmentErrorProvider.SetError(txtAppointmentTime, "Invalid Time entry. Please enter a value between 9:00 - 17:00");
                    CreateAppointmentErrorProvider.BlinkRate = 0;
                    txtAppointmentTime.Clear();
                }
            }
            
            if (txtDoctorName.Text == "")
            {
                val = -1;
                CreateAppointmentErrorProvider.SetError(txtDoctorName, "This field cannot be empty");
                CreateAppointmentErrorProvider.BlinkRate = 0;
            }

            if (txtPatientName.Text == "")
            {
                val = -1;
                CreateAppointmentErrorProvider.SetError(txtPatientName, "This field cannot be empty");
                CreateAppointmentErrorProvider.BlinkRate = 0;
            }

            if (txtPatientNumber.Text == "")
            {
                val = -1;
                CreateAppointmentErrorProvider.SetError(txtPatientNumber, "This field cannot be empty");
                CreateAppointmentErrorProvider.BlinkRate = 0;
            }

            if (txtRoomNumber.Text == "")
            {
                val = -1;
                CreateAppointmentErrorProvider.SetError(txtRoomNumber, "This field cannot be empty");
                CreateAppointmentErrorProvider.BlinkRate = 0;
            }

            if (Array.IndexOf(result123, txtAppointmentTime.Text.Trim()) != -1)
            {
                MessageBox.Show("Valid Time");
            }

            else
            {
                MessageBox.Show("InvalidTime");
            }

            if (val < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void btnCheckAvailableRooms_Click(object sender, EventArgs e)
        {
             Array.Clear(result1234, 0, 10);
             lblAvailableRooms.Text = "";
            
            getRooms gr = new getRooms(dtpAppointmentDate.Value.ToShortDateString(), txtAppointmentTime.Text.Trim());
           
            result1234 = gr.GetRoomProc(gr);
            for (int i = 0; i < result1234.Length; i++)
            {
                if (result1234[i] != "")
                {
                    availableRooms = availableRooms + " " + result1234[i];
                }
            }

            lblAvailableRooms.Text = availableRooms;
        }

        private void btnCheckDoctorAvailability_Click(object sender, EventArgs e)
        {
            getDoctorAvailability gd = new getDoctorAvailability(dtpAppointmentDate.Value.ToShortDateString(), txtDoctorName.Text.Trim());

            Array.Clear(result123, 0, 100);
            lblDoctorAvailableTime.Text = "";

            result123 = gd.getAvailabilityProc(gd);
            for (int i = 0; i < result123.Length; i++)
            {
                if (result123[i] != "")
                {
                    availableTimeForDoctor = availableTimeForDoctor + "\n" + result123[i];
                }
            }

            
            lblDoctorAvailableTime.Text = "Available Times" + availableTimeForDoctor;
        }

        private void grpCreateAppointment_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDoctorAvailableTime.Text = "";
        }
    }
}
