using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongNVForm : Form
    {
        private string maNV;
        private System.ComponentModel.IContainer components = null;
        private Guna2TabControl tabControl;
        private TabPage tabLuong;
        private TabPage tabTinhLuong;
        private Panel panelContent;


        public BangLuongNVForm(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;  // Lưu mã nhân viên
        }

        private void InitializeComponent()
        {
            tabControl = new Guna2TabControl();
            tabLuong = new TabPage();
            tabTinhLuong = new TabPage();
            panelContent = new Panel();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabLuong);
            tabControl.Controls.Add(tabTinhLuong);
            tabControl.Dock = DockStyle.Top;
            tabControl.Font = new Font("Arial", 16F, FontStyle.Bold);
            tabControl.ItemSize = new Size(150, 40);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1381, 50);
            tabControl.TabButtonHoverState.BorderColor = Color.Empty;
            tabControl.TabButtonHoverState.FillColor = Color.LightBlue;
            tabControl.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tabControl.TabButtonHoverState.ForeColor = Color.White;
            tabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonIdleState.BorderColor = Color.Empty;
            tabControl.TabButtonIdleState.FillColor = Color.White;
            tabControl.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tabControl.TabButtonIdleState.ForeColor = Color.Black;
            tabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = Color.LightBlue;
            tabControl.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tabControl.TabButtonSelectedState.ForeColor = Color.White;
            tabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabControl.TabButtonSize = new Size(150, 40);
            tabControl.TabIndex = 0;
            tabControl.TabMenuBackColor = SystemColors.Control;
            tabControl.TabMenuOrientation = TabMenuOrientation.HorizontalTop;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabLuong
            // 
            tabLuong.ForeColor = SystemColors.Control;
            tabLuong.Location = new Point(4, 44);
            tabLuong.Name = "tabLuong";
            tabLuong.Size = new Size(1373, 2);
            tabLuong.TabIndex = 0;
            tabLuong.Text = "Bảng Lương";
            // 
            // tabTinhLuong
            // 
            tabTinhLuong.ForeColor = SystemColors.Control;
            tabTinhLuong.Location = new Point(4, 44);
            tabTinhLuong.Name = "tabTinhLuong";
            tabTinhLuong.Size = new Size(1373, 2);
            tabTinhLuong.TabIndex = 1;
            tabTinhLuong.Text = "Tính Lương";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1381, 697);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // BangLuongNVForm
            // 
            ClientSize = new Size(1381, 747);
            Controls.Add(panelContent);
            Controls.Add(tabControl);
            Name = "BangLuongNVForm";
            Text = "Bảng Lương";
            Load += BangLuongNVForm_Load;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BangLuongNVForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Khởi tạo BangLuongNV với mã nhân viên
                var bangLuongControl = new BangLuongNV(maNV);
                bangLuongControl.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(bangLuongControl);  // Thêm UserControl vào panelContent

                // Mặc định chọn tab Bảng Lương
                tabControl.SelectedIndex = 0;  // Đảm bảo tab đầu tiên (Bảng lương) được chọn
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();  // Xóa nội dung hiện tại của panelContent

            if (tabControl.SelectedIndex == 0)  // Nếu chọn tab Bảng Lương
            {
                // Khởi tạo BangLuongNV và truyền tham số maNV
                var bangLuongControl = new BangLuongNV(maNV);  // Truyền MaNV vào khi khởi tạo UserControl
                bangLuongControl.Dock = DockStyle.Fill;
                panelContent.Controls.Add(bangLuongControl);  // Thêm UserControl vào panelContent
            }
            else if (tabControl.SelectedIndex == 1)  // Nếu chọn tab Tính Lương
            {

                var tinhLuongControl = new BangTinhLuongNV(maNV);  // Truyền MaNV vào khi khởi tạo UserControl
                tinhLuongControl.Dock = DockStyle.Fill;
                panelContent.Controls.Add(tinhLuongControl);  // Thêm UserControl vào panelContent

            }
        }
    }
}
