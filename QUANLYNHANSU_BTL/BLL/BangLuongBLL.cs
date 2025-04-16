using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;
using System.Data;


namespace QUANLYNHANSU_BTL.BLL
{
    public class BangLuongBLL
    {
        public static DataTable GetBangLuong(int page, int pageSize)
        {
            return BangLuongDAL.GetBangLuong(page, pageSize);
        }
        
        private BangLuongDAL dal = new BangLuongDAL();

          public BangLuongDTO GetBangLuongByMaNV(int maNV)
           {
            return dal.GetBangLuongByMaNV(maNV);
           }
       
        public static int GetTotalRows()
        {
            return BangLuongDAL.GetTotalRows();
        }
        public static bool UpdateBangLuong(BangLuongDTO bangLuong)
        {
            try
            {
                BangLuongDAL.UpdateBangLuong(bangLuong);  // Gọi DAL để cập nhật
                return true;  // Trả về true nếu cập nhật thành công
            }
            catch (Exception)
            {
                return false;  // Trả về false nếu có lỗi
            }
        }

        public static bool AddBangLuong(BangLuongDTO bangLuong)
        {
            try
            {
                BangLuongDAL.AddBangLuong(bangLuong);  // Gọi DAL để thêm mới
                return true;  // Trả về true nếu thêm thành công
            }
            catch (Exception)
            {
                return false;  // Trả về false nếu có lỗi
            }
        }


        public static void DeleteBangLuong(string maNV)
        {
            BangLuongDAL.DeleteBangLuong(maNV);
        }
        public static string GetHoTenByMaNV(string maNV)
        {
            return BangLuongDAL.GetHoTenByMaNV(maNV);
        }
        public static DataTable GetBangLuongByMaNV(string maNV)
        {
            return BangLuongDAL.GetBangLuongByMaNV(maNV);
        }

        public static DataTable SearchByMaNV(string maNV)
        {
            return BangLuongDAL.SearchByMaNV(maNV);
        }
    }
}
