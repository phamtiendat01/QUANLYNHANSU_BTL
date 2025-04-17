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


        public BangTinhLuongNV(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;  // Lưu mã nhân viên
            LoadChartData();  // Gọi hàm để tải dữ liệu cho biểu đồ
            cartesianChart.DataClick += CartesianChart_DataClick;  // Đảm bảo đúng sự kiện và handler

        }
        

        public void LoadChartData()
        {

            var bangTinhLuongBLL = new BangTinhLuongBLL();
            var data = bangTinhLuongBLL.GetTotalSalaryByMaNV(maNV);  // Gọi t  // Gọi từ lớp (đúng)

            var series = new SeriesCollection();

            foreach (DataRow row in data.Rows)
            {
                string month = row["Thang"].ToString();  // Tháng
                double totalSalary = Convert.ToDouble(row["TongTien"]);  // Tổng lương của nhân viên trong tháng đó

                // Thêm vào biểu đồ cột
                series.Add(new ColumnSeries
                {
                    Title = month,
                    Values = new ChartValues<double> { totalSalary }
                });
            }

            // Cập nhật dữ liệu biểu đồ với tổng lương của từng tháng
            cartesianChart.Series = series;

            // Cập nhật trục X với tên các tháng
            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = data.AsEnumerable().Select(row => row["Thang"].ToString()).ToArray()
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
            var clickedMonth = cartesianChart.AxisX[0].Labels[(int)point.X]; // Lấy tháng từ trục X của biểu đồ

            // Kiểm tra tháng có hợp lệ không (cần format đúng)
            DateTime parsedMonth;
            if (DateTime.TryParse(clickedMonth, out parsedMonth))
            {
                // Gọi hàm để tải dữ liệu chi tiết lương theo tháng và mã nhân viên
                LoadSalaryDetailsForMonth(parsedMonth.ToString("MM/yyyy"));
            }
            else
            {
                MessageBox.Show("Dữ liệu tháng không hợp lệ.");
            }
        }

        private void BangTinhLuongNV_Load(object sender, EventArgs e)
        {

        }

        private void cartesianChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
