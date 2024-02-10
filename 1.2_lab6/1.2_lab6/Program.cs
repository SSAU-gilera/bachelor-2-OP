using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _1._2_lab6
{
    class Program
    {
        static IVector[] AddVectors()
        {
            Console.Clear();
            Console.Write("Введите число векторов: ");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size <= 0)
            {
                Console.WriteLine("Ошибка. Автоматически число векторов = 3");
                size = 3;
            }
            IVector[] mas = new IVector[size];
            for (int i = 0; i < size; i++)
            {
                Console.Clear();
                Console.Write("Размер {0} вектора: ", i + 1);
                try
                {
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    if (n1 <= 0) { AddVectors(); }
                    Console.WriteLine("\nКакой вектор создадим?");
                    Console.WriteLine("         1 - ArrayVector");
                    Console.WriteLine("         2 - LinkedListVecto");
                    Console.Write("> ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        mas[i] = new ArrayVector(n1);
                        Console.WriteLine("Введите значения вектора:");
                        int l = Console.CursorLeft;
                        int h = Console.CursorTop;
                        for (int j = 0; j < n1; j++)
                        {
                            Console.SetCursorPosition(l + 4 * j, h);
                            mas[i][j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    else if (choice == 2)
                    {
                        mas[i] = new LinkedListVector(n1);
                        int j = 0;
                        Console.WriteLine("Введите значения вектора:");
                        int l = Console.CursorLeft;
                        int h = Console.CursorTop;
                        while (j < n1)
                        {
                            try
                            {
                                Console.SetCursorPosition(l + 4 * j, h);
                                mas[i][j] = double.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            j++;
                        }
                    }
                    else AddVectors();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода! Нажмите enter и попробуйте еще раз");
                    Console.ReadLine();
                    AddVectors();
                }
            }
            return mas;
        }
        static void WriteByte(IVector[] mas)
        {
            FileStream test = new FileStream("test.dat", FileMode.Append, FileAccess.Write);
            Vectors.OutputVector(mas, test);
            test.Close();
        }
        static void ReadByte()
        {
            FileStream test = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.Read);
            IVector[] arr = Vectors.InputVector(test);
            Console.WriteLine("Считывание с байтового потока: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            test.Close();
        }
        static void WriteText(IVector[] mas)
        {
            StreamWriter test = new StreamWriter("test.txt");
            Vectors.WriteVector(mas, test);
            test.Close();
        }
        static void ReadText()
        {
            StreamReader test = new StreamReader("test.txt");
            IVector[] arr = Vectors.ReadVector(test);
            Console.WriteLine("Считывание с символьного потока: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            test.Close();
            Console.ReadLine();
        }
        static void WriteSerializable(IVector[] mas)
        {
            if (File.Exists("test2.txt")) File.Delete("test2.txt");
            FileStream test = new FileStream("test2.txt", FileMode.Append, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(test, mas);
            test.Close();
        }
        static void ReadSerializable()
        {
            FileStream test = new FileStream("test2.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bin = new BinaryFormatter();
            IVector[] v = (IVector[])bin.Deserialize(test);
            Console.WriteLine("Считывание объекта с потока: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.ReadLine();
            test.Close();
        }
        static void Task()
        {
            //Console.SetWindowSize(100, 50);
            int N = 1, size = 0;
            IVector[] mas = null;
            try
            {
                do
                {
                    if (mas != null) size = mas.Length;
                    Console.Clear();
                    Console.WriteLine(" ______________________________________________________ ");
                    Console.WriteLine("|                                                      |");
                    Console.WriteLine("|~~~~~~~~~~~~~~~~ Лабораторная номер 6 ~~~~~~~~~~~~~~~~|");
                    Console.WriteLine("|~~~~~~~~~~~~~ Студент: Гижевская Валерия ~~~~~~~~~~~~~|");
                    Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~ Группа: 6113 ~~~~~~~~~~~~~~~~~~~~|");
                    Console.WriteLine("|                                                      |");
                    Console.WriteLine("|                   Меню программы:                    |");
                    Console.WriteLine("|                                                      |");
                    Console.WriteLine("|           1 - Создание массива объектов              |");
                    Console.WriteLine("|           2 - Запись вектора в байтовый поток        |");
                    Console.WriteLine("|           3 - Чтение вектора из байтового потока     |");
                    Console.WriteLine("|           4 - Запись вектора в символьный поток      |");
                    Console.WriteLine("|           5 - Чтение вектора из символьного потока   |");
                    Console.WriteLine("|           6 - Запись объекта в поток                 |");
                    Console.WriteLine("|           7 - Считывание объекта из потока           |");
                    Console.WriteLine("|           8 - Удалить все файлы                      |");
                    Console.WriteLine("|           0 - Выход из программы                     |");
                    Console.WriteLine("|                                                      |");
                    Console.WriteLine("|______________________________________________________|");
                    Console.Write("\nВыберите необходимый пункт меню: ");
                    try
                    {
                        N = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка ввода! Нажмите enter и попробуйте еще раз");
                        Console.ReadLine();
                        Task();
                    }
                    switch (N)
                    {
                        case 1:
                            {
                                mas = null;
                                mas = AddVectors();
                            }
                            break;
                        case 2:
                            {
                                if (mas != null) WriteByte(mas);
                            }
                            break;
                        case 3:
                            {
                                ReadByte();
                            }
                            break;
                        case 4:
                            {
                                if (mas != null) WriteText(mas);
                            }
                            break;
                        case 5:
                            {
                                ReadText();
                            }
                            break;
                        case 6:
                            {
                                if (mas != null) WriteSerializable(mas);
                            }
                            break;
                        case 7:
                            {
                                Console.WriteLine("Исходный объект: ");
                                for (int i = 0; i < mas.Length; i++)
                                {
                                    Console.WriteLine(mas[i]);
                                }
                                ReadSerializable();
                            }
                            break;
                        case 8:
                            {
                                File.Delete("test.txt");
                                File.Delete("test2.txt");
                                File.Delete("test.dat");
                            }
                            break;
                    }
                } while (N != 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода! Нажмите enter и попробуйте еще раз");
                Console.ReadLine();
                Task();
            }
        }
        public static void Main(string[] args)
        {
            Task();
        }
    }
}
