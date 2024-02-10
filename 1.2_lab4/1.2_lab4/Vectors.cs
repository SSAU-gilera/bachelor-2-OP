using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab4
{
    class Vectors
    {
        public static ArrayVector Sum(IVector v1, IVector v2)//МЕНЯЕМ ArrayVector НА IVector
        {
            ArrayVector v3 = new ArrayVector(v1.Length);
            if (v1.Length != v2.Length)
            {
                throw new FormatException("Размеры не совпадают.");
            }
            for (int i = 0; i < v1.Length; i++)
            {
                v3[i] = v1[i] + v2[i];//ТУТ УБРАЛИ .array
            }
            return v3;
        }
        public static double Scalar(IVector v1, IVector v2)//ТУТ ТОЖЕ ПОМЕНЯЛИ
        {
            double scalar = 0;
            if (v1.Length != v2.Length)
            {
                throw new FormatException("Размеры не совпадают.");
            }
            for (int i = 0; i < v1.Length; i++)
            {
                scalar += v1[i] * v2[i];//ТУТ ТОЖЕ УБРАЛИ ТОЧЕЧКУ И ЭРРЭЙ
            }
            return scalar;
        }

        public static double GetNorm(IVector v1)//И ТУТ ПОМЕНЯЛИ
        {
            double abs = 0;
            for (int i = 0; i < v1.Length; i++)//И ТУТ УБРАЛИ
            {
                abs += Math.Pow(v1[i], 2);//И ТУТ УБРАЛИ
            }
            abs = Math.Sqrt(abs);
            return abs;
        }
    }
}
