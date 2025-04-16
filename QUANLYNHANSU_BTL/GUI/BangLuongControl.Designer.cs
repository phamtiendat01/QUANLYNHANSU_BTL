using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp; // Để sử dụng các biểu tượng của FontAwesome
using Guna.UI2.WinForms; // Để sử dụng các control Guna

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongControl : UserControl
    {
        private Label lblTitle;
        private Label lblPage;
        private Guna2TextBox txtSearch;
        private Guna2DataGridView dgvBangLuong;
        private IconButton btnThem, btnSua, btnXoa, btnLamMoi, btnExportExcel, btnPrev, btnNext;


        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblPage = new Label();
            txtSearch = new Guna2TextBox();
            dgvBangLuong = new Guna2DataGridView();
            btnThem = new IconButton();
            btnSua = new IconButton();
            btnXoa = new IconButton();
            btnLamMoi = new IconButton();
            btnExportExcel = new IconButton();
            btnPrev = new IconButton();
            btnNext = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(31, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 43);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Thông tin Bảng Lương";
            // 
            // lblPage
            // 
            lblPage.Location = new Point(671, 570);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(104, 30);
            lblPage.TabIndex = 10;
            lblPage.Text = "Trang 1/10";
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(31, 71);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm mã nhân viên...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(301, 40);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBangLuong
            // 
            dgvBangLuong.AllowUserToAddRows = false;
            dgvBangLuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBangLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvBangLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBangLuong.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBangLuong.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBangLuong.GridColor = Color.FromArgb(231, 229, 255);
            dgvBangLuong.Location = new Point(31, 118);
            dgvBangLuong.Name = "dgvBangLuong";
            dgvBangLuong.ReadOnly = true;
            dgvBangLuong.RowHeadersVisible = false;
            dgvBangLuong.RowHeadersWidth = 51;
            dgvBangLuong.RowTemplate.Height = 24;
            dgvBangLuong.Size = new Size(1213, 438);
            dgvBangLuong.TabIndex = 0;
            dgvBangLuong.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBangLuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBangLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBangLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBangLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBangLuong.ThemeStyle.BackColor = Color.White;
            dgvBangLuong.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBangLuong.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBangLuong.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBangLuong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvBangLuong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBangLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBangLuong.ThemeStyle.HeaderStyle.Height = 30;
            dgvBangLuong.ThemeStyle.ReadOnly = true;
            dgvBangLuong.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBangLuong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBangLuong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBangLuong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBangLuong.ThemeStyle.RowsStyle.Height = 24;
            dgvBangLuong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBangLuong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Blue;
            btnThem.IconChar = IconChar.Add;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = IconFont.Auto;
            btnThem.IconSize = 20;
            btnThem.Location = new Point(31, 635);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 56);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Green;
            btnSua.IconChar = IconChar.Edit;
            btnSua.IconColor = Color.White;
            btnSua.IconFont = IconFont.Auto;
            btnSua.IconSize = 20;
            btnSua.Location = new Point(327, 635);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 56);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.IconChar = IconChar.Trash;
            btnXoa.IconColor = Color.White;
            btnXoa.IconFont = IconFont.Auto;
            btnXoa.IconSize = 20;
            btnXoa.Location = new Point(602, 635);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(134, 56);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Orange;
            btnLamMoi.IconChar = IconChar.SyncAlt;
            btnLamMoi.IconColor = Color.White;
            btnLamMoi.IconFont = IconFont.Auto;
            btnLamMoi.IconSize = 20;
            btnLamMoi.Location = new Point(875, 635);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(132, 56);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.SeaGreen;
            btnExportExcel.IconChar = IconChar.FileExcel;
            btnExportExcel.IconColor = Color.White;
            btnExportExcel.IconFont = IconFont.Auto;
            btnExportExcel.IconSize = 20;
            btnExportExcel.Location = new Point(1112, 635);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(132, 56);
            btnExportExcel.TabIndex = 7;
            btnExportExcel.Text = "Excel";
            btnExportExcel.TextAlign = ContentAlignment.MiddleRight;
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gray;
            btnPrev.IconChar = IconChar.None;
            btnPrev.IconColor = Color.White;
            btnPrev.IconFont = IconFont.Auto;
            btnPrev.Location = new Point(1154, 564);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 36);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrevPage_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.IconChar = IconChar.None;
            btnNext.IconColor = Color.White;
            btnNext.IconFont = IconFont.Auto;
            btnNext.Location = new Point(1200, 564);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 36);
            btnNext.TabIndex = 9;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNextPage_Click;
            // 
            // BangLuongControl
            // 
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(dgvBangLuong);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnExportExcel);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Name = "BangLuongControl";
            Size = new Size(1296, 717);
            Load += BangLuongControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).EndInit();
            ResumeLayout(false);
        }
    }
}
