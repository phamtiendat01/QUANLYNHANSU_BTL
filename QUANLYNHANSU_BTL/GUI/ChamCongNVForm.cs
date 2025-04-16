using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ChamCongNVForm : Form
    {
        private ChamCongBLL chamCongBLL = new ChamCongBLL();
        private string maNV;
        private int currentPage = 1;
        private int totalPages = 1;
        private int pageSize = 10; // Số bản ghi trên mỗi trang
        private List<ChamCong> chamCongList = new List<ChamCong>(); // Danh sách chấm công

        public ChamCongNVForm(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV ?? throw new ArgumentNullException(nameof(maNV)); // Đảm bảo maNV không null
            LoadThangComboBox(); // Khởi tạo ComboBox tháng
            LoadChamCongData(); // Lấy dữ liệu chấm công ban đầu
        }

        // Lấy dữ liệu chấm công ban đầu vào DataGridView
        private void LoadChamCongData()
        {
            chamCongList = chamCongBLL.GetChamCongByMaNV(maNV);  // Lấy toàn bộ dữ liệu chấm công của nhân viên từ cơ sở dữ liệu
            guna2DataGridViewChamCong.DataSource = chamCongList;  // Gán dữ liệu vào DataGridView

            // Cập nhật số trang và thông tin phân trang
            totalPages = (int)Math.Ceiling((double)chamCongList.Count / pageSize);
            UpdatePageInfo();
            UpdateStats(chamCongList);  // Cập nhật thống kê (Đủ, Vắng, Khác)
        }

        // Lọc dữ liệu chấm công theo tháng
        private void FilterDataByMonth()
        {
            int thang = Convert.ToInt32(guna2ComboBoxThang.SelectedItem.ToString().Split('/')[0]); // Lấy tháng từ ComboBox, ví dụ: "03/2025" -> "03"
            int nam = Convert.ToInt32(guna2ComboBoxThang.SelectedItem.ToString().Split('/')[1]); // Lấy năm từ ComboBox, ví dụ: "03/2025" -> "2025"

            // Lọc dữ liệu chấm công theo tháng và năm đã chọn
            var filteredList = chamCongList.Where(c => c.Ngay.Month == thang && c.Ngay.Year == nam).ToList();

            // Gán lại dữ liệu đã lọc vào DataGridView
            guna2DataGridViewChamCong.DataSource = filteredList;

            // Cập nhật các label thống kê (Đủ, Vắng, Khác) theo dữ liệu đã lọc
            UpdateStats(filteredList);
        }

        // Cập nhật các label thống kê Đủ, Vắng, Khác
        private void UpdateStats(List<ChamCong> filteredList)
        {
            int du = 0, vang = 0, khac = 0;

            // Duyệt qua danh sách chấm công đã lọc và thống kê
            foreach (var chamCong in filteredList)
            {
                if (chamCong.TrangThai == "Đúng giờ") du++;
                else if (chamCong.TrangThai == "Vắng không phép") vang++;
                else if (chamCong.TrangThai == "Vắng") vang++; // Vắng có phép
                else khac++;
            }

            // Cập nhật thông tin vào các label
            lblDu.Text = $"Đủ: {du}";
            lblVang.Text = $"Vắng: {vang}";
            lblKhac.Text = $"Khác: {khac}";
        }

        // Khởi tạo ComboBox tháng (01/2025, 02/2025,...)
        private void LoadThangComboBox()
        {
            for (int i = 1; i <= 12; i++)
            {
                guna2ComboBoxThang.Items.Add($"{i:D2}/2025"); // Thêm tháng vào ComboBox dưới dạng 03/2025
            }
            guna2ComboBoxThang.SelectedIndex = 0; // Mặc định chọn tháng 1
        }

        // Sự kiện khi chọn tháng từ ComboBox
        private void guna2ComboBoxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataByMonth(); // Lọc dữ liệu khi thay đổi tháng trong ComboBox
        }

        private void UpdatePageInfo()
        {
            // Cập nhật thông tin trang
            lblPageInfo.Text = $"Trang: {currentPage}/{totalPages}";  // Hiển thị trang hiện tại trên tổng số trang
        }

        // Nút phân trang trước
        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                UpdatePageInfo();
                LoadChamCongData();
            }
        }

        // Nút phân trang sau
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                UpdatePageInfo();
                LoadChamCongData();
            }
        }
    }
}
