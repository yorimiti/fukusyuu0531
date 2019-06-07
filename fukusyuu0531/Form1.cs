using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyuu0531
{
    public partial class Form1 : Form
    {int vx=-10;
    int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = MousePosition.X + "," + MousePosition.Y;
            Point p = PointToClient(MousePosition);

            label2.Left = p.X - label2.Width / 2;
            label2.Top = p.Y - label2.Width / 2;

            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0) 
            {
                vx = -vx;
            }
            if (label1.Top<10)
            {
                vy = -vy;
            }
            if (label1.Left>500)
            {
                vx = -vx;
            }
            if (label1.Top>400)
            {
                vy = -vy;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
