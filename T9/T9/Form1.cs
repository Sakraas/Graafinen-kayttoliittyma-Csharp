namespace T9
{
    public partial class Lampotilamuunnin : Form
    {
        public Lampotilamuunnin()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus = 0.0;
            double asteet = Convert.ToDouble(syottoTB.Text);
            if (celsiusRB.Checked)
            {
                vastaus = asteet * 9 / 5 + 32;
            }
            else if (fahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) * 5 / 9;
            }
            vastausLB.Text = vastaus.ToString("F2") + " °" + (celsiusRB.Checked ? "F" : "C");
            vastausLB.Visible = true;

        }
    }
}
