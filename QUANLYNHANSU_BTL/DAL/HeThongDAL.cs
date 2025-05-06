using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class TaiKhoanDAL
    {
        public List<TaiKhoanDTO> GetAll()
        {
            string query = "SELECT MaNV, TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai FROM TaiKhoan ORDER BY MaNV"; // <-- thêm ORDER BY MaNV
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TaiKhoanDTO
                {
                    MaNV = row["MaNV"] != DBNull.Value ? Convert.ToInt32(row["MaNV"]) : null,
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    VaiTro = row["VaiTro"].ToString(),
                    TrangThai = Convert.ToBoolean(row["TrangThai"])
                });
            }
            return list;
        }


        public static TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "SELECT MaNV, TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai = 1";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new TaiKhoanDTO
            {
                MaNV = row["MaNV"] != DBNull.Value ? Convert.ToInt32(row["MaNV"]) : null,
                TenDangNhap = row["TenDangNhap"].ToString(),
                MatKhau = row["MatKhau"].ToString(),
                HoTen = row["HoTen"].ToString(),
                VaiTro = row["VaiTro"].ToString(),
                TrangThai = Convert.ToBoolean(row["TrangThai"])
            };
        }

        public bool Insert(TaiKhoanDTO tk)
        {
            string query = "INSERT INTO TaiKhoan (MaNV, TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai) VALUES (@MaNV, @TenDangNhap, @MatKhau, @HoTen, @VaiTro, @TrangThai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", tk.MaNV.HasValue ? (object)tk.MaNV.Value : DBNull.Value),
                new SqlParameter("@TenDangNhap", tk.TenDangNhap),
                new SqlParameter("@MatKhau", tk.MatKhau),
                new SqlParameter("@HoTen", tk.HoTen ?? (object)DBNull.Value),
                new SqlParameter("@VaiTro", tk.VaiTro),
                new SqlParameter("@TrangThai", tk.TrangThai)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(TaiKhoanDTO tk)
        {
            string query = "UPDATE TaiKhoan SET MaNV = @MaNV, MatKhau = @MatKhau, HoTen = @HoTen, VaiTro = @VaiTro, TrangThai = @TrangThai WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", tk.MaNV.HasValue ? (object)tk.MaNV.Value : DBNull.Value),
                new SqlParameter("@TenDangNhap", tk.TenDangNhap),
                new SqlParameter("@MatKhau", tk.MatKhau),
                new SqlParameter("@HoTen", tk.HoTen ?? (object)DBNull.Value),
                new SqlParameter("@VaiTro", tk.VaiTro),
                new SqlParameter("@TrangThai", tk.TrangThai)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(string tenDangNhap)
        {
            string query = "DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool KiemTraMatKhauCu(string maNV, string matKhauCu)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNV = @maNV AND MatKhau = @matKhau";
            SqlParameter[] parameters = {
        new SqlParameter("@maNV", maNV),
        new SqlParameter("@matKhau", matKhauCu)
    };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            int count = (result != null) ? Convert.ToInt32(result) : 0;

            return count > 0;
        }

        public bool CapNhatMatKhauMoi(string maNV, string matKhauMoi)
        {
            string sql = "UPDATE TaiKhoan SET MatKhau = @matKhauMoi WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
        new SqlParameter("@matKhauMoi", matKhauMoi),
        new SqlParameter("@maNV", maNV)
    };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(sql, parameters);
            return rowsAffected > 0;
        }




        public List<TaiKhoanDTO> Search(string keyword)
        {
            string query = "SELECT MaNV, TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai FROM TaiKhoan WHERE TenDangNhap LIKE @kw OR HoTen LIKE @kw";
            SqlParameter[] parameters =
            {
                new SqlParameter("@kw", $"%{keyword}%")
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TaiKhoanDTO
                {
                    MaNV = row["MaNV"] != DBNull.Value ? Convert.ToInt32(row["MaNV"]) : null,
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    VaiTro = row["VaiTro"].ToString(),
                    TrangThai = Convert.ToBoolean(row["TrangThai"])
                });
            }
            return list;
        }
    }
}
