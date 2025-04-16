using System;
using System.Collections.Generic;
using System.Linq;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;
using System.Windows.Forms;

namespace QUANLYNHANSU_BTL.BLL
{
    public static class AutoSalaryCalculation
    {
        // Phương thức kiểm tra xem có phải là ngày cuối tháng không
        public static bool IsLastDayOfMonth(DateTime date)
        {
            return date.Day == DateTime.DaysInMonth(date.Year, date.Month);
        }

        // Phương thức kiểm tra và tính lương nếu là ngày cuối tháng
        public static void CheckAndCalculateSalary()
        {
            DateTime currentDate = DateTime.Now;

            // Kiểm tra nếu hôm nay là ngày cuối tháng
            if (IsLastDayOfMonth(currentDate))
            {
                // Nếu đúng là ngày cuối tháng, gọi phương thức tính lương
                CalculateAndUpdateLuongThang(currentDate);
                Console.WriteLine("Tính lương cho tháng: " + currentDate.ToString("MM/yyyy"));

            }
        }

        // Phương thức tính lương cho tháng đã chọn
        public static void CalculateAndUpdateLuongThang(DateTime month)
        {
            BangTinhLuongBLL bangTinhLuongBLL = new BangTinhLuongBLL();
            // Lấy danh sách nhân viên
            var employees = new NhanVienDAL().LayDanhSachNhanVien();

            foreach (var employee in employees)
            {
                // Lấy thông tin bảng lương của nhân viên này
                var bangTinhLuong = new BangTinhLuongDTO
                {
                    MaNV = Convert.ToInt32(employee.MaNV),  // Chuyển đổi MaNV từ string sang int
                    ThangNam = month,
                    SoNgayCong = CalculateSoNgayCong(employee.MaNV, month),
                    SoNgayOT = CalculateSoNgayOT(employee.MaNV, month),
                    LuongCoBan = GetLuongCoBan(employee.MaNV),
                    PhuCapChucVu = GetPhuCapChucVu(employee.MaNV),
                    PhuCapKhac = GetPhuCapKhac(employee.MaNV),
                    TienLuongOT = CalculateTienLuongOT(employee.MaNV, month),
                    TienPhat = CalculateTienPhat(employee.MaNV, month),
                    TongLuong = CalculateTongLuong(employee.MaNV, month)
                };

                // Cập nhật bảng tính lương
                if (!bangTinhLuongBLL.Exists(bangTinhLuong.MaNV, bangTinhLuong.ThangNam))
                {
                    bangTinhLuongBLL.Insert(bangTinhLuong); // Thêm mới vào bảng lương
                }
                else
                {
                    bangTinhLuongBLL.Update(bangTinhLuong); // Cập nhật bảng lương nếu đã có
                }
            }

            MessageBox.Show("Đã tính lương tháng " + month.ToString("MM/yyyy"));
        }

        // Các phương thức tính toán (có thể sử dụng các phương thức tương tự từ DAL hoặc BLL)
        private static int CalculateSoNgayCong(string maNV, DateTime month)
        {
            // Tính số ngày công (có thể dựa vào dữ liệu khác, ví dụ như đi làm hay nghỉ)
            return 22; // Số ngày công mặc định (có thể sửa theo nhu cầu)
        }

        private static int CalculateSoNgayOT(string maNV, DateTime month)
        {
            // Tính số ngày OT (làm thêm)
            return 5; // Số ngày OT mặc định (có thể sửa theo nhu cầu)
        }

        private static float GetLuongCoBan(string maNV)
        {
            // Lấy lương cơ bản từ thông tin nhân viên
            NhanVienDTO nv = new NhanVienDAL().LayNhanVienTheoMa(maNV);
            return 5000000; // Giá trị lương cơ bản mặc định (có thể sửa theo nhu cầu)
        }

        private static float GetPhuCapChucVu(string maNV)
        {
            // Lấy phụ cấp chức vụ từ thông tin nhân viên
            return 1000000; // Phụ cấp chức vụ mặc định (có thể sửa theo nhu cầu)
        }

        private static float GetPhuCapKhac(string maNV)
        {
            // Lấy phụ cấp khác từ thông tin nhân viên
            return 500000; // Phụ cấp khác mặc định (có thể sửa theo nhu cầu)
        }

        private static float CalculateTienLuongOT(string maNV, DateTime month)
        {
            // Tính tiền lương làm thêm (OT)
            return 1000000; // Tiền lương OT mặc định (có thể sửa theo nhu cầu)
        }

        private static float CalculateTienPhat(string maNV, DateTime month)
        {
            // Tính tiền phạt (nếu có)
            return 0; // Tiền phạt mặc định là 0 (có thể sửa theo nhu cầu)
        }

        private static float CalculateTongLuong(string maNV, DateTime month)
        {
            // Tính tổng lương = Lương cơ bản + phụ cấp + tiền OT - tiền phạt
            float luongCoBan = GetLuongCoBan(maNV);
            float phuCapChucVu = GetPhuCapChucVu(maNV);
            float phuCapKhac = GetPhuCapKhac(maNV);
            float tienLuongOT = CalculateTienLuongOT(maNV, month);
            float tienPhat = CalculateTienPhat(maNV, month);

            return luongCoBan + phuCapChucVu + phuCapKhac + tienLuongOT - tienPhat;
        }
    }
}
