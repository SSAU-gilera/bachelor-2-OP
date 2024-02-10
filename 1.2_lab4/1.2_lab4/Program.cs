using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab4
{
    delegate void Delegat();
    class Program
    {
        public static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1");
            Console.Write("Введите размер вектора: ");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы ввели не число. Пожалуйста, будьте внимательны.");
            }
            ArrayVector arr1 = new ArrayVector(n);
            Console.WriteLine("Вектор: ");
            for (int i = 0; i < arr1.array.Length; i++)
            {
                Console.SetCursorPosition(7 * i, 2);
                arr1[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Модуль вектора: " + arr1.GetNorm());
            //Console.WriteLine("Число координат вектора: " + arr1.Length);
            Console.WriteLine(arr1.ToString());//
            Console.ReadLine();
        }

        public static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2");
            Console.Write("Введите размер 1 массива: ");
            int k = 0;
            try
            {
                k = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            LinkedListVector list1 = new LinkedListVector(k);
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < k; i++)
            {
                double element = 0;
                Console.SetCursorPosition(7 * i, 2);
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                list1.Add(element);
            }
            Console.Write("Введите размер 2 массива: ");
            int h = 0;
            try
            {
                h = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            LinkedListVector list2 = new LinkedListVector(h);
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < h; i++)
            {
                double element = 0;
                Console.SetCursorPosition(7 * i, 6);
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                list2.Add(element);
            }
            Console.WriteLine("Модуль 1 вектора " + list1.GetNorm());
            Console.WriteLine("Модуль 2 вектора " + list2.GetNorm());
            //////////////////////////////////////////////////////////////////
            //Console.WriteLine("Число координат 1 вектора: " + list1.Length / 2);
            //Console.WriteLine("Число координат 2 вектора: " + list2.Length / 2);
            //Console.ReadLine();
            try
            {
                Console.WriteLine("Скалярное произведениее: " + Vectors.Scalar(list1, list2));
                // list3 = Vectors.Sum(list1, list2);
                // Console.WriteLine("Сумма: " + list3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Сумма и произведение не могут быть найдены");
            }
            Console.WriteLine("Число координат 1 вектора: " + list1.Length / 2);
            Console.WriteLine("Число координат 2 вектора: " + list2.Length / 2);
            Console.ReadLine();
        }

        public static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задание 3");
            Console.Write("Введите размер 1 вектора: ");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            ArrayVector v1 = new ArrayVector(n);
            Console.WriteLine("Вектор 1: ");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.SetCursorPosition(7 * i, 2);
                v1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Введите размер 2 вектора: ");
            int m = 0;
            try
            {
                m = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            ArrayVector v2 = new ArrayVector(m);
            Console.WriteLine("Вектор 2: ");
            for (int i = 0; i < v2.Length; i++)
            {
                Console.SetCursorPosition(7 * i, 6);
                v2[i] = Convert.ToDouble(Console.ReadLine());
            }
            try
            {
                ArrayVector v3 = new ArrayVector(v1.Length);
                v3 = Vectors.Sum(v1, v2);
                Console.WriteLine("Сумма векторов: ");
                for (int i = 0; i < v2.Length; i++)
                {
                    Console.SetCursorPosition(7 * i, 10);
                    Console.WriteLine(v3[i] + "\t");
                }

                Console.WriteLine("Скалярное произведение векторов: ");
                Console.WriteLine(Vectors.Scalar(v1, v2));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Сумма и скалярное произведение не могут быть найдены");
            }
            Console.WriteLine("Модуль 1 вектора: " + Vectors.GetNorm(v1));
            Console.WriteLine("Модуль 2 вектора: " + Vectors.GetNorm(v2));
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Delegat delegat = null;
            string s;
            do
            {
                Console.Clear();
                Console.WriteLine(" ______________________________________________________ ");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|~~~~~~~~~~~~~~~~ Лабораторная номер 4 ~~~~~~~~~~~~~~~~|");
                Console.WriteLine("|~~~~~~~~~~~~~ Студент: Гижевская Валерия ~~~~~~~~~~~~~|");
                Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~ Группа: 6113 ~~~~~~~~~~~~~~~~~~~~|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                   Меню программы:                    |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                 1 - ArrayVector                      |");
                Console.WriteLine("|                 2 - LinkedListVector                 |");
                Console.WriteLine("|                 3 - Vectors                          |");
                Console.WriteLine("|                 0 - Выход из программы               |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|______________________________________________________|");
                Console.Write("\nВыберите необходимый пункт меню: ");
                s = Console.ReadLine();
                switch (s)
                {
                    case "1": delegat += Task1; break;
                    case "2": delegat += Task2; break;
                    case "3": delegat += Task3; break;
                }
            }
            while (s != "0");
            delegat();
            Console.ReadKey();
        }


    }
}
