namespace QUANLYNHANSU_BTL.DTO
{
    public class BangTinhLuongDTO
    {
        public string MaTinhLuong { get; set; }
        public int MaNV { get; set; }
        public string HoTen { get; set; } // Thêm trường Họ và Tên
        public string ChucVu { get; set; } // Thêm trường Chức vụ
        public DateTime ThangNam { get; set; }
        public int SoNgayCong { get; set; }
        public int SoNgayOT { get; set; }
        public float LuongCoBan { get; set; }
        public float PhuCapChucVu { get; set; }
        public float PhuCapKhac { get; set; }
        public float TienLuongOT { get; set; }
        public float TienPhat { get; set; }
        public float TongLuong { get; set; }
    }
}
