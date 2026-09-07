namespace Bai5
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
            lblNhapTenPrompt = new Label();
            txtNhapTen = new TextBox();
            grpColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            grpFont = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            lblLapTrinhBoi = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            grpColor.SuspendLayout();
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTenPrompt
            // 
            lblNhapTenPrompt.BackColor = Color.Black;
            lblNhapTenPrompt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNhapTenPrompt.ForeColor = Color.Lime;
            lblNhapTenPrompt.Location = new Point(25, 20);
            lblNhapTenPrompt.Name = "lblNhapTenPrompt";
            lblNhapTenPrompt.Size = new Size(85, 25);
            lblNhapTenPrompt.TabIndex = 8;
            lblNhapTenPrompt.Text = "Nhập Tên:";
            lblNhapTenPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Font = new Font("Segoe UI", 10F);
            txtNhapTen.Location = new Point(115, 20);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(335, 25);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // grpColor
            // 
            grpColor.BackColor = Color.FromArgb(220, 235, 252);
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radGreen);
            grpColor.Controls.Add(radRed);
            grpColor.Font = new Font("Segoe UI", 9.75F);
            grpColor.Location = new Point(25, 60);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(195, 160);
            grpColor.TabIndex = 1;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(25, 122);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(62, 23);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(25, 90);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(56, 23);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(25, 58);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(66, 23);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(25, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(52, 23);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // grpFont
            // 
            grpFont.BackColor = Color.FromArgb(255, 235, 215);
            grpFont.Controls.Add(chkUnderline);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Font = new Font("Segoe UI", 9.75F);
            grpFont.Location = new Point(255, 60);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(195, 160);
            grpFont.TabIndex = 2;
            grpFont.TabStop = false;
            grpFont.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            chkUnderline.ForeColor = Color.Navy;
            chkUnderline.Location = new Point(25, 108);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(93, 23);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            chkItalic.ForeColor = Color.Navy;
            chkItalic.Location = new Point(25, 68);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(116, 23);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkBold.ForeColor = Color.Navy;
            chkBold.Location = new Point(25, 28);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(92, 23);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // lblLapTrinhBoi
            // 
            lblLapTrinhBoi.AutoSize = true;
            lblLapTrinhBoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLapTrinhBoi.ForeColor = Color.Brown;
            lblLapTrinhBoi.Location = new Point(25, 245);
            lblLapTrinhBoi.Name = "lblLapTrinhBoi";
            lblLapTrinhBoi.Size = new Size(106, 19);
            lblLapTrinhBoi.TabIndex = 3;
            lblLapTrinhBoi.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = Color.White;
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Font = new Font("Segoe UI", 10F);
            lblLapTrinh.ForeColor = Color.Red;
            lblLapTrinh.Location = new Point(140, 240);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(200, 32);
            lblLapTrinh.TabIndex = 4;
            lblLapTrinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9.75F);
            btnThoat.Location = new Point(355, 239);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 295);
            Controls.Add(lblNhapTenPrompt);
            Controls.Add(txtNhapTen);
            Controls.Add(grpColor);
            Controls.Add(grpFont);
            Controls.Add(lblLapTrinhBoi);
            Controls.Add(lblLapTrinh);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Định Dạng(Formater)";
            Load += Form1_Load;
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTenPrompt;
        private TextBox txtNhapTen;
        private GroupBox grpColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox grpFont;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label lblLapTrinhBoi;
        private Label lblLapTrinh;
        private Button btnThoat;
    }
}
