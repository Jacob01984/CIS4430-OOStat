namespace OOStat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            Statistics oStat = new Statistics();
            oStat.input = txtInput.Text;
            txtNumbers.Text = oStat.getValues();
            txtSum.Text = oStat.getSum().ToString();
            txtMean.Text = oStat.getMean().ToString();
            txtVariance.Text = oStat.getVariance().ToString();
            txtSD.Text = oStat.getSD().ToString();
        }
        
    }
}