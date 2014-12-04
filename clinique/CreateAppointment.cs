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

namespace clinique
{
    public partial class CreateAppointment : Form
    {
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
                        MessageBox.Show("Successfully Inserted");
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

            string[] ValidTimes = new string[] { "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };

            if (txtAppointmentTime.Text == "")
            {
                val = -1;
                CreateAppointmentErrorProvider.SetError(txtAppointmentTime, "This field cannot be empty");
                CreateAppointmentErrorProvider.BlinkRate = 0;
            }

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

            if (val < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
