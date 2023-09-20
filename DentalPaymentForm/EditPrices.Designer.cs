namespace DentalPaymentForm
{
    partial class EditPrices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSuaCaoVoi = new TextBox();
            txtSuaTayTrang = new TextBox();
            txtSuaChupHinh = new TextBox();
            txtSuaTramRang = new TextBox();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(424, 74);
            label1.TabIndex = 0;
            label1.Text = "Sua Gia Dich Vu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 108);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 0;
            label2.Text = "Cao Voi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 158);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 0;
            label3.Text = "Tay Trang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 207);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 0;
            label4.Text = "Chup Hinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 260);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 0;
            label5.Text = "Tram Rang";
            // 
            // txtSuaCaoVoi
            // 
            txtSuaCaoVoi.Location = new Point(224, 108);
            txtSuaCaoVoi.Name = "txtSuaCaoVoi";
            txtSuaCaoVoi.Size = new Size(150, 31);
            txtSuaCaoVoi.TabIndex = 0;
            txtSuaCaoVoi.KeyPress += txtSuaCaoVoi_KeyPress;
            // 
            // txtSuaTayTrang
            // 
            txtSuaTayTrang.Location = new Point(224, 158);
            txtSuaTayTrang.Name = "txtSuaTayTrang";
            txtSuaTayTrang.Size = new Size(150, 31);
            txtSuaTayTrang.TabIndex = 1;
            txtSuaTayTrang.KeyPress += txtSuaTayTrang_KeyPress;
            // 
            // txtSuaChupHinh
            // 
            txtSuaChupHinh.Location = new Point(224, 207);
            txtSuaChupHinh.Name = "txtSuaChupHinh";
            txtSuaChupHinh.Size = new Size(150, 31);
            txtSuaChupHinh.TabIndex = 2;
            txtSuaChupHinh.KeyPress += txtSuaChupHinh_KeyPress;
            // 
            // txtSuaTramRang
            // 
            txtSuaTramRang.Location = new Point(224, 260);
            txtSuaTramRang.Name = "txtSuaTramRang";
            txtSuaTramRang.Size = new Size(150, 31);
            txtSuaTramRang.TabIndex = 3;
            txtSuaTramRang.KeyPress += txtSuaTramRang_KeyPress;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(262, 323);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // EditPrices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 409);
            Controls.Add(btnLuu);
            Controls.Add(txtSuaTramRang);
            Controls.Add(txtSuaChupHinh);
            Controls.Add(txtSuaTayTrang);
            Controls.Add(txtSuaCaoVoi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditPrices";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSuaCaoVoi;
        private TextBox txtSuaTayTrang;
        private TextBox txtSuaChupHinh;
        private TextBox txtSuaTramRang;
        private Button btnLuu;
    }
}