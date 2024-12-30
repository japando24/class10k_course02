namespace PTB2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng phần mềm không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }



        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtHeSoA.Text);
            double b = double.Parse(txtHeSoB.Text);
            double c = double.Parse(txtHeSoC.Text);
            if (a == 0)
            {    //bx+c=0
                if (b == 0 && c == 0)
                {
                    lblKetQua.Text = "Vô số nghiệm";
                }
                else if (b == 0 && c != 0)
                {
                    lblKetQua.Text = "Vô nghiệm";
                }
            }
            else
            {
                double delta = b * b - (4 * a * c);
                if (delta < 0)
                {
                    lblKetQua.Text = "Vô nghiệm";
                }
                else if (delta == 0)
                {
                    lblKetQua.Text = "Nghiệm kép x1=x2=" + (-b / (2 * a));
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    lblKetQua.Text = "x1=" + x1 + ";x2=" + x2;
                }
            }
        }

        private void btnTiep_Click_1(object sender, EventArgs e)
        {
            txtHeSoA.Text = string.Empty;
            txtHeSoB.Text = string.Empty;
            txtHeSoC.Text = string.Empty;
            txtHeSoA.Focus();
        }
    }
}
