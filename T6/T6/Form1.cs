namespace T6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Sakari" && SalasanaTB.Text == "Sakari")
            {
                SalasanaOikeinPanel.Visible = true;
                SalasanaPanel.Visible = true;
                VirheviestiLB.Visible = false;
                
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
