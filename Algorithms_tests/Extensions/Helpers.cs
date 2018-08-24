using System;
using System.Collections;
using System.Collections.Generic;

namespace Extensions
{
    public static class Helpers
    {
        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2 || firstIndex == secondIndex)
                return;

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
