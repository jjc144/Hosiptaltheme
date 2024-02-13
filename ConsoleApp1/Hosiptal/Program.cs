using System;

class Program
{
    static void Main()
    {
       
        
       Doctor doctor = new Doctor("Dr. Johnson", 40, "Cardiac Arrest", "Cardiologist");

        Console.WriteLine(doctor);

        Nurse nurse = new Nurse("Sarah Davis", 35, "Injury", 6);

        Inventory inventoryitem = new Inventory("Bandages", 100);

        doctor.DisplayInfo();
        nurse.DisplayInfo();
        inventoryitem.DisplayInfo();
    }   
}

