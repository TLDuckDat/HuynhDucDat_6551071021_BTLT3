namespace BTLT3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(70, 55, 45);
            label1.Location = new Point(170, 105);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(70, 55, 45);
            label2.Location = new Point(170, 155);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Hiển thị";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 13F);
            textBox1.Location = new Point(310, 100);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 13F);
            textBox2.Location = new Point(310, 150);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 94, 75);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(170, 225);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 4;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(151, 123, 104);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(335, 225);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 5;
            button2.Text = "Tiếp";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(175, 80, 80);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(500, 225);
            button3.Name = "button3";
            button3.Size = new Size(125, 40);
            button3.TabIndex = 6;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Font = new Font("Times New Roman", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sử dụng label và Textbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}