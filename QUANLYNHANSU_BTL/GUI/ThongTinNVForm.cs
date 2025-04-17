using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;
using System;
using System.IO;
using System.Windows.Forms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ThongTinNVForm : Form
    {
        private NhanVienDTO nv;  // Lưu thông tin nhân viên

        // Constructor nhận thông tin nhân viên từ formNV
        public ThongTinNVForm(NhanVienDTO nv)
        {
            InitializeComponent();
            this.nv = nv;

            if (nv != null)
            {
                // Cập nhật thông tin vào các label trong form
                lblTenNV.Text = "Tên nhân viên: " + nv.HoTen;
                lblPhongBan.Text = "Phong ban: " + nv.PhongBan;
                lblNgaySinh.Text = "Ngày sinh: " + nv.NgaySinh.ToString("dd/MM/yyyy");
                lblCMND.Text = "CMND: " + nv.CMND_CCCD;
                lblGioiTinh.Text = "Giới tính: " + nv.GioiTinh;
                lblChucVu.Text = "Chức vụ: " + nv.ChucVu;
                lblSDT.Text = "SĐT: " + nv.SDT;
                lblLoaiNV.Text = "Loại nhân viên: " + nv.LoaiNV;
                lblHocVan.Text = "Học vấn: " + nv.HocVan;

                // Hiển thị ảnh nhân viên (Avatar)
                int maNV = 0;
                if (int.TryParse(nv.MaNV, out maNV))  // Ép kiểu string sang int
                {
                    // Hiển thị ảnh nhân viên (Avatar)
                    DisplayAvatar(maNV);
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị ảnh nhân viên (Base64)
        private void DisplayAvatar(int maNV)
        {
            // Lấy ảnh từ cơ sở dữ liệu dưới dạng Base64
            string avatarBase64 = NhanVienBLL.GetAvatar(maNV);

            if (!string.IsNullOrEmpty(avatarBase64))
            {
                try
                {
                    // Chuyển từ Base64 thành byte[] và hiển thị ảnh
                    byte[] imageBytes = Convert.FromBase64String(avatarBase64);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picAvatar.Image = Image.FromStream(ms);  // Hiển thị ảnh trong PictureBox
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ảnh không hợp lệ.", "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                picAvatar.Image = null;  // Nếu không có ảnh, có thể hiển thị ảnh mặc định
            }
        }



        // Button chọn ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";  // Chỉ cho phép chọn ảnh

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn ảnh được chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                picAvatar.Image = Image.FromFile(filePath);

                // Lưu ảnh vào cơ sở dữ liệu (dưới dạng mảng byte)
                bool success = NhanVienBLL.SaveAvatar(nv.MaNV, filePath);

                if (success)
                {
                    MessageBox.Show("Ảnh đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi khi lưu ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Event Paint nếu cần vẽ gì đó
        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Bạn có thể xử lý các sự kiện vẽ nếu cần thiết
        }

        private void lblLoaiNV_Click(object sender, EventArgs e)
        {

        }
    }
}
