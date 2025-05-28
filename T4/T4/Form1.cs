namespace T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime syntymaAika = syntymaDT.Value;
            DateTime nykyhetki = DateTime.Now;
            double ikaero = (nykyhetki - syntymaAika).TotalDays / 365.25; // Oletetaan karkausvuosi joka nelj‰s vuosi
            ikaero = Math.Floor(ikaero); // Pyˆristet‰‰n alasp‰in
            vuosiLB.Text = ikaero.ToString("0") + " vuotta";
            vuosiLB.Visible = true;
            //toimii t‰h‰n asti
            ikaero = (nykyhetki - syntymaAika).TotalDays / 30.4375; // Oletetaan kuukausi keskim‰‰rin 30.4375 p‰iv‰‰
            kuukausiLB.Text = ikaero.ToString("0") + " kuukautta";
            kuukausiLB.Visible = true;
            //toimii t‰h‰n asti
            ikaero = (nykyhetki - syntymaAika).TotalDays; // Oletetaan p‰iv‰ 1 p‰iv‰
            paivaLB.Text = ikaero.ToString("0") + " p‰iv‰‰";
            paivaLB.Visible = true;
            //toimii t‰h‰n asti
            ikaero = (nykyhetki - syntymaAika).TotalHours; // Oletetaan tunti 1 tunti
            tuntiLB.Text = ikaero.ToString("0") + " tuntia";
            tuntiLB.Visible = true;
            //toimii t‰h‰n asti
            ikaero = (nykyhetki - syntymaAika).TotalMinutes; // Oletetaan minuutti 1 minuutti
            minuuttiLB.Text = ikaero.ToString("0") + " minuuttia";
            minuuttiLB.Visible = true;
            //toimii t‰h‰n asti
            ikaero = (nykyhetki - syntymaAika).TotalSeconds; // Oletetaan sekunti 1 sekunti
            sekuntiLB.Text = ikaero.ToString("0") + " sekuntia";
            sekuntiLB.Visible = true;
            //toimii t‰h‰n asti
        }
    }
}
