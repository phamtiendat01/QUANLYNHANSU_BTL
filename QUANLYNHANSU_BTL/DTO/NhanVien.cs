    namespace QUANLYNHANSU_BTL.DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string PhongBan { get; set; }   // ✅ Thêm Phòng Ban
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND_CCCD { get; set; }  // ✅ Cột này bị lệch tên ở DAL, sửa lại cho khớp
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string SDT { get; set; }
        public string LoaiNV { get; set; }
        public string HocVan { get; set; }
        public string Avatar { get; set; } // Đường dẫn ảnh hoặc Base64

    }
}
