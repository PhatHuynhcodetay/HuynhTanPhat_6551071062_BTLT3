namespace Định_dạng___Formater
{
    public partial class frmDinhDang : Form
    {
        public frmDinhDang()
        {
            InitializeComponent();
        }

        private void frmDinhDang_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                txtNhapTen.ForeColor = Color.Red;
                lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                txtNhapTen.ForeColor = Color.Green;
                lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                txtNhapTen.ForeColor = Color.Blue;
                lblLapTrinh.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                txtNhapTen.ForeColor = Color.Black;
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void CapNhatKieuChu()
        {
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.FontFamily, lblLapTrinh.Font.Size, style);
            txtNhapTen.Font = new Font(txtNhapTen.Font.FontFamily, txtNhapTen.Font.Size, style);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatKieuChu();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatKieuChu();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatKieuChu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
