using ExtensionMethod.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine( number.Square());

            Random random = new Random();
            Console.WriteLine( random.RandomLetter());
            Console.WriteLine(random.RandomWord(16));
        }

    }
}
