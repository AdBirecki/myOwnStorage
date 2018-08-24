using System;
using static System.Console;

namespace Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            Human h = new Human(28, "Adam");
            h.Introduce();
            h.AnimalWalks();

            Animal a = h;
            a.Introduce();
            a.AnimalWalks();
            ReadLine();
        }
    }
}
