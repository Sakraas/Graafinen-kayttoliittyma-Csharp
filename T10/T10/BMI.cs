namespace T10
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = paino / (pituus * pituus);
            if (bmi < 18.5)
            {
                bmiLB.Text = "Alipaino";
                bmiLB.ForeColor = Color.Blue;
                bmiLB.Text += " " + bmi.ToString("0.00");
                bmiLB.Font = new Font(bmiLB.Font, FontStyle.Bold);
                bmiLB.Visible = true;
            }
            else if (bmi < 25)
            {
                bmiLB.Text = "Normaali paino";
                bmiLB.ForeColor = Color.Green;
                bmiLB.Text += " " + bmi.ToString("0.00");
                bmiLB.Font = new Font(bmiLB.Font, FontStyle.Bold);
                bmiLB.Visible = true;
            }
            else if (bmi < 30)
            {
                bmiLB.Text = "Ylipaino";
                bmiLB.ForeColor = Color.Orange;
                bmiLB.Text += " " + bmi.ToString("0.00");
                bmiLB.Font = new Font(bmiLB.Font, FontStyle.Bold);
                bmiLB.Visible = true;
            }
            else
            {
                bmiLB.Text = "Lihavuus";
                bmiLB.ForeColor = Color.Red;
                bmiLB.Text += " " + bmi.ToString("0.00");
                bmiLB.Font = new Font(bmiLB.Font, FontStyle.Bold);
                bmiLB.Visible = true;
            }
        }
    }
}
