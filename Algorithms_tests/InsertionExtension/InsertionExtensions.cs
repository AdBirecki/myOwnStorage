using System;
using System.Runtime.CompilerServices;

namespace InsertionExtension
{
    public static class InsertionExtensions
    {
        public static bool IsLessThan<T>(this T firstValue, T secondValue) where T: IComparable<T>
        {
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

    }
}
