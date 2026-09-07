namespace Baitap2
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
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Anchor = AnchorStyles.None;
            btnClickMe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(135, 75);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(150, 55);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += btnClickMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 220);
            Controls.Add(btnClickMe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Event Example";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
    }
}
