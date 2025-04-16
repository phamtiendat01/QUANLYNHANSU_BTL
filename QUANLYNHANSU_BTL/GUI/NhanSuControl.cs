using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using QUANLYNHANSU_BTL.BLL;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class NhanSuControl : UserControl
    {
        private readonly NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public NhanSuControl()
        {
            InitializeComponent();
            Load += NhanSuControl_Load;
        }
        public void RefreshCharts()
        {
            var timer = new System.Windows.Forms.Timer(); timer.Interval = 1;
            timer.Tick += (s, e) =>
            {
                lineChartNamSinh.Hide();
                columnChartChucVu.Hide();
                pieChartTyLe.Hide();

                lineChartNamSinh.Show();
                columnChartChucVu.Show();
                pieChartTyLe.Show();

                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }


        private void NhanSuControl_Load(object sender, EventArgs e)
        {
            columnChartChucVu.BackColor = Color.WhiteSmoke;
            lineChartNamSinh.BackColor = Color.WhiteSmoke;
            pieChartTyLe.BackColor = Color.WhiteSmoke;

            LoadThongKe();
        }

        private void LoadThongKe()
        {
            VeColumnChart_ChucVu();
            VeLineChart_NamSinh();
            VePieChart_PhongBan();
        }

        private void VeColumnChart_ChucVu()
        {
            var data = nhanVienBLL.ThongKeTheoChucVu();
            int tongNV = data.Values.Sum();
            lblTongNV.Text = $"Tổng số nhân viên: {tongNV}";

            columnChartChucVu.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Chức vụ",
                    Values = new ChartValues<int>(data.Values),
                    DataLabels = true
                }
            };

            columnChartChucVu.AxisX.Clear();
            columnChartChucVu.AxisX.Add(new Axis
            {
                Title = "Chức vụ",
                Labels = data.Keys.ToArray()
            });

            columnChartChucVu.AxisY.Clear();
            columnChartChucVu.AxisY.Add(new Axis
            {
                Title = "Số lượng",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void VeLineChart_NamSinh()
        {
            var data = nhanVienBLL.ThongKeTheoNamSinh()
                                  .OrderBy(x => x.Key)
                                  .ToDictionary(kv => kv.Key.ToString(), kv => kv.Value);

            lineChartNamSinh.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Năm sinh",
                    Values = new ChartValues<int>(data.Values),
                    DataLabels = true,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = DefaultGeometries.Circle
                }
            };

            lineChartNamSinh.AxisX.Clear();
            lineChartNamSinh.AxisX.Add(new Axis
            {
                Title = "Năm sinh",
                Labels = data.Keys.ToArray()
            });

            lineChartNamSinh.AxisY.Clear();
            lineChartNamSinh.AxisY.Add(new Axis
            {
                Title = "Số lượng",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void VePieChart_PhongBan()
        {
            var data = nhanVienBLL.ThongKeTheoPhongBan();
            lblSoPhongBan.Text = $"Phòng ban: {data.Count} loại";

            pieChartTyLe.Series = new SeriesCollection();
            foreach (var kv in data)
            {
                pieChartTyLe.Series.Add(new PieSeries
                {
                    Title = kv.Key,
                    Values = new ChartValues<int> { kv.Value },
                    DataLabels = true
                });
            }

            pieChartTyLe.LegendLocation = LegendLocation.Bottom;
        }

        private void pieChartTyLe_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
