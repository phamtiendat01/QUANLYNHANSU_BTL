using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class TaiKhoanPopupForm : Form
    {
        public TaiKhoan TaiKhoanDuocNhap { get; private set; }
        private bool isEdit;

        public TaiKhoanPopupForm(TaiKhoan tk = null)
        {
            InitializeComponent();
            isEdit = tk != null;

            if (isEdit)
            {
                Text = "Sửa tài khoản";
                LoadThongTin(tk);
                txtTenDangNhap.Enabled = false; // Không cho sửa tên đăng nhập
            }
            else
            {
                Text = "Thêm tài khoản";
            }

            btnLuu.Click += BtnLuu_Click;
        }

        private void LoadThongTin(TaiKhoan tk)
        {
            txtTenDangNhap.Text = tk.TenDangNhap;
            txtMatKhau.Text = tk.MatKhau;
            txtHoTen.Text = tk.HoTen;
            cmbVaiTro.SelectedItem = tk.VaiTro;
            toggleTrangThai.Checked = tk.TrangThai;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                cmbVaiTro.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gán dữ liệu
            TaiKhoanDuocNhap = new TaiKhoan
            {
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = txtMatKhau.Text,
                HoTen = txtHoTen.Text.Trim(),
                VaiTro = cmbVaiTro.SelectedItem.ToString(),
                TrangThai = toggleTrangThai.Checked
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToggleTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            bool status = toggleTrangThai.Checked;
            lblToggleStatus.Text = status ? "Hoạt động" : "Bị khóa";
            lblToggleStatus.ForeColor = status ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private void TaiKhoanPopupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
