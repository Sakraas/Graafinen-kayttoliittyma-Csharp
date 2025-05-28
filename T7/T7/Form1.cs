namespace T7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AjomaaraCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, muut, polttoaine, pesut, huollot, renkaat, kulut, kilometrit;

            laina = Convert.ToDouble(LyhennysTB.Text);
            laina = laina * 12; // Muutetaan kuukausilyhennys vuotuiseksi
            nesteet = Convert.ToDouble(NesteetTB.Text);
            nesteet = nesteet * 12; // Muutetaan kuukausikulutus vuotuiseksi
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            muut = Convert.ToDouble(MuutkulutTB.Text);
            muut = muut * 12; // Muutetaan kuukausikulutus vuotuiseksi
            polttoaine = Convert.ToDouble(PolttoaineTB.Text);
            polttoaine = polttoaine * 12; // Muutetaan kuukausikulutus vuotuiseksi
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kulut = laina + nesteet + vakuutus + muut + polttoaine + pesut + huollot + renkaat;
            kilometrit = Convert.ToDouble(AjomaaraCB.Text);

            TulostusLB.Text = (kulut / kilometrit).ToString("0.00") + " €/km";

            TulostusLB.Visible = true;

        }
    }
}
