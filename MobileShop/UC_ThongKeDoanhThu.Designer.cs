namespace MobileShop
{
    partial class UC_ThongKeDoanhThu
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoaiThoiGian = new System.Windows.Forms.Label();
            this.cbLoaiThoiGian = new System.Windows.Forms.ComboBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê doanh thu";
            // 
            // lblLoaiThoiGian
            // 
            this.lblLoaiThoiGian.AutoSize = true;
            this.lblLoaiThoiGian.Location = new System.Drawing.Point(49, 87);
            this.lblLoaiThoiGian.Name = "lblLoaiThoiGian";
            this.lblLoaiThoiGian.Size = new System.Drawing.Size(103, 20);
            this.lblLoaiThoiGian.TabIndex = 2;
            this.lblLoaiThoiGian.Text = "Loại thời gian";
            // 
            // cbLoaiThoiGian
            // 
            this.cbLoaiThoiGian.FormattingEnabled = true;
            this.cbLoaiThoiGian.Items.AddRange(new object[] {
            "Báo cáo theo ngày",
            "Báo cáo theo tháng",
            "Báo cáo theo quý"});
            this.cbLoaiThoiGian.Location = new System.Drawing.Point(188, 84);
            this.cbLoaiThoiGian.Name = "cbLoaiThoiGian";
            this.cbLoaiThoiGian.Size = new System.Drawing.Size(163, 28);
            this.cbLoaiThoiGian.TabIndex = 3;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(49, 144);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(103, 20);
            this.lblNgayBatDau.TabIndex = 4;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(188, 138);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayBatDau.TabIndex = 5;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(49, 201);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(106, 20);
            this.lblNgayKetThuc.TabIndex = 6;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(188, 201);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(52, 257);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 42);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // UC_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.cbLoaiThoiGian);
            this.Controls.Add(this.lblLoaiThoiGian);
            this.Controls.Add(this.label2);
            this.Name = "UC_ThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1053, 579);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoaiThoiGian;
        private System.Windows.Forms.ComboBox cbLoaiThoiGian;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
