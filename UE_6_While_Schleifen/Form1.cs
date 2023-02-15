using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UE_6_While_Schleifen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            /*
            int d = 1;
            while (d <= 10)
            {
                TxtOut.Text += d + " ";
                d++;
            }*/

            // Zufallszahlen, hört auf, sobald 24 generiert wird.
            /*TxtOut.Clear();
            Random r = new Random();
            int value = 0;
            int counter = 0;
            string output = "";

            while (value != 24)
            {
                value = r.Next(0, 101);
                output += value + ", ";
                counter++;
            }
            LblWiederholungen.Text = output;
            LblWiederholungen.Text = counter.ToString();*/

            // Zufallszahlen, hört auf, sobald 24 generiert wird.
            TxtOut.Clear();
            Random r = new Random();
            int value = 0;
            int counter = 0;
            string output = "";

            do
            {
                value = r.Next(0, 101);
                output += value + ", ";
                counter++;
            } while (value != 0);

            LblWiederholungen.Text = output;
            LblWiederholungen.Text = counter.ToString();

        }
    }
}
