using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;  // Đảm bảo bạn đã thêm FontAwesome vào dự án của mình

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ThongTinNVForm : Form
    {
        private Guna2Panel pnlInfo;
        private Guna2PictureBox picAvatar;
        private IconButton btnChonAnh; // Thay Guna2Button bằng IconButton
        private Label lblTitle;
        private Label lblTenNV;
        private Label lblPhongBan;
        private Label lblNgaySinh;
        private Label lblCMND;
        private Label lblGioiTinh;
        private Label lblChucVu;
        private Label lblSDT;
        private Label lblLoaiNV;
        private Label lblHocVan;

        public ThongTinNVForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlInfo = new Guna2Panel();
            panel1 = new Panel();
            lblCMND = new Label();
            picAvatar = new Guna2PictureBox();
            lblTenNV = new Label();
            lblTitle = new Label();
            lblSDT = new Label();
            lblLoaiNV = new Label();
            lblChucVu = new Label();
            btnChonAnh = new IconButton();
            lblNgaySinh = new Label();
            lblPhongBan = new Label();
            lblGioiTinh = new Label();
            lblHocVan = new Label();
            pnlInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(panel1);
            pnlInfo.Controls.Add(lblHocVan);
            pnlInfo.CustomizableEdges = customizableEdges3;
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(0, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlInfo.Size = new Size(927, 679);
            pnlInfo.TabIndex = 0;
            pnlInfo.Paint += pnlInfo_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCMND);
            panel1.Controls.Add(picAvatar);
            panel1.Controls.Add(lblTenNV);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblSDT);
            panel1.Controls.Add(lblLoaiNV);
            panel1.Controls.Add(lblChucVu);
            panel1.Controls.Add(btnChonAnh);
            panel1.Controls.Add(lblNgaySinh);
            panel1.Controls.Add(lblPhongBan);
            panel1.Controls.Add(lblGioiTinh);
            panel1.Location = new Point(222, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 488);
            panel1.TabIndex = 11;
            // 
            // lblCMND
            // 
            lblCMND.Font = new Font("Segoe UI", 10F);
            lblCMND.Location = new Point(149, 206);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(385, 27);
            lblCMND.TabIndex = 5;
            lblCMND.Text = "CMND:";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.White;
            picAvatar.CustomizableEdges = customizableEdges1;
            picAvatar.FillColor = Color.LightGray;
            picAvatar.ImageRotate = 0F;
            picAvatar.Location = new Point(3, 86);
            picAvatar.Name = "picAvatar";
            picAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picAvatar.Size = new Size(140, 191);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // lblTenNV
            // 
            lblTenNV.Font = new Font("Segoe UI", 10F);
            lblTenNV.Location = new Point(149, 86);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(385, 27);
            lblTenNV.TabIndex = 2;
            lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(149, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thông tin nhân viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 10F);
            lblSDT.Location = new Point(149, 326);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(385, 27);
            lblSDT.TabIndex = 8;
            lblSDT.Text = "SĐT:";
            // 
            // lblLoaiNV
            // 
            lblLoaiNV.Font = new Font("Segoe UI", 10F);
            lblLoaiNV.Location = new Point(149, 366);
            lblLoaiNV.Name = "lblLoaiNV";
            lblLoaiNV.Size = new Size(385, 27);
            lblLoaiNV.TabIndex = 9;
            lblLoaiNV.Text = "Loại nhân viên:";
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 10F);
            lblChucVu.Location = new Point(149, 286);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(385, 27);
            lblChucVu.TabIndex = 7;
            lblChucVu.Text = "Chức vụ:";
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.FromArgb(0, 204, 102);
            btnChonAnh.Font = new Font("Segoe UI", 9F);
            btnChonAnh.ForeColor = Color.White;
            btnChonAnh.IconChar = IconChar.FolderOpen;
            btnChonAnh.IconColor = Color.White;
            btnChonAnh.IconFont = IconFont.Auto;
            btnChonAnh.IconSize = 20;
            btnChonAnh.Location = new Point(12, 286);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(120, 37);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.TextAlign = ContentAlignment.MiddleRight;
            btnChonAnh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.Location = new Point(149, 166);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(385, 27);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblPhongBan
            // 
            lblPhongBan.Font = new Font("Segoe UI", 10F);
            lblPhongBan.Location = new Point(149, 126);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(385, 27);
            lblPhongBan.TabIndex = 3;
            lblPhongBan.Text = "Phòng ban:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Font = new Font("Segoe UI", 10F);
            lblGioiTinh.Location = new Point(149, 246);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(385, 27);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblHocVan
            // 
            lblHocVan.Font = new Font("Segoe UI", 10F);
            lblHocVan.Location = new Point(242, 882);
            lblHocVan.Name = "lblHocVan";
            lblHocVan.Size = new Size(385, 27);
            lblHocVan.TabIndex = 10;
            lblHocVan.Text = "Học vấn:";
            // 
            // ThongTinNVForm
            // 
            ClientSize = new Size(927, 679);
            Controls.Add(pnlInfo);
            Name = "ThongTinNVForm";
            Text = "Thông tin cá nhân";
            pnlInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
    }
}
