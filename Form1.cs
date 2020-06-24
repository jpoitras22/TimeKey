using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            label2.Text = "Running";
            label2.ForeColor = Color.Green;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("W");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            label2.Text = "Stopped";
            label2.ForeColor = Color.Red;
            timer1.Enabled = false;
        }
    }
}
