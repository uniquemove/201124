namespace MobileShop
{
    partial class UC_DonHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.lblNhapMa = new System.Windows.Forms.Label();
            this.textNhapMa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaDonHang,
            this.cMaKhachHang,
            this.cMaSanPham,
            this.cSoLuong,
            this.cNgayMua});
            this.dataGridView1.Location = new System.Drawing.Point(20, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 328);
            this.dataGridView1.TabIndex = 1;
            // 
            // cMaDonHang
            // 
            this.cMaDonHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cMaDonHang.HeaderText = "Mã đơn hàng";
            this.cMaDonHang.MinimumWidth = 8;
            this.cMaDonHang.Name = "cMaDonHang";
            this.cMaDonHang.ReadOnly = true;
            this.cMaDonHang.Width = 150;
            // 
            // cMaKhachHang
            // 
            this.cMaKhachHang.HeaderText = "Mã khách hàng";
            this.cMaKhachHang.MinimumWidth = 8;
            this.cMaKhachHang.Name = "cMaKhachHang";
            this.cMaKhachHang.ReadOnly = true;
            this.cMaKhachHang.Width = 150;
            // 
            // cMaSanPham
            // 
            this.cMaSanPham.HeaderText = "Mã sản phẩm";
            this.cMaSanPham.MinimumWidth = 8;
            this.cMaSanPham.Name = "cMaSanPham";
            this.cMaSanPham.ReadOnly = true;
            this.cMaSanPham.Width = 150;
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số lượng";
            this.cSoLuong.MinimumWidth = 8;
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.ReadOnly = true;
            this.cSoLuong.Width = 150;
            // 
            // cNgayMua
            // 
            this.cNgayMua.HeaderText = "Ngày mua";
            this.cNgayMua.MinimumWidth = 8;
            this.cNgayMua.Name = "cNgayMua";
            this.cNgayMua.ReadOnly = true;
            this.cNgayMua.Width = 150;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(254, 87);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(162, 20);
            this.lblTheLoai.TabIndex = 2;
            this.lblTheLoai.Text = "Tìm kiếm theo thể loại";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Items.AddRange(new object[] {
            "---Chọn loại---",
            "Mã đơn hàng",
            "Mã khách hàng",
            "Mã sản phẩm"});
            this.cbTheLoai.Location = new System.Drawing.Point(422, 84);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(171, 28);
            this.cbTheLoai.TabIndex = 3;
            // 
            // lblNhapMa
            // 
            this.lblNhapMa.AutoSize = true;
            this.lblNhapMa.Location = new System.Drawing.Point(254, 143);
            this.lblNhapMa.Name = "lblNhapMa";
            this.lblNhapMa.Size = new System.Drawing.Size(81, 20);
            this.lblNhapMa.TabIndex = 4;
            this.lblNhapMa.Text = "Nhập mã :";
            // 
            // textNhapMa
            // 
            this.textNhapMa.Location = new System.Drawing.Point(422, 143);
            this.textNhapMa.Name = "textNhapMa";
            this.textNhapMa.Size = new System.Drawing.Size(171, 26);
            this.textNhapMa.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(647, 140);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 33);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(900, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UC_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.textNhapMa);
            this.Controls.Add(this.lblNhapMa);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_DonHang";
            this.Size = new System.Drawing.Size(1053, 579);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayMua;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Label lblNhapMa;
        private System.Windows.Forms.TextBox textNhapMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button button1;
    }
}
