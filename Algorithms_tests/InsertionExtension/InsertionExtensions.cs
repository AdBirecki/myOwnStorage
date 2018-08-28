using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace InsertionExtension
{
    public static class InsertionExtensions
    {
        public static bool IsLessThan<T>(this T firstValue, T secondValue) where T: IComparable<T>
        {
            var temp = firstValue.CompareTo(secondValue);
            return firstValue.CompareTo(secondValue) < 0;
        }

        public static bool IsGreaterThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.CompareTo(secondValue) > 0;
        }

        public static bool IsEqualTo<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.Equals(secondValue);
        }

        public static void Swap<T>(this List<T> collection, int firstIndex, int secondIndex) where T : IComparable<T>
        {
            if (collection.Count < 2 || firstIndex == secondIndex)
                return;

            T temp = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = temp;
        }
    }
}
