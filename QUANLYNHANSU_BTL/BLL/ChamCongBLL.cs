using System;
using System.Collections.Generic;
using QUANLYNHANSU_BTL.DTO;
using QUANLYNHANSU_BTL.DAL;
using Microsoft.Data.SqlClient;
using System.Data;

namespace QUANLYNHANSU_BTL.BLL
{
    public class ChamCongBLL
    {
        private ChamCongDAL dal = new ChamCongDAL();

        public List<ChamCong> LayTatCa() => dal.GetAll();
        public List<ChamCong> TimTheoMaNV(string maNV)
        {
            ChamCongDAL chamCongDAL = new ChamCongDAL(); // Khởi tạo đối tượng
            return chamCongDAL.TimTheoMaNV(maNV); // Gọi phương thức trên đối tượng
        }
        public static bool KiemTraChamCongTheoNgay(string maNV, DateTime ngay)
        {
            // Gọi đến DAL để kiểm tra
            return ChamCongDAL.KiemTraChamCongTheoNgay(maNV, ngay);
        }
        public static List<ChamCong> GetChamCongByMonth(string maNV, int thang)
        {
            return ChamCongDAL.GetChamCongByMonth(maNV, thang);  // Gọi đến DAL để lấy dữ liệu
        }
        private ChamCongDAL chamCongDAL = new ChamCongDAL();

        public List<ChamCong> GetChamCongByMaNV(string maNV)
        {
            return chamCongDAL.GetChamCongByMaNV(maNV); // Lấy dữ liệu chấm công theo MaNV
        }

        public List<ChamCong> LocTheoNgay(DateTime ngay) => dal.FilterByDate(ngay);
        public List<ChamCong> LayTheoTrang(int page, int size) => dal.GetPaged(page, size);
        public int TongSoLuong() => dal.GetTotalCount();

        public bool Them(ChamCong cc) => dal.Insert(cc);
        public bool CapNhat(ChamCong cc) => dal.Update(cc);
        public bool Xoa(int maCC) => dal.Delete(maCC);

    }
}