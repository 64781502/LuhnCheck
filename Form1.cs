using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luhn
{
    public partial class LuhnCheck : Form
    {
        public LuhnCheck()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try //dont do this kids 💀
            {
                int doubleB1 = Math.Abs(Convert.ToInt32(b1.Text) * 2);
                int doubleB3 = Math.Abs(Convert.ToInt32(b3.Text) * 2);
                int doubleB5 = Math.Abs(Convert.ToInt32(b5.Text) * 2);
                int doubleB7 = Math.Abs(Convert.ToInt32(b7.Text) * 2);
                int doubleB9 = Math.Abs(Convert.ToInt32(b9.Text) * 2);
                int doubleB11 = Math.Abs(Convert.ToInt32(b11.Text) * 2);
                int doubleB13 = Math.Abs(Convert.ToInt32(b13.Text) * 2);
                int doubleB15 = Math.Abs(Convert.ToInt32(b15.Text) * 2);
                int checkeddoubleB1 = 0;
                int checkeddoubleB3 = 0;
                int checkeddoubleB5 = 0;
                int checkeddoubleB7 = 0;
                int checkeddoubleB9 = 0;
                int checkeddoubleB11 = 0;
                int checkeddoubleB13 = 0;
                int checkeddoubleB15 = 0;

                if (doubleB1 >= 10)
                {
                    checkeddoubleB1 += Math.Abs(doubleB1 - 9);
                }
                else
                {
                    checkeddoubleB1 = doubleB1;
                }


                if (doubleB3 >= 10)
                {
                    checkeddoubleB3 += Math.Abs(doubleB3 - 9);
                }
                else
                {
                    checkeddoubleB3 = doubleB3;
                }


                if (doubleB5 >= 10)
                {
                    checkeddoubleB5 += Math.Abs(doubleB5 - 9);
                }
                else
                {
                    checkeddoubleB5 = doubleB5;
                }

                if (doubleB7 >= 10)
                {
                    checkeddoubleB7 += Math.Abs(doubleB7 - 9);
                }
                else
                {
                    checkeddoubleB7 = doubleB7;
                }


                if (doubleB9 >= 10)
                {
                    checkeddoubleB9 += Math.Abs(doubleB9 - 9);
                }
                else
                {
                    checkeddoubleB9 = doubleB9;
                }


                if (doubleB11 >= 10)
                {
                    checkeddoubleB11 += Math.Abs(doubleB11 - 9);
                }
                else
                {
                    checkeddoubleB11 = doubleB11;
                }


                if (doubleB13 >= 10)
                {
                    checkeddoubleB13 += Math.Abs(doubleB13 - 9);
                }
                else
                {
                    checkeddoubleB13 = doubleB13;
                }


                if (doubleB15 >= 10)
                {
                    checkeddoubleB15 += Math.Abs(doubleB15 - 9);
                }
                else
                {
                    checkeddoubleB15 = doubleB15;
                }

                int checkedSum = Math.Abs(checkeddoubleB1 + Convert.ToInt32(b2.Text) + checkeddoubleB3 + Convert.ToInt32(b4.Text) + checkeddoubleB5 + Convert.ToInt32(b6.Text) + checkeddoubleB7 + Convert.ToInt32(b8.Text) + checkeddoubleB9 + Convert.ToInt32(b10.Text) + checkeddoubleB11 + Convert.ToInt32(b12.Text) + checkeddoubleB13 + Convert.ToInt32(b14.Text) + checkeddoubleB15 + Convert.ToInt32(b16.Text));

                if (checkedSum.ToString().EndsWith(("0")))
                {
                    CalcLabel.ForeColor = Color.FromArgb(0, 220, 0);
                    CalcLabel.Text = "Credit card valid";
                }
                else
                {
                    CalcLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    CalcLabel.Text = "Credit card not valid";
                }
            }
            catch (FormatException)
            {
                CalcLabel.ForeColor = Color.FromArgb(255, 0, 0);
                CalcLabel.Text = "Please fill all the digits";
            }
        }

        //ignore
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
