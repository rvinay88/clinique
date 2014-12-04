using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinique
{
    class Appointment
    {
        public string PatientName { get; private set; }
        public string PatientNumber { get; private set; }
        public string DoctorName { get; private set; }
        public string AppointmentDate { get; private set; }
        public string AppointmentTime { get; private set; }
        public string RoomNumber { get; private set; }

        public Appointment(string patientName, string patientNumber, string doctorName, string appointmentDate, string appointmentTime, string roomNumber)
        {
            PatientName = patientName;
            PatientNumber = patientNumber;
            DoctorName = doctorName;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
            RoomNumber = roomNumber;
        }
    }
}
