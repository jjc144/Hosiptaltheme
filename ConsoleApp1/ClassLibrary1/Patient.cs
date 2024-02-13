using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Patient 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string MedicalCondition { get; set; }
        public Patient(string name, int age, string medicalCondition)
        {
            Name = name;
            Age = age;
            MedicalCondition = medicalCondition;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Patient Name: {Name}, Age: {Age}, Condition: {MedicalCondition}");
        }
    }
}
