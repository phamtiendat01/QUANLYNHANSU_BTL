using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ChamCongPopup : Form
    {
       
        private Label lblTitle;
        private Guna2TextBox txtMaNV, txtHoTen, txtGhiChu, txtSoGioTangCa;
        private Guna2DateTimePicker dtpNgay;
        private Guna2ComboBox cmbLoaiCong, cmbTrangThai;
        private Guna2DateTimePicker timeGioVao, timeGioRa;
        private Guna2Button btnLuu, btnHuy;


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
            lblTitle = new Label();
            txtMaNV = new Guna2TextBox();
            txtHoTen = new Guna2TextBox();
            dtpNgay = new Guna2DateTimePicker();
            cmbLoaiCong = new Guna2ComboBox();
            cmbTrangThai = new Guna2ComboBox();
            timeGioVao = new Guna2DateTimePicker();
            timeGioRa = new Guna2DateTimePicker();
            txtSoGioTangCa = new Guna2TextBox();
            txtGhiChu = new Guna2TextBox();
            btnLuu = new Guna2Button();
            btnHuy = new Guna2Button();

            SuspendLayout();
            // 

            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin chấm công";
            // 
            // txtMaNV
            // 
            txtMaNV.CustomizableEdges = customizableEdges1;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.Location = new Point(20, 50);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "Mã nhân viên";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNV.Size = new Size(300, 36);
            txtMaNV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.CustomizableEdges = customizableEdges3;
            txtHoTen.DefaultText = "";
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(20, 95);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Họ tên";
            txtHoTen.ReadOnly = true;
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHoTen.Size = new Size(300, 36);
            txtHoTen.TabIndex = 2;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // dtpNgay
            // 
            dtpNgay.Checked = true;
            dtpNgay.CustomizableEdges = customizableEdges5;
            dtpNgay.Font = new Font("Segoe UI", 9F);
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(20, 143);
            dtpNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpNgay.Size = new Size(300, 36);
            dtpNgay.TabIndex = 3;
            dtpNgay.Value = new DateTime(2025, 3, 26, 20, 49, 45, 109);
            // 
            // cmbLoaiCong
            // 
            cmbLoaiCong.BackColor = Color.Transparent;
            cmbLoaiCong.CustomizableEdges = customizableEdges7;
            cmbLoaiCong.DrawMode = DrawMode.OwnerDrawFixed;
            cmbLoaiCong.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiCong.FocusedColor = Color.Empty;
            cmbLoaiCong.Font = new Font("Segoe UI", 10F);
            cmbLoaiCong.ForeColor = Color.FromArgb(68, 88, 112);
            cmbLoaiCong.ItemHeight = 30;
            cmbLoaiCong.Items.AddRange(new object[] { "C - Công chuẩn", "P - Nghỉ phép có lương", "NP - Nghỉ phép không lương", "V - Vắng không phép", "OT - Tăng ca", "L - Nghỉ lễ", "K - Khám sức khỏe", "CT - Công tác", "TS - Thai sản" });
            cmbLoaiCong.Location = new Point(20, 185);
            cmbLoaiCong.Name = "cmbLoaiCong";
            cmbLoaiCong.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbLoaiCong.Size = new Size(300, 36);
            cmbLoaiCong.TabIndex = 4;
            cmbLoaiCong.SelectedIndexChanged += cmbLoaiCong_SelectedIndexChanged;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.BackColor = Color.Transparent;
            cmbTrangThai.CustomizableEdges = customizableEdges9;
            cmbTrangThai.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.FocusedColor = Color.Empty;
            cmbTrangThai.Font = new Font("Segoe UI", 10F);
            cmbTrangThai.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTrangThai.ItemHeight = 30;
            cmbTrangThai.Items.AddRange(new object[] { "-- Chọn trạng thái --", "Đúng giờ", "Đi muộn", "Về sớm", "Không phép", "Có phép" });
            cmbTrangThai.Location = new Point(20, 230);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbTrangThai.Size = new Size(300, 36);
            cmbTrangThai.TabIndex = 5;
            // 
            // timeGioVao
            // 
            timeGioVao.Checked = true;
            timeGioVao.CustomizableEdges = customizableEdges11;
            timeGioVao.Font = new Font("Segoe UI", 9F);
            timeGioVao.Format = DateTimePickerFormat.Time;
            timeGioVao.Location = new Point(20, 275);
            timeGioVao.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            timeGioVao.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            timeGioVao.Name = "timeGioVao";
            timeGioVao.ShadowDecoration.CustomizableEdges = customizableEdges12;
            timeGioVao.ShowUpDown = true;
            timeGioVao.Size = new Size(300, 36);
            timeGioVao.TabIndex = 6;
            timeGioVao.Value = new DateTime(2025, 3, 26, 20, 49, 45, 332);
            // 
            // timeGioRa
            // 
            timeGioRa.Checked = true;
            timeGioRa.CustomizableEdges = customizableEdges13;
            timeGioRa.Font = new Font("Segoe UI", 9F);
            timeGioRa.Format = DateTimePickerFormat.Time;
            timeGioRa.Location = new Point(20, 320);
            timeGioRa.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            timeGioRa.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            timeGioRa.Name = "timeGioRa";
            timeGioRa.ShadowDecoration.CustomizableEdges = customizableEdges14;
            timeGioRa.ShowUpDown = true;
            timeGioRa.Size = new Size(300, 36);
            timeGioRa.TabIndex = 7;
            timeGioRa.Value = new DateTime(2025, 3, 26, 20, 49, 45, 461);
            // 
            // txtSoGioTangCa
            // 
            txtSoGioTangCa.CustomizableEdges = customizableEdges15;
            txtSoGioTangCa.DefaultText = "";
            txtSoGioTangCa.Font = new Font("Segoe UI", 9F);
            txtSoGioTangCa.Location = new Point(20, 365);
            txtSoGioTangCa.Margin = new Padding(3, 4, 3, 4);
            txtSoGioTangCa.Name = "txtSoGioTangCa";
            txtSoGioTangCa.PlaceholderText = "Số giờ tăng ca";
            txtSoGioTangCa.SelectedText = "";
            txtSoGioTangCa.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtSoGioTangCa.Size = new Size(300, 36);
            txtSoGioTangCa.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            txtGhiChu.CustomizableEdges = customizableEdges17;
            txtGhiChu.DefaultText = "";
            txtGhiChu.Font = new Font("Segoe UI", 9F);
            txtGhiChu.Location = new Point(20, 410);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi chú...";
            txtGhiChu.SelectedText = "";
            txtGhiChu.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtGhiChu.Size = new Size(300, 60);
            txtGhiChu.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.CustomizableEdges = customizableEdges19;
            btnLuu.FillColor = Color.SeaGreen;
            btnLuu.Font = new Font("Segoe UI", 9F);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(50, 480);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.Click += BtnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.CustomizableEdges = customizableEdges21;
            btnHuy.FillColor = Color.IndianRed;
            btnHuy.Font = new Font("Segoe UI", 9F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(182, 480);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnHuy.Size = new Size(100, 40);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // ChamCongPopup
            // 
            ClientSize = new Size(342, 523);
            Controls.Add(lblTitle);
            Controls.Add(txtMaNV);
            Controls.Add(txtHoTen);
            Controls.Add(dtpNgay);
            Controls.Add(cmbLoaiCong);
            Controls.Add(cmbTrangThai);
            Controls.Add(timeGioVao);
            Controls.Add(timeGioRa);
            Controls.Add(txtSoGioTangCa);
            Controls.Add(txtGhiChu);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Name = "ChamCongPopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chấm công";
            Load += ChamCongPopup_Load;
            ResumeLayout(false);
        }
    }
}
