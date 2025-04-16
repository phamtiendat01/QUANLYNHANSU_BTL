using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongPopupForm : Form
    {
        private string maNV;

        // Constructor cho Thêm
        public BangLuongPopupForm()
        {
            InitializeComponent();
        }

        // Constructor cho Sửa
        public BangLuongPopupForm(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            LoadData(maNV); // Tải dữ liệu nếu là sửa
        }

        // Tải dữ liệu cho popup khi sửa
        public void LoadData(string maNV)
        {
            DataTable dt = BangLuongBLL.GetBangLuongByMaNV(maNV);

            if (dt.Rows.Count > 0)
            {
                txtMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtChucVu.Text = dt.Rows[0]["ChucVu"].ToString();  // Thêm Chức Vụ
                txtLuongCoBan.Text = dt.Rows[0]["LuongCoBan"].ToString();
                txtPhuCapChucVu.Text = dt.Rows[0]["PhuCapChucVu"].ToString();
                txtPhuCapKhac.Text = dt.Rows[0]["PhuCapKhac"].ToString();
                txtGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
            }
        }

        // Sự kiện khi nhấn "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Tạo đối tượng bảng lương và gán các giá trị
            BangLuongDTO bangLuong = new BangLuongDTO()
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                ChucVu = txtChucVu.Text,  // Lưu Chức Vụ
                LuongCoBan = decimal.Parse(txtLuongCoBan.Text),
                PhuCapChucVu = decimal.Parse(txtPhuCapChucVu.Text),
                PhuCapKhac = decimal.Parse(txtPhuCapKhac.Text),
                GhiChu = txtGhiChu.Text
            };

            bool result = false;

            // Nếu có mã NV => thực hiện cập nhật, ngược lại thực hiện thêm mới
            if (!string.IsNullOrEmpty(maNV))
            {
                result = BangLuongBLL.UpdateBangLuong(bangLuong);
            }
            else
            {
                result = BangLuongBLL.AddBangLuong(bangLuong);
            }

            if (result)
            {
                MessageBox.Show("Thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        // Sự kiện khi nhấn "Hủy"
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng popup
        }

        // Tìm kiếm mã nhân viên và hiển thị Họ tên, Chức vụ khi nhấn Enter

        // Sự kiện nhấn Enter khi nhập Mã nhân viên
        private void txtMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Khi nhấn Enter
            {
                string maNV = txtMaNV.Text.Trim();
                if (!string.IsNullOrEmpty(maNV))
                {
                    // Gọi hàm truy vấn bảng NhanVien để lấy thông tin
                    DataTable dt = NhanVienDAL.GetNhanVienByMaNV(maNV);

                    // Kiểm tra xem có dữ liệu trả về không
                    if (dt.Rows.Count > 0)
                    {
                        txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();  // Hiển thị Họ tên
                        txtChucVu.Text = dt.Rows[0]["ChucVu"].ToString();  // Hiển thị Chức vụ
                    }
                    else
                    {
                        txtHoTen.Text = "";
                        txtChucVu.Text = "";
                        MessageBox.Show("Mã nhân viên không tồn tại.");
                    }
                }
            }
        }

        private void BangLuongPopupForm_Load(object sender, EventArgs e)
        {

        }
    }
}


        // Chức năng Tìm kiếm theo mã nhân viên trong datagridview
        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    // Logic để lọc dữ liệu trong datagridview khi thay đổi mã nhân viên
        //    string searchKeyword = txtSearch.Text.Trim();
        //    // Gọi phương thức tìm kiếm từ BLL và cập nhật lại DataGridView
        //    dgvBangLuong.DataSource = BangLuongBLL.SearchByMaNV(searchKeyword);
        //}

        //private void BangLuongPopupForm_Load(object sender, EventArgs e)
        //{
        //    // Nếu cần thực hiện các chức năng khi popup form được load, thêm vào đây.
    