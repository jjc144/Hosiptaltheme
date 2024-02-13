using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Nurse : Patient
    {
        public int ShiftsPerWeek { get; set; }

        public Nurse(string name, int age,string medicalCondition, int shiftsPerWeek):
            base(name, age, medicalCondition)
        {
            ShiftsPerWeek = shiftsPerWeek;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Nurse Shifts per Week: {ShiftsPerWeek}");
        }
    }
}
