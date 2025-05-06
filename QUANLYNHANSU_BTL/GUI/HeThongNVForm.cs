using System;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.DAL;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class HeThongNVForm : Form
    {
        private string maNV; // Mã nhân viên đăng nhập
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public HeThongNVForm(string maNV)  // constructor nhận mã nhân viên
        {
            InitializeComponent();
            this.maNV = maNV;  // gán mã nhân viên cho biến thành viên
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string usernameInput = maNV; // lấy mã nhân viên đang đăng nhập
            string oldPassInput = txtOldPass.Text.Trim();
            string newPassInput = txtNewPass.Text.Trim();

            if (string.IsNullOrEmpty(oldPassInput) || string.IsNullOrEmpty(newPassInput))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu cũ và mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!taiKhoanDAL.KiemTraMatKhauCu(usernameInput, oldPassInput))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (taiKhoanDAL.CapNhatMatKhauMoi(usernameInput, newPassInput))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Clear();
                txtNewPass.Clear();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
