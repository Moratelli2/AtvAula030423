using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATVAULA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);

            double delta =Math.Pow(b, 2) - 4 * a * c;

            double x1 = ((-b) + Math.Sqrt(delta)) / 2.0 * a;
            double x2 = ((-b) - Math.Sqrt(delta)) / 2.0 * a;

            MessageBox.Show("Delta = " + delta +
                            "\nx1 = " + x1 +
                            "\nx2 = " + x2);
        }
    }
}
