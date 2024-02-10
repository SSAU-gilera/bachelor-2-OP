using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab5
{
    class LinkedListVector : IVector, IComparable, ICloneable
    {
        public class Node : ICloneable
        {
            double elem;
            Node next;
            public Node() { }
            public double Element { get; set; }
            public Node Next { get; set; }
            public Node(double elem)
            {
                Element = elem;
            }
            public override string ToString()
            {
                return Element.ToString();
            }
            public object Clone()
            {
                Node m = (Node)this.MemberwiseClone();
                m.elem = (double)elem;
                if (next != null)
                {
                    m.next = (Node)next.Clone();
                }
                return m;
            }
        }
        private Node head = null;
        public LinkedListVector()
        {
            Length = 5;
            for (int i = 0; i < Length; i++)
            {
                Add(0);
            }
        }
        public LinkedListVector(int length)
        {
            Length = length;
            for (int i = 0; i < Length; i++)
            {
                Add(0);
            }
        }
        public int Length { get; set; }
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
        public double this[int ndx]
        {
            get
            {
                if (ndx >= Length || ndx < 0) throw new IndexOutOfRangeException("Указан некорректный индекс!");
                int count = 0;
                Node current = head;
                while (count != ndx)
                {
                    current = current.Next;
                    count++;
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
        public override string ToString()
        {
            string result = Length + " | ";
            Node current = head;
            while (current != null)
            {
                result += current.Element + " ";
                current = current.Next;
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is IVector)
            {
                IVector mo = obj as IVector;
                if (mo.Length == Length)
                {
                    int i = 0;
                    while (i < Length && mo[i] == this[i])
                    {
                        i++;
                    }
                    if (i == Length)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Объект не реализует интерфейс IVector");
            }
        }
        public override int GetHashCode()
        {
            double sum = 0;
            for (int i = 0; i < this.Length; i++)
            {
                sum += this[i];
            }
            return (int)sum + this.Length;
        }
        public int CompareTo(object obj)
        {
            IVector vector;
            try
            {
                vector = obj as IVector;
                if (this.Length < vector.Length)
                {
                    return -1;
                }
                else
                {
                    if (this.Length > vector.Length)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            throw new NotImplementedException();
        }
        public object Clone()
        {
            LinkedListVector vector = (LinkedListVector)this.MemberwiseClone();
            vector.head = (Node)head.Clone();
            return vector;
        }
    }
}
