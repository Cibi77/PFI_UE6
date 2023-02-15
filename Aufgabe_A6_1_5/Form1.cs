using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A6_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String emptyString = "";
            for (int y = 1; y <= 10; y++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    if ((x * y) < 10)
                    {
                        emptyString = "     "; // 5 Leerzeichen
                    }
                    else if ((x * y) >= 10 && (x * y) < 100)
                    {
                        emptyString = "   "; // 3 Leerzeichen
                    }
                    else if ((x * y) >= 100)
                    {
                        emptyString = " "; // 1 Leerzeichen
                    }
                    TxtView.Text += emptyString + Convert.ToString(y * x);
                }
                TxtView.Text += "\r\n";
            }

        }
    }
}
