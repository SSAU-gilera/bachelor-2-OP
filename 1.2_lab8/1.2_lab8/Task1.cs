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
    public partial class Task1 : Form
    {

        /// </summary>
        public Task1()
        {
            InitializeComponent();
        }

        Employee[] massiv;////////////////////////////////////////////////
        int n;////////////////////////////////////////////////////////////

        public Task1(Employee[] mas)///////////////////////////////////////
        {
            massiv = mas;//////////////////////////////////////////////////
            n = massiv.Length;/////////////////////////////////////////////
            InitializeComponent();/////////////////////////////////////////
        }


        private void Task1_Load(object sender, EventArgs e)
        {
            zadanie1.Text += "\r\n";
            for (int i = 0; i < n; i++)
            {
                zadanie1.Text += Convert.ToString("\r\n" + massiv[i]);
            }
        }

    }
}
