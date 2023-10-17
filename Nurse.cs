using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseHospital
{
    internal class Nurse : Person
    {
        public string Shift;

        public Nurse(string name, string shift)
        {
            Name = name;
            Shift = shift;
            Profession = "Nurse";
        }


        public void TakeBloodTest()
        {
            Console.WriteLine($"{Name} took a blood sample");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is a {Profession} and works {Shift.ToLower()}.");
        }


    }
}
