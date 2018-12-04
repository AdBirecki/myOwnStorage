using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverride
{
    class Mamal : Animal
    {
        public override void Introduce()
        {
            Console.WriteLine($"Mamal");
        }
    }
}
