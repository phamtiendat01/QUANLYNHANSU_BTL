using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class BoPhanDAL
    {
        // ✅ Lấy danh sách bộ phận có phân trang
        public List<BoPhanDTO> LayDanhSachPhanTrang(int pageNumber, int pageSize)
        {
            List<BoPhanDTO> danhSach = new List<BoPhanDTO>();
            string query = @"
                SELECT MaPB, TenPB 
                FROM (
                    SELECT MaPB, TenPB, ROW_NUMBER() OVER (ORDER BY MaPB) AS RowNum
                    FROM BoPhan
                ) AS A
                WHERE RowNum BETWEEN @StartRow AND @EndRow";

            SqlParameter[] parameters =
            {
                new SqlParameter("@StartRow", (pageNumber - 1) * pageSize + 1),
                new SqlParameter("@EndRow", pageNumber * pageSize)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new BoPhanDTO
                {
                    MaPB = row["MaPB"].ToString(),
                    TenPB = row["TenPB"].ToString()
                });
            }
            return danhSach;
        }

        // ✅ Lấy toàn bộ danh sách (Xuất Excel)
        public List<BoPhanDTO> LayDanhSachToanBo()
        {
            List<BoPhanDTO> danhSach = new List<BoPhanDTO>();
            string query = "SELECT MaPB, TenPB FROM BoPhan";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new BoPhanDTO
                {
                    MaPB = row["MaPB"].ToString(),
                    TenPB = row["TenPB"].ToString()
                });
            }
            return danhSach;
        }

        // ✅ Đếm tổng số bộ phận (Phục vụ phân trang)
        public int DemTongSoBoPhan()
        {
            string query = "SELECT COUNT(*) FROM BoPhan";
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
        }

        // ✅ Lấy bộ phận theo mã
        public DataRow LayBoPhanTheoMa(string maBP) // ✅ Đổi thành string
        {
            string query = "SELECT * FROM BoPhan WHERE MaPB = @MaPB";
            SqlParameter[] parameters = { new SqlParameter("@MaPB", SqlDbType.NVarChar) { Value = maBP } }; // ✅ Đảm bảo kiểu dữ liệu phù hợp

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }


        // ✅ Tìm kiếm phòng ban theo từ khóa
        public List<BoPhanDTO> TimBoPhan(string keyword)
        {
            List<BoPhanDTO> danhSach = new List<BoPhanDTO>();
            string query = "SELECT MaPB, TenPB FROM BoPhan WHERE MaPB LIKE @Keyword OR TenPB LIKE @Keyword";

            SqlParameter[] parameters = { new SqlParameter("@Keyword", "%" + keyword + "%") };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new BoPhanDTO
                {
                    MaPB = row["MaPB"].ToString(),
                    TenPB = row["TenPB"].ToString()
                });
            }
            return danhSach;
        }

        // ✅ Thêm mới phòng ban
        public void ThemBoPhan(BoPhanDTO boPhan)
        {
            string query = "INSERT INTO BoPhan (MaPB, TenPB) VALUES (@MaPB, @TenPB)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPB", boPhan.MaPB),
                new SqlParameter("@TenPB", boPhan.TenPB)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // ✅ Cập nhật phòng ban
        public void CapNhatBoPhan(BoPhanDTO boPhan)
        {
            string query = "UPDATE BoPhan SET TenPB = @TenPB WHERE MaPB = @MaPB";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPB", boPhan.MaPB),
                new SqlParameter("@TenPB", boPhan.TenPB)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // ✅ Xóa phòng ban
        public void XoaBoPhan(string maPB)
        {
            string query = "DELETE FROM BoPhan WHERE MaPB = @MaPB";
            SqlParameter[] parameters = { new SqlParameter("@MaPB", maPB) };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
