using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace QUANLYNHANSU_BTL.GUI
{
    public partial class NhanVienPopup : Form
    {
        private Label lblTitle, lblMaNV, lblHoTen, lblCMND_CCCD, lblNgaySinh, lblSDT, lblGioiTinh, lblChucVu, lblLoaiNV, lblHocVan;
        private Guna2TextBox txtMaNV, txtHoTen, txtCMND_CCCD, txtSDT, txtHocVan;
        private Guna2DateTimePicker dtpNgaySinh;
        private Guna2ComboBox cmbGioiTinh, cmbChucVu, cmbLoaiNV;
        private Guna2Button btnLuu, btnHuy;

        public NhanVienPopup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            lblMaNV = new Label();
            txtMaNV = new Guna2TextBox();
            lblHoTen = new Label();
            txtHoTen = new Guna2TextBox();
            lblCMND_CCCD = new Label();
            txtCMND_CCCD = new Guna2TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new Guna2DateTimePicker();
            lblSDT = new Label();
            txtSDT = new Guna2TextBox();
            lblGioiTinh = new Label();
            cmbGioiTinh = new Guna2ComboBox();
            lblChucVu = new Label();
            cmbChucVu = new Guna2ComboBox();
            lblLoaiNV = new Label();
            cmbLoaiNV = new Guna2ComboBox();
            lblHocVan = new Label();
            txtHocVan = new Guna2TextBox();
            btnLuu = new Guna2Button();
            btnHuy = new Guna2Button();
            PhongBan = new Label();
            cmbPhongBan = new Guna2ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(86, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin nhân viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            lblMaNV.Location = new Point(12, 45);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(118, 23);
            lblMaNV.TabIndex = 1;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            txtMaNV.CustomizableEdges = customizableEdges1;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.Location = new Point(150, 45);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNV.Size = new Size(237, 32);
            txtMaNV.TabIndex = 2;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(12, 92);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(118, 23);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.CustomizableEdges = customizableEdges3;
            txtHoTen.DefaultText = "";
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(150, 85);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "";
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHoTen.Size = new Size(237, 32);
            txtHoTen.TabIndex = 4;
            // 
            // lblCMND_CCCD
            // 
            lblCMND_CCCD.Location = new Point(12, 135);
            lblCMND_CCCD.Name = "lblCMND_CCCD";
            lblCMND_CCCD.Size = new Size(98, 23);
            lblCMND_CCCD.TabIndex = 5;
            lblCMND_CCCD.Text = "CMND_CCCD/CCCD:";
            // 
            // txtCMND_CCCD
            // 
            txtCMND_CCCD.CustomizableEdges = customizableEdges5;
            txtCMND_CCCD.DefaultText = "";
            txtCMND_CCCD.Font = new Font("Segoe UI", 9F);
            txtCMND_CCCD.Location = new Point(150, 125);
            txtCMND_CCCD.Margin = new Padding(3, 4, 3, 4);
            txtCMND_CCCD.Name = "txtCMND_CCCD";
            txtCMND_CCCD.PlaceholderText = "";
            txtCMND_CCCD.SelectedText = "";
            txtCMND_CCCD.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCMND_CCCD.Size = new Size(237, 33);
            txtCMND_CCCD.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(12, 178);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(118, 23);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Checked = true;
            dtpNgaySinh.CustomizableEdges = customizableEdges7;
            dtpNgaySinh.Font = new Font("Segoe UI", 9F);
            dtpNgaySinh.Format = DateTimePickerFormat.Long;
            dtpNgaySinh.Location = new Point(150, 165);
            dtpNgaySinh.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpNgaySinh.Size = new Size(237, 36);
            dtpNgaySinh.TabIndex = 8;
            dtpNgaySinh.Value = new DateTime(2025, 3, 21, 23, 49, 23, 448);
            // 
            // lblSDT
            // 
            lblSDT.Location = new Point(12, 213);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(118, 23);
            lblSDT.TabIndex = 9;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.CustomizableEdges = customizableEdges9;
            txtSDT.DefaultText = "";
            txtSDT.Font = new Font("Segoe UI", 9F);
            txtSDT.Location = new Point(150, 205);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "";
            txtSDT.SelectedText = "";
            txtSDT.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSDT.Size = new Size(237, 33);
            txtSDT.TabIndex = 10;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(12, 253);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(118, 23);
            lblGioiTinh.TabIndex = 11;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.BackColor = Color.Transparent;
            cmbGioiTinh.CustomizableEdges = customizableEdges11;
            cmbGioiTinh.DrawMode = DrawMode.OwnerDrawFixed;
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.FocusedColor = Color.Empty;
            cmbGioiTinh.Font = new Font("Segoe UI", 10F);
            cmbGioiTinh.ForeColor = Color.FromArgb(68, 88, 112);
            cmbGioiTinh.ItemHeight = 30;
            cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cmbGioiTinh.Location = new Point(150, 245);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbGioiTinh.Size = new Size(237, 36);
            cmbGioiTinh.TabIndex = 12;
            // 
            // lblChucVu
            // 
            lblChucVu.Location = new Point(12, 292);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(118, 23);
            lblChucVu.TabIndex = 13;
            lblChucVu.Text = "Chức vụ:";
            // 
            // cmbChucVu
            // 
            cmbChucVu.BackColor = Color.Transparent;
            cmbChucVu.CustomizableEdges = customizableEdges13;
            cmbChucVu.DrawMode = DrawMode.OwnerDrawFixed;
            cmbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChucVu.FocusedColor = Color.Empty;
            cmbChucVu.Font = new Font("Segoe UI", 10F);
            cmbChucVu.ForeColor = Color.FromArgb(68, 88, 112);
            cmbChucVu.ItemHeight = 30;
            cmbChucVu.Items.AddRange(new object[] { "Giám đốc công nghệ (CTO)", "Trưởng phòng kỹ thuật (Tech Lead)", "Kiến trúc sư phần mềm (Software Architect)", "Trưởng nhóm phát triển (Team Leader)", "Lập trình viên Backend (Backend Developer)", "Lập trình viên Frontend (Frontend Developer)", "Lập trình viên Fullstack (Fullstack Developer)", "Kiểm thử phần mềm (QA/QC Tester)", "DevOps Engineer" });
            cmbChucVu.Location = new Point(150, 285);
            cmbChucVu.Name = "cmbChucVu";
            cmbChucVu.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cmbChucVu.Size = new Size(237, 36);
            cmbChucVu.TabIndex = 14;
            // 
            // lblLoaiNV
            // 
            lblLoaiNV.Location = new Point(12, 335);
            lblLoaiNV.Name = "lblLoaiNV";
            lblLoaiNV.Size = new Size(118, 23);
            lblLoaiNV.TabIndex = 15;
            lblLoaiNV.Text = "Loại nhân viên:";
            // 
            // cmbLoaiNV
            // 
            cmbLoaiNV.BackColor = Color.Transparent;
            cmbLoaiNV.CustomizableEdges = customizableEdges15;
            cmbLoaiNV.DrawMode = DrawMode.OwnerDrawFixed;
            cmbLoaiNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiNV.FocusedColor = Color.Empty;
            cmbLoaiNV.Font = new Font("Segoe UI", 10F);
            cmbLoaiNV.ForeColor = Color.FromArgb(68, 88, 112);
            cmbLoaiNV.ItemHeight = 30;
            cmbLoaiNV.Location = new Point(150, 325);
            cmbLoaiNV.Name = "cmbLoaiNV";
            cmbLoaiNV.ShadowDecoration.CustomizableEdges = customizableEdges16;
            cmbLoaiNV.Size = new Size(237, 36);
            cmbLoaiNV.TabIndex = 16;
            // 
            // lblHocVan
            // 
            lblHocVan.Location = new Point(12, 375);
            lblHocVan.Name = "lblHocVan";
            lblHocVan.Size = new Size(118, 23);
            lblHocVan.TabIndex = 17;
            lblHocVan.Text = "Học vấn:";
            // 
            // txtHocVan
            // 
            txtHocVan.CustomizableEdges = customizableEdges17;
            txtHocVan.DefaultText = "";
            txtHocVan.Font = new Font("Segoe UI", 9F);
            txtHocVan.Location = new Point(150, 365);
            txtHocVan.Margin = new Padding(3, 4, 3, 4);
            txtHocVan.Name = "txtHocVan";
            txtHocVan.PlaceholderText = "";
            txtHocVan.SelectedText = "";
            txtHocVan.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtHocVan.Size = new Size(237, 38);
            txtHocVan.TabIndex = 18;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 10;
            btnLuu.CustomizableEdges = customizableEdges19;
            btnLuu.FillColor = Color.SeaGreen;
            btnLuu.Font = new Font("Segoe UI", 9F);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(38, 474);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnLuu.Size = new Size(120, 40);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.Click += BtnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BorderRadius = 10;
            btnHuy.CustomizableEdges = customizableEdges21;
            btnHuy.FillColor = Color.IndianRed;
            btnHuy.Font = new Font("Segoe UI", 9F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(230, 474);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnHuy.Size = new Size(120, 40);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.Click += BtnHuy_Click;
            // 
            // PhongBan
            // 
            PhongBan.Location = new Point(12, 416);
            PhongBan.Name = "PhongBan";
            PhongBan.Size = new Size(118, 23);
            PhongBan.TabIndex = 21;
            PhongBan.Text = "Phòng ban ";
            // 
            // cmbPhongBan
            // 
            cmbPhongBan.BackColor = Color.Transparent;
            cmbPhongBan.CustomizableEdges = customizableEdges23;
            cmbPhongBan.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhongBan.FocusedColor = Color.Empty;
            cmbPhongBan.Font = new Font("Segoe UI", 10F);
            cmbPhongBan.ForeColor = Color.FromArgb(68, 88, 112);
            cmbPhongBan.ItemHeight = 30;
            cmbPhongBan.Location = new Point(150, 416);
            cmbPhongBan.Name = "cmbPhongBan";
            cmbPhongBan.ShadowDecoration.CustomizableEdges = customizableEdges24;
            cmbPhongBan.Size = new Size(237, 36);
            cmbPhongBan.TabIndex = 22;
            // 
            // NhanVienPopup
            // 
            BackColor = Color.White;
            ClientSize = new Size(426, 526);
            Controls.Add(cmbPhongBan);
            Controls.Add(PhongBan);
            Controls.Add(lblTitle);
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblCMND_CCCD);
            Controls.Add(txtCMND_CCCD);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(lblGioiTinh);
            Controls.Add(cmbGioiTinh);
            Controls.Add(lblChucVu);
            Controls.Add(cmbChucVu);
            Controls.Add(lblLoaiNV);
            Controls.Add(cmbLoaiNV);
            Controls.Add(lblHocVan);
            Controls.Add(txtHocVan);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienPopup";
            Text = "Thông tin nhân viên";
            Load += NhanVienPopup_Load;
            ResumeLayout(false);
        }

        private Label PhongBan;
        private Guna2ComboBox cmbPhongBan;
    }
}
