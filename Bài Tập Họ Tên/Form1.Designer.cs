namespace Bài_Tập_Họ_Tên
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
            btnHoLot = new Button();
            btnTen = new Button();
            btnHoVaTen = new Button();
            btnExit = new Button();
            lblHoLot = new Label();
            lblTen = new Label();
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            lblHoVaTen = new Label();
            SuspendLayout();
            // 
            // btnHoLot
            // 
            btnHoLot.Location = new Point(167, 290);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(94, 42);
            btnHoLot.TabIndex = 0;
            btnHoLot.Text = "Họ lót";
            btnHoLot.UseVisualStyleBackColor = true;
            btnHoLot.Click += btnHoLot_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(360, 290);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 42);
            btnTen.TabIndex = 1;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoVaTen
            // 
            btnHoVaTen.Location = new Point(538, 290);
            btnHoVaTen.Name = "btnHoVaTen";
            btnHoVaTen.Size = new Size(94, 42);
            btnHoVaTen.TabIndex = 2;
            btnHoVaTen.Text = "Họ và tên";
            btnHoVaTen.UseVisualStyleBackColor = true;
            btnHoVaTen.Click += btnHoVaTen_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(331, 357);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát chương trình";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHoLot
            // 
            lblHoLot.AutoSize = true;
            lblHoLot.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoLot.Location = new Point(167, 183);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(51, 20);
            lblHoLot.TabIndex = 4;
            lblHoLot.Text = "Họ lót";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(167, 226);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 5;
            lblTen.Text = "Tên";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(255, 180);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(364, 27);
            txtHoLot.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.LightPink;
            txtTen.Location = new Point(255, 226);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(364, 27);
            txtTen.TabIndex = 7;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.BackColor = SystemColors.MenuHighlight;
            lblHoVaTen.BorderStyle = BorderStyle.Fixed3D;
            lblHoVaTen.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoVaTen.ForeColor = SystemColors.Desktop;
            lblHoVaTen.Location = new Point(-2, -3);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(806, 186);
            lblHoVaTen.TabIndex = 8;
            lblHoVaTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoVaTen.Click += lblHoVaTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoVaTen);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(lblTen);
            Controls.Add(lblHoLot);
            Controls.Add(btnExit);
            Controls.Add(btnHoVaTen);
            Controls.Add(btnTen);
            Controls.Add(btnHoLot);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHoLot;
        private Button btnTen;
        private Button btnHoVaTen;
        private Button btnExit;
        private Label lblHoLot;
        private Label lblTen;
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Label lblHoVaTen;
    }
}
