namespace T3
{
    public partial class Nelilaskin : Form
    {
        public Nelilaskin()
        {
            InitializeComponent();
        }

        private void Nelilaskin_Load(object sender, EventArgs e)
        {

        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(lukuYksiTB.Text);
            float luku2 = float.Parse(lukuKaksiTB.Text);
            float vastaus = 0;
            string operaattori = operaattoriCB.Text;

            switch (operaattori)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;

                case "-":
                    vastaus = luku1 - luku2;
                    break;

                case "*":
                    vastaus = luku1 * luku2;
                    break;

                case "/":
                    vastaus = luku1 / luku2;
                    break;

                default:
                    vastaus = 000;
                    break;
            }
            vastausLB.Text = Convert.ToString(vastaus);
            vastausLB.Visible = true;
        }
    }
}
