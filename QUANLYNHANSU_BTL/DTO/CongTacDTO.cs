namespace QUANLYNHANSU_BTL.DTO
{
    public class CongTacDTO
    {
        public int MaCongTac { get; set; }
        public int MaNV { get; set; }
        public string HoTen { get; set; }  // Sửa lại tên trường thành HoTen
        public string ChucVu { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }  // Nullable nếu có thể không có giá trị
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
