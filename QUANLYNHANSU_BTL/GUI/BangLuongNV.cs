using System;
using System.Data;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.DAL; // Dùng DAL để lấy dữ liệu từ database
using QUANLYNHANSU_BTL.DTO; // Dùng DTO nếu cần
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongNV : UserControl
    {
        private string maNV;

        public BangLuongNV(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV; // Nhận mã nhân viên từ form trước
            LoadBangLuongData(); // Lấy dữ liệu bảng lương
        }

        // Lấy dữ liệu bảng lương cho nhân viên theo mã nhân viên
        private void LoadBangLuongData()
        {
            // Lấy dữ liệu bảng lương cho mã nhân viên
            DataTable bangLuongData = BangLuongDAL.GetBangLuongByMaNV(maNV);

            if (bangLuongData != null && bangLuongData.Rows.Count > 0)
            {
                // Hiển thị thông tin bảng lương vào các label
                var row = bangLuongData.Rows[0]; // Chỉ lấy bản ghi đầu tiên (có thể thay đổi tùy vào nhu cầu)

                lblHoTen.Text = "Họ tên: " + row["HoTen"].ToString();
                lblChucVu.Text = "Chức vụ: " + row["ChucVu"].ToString();
                lblLuongCoBan.Text = "Lương cơ bản: " + Convert.ToDecimal(row["LuongCoBan"]).ToString("C");
                lblPhuCapChucVu.Text = "Phụ cấp chức vụ: " + Convert.ToDecimal(row["PhuCapChucVu"]).ToString("C");
                lblPhuCapKhac.Text = "Phụ cấp khác: " + Convert.ToDecimal(row["PhuCapKhac"]).ToString("C");
                lblGhiChu.Text = "Ghi chú: " + row["GhiChu"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu bảng lương cho nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
