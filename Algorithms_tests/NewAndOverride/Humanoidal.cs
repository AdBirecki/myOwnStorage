using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverride
{
    class Humanoidal : Mamal
    {
        public new virtual void Introduce()
        {
            Console.WriteLine($"Humanoidal");
        }
    }
}
