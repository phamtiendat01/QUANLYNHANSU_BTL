using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using System.Data;
using QUANLYNHANSU_BTL.DAL; // Thêm thư viện DAL để lấy dữ liệu

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangTinhLuongNV : UserControl
    {

        private void InitializeComponent()
        {
            lblTitle = new Label();
            cartesianChart = new CartesianChart();
            detailsPanel = new Panel();
            lblTienLuongOT = new Label();
            lblMonth = new Label();
            lblSoNgayCong = new Label();
            lblLuongCoBan = new Label();
            lblPhuCapChucVu = new Label();
            lblPhuCapKhac = new Label();
            lblTienPhat = new Label();
            detailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(84, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tính Lương Tháng";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cartesianChart
            // 
            cartesianChart.Location = new Point(146, 60);
            cartesianChart.Name = "cartesianChart";
            cartesianChart.Size = new Size(619, 187);
            cartesianChart.TabIndex = 1;
            cartesianChart.Text = "Tính lương chart";
            cartesianChart.DataClick += CartesianChart_DataClick;
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(lblTienLuongOT);
            detailsPanel.Controls.Add(lblMonth);
            detailsPanel.Controls.Add(lblSoNgayCong);
            detailsPanel.Controls.Add(lblLuongCoBan);
            detailsPanel.Controls.Add(lblPhuCapChucVu);
            detailsPanel.Controls.Add(lblPhuCapKhac);
            detailsPanel.Controls.Add(lblTienPhat);
            detailsPanel.Location = new Point(146, 334);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(619, 268);
            detailsPanel.TabIndex = 2;
            // 
            // lblTienLuongOT
            // 
            lblTienLuongOT.Font = new Font("Arial", 10F);
            lblTienLuongOT.Location = new Point(317, 166);
            lblTienLuongOT.Name = "lblTienLuongOT";
            lblTienLuongOT.Size = new Size(289, 30);
            lblTienLuongOT.TabIndex = 7;
            lblTienLuongOT.Text = "Tiền Lương OT:";
            // 
            // lblMonth
            // 
            lblMonth.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblMonth.Location = new Point(3, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(200, 30);
            lblMonth.TabIndex = 0;
            lblMonth.Text = "Tháng:";
            // 
            // lblSoNgayCong
            // 
            lblSoNgayCong.Font = new Font("Arial", 10F);
            lblSoNgayCong.Location = new Point(317, 0);
            lblSoNgayCong.Name = "lblSoNgayCong";
            lblSoNgayCong.Size = new Size(289, 30);
            lblSoNgayCong.TabIndex = 1;
            lblSoNgayCong.Text = "Số ngày công:";
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.Font = new Font("Arial", 10F);
            lblLuongCoBan.Location = new Point(317, 40);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(289, 30);
            lblLuongCoBan.TabIndex = 2;
            lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // lblPhuCapChucVu
            // 
            lblPhuCapChucVu.Font = new Font("Arial", 10F);
            lblPhuCapChucVu.Location = new Point(317, 80);
            lblPhuCapChucVu.Name = "lblPhuCapChucVu";
            lblPhuCapChucVu.Size = new Size(289, 30);
            lblPhuCapChucVu.TabIndex = 3;
            lblPhuCapChucVu.Text = "Phụ cấp chức vụ:";
            // 
            // lblPhuCapKhac
            // 
            lblPhuCapKhac.Font = new Font("Arial", 10F);
            lblPhuCapKhac.Location = new Point(317, 119);
            lblPhuCapKhac.Name = "lblPhuCapKhac";
            lblPhuCapKhac.Size = new Size(289, 30);
            lblPhuCapKhac.TabIndex = 4;
            lblPhuCapKhac.Text = "Phụ cấp khác:";
            // 
            // lblTienPhat
            // 
            lblTienPhat.Font = new Font("Arial", 10F);
            lblTienPhat.Location = new Point(317, 210);
            lblTienPhat.Name = "lblTienPhat";
            lblTienPhat.Size = new Size(289, 30);
            lblTienPhat.TabIndex = 6;
            lblTienPhat.Text = "Tiền phạt:";
            // 
            // BangTinhLuongNV
            // 
            Controls.Add(lblTitle);
            Controls.Add(cartesianChart);
            Controls.Add(detailsPanel);
            Name = "BangTinhLuongNV";
            Size = new Size(1151, 707);
            Load += BangTinhLuongNV_Load;
            detailsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblTitle;
        public CartesianChart cartesianChart;
        private Panel detailsPanel;
        private Label lblMonth;
        private Label lblSoNgayCong;
        private Label lblLuongCoBan;
        private Label lblPhuCapChucVu;
        private Label lblPhuCapKhac;
        private Label lblTienPhat;
        private Label lblTienLuongOT;
    }
}
