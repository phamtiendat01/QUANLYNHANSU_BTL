using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class TaiKhoanPopupForm : Form
    {
        public TaiKhoanDTO TaiKhoanDuocNhap { get; private set; }
        private bool isEdit;

        public TaiKhoanPopupForm(TaiKhoanDTO tk = null)
        {
            InitializeComponent();
            isEdit = tk != null;

            if (isEdit)
            {
                Text = "Sửa tài khoản";
                LoadThongTin(tk);
                txtTenDangNhap.Enabled = false; // Không cho sửa tên đăng nhập
                txtMaNV.Enabled = false; // Không cho sửa MaNV nếu đang edit
            }
            else
            {
                Text = "Thêm tài khoản";
            }

            btnLuu.Click += BtnLuu_Click;
        }

        private void LoadThongTin(TaiKhoanDTO tk)
        {
            txtTenDangNhap.Text = tk.TenDangNhap;
            txtMatKhau.Text = tk.MatKhau;
            txtHoTen.Text = tk.HoTen;
            txtMaNV.Text = tk.MaNV.ToString();
            cmbVaiTro.SelectedItem = tk.VaiTro;
            toggleTrangThai.Checked = tk.TrangThai;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                cmbVaiTro.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
            {
                MessageBox.Show("Mã nhân viên phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoanDuocNhap = new TaiKhoanDTO
            {
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = txtMatKhau.Text,
                HoTen = txtHoTen.Text.Trim(),
                MaNV = maNV,
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
