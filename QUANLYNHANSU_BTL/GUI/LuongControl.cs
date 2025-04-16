using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using QUANLYNHANSU_BTL.BLL;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class LuongControl : UserControl
    {
        private readonly BangTinhLuongBLL bll = new BangTinhLuongBLL();

        public LuongControl()
        {
            InitializeComponent();
            Load += LuongControl_Load;
            LoadComboBoxThang();
        }

        private void LuongControl_Load(object sender, EventArgs e)
        {
            chartLuongTheoThang.BackColor = Color.WhiteSmoke;
            chartLuongTheoPhongBan.BackColor = Color.WhiteSmoke;
            chartLuongTrungBinh.BackColor = Color.WhiteSmoke;

            LoadThongKe();
        }

        public void RefreshCharts()
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += (s, e) =>
            {
                chartLuongTheoThang.Hide();
                chartLuongTheoPhongBan.Hide();
                chartLuongTrungBinh.Hide();

                chartLuongTheoThang.Show();
                chartLuongTheoPhongBan.Show();
                chartLuongTrungBinh.Show();

                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void LoadThongKe()
        {
            VeBieuDoCot_TongLuongTheoThang();
            VeBieuDoTron_TongLuongTheoPhongBan();
            VeBieuDoDuong_LuongTrungBinhTheoThang();
            VeBieuDoStacked_LuongTheoPhongBanThang();
        }

        private void VeBieuDoCot_TongLuongTheoThang()
        {
            var data = bll.GetTongLuongTheoThang();
            double tongTatCa = data.Values.Sum();
            lblTongLuong.Text = $"Tổng lương tất cả tháng: {tongTatCa:N0} VNĐ";

            chartLuongTheoThang.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Tổng lương",
                    Values = new ChartValues<double>(data.Values),
                    DataLabels = true
                }
            };

            chartLuongTheoThang.AxisX.Clear();
            chartLuongTheoThang.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = data.Keys.ToArray()
            });

            chartLuongTheoThang.AxisY.Clear();
            chartLuongTheoThang.AxisY.Add(new Axis
            {
                Title = "Tổng lương",
                LabelFormatter = val => val.ToString("N0")
            });
        }

        private void VeBieuDoTron_TongLuongTheoPhongBan()
        {
            var data = bll.GetTongLuongTheoPhongBan();
            chartLuongTheoPhongBan.Series = new SeriesCollection();
            foreach (var kv in data)
            {
                chartLuongTheoPhongBan.Series.Add(new PieSeries
                {
                    Title = kv.Key,
                    Values = new ChartValues<double> { kv.Value },
                    DataLabels = true,
                    LabelPosition = PieLabelPosition.InsideSlice
                });
            }

            chartLuongTheoPhongBan.LegendLocation = LegendLocation.Bottom;
        }

        private void VeBieuDoDuong_LuongTrungBinhTheoThang()
        {
            var data = bll.GetLuongTrungBinhTheoThang();

            chartLuongTrungBinh.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lương TB",
                    Values = new ChartValues<double>(data.Values),
                    DataLabels = true,
                    PointGeometry = DefaultGeometries.Circle,
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };

            chartLuongTrungBinh.AxisX.Clear();
            chartLuongTrungBinh.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = data.Keys.ToArray()
            });

            chartLuongTrungBinh.AxisY.Clear();
            chartLuongTrungBinh.AxisY.Add(new Axis
            {
                Title = "Lương TB",
                LabelFormatter = val => val.ToString("N0")
            });
        }

        private void VeBieuDoStacked_LuongTheoPhongBanThang()
        {
            var data = bll.GetLuongPhongBanTheoThang();

            // Lấy tất cả các tháng có mặt (Labels trục X)
            var allMonths = data.Values
                                .SelectMany(dic => dic.Keys)
                                .Distinct()
                                .OrderBy(m => m)
                                .ToList();

            var series = new SeriesCollection();

            foreach (var phongBan in data.Keys)
            {
                var values = new List<double>();
                foreach (var month in allMonths)
                {
                    if (data[phongBan].ContainsKey(month))
                        values.Add(data[phongBan][month]);
                    else
                        values.Add(0);
                }

                series.Add(new StackedColumnSeries
                {
                    Title = phongBan,
                    Values = new ChartValues<double>(values),
                    DataLabels = true
                });
            }


        }
        private void LoadComboBoxThang()
        {
            var dsThang = bll.GetTongLuongTheoThang().Keys.ToList();
            cmbThang.Items.Clear();
            cmbThang.Items.AddRange(dsThang.ToArray());

            if (cmbThang.Items.Count > 0)
                cmbThang.SelectedIndex = 0;
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThang.SelectedItem == null) return;

            string selectedThang = cmbThang.SelectedItem.ToString();

            // Gọi BLL để lấy dữ liệu theo tháng
            var data = bll.GetLuongPhongBanTrongThang(selectedThang);

            chartLuongTrungBinh.Series.Clear();

            chartLuongTrungBinh.Series = new SeriesCollection
        {
             new LineSeries
        {
            Title = $"Tháng {selectedThang}",
            Values = new ChartValues<double>(data.Values),
            DataLabels = true,
            PointGeometry = DefaultGeometries.Circle,
            Fill = System.Windows.Media.Brushes.Transparent,
            LineSmoothness = 0.5, // ✅ Làm mượt đường
            StrokeThickness = 2
        }
            };

            chartLuongTrungBinh.AxisX.Clear();
            chartLuongTrungBinh.AxisX.Add(new Axis
            {
                Title = "Phòng ban",
                Labels = data.Keys.ToArray()
            });

            chartLuongTrungBinh.AxisY.Clear();
            chartLuongTrungBinh.AxisY.Add(new Axis
            {
                Title = "Tổng lương",
                LabelFormatter = value => value.ToString("N0")
            });
        }


        private void chartLuongStacked_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void lblTongLuong_Click(object sender, EventArgs e)
        {

        }
    }
}
