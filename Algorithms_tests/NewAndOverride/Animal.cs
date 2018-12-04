using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverride
{
    class Animal
    {
        public virtual void Introduce() {
            Console.WriteLine($"Animal");
        }
    }
}
