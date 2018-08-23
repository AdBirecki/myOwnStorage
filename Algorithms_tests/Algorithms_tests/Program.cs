using BSTS_Models;
using System;
using System.Collections.Generic;
using Comparers;

namespace Algorithms_tests
{
    public static class BinaryTreeSearchSorter
    {
        public static void UnbalancedBSTSort<T>(this List<T> collection) where T: IComparable<T>
        {
            if (collection.Count == 0 )
                return;

            Node<T> rootNode = new Node<T> { Value = collection[0]};

            for(int i = 1; i < collection.Count; ++i)
            {

                var currentNode = rootNode;
                var newNode = new Node<T>() {Value = collection[i] };

                while (true)
                {
                    // go left
                    if (newNode.Value.IsLessThan(currentNode.Value))
                    {
                        if (currentNode.Left == null)
                        {
                            newNode.Parent = currentNode;
                            currentNode.Left = newNode;
                            break;
                        }
                        currentNode = currentNode.Left;
                    }

                    // go right
                    else 
                    {
                        if (currentNode.Right == null)
                        {
                            newNode.Parent = currentNode;
                            currentNode.Right = newNode;
                            break;
                        }

                        currentNode = currentNode.Right;
                    }
                }
            }

            // Reference handle to root again.
            collection.Clear();
            var treeRootRefernce = rootNode;
            _inOrderTravelAndAdd(treeRootRefernce, ref collection);
            treeRootRefernce = rootNode = null;
        }

        private static void _inOrderTravelAndAdd<T>(Node<T> currentNode, ref List<T> collection) where T: IComparable<T>
        {
            if (currentNode == null)
                return;
            
            _inOrderTravelAndAdd<T>(currentNode.Left, ref collection);
            collection.Add(currentNode.Value);
            _inOrderTravelAndAdd<T>(currentNode.Right, ref collection);
        }
    }
}
