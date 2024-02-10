using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab5
{
    class ArrayVector : IVector, IComparable, ICloneable
    {
        double[] arr;
        public ArrayVector(int n)
        {
            Length = n;
            arr = new double[n];
        }
        public ArrayVector()
        {
            Length = 5;
            arr = new double[5];
        }
        public int Length
        {
            get { return arr.Length; }
            set { }
        }
        public double this[int ndx]
        {
            get
            {
                if (ndx >= arr.Length)
                    throw new IndexOutOfRangeException("Индекс больше длины массива!");
                if (ndx < 0)
                    throw new IndexOutOfRangeException("Индекс не может быть отрицательным!");
                return arr[ndx];
            }
            set
            {
                if (ndx > Length) throw new IndexOutOfRangeException();
                if (ndx >= arr.Length)
                    throw new IndexOutOfRangeException("Индекс больше длины массива!");
                if (ndx < 0)
                    throw new IndexOutOfRangeException("Индекс не может быть отрицательным!");
                arr[ndx] = value;
            }
        }
        public double GetNorm()
        {
            double norm = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                norm += Math.Pow(arr[i], 2);
            }
            return Math.Sqrt(norm);
        }
        public override string ToString()
        {
            string result = arr.Length + " | ";
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                result += " ";
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
                    while (i < Length && mo[i] == arr[i])
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
            ArrayVector array = (ArrayVector)this.MemberwiseClone();
            array.arr = (double[])arr.Clone();
            return array;
        }
    }
}
