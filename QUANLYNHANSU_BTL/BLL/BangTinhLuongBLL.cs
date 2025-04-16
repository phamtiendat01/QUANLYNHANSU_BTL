using System;
using System.Collections.Generic;
using QUANLYNHANSU_BTL.DTO;
using QUANLYNHANSU_BTL.DAL;
using System.Data;

namespace QUANLYNHANSU_BTL.BLL
{
    public class BangTinhLuongBLL
    {
        private BangTinhLuongDAL dal = new BangTinhLuongDAL();

        // Lấy dữ liệu bảng tính lương theo tháng
        public List<BangTinhLuongDTO> GetByMonth(DateTime month)
        {
            return dal.GetByMonth(month);
        }

        // Thêm bảng tính lương
        public bool Insert(BangTinhLuongDTO bangTinhLuong)
        {
            return dal.Insert(bangTinhLuong);
        }

        // Cập nhật bảng tính lương
        public bool Update(BangTinhLuongDTO bangTinhLuong)
        {
            return dal.Update(bangTinhLuong);
        }
        public List<BangTinhLuongDTO> SearchByMaNV(string maNV)
        {
            return dal.SearchByMaNV(maNV);
        }
        public BangTinhLuongDTO GetByMaTinhLuong(string maTinhLuong)
        {
            return dal.GetByMaTinhLuong(maTinhLuong);
        }
        public int GetTotalCountByMonth(DateTime month)
        {
            return dal.GetTotalCountByMonth(month);
        }
        public List<BangTinhLuongDTO> GetPagedByMonth(DateTime month, int page, int pageSize)
        {
            return dal.GetPagedByMonth(month, page, pageSize);
        }
        public bool Exists(int maNV, DateTime thangNam)
        {
            return dal.Exists(maNV, thangNam);  // Gọi phương thức Exists từ DAL
        }
        // Xóa bảng tính lương
        public bool Delete(string maTinhLuong)
        {
            return dal.Delete(maTinhLuong);
        }
        public Dictionary<string, double> GetTongLuongTheoThang()
        {
            var result = new Dictionary<string, double>();
            DataTable dt = BangTinhLuongDAL.ThongKeTongLuongTheoThang();

            foreach (DataRow row in dt.Rows)
            {
                string thang = row["Thang"].ToString();
                double tong = Convert.ToDouble(row["TongTien"]);
                result[thang] = tong;
            }

            return result;
        }
        // Trả về: lương từng phòng ban trong 1 tháng cụ thể
        public Dictionary<string, double> GetLuongPhongBanTrongThang(string thangMMYYYY)
        {
            var result = new Dictionary<string, double>();

            var all = GetLuongPhongBanTheoThang(); // dùng lại dữ liệu đã load toàn bộ
            foreach (var pb in all)
            {
                if (pb.Value.ContainsKey(thangMMYYYY))
                {
                    result[pb.Key] = pb.Value[thangMMYYYY];
                }
            }

            return result;
        }

        // 2. Tổng lương theo phòng ban
        public Dictionary<string, double> GetTongLuongTheoPhongBan()
        {
            var result = new Dictionary<string, double>();
            DataTable dt = BangTinhLuongDAL.ThongKeTongLuongTheoPhongBan();

            foreach (DataRow row in dt.Rows)
            {
                string phongBan = row["PhongBan"].ToString();
                double tong = Convert.ToDouble(row["TongTien"]);
                result[phongBan] = tong;
            }

            return result;
        }

        // 3. Lương trung bình theo tháng
        public Dictionary<string, double> GetLuongTrungBinhTheoThang()
        {
            var result = new Dictionary<string, double>();
            DataTable dt = BangTinhLuongDAL.ThongKeLuongTrungBinhTheoThang();

            foreach (DataRow row in dt.Rows)
            {
                string thang = row["Thang"].ToString();
                double tb = Convert.ToDouble(row["LuongTB"]);
                result[thang] = tb;
            }

            return result;
        }

        // 4. Lương từng phòng ban theo từng tháng (cho stacked column)
        public Dictionary<string, Dictionary<string, double>> GetLuongPhongBanTheoThang()
        {
            var result = new Dictionary<string, Dictionary<string, double>>();
            DataTable dt = BangTinhLuongDAL.ThongKeLuongPhongBanTheoThang();

            foreach (DataRow row in dt.Rows)
            {
                string thang = row["Thang"].ToString();
                string phongBan = row["PhongBan"].ToString();
                double tong = Convert.ToDouble(row["TongTien"]);

                if (!result.ContainsKey(phongBan))
                {
                    result[phongBan] = new Dictionary<string, double>();
                }

                result[phongBan][thang] = tong;
            }

            return result;
        }
    }
}
