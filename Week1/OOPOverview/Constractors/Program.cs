using System;

namespace Constractors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Bread bread = new Bread();
            Console.WriteLine(bread.Type);//White Bread

            Bread bread1 = new Bread("Trabzon Bread");
            Console.WriteLine(bread1.Type);//Trabzon Bread
        }
    }
}
