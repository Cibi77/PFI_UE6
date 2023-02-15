using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A6_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            for (int x = Convert.ToInt32(NumStart.Value); x<=Convert.ToInt32(NumEnd.Value); x += Convert.ToInt32(NumStep.Value))
            {
                if ((x %2 ==0) && (RadEven.Checked || RadEverything.Checked))
                {
                    TxtOut.Text += Convert.ToString(x) + "\r\n";
                }
                else if ((x%2!=0) && (RadOdd.Checked || RadEverything.Checked))
                {
                    TxtOut.Text += Convert.ToString(x) + "\r\n";
                }
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            TxtOut.Clear();
        }
    }
}
