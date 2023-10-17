using ExcerciseHospital;
using System;

namespace ExcercieHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor1 = new Doctor("Johan", 70000);
            Nurse nurse1 = new Nurse("Agda", "Day");
            Nurse nurse2 = new Nurse("Jenny", "Night");

            Patient patient1 = new Patient("Aldor", "Fever" ,"Alvedon");
            Patient patient2 = new Patient("Stefan", "Cancer", "Ipren");
            Patient patient3 = new Patient("Jonas", "Fraktur", "Morfin");
            Patient patient4 = new Patient("Inez", "Headache");
            Patient patient5 = new Patient("Fredrik", "Ligma");


            doctor1.WritePrescription(patient5);
            nurse1.TakeBloodTest(patient3);
            nurse2.TakeBloodTest(patient1);

            Console.WriteLine();


            List<Person> people = new List<Person> 
            {doctor1, nurse1, nurse2, patient1, patient2, patient3, patient4, patient5 };


            foreach (Person person in people )
            {
                person.PrintInfo();
                Console.WriteLine();
            }








        }
    }
}