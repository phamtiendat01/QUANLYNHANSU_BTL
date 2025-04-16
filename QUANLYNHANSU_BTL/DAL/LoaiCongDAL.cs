using System.Collections.Generic;
using System.Data;
using QUANLYNHANSU_BTL.DTO;
using Microsoft.Data.SqlClient;

namespace QUANLYNHANSU_BTL.DAL
{
    public class LoaiCongDAL
    {
        public List<LoaiCongDTO> LayTatCa()
        {
            List<LoaiCongDTO> list = new List<LoaiCongDTO>();
            string query = "SELECT * FROM LoaiCong";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new LoaiCongDTO
                {
                    MaLoaiCong = row["MaLoaiCong"].ToString(),
                    TenLoaiCong = row["TenLoaiCong"].ToString(),
                    MoTa = row["MoTa"].ToString()
                });
            }

            return list;
        }

        public string? LayTenTheoMa(string maLoaiCong)
        {
            string query = "SELECT TenLoaiCong FROM LoaiCong WHERE MaLoaiCong = @ma";
            SqlParameter[] parameters = { new SqlParameter("@ma", maLoaiCong) };
            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
    }
}
