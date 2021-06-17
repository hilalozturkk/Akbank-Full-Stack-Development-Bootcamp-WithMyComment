using System;

namespace OOPOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Staff staff = new Staff();
            staff.Name = "Hilal";
            staff.Married = true;

            Staff staff1 = staff;
            staff1.Name = "Ayşe";
            Console.WriteLine(staff.Name); //Ayşe

            /*
            staff.SetValueToAge(-14); // set age
            staff.GetValueAge(); // return age

            Console.WriteLine(staff.GetValueAge()); //exception  
            */

            staff.SetAge(-14); // set age
            staff.GetAge(); // return age

        }
    }
}
