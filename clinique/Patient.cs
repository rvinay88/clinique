using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinique
{
    class Patient
    {
        public string PatientName { get; private set; }
        public string PatientPhone { get; private set; }
        public string PatientIssue { get; private set; }

        public Patient(string patientName, string patientPhone, string patientIssue)
        {
            PatientName = patientName;
            PatientPhone = patientPhone;
            PatientIssue = patientIssue;
        }
    }
}
