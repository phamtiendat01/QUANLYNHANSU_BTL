using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BoPhanPopup : Form
    {


        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblMaPB = new Label();
            lblTenPB = new Label();
            txtMaPB = new TextBox();
            txtTenPB = new TextBox();
            btnLuu = new FontAwesome.Sharp.IconButton();
            btnHuy = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(80, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông Tin Bộ Phận";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaPB
            // 
            lblMaPB.AutoSize = true;
            lblMaPB.Font = new Font("Segoe UI", 12F);
            lblMaPB.Location = new Point(20, 80);
            lblMaPB.Name = "lblMaPB";
            lblMaPB.Size = new Size(143, 28);
            lblMaPB.TabIndex = 1;
            lblMaPB.Text = "Mã Phòng Ban:";
            // 
            // lblTenPB
            // 
            lblTenPB.AutoSize = true;
            lblTenPB.Font = new Font("Segoe UI", 12F);
            lblTenPB.Location = new Point(20, 130);
            lblTenPB.Name = "lblTenPB";
            lblTenPB.Size = new Size(144, 28);
            lblTenPB.TabIndex = 3;
            lblTenPB.Text = "Tên Phòng Ban:";
            // 
            // txtMaPB
            // 
            txtMaPB.BackColor = Color.WhiteSmoke;
            txtMaPB.BorderStyle = BorderStyle.FixedSingle;
            txtMaPB.Font = new Font("Segoe UI", 12F);
            txtMaPB.Location = new Point(170, 77);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.Size = new Size(230, 34);
            txtMaPB.TabIndex = 2;
            txtMaPB.Paint += TxtBox_Paint;
            // 
            // txtTenPB
            // 
            txtTenPB.BackColor = Color.WhiteSmoke;
            txtTenPB.BorderStyle = BorderStyle.FixedSingle;
            txtTenPB.Font = new Font("Segoe UI", 12F);
            txtTenPB.Location = new Point(170, 127);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.Size = new Size(230, 34);
            txtTenPB.TabIndex = 4;
            txtTenPB.Paint += TxtBox_Paint;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SeaGreen;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnLuu.IconColor = Color.White;
            btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLuu.Location = new Point(60, 190);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(130, 45);
            btnLuu.TabIndex = 5;
            btnLuu.Text = " Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Firebrick;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnHuy.IconColor = Color.White;
            btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHuy.Location = new Point(230, 190);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(130, 45);
            btnHuy.TabIndex = 6;
            btnHuy.Text = " Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // BoPhanPopup
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(419, 265);
            Controls.Add(lblTitle);
            Controls.Add(lblMaPB);
            Controls.Add(txtMaPB);
            Controls.Add(lblTenPB);
            Controls.Add(txtTenPB);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BoPhanPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Bộ Phận";
            Load += BoPhanPopup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // 🔹 Bo góc button bằng GraphicsPath
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // 🔹 Làm viền TextBox nhạt hơn bằng Paint
        private void TxtBox_Paint(object sender, PaintEventArgs e)
        {
            TextBox txt = sender as TextBox;
            Pen p = new Pen(Color.LightGray, 2);
            e.Graphics.DrawRectangle(p, new Rectangle(0, 0, txt.Width - 1, txt.Height - 1));
        }

        

        private Label lblTitle;
        private Label lblMaPB;
        private Label lblTenPB;
        private TextBox txtMaPB;
        private TextBox txtTenPB;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnHuy;
    }
}
