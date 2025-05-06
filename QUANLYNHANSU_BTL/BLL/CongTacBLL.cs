using System;
using System.Collections.Generic;
using System.Data;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.BLL
{
    public class CongTacBLL
    {
        // Hàm phân trang (dùng ở LoadDataByPage)
        public List<CongTacDTO> GetCongTac(int page, int pageSize)
        {
            return CongTacDAL.GetAllCongTac()
                             .Skip((page - 1) * pageSize)
                             .Take(pageSize)
                             .ToList();
        }

        // Hàm lấy công tác theo mã nhân viên (dùng ở CellClick)
        public List<CongTacDTO> GetCongTac(int maNV)
        {
            return CongTacDAL.GetAllCongTac()
                             .Where(ct => ct.MaNV == maNV)
                             .ToList();
        }



        // Thêm tiến trình công tác
        public bool AddCongTac(CongTacDTO congTac)
        {
            return CongTacDAL.AddCongTac(congTac);
        }

        // Cập nhật tiến trình công tác
        public bool UpdateCongTac(CongTacDTO congTac)
        {
            return CongTacDAL.UpdateCongTac(congTac);
        }

        // Xóa tiến trình công tác
        public bool DeleteCongTac(int maCongTac)
        {
            return CongTacDAL.DeleteCongTac(maCongTac);
        }

        // Lọc tiến trình công tác theo khoảng thời gian
        public DataTable FilterCongTacByDate(DateTime fromDate, DateTime toDate)
        {
            return CongTacDAL.FilterCongTacByDate(fromDate, toDate);
        }

        // Tìm kiếm tiến trình công tác
        public DataTable SearchCongTac(int maNV, string hoTen)
        {
            return CongTacDAL.SearchCongTac(maNV, hoTen); // Chỉ cần tìm kiếm theo maNV và hoTen
        }

        // Sửa: Cập nhật maCongTac sang kiểu int
        public List<CongTacDTO> GetCongTacByMaCongTac(int maCongTac)
        {
              var congTacDAL = new CongTacDAL();
            return CongTacDAL.GetCongTacByMaCongTac(maCongTac);  // Thay đổi kiểu tham số thành int

        }
        public DataTable ConvertListToDataTable(List<CongTacDTO> congTacList)
        {
            DataTable dt = new DataTable();

            // Tạo cột cho DataTable từ các thuộc tính của CongTacDTO
            dt.Columns.Add("MaCongTac");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("ChucVu");
            dt.Columns.Add("TuNgay");
            dt.Columns.Add("DenNgay");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("GhiChu");

            // Duyệt qua các đối tượng trong List<CongTacDTO> và thêm vào DataTable
            foreach (var congTac in congTacList)
            {
                dt.Rows.Add(congTac.MaCongTac, congTac.MaNV, congTac.HoTen, congTac.ChucVu,
                            congTac.TuNgay, congTac.DenNgay, congTac.MoTa, congTac.TrangThai, congTac.GhiChu);
            }

            return dt;
        }

        // Lấy tổng số bản ghi
        public int GetTotalRecords()
        {
            return CongTacDAL.GetTotalRecords();
        }
    }
}
