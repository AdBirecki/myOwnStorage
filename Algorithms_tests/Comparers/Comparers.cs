﻿using System;

namespace Comparers
{
    public static class Comparers
    {
        public static bool IsNumber<T>(this T value)
        {
            if (value is sbyte) return true;
            if (value is byte) return true;
            if (value is short) return true;
            if (value is ushort) return true;
            if (value is int) return true;
            if (value is uint) return true;
            if (value is ulong) return true;
            if (value is float) return true;
            if (value is double) return true;
            if (value is decimal) return true;

            return false;
        }

        public static bool IsEqualTo<T>(this T firstvalue, T secondValue) where T : IComparable<T>
        {
            return firstvalue.Equals(secondValue);
        }

        public static bool IsGreaterThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.CompareTo(secondValue) > 0;
        }

        public static bool IsLessThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.CompareTo(secondValue) < 0;
        }
    }
}
