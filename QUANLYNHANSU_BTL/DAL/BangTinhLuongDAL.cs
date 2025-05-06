using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class BangTinhLuongDAL
    {
        // Lấy danh sách bảng lương theo tháng
        public List<BangTinhLuongDTO> GetByMonth(DateTime month)
        {
            string query = @"
                SELECT 
                    tl.MaTinhLuong, 
                    nv.HoTen, 
                    nv.ChucVu,
                    tl.MaNV,
                    tl.ThangNam,
                    tl.SoNgayCong,
                    tl.SoNgayOT,
                    tl.LuongCoBan,
                    tl.PhuCapChucVu,
                    tl.PhuCapKhac,
                    tl.TienLuongOT,
                    tl.TienPhat,
                    tl.TongLuong
                FROM 
                    BangTinhLuong tl
                INNER JOIN NhanVien nv ON tl.MaNV = nv.MaNV
                WHERE 
                    FORMAT(tl.ThangNam, 'MM/yyyy') = @ThangNam";

            SqlParameter[] parameters = { new SqlParameter("@ThangNam", month.ToString("MM/yyyy")) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<BangTinhLuongDTO> list = new List<BangTinhLuongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BangTinhLuongDTO
                {
                    MaTinhLuong = row["MaTinhLuong"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    ThangNam = Convert.ToDateTime(row["ThangNam"]),
                    SoNgayCong = row["SoNgayCong"] != DBNull.Value ? Convert.ToInt32(row["SoNgayCong"]) : 0,  // Kiểm tra null và ép kiểu
                    SoNgayOT = row["SoNgayOT"] != DBNull.Value ? Convert.ToInt32(row["SoNgayOT"]) : 0,
                    LuongCoBan = row["LuongCoBan"] != DBNull.Value ? Convert.ToSingle(row["LuongCoBan"]) : 0f,
                    PhuCapChucVu = row["PhuCapChucVu"] != DBNull.Value ? Convert.ToSingle(row["PhuCapChucVu"]) : 0f,
                    PhuCapKhac = row["PhuCapKhac"] != DBNull.Value ? Convert.ToSingle(row["PhuCapKhac"]) : 0f,
                    TienLuongOT = row["TienLuongOT"] != DBNull.Value ? Convert.ToSingle(row["TienLuongOT"]) : 0f,
                    TienPhat = row["TienPhat"] != DBNull.Value ? Convert.ToSingle(row["TienPhat"]) : 0f,
                    TongLuong = row["TongLuong"] != DBNull.Value ? Convert.ToSingle(row["TongLuong"]) : 0f,
                });
            }
            return list;
        }

        // Thêm bảng tính lương
        public bool Insert(BangTinhLuongDTO bangTinhLuong)
        {
            string query = @"
                INSERT INTO BangTinhLuong (
                    MaTinhLuong, MaNV, ThangNam, SoNgayCong, SoNgayOT, 
                    LuongCoBan, PhuCapChucVu, PhuCapKhac, TienLuongOT, TienPhat, TongLuong)
                VALUES (
                    @MaTinhLuong, @MaNV, @ThangNam, @SoNgayCong, @SoNgayOT, 
                    @LuongCoBan, @PhuCapChucVu, @PhuCapKhac, @TienLuongOT, @TienPhat, @TongLuong)";

            SqlParameter[] parameters = {
                new SqlParameter("@MaTinhLuong", bangTinhLuong.MaTinhLuong),
                new SqlParameter("@MaNV", bangTinhLuong.MaNV),
                new SqlParameter("@ThangNam", bangTinhLuong.ThangNam),
                new SqlParameter("@SoNgayCong", bangTinhLuong.SoNgayCong),
                new SqlParameter("@SoNgayOT", bangTinhLuong.SoNgayOT),
                new SqlParameter("@LuongCoBan", bangTinhLuong.LuongCoBan),
                new SqlParameter("@PhuCapChucVu", bangTinhLuong.PhuCapChucVu),
                new SqlParameter("@PhuCapKhac", bangTinhLuong.PhuCapKhac),
                new SqlParameter("@TienLuongOT", bangTinhLuong.TienLuongOT),
                new SqlParameter("@TienPhat", bangTinhLuong.TienPhat),
                new SqlParameter("@TongLuong", bangTinhLuong.TongLuong)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật bảng tính lương
        public bool Update(BangTinhLuongDTO bangTinhLuong)
        {
            string query = @"
                UPDATE BangTinhLuong SET 
                    SoNgayCong = @SoNgayCong, 
                    SoNgayOT = @SoNgayOT, 
                    LuongCoBan = @LuongCoBan, 
                    PhuCapChucVu = @PhuCapChucVu, 
                    PhuCapKhac = @PhuCapKhac, 
                    TienLuongOT = @TienLuongOT, 
                    TienPhat = @TienPhat, 
                    TongLuong = @TongLuong
                WHERE MaTinhLuong = @MaTinhLuong";

            SqlParameter[] parameters = {
                new SqlParameter("@MaTinhLuong", bangTinhLuong.MaTinhLuong),
                new SqlParameter("@SoNgayCong", bangTinhLuong.SoNgayCong),
                new SqlParameter("@SoNgayOT", bangTinhLuong.SoNgayOT),
                new SqlParameter("@LuongCoBan", bangTinhLuong.LuongCoBan),
                new SqlParameter("@PhuCapChucVu", bangTinhLuong.PhuCapChucVu),
                new SqlParameter("@PhuCapKhac", bangTinhLuong.PhuCapKhac),
                new SqlParameter("@TienLuongOT", bangTinhLuong.TienLuongOT),
                new SqlParameter("@TienPhat", bangTinhLuong.TienPhat),
                new SqlParameter("@TongLuong", bangTinhLuong.TongLuong)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public List<BangTinhLuongDTO> SearchByMaNV(string maNV)
        {
            string query = @"
        SELECT 
            tl.MaTinhLuong, 
            nv.HoTen, 
            nv.ChucVu,
            tl.MaNV,
            tl.ThangNam,
            tl.SoNgayCong,
            tl.SoNgayOT,
            tl.LuongCoBan,
            tl.PhuCapChucVu,
            tl.PhuCapKhac,
            tl.TienLuongOT,
            tl.TienPhat,
            tl.TongLuong
        FROM 
            BangTinhLuong tl
        INNER JOIN NhanVien nv ON tl.MaNV = nv.MaNV
        WHERE 
            nv.MaNV = @MaNV";

            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<BangTinhLuongDTO> list = new List<BangTinhLuongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BangTinhLuongDTO
                {
                    MaTinhLuong = row["MaTinhLuong"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    ThangNam = Convert.ToDateTime(row["ThangNam"]),
                    SoNgayCong = Convert.ToInt32(row["SoNgayCong"]),
                    SoNgayOT = Convert.ToInt32(row["SoNgayOT"]),
                    LuongCoBan = Convert.ToSingle(row["LuongCoBan"]),
                    PhuCapChucVu = Convert.ToSingle(row["PhuCapChucVu"]),
                    PhuCapKhac = Convert.ToSingle(row["PhuCapKhac"]),
                    TienLuongOT = Convert.ToSingle(row["TienLuongOT"]),
                    TienPhat = Convert.ToSingle(row["TienPhat"]),
                    TongLuong = Convert.ToSingle(row["TongLuong"]),
                });
            }
            return list;
        }
        public List<BangTinhLuongDTO> GetPagedByMonth(DateTime month, int page, int pageSize)
        {
            string query = @"
        SELECT * FROM (
            SELECT 
                tl.MaTinhLuong, 
                nv.HoTen, 
                nv.ChucVu,
                tl.MaNV,
                tl.ThangNam,
                tl.SoNgayCong,
                tl.SoNgayOT,
                tl.LuongCoBan,
                tl.PhuCapChucVu,
                tl.PhuCapKhac,
                tl.TienLuongOT,
                tl.TienPhat,
                tl.TongLuong,
                ROW_NUMBER() OVER (ORDER BY nv.HoTen) AS RowNum
            FROM 
                BangTinhLuong tl
            INNER JOIN NhanVien nv ON tl.MaNV = nv.MaNV
            WHERE FORMAT(tl.ThangNam, 'MM/yyyy') = @ThangNam
        ) AS Temp
        WHERE RowNum BETWEEN @Start AND @End";

            SqlParameter[] parameters = {
        new SqlParameter("@ThangNam", month.ToString("MM/yyyy")),
        new SqlParameter("@Start", (page - 1) * pageSize + 1),
        new SqlParameter("@End", page * pageSize)
    };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<BangTinhLuongDTO> list = new List<BangTinhLuongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BangTinhLuongDTO
                {
                    MaTinhLuong = row["MaTinhLuong"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    ThangNam = Convert.ToDateTime(row["ThangNam"]),
                    SoNgayCong = Convert.ToInt32(row["SoNgayCong"]),
                    SoNgayOT = Convert.ToInt32(row["SoNgayOT"]),
                    LuongCoBan = Convert.ToSingle(row["LuongCoBan"]),
                    PhuCapChucVu = Convert.ToSingle(row["PhuCapChucVu"]),
                    PhuCapKhac = Convert.ToSingle(row["PhuCapKhac"]),
                    TienLuongOT = Convert.ToSingle(row["TienLuongOT"]),
                    TienPhat = Convert.ToSingle(row["TienPhat"]),
                    TongLuong = Convert.ToSingle(row["TongLuong"]),
                });
            }
            return list;
        }
        public BangTinhLuongDTO GetByMaTinhLuong(string maTinhLuong)
        {
            string query = @"
        SELECT 
            tl.MaTinhLuong, 
            nv.HoTen, 
            nv.ChucVu,
            tl.MaNV,
            tl.ThangNam,
            tl.SoNgayCong,
            tl.SoNgayOT,
            tl.LuongCoBan,
            tl.PhuCapChucVu,
            tl.PhuCapKhac,
            tl.TienLuongOT,
            tl.TienPhat,
            tl.TongLuong
        FROM 
            BangTinhLuong tl
        INNER JOIN NhanVien nv ON tl.MaNV = nv.MaNV
        WHERE 
            tl.MaTinhLuong = @MaTinhLuong";

            SqlParameter[] parameters = { new SqlParameter("@MaTinhLuong", maTinhLuong) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new BangTinhLuongDTO
            {
                MaTinhLuong = row["MaTinhLuong"].ToString(),
                HoTen = row["HoTen"].ToString(),
                ChucVu = row["ChucVu"].ToString(),
                MaNV = Convert.ToInt32(row["MaNV"]),
                ThangNam = Convert.ToDateTime(row["ThangNam"]),
                SoNgayCong = Convert.ToInt32(row["SoNgayCong"]),
                SoNgayOT = Convert.ToInt32(row["SoNgayOT"]),
                LuongCoBan = Convert.ToSingle(row["LuongCoBan"]),
                PhuCapChucVu = Convert.ToSingle(row["PhuCapChucVu"]),
                PhuCapKhac = Convert.ToSingle(row["PhuCapKhac"]),
                TienLuongOT = Convert.ToSingle(row["TienLuongOT"]),
                TienPhat = Convert.ToSingle(row["TienPhat"]),
                TongLuong = Convert.ToSingle(row["TongLuong"]),
            };
        }
        public bool Exists(int maNV, DateTime thangNam)
        {
            string query = "SELECT COUNT(*) FROM BangTinhLuong WHERE MaNV = @MaNV AND FORMAT(ThangNam, 'MM/yyyy') = @ThangNam";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@ThangNam", thangNam.ToString("MM/yyyy"))
        };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;  // Nếu có bản ghi thì trả về true
        }
        public static DataTable ThongKeTongLuongTheoThang()
        {
            string query = @"
                SELECT 
                    FORMAT(ThangNam, 'MM/yyyy') AS Thang,
                    SUM(TongLuong) AS TongTien
                FROM BangTinhLuong
                GROUP BY FORMAT(ThangNam, 'MM/yyyy')
                ORDER BY MIN(ThangNam)";
            return DatabaseHelper.ExecuteQuery(query);
        }
        public List<BangTinhLuongDTO> GetByMonthAndMaNV(DateTime month, string maNV)
        {
            string query = @"
        SELECT 
            tl.MaTinhLuong, 
            nv.HoTen, 
            nv.ChucVu,
            tl.MaNV,
            tl.ThangNam,
            tl.SoNgayCong,
            tl.SoNgayOT,
            tl.LuongCoBan,
            tl.PhuCapChucVu,
            tl.PhuCapKhac,
            tl.TienLuongOT,
            tl.TienPhat,
            tl.TongLuong
        FROM 
            BangTinhLuong tl
        INNER JOIN NhanVien nv ON tl.MaNV = nv.MaNV
        WHERE 
            FORMAT(tl.ThangNam, 'MM/yyyy') = @ThangNam AND tl.MaNV = @MaNV";

            SqlParameter[] parameters = {
        new SqlParameter("@ThangNam", month.ToString("MM/yyyy")),
        new SqlParameter("@MaNV", maNV)
    };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<BangTinhLuongDTO> list = new List<BangTinhLuongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BangTinhLuongDTO
                {
                    MaTinhLuong = row["MaTinhLuong"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    ThangNam = Convert.ToDateTime(row["ThangNam"]),
                    SoNgayCong = Convert.ToInt32(row["SoNgayCong"]),
                    SoNgayOT = Convert.ToInt32(row["SoNgayOT"]),
                    LuongCoBan = Convert.ToSingle(row["LuongCoBan"]),
                    PhuCapChucVu = Convert.ToSingle(row["PhuCapChucVu"]),
                    PhuCapKhac = Convert.ToSingle(row["PhuCapKhac"]),
                    TienLuongOT = Convert.ToSingle(row["TienLuongOT"]),
                    TienPhat = Convert.ToSingle(row["TienPhat"]),
                    TongLuong = Convert.ToSingle(row["TongLuong"]),
                });
            }
            return list;
        }



        // 2. Tổng tiền lương theo từng phòng ban (JOIN NhanVien)
        public static DataTable ThongKeTongLuongTheoPhongBan()
        {
            string query = @"
                SELECT 
                    nv.PhongBan,
                    SUM(btl.TongLuong) AS TongTien
                FROM BangTinhLuong btl
                JOIN NhanVien nv ON btl.MaNV = nv.MaNV
                GROUP BY nv.PhongBan";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // 3. Lương trung bình theo từng tháng
        public static DataTable ThongKeLuongTrungBinhTheoThang()
        {
            string query = @"
                SELECT 
                    FORMAT(ThangNam, 'MM/yyyy') AS Thang,
                    AVG(TongLuong) AS LuongTB
                FROM BangTinhLuong
                GROUP BY FORMAT(ThangNam, 'MM/yyyy')
                ORDER BY MIN(ThangNam)";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // 4. Lương từng phòng ban theo tháng (stacked column)
        public static DataTable ThongKeLuongPhongBanTheoThang()
        {
            string query = @"
                SELECT 
                    FORMAT(btl.ThangNam, 'MM/yyyy') AS Thang,
                    nv.PhongBan,
                    SUM(btl.TongLuong) AS TongTien
                FROM BangTinhLuong btl
                JOIN NhanVien nv ON btl.MaNV = nv.MaNV
                GROUP BY FORMAT(btl.ThangNam, 'MM/yyyy'), nv.PhongBan
                ORDER BY MIN(btl.ThangNam), nv.PhongBan";
            return DatabaseHelper.ExecuteQuery(query);
        }
        public DataTable GetTotalSalaryByMaNV(string maNV)
        {
            string query = @"
            SELECT 
                FORMAT(ThangNam, 'MM/yyyy') AS Thang,
                SUM(TongLuong) AS TongTien
            FROM 
                BangTinhLuong
            WHERE 
                MaNV = @MaNV
            GROUP BY 
                FORMAT(ThangNam, 'MM/yyyy')
            ORDER BY
                FORMAT(ThangNam, 'MM/yyyy')";

            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            return DatabaseHelper.ExecuteQuery(query, parameters); // Trả về DataTable chứa thông tin tổng lương theo từng tháng
        }





        // Xóa bảng tính lương
        public bool Delete(string maTinhLuong)
        {
            string query = "DELETE FROM BangTinhLuong WHERE MaTinhLuong = @MaTinhLuong";
            SqlParameter[] parameters = { new SqlParameter("@MaTinhLuong", maTinhLuong) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public int GetTotalCountByMonth(DateTime month)
        {
            string query = "SELECT COUNT(*) FROM BangTinhLuong WHERE FORMAT(ThangNam, 'MM/yyyy') = @ThangNam";
            SqlParameter[] parameters = { new SqlParameter("@ThangNam", month.ToString("MM/yyyy")) };
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
        }

    }
}
