using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A6_2_3_ggT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdCalc_Click(object sender, EventArgs e)
        {
            int divisor  = 0;
            int dividend = 0;
            int zahl1 = Convert.ToInt32(Num1.Value);
            int zahl2 = Convert.ToInt32(Num2.Value);
            int rest = 0;
            int ggt = 0;

            if (zahl1 == zahl2)
            {
                MessageBox.Show(this, "Zahlen gleich gross, also auch ggT.");
            }
            else
            {

                if (zahl1 < zahl2)
                {
                    divisor = zahl1;
                    dividend = zahl2;
                }
                else
                {
                    divisor = zahl2;
                    dividend = zahl1;
                }

                do
                {
                    rest = dividend % divisor;
                    if (rest == 0)
                    {
                        ggt = divisor;
                    }
                    dividend = divisor;
                    divisor = rest;
                } while (!(rest == 0));

                LblResult.Text = Convert.ToString(ggt);
                if (ggt == 1)
                {
                    MessageBox.Show(this, "ggT = 1, d.h. die Zahlen sind Teilerfremd.");
                }
            }
        }
    }
}
