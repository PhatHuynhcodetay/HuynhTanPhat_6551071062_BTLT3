namespace demo
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
            lblNhapPassword = new Label();
            lblHienThi = new Label();
            txtNhapPassword = new TextBox();
            txtHienThi = new TextBox();
            btnHienThi = new Button();
            btnTiep = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // lblNhapPassword
            // 
            lblNhapPassword.AutoSize = true;
            lblNhapPassword.Location = new Point(244, 114);
            lblNhapPassword.Name = "lblNhapPassword";
            lblNhapPassword.Size = new Size(110, 20);
            lblNhapPassword.TabIndex = 0;
            lblNhapPassword.Text = "Nhập Password";
            lblNhapPassword.Click += label1_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.AutoSize = true;
            lblHienThi.Location = new Point(244, 160);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(61, 20);
            lblHienThi.TabIndex = 1;
            lblHienThi.Text = "Hiển thị";
            lblHienThi.Click += label2_Click;
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.Location = new Point(376, 114);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(125, 27);
            txtNhapPassword.TabIndex = 2;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(376, 160);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.ReadOnly = true;
            txtHienThi.Size = new Size(125, 27);
            txtHienThi.TabIndex = 3;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(133, 286);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 4;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(332, 286);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(539, 286);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(btnTiep);
            Controls.Add(btnHienThi);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPassword);
            Controls.Add(lblHienThi);
            Controls.Add(lblNhapPassword);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sử dụng Label và Textbox";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapPassword;
        private Label lblHienThi;
        private TextBox txtNhapPassword;
        private TextBox txtHienThi;
        private Button btnHienThi;
        private Button btnTiep;
        private Button btnDong;
    }
}
