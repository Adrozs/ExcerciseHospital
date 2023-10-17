using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseHospital
{
    internal class Doctor : Person
    {
        public int Salary;


        public Doctor(string name, int salary)
        {
            Name = name;
            Salary = salary;
            Profession = "Doctor";
        }



        public void WritePrescription(Patient patient)
        {
            Console.WriteLine($"{Profession} {Name} writes a prescription for {patient.Name} and their {patient.Diagnosis}.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is a {Profession} and earns {Salary}.");
        }


    }
}
