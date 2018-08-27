using System;
using System.Collections.Generic;

namespace InsertionSort_Algorithm
{
    public class InsertionSort_Algorithm
        {
            public static void InsertSort<T>(this IList<T> collection, Comparer<T> comparer)
            {
            comparer = comparer ?? Comparer<T>.Default;


            }
    }
}
