using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A6_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            TxtOut.Clear();
            int number = Convert.ToInt32(NumNumber.Value);
            string binary = "";

            do
            {
                binary = Convert.ToString((number % 2)) + binary;
                number = number / 2;
            } while (number > 0);

            TxtOut.Text = binary;
        }
    }
}
