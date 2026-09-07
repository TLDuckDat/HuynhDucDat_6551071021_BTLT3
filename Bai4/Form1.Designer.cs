namespace Bai4
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
            panelHeader = new Panel();
            lblHeader = new Label();
            panelControl = new Panel();
            lblDock = new Label();
            cboDock = new ComboBox();
            lblAnchor = new Label();
            cboAnchor = new ComboBox();
            btnClickMe = new Button();
            panelHeader.SuspendLayout();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader (Minh họa thuộc tính Dock = Top)
            // 
            panelHeader.BackColor = Color.FromArgb(230, 240, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 35);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblHeader.ForeColor = Color.FromArgb(0, 50, 150);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(500, 35);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Kéo giãn cửa sổ để quan sát đối tượng tự căn chỉnh vị trí hợp lý";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelControl (Minh họa thuộc tính Dock = Bottom)
            // 
            panelControl.BackColor = Color.FromArgb(245, 245, 245);
            panelControl.BorderStyle = BorderStyle.FixedSingle;
            panelControl.Controls.Add(lblDock);
            panelControl.Controls.Add(cboDock);
            panelControl.Controls.Add(lblAnchor);
            panelControl.Controls.Add(cboAnchor);
            panelControl.Dock = DockStyle.Bottom;
            panelControl.Location = new Point(0, 265);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(500, 45);
            panelControl.TabIndex = 2;
            // 
            // lblDock
            // 
            lblDock.AutoSize = true;
            lblDock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDock.Location = new Point(255, 14);
            lblDock.Name = "lblDock";
            lblDock.Size = new Size(39, 15);
            lblDock.TabIndex = 2;
            lblDock.Text = "Dock:";
            // 
            // cboDock
            // 
            cboDock.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDock.FormattingEnabled = true;
            cboDock.Items.AddRange(new object[] { "None", "Top", "Bottom", "Left", "Right", "Fill" });
            cboDock.Location = new Point(300, 11);
            cboDock.Name = "cboDock";
            cboDock.Size = new Size(130, 23);
            cboDock.TabIndex = 3;
            cboDock.SelectedIndexChanged += cboDock_SelectedIndexChanged;
            // 
            // lblAnchor
            // 
            lblAnchor.AutoSize = true;
            lblAnchor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnchor.Location = new Point(15, 14);
            lblAnchor.Name = "lblAnchor";
            lblAnchor.Size = new Size(51, 15);
            lblAnchor.TabIndex = 0;
            lblAnchor.Text = "Anchor:";
            // 
            // cboAnchor
            // 
            cboAnchor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnchor.FormattingEnabled = true;
            cboAnchor.Items.AddRange(new object[] { "None (Luôn ở giữa Form)", "Top, Left (Mặc định)", "Top, Right", "Bottom, Right", "Top, Bottom, Left, Right (Co giãn)" });
            cboAnchor.Location = new Point(72, 11);
            cboAnchor.Name = "cboAnchor";
            cboAnchor.Size = new Size(170, 23);
            cboAnchor.TabIndex = 1;
            cboAnchor.SelectedIndexChanged += cboAnchor_SelectedIndexChanged;
            // 
            // btnClickMe (Nút chính từ Bài 2, Anchor = None để luôn ở chính giữa form)
            // 
            btnClickMe.Anchor = AnchorStyles.None;
            btnClickMe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(175, 120);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(150, 55);
            btnClickMe.TabIndex = 1;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += btnClickMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 310);
            Controls.Add(btnClickMe);
            Controls.Add(panelControl);
            Controls.Add(panelHeader);
            MinimumSize = new Size(480, 280);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Event Example - Layout Anchor & Dock";
            Load += Form1_Load;
            Click += Form1_Click;
            panelHeader.ResumeLayout(false);
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelControl;
        private Label lblAnchor;
        private ComboBox cboAnchor;
        private Label lblDock;
        private ComboBox cboDock;
        private Button btnClickMe;
    }
}
