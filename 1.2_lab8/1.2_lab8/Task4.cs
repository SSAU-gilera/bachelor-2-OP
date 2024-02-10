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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        Employee[] massiv;////////////////////////////////////////////////
        int n;////////////////////////////////////////////////////////////

        public Task4(Employee[] mas)///////////////////////////////////////
        {
            massiv = mas;//////////////////////////////////////////////////
            n = massiv.Length;/////////////////////////////////////////////
            InitializeComponent();/////////////////////////////////////////
        }
        private void Task1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < n; i++)
            {
                if (massiv[i].Vacancy == Vacancies.Manager)
                    textBox1.Text += massiv[i].ToString() + "\r\n";
            }
        }


        private void Task2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < n; i++)
            {
                if (massiv[i].Vacancy == Vacancies.Clerk)
                    textBox1.Text += massiv[i].ToString() + "\r\n";
            }
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < n; i++)
            {
                if (massiv[i].Vacancy == Vacancies.Salesman)
                    textBox1.Text += massiv[i].ToString() + "\r\n";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < n; i++)
            {
                if (massiv[i].Vacancy == Vacancies.Boss)
                textBox1.Text += massiv[i].ToString() + "\r\n";
            }
        }
    }
}
