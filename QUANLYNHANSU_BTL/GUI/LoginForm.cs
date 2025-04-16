using System;
using System.Drawing;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO; 
namespace QUANLYNHANSU_BTL.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDN = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tk = TaiKhoanBLL.KiemTraDangNhap(tenDN, matKhau);

            if (tk == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra MaNV hợp lệ
            if (tk.MaNV == 0)
            {
                MessageBox.Show("Không có thông tin nhân viên (MaNV không hợp lệ)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($"MaNV: {tk.MaNV}");  // Kiểm tra giá trị MaNV

            // Nếu là tài khoản nhân viên
            if (tk.VaiTro.ToLower() == "admin")
            {
                MainForm main = new MainForm();
                main.ShowDialog();
            }
            else
            {
                // Lấy thông tin nhân viên
                NhanVienDTO nv = NhanVienBLL.GetNhanVienInfo(tk.MaNV);  // Lấy thông tin nhân viên từ BLL
                Console.WriteLine($"MaNV khi lấy thông tin nhân viên: {tk.MaNV}");
                if (nv != null)
                {
                    // Truyền thông tin nhân viên vào form nhân viên
                    formNV formNV = new formNV(nv);  // Truyền NhanVienDTO vào formNV
                    formNV.Text = "Nhân viên";

                    formNV.StartPosition = FormStartPosition.CenterScreen;
                    formNV.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có thông tin nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }





        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
