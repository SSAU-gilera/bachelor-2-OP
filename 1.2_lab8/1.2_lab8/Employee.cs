using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab8
{
   public struct Employee
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
            return name + "\t" + vacancy + "\t\t" + salary.ToString() + "\t"+ "  " + hiredate[0].ToString() + "." + hiredate[1].ToString() + "." + hiredate[2].ToString();
        }
    }
}
