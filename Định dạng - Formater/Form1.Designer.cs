namespace Định_dạng___Formater
{
    partial class frmDinhDang
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
            lblNhapTen = new Label();
            txtNhapTen = new TextBox();
            grpColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            grpFont = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            lblTieuDeLapTrinh = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            grpColor.SuspendLayout();
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.BackColor = Color.Black;
            lblNhapTen.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapTen.ForeColor = Color.Lime;
            lblNhapTen.Location = new Point(66, 50);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(119, 31);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(186, 54);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(529, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // grpColor
            // 
            grpColor.BackColor = Color.LightSteelBlue;
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radRed);
            grpColor.Controls.Add(radGreen);
            grpColor.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpColor.Location = new Point(66, 101);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(305, 231);
            grpColor.TabIndex = 2;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.Location = new Point(31, 167);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(93, 35);
            radBlack.TabIndex = 5;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(31, 126);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(83, 35);
            radBlue.TabIndex = 4;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(31, 44);
            radRed.Name = "radRed";
            radRed.Size = new Size(75, 35);
            radRed.TabIndex = 3;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(31, 85);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(98, 35);
            radGreen.TabIndex = 0;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // grpFont
            // 
            grpFont.BackColor = Color.PeachPuff;
            grpFont.Controls.Add(chkUnderline);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFont.Location = new Point(390, 101);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(325, 231);
            grpFont.TabIndex = 3;
            grpFont.TabStop = false;
            grpFont.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.ForeColor = SystemColors.HotTrack;
            chkUnderline.Location = new Point(44, 167);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(143, 35);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = SystemColors.HotTrack;
            chkItalic.Location = new Point(44, 104);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(173, 35);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.ForeColor = SystemColors.HotTrack;
            chkBold.Location = new Point(44, 45);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(142, 35);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // lblTieuDeLapTrinh
            // 
            lblTieuDeLapTrinh.AutoSize = true;
            lblTieuDeLapTrinh.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDeLapTrinh.ForeColor = Color.Crimson;
            lblTieuDeLapTrinh.Location = new Point(66, 376);
            lblTieuDeLapTrinh.Name = "lblTieuDeLapTrinh";
            lblTieuDeLapTrinh.Size = new Size(161, 31);
            lblTieuDeLapTrinh.TabIndex = 4;
            lblTieuDeLapTrinh.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Location = new Point(223, 381);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(395, 25);
            lblLapTrinh.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(624, 368);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(91, 47);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDinhDang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(lblTieuDeLapTrinh);
            Controls.Add(grpFont);
            Controls.Add(grpColor);
            Controls.Add(txtNhapTen);
            Controls.Add(lblNhapTen);
            Name = "frmDinhDang";
            Text = "Định dạng (Formater)";
            Load += frmDinhDang_Load;
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private TextBox txtNhapTen;
        private GroupBox grpColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radRed;
        private RadioButton radGreen;
        private GroupBox grpFont;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label lblTieuDeLapTrinh;
        private Label lblLapTrinh;
        private Button btnThoat;
    }
}
