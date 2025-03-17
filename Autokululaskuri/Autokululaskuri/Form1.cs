using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokululaskuri
{
    public partial class Autokulutuslaskuri : Form
    {
        public Autokulutuslaskuri()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tulosperkm_Click(object sender, EventArgs e)
        {


        }

        private void laskee_Click(object sender, EventArgs e)
        {
            tulosperkm.Visible = true;
            Double arv = Convert.ToDouble(hankintahinta.Text);
            Double pros = Convert.ToDouble(arvonalenema.Text);
            Double vak = Convert.ToDouble(vakuutusmaksu.Text);
            Double huol = Convert.ToDouble(vuosihuollot.Text);
            Double renk = Convert.ToDouble(renkaatvuodessa.Text);
            Double pes = Convert.ToDouble(pesutvuodessa.Text);
            Double lyh = Convert.ToDouble(lyhennyskorkoineen.Text);
            Double nes = Convert.ToDouble(lisattavatnesteet.Text);
            Double pys = Convert.ToDouble(pysakointikuukaudessa.Text);
            Double ben = Convert.ToDouble(polttoaineetkuukaudessa.Text);
            Double muut = Convert.ToDouble(muutkulutkuukaudessa.Text);
            Double kmv = Convert.ToDouble(kilometritvuodessa.Text);

            Double tul = (pros / 100 * arv / kmv) + (vak + huol + renk + pes + ((lyh + nes + pys + ben + muut) * 12)) / kmv;

            tulosperkm.Text = tul + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double kmkk1 = Convert.ToDouble(kmkk.Text);

            Double tul = Convert.ToDouble(tulosperkm.Text);

            Double kust = kmkk1 * tul;

            kustkk.Text = kust + "€";

            kustkk.Visible= true;
        }
    }
}
