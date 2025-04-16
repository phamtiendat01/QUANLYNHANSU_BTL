using System.Drawing;
using System.Windows.Forms;
using LiveCharts.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    partial class NhanSuControl
    {
        private Label lblTitle;
        private Label lblTongNV;
        private Label lblSoPhongBan;
        private CartesianChart columnChartChucVu;
        private CartesianChart lineChartNamSinh;
        private PieChart pieChartTyLe;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTongNV = new Label();
            lblSoPhongBan = new Label();
            columnChartChucVu = new CartesianChart();
            lineChartNamSinh = new CartesianChart();
            pieChartTyLe = new PieChart();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thống kê Nhân sự";
            // 
            // lblTongNV
            // 
            lblTongNV.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblTongNV.Location = new Point(0, 367);
            lblTongNV.Name = "lblTongNV";
            lblTongNV.Size = new Size(500, 25);
            lblTongNV.TabIndex = 1;
            // 
            // lblSoPhongBan
            // 
            lblSoPhongBan.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblSoPhongBan.Location = new Point(810, 629);
            lblSoPhongBan.Name = "lblSoPhongBan";
            lblSoPhongBan.Size = new Size(400, 25);
            lblSoPhongBan.TabIndex = 2;
            // 
            // columnChartChucVu
            // 
            columnChartChucVu.Location = new Point(3, 47);
            columnChartChucVu.Name = "columnChartChucVu";
            columnChartChucVu.Size = new Size(799, 317);
            columnChartChucVu.TabIndex = 3;
            // 
            // lineChartNamSinh
            // 
            lineChartNamSinh.Location = new Point(3, 395);
            lineChartNamSinh.Name = "lineChartNamSinh";
            lineChartNamSinh.Size = new Size(780, 300);
            lineChartNamSinh.TabIndex = 4;
            // 
            // pieChartTyLe
            // 
            pieChartTyLe.Location = new Point(802, 47);
            pieChartTyLe.Name = "pieChartTyLe";
            pieChartTyLe.Size = new Size(408, 579);
            pieChartTyLe.TabIndex = 5;
            pieChartTyLe.ChildChanged += pieChartTyLe_ChildChanged;
            // 
            // NhanSuControl
            // 
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblTitle);
            Controls.Add(lblTongNV);
            Controls.Add(lblSoPhongBan);
            Controls.Add(columnChartChucVu);
            Controls.Add(lineChartNamSinh);
            Controls.Add(pieChartTyLe);
            Name = "NhanSuControl";
            Size = new Size(1335, 721);
            ResumeLayout(false);
        }
    }
}
