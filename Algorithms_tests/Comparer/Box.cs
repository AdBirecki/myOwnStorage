using System;

namespace Comparer
{
    public class Box : IComparable<Box>
    {
        public Box(int h, int l, int w)
        {
            Height = h ;
            Length = l;
            Width = w;
        }
        public int Height { get; private set; }
        public int Length { get; }
        public int Width { get; }


        public int CompareTo(Box other)
        {
            if (Height.CompareTo(other.Height) != 0)
            {
                return Height.CompareTo(other.Height);
            }
            if (Length.CompareTo(other.Length) != 0)
            {
                return Length.CompareTo(other.Length);
            }
            if (Width.CompareTo(other.Width) != 0)
            {
                return Width.CompareTo(other.Width);
            }

            return 0;
        }
    }
}
