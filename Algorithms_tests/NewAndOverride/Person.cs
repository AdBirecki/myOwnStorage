using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverride
{
    class Person : Humanoidal
    {
        public override void Introduce()
        {
            Console.WriteLine($"Person");
        }
    }
}
