using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;
namespace QUANLYNHANSU_BTL.GUI
{
    partial class BoPhanForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvBoPhan;
        private Guna2TextBox txtTimKiem;
        private Label lblTitle;
        private Label lblTimKiem;
        private IconButton btnThem;
        private IconButton btnSua;
        private IconButton btnXoa;
        private IconButton btnLamMoi;
        private IconButton btnTruoc;
        private IconButton btnSau;
        private System.Windows.Forms.Label lblTrang;
        private FontAwesome.Sharp.IconButton btnXuatExcel;

        /// <summary>
        /// Giải phóng tài nguyên
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Khởi tạo giao diện
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnXuatExcel = new IconButton();
            lblTrang = new Label();
            dgvBoPhan = new Guna2DataGridView();
            txtTimKiem = new Guna2TextBox();
            lblTitle = new Label();
            lblTimKiem = new Label();
            btnThem = new IconButton();
            btnSua = new IconButton();
            btnXoa = new IconButton();
            btnLamMoi = new IconButton();
            btnTruoc = new IconButton();
            btnSau = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvBoPhan).BeginInit();
            SuspendLayout();
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatExcel.IconChar = IconChar.FileExcel;
            btnXuatExcel.IconColor = Color.Green;
            btnXuatExcel.IconFont = IconFont.Auto;
            btnXuatExcel.IconSize = 24;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(1096, 602);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(133, 52);
            btnXuatExcel.TabIndex = 4;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.TextAlign = ContentAlignment.MiddleRight;
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // lblTrang
            // 
            lblTrang.AutoSize = true;
            lblTrang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrang.Location = new Point(580, 512);
            lblTrang.Name = "lblTrang";
            lblTrang.Size = new Size(99, 23);
            lblTrang.TabIndex = 10;
            lblTrang.Text = "Trang 1 / 1";
            // 
            // dgvBoPhan
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBoPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBoPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBoPhan.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBoPhan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBoPhan.GridColor = Color.FromArgb(231, 229, 255);
            dgvBoPhan.Location = new Point(20, 117);
            dgvBoPhan.Name = "dgvBoPhan";
            dgvBoPhan.RowHeadersVisible = false;
            dgvBoPhan.RowHeadersWidth = 51;
            dgvBoPhan.RowTemplate.Height = 30;
            dgvBoPhan.Size = new Size(1209, 374);
            dgvBoPhan.TabIndex = 3;
            dgvBoPhan.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBoPhan.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBoPhan.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBoPhan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBoPhan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBoPhan.ThemeStyle.BackColor = Color.White;
            dgvBoPhan.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBoPhan.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBoPhan.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBoPhan.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvBoPhan.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBoPhan.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBoPhan.ThemeStyle.HeaderStyle.Height = 29;
            dgvBoPhan.ThemeStyle.ReadOnly = false;
            dgvBoPhan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBoPhan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBoPhan.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBoPhan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBoPhan.ThemeStyle.RowsStyle.Height = 30;
            dgvBoPhan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBoPhan.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(135, 74);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(300, 36);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 49);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Bộ phận";
            // 
            // lblTimKiem
            // 
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.Black;
            lblTimKiem.Location = new Point(29, 80);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(100, 23);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.IconChar = IconChar.CirclePlus;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = IconFont.Auto;
            btnThem.IconSize = 24;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(20, 605);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 52);
            btnThem.TabIndex = 4;
            btnThem.Text = " Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkOrange;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.IconChar = IconChar.Edit;
            btnSua.IconColor = Color.White;
            btnSua.IconFont = IconFont.Auto;
            btnSua.IconSize = 24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(296, 605);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 52);
            btnSua.TabIndex = 5;
            btnSua.Text = " Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.IconChar = IconChar.Trash;
            btnXoa.IconColor = Color.White;
            btnXoa.IconFont = IconFont.Auto;
            btnXoa.IconSize = 24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(601, 605);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 52);
            btnXoa.TabIndex = 6;
            btnXoa.Text = " Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DodgerBlue;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.IconChar = IconChar.Refresh;
            btnLamMoi.IconColor = Color.White;
            btnLamMoi.IconFont = IconFont.Auto;
            btnLamMoi.IconSize = 24;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(869, 602);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(139, 58);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = " Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.BackColor = Color.Gray;
            btnTruoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTruoc.ForeColor = Color.White;
            btnTruoc.IconChar = IconChar.ArrowLeft;
            btnTruoc.IconColor = Color.White;
            btnTruoc.IconFont = IconFont.Auto;
            btnTruoc.IconSize = 24;
            btnTruoc.ImageAlign = ContentAlignment.MiddleLeft;
            btnTruoc.Location = new Point(1055, 512);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(35, 40);
            btnTruoc.TabIndex = 8;
            btnTruoc.UseVisualStyleBackColor = false;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnSau
            // 
            btnSau.BackColor = Color.Gray;
            btnSau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSau.ForeColor = Color.White;
            btnSau.IconChar = IconChar.ArrowRight;
            btnSau.IconColor = Color.White;
            btnSau.IconFont = IconFont.Auto;
            btnSau.IconSize = 24;
            btnSau.ImageAlign = ContentAlignment.MiddleLeft;
            btnSau.Location = new Point(1096, 512);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(35, 40);
            btnSau.TabIndex = 9;
            btnSau.UseVisualStyleBackColor = false;
            btnSau.Click += btnSau_Click;
            // 
            // BoPhanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 697);
            Controls.Add(btnXuatExcel);
            Controls.Add(lblTrang);
            Controls.Add(lblTitle);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvBoPhan);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTruoc);
            Controls.Add(btnSau);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BoPhanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Bộ phận";
            Load += BoPhanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoPhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
