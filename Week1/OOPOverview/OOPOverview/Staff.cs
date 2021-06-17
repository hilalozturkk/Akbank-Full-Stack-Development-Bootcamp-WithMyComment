using System;
using System.Collections.Generic;
using System.Text;

namespace OOPOverview
{
    public class Staff
    {
        private string name;
        private int age;
        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new Exception("Age value cant be negative."); 
            }
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public string Name
        {  //shortcut
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Age value cant be negative.");
                }

                name = value; 
            }

        }
        //.NET definition
        public bool Married { get; set; }

        public string Surname { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        private decimal DefaultHourlyRate = 100;
        public void WorkingHour(int totalHours)
        {
            Sales = DefaultHourlyRate * totalHours;
        }
        public decimal Sales { get;private set; } //read only


    }
}
