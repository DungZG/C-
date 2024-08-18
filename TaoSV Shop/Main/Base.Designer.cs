namespace TaoSV_Shop.Main
{
    partial class Base
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelContainer = new Panel();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnBaoCaoThongKe = new Guna.UI2.WinForms.Guna2Button();
            btnSanPham = new Guna.UI2.WinForms.Guna2Button();
            btnBanHang = new Guna.UI2.WinForms.Guna2Button();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelContainers = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 218, 24);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 64);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(panelContainer);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnKhachHang);
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(btnBaoCaoThongKe);
            panel2.Controls.Add(btnSanPham);
            panel2.Controls.Add(btnBanHang);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 64);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 682);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(191, 3);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(830, 535);
            panelContainer.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BorderColor = Color.Transparent;
            btnThoat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnThoat.CustomImages.Image = (Image)resources.GetObject("resource.Image");
            btnThoat.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnThoat.CustomImages.ImageSize = new Size(30, 30);
            btnThoat.CustomizableEdges = customizableEdges1;
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.FillColor = Color.Transparent;
            btnThoat.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.WhiteSmoke;
            btnThoat.ImageAlign = HorizontalAlignment.Right;
            btnThoat.Location = new Point(-1, 625);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThoat.Size = new Size(192, 57);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "THOÁT";
            btnThoat.TextAlign = HorizontalAlignment.Right;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Transparent;
            btnKhachHang.BorderColor = Color.Transparent;
            btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnKhachHang.CheckedState.CustomBorderColor = Color.OrangeRed;
            btnKhachHang.CustomBorderThickness = new Padding(4, 0, 0, 0);
            btnKhachHang.CustomImages.Image = (Image)resources.GetObject("resource.Image1");
            btnKhachHang.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnKhachHang.CustomImages.ImageSize = new Size(30, 30);
            btnKhachHang.CustomizableEdges = customizableEdges3;
            btnKhachHang.DisabledState.BorderColor = Color.DarkGray;
            btnKhachHang.DisabledState.CustomBorderColor = Color.DarkGray;
            btnKhachHang.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnKhachHang.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnKhachHang.FillColor = Color.Transparent;
            btnKhachHang.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.WhiteSmoke;
            btnKhachHang.HoverState.CustomBorderColor = Color.Transparent;
            btnKhachHang.ImageAlign = HorizontalAlignment.Right;
            btnKhachHang.Location = new Point(0, 0);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.ShadowDecoration.Color = Color.Transparent;
            btnKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnKhachHang.Size = new Size(191, 57);
            btnKhachHang.TabIndex = 24;
            btnKhachHang.Text = "  KHÁCH HÀNG";
            btnKhachHang.TextAlign = HorizontalAlignment.Right;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.CheckedState.CustomBorderColor = Color.OrangeRed;
            guna2Button1.CustomBorderThickness = new Padding(4, 0, 0, 0);
            guna2Button1.CustomImages.Image = (Image)resources.GetObject("resource.Image2");
            guna2Button1.CustomImages.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.CustomImages.ImageSize = new Size(35, 35);
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.WhiteSmoke;
            guna2Button1.HoverState.CustomBorderColor = Color.Transparent;
            guna2Button1.ImageAlign = HorizontalAlignment.Right;
            guna2Button1.Location = new Point(0, 221);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(191, 57);
            guna2Button1.TabIndex = 22;
            guna2Button1.Text = "GIỚI THIỆU";
            guna2Button1.TextAlign = HorizontalAlignment.Right;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnBaoCaoThongKe
            // 
            btnBaoCaoThongKe.BackColor = Color.Transparent;
            btnBaoCaoThongKe.BorderColor = Color.Transparent;
            btnBaoCaoThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBaoCaoThongKe.CheckedState.CustomBorderColor = Color.OrangeRed;
            btnBaoCaoThongKe.CustomBorderThickness = new Padding(4, 0, 0, 0);
            btnBaoCaoThongKe.CustomImages.Image = (Image)resources.GetObject("resource.Image3");
            btnBaoCaoThongKe.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnBaoCaoThongKe.CustomImages.ImageSize = new Size(30, 30);
            btnBaoCaoThongKe.CustomizableEdges = customizableEdges7;
            btnBaoCaoThongKe.DisabledState.BorderColor = Color.DarkGray;
            btnBaoCaoThongKe.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBaoCaoThongKe.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBaoCaoThongKe.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBaoCaoThongKe.FillColor = Color.Transparent;
            btnBaoCaoThongKe.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCaoThongKe.ForeColor = Color.WhiteSmoke;
            btnBaoCaoThongKe.HoverState.CustomBorderColor = Color.Transparent;
            btnBaoCaoThongKe.ImageAlign = HorizontalAlignment.Right;
            btnBaoCaoThongKe.Location = new Point(0, 167);
            btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            btnBaoCaoThongKe.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBaoCaoThongKe.Size = new Size(191, 54);
            btnBaoCaoThongKe.TabIndex = 19;
            btnBaoCaoThongKe.Text = "    BÁO CÁO  THỐNG KÊ";
            btnBaoCaoThongKe.TextAlign = HorizontalAlignment.Right;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Transparent;
            btnSanPham.BorderColor = Color.Transparent;
            btnSanPham.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnSanPham.CheckedState.CustomBorderColor = Color.OrangeRed;
            btnSanPham.CustomBorderThickness = new Padding(4, 0, 0, 0);
            btnSanPham.CustomImages.Image = (Image)resources.GetObject("resource.Image4");
            btnSanPham.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnSanPham.CustomImages.ImageSize = new Size(30, 30);
            btnSanPham.CustomizableEdges = customizableEdges9;
            btnSanPham.DisabledState.BorderColor = Color.DarkGray;
            btnSanPham.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSanPham.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSanPham.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSanPham.FillColor = Color.Transparent;
            btnSanPham.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSanPham.ForeColor = Color.WhiteSmoke;
            btnSanPham.HoverState.CustomBorderColor = Color.Transparent;
            btnSanPham.ImageAlign = HorizontalAlignment.Right;
            btnSanPham.Location = new Point(0, 110);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSanPham.Size = new Size(191, 57);
            btnSanPham.TabIndex = 18;
            btnSanPham.Text = "SẢN PHẨM";
            btnSanPham.TextAlign = HorizontalAlignment.Right;
            btnSanPham.Click += btnKhoHang_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.Transparent;
            btnBanHang.BorderColor = Color.Transparent;
            btnBanHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBanHang.CheckedState.CustomBorderColor = Color.OrangeRed;
            btnBanHang.CustomBorderThickness = new Padding(4, 0, 0, 0);
            btnBanHang.CustomImages.Image = (Image)resources.GetObject("resource.Image5");
            btnBanHang.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnBanHang.CustomImages.ImageSize = new Size(30, 30);
            btnBanHang.CustomizableEdges = customizableEdges11;
            btnBanHang.DisabledState.BorderColor = Color.DarkGray;
            btnBanHang.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBanHang.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBanHang.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBanHang.FillColor = Color.Transparent;
            btnBanHang.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBanHang.ForeColor = Color.WhiteSmoke;
            btnBanHang.HoverState.CustomBorderColor = Color.Transparent;
            btnBanHang.ImageAlign = HorizontalAlignment.Right;
            btnBanHang.Location = new Point(0, 56);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnBanHang.Size = new Size(191, 57);
            btnBanHang.TabIndex = 17;
            btnBanHang.Text = "BÁN HÀNG";
            btnBanHang.TextAlign = HorizontalAlignment.Right;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = panel1;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelContainers
            // 
            panelContainers.BackColor = Color.White;
            panelContainers.Dock = DockStyle.Fill;
            panelContainers.Location = new Point(191, 64);
            panelContainers.Margin = new Padding(3, 2, 3, 2);
            panelContainers.Name = "panelContainers";
            panelContainers.Size = new Size(1089, 682);
            panelContainers.TabIndex = 2;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 746);
            Controls.Add(panelContainers);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Base";
            Text = "Base";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnBanHang;
        private Guna.UI2.WinForms.Guna2Button btnSanPham;
        private Guna.UI2.WinForms.Guna2Button btnBaoCaoThongKe;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private PictureBox pictureBox1;
        private Panel panelContainer;
        private Panel panelContainers;
    }
}