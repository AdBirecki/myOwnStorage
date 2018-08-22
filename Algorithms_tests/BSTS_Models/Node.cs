using System;
using System.Collections.Generic;
using System.Text;
using static System.IComparable;

namespace BSTS_Models
{
    public class Node<T>: IComparable<Node<T>> where T: IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node()
        {
            Value = default(T);
            Parent = null;
            Left = null;
            Right = null;
        }

        public int CompareTo(Node<T> other)
        {
            if (other == null) return -1;
            return this.Value.CompareTo(other.Value);
        }
    }
}
