using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;  // Dùng Guna2 cho các control

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongPopupForm : Form
    {
      

        // Khai báo các control
        private Guna2TextBox txtMaNV;
        private Guna2TextBox txtHoTen;
        private Guna2TextBox txtChucVu;
        private Guna2TextBox txtLuongCoBan;
        private Guna2TextBox txtPhuCapChucVu;
        private Guna2TextBox txtPhuCapKhac;
        private Guna2TextBox txtGhiChu;
        private Guna2Button btnSave;
        private Guna2Button btnCancel;

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
            txtMaNV = new Guna2TextBox();
            txtHoTen = new Guna2TextBox();
            txtChucVu = new Guna2TextBox();
            txtLuongCoBan = new Guna2TextBox();
            txtPhuCapChucVu = new Guna2TextBox();
            txtPhuCapKhac = new Guna2TextBox();
            txtGhiChu = new Guna2TextBox();
            btnSave = new Guna2Button();
            btnCancel = new Guna2Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtMaNV
            // 
            txtMaNV.CustomizableEdges = customizableEdges1;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.Location = new Point(30, 65);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "Mã Nhân Viên";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNV.Size = new Size(300, 40);
            txtMaNV.TabIndex = 1;
            txtMaNV.KeyDown += txtMaNV_KeyDown;
            // 
            // txtHoTen
            // 
            txtHoTen.CustomizableEdges = customizableEdges3;
            txtHoTen.DefaultText = "";
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(30, 113);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Họ và Tên";
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHoTen.Size = new Size(300, 40);
            txtHoTen.TabIndex = 2;
            // 
            // txtChucVu
            // 
            txtChucVu.CustomizableEdges = customizableEdges5;
            txtChucVu.DefaultText = "";
            txtChucVu.Font = new Font("Segoe UI", 9F);
            txtChucVu.Location = new Point(30, 161);
            txtChucVu.Margin = new Padding(3, 4, 3, 4);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.PlaceholderText = "Chức Vụ";
            txtChucVu.SelectedText = "";
            txtChucVu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtChucVu.Size = new Size(300, 40);
            txtChucVu.TabIndex = 3;
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.CustomizableEdges = customizableEdges7;
            txtLuongCoBan.DefaultText = "";
            txtLuongCoBan.Font = new Font("Segoe UI", 9F);
            txtLuongCoBan.Location = new Point(30, 209);
            txtLuongCoBan.Margin = new Padding(3, 4, 3, 4);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.PlaceholderText = "Lương Cơ Bản";
            txtLuongCoBan.SelectedText = "";
            txtLuongCoBan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtLuongCoBan.Size = new Size(300, 40);
            txtLuongCoBan.TabIndex = 4;
            // 
            // txtPhuCapChucVu
            // 
            txtPhuCapChucVu.CustomizableEdges = customizableEdges9;
            txtPhuCapChucVu.DefaultText = "";
            txtPhuCapChucVu.Font = new Font("Segoe UI", 9F);
            txtPhuCapChucVu.Location = new Point(30, 257);
            txtPhuCapChucVu.Margin = new Padding(3, 4, 3, 4);
            txtPhuCapChucVu.Name = "txtPhuCapChucVu";
            txtPhuCapChucVu.PlaceholderText = "Phụ Cấp Chức Vụ";
            txtPhuCapChucVu.SelectedText = "";
            txtPhuCapChucVu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPhuCapChucVu.Size = new Size(300, 40);
            txtPhuCapChucVu.TabIndex = 5;
            // 
            // txtPhuCapKhac
            // 
            txtPhuCapKhac.CustomizableEdges = customizableEdges11;
            txtPhuCapKhac.DefaultText = "";
            txtPhuCapKhac.Font = new Font("Segoe UI", 9F);
            txtPhuCapKhac.Location = new Point(30, 305);
            txtPhuCapKhac.Margin = new Padding(3, 4, 3, 4);
            txtPhuCapKhac.Name = "txtPhuCapKhac";
            txtPhuCapKhac.PlaceholderText = "Phụ Cấp Khác";
            txtPhuCapKhac.SelectedText = "";
            txtPhuCapKhac.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtPhuCapKhac.Size = new Size(300, 40);
            txtPhuCapKhac.TabIndex = 6;
            // 
            // txtGhiChu
            // 
            txtGhiChu.CustomizableEdges = customizableEdges13;
            txtGhiChu.DefaultText = "";
            txtGhiChu.Font = new Font("Segoe UI", 9F);
            txtGhiChu.Location = new Point(30, 353);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi Chú";
            txtGhiChu.SelectedText = "";
            txtGhiChu.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtGhiChu.Size = new Size(300, 40);
            txtGhiChu.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges15;
            btnSave.FillColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 428);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.Click += btnLuu_Click;
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges17;
            btnCancel.FillColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(200, 428);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnHuy_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin bảng lương";
            // 
            // BangLuongPopupForm
            // 
            ClientSize = new Size(368, 500);
            Controls.Add(lblTitle);
            Controls.Add(txtMaNV);
            Controls.Add(txtHoTen);
            Controls.Add(txtChucVu);
            Controls.Add(txtLuongCoBan);
            Controls.Add(txtPhuCapChucVu);
            Controls.Add(txtPhuCapKhac);
            Controls.Add(txtGhiChu);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BangLuongPopupForm";
            Text = "Thông tin bảng lương";
            Load += BangLuongPopupForm_Load;
            ResumeLayout(false);
        }

        private Label lblTitle;
    }
}
