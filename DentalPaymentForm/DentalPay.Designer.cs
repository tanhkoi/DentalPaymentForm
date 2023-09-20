namespace DentalPayment
{
    partial class DentalPay
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            nudTramRang = new NumericUpDown();
            lblGiaChupHinhRang = new Label();
            label7 = new Label();
            lblGiaTramRang = new Label();
            lblGiaTayTrang = new Label();
            lblGiaCaoVoi = new Label();
            ckbChupHinhRang = new CheckBox();
            ckbTayTrang = new CheckBox();
            ckbCaoVoi = new CheckBox();
            txtTenKhach = new TextBox();
            label8 = new Label();
            txtTongTien = new TextBox();
            btnTinhTien = new Button();
            btnThoat = new Button();
            lsvDanhSach = new ListView();
            hoten = new ColumnHeader();
            tien = new ColumnHeader();
            btnSuaGiaTien = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTramRang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 60);
            label1.TabIndex = 0;
            label1.Text = "Dental Payment Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 82);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Ten khach";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudTramRang);
            groupBox1.Controls.Add(lblGiaChupHinhRang);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblGiaTramRang);
            groupBox1.Controls.Add(lblGiaTayTrang);
            groupBox1.Controls.Add(lblGiaCaoVoi);
            groupBox1.Controls.Add(ckbChupHinhRang);
            groupBox1.Controls.Add(ckbTayTrang);
            groupBox1.Controls.Add(ckbCaoVoi);
            groupBox1.Location = new Point(54, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 265);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dich vu";
            // 
            // nudTramRang
            // 
            nudTramRang.Location = new Point(134, 191);
            nudTramRang.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudTramRang.Name = "nudTramRang";
            nudTramRang.Size = new Size(167, 31);
            nudTramRang.TabIndex = 4;
            // 
            // lblGiaChupHinhRang
            // 
            lblGiaChupHinhRang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGiaChupHinhRang.AutoSize = true;
            lblGiaChupHinhRang.Location = new Point(324, 126);
            lblGiaChupHinhRang.Name = "lblGiaChupHinhRang";
            lblGiaChupHinhRang.Size = new Size(76, 25);
            lblGiaChupHinhRang.TabIndex = 1;
            lblGiaChupHinhRang.Text = "200.000";
            lblGiaChupHinhRang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 191);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 1;
            label7.Text = "Tram rang";
            // 
            // lblGiaTramRang
            // 
            lblGiaTramRang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGiaTramRang.AutoSize = true;
            lblGiaTramRang.Location = new Point(324, 197);
            lblGiaTramRang.Name = "lblGiaTramRang";
            lblGiaTramRang.Size = new Size(94, 25);
            lblGiaTramRang.TabIndex = 1;
            lblGiaTramRang.Text = "80.000/cai";
            lblGiaTramRang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGiaTayTrang
            // 
            lblGiaTayTrang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGiaTayTrang.AutoSize = true;
            lblGiaTayTrang.Location = new Point(324, 86);
            lblGiaTayTrang.Name = "lblGiaTayTrang";
            lblGiaTayTrang.RightToLeft = RightToLeft.No;
            lblGiaTayTrang.Size = new Size(90, 25);
            lblGiaTayTrang.TabIndex = 1;
            lblGiaTayTrang.Text = "1.200.000";
            lblGiaTayTrang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGiaCaoVoi
            // 
            lblGiaCaoVoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGiaCaoVoi.AutoSize = true;
            lblGiaCaoVoi.Location = new Point(324, 48);
            lblGiaCaoVoi.Name = "lblGiaCaoVoi";
            lblGiaCaoVoi.Size = new Size(76, 25);
            lblGiaCaoVoi.TabIndex = 1;
            lblGiaCaoVoi.Text = "100.000";
            lblGiaCaoVoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbChupHinhRang
            // 
            ckbChupHinhRang.AutoSize = true;
            ckbChupHinhRang.Location = new Point(33, 125);
            ckbChupHinhRang.Name = "ckbChupHinhRang";
            ckbChupHinhRang.Size = new Size(160, 29);
            ckbChupHinhRang.TabIndex = 3;
            ckbChupHinhRang.Text = "Chup hinh rang";
            ckbChupHinhRang.UseVisualStyleBackColor = true;
            // 
            // ckbTayTrang
            // 
            ckbTayTrang.AutoSize = true;
            ckbTayTrang.Location = new Point(33, 86);
            ckbTayTrang.Name = "ckbTayTrang";
            ckbTayTrang.Size = new Size(111, 29);
            ckbTayTrang.TabIndex = 2;
            ckbTayTrang.Text = "Tay Trang";
            ckbTayTrang.UseVisualStyleBackColor = true;
            // 
            // ckbCaoVoi
            // 
            ckbCaoVoi.AutoSize = true;
            ckbCaoVoi.Location = new Point(33, 44);
            ckbCaoVoi.Name = "ckbCaoVoi";
            ckbCaoVoi.Size = new Size(99, 29);
            ckbCaoVoi.TabIndex = 1;
            ckbCaoVoi.Text = "Cao Voi";
            ckbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(149, 76);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(342, 31);
            txtTenKhach.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 403);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 1;
            label8.Text = "Tong Tien";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(219, 397);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(271, 31);
            txtTongTien.TabIndex = 10;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(219, 469);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(112, 34);
            btnTinhTien.TabIndex = 5;
            btnTinhTien.Text = "Tinh tien";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(378, 469);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.Columns.AddRange(new ColumnHeader[] { hoten, tien });
            lsvDanhSach.GridLines = true;
            lsvDanhSach.Location = new Point(617, 123);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(422, 326);
            lsvDanhSach.TabIndex = 5;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            lsvDanhSach.View = View.Details;
            // 
            // hoten
            // 
            hoten.Text = "Ho ten";
            hoten.Width = 250;
            // 
            // tien
            // 
            tien.Text = "Tien";
            tien.Width = 150;
            // 
            // btnSuaGiaTien
            // 
            btnSuaGiaTien.Location = new Point(889, 469);
            btnSuaGiaTien.Name = "btnSuaGiaTien";
            btnSuaGiaTien.Size = new Size(150, 34);
            btnSuaGiaTien.TabIndex = 7;
            btnSuaGiaTien.Text = "Sua Gia Dich Vu";
            btnSuaGiaTien.UseVisualStyleBackColor = true;
            btnSuaGiaTien.Click += btnSuaGiaTien_Click;
            // 
            // DentalPay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 538);
            Controls.Add(btnSuaGiaTien);
            Controls.Add(lsvDanhSach);
            Controls.Add(btnThoat);
            Controls.Add(btnTinhTien);
            Controls.Add(txtTongTien);
            Controls.Add(txtTenKhach);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "DentalPay";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTramRang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private NumericUpDown nudTramRang;
        private Label lblGiaChupHinhRang;
        private Label label7;
        private Label lblGiaTramRang;
        private Label lblGiaTayTrang;
        private Label lblGiaCaoVoi;
        private CheckBox ckbChupHinhRang;
        private CheckBox ckbTayTrang;
        private CheckBox ckbCaoVoi;
        private TextBox txtTenKhach;
        private Label label8;
        private TextBox txtTongTien;
        private Button btnTinhTien;
        private Button btnThoat;
        private ListView lsvDanhSach;
        private ColumnHeader hoten;
        private ColumnHeader tien;
        private Button btnSuaGiaTien;
    }
}