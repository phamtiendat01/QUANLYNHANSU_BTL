using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangTinhLuongPopup : Form
    {
        private Guna2TextBox txtMaNV;
        private Guna2TextBox txtHoTen;
        private Guna2TextBox txtChucVu;
        private Guna2TextBox txtSoNgayCong;
        private Guna2TextBox txtSoNgayOT;
        private Guna2TextBox txtLuongCoBan;
        private Guna2TextBox txtPhuCapChucVu;
        private Guna2TextBox txtPhuCapKhac;
        private Guna2TextBox txtTienLuongOT;
        private Guna2TextBox txtTienPhat;
        private Guna2TextBox txtTongLuong;
        private Guna2DateTimePicker dtpThangNam;
        private Guna2Button btnLuu;
        private Guna2Button btnHuy;
        private Label lblMaNV;
        private Label lblHoTen;
        private Label lblChucVu;
        private Label lblThangNam;
        private Label lblSoNgayCong;
        private Label lblSoNgayOT;
        private Label lblLuongCoBan;
        private Label lblPhuCapChucVu;
        private Label lblPhuCapKhac;
        private Label lblTienLuongOT;
        private Label lblTienPhat;
        private Label lblTongLuong;
        private Label lblTitle;



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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtMaNV = new Guna2TextBox();
            txtHoTen = new Guna2TextBox();
            txtChucVu = new Guna2TextBox();
            txtSoNgayCong = new Guna2TextBox();
            txtSoNgayOT = new Guna2TextBox();
            txtLuongCoBan = new Guna2TextBox();
            txtPhuCapChucVu = new Guna2TextBox();
            txtPhuCapKhac = new Guna2TextBox();
            txtTienLuongOT = new Guna2TextBox();
            txtTienPhat = new Guna2TextBox();
            txtTongLuong = new Guna2TextBox();
            dtpThangNam = new Guna2DateTimePicker();
            btnLuu = new Guna2Button();
            btnHuy = new Guna2Button();
            lblMaNV = new Label();
            lblHoTen = new Label();
            lblChucVu = new Label();
            lblThangNam = new Label();
            lblSoNgayCong = new Label();
            lblSoNgayOT = new Label();
            lblLuongCoBan = new Label();
            lblPhuCapChucVu = new Label();
            lblPhuCapKhac = new Label();
            lblTienLuongOT = new Label();
            lblTienPhat = new Label();
            lblTongLuong = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 10;
            txtMaNV.CustomizableEdges = customizableEdges1;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.Location = new Point(130, 66);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "Nhập mã nhân viên";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNV.Size = new Size(247, 36);
            txtMaNV.TabIndex = 2;
            txtMaNV.KeyDown += TxtMaNV_KeyDown;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderRadius = 10;
            txtHoTen.CustomizableEdges = customizableEdges3;
            txtHoTen.DefaultText = "";
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(130, 106);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Nhập họ và tên";
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHoTen.Size = new Size(247, 36);
            txtHoTen.TabIndex = 3;
            // 
            // txtChucVu
            // 
            txtChucVu.BorderRadius = 10;
            txtChucVu.CustomizableEdges = customizableEdges5;
            txtChucVu.DefaultText = "";
            txtChucVu.Font = new Font("Segoe UI", 9F);
            txtChucVu.Location = new Point(130, 146);
            txtChucVu.Margin = new Padding(3, 4, 3, 4);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.PlaceholderText = "Nhập chức vụ";
            txtChucVu.SelectedText = "";
            txtChucVu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtChucVu.Size = new Size(247, 36);
            txtChucVu.TabIndex = 4;
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.BorderRadius = 10;
            txtSoNgayCong.CustomizableEdges = customizableEdges7;
            txtSoNgayCong.DefaultText = "";
            txtSoNgayCong.Font = new Font("Segoe UI", 9F);
            txtSoNgayCong.Location = new Point(130, 186);
            txtSoNgayCong.Margin = new Padding(3, 4, 3, 4);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.PlaceholderText = "Nhập số ngày công";
            txtSoNgayCong.SelectedText = "";
            txtSoNgayCong.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSoNgayCong.Size = new Size(247, 36);
            txtSoNgayCong.TabIndex = 5;
            txtSoNgayCong.TextChanged += txtSoNgayCong_TextChanged;
            // 
            // txtSoNgayOT
            // 
            txtSoNgayOT.BorderRadius = 10;
            txtSoNgayOT.CustomizableEdges = customizableEdges9;
            txtSoNgayOT.DefaultText = "";
            txtSoNgayOT.Font = new Font("Segoe UI", 9F);
            txtSoNgayOT.Location = new Point(130, 226);
            txtSoNgayOT.Margin = new Padding(3, 4, 3, 4);
            txtSoNgayOT.Name = "txtSoNgayOT";
            txtSoNgayOT.PlaceholderText = "Nhập số ngày OT";
            txtSoNgayOT.SelectedText = "";
            txtSoNgayOT.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSoNgayOT.Size = new Size(247, 36);
            txtSoNgayOT.TabIndex = 6;
            txtSoNgayOT.TextChanged += txtSoNgayOT_TextChanged;
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.BorderRadius = 10;
            txtLuongCoBan.CustomizableEdges = customizableEdges11;
            txtLuongCoBan.DefaultText = "";
            txtLuongCoBan.Font = new Font("Segoe UI", 9F);
            txtLuongCoBan.Location = new Point(130, 266);
            txtLuongCoBan.Margin = new Padding(3, 4, 3, 4);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.PlaceholderText = "Nhập lương cơ bản";
            txtLuongCoBan.SelectedText = "";
            txtLuongCoBan.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtLuongCoBan.Size = new Size(247, 36);
            txtLuongCoBan.TabIndex = 7;
            // 
            // txtPhuCapChucVu
            // 
            txtPhuCapChucVu.BorderRadius = 10;
            txtPhuCapChucVu.CustomizableEdges = customizableEdges13;
            txtPhuCapChucVu.DefaultText = "";
            txtPhuCapChucVu.Font = new Font("Segoe UI", 9F);
            txtPhuCapChucVu.Location = new Point(130, 306);
            txtPhuCapChucVu.Margin = new Padding(3, 4, 3, 4);
            txtPhuCapChucVu.Name = "txtPhuCapChucVu";
            txtPhuCapChucVu.PlaceholderText = "Nhập phụ cấp chức vụ";
            txtPhuCapChucVu.SelectedText = "";
            txtPhuCapChucVu.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtPhuCapChucVu.Size = new Size(247, 36);
            txtPhuCapChucVu.TabIndex = 8;
            // 
            // txtPhuCapKhac
            // 
            txtPhuCapKhac.BorderRadius = 10;
            txtPhuCapKhac.CustomizableEdges = customizableEdges15;
            txtPhuCapKhac.DefaultText = "";
            txtPhuCapKhac.Font = new Font("Segoe UI", 9F);
            txtPhuCapKhac.Location = new Point(130, 346);
            txtPhuCapKhac.Margin = new Padding(3, 4, 3, 4);
            txtPhuCapKhac.Name = "txtPhuCapKhac";
            txtPhuCapKhac.PlaceholderText = "Nhập phụ cấp khác";
            txtPhuCapKhac.SelectedText = "";
            txtPhuCapKhac.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtPhuCapKhac.Size = new Size(247, 36);
            txtPhuCapKhac.TabIndex = 9;
            // 
            // txtTienLuongOT
            // 
            txtTienLuongOT.BorderRadius = 10;
            txtTienLuongOT.CustomizableEdges = customizableEdges17;
            txtTienLuongOT.DefaultText = "";
            txtTienLuongOT.Font = new Font("Segoe UI", 9F);
            txtTienLuongOT.Location = new Point(130, 386);
            txtTienLuongOT.Margin = new Padding(3, 4, 3, 4);
            txtTienLuongOT.Name = "txtTienLuongOT";
            txtTienLuongOT.PlaceholderText = "Nhập tiền lương OT";
            txtTienLuongOT.SelectedText = "";
            txtTienLuongOT.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtTienLuongOT.Size = new Size(247, 36);
            txtTienLuongOT.TabIndex = 10;
            // 
            // txtTienPhat
            // 
            txtTienPhat.BorderRadius = 10;
            txtTienPhat.CustomizableEdges = customizableEdges19;
            txtTienPhat.DefaultText = "";
            txtTienPhat.Font = new Font("Segoe UI", 9F);
            txtTienPhat.Location = new Point(130, 426);
            txtTienPhat.Margin = new Padding(3, 4, 3, 4);
            txtTienPhat.Name = "txtTienPhat";
            txtTienPhat.PlaceholderText = "Nhập tiền phạt";
            txtTienPhat.SelectedText = "";
            txtTienPhat.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtTienPhat.Size = new Size(247, 36);
            txtTienPhat.TabIndex = 11;
            txtTienPhat.TextChanged += txtTienPhat_TextChanged;
            // 
            // txtTongLuong
            // 
            txtTongLuong.BorderRadius = 10;
            txtTongLuong.CustomizableEdges = customizableEdges21;
            txtTongLuong.DefaultText = "";
            txtTongLuong.Font = new Font("Segoe UI", 9F);
            txtTongLuong.Location = new Point(130, 466);
            txtTongLuong.Margin = new Padding(3, 4, 3, 4);
            txtTongLuong.Name = "txtTongLuong";
            txtTongLuong.PlaceholderText = "Tính tổng lương";
            txtTongLuong.SelectedText = "";
            txtTongLuong.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtTongLuong.Size = new Size(247, 36);
            txtTongLuong.TabIndex = 12;
            // 
            // dtpThangNam
            // 
            dtpThangNam.Checked = true;
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.CustomizableEdges = customizableEdges23;
            dtpThangNam.Font = new Font("Segoe UI", 9F);
            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.Location = new Point(130, 509);
            dtpThangNam.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpThangNam.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpThangNam.Name = "dtpThangNam";
            dtpThangNam.ShadowDecoration.CustomizableEdges = customizableEdges24;
            dtpThangNam.Size = new Size(247, 36);
            dtpThangNam.TabIndex = 13;
            dtpThangNam.Value = new DateTime(2025, 4, 3, 10, 36, 59, 694);
            // 
            // btnLuu
            // 
            btnLuu.CustomizableEdges = customizableEdges25;
            btnLuu.FillColor = Color.MediumSlateBlue;
            btnLuu.Font = new Font("Segoe UI", 9F);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(130, 564);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnLuu.Size = new Size(75, 36);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.Click += BtnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.CustomizableEdges = customizableEdges27;
            btnHuy.FillColor = Color.Crimson;
            btnHuy.Font = new Font("Segoe UI", 9F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(244, 564);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnHuy.Size = new Size(75, 36);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // lblMaNV
            // 
            lblMaNV.Location = new Point(12, 66);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(100, 23);
            lblMaNV.TabIndex = 1;
            lblMaNV.Text = "Mã NV:";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(12, 106);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên:";
            // 
            // lblChucVu
            // 
            lblChucVu.Location = new Point(12, 146);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(100, 23);
            lblChucVu.TabIndex = 3;
            lblChucVu.Text = "Chức vụ:";
            // 
            // lblThangNam
            // 
            lblThangNam.Location = new Point(0, 0);
            lblThangNam.Name = "lblThangNam";
            lblThangNam.Size = new Size(100, 23);
            lblThangNam.TabIndex = 0;
            // 
            // lblSoNgayCong
            // 
            lblSoNgayCong.Location = new Point(12, 186);
            lblSoNgayCong.Name = "lblSoNgayCong";
            lblSoNgayCong.Size = new Size(112, 23);
            lblSoNgayCong.TabIndex = 4;
            lblSoNgayCong.Text = "Số ngày công:";
            // 
            // lblSoNgayOT
            // 
            lblSoNgayOT.Location = new Point(12, 226);
            lblSoNgayOT.Name = "lblSoNgayOT";
            lblSoNgayOT.Size = new Size(100, 23);
            lblSoNgayOT.TabIndex = 5;
            lblSoNgayOT.Text = "Số ngày OT:";
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.Location = new Point(12, 266);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(112, 23);
            lblLuongCoBan.TabIndex = 6;
            lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // lblPhuCapChucVu
            // 
            lblPhuCapChucVu.Location = new Point(12, 306);
            lblPhuCapChucVu.Name = "lblPhuCapChucVu";
            lblPhuCapChucVu.Size = new Size(100, 23);
            lblPhuCapChucVu.TabIndex = 7;
            lblPhuCapChucVu.Text = "Phụ cấp chức vụ:";
            // 
            // lblPhuCapKhac
            // 
            lblPhuCapKhac.Location = new Point(12, 346);
            lblPhuCapKhac.Name = "lblPhuCapKhac";
            lblPhuCapKhac.Size = new Size(100, 23);
            lblPhuCapKhac.TabIndex = 8;
            lblPhuCapKhac.Text = "Phụ cấp khác:";
            // 
            // lblTienLuongOT
            // 
            lblTienLuongOT.Location = new Point(12, 386);
            lblTienLuongOT.Name = "lblTienLuongOT";
            lblTienLuongOT.Size = new Size(112, 23);
            lblTienLuongOT.TabIndex = 9;
            lblTienLuongOT.Text = "Tiền lương OT:";
            // 
            // lblTienPhat
            // 
            lblTienPhat.Location = new Point(12, 426);
            lblTienPhat.Name = "lblTienPhat";
            lblTienPhat.Size = new Size(100, 23);
            lblTienPhat.TabIndex = 10;
            lblTienPhat.Text = "Tiền phạt:";
            // 
            // lblTongLuong
            // 
            lblTongLuong.Location = new Point(12, 466);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new Size(100, 23);
            lblTongLuong.TabIndex = 11;
            lblTongLuong.Text = "Tổng lương:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(58, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bảng Tính Lương";
            // 
            // BangTinhLuongPopup
            // 
            ClientSize = new Size(389, 616);
            Controls.Add(lblTitle);
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblChucVu);
            Controls.Add(txtChucVu);
            Controls.Add(lblSoNgayCong);
            Controls.Add(txtSoNgayCong);
            Controls.Add(lblSoNgayOT);
            Controls.Add(txtSoNgayOT);
            Controls.Add(lblLuongCoBan);
            Controls.Add(txtLuongCoBan);
            Controls.Add(lblPhuCapChucVu);
            Controls.Add(txtPhuCapChucVu);
            Controls.Add(lblPhuCapKhac);
            Controls.Add(txtPhuCapKhac);
            Controls.Add(lblTienLuongOT);
            Controls.Add(txtTienLuongOT);
            Controls.Add(lblTienPhat);
            Controls.Add(txtTienPhat);
            Controls.Add(lblTongLuong);
            Controls.Add(txtTongLuong);
            Controls.Add(dtpThangNam);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Name = "BangTinhLuongPopup";
            Text = "Bảng Tính Lương";
            Load += BangTinhLuongPopup_Load;
            ResumeLayout(false);
        }
    }
}
