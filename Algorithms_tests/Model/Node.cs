using System;

namespace Model
{
    public class Node<T>: IComparable<Node<T>> where T : IComparable<T>
    {
        private System.Collections.Generic.IList<T> value;

        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; }

        public int CompareTo(Node<T> other)
        {
            if (other == null) return -1;
            return this.Value.CompareTo(other.Value);
        }

    }
}
