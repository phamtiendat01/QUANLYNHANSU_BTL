using QUANLYNHANSU_BTL.DAL;
using QUANLYNHANSU_BTL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Data;
using QUANLYNHANSU_BTL.BLL;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangTinhLuongNV : UserControl
    {

        private string maNV;  // Mã nhân viên từ tài khoản đăng nhập
        private Dictionary<int, string> monthMapping; // Khai báo monthMapping ở cấp độ lớp



        public BangTinhLuongNV(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;  // Lưu mã nhân viên
            monthMapping = new Dictionary<int, string>(); // Khởi tạo monthMapping

            LoadChartData();  // Gọi hàm để tải dữ liệu cho biểu đồ

        }
        public void LoadChartData()
        {
            var bangTinhLuongBLL = new BangTinhLuongBLL();
            var data = bangTinhLuongBLL.GetTotalSalaryByMaNV(maNV);

            var columnSeries = new ColumnSeries
            {
                Title = "Tổng lương",
                Values = new ChartValues<double>()
            };

            monthMapping.Clear();

            foreach (DataRow row in data.Rows)
            {
                string month = row["Thang"].ToString();
                double totalSalary = Convert.ToDouble(row["TongTien"]);

                columnSeries.Values.Add(totalSalary);

                int monthIndex = monthMapping.Count;
                monthMapping[monthIndex] = month;
            }

            cartesianChart.Series.Clear();
            cartesianChart.Series.Add(columnSeries);

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = monthMapping.Values.ToArray()
            });
        }


        private void LoadSalaryDetailsForMonth(string month)
        {
            // Gọi DAL để lấy dữ liệu chi tiết lương theo mã nhân viên và tháng
            var data = new BangTinhLuongDAL().GetByMonthAndMaNV(Convert.ToDateTime(month), maNV); // Gửi mã nhân viên vào

            if (data.Count > 0)
            {
                // Lấy thông tin lương của nhân viên đầu tiên từ dữ liệu
                var salaryDetails = data[0];

                // Cập nhật các label với thông tin lương của nhân viên
                lblMonth.Text = "Tháng: " + salaryDetails.ThangNam.ToString("MM/yyyy");
                lblSoNgayCong.Text = "Số ngày công: " + salaryDetails.SoNgayCong;
                lblLuongCoBan.Text = "Lương cơ bản: " + salaryDetails.LuongCoBan.ToString("N0");
                lblPhuCapChucVu.Text = "Phụ cấp chức vụ: " + salaryDetails.PhuCapChucVu.ToString("N0");
                lblPhuCapKhac.Text = "Phụ cấp khác: " + salaryDetails.PhuCapKhac.ToString("N0");
                lblTienLuongOT.Text = "Tiền lương OT: " + salaryDetails.TienLuongOT.ToString("N0");
                lblTienPhat.Text = "Tiền phạt: " + salaryDetails.TienPhat.ToString("N0");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho tháng này.");
            }
        }

        // Sự kiện khi người dùng click vào cột trong biểu đồ
        private void CartesianChart_DataClick(object sender, ChartPoint point)
        {
            // Lấy tháng từ dictionary thay vì trực tiếp từ Labels
            int clickedMonthIndex = (int)point.X;
            if (monthMapping.ContainsKey(clickedMonthIndex))
            {
                string clickedMonth = monthMapping[clickedMonthIndex];  // Lấy tháng bằng chỉ số

                // Kiểm tra tháng có hợp lệ không (cần format đúng)
                DateTime parsedMonth;
                if (DateTime.TryParseExact(clickedMonth, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedMonth))
                {
                    // Gọi hàm để tải dữ liệu chi tiết lương theo tháng và mã nhân viên
                    LoadSalaryDetailsForMonth(parsedMonth.ToString("MM/yyyy"));
                }
                else
                {
                    MessageBox.Show("Dữ liệu tháng không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho tháng này.");
            }
        }



        private void BangTinhLuongNV_Load(object sender, EventArgs e)
        {

        }
    }
}
