using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addUserControll(UserControl uc)
        {
            uc.Margin = new Padding(0);
            uc.Padding = new Padding(0);
            uc.Size = plContainer.Size;
            uc.Dock = DockStyle.Fill;
            plContainer.Controls.Clear();
            plContainer.Controls.Add(uc);
            plContainer.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UC_DonHang uc = new UC_DonHang();
            addUserControll(uc);
        }

        private void btnDanhMucSanPham_Click(object sender, EventArgs e)
        {
            UC_DanhMucSanPham uc = new UC_DanhMucSanPham();
            addUserControll(uc);
        }

        private void btnDanhMucKhachHang_Click(object sender, EventArgs e)
        {
            UC_DanhMucKhachHang uc = new UC_DanhMucKhachHang();
            addUserControll(uc);
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            UC_ThongKeDoanhThu uc = new UC_ThongKeDoanhThu();
            addUserControll(uc);
        }

        private void plContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
