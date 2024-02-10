using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        int ballX = 10;
        int ballY = 10;
        int speedX = 5;
        int speedY = 5;
        int ballSize = 50;
        Graphics g;
        int platformSpeed;
        int platSpeedL = -15;
        int platSpeedR = 15;
        int platformX = 349;
        int platformY = 457;
        private void Game_Load(object sender, EventArgs e)
        {
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //ball.Left = ballX;
            //ball.Top = ballY;
            ballX += speedX;
            ballY += speedY;
            if (ballX <= 0 || ballX + ballSize >= this.ClientSize.Width) speedX = -speedX;
            if (ballY <= 0 || ballY + ballSize >= this.ClientSize.Height) speedY = -speedY;
            /*do
            {
                timer1.Interval -= 1;
            }
            while (timer1.Interval > 5);*/

            //platform.Left = platformX;
            //platform.Right = platformY;
            //if (platform.Left <= 0 || platform.Left + 160 >= this.ClientSize.Width) platform.Left += 0;
            

            Invalidate();

            //this.Refresh();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(this.BackColor);
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(Brushes.MistyRose, new Rectangle(ballX, ballY, ballSize, ballSize));

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) platformSpeed = platSpeedL;
            if (e.KeyCode == Keys.Right) platformSpeed = platSpeedR;
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) platformSpeed = 0;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (platform.Left <= 0 || platform.Left + 160 > this.ClientSize.Width) platform.Left += 0;//timer2.Stop();
            else platform.Left += platformSpeed;
            /*if (platform.Left < 0) platform.Left = 1;
            else if (platform.Left + 160 > this.ClientSize.Width) platform.Left = ClientSize.Width - 160;
            else platform.Left += platformSpeed;*/
        }
    }
}
