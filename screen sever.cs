using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Random R = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label1.Left -= 5;
            if (label1.Left < 0)
            {
                label1.Left = this.ClientSize.Width;
                label1.Top = R.Next(this.Height - label1.Height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int D = R.Next(this.Height);
            int X = R.Next(this.Width - D);
            int Y = R.Next(this.Height-D);
            Bitmap bg = new Bitmap(this.Width,this.Height);
            //新增加修改圓的填充顏色
            Color C = Color.FromArgb(R.Next(256), R.Next(256),R.Next(256));
            SolidBrush B=new SolidBrush(C);
            Graphics g = Graphics.FromImage(bg);
            g.FillEllipse(B,X,Y,D,D);
            //新增滑鼠互動的部份
            g.DrawLine(Pens.Black, 0, mmy, this.Width, mmy);
            g.DrawLine(Pens.Black, mmx, 0, mmx, this.Height);
            this.BackgroundImage = bg;
        }
        int mmx, mmy;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mmx = e.X;
            mmy = e.Y;
        }
        int curP = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            curP += 1;
            if (curP > 8) { curP = 1; }
            switch(curP)
            {
                case 1:
                    this.BackgroundImage=Properties.Resources.P1;
                    break;
                case 2:
                    this.BackgroundImage=Properties.Resources.P2;
                    break;
                case 3:
                    this.BackgroundImage=Properties.Resources.P3;
                    break;
                case 4:
                    this.BackgroundImage=Properties.Resources.P4;
                    break;
                case 5:
                    this.BackgroundImage=Properties.Resources.P5;
                    break;
                case 6:
                    this.BackgroundImage=Properties.Resources.P6;
                    break;
                case 7:
                    this.BackgroundImage=Properties.Resources.P7;
                    break;
                case 8:
                    this.BackgroundImage=Properties.Resources.P8;
                    break;
            }
         
            
        }
    }
}
