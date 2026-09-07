namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Khi Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // a. Radiobutton Red được chọn mặc định
            radRed.Checked = true;
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;

            // b. Con trỏ xuất hiện ngay tại ô Nhập tên
            txtNhapTen.Focus();
        }

        // 2. Khi gõ chữ trong txtNhapTen, chữ xuất hiện liên tục trong lblLapTrinh
        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        // 3. Đổi màu chữ tương ứng khi nhấn các RadioButton
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhapTen.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhapTen.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        // 4. Đổi kiểu font (Đậm, Nghiêng, Gạch chân) bằng toán tử XOR (^)
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Underline);
        }

        // 5. Nhấn nút Thoát để đóng Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
