using System;

namespace Model
{
    public class Node<T>: IComparable<Node<T>> where T : IComparable
    {

        public T Value { get; }

        public int CompareTo(Node<T> other)
        {
            if (other == null) return -1;
            return this.Value.CompareTo(other.Value);
        }

    }
}
