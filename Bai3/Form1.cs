namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nhấn vào Button btnHo thì gán nội dung của txtHo cho lblHoTen
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        // Nhấn vào Button btnTen thì gán nội dung của txtTen cho lblHoTen
        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        // Nhấn vào Button btnHoTen thì gán nội dung của txtHo cộng với txtTen cho lblHoTen
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        // Nhấn Double click vào lblHoTen thì nội dung của lblHoTen bị xoá
        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        // Nhấn vào btnKetThuc thì đóng chương trình
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
