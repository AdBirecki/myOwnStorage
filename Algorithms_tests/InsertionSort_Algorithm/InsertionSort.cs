using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using InsertionExtension;
using Model;

namespace InsertionSort_Algorithm
{
    public static class InsertionSort_Algorithm
        {
            public static IList<T> InsertSort<T>(this IList<T> collection, Comparer<T> comparer = null) where T :IComparable<T>
            {
                // comparer = comparer ?? Comparer<T>.Default;

                List<Node<T>> nodesCollection = new List<Node<T>>();
                foreach (T value in collection)
                {
                    nodesCollection.Add(new Node<T>(value));
                }

                // start of algorithm

                int i, j;
                for (i = 1; i < nodesCollection.Count; i++)
                {
                    Node<T> node = nodesCollection[i];
                    j = i - 1;
                    while (j > 0 && nodesCollection[j].IsGreaterThan(nodesCollection[i]))
                    {
                        nodesCollection[j + 1] = nodesCollection[j];
                        j--;
                    }
                    nodesCollection[j + 1] = node;
                }

                return nodesCollection.Select(node => node.Value).ToList();
            }
    }
}
