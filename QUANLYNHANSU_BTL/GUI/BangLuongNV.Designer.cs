using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongNV : UserControl
    {
        private Guna2Panel pnlInfo;
        private Guna2PictureBox picAvatar;
        private Label lblTitle;
        private Label lblHoTen;
        private Label lblChucVu;
        private Label lblLuongCoBan;
        private Label lblPhuCapChucVu;
        private Label lblPhuCapKhac;
        private Label lblGhiChu;

        public BangLuongNV()
        {
            InitializeComponent();
        }
        public void CreateBangLuongNV()
        {
            InitializeComponent();  // Đảm bảo khởi tạo các thành phần UI
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangLuongNV));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlInfo = new Guna2Panel();
            panel1 = new Panel();
            picAvatar = new Guna2PictureBox();
            lblGhiChu = new Label();
            lblTitle = new Label();
            lblPhuCapKhac = new Label();
            lblHoTen = new Label();
            lblPhuCapChucVu = new Label();
            lblChucVu = new Label();
            lblLuongCoBan = new Label();
            pnlInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(panel1);
            pnlInfo.CustomizableEdges = customizableEdges3;
            pnlInfo.Location = new Point(0, 0);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlInfo.Size = new Size(1118, 905);
            pnlInfo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(picAvatar);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblPhuCapKhac);
            panel1.Controls.Add(lblHoTen);
            panel1.Controls.Add(lblPhuCapChucVu);
            panel1.Controls.Add(lblChucVu);
            panel1.Controls.Add(lblLuongCoBan);
            panel1.Location = new Point(243, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 490);
            panel1.TabIndex = 8;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.LightGray;
            picAvatar.CustomizableEdges = customizableEdges1;
            picAvatar.Image = (Image)resources.GetObject("picAvatar.Image");
            picAvatar.ImageRotate = 0F;
            picAvatar.Location = new Point(39, 103);
            picAvatar.Margin = new Padding(3, 4, 3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picAvatar.Size = new Size(171, 196);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Segoe UI", 10F);
            lblGhiChu.Location = new Point(216, 370);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(343, 36);
            lblGhiChu.TabIndex = 7;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(216, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(326, 53);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Bảng lương nhân viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhuCapKhac
            // 
            lblPhuCapKhac.Font = new Font("Segoe UI", 10F);
            lblPhuCapKhac.Location = new Point(216, 317);
            lblPhuCapKhac.Name = "lblPhuCapKhac";
            lblPhuCapKhac.Size = new Size(343, 36);
            lblPhuCapKhac.TabIndex = 6;
            lblPhuCapKhac.Text = "Phụ cấp khác:";
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(216, 103);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(343, 36);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblPhuCapChucVu
            // 
            lblPhuCapChucVu.Font = new Font("Segoe UI", 10F);
            lblPhuCapChucVu.Location = new Point(216, 263);
            lblPhuCapChucVu.Name = "lblPhuCapChucVu";
            lblPhuCapChucVu.Size = new Size(343, 36);
            lblPhuCapChucVu.TabIndex = 5;
            lblPhuCapChucVu.Text = "Phụ cấp chức vụ:";
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 10F);
            lblChucVu.Location = new Point(216, 157);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(352, 36);
            lblChucVu.TabIndex = 3;
            lblChucVu.Text = "Chức vụ:";
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.Font = new Font("Segoe UI", 10F);
            lblLuongCoBan.Location = new Point(216, 210);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(352, 36);
            lblLuongCoBan.TabIndex = 4;
            lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // BangLuongNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BangLuongNV";
            Size = new Size(1059, 905);
            pnlInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
    }
}
