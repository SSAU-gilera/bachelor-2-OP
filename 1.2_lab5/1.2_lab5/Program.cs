using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            do
            {
                Console.Clear();
                Console.WriteLine("Лабораторная работа 4\nВыполнила:Гижевская Лера\nГруппа: 6113-020302D");
                Console.WriteLine("==========================================================");
                Console.WriteLine("|| Выберите:                                            ||");
                Console.WriteLine("==========================================================");
                Console.WriteLine("|| 0 || Выход                                           ||");
                Console.WriteLine("|| 1 || Задание 1 - ArrayVector                         ||");
                Console.WriteLine("|| 2 || Задание 2 - LinkedListVector                    ||");
                Console.WriteLine("|| 3 || Задание 3 - CompareTo, IComparer                ||");
                Console.WriteLine("|| 4 || Задание 4 - Clone                               ||");
                Console.WriteLine("|| 5 || Задание 5 - Equals                              ||");
                Console.WriteLine("==========================================================");
                s = Console.ReadLine();
                switch (s)
                {
                    case "0": Console.Clear(); return;
                    case "1": Console.Clear(); Task1(); break;
                    case "2": Console.Clear(); Task2(); break;
                    case "3": Console.Clear(); Task3(); break;
                    case "4": Console.Clear(); Task4(); break;
                    case "5": Console.Clear(); Task5(); break;

                    default: Console.WriteLine("Такого пункта нет меню"); break;
                }
            }
            while (s != "0");
        }
        public static void Task5()
        {
            IVector vect1;
            Console.Clear();
            List<IVector> list = new List<IVector>();
            try
            {
                Console.WriteLine("Сколько векторов создадим?");
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    Console.Write("Длина " + (i + 1) + " вектора: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Какой вектор создадим?");
                    Console.WriteLine("1 - ArrayVector");
                    Console.WriteLine("2 - LinkedListVector");
                    int choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            vect1 = new ArrayVector(l);
                            break;
                        default:
                            vect1 = new LinkedListVector(l);
                            break;
                    }
                    InputElements(vect1);
                    list.Add(vect1);
                    if (i > 0 && vect1.Equals(list[i - 1]))
                    {
                        Console.WriteLine("Векторы равны");
                    }
                    // Console.WriteLine("Векторы равны");
                }
                Console.ReadLine();

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Мы создали этот вектор ArrayVector.");
                vect1 = new ArrayVector();
                Console.ReadLine();
            }
        }
        public static void Task1()
        {
            Console.Clear();
            Console.Write("Введите размерность первого вектора: ");
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            ArrayVector arr1 = new ArrayVector(size);
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < arr1.Length; i++)
            {
                double element = 0;
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                arr1[i] = element;
            }
            Console.Write("Введите размерность второго вектора: ");
            try
            {
                size = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            ArrayVector arr2 = new ArrayVector(size);
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < arr2.Length; i++)
            {
                double element = 0;
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                arr2[i] = element;
            }
            try
            {
                Console.WriteLine("Сумма векторов: ");
                Console.WriteLine(Vectors.Sum(arr1, arr2));
                Console.WriteLine("Скалярное произведение векторов: ");
                Console.WriteLine(Vectors.Scalar(arr1, arr2));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Сумма и произведение не могут быть найдены");
            }
            Console.Write("Введите число, на которое умножим первый вектор: ");
            double elem = 0;
            try
            {
                elem = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(Vectors.NumberMul(arr1, elem));
            Console.WriteLine("Модуль второго вектора: ");
            Console.WriteLine(Vectors.GetNorm(arr2));
            Console.ReadLine();
        }
        public static void Task2()
        {
            Console.Clear();
            Console.Write("Введите размерность первого вектора: ");
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            LinkedListVector larr = new LinkedListVector(size);
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < larr.Length; i++)
            {
                double element = 0;
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                larr[i] = element;
            }
            Console.Write("Введите размерность второго вектора: ");
            try
            {
                size = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            LinkedListVector larr2 = new LinkedListVector(size);
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < larr2.Length; i++)
            {
                double element = 0;
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                larr2[i] = element;
            }
            //Console.WriteLine("Вектор: "+larr);
            Console.WriteLine("Модуль первого вектора " + larr.GetNorm());
            Console.WriteLine("Модуль второго вектора " + larr2.GetNorm());
            try
            {
                Console.WriteLine("Сумма векторов " + Vectors.Sum(larr, larr2));
                Console.WriteLine("Скалярное произведение векторов " + Vectors.Scalar(larr, larr2));

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + "Сумму и скалярное произведение найти не удалось!");
            }
            Console.Write("На какое число умножим первый вектор? ");
            double num = 1;
            try
            {
                num = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Результат: " + Vectors.NumberMul(larr, num));
            Console.ReadLine();
        }
        public static void Task3()
        {
            IVector vect1;
            Console.Clear();
            List<IVector> list = new List<IVector>();
            try
            {
                Console.WriteLine("Сколько векторов создадим?");
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    Console.Write("Длина " + (i + 1) + " вектора: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Какой вектор создадим?");
                    Console.WriteLine("1 - ArrayVector");
                    Console.WriteLine("2 - LinkedListVector");
                    int choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            vect1 = new ArrayVector(l);
                            break;
                        default:
                            vect1 = new LinkedListVector(l);
                            break;
                    }
                    InputElements(vect1);
                    list.Add(vect1);
                    if (i > 0 && vect1.Equals(list[i - 1]))
                    {
                        Console.WriteLine("Вектор равен предыдущему");
                    }
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Мы создали этот вектор ArrayVector.");
                vect1 = new ArrayVector();
                Console.ReadLine();
            }
            Console.WriteLine("Векторы по возрастанию количества координат:");
            list.Sort();
            foreach (IVector i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Минимальная длина:");
            int j = 0;
            while (j >= 0 && list[j].Length == list[0].Length)
            {
                Console.WriteLine(list[j]);
                j++;
            }
            if (list[0].Length != list[list.Count - 1].Length)
            {
                Console.WriteLine("Максимальная длина");
                j = list.Count - 1;
                while (j < list.Count && list[j].Length == list[list.Count - 1].Length)
                {
                    Console.WriteLine(list[j]);
                    j--;
                }
            }

            Console.WriteLine("Векторы по возрастанию модулей");
            SortByNorm sbn = new SortByNorm();
            list.Sort(sbn);
            foreach (IVector i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static void Task4()
        {
            Console.Clear();
            IVector vector;
            try
            {
                Console.Write("Длина вектора: ");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Какой вектор создадим: ");
                Console.WriteLine("1 - ArrayVector");
                Console.WriteLine("2 - LinkedListVector");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        vector = new ArrayVector(l);
                        break;
                    default:
                        vector = new LinkedListVector(l);
                        break;
                }
                InputElements(vector);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Мы создали вектор ArrayVector.");
                vector = new ArrayVector();
                Console.ReadLine();
            }
            if (vector is ArrayVector)
            {
                ArrayVector vect1 = vector as ArrayVector;
                ArrayVector vect2 = (ArrayVector)vect1.Clone();
                Console.WriteLine("Какой элемент хотите изменить в векторе?");
                int g = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите новое значение: ");
                vect1[g - 1] = double.Parse(Console.ReadLine());
                Console.WriteLine("Исходный измененный: ");
                Console.WriteLine(vect1);
                Console.WriteLine("Клон: ");
                Console.WriteLine(vect2);
            }
            else
            {
                LinkedListVector vect1 = vector as LinkedListVector;
                LinkedListVector vect2 = (LinkedListVector)vect1.Clone();
                Console.WriteLine("Какой элемент хотите изменить в векторе?");
                int g = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите новое значение: ");
                vect1[g - 1] = double.Parse(Console.ReadLine());
                Console.WriteLine("Исходный измененный: ");
                Console.WriteLine(vect1);
                Console.WriteLine("Клон: ");
                Console.WriteLine(vect2);
            }
            Console.ReadLine();
        }
        static void InputElements(IVector vector)
        {
            Console.WriteLine("Ввод значений:");
            for (int i = 0; i < vector.Length; i++)
            {
                double element = 0;
                try
                {
                    element = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                vector[i] = element;
            }
        }
    }
}
