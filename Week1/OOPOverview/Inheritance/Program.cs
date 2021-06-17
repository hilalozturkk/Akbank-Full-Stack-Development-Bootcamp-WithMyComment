using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Gamer gamer = new Gamer();
            gamer.GamerOfGun = new Ak47();  //!!!

            Chef chef = new Chef();
            chef.Cook(new Meatball()); // chef -> food -> meat meal -> meatball

        }
    }
}
