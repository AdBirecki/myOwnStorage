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
                for (j = 2; j < nodesCollection.Count; j++)
                {
                    Node<T> node = nodesCollection[j];
                    i = j - 1;
                    while (i >= 0 && nodesCollection[i].IsGreaterThan(nodesCollection[j]))
                    {
                        nodesCollection[i + 1] = nodesCollection[i];
                        i--;
                    }
                    nodesCollection[i + 1] = node;
                }

                return nodesCollection.Select(node => node.Value).ToList();
            }
    }
}
