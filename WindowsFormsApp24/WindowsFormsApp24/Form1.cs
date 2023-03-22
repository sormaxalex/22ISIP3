using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i==5000)
            {
                timer1.Stop();
                Program.f2.Show();
                this.Hide();
            }
            else
            {
                i += 100;
                progressBar1.PerformStep();
            }
        }
    }
}
