namespace Bai3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHoTen = new Label();
            lblHo = new Label();
            lblTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.FromArgb(30, 144, 255);
            lblHoTen.Dock = DockStyle.Top;
            lblHoTen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.ForeColor = Color.White;
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(480, 55);
            lblHoTen.TabIndex = 0;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Font = new Font("Segoe UI", 10F);
            lblHo.Location = new Point(45, 78);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(46, 19);
            lblHo.TabIndex = 1;
            lblHo.Text = "Họ lót";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F);
            lblTen.Location = new Point(45, 118);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(30, 19);
            lblTen.TabIndex = 3;
            lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Font = new Font("Segoe UI", 10F);
            txtHo.Location = new Point(120, 75);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(310, 25);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 204, 204);
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(120, 115);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(310, 25);
            txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            btnHo.Font = new Font("Segoe UI", 9.75F);
            btnHo.Location = new Point(45, 165);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(100, 32);
            btnHo.TabIndex = 5;
            btnHo.Text = "&Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Font = new Font("Segoe UI", 9.75F);
            btnTen.Location = new Point(185, 165);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(100, 32);
            btnTen.TabIndex = 6;
            btnTen.Text = "&Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Font = new Font("Segoe UI", 9.75F);
            btnHoTen.Location = new Point(320, 165);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(110, 32);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ &và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9.75F);
            btnKetThuc.Location = new Point(155, 215);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(160, 35);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 275);
            Controls.Add(lblHoTen);
            Controls.Add(lblHo);
            Controls.Add(txtHo);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(btnHo);
            Controls.Add(btnTen);
            Controls.Add(btnHoTen);
            Controls.Add(btnKetThuc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblHo;
        private Label lblTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
    }
}
