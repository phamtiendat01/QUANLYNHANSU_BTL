using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BaoCaoForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2TabControl tabControl;
        private TabPage tabNhanSu;
        private TabPage tabLuong;
        private Panel panelContent;

        public BaoCaoForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tabControl = new Guna2TabControl();
            tabNhanSu = new TabPage();
            tabLuong = new TabPage();
            panelContent = new Panel();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNhanSu);
            tabControl.Controls.Add(tabLuong);
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
            // tabNhanSu
            // 
            tabNhanSu.ForeColor = SystemColors.Control;
            tabNhanSu.Location = new Point(4, 44);
            tabNhanSu.Name = "tabNhanSu";
            tabNhanSu.Size = new Size(1373, 2);
            tabNhanSu.TabIndex = 0;
            tabNhanSu.Text = "Nhân sự";
            // 
            // tabLuong
            // 
            tabLuong.ForeColor = SystemColors.Control;
            tabLuong.Location = new Point(4, 44);
            tabLuong.Name = "tabLuong";
            tabLuong.Size = new Size(792, 2);
            tabLuong.TabIndex = 1;
            tabLuong.Text = "Lương";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1381, 697);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint_3;
            // 
            // BaoCaoForm
            // 
            ClientSize = new Size(1381, 747);
            Controls.Add(panelContent);
            Controls.Add(tabControl);
            Name = "BaoCaoForm";
            Text = "Báo Cáo";
            Load += BaoCaoForm_Load;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Load mặc định tab Nhân sự khi mở form (nếu không ở chế độ thiết kế)
        private void BaoCaoForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                var nhanSuControl = new NhanSuControl();
                nhanSuControl.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(nhanSuControl);
                nhanSuControl.RefreshCharts(); // refresh luôn lúc form load
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            if (tabControl.SelectedIndex == 0)
            {
                var nhanSuControl = new NhanSuControl();
                nhanSuControl.Dock = DockStyle.Fill;
                panelContent.Controls.Add(nhanSuControl);
                nhanSuControl.RefreshCharts(); // refresh khi chuyển tab
            }
            else if (tabControl.SelectedIndex == 1)
            {
                var luongControl = new LuongControl();
                luongControl.Dock = DockStyle.Fill;
                panelContent.Controls.Add(luongControl);
                luongControl.RefreshCharts();
            }
        }



    }
}
