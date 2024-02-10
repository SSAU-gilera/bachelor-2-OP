using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab5
{
    class Vectors
    {
        public static IVector Sum(IVector arr1, IVector arr2)
        {
            IVector result;
            if (arr1 is ArrayVector)
            {
                result = new ArrayVector(arr1.Length);
            }
            else
            {
                result = new LinkedListVector(arr1.Length);
            }
            if (arr1.Length != arr2.Length)
            {
                throw new FormatException("Размеры векторов не совпадают!");
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }
        public static double Scalar(IVector arr1, IVector arr2)
        {
            double result = 0;
            if (arr1.Length != arr2.Length)
            {
                throw new FormatException("Размеры векторов не совпадают!");
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                result += arr1[i] * arr2[i];
            }
            return result;
        }
        public static IVector NumberMul(IVector arr, double numb)
        {
            IVector result;
            if (arr is ArrayVector)
            {
                result = new ArrayVector(arr.Length);
            }
            else
            {
                result = new LinkedListVector(arr.Length);
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr[i] * numb;
            }
            return result;
        }
        public static double GetNorm(IVector arr)
        {
            return arr.GetNorm();
        }

    }
}
