using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Diagnostics.Stopwatch Stopwatch = new System.Diagnostics.Stopwatch();

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            TimeSpan elapsed = this.Stopwatch.Elapsed;
            label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Stopwatch.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Stopwatch.Stop();
        }

        private void button_mark_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text + "\n");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            this.Stopwatch.Reset();
            label1.Text = "00:00:00:000";
            listBox1 .Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
