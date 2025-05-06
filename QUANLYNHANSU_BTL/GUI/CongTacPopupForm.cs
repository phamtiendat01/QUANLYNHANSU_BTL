using System;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class CongTacPopupForm : Form
    {
        private int maCongTac;  // Biến lưu mã tiến trình công tác (sửa thành int)

        public CongTacPopupForm(int maCongTac)  // Constructor nhận tham số kiểu int
        {
            InitializeComponent();
            this.maCongTac = maCongTac;
            LoadDataForEdit(maCongTac);  // Gọi phương thức LoadDataForEdit và truyền tham số kiểu int
        }

        // Đổ dữ liệu vào form khi sửa
        private void LoadDataForEdit(int maCongTac)
        {
            var congTacBLL = new CongTacBLL();
            var congTacList = congTacBLL.GetCongTacByMaCongTac(maCongTac);  // Lấy tiến trình công tác theo mã công tác

            if (congTacList.Count > 0)
            {
                var congTac = congTacList[0]; // Dữ liệu cần sửa
                txtMaNV.Text = congTac.MaNV.ToString();  // Mã nhân viên
                txtHoTen.Text = congTac.HoTen;           // Họ tên
                txtChucVu.Text = congTac.ChucVu;         // Chức vụ
                txtMoTa.Text = congTac.MoTa;             // Mô tả công việc
                dtpTuNgay.Value = congTac.TuNgay;       // Ngày bắt đầu
                dtpDenNgay.Value = congTac.DenNgay ?? DateTime.Now; // Ngày kết thúc (nếu có)
                cmbTrangThai.SelectedItem = congTac.TrangThai; // Trạng thái công tác
                txtGhiChu.Text = congTac.GhiChu;        // Ghi chú
            }
        }

        // Khi nhấn "Lưu" thực hiện thêm mới hoặc sửa
        private void btnSave_Click(object sender, EventArgs e)
        {
            var congTacBLL = new CongTacBLL();
            var congTac = new CongTacDTO();

            // Kiểm tra mã nhân viên có hợp lệ không
            int maNV;
            if (int.TryParse(txtMaNV.Text, out maNV))
            {
                congTac.MaNV = maNV;
            }
            else
            {
                MessageBox.Show("Mã nhân viên không hợp lệ, vui lòng nhập số.");
                return; // Dừng lại nếu mã nhân viên không hợp lệ
            }

            // Tiếp tục lấy các giá trị khác từ form
            congTac.HoTen = txtHoTen.Text;
            congTac.ChucVu = txtChucVu.Text;
            congTac.TuNgay = dtpTuNgay.Value;
            congTac.DenNgay = dtpDenNgay.Value;
            congTac.MoTa = txtMoTa.Text;
            congTac.GhiChu = txtGhiChu.Text;
            congTac.TrangThai = cmbTrangThai.SelectedItem.ToString();

            if (maCongTac == 0)  // Thêm mới (MaCongTac mặc định là 0 khi thêm mới)
            {
                bool result = congTacBLL.AddCongTac(congTac);
                if (result)
                    MessageBox.Show("Thêm tiến trình thành công!");
            }
            else // Sửa
            {
                congTac.MaCongTac = maCongTac;  // Sử dụng maCongTac từ constructor
                bool result = congTacBLL.UpdateCongTac(congTac);
                if (result)
                    MessageBox.Show("Sửa tiến trình thành công!");
            }

            this.Close(); // Đóng form sau khi lưu
        }

        // Khi nhấn "Hủy", đóng form mà không lưu
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CongTacPopupForm_Load(object sender, EventArgs e)
        {
        }
    }
}
