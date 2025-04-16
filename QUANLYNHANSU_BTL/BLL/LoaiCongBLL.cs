using System.Collections.Generic;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.BLL
{
    public class LoaiCongBLL
    {
        private LoaiCongDAL dal = new LoaiCongDAL();

        public List<LoaiCongDTO> LayTatCa() => dal.LayTatCa();

        public string? LayTenLoaiCong(string maLoai) => dal.LayTenTheoMa(maLoai);
    }
}
