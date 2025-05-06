namespace QUANLYNHANSU_BTL.DTO
{
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public bool TrangThai { get; set; }
        public int? MaNV { get; set; }  // Cho phép null
        public string HoTen { get; set; } // Đã thêm
    }
}
