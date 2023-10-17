using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseHospital
{
    internal class Patient : Person
    {
        public string Diagnosis;
        public string Prescription = null;

        public DateTime CheckIn;
        public DateTime CheckOut;


        public Patient(string name, string diagnosis)
        {
            Name = name;
            Diagnosis = diagnosis;
            CheckIn = DateTime.Now;
            CheckOut = DateTime.Now.AddDays(1);

        }

        public Patient(string name, string diagnosis, string prescription)
        {
           Name = name;
           Diagnosis = diagnosis;
           Prescription = prescription;
           CheckIn = DateTime.Now;
           CheckOut = DateTime.Now.AddDays(1);

        }


        public override void PrintInfo()
        {
            if (Prescription != null)
            {
                Console.WriteLine($"Patient: {Name}. Diagnosis: {Diagnosis}. Prescription: {Prescription}." +
                $" \nCheck in date: {CheckIn}. Check out date: {CheckOut}");
            }
            else
            {
                Console.WriteLine($"Patient: {Name}. Diagnosis: {Diagnosis}. Prescription: Not needed." +
                $" \nCheck in date: {CheckIn}. Check out date: {CheckOut}");
            }
            
        }

    }
}
