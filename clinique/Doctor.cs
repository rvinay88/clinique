using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinique
{
    class Doctor
    {
        public string DoctorName { get; private set; }
        public string DoctorPhone { get; private set; }
        public string Specialization { get; private set; }
        public string Employment { get; private set; }

        public Doctor(string doctorName, string doctorPhone, string specialization, string employment)
        {
            DoctorName = doctorName;
            DoctorPhone = doctorPhone;
            Specialization = specialization;
            Employment = employment;
        }

    }
}
