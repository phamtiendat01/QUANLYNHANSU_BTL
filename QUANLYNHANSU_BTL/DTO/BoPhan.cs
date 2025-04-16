namespace QUANLYNHANSU_BTL.DTO
{
    public class BoPhanDTO
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }

        public BoPhanDTO() { }

        public BoPhanDTO(string maPB, string tenPB)
        {
            this.MaPB = maPB;
            this.TenPB = tenPB;
        }
    }
}
