using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.DAL
{
    public class TaiKhoanDAL
    {
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = "SELECT * FROM TaiKhoan";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TaiKhoan
                {
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
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai = 1";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenDangNhap", SqlDbType.NVarChar) { Value = tenDangNhap },
        new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = matKhau }
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new TaiKhoanDTO
            {
                TenDangNhap = row["TenDangNhap"].ToString(),
                MatKhau = row["MatKhau"].ToString(),
                VaiTro = row["VaiTro"].ToString(),
                TrangThai = (bool)row["TrangThai"],
                MaNV = row["MaNV"] != DBNull.Value ? Convert.ToInt32(row["MaNV"]) : 0 // Kiểm tra MaNV có hợp lệ không


            };
        }

        public bool Insert(TaiKhoan tk)
        {
            string query = "INSERT INTO TaiKhoan VALUES (@TenDangNhap, @MatKhau, @HoTen, @VaiTro, @TrangThai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tk.TenDangNhap),
                new SqlParameter("@MatKhau", tk.MatKhau),
                new SqlParameter("@HoTen", tk.HoTen),
                new SqlParameter("@VaiTro", tk.VaiTro),
                new SqlParameter("@TrangThai", tk.TrangThai)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(TaiKhoan tk)
        {
            string query = "UPDATE TaiKhoan SET MatKhau=@MatKhau, HoTen=@HoTen, VaiTro=@VaiTro, TrangThai=@TrangThai WHERE TenDangNhap=@TenDangNhap";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tk.TenDangNhap),
                new SqlParameter("@MatKhau", tk.MatKhau),
                new SqlParameter("@HoTen", tk.HoTen),
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

        public List<TaiKhoan> Search(string keyword)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap LIKE @kw";
            SqlParameter[] parameters =
            {
                new SqlParameter("@kw", $"%{keyword}%")
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TaiKhoan
                {
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
