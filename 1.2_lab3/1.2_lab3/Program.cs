using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab3
{
    enum Vacancies { Manager, Boss, Clerk, Salesman };

    struct Employee
    {
        string name;
        Vacancies vacancy;
        int salary;
        public int[] hiredate;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public Vacancies Vacancy
        {
            get { return vacancy; }
            set { this.vacancy = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public int Day
        {
            get { return hiredate[0]; }
            set { hiredate[0] = value; }
        }
        public int Month
        {
            get { return hiredate[1]; }
            set { hiredate[1] = value; }
        }
        public int Year
        {
            get { return hiredate[2]; }
            set { hiredate[2] = value; }
        }
        public override string ToString()
        {
            return name + "\t" + vacancy + "\t" + "     " + salary.ToString() + "\t" + "   " + hiredate[0].ToString() + "." + hiredate[1].ToString() + "." + hiredate[2].ToString();
        }
    }
    public class ObjectComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            return (a is Employee _a && b is Employee _b) ? _a.Name.CompareTo(_b.Name) : throw new NotSupportedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3");
            Console.WriteLine("Выполнила: студентка группы 6113-020303D");
            Console.WriteLine("           Гижевская Валерия ");
            Console.Write("Введите количество сотрудников: ");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Employee[] massiv = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    massiv[i].hiredate = new int[3];
                    Console.Clear();
                    Console.WriteLine("Введите информацию о " + (i + 1) + " сотруднике");
                    Console.Write("Введите имя: ");
                    massiv[i].Name = Console.ReadLine();
                    Console.WriteLine(" 1-Manager, 2-Clerk, 3-Salesman, 4-Boss ");
                    Console.Write("Введите должность: ");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1": massiv[i].Vacancy = Vacancies.Manager; break;
                        case "2": massiv[i].Vacancy = Vacancies.Clerk; break;
                        case "3": massiv[i].Vacancy = Vacancies.Salesman; break;
                        case "4": massiv[i].Vacancy = Vacancies.Boss; break;
                    }
                    Console.Write("Введите заработную плату: ");
                    massiv[i].Salary = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.SetCursorPosition(0, 5);
                        Console.Write("Введите день приема на работу:     ");
                        Console.SetCursorPosition(31, 5);
                        massiv[i].Day = int.Parse(Console.ReadLine());
                    }
                    while (massiv[i].Day < 0 || massiv[i].Day > 31);
                    do
                    {
                        Console.SetCursorPosition(0, 6);
                        Console.Write("Введите месяц приема на работу:     ");
                        Console.SetCursorPosition(31, 6);
                        massiv[i].Month = int.Parse(Console.ReadLine());
                    }
                    while (massiv[i].Month < 0 || massiv[i].Month > 12);
                    do
                    {
                        Console.SetCursorPosition(0, 7);
                        Console.Write("Введите год приема на работу:       ");
                        Console.SetCursorPosition(31, 7);
                        massiv[i].Year = int.Parse(Console.ReadLine());
                    }
                    while (massiv[i].Year < 0 || massiv[i].Year > 9999);
                    i++;
                }
                while (i != n);
            }


            string h;
            do
            {
                Console.Clear();
                Console.WriteLine(" ______________________________________________________ ");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|~~~~~~~~~~~~~~~~ Лабораторная номер 3 ~~~~~~~~~~~~~~~~|");
                Console.WriteLine("|~~~~~~~~~~~~~ Студент: Гижевская Валерия ~~~~~~~~~~~~~|");
                Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~ Группа: 6113 ~~~~~~~~~~~~~~~~~~~~|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                   Меню программы:                    |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|            1 - Информация о сотрудниках              |");
                Console.WriteLine("|            2 - Менеджеры, по зарплате                |");
                Console.WriteLine("|            3 - Принятые после босса                  |");
                Console.WriteLine("|            4 - Выбрать должность                     |");
                Console.WriteLine("|            0 - Выход из программы                    |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|______________________________________________________|");
                Console.Write("\nВыберите необходимый пункт меню: ");
                h = Console.ReadLine();
                switch (h)
                {
                    case "1":
                        {

                            for (int i = 0; i < n; i++)
                            {

                                Console.WriteLine(massiv[i].ToString());
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        {
                            double midSalary = 0;
                            int s = 0;
                            for (int i = 0; i < n; i++)
                            {
                                if (massiv[i].Vacancy == Vacancies.Clerk)
                                {
                                    midSalary += massiv[i].Salary;
                                    s++;
                                }
                            }
                            if (s == 0)
                            {
                                Console.WriteLine("Клерков нет среди сотрудников");
                            }
                            else
                            {
                                midSalary = midSalary / s;
                                Employee[] massiv2 = (Employee[])massiv.Clone();
                                Array.Sort(massiv2, new ObjectComparer());
                                for (int i = 0; i < n; i++)
                                {
                                    if (massiv2[i].Vacancy == Vacancies.Manager && massiv2[i].Salary > midSalary)
                                    {
                                        Console.WriteLine(massiv2[i].ToString());
                                    }
                                }
                            }
                            Console.ReadKey();

                        }
                        break;
                    case "3":
                        {
                            int s = 0;
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Employee[] massiv2 = (Employee[])massiv.Clone();
                                    Array.Sort(massiv2, new ObjectComparer());
                                    if (massiv2[i].Vacancy == Vacancies.Boss)
                                    {
                                        s++;
                                        if (massiv2[j].Year > massiv2[i].Year) Console.WriteLine(massiv2[j].ToString());
                                        else
                                        {
                                            if (massiv2[j].Month > massiv2[i].Month) Console.WriteLine(massiv2[j].ToString());
                                            else
                                            {
                                                if (massiv2[j].Day > massiv2[i].Day) Console.WriteLine(massiv2[j].ToString());
                                            }
                                        }
                                    }
                                }
                            }
                            if (s == 0) Console.WriteLine("Босса нет среди сотрудников");
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        Console.WriteLine("1-Manager, 2-Clerk, 3-Salesman, 4-Boss");
                        {
                            for (int i = 0; i < n; i++)
                            {
                                string f = Console.ReadLine();
                                switch (f)
                                {
                                    case "1":
                                        {

                                            for (i = 0; i < n; i++)
                                            {
                                                if (massiv[i].Vacancy == Vacancies.Manager)
                                                    Console.WriteLine(massiv[i].ToString());
                                            }

                                        }
                                        break;
                                    case "2":


                                        {
                                            for (i = 0; i < n; i++)
                                            {
                                                if (massiv[i].Vacancy == Vacancies.Clerk)
                                                    Console.WriteLine(massiv[i].ToString());
                                            }
                                        }

                                        break;
                                    case "3":
                                        {
                                            for (i = 0; i < n; i++)
                                            {
                                                if (massiv[i].Vacancy == Vacancies.Salesman)
                                                    Console.WriteLine(massiv[i].ToString());
                                            }

                                        }
                                        break;
                                    case "4":


                                        {
                                            for (i = 0; i < n; i++)
                                            {
                                                if (massiv[i].Vacancy == Vacancies.Boss)
                                                    Console.WriteLine(massiv[i].ToString());
                                            }
                                        }

                                        break;
                                }

                            }
                            Console.ReadKey();
                        }
                        break;
                }
            }
            while (h != "0");
            Console.ReadLine();

        }

    }
}
