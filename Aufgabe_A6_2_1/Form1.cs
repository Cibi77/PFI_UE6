using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A6_2_1
{
    public partial class Form1 : Form
    {
        int randomValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdGenerate_Click(object sender, EventArgs e)
        {
            Random randomGen = new Random();
            randomValue = randomGen.Next(10, 10001);
            TxtNumber.Text = randomValue.ToString();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            if (randomValue == 0)
            {
                MessageBox.Show(this, "Bitte erst eine Zufallszahl generieren");
            }
            else
            {
                TxtOut.Clear();
                float number = randomValue;
                float result = 0f;
                int count = 0;

                do
                {
                    result = number / 2;
                    TxtOut.Text += number.ToString() + " /2 = " + result.ToString() +"\r\n";
                    number = result;
                    count++;
                } while (result >= 1);
                LblCount.Text = "Anzahl Schleifenwiederholungen: " + count.ToString();
            }
        }
    }
}
