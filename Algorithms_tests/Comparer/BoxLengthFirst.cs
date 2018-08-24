using System.Collections.Generic;

namespace Comparer
{
    public class BoxLengthFirst: Comparer<Box>
    {
        public override int Compare(Box x, Box y)
        {
            if (x.Length.CompareTo(y.Length) != 0)
            {
                return x.Length.CompareTo(y.Length);
            }
            if (x.Height.CompareTo(y.Height) != 0)
            {
                return x.Height.CompareTo(y.Height);
            }
            if (x.Width.CompareTo(y.Width) != 0)
            {
                return x.Width.CompareTo(y.Width);
            }

            return 0;
        }
    }
}
