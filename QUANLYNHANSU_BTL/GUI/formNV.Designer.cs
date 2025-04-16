using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace QUANLYNHANSU_BTL.GUI
{
    public partial class formNV : Form
    {
        private Panel pnlSidebar;
        private Panel pnlMainContent;
        private Label lblFooter;
        private Label lblTitle;
        private PictureBox pbxLogo;
        private PictureBox pbBackground;
        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer timerClock;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private Button btnTrangChu, btnThongTin, btnChamCong, btnBangLuong, btnHeThong;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlSidebar = new Panel();
            pbxLogo = new PictureBox();
            btnDangXuat = new IconButton();
            lblTitle = new Label();
            lblFooter = new Label();
            pnlMainContent = new Panel();
            pbBackground = new PictureBox();
            lblTime = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            pbBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(230, 240, 250);
            pnlSidebar.Controls.Add(pbxLogo);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(lblFooter);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 771);
            pnlSidebar.TabIndex = 1;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(20, 20);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(50, 50);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDangXuat.BackColor = Color.Firebrick;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.IconChar = IconChar.SignOutAlt;
            btnDangXuat.IconColor = Color.White;
            btnDangXuat.IconFont = IconFont.Auto;
            btnDangXuat.IconSize = 20;
            btnDangXuat.Location = new Point(20, 673);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 45);
            btnDangXuat.TabIndex = 1;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleRight;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += BtnDangXuat_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(80, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(79, 29);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "QLNV";
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Arial", 10F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(0, 721);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(220, 50);
            lblFooter.TabIndex = 2;
            lblFooter.Text = "Nhân viên: GUEST  |  Quyền hạn: XEM THÔNG TIN ";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Controls.Add(pbBackground);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(220, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1329, 771);
            pnlMainContent.TabIndex = 0;
            // 
            // pbBackground
            // 
            pbBackground.Controls.Add(lblTime);
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = (Image)resources.GetObject("pbBackground.Image");
            pbBackground.Location = new Point(0, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(1329, 771);
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackground.TabIndex = 0;
            pbBackground.TabStop = false;
            pbBackground.Click += pbBackground_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTime.ForeColor = Color.DarkBlue;
            lblTime.Location = new Point(149, 30);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 50);
            lblTime.TabIndex = 0;
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            ClientSize = new Size(1549, 771);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân sự";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            pbBackground.ResumeLayout(false);
            pbBackground.PerformLayout();
            ResumeLayout(false);
        }
    }
}
