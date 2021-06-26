using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BuiltinInterfaces
{
    public class Student : IComparable<Student> // sort() -> sorted from smallest to largest
        //IComparable<> -> preppared interface used to sort() ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo([AllowNull] Student other) //0,1,-1
        {
            if (this.Age == other.Age)
            {
                return 0;
            }
            else if (this.Age > other.Age)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
