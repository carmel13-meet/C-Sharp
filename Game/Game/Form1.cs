using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private Rectangle Goal = new Rectangle(350, 600, 50, 50);
        private Rectangle Player = new Rectangle(350, 0, 50, 50);
        private Rectangle Enemy1 = new Rectangle(0, 150, 75, 75);
        private Rectangle Enemy2 = new Rectangle(599, 350, 75, 75);

        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new Size(750, 750);
            this.MinimumSize = new Size(750, 750);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, Goal);
            e.Graphics.DrawRectangle(Pens.Blue, Player);
            e.Graphics.DrawRectangle(Pens.Red, Enemy1);
            e.Graphics.DrawRectangle(Pens.Red, Enemy2);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int PlayerX = Player.Location.X;
            int PlayerY = Player.Location.Y;

            switch (e.KeyData)
            {
                case Keys.Up:
                    {
                        Player.Location = new Point(PlayerX += 0, PlayerY -= 20);
                        this.Refresh();
                        break;
                    }
                case Keys.Down:
                    {
                        Player.Location = new Point(PlayerX += 0, PlayerY += 20);
                        this.Refresh();
                        break;
                    }
                case Keys.Left:
                    {
                        Player.Location = new Point(PlayerX -= 20, PlayerY += 0);
                        this.Refresh();
                        break;
                    }
                case Keys.Right:
                    {
                        Player.Location = new Point(PlayerX += 20, PlayerY += 0);
                        this.Refresh();
                        break;
                    }
            }
            HitDetect();

            if (Player.Location.X > 650)
            {
                Player.Location = new Point(PlayerX -= 20, PlayerY += 0); 
            }

            if (Player.Location.X < 0)
            {
                Player.Location = new Point(PlayerX += 20, PlayerY += 0);
            }

            if (Player.Location.Y > 590)
            {
                Player.Location = new Point(PlayerX += 0, PlayerY -= 20);
            }

            if (Player.Location.Y < 1)
            {
                Player.Location = new Point(PlayerX += 0, PlayerY += 20);
            }
        }
        public void HitDetect()
        {
            if (Player.IntersectsWith(Goal))
            {
                MessageBox.Show("You Win!");
            }

            int PlayerX = Player.Location.X;
            int PlayerY = Player.Location.Y;
            if (Enemy1.IntersectsWith(Player))
            {
                Player.Location = new Point(PlayerX = 350, PlayerY = 0);
                MessageBox.Show("You Lose!");
            }

            if (Enemy2.IntersectsWith(Player))
            {
                Player.Location = new Point(PlayerX = 350, PlayerY = 0);
                MessageBox.Show("You Lose!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int EX1 = Enemy1.Location.X;
            int EY1 = Enemy1.Location.Y;
            
            Random randNumber = new Random();
            int number = randNumber.Next(251);
                    
            if (Enemy1.Location.X > 600)
            {
                
                //Enemy1.Location = new Point(EX1 = 0, EY1 = 150);
                Enemy1.Location = new Point(EX1 = 0, EY1 = number);

            }

            Enemy1.Location = new Point(EX1 += 30, EY1 += 0);
            this.Refresh();

            int EX2 = Enemy2.Location.X;
            int EY2 = Enemy2.Location.Y;

            if (Enemy2.Location.X < 0)
            {
                number = randNumber.Next(251);
                Enemy2.Location = new Point(EX2 = 599, EY2 = 450-number);
            }

            Enemy2.Location = new Point(EX2 -= 30, EY2 += 0);
            this.Refresh();
        }
    }
}
