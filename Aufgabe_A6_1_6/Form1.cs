using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A6_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            TxtOut.Clear();
            for (int y=1; y<=14; y++)
            {
                for (int x=1; x<=y; x++)
                {
                    TxtOut.Text += x;
                }
                TxtOut.Text += "\r\n";
            }
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            TxtOut.Clear();
           
        }
    }
}
