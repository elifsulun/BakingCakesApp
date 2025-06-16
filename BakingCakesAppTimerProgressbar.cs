using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class BakingCakesAppTimerProgressbar : Form
    {
        public BakingCakesAppTimerProgressbar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.MistyRose;
            }

            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.HotPink;
            }

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 20;

            if (progressBar2.Value % 40 == 0)
            {
                label2.BackColor = Color.MistyRose;
            }
            else
            {
                label2.BackColor = Color.HotPink;
            }

            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;

            if (progressBar3.Value % 40 == 0)
            {
                label3.BackColor = Color.MistyRose;
            }
            else
            {
                label3.BackColor = Color.HotPink;
            }

            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 5;

            if (progressBar4.Value % 10 == 0)
            {
                label4.BackColor = Color.HotPink;
            }
            else
            {
                label4.BackColor = Color.MistyRose;
            }

            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Afiyet olsun :)");
            }

        }
    }
}
