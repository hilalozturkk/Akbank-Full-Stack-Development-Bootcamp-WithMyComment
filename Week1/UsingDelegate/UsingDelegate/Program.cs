using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingDelegate
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)

        {//this process of passing a method as a parameter to another method
            var evenNumbers = Filter.FilterArray(numbers,getEvenNumbers);
           
            //.NET 2.0 ->

            var multiplierThree = Filter.FilterArray(numbers,
                delegate(int value)
                {
                    return value % 3 == 0;
                });

            //.NET 3.5 ->

            var moreThanFive = Filter.FilterArray(numbers, x => x > 5);

            List<string> names = new List<string> { "Hilal", "Aydın Necmi", "Burak", "Türkay" };
            names = names.Where(name => name.StartsWith("B")).ToList();
            names.OrderBy(x => x);
            names.ForEach(name => Console.WriteLine(name));
            
            foreach(var item in moreThanFive)
            {
                Console.WriteLine(item);
            }  
        }

        static bool getEvenNumbers(int value)
        {
            return value % 2 == 0;
        }
    }
}
