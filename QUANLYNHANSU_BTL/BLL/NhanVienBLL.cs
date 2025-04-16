using System;
using System.Collections.Generic;
using System.Data;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        // ✅ Lấy danh sách nhân viên
        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return nhanVienDAL.LayDanhSachNhanVien();
        }
        public List<string> LayDanhSachPhongBan()
        {
            return nhanVienDAL.LayDanhSachPhongBan();
        }


        // ✅ Phân trang danh sách nhân viên
        public List<NhanVienDTO> LayDanhSachPhanTrang(int page, int pageSize)
        {
            return nhanVienDAL.LayDanhSachPhanTrang(page, pageSize);
        }

        // ✅ Tìm kiếm nhân viên theo từ khóa
        public List<NhanVienDTO> TimKiemNhanVien(string keyword)
        {
            return nhanVienDAL.TimNhanVien(keyword);
        }

        // ✅ Lọc nhân viên theo phòng ban
        public List<NhanVienDTO> LocNhanVienTheoPhongBan(string phongBan)
        {
            return nhanVienDAL.LocTheoPhongBan(phongBan);
        }

        // ✅ Lọc nhân viên theo chức vụ
        public List<NhanVienDTO> LocNhanVienTheoChucVu(string chucVu)
        {
            return nhanVienDAL.LocTheoChucVu(chucVu);
        }

        // ✅ Lọc nhân viên theo loại nhân viên
        public List<NhanVienDTO> LocNhanVienTheoLoaiNV(string loaiNV)
        {
            return nhanVienDAL.LocTheoLoaiNV(loaiNV);
        }

        // ✅ Thêm nhân viên mới
        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.ThemNhanVien(nhanVien);
        }

        // ✅ Cập nhật nhân viên
        public void CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.CapNhatNhanVien(nhanVien);
        }

        // ✅ Lấy danh sách nhân viên đầy đủ (không phân trang)

        public static List<NhanVienDTO> LayDanhSachNhanVienFull()
        {
            return NhanVienDAL.LayDanhSachNhanVienFull();
        }
        public NhanVienDTO GetNhanVienByMa(int maNV)
        {
            return dal.GetNhanVienByMa(maNV);
        }


        // ✅ Đếm tổng số nhân viên
        public int DemTongSoNhanVien()
        {
            return nhanVienDAL.DemTongSoNhanVien();
        }
        public  NhanVienDTO LayNhanVienTheoMa(string maNV)
        {
            return nhanVienDAL.LayNhanVienTheoMa(maNV);
        }
        private NhanVienDAL dal = new NhanVienDAL();

        public string LayHoTen(string maNV)
        {
            var nv = dal.TimTheoMa(maNV);
            return nv != null ? nv.HoTen : "";
        }
        public static DataTable GetNhanVienByMaNV(string maNV)
        {
            return NhanVienDAL.GetNhanVienByMaNV(maNV); // Gọi phương thức trong DAL
        }


        // ✅ Chuyển danh sách nhân viên sang DataTable để xuất Excel
        public DataTable ConvertListToDataTable(List<NhanVienDTO> danhSach)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Phòng Ban");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("Số Điện Thoại");

            foreach (var nv in danhSach)
            {
                dt.Rows.Add(nv.MaNV, nv.HoTen, nv.PhongBan, nv.NgaySinh, nv.GioiTinh, nv.SDT);
            }
            return dt;
        }
        // Thống kê số lượng nhân viên theo chức vụ
        public Dictionary<string, int> ThongKeTheoChucVu()
        {
            return nhanVienDAL.ThongKeTheoChucVu();
        }

        // Thống kê số lượng nhân viên theo năm sinh
        public Dictionary<int, int> ThongKeTheoNamSinh()
        {
            return nhanVienDAL.ThongKeTheoNamSinh();
        }
        public static NhanVienDTO GetNhanVienInfo(int maNV)
        {
            DataTable dt = NhanVienDAL.GetNhanVienById(maNV);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];  // Lấy hàng đầu tiên
                return new NhanVienDTO
                {
                    MaNV = row["MaNV"].ToString(),
                    PhongBan = row["PhongBan"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                    CMND_CCCD = row["CMND_CCCD"].ToString(),
                    GioiTinh = row["GioiTinh"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    SDT = row["SDT"].ToString(),
                    LoaiNV = row["LoaiNV"].ToString(),
                    HocVan = row["HocVan"].ToString(),
                    Avatar = row["Avatar"].ToString() // Nếu có cột ảnh
                };
            }

            return null;  // Trả về null nếu không tìm thấy
        }
        public static bool UpdateNhanVienImage(int maNV, string avatar)
        {
            // Lưu đường dẫn ảnh vào CSDL
            bool result = NhanVienDAL.SaveEmployeeImage(maNV, avatar); // Lưu ảnh vào cơ sở dữ liệu
            return result;  // Trả về kết quả lưu thành công (true/false)
        }

        // Hàm lưu ảnh trực tiếp vào cơ sở dữ liệu dưới dạng mảng byte (VARBINARY)
        public static bool SaveAvatar(string maNV, string imagePath)
        {
            int maNvInt;
            if (int.TryParse(maNV, out maNvInt))  // Chuyển từ string sang int
            {
                return NhanVienDAL.SaveEmployeeImage(maNvInt, imagePath);
            }
            else
            {
                MessageBox.Show("MaNV không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string GetAvatar(int maNV)
        {
            return NhanVienDAL.GetAvatarByMaNV(maNV);  // Gọi DAL để lấy ảnh
        }



        // Hàm chuyển ảnh từ file thành Base64 (nếu bạn cần sử dụng Base64)
        public static string ConvertImageToBase64(string filePath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(filePath);
            return Convert.ToBase64String(imageBytes);
        }

        // Thống kê số lượng nhân viên theo phòng ban
        public Dictionary<string, int> ThongKeTheoPhongBan()
        {
            return nhanVienDAL.ThongKeTheoPhongBan();
        }


        // ✅ Xóa nhân viên theo mã
        public void XoaNhanVien(string maNV)
        {
            nhanVienDAL.XoaNhanVien(maNV);
        }

    }
}
