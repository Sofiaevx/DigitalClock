using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int secondA = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAll(object sender, EventArgs e)
        {
            Button btnall = (Button)sender;
            btnall.BackColor = System.Drawing.Color.Tomato;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            string secA =(DateTime.Now.ToString("ss"));
            secondA = Convert.ToInt32(secA.Substring(secA.Length -1));
          
            choice(secondA);
        }
        private void choice(int btnclock)
        {
           
           if (btnclock == 1)
            {
                A1.BackColor = System.Drawing.Color.Transparent;
                A4.BackColor = System.Drawing.Color.Transparent;
                A5.BackColor = System.Drawing.Color.Transparent;
                A6.BackColor = System.Drawing.Color.Transparent;

                A2.PerformClick();
                A3.PerformClick();

            }
            else if(btnclock == 2)
            {
                A3.BackColor = System.Drawing.Color.Transparent;

                A1.PerformClick();
                A2.PerformClick();
                A7.PerformClick();
                A5.PerformClick();
                A4.PerformClick();
            }
            else if (btnclock == 3)
            {
                A5.BackColor = System.Drawing.Color.Transparent;

                A1.PerformClick();
                A2.PerformClick();
                A3.PerformClick();
                A4.PerformClick();
                A7.PerformClick();
            }
            else if (btnclock == 4)
            {
                A1.BackColor = System.Drawing.Color.Transparent;
                A4.BackColor = System.Drawing.Color.Transparent;

                A2.PerformClick();
                A3.PerformClick();
                A6.PerformClick();
                A7.PerformClick();
            }
            else if (btnclock == 5)
            {
                A2.BackColor = System.Drawing.Color.Transparent;

                A1.PerformClick();
                A3.PerformClick();
                A4.PerformClick();
                A6.PerformClick();
                A7.PerformClick();
            }
            else if (btnclock == 6)
            {

                A1.PerformClick();
                A3.PerformClick();
                A4.PerformClick();
                A5.PerformClick();
                A6.PerformClick();
                A7.PerformClick();
            }
            else if (btnclock == 7)
            {
                A4.BackColor = System.Drawing.Color.Transparent;
                A5.BackColor = System.Drawing.Color.Transparent;
                A6.BackColor = System.Drawing.Color.Transparent;
                A7.BackColor = System.Drawing.Color.Transparent;

                A1.PerformClick();
                A2.PerformClick();
                A3.PerformClick();
            }
            else if (btnclock == 8)
            {
                A1.PerformClick();
                A2.PerformClick();
                A3.PerformClick();
                A4.PerformClick();
                A5.PerformClick();
                A6.PerformClick();
                A7.PerformClick();
            }
            else if (btnclock == 9)
            {
                A5.BackColor = System.Drawing.Color.Transparent;

                A1.PerformClick();
                A2.PerformClick();
                A3.PerformClick();
                A4.PerformClick();
                A6.PerformClick();
                A7.PerformClick();
            }
            else
            {
                A7.BackColor = System.Drawing.Color.Transparent;
                A1.PerformClick();
                A2.PerformClick();
                A3.PerformClick();
                A4.PerformClick();
                A5.PerformClick();
                A6.PerformClick();
            }

        }
        }
}
