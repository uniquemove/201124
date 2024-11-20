namespace MobileShop
{
    partial class UC_ThemSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textMaDonHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMaKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // textMaDonHang
            // 
            this.textMaDonHang.Location = new System.Drawing.Point(181, 74);
            this.textMaDonHang.Name = "textMaDonHang";
            this.textMaDonHang.Size = new System.Drawing.Size(202, 26);
            this.textMaDonHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textMaKhachHang
            // 
            this.textMaKhachHang.Location = new System.Drawing.Point(181, 145);
            this.textMaKhachHang.Name = "textMaKhachHang";
            this.textMaKhachHang.Size = new System.Drawing.Size(202, 26);
            this.textMaKhachHang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // textMaSanPham
            // 
            this.textMaSanPham.Location = new System.Drawing.Point(181, 219);
            this.textMaSanPham.Name = "textMaSanPham";
            this.textMaSanPham.Size = new System.Drawing.Size(202, 26);
            this.textMaSanPham.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng:";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(181, 284);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(202, 26);
            this.textSoLuong.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày mua";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 349);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(102, 445);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 32);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(244, 445);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // UC_ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMaSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMaKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMaDonHang);
            this.Controls.Add(this.label1);
            this.Name = "UC_ThemSanPham";
            this.Size = new System.Drawing.Size(449, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMaKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}
