using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class CongTacDAL
    {
        // Lấy tiến trình công tác theo MaNV
        public static List<CongTacDTO> GetAllCongTac()
        {
            string query = "SELECT * FROM CongTac";  // Lấy toàn bộ dữ liệu
            DataTable dt = DatabaseHelper.ExecuteQuery(query);  // Thực hiện truy vấn
            List<CongTacDTO> congTacList = new List<CongTacDTO>();

            foreach (DataRow row in dt.Rows)
            {
                CongTacDTO congTac = new CongTacDTO
                {
                    MaCongTac = Convert.ToInt32(row["MaCongTac"]),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    TuNgay = Convert.ToDateTime(row["TuNgay"]),
                    DenNgay = row.IsNull("DenNgay") ? (DateTime?)null : Convert.ToDateTime(row["DenNgay"]),
                    MoTa = row["MoTa"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    GhiChu = row["GhiChu"].ToString()
                };
                congTacList.Add(congTac);
            }

            return congTacList;
        }


        // Phương thức thêm tiến trình công tác
        public static bool AddCongTac(CongTacDTO congTac)
        {
            string query = "INSERT INTO CongTac (MaNV, HoTen, ChucVu, TuNgay, DenNgay, MoTa, TrangThai, GhiChu) VALUES (@maNV, @hoTen, @chucVu, @tuNgay, @denNgay, @moTa, @trangThai, @ghiChu)";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@maNV", congTac.MaNV),
                new SqlParameter("@hoTen", congTac.HoTen),
                new SqlParameter("@chucVu", congTac.ChucVu),
                new SqlParameter("@tuNgay", congTac.TuNgay),
                new SqlParameter("@denNgay", congTac.DenNgay ?? (object)DBNull.Value),  // Nullable DateTime
                new SqlParameter("@moTa", congTac.MoTa),
                new SqlParameter("@trangThai", congTac.TrangThai),
                new SqlParameter("@ghiChu", congTac.GhiChu)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Phương thức cập nhật tiến trình công tác
        public static bool UpdateCongTac(CongTacDTO congTac)
        {
            string query = "UPDATE CongTac SET HoTen = @hoTen, ChucVu = @chucVu, TuNgay = @tuNgay, DenNgay = @denNgay, MoTa = @moTa, TrangThai = @trangThai, GhiChu = @ghiChu WHERE MaCongTac = @maCongTac";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@maCongTac", congTac.MaCongTac),
                new SqlParameter("@hoTen", congTac.HoTen),
                new SqlParameter("@chucVu", congTac.ChucVu),
                new SqlParameter("@tuNgay", congTac.TuNgay),
                new SqlParameter("@denNgay", congTac.DenNgay ?? (object)DBNull.Value),  // Nullable DateTime
                new SqlParameter("@moTa", congTac.MoTa),
                new SqlParameter("@trangThai", congTac.TrangThai),
                new SqlParameter("@ghiChu", congTac.GhiChu)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Phương thức xóa tiến trình công tác
        public static bool DeleteCongTac(int maCongTac)
        {
            string query = "DELETE FROM CongTac WHERE MaCongTac = @maCongTac";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@maCongTac", maCongTac)  // Sử dụng kiểu int
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Phương thức lọc tiến trình công tác theo khoảng thời gian
        public static DataTable FilterCongTacByDate(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT * FROM CongTac WHERE TuNgay >= @fromDate AND DenNgay <= @toDate";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Tìm kiếm tiến trình công tác
        // Phương thức tìm kiếm tiến trình công tác theo mã nhân viên hoặc tên nhân viên
        public static DataTable SearchCongTac(int maNV, string hoTen)
        {
            string query = "SELECT * FROM CongTac WHERE MaNV = @maNV AND HoTen LIKE @hoTen";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@hoTen", "%" + hoTen + "%")  // Tìm kiếm tên nhân viên theo từ khóa
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Sửa phương thức này để nhận tham số là int
        public static List<CongTacDTO> GetCongTacByMaCongTac(int maCongTac)
        {
            string query = "SELECT * FROM CongTac WHERE MaCongTac = @maCongTac";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@maCongTac", maCongTac)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            List<CongTacDTO> congTacList = new List<CongTacDTO>();

            foreach (DataRow row in dt.Rows)
            {
                CongTacDTO congTac = new CongTacDTO
                {
                    MaCongTac = Convert.ToInt32(row["MaCongTac"]),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    TuNgay = Convert.ToDateTime(row["TuNgay"]),
                    DenNgay = row.IsNull("DenNgay") ? (DateTime?)null : Convert.ToDateTime(row["DenNgay"]),
                    MoTa = row["MoTa"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    GhiChu = row["GhiChu"].ToString()
                };
                congTacList.Add(congTac);
            }

            return congTacList;
        }

        // Lấy tổng số bản ghi
        public static int GetTotalRecords()
        {
            string query = "SELECT COUNT(*) FROM CongTac";
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
        }
    }
}
