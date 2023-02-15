using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TxtOut.Clear();

            //for-Schleife
            for (int y = 1; y <= 10; y++)
            {              
                for (int x=y; x <= 10; x++)
                {
                    if (x < 10)
                    {
                        TxtOut.Text += " " + x + " ";
                    }
                    else
                    {
                        TxtOut.Text += x + " ";
                    }
 
                }
                TxtOut.Text += "\r\n";
            }

        }
    }
}
