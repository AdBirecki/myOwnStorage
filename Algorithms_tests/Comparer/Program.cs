using System.Collections.Generic;
using static System.Console;
namespace Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> Boxes = new List<Box>();
            Boxes.Add(new Box(4, 20, 14));
            Boxes.Add(new Box(12, 12, 12));
            Boxes.Add(new Box(8, 20, 10));
            Boxes.Add(new Box(6, 10, 2));
            Boxes.Add(new Box(2, 8, 4));
            Boxes.Add(new Box(2, 6, 8));
            Boxes.Add(new Box(4, 12, 20));
            Boxes.Add(new Box(18, 10, 4));
            Boxes.Add(new Box(24, 4, 18));
            Boxes.Add(new Box(10, 4, 16));
            Boxes.Add(new Box(10, 2, 10));
            Boxes.Add(new Box(6, 18, 2));
            Boxes.Add(new Box(8, 12, 4));
            Boxes.Add(new Box(12, 10, 8));
            Boxes.Add(new Box(14, 6, 6));
            Boxes.Add(new Box(16, 6, 16));
            Boxes.Add(new Box(2, 8, 12));
            Boxes.Add(new Box(4, 24, 8));
            Boxes.Add(new Box(8, 6, 20));
            
            WriteLine("H - L - W");
            WriteLine("==========");

            foreach (Box bx in Boxes )
            {
                WriteLine("{0}\t{1}\t{2}", bx.Height.ToString(), bx.Length.ToString(), bx.Width.ToString());
            }

            WriteLine();
            WriteLine("H - L - W");
            WriteLine("==========");

            Comparer<Box> defComparer = Comparer<Box>.Default;


            Boxes.Sort();

            foreach (Box bx in Boxes)
            {
                WriteLine($"{bx.Height.ToString()}\t{bx.Length.ToString()}\t{bx.Width.ToString()}");
            }

            BoxLengthFirst LengthFirst = new BoxLengthFirst();

            Comparer<Box> bc = LengthFirst;

            Box boxA = new Box(2, 6, 8);
            Box boxB = new Box(10, 12, 14);
            int x = LengthFirst.Compare(boxA, boxB);
            WriteLine();
            WriteLine(x.ToString());

            ReadLine();
        }
    }
}
