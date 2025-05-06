using System.Collections.Generic;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public List<TaiKhoanDTO> GetAll() => dal.GetAll();

        public bool Insert(TaiKhoanDTO tk) => dal.Insert(tk);

        public bool Update(TaiKhoanDTO tk) => dal.Update(tk);

        public bool Delete(string tenDangNhap) => dal.Delete(tenDangNhap);

        public List<TaiKhoanDTO> Search(string keyword) => dal.Search(keyword);

        public static TaiKhoanDTO KiemTraDangNhap(string tenDN, string matKhau)
        {
            return TaiKhoanDAL.DangNhap(tenDN, matKhau);
        }
    }
}
