using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work_wf_ProgressBar
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = counter.ToString();
            counters = trackBar1.Value * 10;
            toolStripStatusLabel4.Text = counters.ToString();
            timer.Tick += new EventHandler(Show_info);
        }
        int counters;
        int counters_time;
        int counter = 1;

        private void Show_info(object sender, EventArgs e)
        {
            counters_time++;
            counters--;
            toolStripStatusLabel4.Text = counters.ToString();
            if (toolStripStatusLabel2.Text == "11")
            {
                timer.Stop();
                MessageBox.Show($"ти виграв\nзатрачений час: {counters_time} c");

            }
            else
            if (counters == 0)
            {
                timer.Stop();
                MessageBox.Show($"you lose");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
            int[] arr = new int[10];

            Random random = new Random();
            int rnd;

            for (int i = 0; i < arr.Length; i++)
            {
                rnd = random.Next(1, 11);
                arr[i] = rnd;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        i--;
                        break;
                    }
                }
            }

            int k = 0;
            foreach (Button rb1 in groupBox1.Controls.OfType<Button>())
            {
                rb1.Text = arr[k].ToString();
                k++;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == counter.ToString())
            {
                button2.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == counter.ToString())
            {
                button8.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == counter.ToString())
            {
                button9.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == counter.ToString())
            {
                button5.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == counter.ToString())
            {
                button4.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == counter.ToString())
            {
                button3.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == counter.ToString())
            {
                button11.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == counter.ToString())
            {
                button7.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == counter.ToString())
            {
                button6.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == counter.ToString())
            {
                button10.BackColor = Color.Green;
                    counter++;
                toolStripStatusLabel2.Text = counter.ToString();
                toolStripProgressBar1.Value += 10;
            }


        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            counters = trackBar1.Value * 10;
            toolStripStatusLabel4.Text = counters.ToString();
        }
    }
}
