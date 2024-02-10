using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_lab8
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        Employee[] massiv;////////////////////////////////////////////////
        int n;////////////////////////////////////////////////////////////

        public Task2(Employee[] mas)///////////////////////////////////////
        {
            massiv = mas;//////////////////////////////////////////////////
            n = massiv.Length;/////////////////////////////////////////////
            InitializeComponent();/////////////////////////////////////////
        }


        private void Task2_Load(object sender, EventArgs e)
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
                textBox1.Text = "Клерков нет среди сотрудников";
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
                        textBox1.Text += massiv2[i].ToString() + "\r\n";
                    }
                }
            }
        }
    }
}
