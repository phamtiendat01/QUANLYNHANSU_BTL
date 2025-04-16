using System.Collections.Generic;
using System.Data;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.BLL
{
    public class BoPhanBLL
    {
        private BoPhanDAL boPhanDAL = new BoPhanDAL();

        // ✅ Lấy danh sách có phân trang
        public List<BoPhanDTO> LayDanhSachPhanTrang(int pageNumber, int pageSize)
        {
            return boPhanDAL.LayDanhSachPhanTrang(pageNumber, pageSize);
        }

        // ✅ Lấy toàn bộ danh sách để xuất Excel
        public List<BoPhanDTO> LayDanhSachToanBo()
        {
            return boPhanDAL.LayDanhSachToanBo();
        }
        public DataRow LayBoPhanTheoMa(String maBP)
        {
            return boPhanDAL.LayBoPhanTheoMa(maBP);
        }

        // ✅ Đếm tổng số phòng ban (phục vụ phân trang)
        public int DemTongSoBoPhan()
        {
            return boPhanDAL.DemTongSoBoPhan();
        }

        // ✅ Tìm kiếm phòng ban
        public List<BoPhanDTO> TimBoPhan(string keyword)
        {
            return boPhanDAL.TimBoPhan(keyword);
        }

        // ✅ Thêm mới phòng ban
        public void ThemBoPhan(BoPhanDTO boPhan)
        {
            boPhanDAL.ThemBoPhan(boPhan);
        }

        // ✅ Cập nhật phòng ban
        public void CapNhatBoPhan(BoPhanDTO boPhan)
        {
            boPhanDAL.CapNhatBoPhan(boPhan);
        }

        // ✅ Xóa phòng ban
        public void XoaBoPhan(string maPB)
        {
            boPhanDAL.XoaBoPhan(maPB);
        }
    }
}
