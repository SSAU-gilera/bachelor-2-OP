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
    public enum Vacancies { Manager, Boss, Clerk, Salesman };
    public partial class Form1 : Form
    {
        int n;//количество сотрудников
        int i = 0;
        Employee[] massiv;
        public Form1()
        {
            InitializeComponent();
        }

        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработать графический интерфейс пользователя, \nадекватно отражающий функциональность приложения. \nПриложение должно быть спроектировано в рамках \nархитектуры «Модель - Вид - Контроллер».");
        }

        private void Num_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(numericUpDown1.Value);
            massiv = new Employee[n];
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            
            massiv[i].hiredate = new int[3];
            massiv[i].Name = nametext.Text;
            string a = dolzhnosttext.Text;
            switch (a)
            {
                case "Manager": massiv[i].Vacancy = Vacancies.Manager; break;
                case "Clerk": massiv[i].Vacancy = Vacancies.Clerk; break;
                case "Salesman": massiv[i].Vacancy = Vacancies.Salesman; break;
                case "Boss": massiv[i].Vacancy = Vacancies.Boss; break;
            }
            massiv[i].Salary = int.Parse(textBox1.Text);
            //string data =Convert.ToString(dateTimePicker1.Value);
            //string[] dat = data.Split('.');
            massiv[i].Day = dateTimePicker1.Value.Day;
            massiv[i].Month = dateTimePicker1.Value.Month;
            massiv[i].Year = dateTimePicker1.Value.Year;
            //MessageBox.Show(Convert.ToString(massiv[i]));
            nametext.Text = "";
            for (int k = 0; k < 4; k++) dolzhnosttext.SetItemChecked(k, false);
            textBox1.Text = "";
            dateTimePicker1.Value = DateTime.UtcNow;//ставится текущая дата
            i++;
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            Task1 zad1 = new Task1(massiv);
            zad1.ShowDialog();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            Task2 zad2 = new Task2(massiv);
            zad2.ShowDialog();
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            Task3 zad3 = new Task3(massiv);
            zad3.ShowDialog();
        }

        private void Task4_Click(object sender, EventArgs e)
        {
            Task4 zad4 = new Task4(massiv);
            zad4.ShowDialog();
        }

        /*private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData ==Keys.Enter)
            {
                n = textBox2.Text;
            }
        }*/
    }
}
