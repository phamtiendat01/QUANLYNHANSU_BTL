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
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.CustomizableEdges = customizableEdges1;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(30, 55);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTenDangNhap.Size = new Size(320, 40);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.CustomizableEdges = customizableEdges3;
            txtMatKhau.DefaultText = "";
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(30, 130);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMatKhau.Size = new Size(320, 40);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtHoTen
            // 
            txtHoTen.CustomizableEdges = customizableEdges5;
            txtHoTen.DefaultText = "";
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(30, 205);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Nhập họ tên";
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtHoTen.Size = new Size(320, 40);
            txtHoTen.TabIndex = 5;
            // 
            // cmbVaiTro
            // 
            cmbVaiTro.BackColor = Color.Transparent;
            cmbVaiTro.CustomizableEdges = customizableEdges7;
            cmbVaiTro.DrawMode = DrawMode.OwnerDrawFixed;
            cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaiTro.FocusedColor = Color.Empty;
            cmbVaiTro.Font = new Font("Segoe UI", 10F);
            cmbVaiTro.ForeColor = Color.FromArgb(68, 88, 112);
            cmbVaiTro.ItemHeight = 30;
            cmbVaiTro.Items.AddRange(new object[] { "Admin", "NhanVien", "KeToan" });
            cmbVaiTro.Location = new Point(30, 280);
            cmbVaiTro.Name = "cmbVaiTro";
            cmbVaiTro.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbVaiTro.Size = new Size(320, 36);
            cmbVaiTro.TabIndex = 7;
            // 
            // toggleTrangThai
            // 
            toggleTrangThai.Checked = true;
            toggleTrangThai.CustomizableEdges = customizableEdges9;
            toggleTrangThai.Location = new Point(139, 330);
            toggleTrangThai.Name = "toggleTrangThai";
            toggleTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges10;
            toggleTrangThai.Size = new Size(50, 23);
            toggleTrangThai.TabIndex = 9;
            toggleTrangThai.CheckedChanged += ToggleTrangThai_CheckedChanged;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 10;
            btnLuu.CustomizableEdges = customizableEdges11;
            btnLuu.FillColor = Color.SeaGreen;
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(40, 390);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLuu.Size = new Size(120, 45);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.Click += BtnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BorderRadius = 10;
            btnHuy.CustomizableEdges = customizableEdges13;
            btnHuy.FillColor = Color.Firebrick;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(200, 390);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnHuy.Size = new Size(120, 45);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.Location = new Point(30, 330);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(91, 23);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Font = new Font("Segoe UI", 10F);
            lblTenDN.Location = new Point(30, 30);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(128, 23);
            lblTenDN.TabIndex = 0;
            lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(30, 105);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(30, 180);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 23);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.Location = new Point(30, 255);
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
            lblToggleStatus.Location = new Point(200, 330);
            lblToggleStatus.Name = "lblToggleStatus";
            lblToggleStatus.Size = new Size(96, 23);
            lblToggleStatus.TabIndex = 0;
            lblToggleStatus.Text = "Hoạt động";
            // 
            // TaiKhoanPopupForm
            // 
            ClientSize = new Size(378, 483);
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
    }
}
