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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }
        Employee[] massiv;////////////////////////////////////////////////
        int n;////////////////////////////////////////////////////////////

        public Task3(Employee[] mas)///////////////////////////////////////
        {
            massiv = mas;//////////////////////////////////////////////////
            n = massiv.Length;/////////////////////////////////////////////
            InitializeComponent();/////////////////////////////////////////
        }


        private void Task3_Load(object sender, EventArgs e)
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
                        if (massiv2[j].Year > massiv2[i].Year) textBox1.Text += massiv2[j].ToString() + "\r\n";
                        else
                        {
                            if (massiv2[j].Month > massiv2[i].Month) textBox1.Text += massiv2[j].ToString() + "\r\n";
                            else
                            {
                                if (massiv2[j].Day > massiv2[i].Day) textBox1.Text += massiv2[j].ToString() + "\r\n";
                            }
                        }
                    }
                }
            }
            if (s == 0) textBox1.Text += "Босса нет среди сотрудников";
        }
    }
}
