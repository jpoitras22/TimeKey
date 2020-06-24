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
        int timerLength = 240000;
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.SelectedIndex = 3;

            timer1.Interval = timerLength;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            label2.Text = "Running";
            label2.ForeColor = Color.Green;
            timer1.Interval = timerLength;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_stop_Click(sender, e);
            timerLength = Convert.ToInt32(comboBox1.SelectedItem) * 60000;
            
            
        }
    }
}
