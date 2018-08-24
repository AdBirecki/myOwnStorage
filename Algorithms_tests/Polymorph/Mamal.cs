using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Polymorph
{
    public class Mamal : Animal
    {
        public Mamal(int age, string name) : base(age, name)
        {
        }

        public override void Introduce()
        {
            WriteLine($"This is Mamal");
        }
        public void MamalMilks()
        {
            WriteLine($"Mamal milks!");
        }
    }
}
