namespace PTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHeSoa.Text = "";
            txtHeSob.Text = "";
            txtKetQua.Text = string.Empty;
            txtHeSoa.Focus();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double hsa = double.Parse(txtHeSoa.Text);
            double hsb = double.Parse(txtHeSob.Text);
            if (hsa == 0 && hsb == 0)
            {
                txtKetQua.Text = "Vô số nghiệm";
            }
            else if (hsa == 0 && hsb != 0)
            {
                txtKetQua.Text = "Vô nghiệm";
            }
            else
            {
                txtKetQua.Text = "x=" + (-hsb / hsa);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
