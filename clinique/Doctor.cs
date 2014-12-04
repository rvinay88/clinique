using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinique
{
    class Doctor
    {
        public enum employment
        {
            PartTime, FullTime
        }
        public string DoctorName { get; private set; }
        public string DoctorPhone { get; private set; }
        public string Specialization { get; private set; }
        public employment Employment { get; private set; }

        public Doctor(string doctorName, string doctorPhone, string specialization, employment employment1)
        {
            DoctorName = doctorName;
            DoctorPhone = doctorPhone;
            Specialization = specialization;
            Employment = employment1;
        }

    }
}
