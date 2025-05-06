using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    partial class TaiKhoanPopupForm
    {
        private Guna2TextBox txtTenDangNhap;
        private Guna2TextBox txtMatKhau;
        private Guna2TextBox txtHoTen;
        private Guna2ComboBox cmbVaiTro;
        private Guna2ToggleSwitch toggleTrangThai;
        private Guna2Button btnLuu;
        private Guna2Button btnHuy;
        private Label lblTrangThai, lblTenDN, lblMatKhau, lblHoTen, lblVaiTro;
        private Label lblToggleStatus;

        // 👉 Thêm control mới
        private Guna2TextBox txtMaNV;
        private Label lblMaNV;

        private void InitializeComponent()
        {
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTenDangNhap = new Guna2TextBox();
            txtMatKhau = new Guna2TextBox();
            txtHoTen = new Guna2TextBox();
            cmbVaiTro = new Guna2ComboBox();
            toggleTrangThai = new Guna2ToggleSwitch();
            btnLuu = new Guna2Button();
            btnHuy = new Guna2Button();
            lblTrangThai = new Label();
            lblTenDN = new Label();
            lblMatKhau = new Label();
            lblHoTen = new Label();
            lblVaiTro = new Label();
            lblToggleStatus = new Label();
            txtMaNV = new Guna2TextBox();
            lblMaNV = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.CustomizableEdges = customizableEdges17;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(30, 156);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtTenDangNhap.Size = new Size(320, 40);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.CustomizableEdges = customizableEdges19;
            txtMatKhau.DefaultText = "";
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(30, 227);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtMatKhau.Size = new Size(320, 40);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtHoTen
            // 
            txtHoTen.CustomizableEdges = customizableEdges21;
            txtHoTen.DefaultText = "";
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(32, 298);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Nhập họ tên";
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtHoTen.Size = new Size(320, 40);
            txtHoTen.TabIndex = 5;
            // 
            // cmbVaiTro
            // 
            cmbVaiTro.BackColor = Color.Transparent;
            cmbVaiTro.CustomizableEdges = customizableEdges23;
            cmbVaiTro.DrawMode = DrawMode.OwnerDrawFixed;
            cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaiTro.FocusedColor = Color.Empty;
            cmbVaiTro.Font = new Font("Segoe UI", 10F);
            cmbVaiTro.ForeColor = Color.FromArgb(68, 88, 112);
            cmbVaiTro.ItemHeight = 30;
            cmbVaiTro.Items.AddRange(new object[] { "Admin", "NhanVien", "KeToan" });
            cmbVaiTro.Location = new Point(30, 368);
            cmbVaiTro.Name = "cmbVaiTro";
            cmbVaiTro.ShadowDecoration.CustomizableEdges = customizableEdges24;
            cmbVaiTro.Size = new Size(320, 36);
            cmbVaiTro.TabIndex = 7;
            // 
            // toggleTrangThai
            // 
            toggleTrangThai.Checked = true;
            toggleTrangThai.CustomizableEdges = customizableEdges25;
            toggleTrangThai.Location = new Point(138, 410);
            toggleTrangThai.Name = "toggleTrangThai";
            toggleTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges26;
            toggleTrangThai.Size = new Size(50, 23);
            toggleTrangThai.TabIndex = 9;
            toggleTrangThai.CheckedChanged += ToggleTrangThai_CheckedChanged;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 10;
            btnLuu.CustomizableEdges = customizableEdges27;
            btnLuu.FillColor = Color.SeaGreen;
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(38, 470);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnLuu.Size = new Size(120, 45);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.Click += BtnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BorderRadius = 10;
            btnHuy.CustomizableEdges = customizableEdges29;
            btnHuy.FillColor = Color.Firebrick;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(200, 470);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnHuy.Size = new Size(120, 45);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.Location = new Point(30, 410);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(91, 23);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Font = new Font("Segoe UI", 10F);
            lblTenDN.Location = new Point(32, 129);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(128, 23);
            lblTenDN.TabIndex = 0;
            lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(32, 200);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(32, 271);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 23);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.Location = new Point(32, 342);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(64, 23);
            lblVaiTro.TabIndex = 6;
            lblVaiTro.Text = "Vai trò:";
            // 
            // lblToggleStatus
            // 
            lblToggleStatus.AutoSize = true;
            lblToggleStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblToggleStatus.ForeColor = Color.Green;
            lblToggleStatus.Location = new Point(200, 410);
            lblToggleStatus.Name = "lblToggleStatus";
            lblToggleStatus.Size = new Size(96, 23);
            lblToggleStatus.TabIndex = 0;
            lblToggleStatus.Text = "Hoạt động";
            // 
            // txtMaNV
            // 
            txtMaNV.CustomizableEdges = customizableEdges31;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 10F);
            txtMaNV.Location = new Point(30, 85);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "Nhập mã nhân viên";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtMaNV.Size = new Size(320, 40);
            txtMaNV.TabIndex = 0;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 10F);
            lblMaNV.Location = new Point(30, 58);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(118, 23);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 12;
            label1.Text = "Tài khoản nhân viên ";
            // 
            // TaiKhoanPopupForm
            // 
            ClientSize = new Size(378, 538);
            Controls.Add(label1);
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(lblToggleStatus);
            Controls.Add(lblTenDN);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblVaiTro);
            Controls.Add(cmbVaiTro);
            Controls.Add(lblTrangThai);
            Controls.Add(toggleTrangThai);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TaiKhoanPopupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin tài khoản";
            Load += TaiKhoanPopupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
