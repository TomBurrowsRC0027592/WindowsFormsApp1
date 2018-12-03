using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richtextbox1.AppendText(d1.ToString() + "\n");
            richtextbox1.AppendText(d1.ToString("N") + "\n");
            richtextbox1.AppendText(d1.ToString("N3")+"\n");
            richtextbox1.AppendText(d1.ToString("N0") + "\n");
            richtextbox1.AppendText(d1.ToString("0") + "\n");
            richtextbox1.AppendText(d1.ToString("0.0") + "\n");
            richtextbox1.AppendText(d1.ToString("0.0E0") + "\n");
            richtextbox1.AppendText(d1.ToString("0.00E00") + "\n");

            double pi = 3.141592653589793;
            double C = 2399792458;
            richtextbox1.AppendText(d1.ToString("N3") + "\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
