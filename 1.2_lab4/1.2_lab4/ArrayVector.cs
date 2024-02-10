using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab4
{
    class ArrayVector : IVector//не там ВОТ ТУТ
    {
        public double[] array;
        public ArrayVector(int n)
        {
            array = new double[n];
        }
        public ArrayVector()
        {
            array = new double[5];
        }

        public int Length
        {
            get { return array.Length; }
        }


        public double this[int i]
        {
            get
            {
                if (i > array.Length)
                    throw new IndexOutOfRangeException("Индекс больше длины массива!");
                if (i < 0)
                    throw new IndexOutOfRangeException("Индекс отрицателен!");
                else return array[i];
            }
            set
            {
                if (i > array.Length)
                    throw new IndexOutOfRangeException("Индекс больше длины массива!");
                if (i < 0)
                    throw new IndexOutOfRangeException("Индекс отрицателен!");
                else array[i] = value;
            }
        }

        public double GetNorm()
        {
            double abs = 0;
            for (int i = 0; i < array.Length; i++)
            {
                abs += Math.Pow(array[i], 2);
            }
            return abs = Math.Sqrt(abs);
        }
        public override string ToString()//ВОТ ТУТ ВОТ
        {
            string res = null;
            for (int i = 0; i < Length; i++) res += array[i] + " ";
            return Length + " | " + res;//ВОТ ДО СЮДА ВОТ
        }
    }
}
