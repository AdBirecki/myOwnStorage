﻿using BSTS_Models;
using System;
using System.Collections.Generic;

namespace Algorithms_tests
{
    public static class BinaryTreeSearchSorter
    {
        public static void UnbalancedBSTSort<T>(this List<T> collection) where T: IComparable<T>
        {
            if (collection.Count == 0 )
                return;

            Node<T> rootNode = new Node<T> { Value = collection[0]};


        }
    }
}
