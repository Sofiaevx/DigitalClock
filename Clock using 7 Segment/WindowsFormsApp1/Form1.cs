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
        int secondB = 0;
        int minuteA = 0;
        int minuteB = 0;
        int hourA = 0;
        int hourB = 0;
        int tick = 0;
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
            tick++;

            string secA =(DateTime.Now.ToString("ss"));
            secondA = Convert.ToInt32(secA.Substring(secA.Length -1));
            choiceA(secondA);
            secondB = Convert.ToInt32(secA.Substring(0,1));
            choiceB(secondB);

            string minA = (DateTime.Now.ToString("mm"));
            minuteA = Convert.ToInt32(minA.Substring(minA.Length - 1));
            choiceC(minuteA);
            minuteB = Convert.ToInt32(minA.Substring(0, 1));
            choiceD(minuteB);

            string hrA = (DateTime.Now.ToString("hh"));
            hourA = Convert.ToInt32(hrA.Substring(hrA.Length - 1));
            choiceE(hourA);
            hourB = Convert.ToInt32(hrA.Substring(0, 1));
            choiceF(hourB);

        }
        private void choiceA(int btnclock)
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
        // ------------------------------------ CHOICE B ------------------------------------------
        private void choiceB(int btnclockB)
        {
            if (btnclockB == 1)
            {
                B1.BackColor = System.Drawing.Color.Transparent;
                B4.BackColor = System.Drawing.Color.Transparent;
                B5.BackColor = System.Drawing.Color.Transparent;
                B6.BackColor = System.Drawing.Color.Transparent;

                B2.PerformClick();
                B3.PerformClick();

            }
            else if (btnclockB == 2)
            {
                B3.BackColor = System.Drawing.Color.Transparent;

                B1.PerformClick();
                B2.PerformClick();
                B7.PerformClick();
                B5.PerformClick();
                B4.PerformClick();
            }
            else if (btnclockB == 3)
            {
                B5.BackColor = System.Drawing.Color.Transparent;

                B1.PerformClick();
                B2.PerformClick();
                B3.PerformClick();
                B4.PerformClick();
                B7.PerformClick();
            }
            else if (btnclockB == 4)
            {
                B1.BackColor = System.Drawing.Color.Transparent;
                B4.BackColor = System.Drawing.Color.Transparent;

                B2.PerformClick();
                B3.PerformClick();
                B6.PerformClick();
                B7.PerformClick();
            }
            else if (btnclockB == 5)
            {
                B2.BackColor = System.Drawing.Color.Transparent;

                B1.PerformClick();
                B3.PerformClick();
                B4.PerformClick();
                B6.PerformClick();
                B7.PerformClick();
            }

            else
            {
                B7.BackColor = System.Drawing.Color.Transparent;

                B1.PerformClick();
                B2.PerformClick();
                B3.PerformClick();
                B4.PerformClick();
                B5.PerformClick();
                B6.PerformClick();
            }

        }
        // ------------------------------------ CHOICE C ------------------------------------------
        private void choiceC(int btnclockC)
        {
            if (btnclockC == 1)
            {
               C1.BackColor = System.Drawing.Color.Transparent;
               C4.BackColor = System.Drawing.Color.Transparent;
               C5.BackColor = System.Drawing.Color.Transparent;
               C6.BackColor = System.Drawing.Color.Transparent;

               C2.PerformClick();
               C3.PerformClick();

            }
            else if(btnclockC == 2)
            {
               C3.BackColor = System.Drawing.Color.Transparent;

               C1.PerformClick();
               C2.PerformClick();
               C7.PerformClick();
               C5.PerformClick();
               C4.PerformClick();
            }
            else if (btnclockC == 3)
            {
               C5.BackColor = System.Drawing.Color.Transparent;

               C1.PerformClick();
               C2.PerformClick();
               C3.PerformClick();
               C4.PerformClick();
               C7.PerformClick();
            }
            else if (btnclockC == 4)
            {
               C1.BackColor = System.Drawing.Color.Transparent;
               C4.BackColor = System.Drawing.Color.Transparent;

               C2.PerformClick();
               C3.PerformClick();
               C6.PerformClick();
               C7.PerformClick();
            }
            else if (btnclockC == 5)
            {
               C2.BackColor = System.Drawing.Color.Transparent;

               C1.PerformClick();
               C3.PerformClick();
               C4.PerformClick();
               C6.PerformClick();
               C7.PerformClick();
            }
            else if (btnclockC == 6)
            {

               C1.PerformClick();
               C3.PerformClick();
               C4.PerformClick();
               C5.PerformClick();
               C6.PerformClick();
               C7.PerformClick();
            }
            else if (btnclockC == 7)
            {
               C4.BackColor = System.Drawing.Color.Transparent;
               C5.BackColor = System.Drawing.Color.Transparent;
               C6.BackColor = System.Drawing.Color.Transparent;
               C7.BackColor = System.Drawing.Color.Transparent;

               C1.PerformClick();
               C2.PerformClick();
               C3.PerformClick();
            }
            else if (btnclockC == 8)
            {
               C1.PerformClick();
               C2.PerformClick();
               C3.PerformClick();
               C4.PerformClick();
               C5.PerformClick();
               C6.PerformClick();
               C7.PerformClick();
            }
            else if (btnclockC == 9)
            {
               C5.BackColor = System.Drawing.Color.Transparent;

               C1.PerformClick();
               C2.PerformClick();
               C3.PerformClick();
               C4.PerformClick();
               C6.PerformClick();
               C7.PerformClick();
            }
            else
            {
               C7.BackColor = System.Drawing.Color.Transparent;
               C1.PerformClick();
               C2.PerformClick();
               C3.PerformClick();
               C4.PerformClick();
               C5.PerformClick();
               C6.PerformClick();
            }

        }
        // ------------------------------------ CHOICE D ------------------------------------------
        private void choiceD(int btnclockD)
        {
            if (btnclockD == 1)
            {
                D1.BackColor = System.Drawing.Color.Transparent;
                D4.BackColor = System.Drawing.Color.Transparent;
                D5.BackColor = System.Drawing.Color.Transparent;
                D6.BackColor = System.Drawing.Color.Transparent;

                D2.PerformClick();
                D3.PerformClick();

            }
            else if (btnclockD == 2)
            {
                D3.BackColor = System.Drawing.Color.Transparent;

                D1.PerformClick();
                D2.PerformClick();
                D7.PerformClick();
                D5.PerformClick();
                D4.PerformClick();
            }
            else if (btnclockD == 3)
            {
                D5.BackColor = System.Drawing.Color.Transparent;

                D1.PerformClick();
                D2.PerformClick();
                D3.PerformClick();
                D4.PerformClick();
                D7.PerformClick();
            }
            else if (btnclockD == 4)
            {
                D1.BackColor = System.Drawing.Color.Transparent;
                D4.BackColor = System.Drawing.Color.Transparent;

                D2.PerformClick();
                D3.PerformClick();
                D6.PerformClick();
                D7.PerformClick();
            }
            else if (btnclockD == 5)
            {
                D2.BackColor = System.Drawing.Color.Transparent;

                D1.PerformClick();
                D3.PerformClick();
                D4.PerformClick();
                D6.PerformClick();
                D7.PerformClick();
            }

            else
            {
                D7.BackColor = System.Drawing.Color.Transparent;

                D1.PerformClick();
                D2.PerformClick();
                D3.PerformClick();
                D4.PerformClick();
                D5.PerformClick();
                D6.PerformClick();
               
            }

        }
        // ------------------------------------ CHOICE E ------------------------------------------
        private void choiceE(int btnclockE)
        {
            if (btnclockE == 1)
            {
                E1.BackColor = System.Drawing.Color.Transparent;
                E4.BackColor = System.Drawing.Color.Transparent;
                E5.BackColor = System.Drawing.Color.Transparent;
                E6.BackColor = System.Drawing.Color.Transparent;

                E2.PerformClick();
                E3.PerformClick();

            }
            else if (btnclockE == 2)
            {
                E3.BackColor = System.Drawing.Color.Transparent;

                E1.PerformClick();
                E2.PerformClick();
                E7.PerformClick();
                E5.PerformClick();
                E4.PerformClick();
            }
            else if (btnclockE == 3)
            {
                E5.BackColor = System.Drawing.Color.Transparent;

                E1.PerformClick();
                E2.PerformClick();
                E3.PerformClick();
                E4.PerformClick();
                E7.PerformClick();
            }
            else if (btnclockE == 4)
            {
                E1.BackColor = System.Drawing.Color.Transparent;
                E4.BackColor = System.Drawing.Color.Transparent;

                E2.PerformClick();
                E3.PerformClick();
                E6.PerformClick();
                E7.PerformClick();
            }
            else if (btnclockE == 5)
            {
                E2.BackColor = System.Drawing.Color.Transparent;

                E1.PerformClick();
                E3.PerformClick();
                E4.PerformClick();
                E6.PerformClick();
                E7.PerformClick();
            }
            else if (btnclockE == 6)
            {

                E1.PerformClick();
                E3.PerformClick();
                E4.PerformClick();
                E5.PerformClick();
                E6.PerformClick();
                E7.PerformClick();
            }
            else if (btnclockE == 7)
            {
                E4.BackColor = System.Drawing.Color.Transparent;
                E5.BackColor = System.Drawing.Color.Transparent;
                E6.BackColor = System.Drawing.Color.Transparent;
                E7.BackColor = System.Drawing.Color.Transparent;

                E1.PerformClick();
                E2.PerformClick();
                E3.PerformClick();
            }
            else if (btnclockE == 8)
            {
                E1.PerformClick();
                E2.PerformClick();
                E3.PerformClick();
                E4.PerformClick();
                E5.PerformClick();
                E6.PerformClick();
                E7.PerformClick();
            }
            else if (btnclockE == 9)
            {
                E5.BackColor = System.Drawing.Color.Transparent;

                E1.PerformClick();
                E2.PerformClick();
                E3.PerformClick();
                E4.PerformClick();
                E6.PerformClick();
                E7.PerformClick();
            }
            else
            {
                E7.BackColor = System.Drawing.Color.Transparent;
                E1.PerformClick();
                E2.PerformClick();
                E3.PerformClick();
                E4.PerformClick();
                E5.PerformClick();
                E6.PerformClick();
            }

        }
        // ------------------------------------ CHOICE F ------------------------------------------
        private void choiceF(int btnclockF)
        {
            if (btnclockF == 1)
            {
                F1.BackColor = System.Drawing.Color.Transparent;
                F4.BackColor = System.Drawing.Color.Transparent;
                F5.BackColor = System.Drawing.Color.Transparent;
                F6.BackColor = System.Drawing.Color.Transparent;

                F2.PerformClick();
                F3.PerformClick();

            }
            else
            {
                F7.BackColor = System.Drawing.Color.Transparent;
                F1.PerformClick();
                F2.PerformClick();
                F3.PerformClick();
                F4.PerformClick();
                F5.PerformClick();
                F6.PerformClick();
            }

        }
    }
}
