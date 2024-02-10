using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1._2_lab6
{
    class Vectors
    {
        static public IVector Sum(IVector v1, IVector v2)
        {
            int n = v1.Length;
            IVector v0 = new ArrayVector(n);
            for (int i = 0; i < n; i++)
            {
                v0[i] = v1[i] + v2[i];
            }
            return v0;
        }
        static public double Scalar(IVector v1, IVector v2)
        {
            int n = v1.Length;
            double p = 0;
            for (int i = 0; i < n; i++)
            {
                p += v1[i] * v2[i];
            }
            return p;
        }
        static public double GetNorm(IVector v1)
        {
            int n = v1.Length;
            double p = 0;
            for (int i = 0; i < n; i++)
            {
                p = p + Math.Pow(v1[i], 2);
            }
            return Math.Sqrt(p);
        }
        public static void OutputVector(IVector[] v, Stream fileOut)
        {
            BinaryWriter writer = new BinaryWriter(fileOut);
            for (int i = 0; i < v.Length; i++)
            {
                writer.Write((byte)v[i].Length);
                for (int j = 0; j < v[i].Length; j++)
                {
                    writer.Write((byte)v[i][j]);
                }
            }
        }
        public static IVector[] InputVector(Stream fileIn)
        {
            double i;
            int a, size = 0;
            BinaryReader reader = new BinaryReader(fileIn);
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                a = reader.ReadByte();
                for (int j = 0; j < a; j++) { i = reader.ReadByte(); }
                size++;
            }
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            IVector[] v = new IVector[size];
            for (int k = 0; k < size; k++)
            {
                IVector v2 = new ArrayVector((int)fileIn.ReadByte());
                for (int j = 0; j < v2.Length; j++)
                {
                    v2[j] = reader.ReadByte();
                }
                v[k] = v2;
            }
            return v;
        }
        public static void WriteVector(IVector[] v, TextWriter fileOut)
        {
            for (int i = 0; i < v.Length; i++)
            {
                fileOut.Write(v[i].Length + " ");
                fileOut.WriteLine(v[i]);
            }
        }
        public static IVector[] ReadVector(TextReader fileIn)
        {
            string s;
            List<IVector> list = new List<IVector>();
            while ((s = fileIn.ReadLine()) != null)
            {
                string[] vector = s.Split();
                IVector v2 = new ArrayVector(int.Parse(vector[0]));
                for (int i = 1; i < v2.Length + 1; i++)
                {
                    v2[i - 1] = double.Parse(vector[i]);
                }
                list.Add(v2);
            }
            var v = list.ToArray();
            return v;
        }
    }
}
