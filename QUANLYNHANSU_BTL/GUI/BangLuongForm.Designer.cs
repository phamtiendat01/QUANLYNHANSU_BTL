using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2TabControl tabControl;
        private TabPage tabBangLuong;
        private TabPage tabBangTinhLuong;
        private Panel panelContent; // Panel chứa nội dung các tab



        private void InitializeComponent()
        {
            tabControl = new Guna2TabControl();
            tabBangLuong = new TabPage();
            tabBangTinhLuong = new TabPage();
            panelContent = new Panel();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBangLuong);
            tabControl.Controls.Add(tabBangTinhLuong);
            tabControl.Dock = DockStyle.Top;
            tabControl.Font = new Font("Arial", 16F, FontStyle.Bold);
            tabControl.ItemSize = new Size(150, 40);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1377, 50);
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
            // tabBangLuong
            // 
            tabBangLuong.ForeColor = SystemColors.Control;
            tabBangLuong.Location = new Point(4, 44);
            tabBangLuong.Name = "tabBangLuong";
            tabBangLuong.Size = new Size(1369, 2);
            tabBangLuong.TabIndex = 0;
            tabBangLuong.Text = "Bảng Lương";
            // 
            // tabBangTinhLuong
            // 
            tabBangTinhLuong.ForeColor = SystemColors.Control;
            tabBangTinhLuong.Location = new Point(4, 44);
            tabBangTinhLuong.Name = "tabBangTinhLuong";
            tabBangTinhLuong.Size = new Size(1369, 2);
            tabBangTinhLuong.TabIndex = 1;
            tabBangTinhLuong.Text = "Bảng Tính Lương";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1377, 692);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint_2;
            // 
            // BangLuongForm
            // 
            ClientSize = new Size(1377, 742);
            Controls.Add(panelContent);
            Controls.Add(tabControl);
            Name = "BangLuongForm";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Xử lý sự kiện khi chuyển giữa các tab
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa nội dung cũ khi chuyển tab
            panelContent.Controls.Clear();

            if (tabControl.SelectedIndex == 0) // Nếu chọn "Bảng Lương"
            {
                var bangLuongControl = new BangLuongControl(); // Giao diện Bảng Lương
                panelContent.Controls.Add(bangLuongControl);
            }
            else if (tabControl.SelectedIndex == 1) // Nếu chọn "Bảng Tính Lương"
            {
                var bangTinhLuongControl = new BangTinhLuongControl(); // Giao diện Bảng Tính Lương
                panelContent.Controls.Add(bangTinhLuongControl);
            }
        }
    }
}
