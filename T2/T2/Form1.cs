namespace T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Lis‰‰n kuuntelun
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        // Toiminnallisuus buttonille
        private void TulostaBT_Click(object sender, EventArgs e)
        {
            TulostusLB.Text = SyottoKenttaTB.Text;
            TulostusLB.Visible = true;
        }
        // Lis‰t‰‰n enter toiminnallisuus
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter painaminen = tulosta
            {
                TulostaBT.PerformClick();
                e.Handled = true; // Kertoo ett‰ toiminto on jo k‰sitelty
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // ESC Sulkee ohjelman
            }
        }

    }
}