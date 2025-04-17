using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class NhanVienDAL
    {
        // ✅ Lấy danh sách nhân viên
        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            string query = "SELECT * FROM NhanVien ORDER BY MaNV";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            return ConvertDataTableToList(dt);
        }
        public int DemTongSoNhanVien()
        {
            SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString());
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar();
            }
        }
        public List<string> LayDanhSachPhongBan()
        {
            List<string> danhSachPhongBan = new List<string>();
            string query = "SELECT DISTINCT TenPB FROM BoPhan"; // Lấy danh sách không trùng lặp

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                danhSachPhongBan.Add(row["TenPB"].ToString());
            }
            return danhSachPhongBan;
        }


        // ✅ Thêm nhân viên
        public void ThemNhanVien(NhanVienDTO nv)
        {
            string query = @"INSERT INTO NhanVien ( PhongBan, HoTen, NgaySinh, CMND_CCCD, GioiTinh, ChucVu, SDT, LoaiNV, HocVan) 
                            VALUES ( @PhongBan, @HoTen, @NgaySinh, @CMND_CCCD, @GioiTinh, @ChucVu, @SDT, @LoaiNV, @HocVan)";

            SqlParameter[] parameters = GetNhanVienParameters(nv);
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // ✅ Xóa nhân viên
        public void XoaNhanVien(string maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // ✅ Cập nhật nhân viên
        public void CapNhatNhanVien(NhanVienDTO nv)
        {
            string query = @"UPDATE NhanVien 
                            SET PhongBan = @PhongBan, HoTen = @HoTen, NgaySinh = @NgaySinh, CMND_CCCD = @CMND_CCCD,
                                GioiTinh = @GioiTinh, ChucVu = @ChucVu, SDT = @SDT, LoaiNV = @LoaiNV, HocVan = @HocVan
                            WHERE MaNV = @MaNV";

            SqlParameter[] parameters = GetNhanVienParameters(nv);
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
        public static DataTable GetNhanVienById(int maNV)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", SqlDbType.Int) { Value = maNV }
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static bool SaveEmployeeImage(int maNV, string imagePath)
        {
            // Chuyển đổi ảnh thành byte[]
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            string query = "UPDATE NhanVien SET Avatar = @Avatar WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", SqlDbType.Int) { Value = maNV },
        new SqlParameter("@Avatar", SqlDbType.VarBinary) { Value = imageBytes }
            };

            // Thực thi câu lệnh SQL và kiểm tra kết quả
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

            // Trả về true nếu ít nhất 1 bản ghi bị thay đổi (thành công), ngược lại false
            return rowsAffected > 0;
        }


        public static string GetAvatarByMaNV(int maNV)
        {
            string query = "SELECT Avatar FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", SqlDbType.Int) { Value = maNV }
            };

            // Thực thi truy vấn và trả về Base64 string của ảnh
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            byte[] imageBytes = null;

            // Kiểm tra xem trường Avatar có giá trị NULL không
            if (dt.Rows[0]["Avatar"] != DBNull.Value)
            {
                imageBytes = (byte[])dt.Rows[0]["Avatar"];
                return Convert.ToBase64String(imageBytes);  // Chuyển đổi ảnh thành Base64
            }

            return null;  // Nếu không có ảnh, trả về null

        }





        // ✅ Tìm nhân viên theo Mã NV hoặc Họ tên
        public List<NhanVienDTO> TimNhanVien(string keyword)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV LIKE @Keyword OR HoTen LIKE @Keyword";
            SqlParameter[] parameters = { new SqlParameter("@Keyword", "%" + keyword + "%") };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return ConvertDataTableToList(dt);
        }

        // ✅ Lọc nhân viên theo Phòng ban
        public List<NhanVienDTO> LocTheoPhongBan(string phongBan)
        {
            string query = "SELECT * FROM NhanVien WHERE PhongBan = @PhongBan";
            SqlParameter[] parameters = { new SqlParameter("@PhongBan", phongBan) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return ConvertDataTableToList(dt);
        }

        // ✅ Lọc nhân viên theo Chức vụ
        public List<NhanVienDTO> LocTheoChucVu(string chucVu)
        {
            string query = "SELECT * FROM NhanVien WHERE ChucVu = @ChucVu";
            SqlParameter[] parameters = { new SqlParameter("@ChucVu", chucVu) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return ConvertDataTableToList(dt);
        }

        // ✅ Lọc nhân viên theo Loại nhân viên
        public List<NhanVienDTO> LocTheoLoaiNV(string loaiNV)
        {
            string query = "SELECT * FROM NhanVien WHERE LoaiNV = @LoaiNV";
            SqlParameter[] parameters = { new SqlParameter("@LoaiNV", loaiNV) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return ConvertDataTableToList(dt);
        }

        // ✅ Phân trang danh sách nhân viên
        public List<NhanVienDTO> LayDanhSachPhanTrang(int pageNumber, int pageSize)
        {
            string query = @"SELECT * FROM NhanVien 
                            ORDER BY MaNV 
                            OFFSET @Offset ROWS 
                            FETCH NEXT @PageSize ROWS ONLY";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Offset", (pageNumber - 1) * pageSize),
                new SqlParameter("@PageSize", pageSize)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return ConvertDataTableToList(dt);
        }

        // ✅ Chuyển đổi DataTable thành danh sách NhanVienDTO
        private static List<NhanVienDTO> ConvertDataTableToList(DataTable dt)
        {
            List<NhanVienDTO> danhSach = new List<NhanVienDTO>();
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new NhanVienDTO
                {
                    MaNV = row["MaNV"].ToString(),
                    PhongBan = row["PhongBan"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    NgaySinh = row["NgaySinh"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgaySinh"]),
                    CMND_CCCD = row["CMND_CCCD"].ToString(),
                    GioiTinh = row["GioiTinh"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    SDT = row["SDT"].ToString(),
                    LoaiNV = row["LoaiNV"].ToString(),
                    HocVan = row["HocVan"].ToString()
                });
            }
            return danhSach;
        }
        public static List<NhanVienDTO> LayDanhSachNhanVienFull()
        {
            string query = "SELECT * FROM NhanVien";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            return ConvertDataTableToList(dt);
        }

        // ✅ Hàm tạo danh sách tham số để tránh lặp lại code
        private SqlParameter[] GetNhanVienParameters(NhanVienDTO nv)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@PhongBan", nv.PhongBan),
                new SqlParameter("@HoTen", nv.HoTen),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@CMND_CCCD", nv.CMND_CCCD),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@LoaiNV", nv.LoaiNV),
                new SqlParameter("@HocVan", nv.HocVan)
            };
        }
        public NhanVienDTO? TimTheoMa(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV = @maNV", conn);
                cmd.Parameters.AddWithValue("@maNV", maNV);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new NhanVienDTO
                    {
                        MaNV = reader["MaNV"].ToString(),
                        HoTen = reader["HoTen"].ToString()!,
                        // Bạn có thể map thêm các trường khác nếu cần
                    };
                }
            }
            return null;
        }
        public NhanVienDTO GetNhanVienByMa(int maNV)
        {
            string query = "SELECT HoTen, ChucVu FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new NhanVienDTO
                {
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString()
                };
            }
            return null;
        }
        public Dictionary<string, int> ThongKeTheoChucVu()
        {
            string query = "SELECT ChucVu, COUNT(*) AS SoLuong FROM NhanVien GROUP BY ChucVu";
            return DocThongKeChuoiSo(query);
        }

        public Dictionary<int, int> ThongKeTheoNamSinh()
        {
            string query = "SELECT YEAR(NgaySinh) AS NamSinh, COUNT(*) AS SoLuong FROM NhanVien GROUP BY YEAR(NgaySinh)";
            return DocThongKeSoSo(query);
        }

        public Dictionary<string, int> ThongKeTheoPhongBan()
        {
            string query = "SELECT PhongBan, COUNT(*) AS SoLuong FROM NhanVien GROUP BY PhongBan";
            return DocThongKeChuoiSo(query);
        }

        // Trả về Dictionary<string, int> từ 1 query
        private Dictionary<string, int> DocThongKeChuoiSo(string query)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                string key = row[0].ToString();
                int value = Convert.ToInt32(row[1]);
                data[key] = value;
            }
            return data;
        }

        // Trả về Dictionary<int, int> từ 1 query
        private Dictionary<int, int> DocThongKeSoSo(string query)
        {
            Dictionary<int, int> data = new Dictionary<int, int>();
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                int key = Convert.ToInt32(row[0]);
                int value = Convert.ToInt32(row[1]);
                data[key] = value;
            }
            return data;
        }



        public static DataTable GetNhanVienByMaNV(string maNV)
        {
            string query = "SELECT HoTen, ChucVu FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public NhanVienDTO LayNhanVienTheoMa(string maNV)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
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
                    HocVan = row["HocVan"].ToString()
                };
            }
            return null;
        }


    }
}
