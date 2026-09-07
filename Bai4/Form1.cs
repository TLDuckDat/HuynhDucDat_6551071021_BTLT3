namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho ComboBox
            cboAnchor.SelectedIndex = 0; // None (luôn ở chính giữa form)
            cboDock.SelectedIndex = 0;   // None

            // Lời chào khi form hiển thị từ Bài 2
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }

        private void cboAnchor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đưa Dock về None để Anchor có hiệu lực
            if (btnClickMe.Dock != DockStyle.None)
            {
                btnClickMe.Dock = DockStyle.None;
                cboDock.SelectedIndex = 0;
            }

            switch (cboAnchor.SelectedIndex)
            {
                case 0:
                    // Anchor = None: Khi form resize, button luôn giữ vị trí chính giữa Form
                    btnClickMe.Anchor = AnchorStyles.None;
                    break;
                case 1:
                    // Mặc định: Gắn cố định vào góc trên bên trái
                    btnClickMe.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    break;
                case 2:
                    // Bám vào góc trên bên phải
                    btnClickMe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    break;
                case 3:
                    // Bám vào góc dưới bên phải
                    btnClickMe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    break;
                case 4:
                    // Bám vào cả 4 cạnh: Tự co giãn theo kích thước Form
                    btnClickMe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    break;
            }
        }

        private void cboDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDock.SelectedIndex)
            {
                case 0:
                    btnClickMe.Dock = DockStyle.None;
                    // Khôi phục kích thước chuẩn nếu vừa bị Dock thay đổi
                    btnClickMe.Size = new Size(150, 55);
                    cboAnchor_SelectedIndexChanged(sender, e);
                    break;
                case 1:
                    btnClickMe.Dock = DockStyle.Top;
                    break;
                case 2:
                    btnClickMe.Dock = DockStyle.Bottom;
                    break;
                case 3:
                    btnClickMe.Dock = DockStyle.Left;
                    break;
                case 4:
                    btnClickMe.Dock = DockStyle.Right;
                    break;
                case 5:
                    btnClickMe.Dock = DockStyle.Fill;
                    break;
            }
        }
    }
}
