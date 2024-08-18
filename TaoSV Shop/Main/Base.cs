using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoSV_Shop.Main
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
            UC_GioiThieu uc = new UC_GioiThieu();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainers.Controls.Clear();
            panelContainers.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            UC_KhachHang uc = new UC_KhachHang();
            addUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_GioiThieu uc = new UC_GioiThieu();
            addUserControl(uc);
        }

       

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            UC_BanHang uc = new UC_BanHang();
            addUserControl(uc);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            UC_SanPham uc = new UC_SanPham();
            addUserControl(uc);
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            UC_BCTK uc = new UC_BCTK();
            addUserControl (uc);
        }
    }
}
