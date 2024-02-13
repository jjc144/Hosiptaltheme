using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Doctor : Patient
    {
        public string Specialization { get; set; }

        public Doctor(string name, int age, string medicalCondition, string specialization) :
              base(name, age, medicalCondition)
        {
            Specialization = specialization;
        }
    } public override void DisplayInfo()
        {
        base.DisplayInfo();
        Console.WriteLine($"Doctor Specialization: {specialization}");
        }

    }   
}
