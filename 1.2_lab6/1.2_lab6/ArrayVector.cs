using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab6
{
    [Serializable]
    class ArrayVector : IVector
    {
        public double[] vector;
        public ArrayVector()
        {
            vector = new double[5];
            RandomInput();
        }
        public ArrayVector(int n)
        {
            //this.n = n;
            vector = new double[n];
            //Length = n;
            //Input();
        }
        public void RandomInput()
        {
            int n = 5;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = r.Next(-10, 10);
            }
        }
        //public void Input()
        //{
        //    Console.WriteLine("Введите значения вектора:");
        //    int l = Console.CursorLeft;
        //    int h = Console.CursorTop;
        //    for (int i = 0; i < Length; i++)
        //    {
        //        Console.SetCursorPosition(l + 4 * i, h);
        //        vector[i] = Convert.ToDouble(Console.ReadLine());
        //    }
        //}
        public Int32 Length
        {
            get
            {
                return vector.Length;
            }
        }
        public double this[int a]
        {
            get
            {
                if (a >= Length || a < 0) throw new IndexOutOfRangeException("Указан некорректный индекс!");
                return vector[a];
            }
            set
            {
                if (a >= Length || a < 0) throw new IndexOutOfRangeException("Указан некорректный индекс!");
                vector[a] = value;
            }
        }
        public double GetNorm()
        {
            double p = 0;
            for (int i = 0; i < Length; i++)
            {
                p = p + Math.Pow(vector[i], 2);
            }
            return Math.Sqrt(p);
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
            ArrayVector clone = new ArrayVector(Length);
            for (int i = 0; i < Length; i++) clone[i] = this[i];
            return clone;
        }
        public override string ToString()
        {
            string result = "";
            //result += Convert.ToString(Length) + " ";
            for (int i = 0; i < Length; i++)
            {
                result += Convert.ToString(vector[i]) + " ";
            }
            return result;
        }
    }
}
