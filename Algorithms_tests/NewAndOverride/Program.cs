using System;
using System.Collections.Generic;
using System.Linq;

namespace NewAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Animal> animaList = new List<Animal>
            {
                new Animal(),
                new Mamal(),
                new Humanoidal(),
                new Person()
            };


            foreach (var item in animaList) {
                item.Introduce();
            }


            List<Humanoidal> humanoiidalList = animaList.OfType<Humanoidal>().ToList();

            foreach (var item in humanoiidalList) {
                item.Introduce();
            }
            Console.ReadKey();

        }
    }
}
