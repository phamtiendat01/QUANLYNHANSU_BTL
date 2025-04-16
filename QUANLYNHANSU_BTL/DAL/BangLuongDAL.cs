using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class BangLuongDAL
    {
        public static DataTable GetBangLuong(int page, int pageSize)
        {
            string query = "SELECT * FROM BangLuong ORDER BY MaNV OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Offset", (page - 1) * pageSize),
                new SqlParameter("@PageSize", pageSize)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public BangLuongDTO GetBangLuongByMaNV(int maNV)
        {
            string query = "SELECT LuongCoBan, PhuCapChucVu, PhuCapKhac FROM BangLuong WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new BangLuongDTO
                {
                    LuongCoBan = Convert.ToDecimal(row["LuongCoBan"]),
                    PhuCapChucVu = Convert.ToDecimal(row["PhuCapChucVu"]),
                    PhuCapKhac = Convert.ToDecimal(row["PhuCapKhac"])


                };
            }
            return null;
        }




        public static int GetTotalRows()
        {
            string query = "SELECT COUNT(*) FROM BangLuong";
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
        }

        public static void AddBangLuong(BangLuongDTO bangLuong)
        {
            string query = "INSERT INTO BangLuong (MaNV, HoTen, ChucVu, LuongCoBan, PhuCapChucVu, PhuCapKhac, GhiChu) " +
                           "VALUES (@MaNV, @HoTen, @ChucVu, @LuongCoBan, @PhuCapChucVu, @PhuCapKhac, @GhiChu)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", bangLuong.MaNV),
                new SqlParameter("@HoTen", bangLuong.HoTen),
                new SqlParameter("@ChucVu", bangLuong.ChucVu),
                new SqlParameter("@LuongCoBan", bangLuong.LuongCoBan),
                new SqlParameter("@PhuCapChucVu", bangLuong.PhuCapChucVu),
                new SqlParameter("@PhuCapKhac", bangLuong.PhuCapKhac),
                new SqlParameter("@GhiChu", bangLuong.GhiChu)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static void UpdateBangLuong(BangLuongDTO bangLuong)
        {
            string query = "UPDATE BangLuong SET HoTen = @HoTen, ChucVu = @ChucVu, LuongCoBan = @LuongCoBan, " +
                           "PhuCapChucVu = @PhuCapChucVu, PhuCapKhac = @PhuCapKhac, GhiChu = @GhiChu WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", bangLuong.MaNV),
                new SqlParameter("@HoTen", bangLuong.HoTen),
                new SqlParameter("@ChucVu", bangLuong.ChucVu),
                new SqlParameter("@LuongCoBan", bangLuong.LuongCoBan),
                new SqlParameter("@PhuCapChucVu", bangLuong.PhuCapChucVu),
                new SqlParameter("@PhuCapKhac", bangLuong.PhuCapKhac),
                new SqlParameter("@GhiChu", bangLuong.GhiChu)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static void DeleteBangLuong(string maNV)
        {
            string query = "DELETE FROM BangLuong WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
        public static string GetHoTenByMaNV(string maNV)
        {
            string query = "SELECT HoTen FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["HoTen"].ToString();
            }
            return string.Empty;
        }
        public static DataTable GetBangLuongByMaNV(string maNV)
        {
            // Gọi phương thức từ DAL để lấy dữ liệu theo mã nhân viên
            string query = "SELECT * FROM BangLuong WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            };

            // Trả về kết quả từ DatabaseHelper.ExecuteQuery
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }



        public static DataTable SearchByMaNV(string maNV)
        {
            string query = "SELECT * FROM BangLuong WHERE MaNV LIKE @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", "%" + maNV + "%")
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
