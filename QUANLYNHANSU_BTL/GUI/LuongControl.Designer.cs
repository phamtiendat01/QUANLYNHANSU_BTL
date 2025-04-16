using System.Drawing;
using System.Windows.Forms;
using LiveCharts.WinForms;
using Guna.UI2.WinForms;
namespace QUANLYNHANSU_BTL.GUI
{
    partial class LuongControl
    {
        private Label lblTitle;
        private Label lblTongLuong;
        private CartesianChart chartLuongTheoThang;
        private PieChart chartLuongTheoPhongBan;
        private CartesianChart chartLuongTrungBinh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbThang;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTongLuong = new Label();
            chartLuongTheoThang = new CartesianChart();
            chartLuongTheoPhongBan = new PieChart();
            chartLuongTrungBinh = new CartesianChart();
            cmbThang = new Guna2ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thống kê Lương";
            // 
            // lblTongLuong
            // 
            lblTongLuong.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblTongLuong.Location = new Point(0, 393);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new Size(400, 25);
            lblTongLuong.TabIndex = 1;
            // 
            // chartLuongTheoThang
            // 
            chartLuongTheoThang.Location = new Point(0, 43);
            chartLuongTheoThang.Name = "chartLuongTheoThang";
            chartLuongTheoThang.Size = new Size(773, 333);
            chartLuongTheoThang.TabIndex = 2;
            // 
            // chartLuongTheoPhongBan
            // 
            chartLuongTheoPhongBan.Location = new Point(779, 77);
            chartLuongTheoPhongBan.Name = "chartLuongTheoPhongBan";
            chartLuongTheoPhongBan.Size = new Size(449, 596);
            chartLuongTheoPhongBan.TabIndex = 3;
            // 
            // chartLuongTrungBinh
            // 
            chartLuongTrungBinh.Location = new Point(3, 451);
            chartLuongTrungBinh.Name = "chartLuongTrungBinh";
            chartLuongTrungBinh.Size = new Size(770, 313);
            chartLuongTrungBinh.TabIndex = 7;
            // 
            // cmbThang
            // 
            cmbThang.Name = "cmbThang";
            cmbThang.Location = new Point(3, 421);
            cmbThang.Size = new Size(200, 36);
            cmbThang.BorderRadius = 8;
            cmbThang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmbThang.ForeColor = Color.White;
            cmbThang.FillColor = Color.FromArgb(0, 123, 255);
            cmbThang.HoverState.FillColor = Color.FromArgb(30, 144, 255);
            cmbThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbThang.TabIndex = 6;
            cmbThang.SelectedIndexChanged += cmbThang_SelectedIndexChanged;
            // 
            // LuongControl
            // 
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblTitle);
            Controls.Add(lblTongLuong);
            Controls.Add(chartLuongTheoThang);
            Controls.Add(chartLuongTheoPhongBan);
            Controls.Add(cmbThang);
            Controls.Add(chartLuongTrungBinh);
            Name = "LuongControl";
            Size = new Size(1328, 793);
            ResumeLayout(false);
        }
    }
}
