using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Polymorph
{
    public class Animal
    {
        public Animal(int age, string name) {
            Age = age;
            Name = name;
        }

        public virtual void Introduce() {
            WriteLine($" This is an Animal");
        }
        public int Age {get; set;}
        public string Name { get; set; }

        public void AnimalWalks() {
            WriteLine($"Animal walks");
        }
    }
}
