using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;


namespace QUANLYNHANSU_BTL.DAL
{
    public class ChamCongDAL
    {
        public List<ChamCong> GetAll()
        {
            List<ChamCong> list = new List<ChamCong>();
            string query = "SELECT * FROM ChamCong";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(DataRowToChamCong(row));
            }
            return list;
        }

        public List<ChamCong> GetPaged(int page, int pageSize)
        {
            string query = $"SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY MaCC DESC) AS RowNum FROM ChamCong) AS Temp WHERE RowNum BETWEEN {(page - 1) * pageSize + 1} AND {page * pageSize}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<ChamCong> list = new List<ChamCong>();
            foreach (DataRow row in dt.Rows)
                list.Add(DataRowToChamCong(row));
            return list;
        }

        public int GetTotalCount()
        {
            string query = "SELECT COUNT(*) FROM ChamCong";
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
        }

        public List<ChamCong> Search(string maNV)
        {
            string query = "SELECT * FROM ChamCong WHERE MaNV LIKE @MaNV";
            SqlParameter[] p = { new SqlParameter("@MaNV", "%" + maNV + "%") };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, p);
            List<ChamCong> list = new List<ChamCong>();
            foreach (DataRow row in dt.Rows)
                list.Add(DataRowToChamCong(row));
            return list;
        }

        public List<ChamCong> FilterByDate(DateTime date)
        {
            // Đảm bảo định dạng ngày đúng để so sánh chính xác
            string query = "SELECT * FROM ChamCong WHERE CAST(Ngay AS DATE) = @Ngay";
            SqlParameter[] p = { new SqlParameter("@Ngay", date) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, p);

            List<ChamCong> list = new List<ChamCong>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(DataRowToChamCong(row));  // Chuyển từ DataRow thành đối tượng ChamCong
            }

            return list;
        }


        // Phương thức kiểm tra chấm công ngày
        public static bool KiemTraChamCongTheoNgay(string maNV, DateTime ngay)
        {
            // Truy vấn SQL để kiểm tra xem đã có chấm công cho nhân viên và ngày đó chưa
            string query = "SELECT COUNT(*) FROM ChamCong WHERE MaNV = @MaNV AND Ngay = @Ngay";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@Ngay", ngay)
        };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0; // Nếu count > 0 nghĩa là nhân viên đã chấm công
        }



        public bool Insert(ChamCong cc)
        {
            string query = "INSERT INTO ChamCong (MaNV, Ngay, GioVao, GioRa, MaLoaiCong, TrangThai, TangCa, GhiChu) VALUES (@MaNV, @Ngay, @GioVao, @GioRa, @MaLoaiCong, @TrangThai, @TangCa, @GhiChu)";
            SqlParameter[] p = {
                new SqlParameter("@MaNV", cc.MaNV),
                new SqlParameter("@Ngay", cc.Ngay),
                new SqlParameter("@GioVao", cc.GioVao),
                new SqlParameter("@GioRa", cc.GioRa),
                new SqlParameter("@MaLoaiCong", cc.MaLoaiCong),
                new SqlParameter("@TrangThai", cc.TrangThai),
                new SqlParameter("@TangCa", cc.TangCa ?? (object)DBNull.Value),
                new SqlParameter("@GhiChu", cc.GhiChu ?? "")
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool Update(ChamCong cc)
        {
            string query = "UPDATE ChamCong SET MaNV = @MaNV, Ngay = @Ngay, GioVao = @GioVao, GioRa = @GioRa, MaLoaiCong = @MaLoaiCong, TrangThai = @TrangThai, TangCa = @TangCa, GhiChu = @GhiChu WHERE MaCC = @MaCC";
            SqlParameter[] p = {
                new SqlParameter("@MaNV", cc.MaNV),
                new SqlParameter("@Ngay", cc.Ngay),
                new SqlParameter("@GioVao", cc.GioVao),
                new SqlParameter("@GioRa", cc.GioRa),
                new SqlParameter("@MaLoaiCong", cc.MaLoaiCong),
                new SqlParameter("@TrangThai", cc.TrangThai),
                new SqlParameter("@TangCa", cc.TangCa ?? (object)DBNull.Value),
                new SqlParameter("@GhiChu", cc.GhiChu ?? ""),
                new SqlParameter("@MaCC", cc.MaCC)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }
        public List<ChamCong> TimTheoMaNV(string maNV)
        {
            string query = "SELECT * FROM ChamCong WHERE MaNV LIKE @MaNV + '%'";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return ChuyenDoi(dt);
        }
        public List<ChamCong> ChuyenDoi(DataTable dt)
        {
            List<ChamCong> listChamCong = new List<ChamCong>();

            foreach (DataRow row in dt.Rows)
            {
                ChamCong chamCong = new ChamCong()
                {
                    MaCC = Convert.ToInt32(row["MaCC"]),
                    MaNV = row["MaNV"].ToString(),
                    Ngay = Convert.ToDateTime(row["Ngay"]),

                    // Chuyển đổi chuỗi thành TimeSpan
                    GioVao = TimeSpan.TryParse(row["GioVao"].ToString(), out TimeSpan gioVao) ? gioVao : TimeSpan.Zero,
                    GioRa = TimeSpan.TryParse(row["GioRa"].ToString(), out TimeSpan gioRa) ? gioRa : TimeSpan.Zero,

                    MaLoaiCong = row["MaLoaiCong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    TangCa = Convert.ToInt32(row["TangCa"]),
                    GhiChu = row["GhiChu"].ToString(),
                };

                listChamCong.Add(chamCong);
            }

            // Sau khi thêm tất cả các phần tử vào danh sách, tiến hành sắp xếp theo MaCC theo thứ tự tăng dần
            listChamCong = listChamCong.OrderBy(c => c.MaCC).ToList();

            return listChamCong;  // Trả về danh sách đã sắp xếp
        }
        public static List<ChamCong> GetChamCongByMonth(string maNV, int thang)
        {
            string query = "SELECT * FROM ChamCong WHERE MaNV = @MaNV AND MONTH(Ngay) = @Thang";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@MaNV", maNV),  // Kiểu maNV là varchar
                new SqlParameter("@Thang", thang)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);  // Thực hiện truy vấn SQL

            List<ChamCong> chamCongData = new List<ChamCong>();

            foreach (DataRow row in dt.Rows)
            {
                ChamCong chamCong = new ChamCong
                {
                    MaNV = row["MaNV"].ToString(),
                    Ngay = Convert.ToDateTime(row["Ngay"]),
                    GioVao = ((DateTime)row["GioVao"]).TimeOfDay,
                    GioRa = ((DateTime)row["GioRa"]).TimeOfDay,
                    TrangThai = row["TrangThai"].ToString(),
                    GhiChu = row["GhiChu"].ToString()
                };

                chamCongData.Add(chamCong);
            }

            return chamCongData;
        }
        public List<ChamCong> GetChamCongByMaNV(string maNV)
        {
            string query = "SELECT * FROM ChamCong WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<ChamCong> chamCongList = new List<ChamCong>();
            foreach (DataRow row in dt.Rows)
            {
                ChamCong chamCong = new ChamCong
                {
                    MaCC = Convert.ToInt32(row["MaCC"]),
                    MaNV = row["MaNV"].ToString(),
                    Ngay = Convert.ToDateTime(row["Ngay"]),
                    GioVao = TimeSpan.Parse(row["GioVao"].ToString()),
                    GioRa = TimeSpan.Parse(row["GioRa"].ToString()),
                    MaLoaiCong = row["MaLoaiCong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    TangCa = Convert.ToInt32(row["TangCa"]),
                    GhiChu = row["GhiChu"].ToString()
                };
                chamCongList.Add(chamCong);
            }

            return chamCongList;
        }







        public bool Delete(int maCC)
        {
            string query = "DELETE FROM ChamCong WHERE MaCC = @MaCC";
            SqlParameter[] p = { new SqlParameter("@MaCC", maCC) };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        private ChamCong DataRowToChamCong(DataRow row)
        {
            return new ChamCong
            {
                MaCC = Convert.ToInt32(row["MaCC"]),
                MaNV = row["MaNV"].ToString(),
                Ngay = Convert.ToDateTime(row["Ngay"]),
                GioVao = TimeSpan.Parse(row["GioVao"].ToString()),
                GioRa = TimeSpan.Parse(row["GioRa"].ToString()),
                MaLoaiCong = row["MaLoaiCong"].ToString(),
                TrangThai = row["TrangThai"].ToString(),
                TangCa = row["TangCa"] == DBNull.Value ? null : (float?)Convert.ToSingle(row["TangCa"]),
                GhiChu = row["GhiChu"].ToString()
            };
        }

    }

}
