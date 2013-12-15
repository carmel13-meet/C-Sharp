using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _27._11._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics dc = this.CreateGraphics();
            this.Show();
            Pen BluePen = new Pen(Color.Black, 3);
            int place = 0;
            int place2 = 0;
            for (int i = 1; i <= 5; i++)
            {
                    dc.DrawEllipse(BluePen, place, 0, 50, 50);
                    place += 50;
            }
            for (int i = 1; i <= 5; i++)
            {
                dc.DrawEllipse(BluePen, place2, 50, 50, 50);
                place2 += 50;
            }
            //for (int i = 0; i <= 50; i++)
            //{
            //    Square c = new Square(i, 0, 50, "red");
            //    this.Show();
            //    dc.DrawRectangle(BluePen, i+=50, 0, 50, 50);
            //}

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
