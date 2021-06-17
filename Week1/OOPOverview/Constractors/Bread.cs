using System;
using System.Collections.Generic;
using System.Text;

namespace Constractors
{
    public class Bread
    {
        public int Number { get; set; }
        public string Type { get; set; }

        // 
        public Bread() : this(1,"White Bread")
        {
            //Number = 1;
            //Type = "White Bread";
        }
        public Bread(int number) : this(number,"White Bread")
        {
            //Number = number;
            //Type = "White Bread";
        }
        public Bread(string type) : this(1,type)
        {
            //Number = 1;
            //Type = type;
        }
        public Bread(int number, string type) 
        {
            Number = number;
            Type = type;
        }

    }
}
