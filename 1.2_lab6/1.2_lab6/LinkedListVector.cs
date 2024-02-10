using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab6
{
    [Serializable]
    class LinkedListVector : IVector
    {
        [Serializable]
        public class Node
        {
            public double element;
            public Node next;
            public Node()
            {
                element = 0;
                next = null;
            }
            public Node(double elem)
            {
                element = elem;
                next = null;
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public double Element
            {
                get { return element; }
                set { element = value; }
            }
        }
        private Node head = null;
        public LinkedListVector()
        {
        }
        public LinkedListVector(int length)
        {
            int i = 0;
            //double elem = 0;
            while (i < length)
            {
                Add(0);
                i++;
            }
        }
        public void Add(double elem)
        {
            Node node = new Node(elem);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }
        public int Length
        {
            get
            {
                int length = 0;
                Node current = head;
                while (current != null)
                {
                    length++;
                    current = current.Next;
                }
                return length;
            }
        }
        public double this[int ndx]
        {
            get
            {
                if (ndx >= Length || ndx < 0) throw new IndexOutOfRangeException("Указан некорректный индекс!");
                int i = 0;
                Node current = head;
                while (i != ndx)
                {
                    current = current.Next;
                    i++;
                }
                return current.Element;
            }
            set
            {
                if (ndx >= Length || ndx < 0) throw new IndexOutOfRangeException("Указан некорректный индекс!");
                Node node = new Node(value);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    int count = 0;
                    Node current = head;
                    while (count != ndx)
                    {
                        current = current.Next;
                        count++;
                    }
                    current.Element = value;
                }
            }
        }
        public double GetNorm()
        {
            Node current = head;
            double norm = 0;
            while (current != null)
            {
                norm += Math.Pow(current.Element, 2);
                current = current.Next;
            }
            return Math.Sqrt(norm);
        }
        public override bool Equals(object a)
        {
            bool result = false;
            if (a is IVector vector1 && this is IVector vector2 && vector1.GetNorm() == vector2.GetNorm() && vector1.Length == vector2.Length)
            {
                result = true;
            }
            return result;
        }
        public int CompareTo(object a)
        {
            if (a is IVector _a && this is IVector _b) return _b.Length - _a.Length;
            else throw new NotSupportedException();
        }
        public object Clone()
        {
            LinkedListVector clone = new LinkedListVector(Length);
            for (int i = 0; i < Length; i++) clone[i] = this[i];
            return clone;
        }
        public override string ToString()
        {
            string result = "";
            Node current = head;
            while (current != null)
            {
                result += current.Element + " ";
                current = current.Next;
            }
            return result;
        }

    }
}
