using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace T15
{
    public partial class SekuntikelloForm : Form
    {
        private Stopwatch T15 = new Stopwatch();
        public SekuntikelloForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", T15.Elapsed);
        }

        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            T15.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            T15.Stop();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            T15.Reset();
        }
    }
}
