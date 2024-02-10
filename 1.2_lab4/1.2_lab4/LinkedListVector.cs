using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab4
{
    class LinkedListVector : IVector
    {
        public class Node
        {
            public Node link;
            public double element;
            public Node()
            {
                link = null;
                element = 0;
            }
            public Node(double t)
            {
                link = null;
                element = t;
            }
            public Node Link
            {
                get { return link; }
                set { link = value; }
            }
            public double Element
            {
                get { return element; }
                set { element = value; }
            }
        }

        private Node head;
        public LinkedListVector()
        {
            for (int i = 0; i < 5; i++) Add(0);
        }
        public LinkedListVector(int length)
        {
            for (int i = 0; i < length; i++) Add(0);
        }

        public int Length
        {
            get
            {
                int length = 0;
                for (Node node = head; node != null; node = node.Link)
                { length++; }
                return length;
            }
        }
        public void Add(double t)
        {
            int length = 0;
            Node n = new Node(t);
            if (head == null) head = n;
            else
            {
                Node current = head;
                while (current.Link != null)
                {
                    current = current.Link;
                }
                current.Link = n;
            }
            length++;
        }



        public double this[int index]
        {
            get
            {
                Node current = head;
                if (Length >= index & index >= 0)
                {
                    for (int i = 0; i < index; i++) if (current.Link == null) throw new IndexOutOfRangeException("Индекс списка находился вне границы"); else current = current.Link;
                    return current.element;
                }
                else throw new IndexOutOfRangeException("Индекс списка находился вне границы");
            }
            set
            {
                Node current = head;
                for (int i = 0; i <= index; i++) if (current.Link == null) throw new IndexOutOfRangeException("Индекс списка находился вне границы"); else current = current.Link;
                current.Element = value;
            }
        }

        public double GetNorm()
        {
            double abs = 0;
            Node current = head;
            for (int i = 0; i < Length; i++)
            {
                abs += current.element * current.element;
                current = current.Link;
            }
            return Math.Sqrt(abs);
        }
        public override string ToString()//ВОТ ТУ ВСЕ НАЧИНАЛОСЬ
        {
            string res = null;
            Node current = head;
            for (int i = 0; i < Length; i++) { res += Convert.ToString(current.Element) + " "; current = current.Link; }
            return Length + " | " + res;//А ВОТ ТУТ ЗАКОНЧИЛОСЬ
        }
    }
}
