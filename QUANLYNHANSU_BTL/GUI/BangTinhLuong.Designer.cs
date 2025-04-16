using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangTinhLuongControl : UserControl
    {
        private Label lblTitle;
        private Label lblPage;
        private Guna2TextBox txtSearch;
        private Guna2DateTimePicker dtpNgayLoc;
        private Guna2DataGridView dgvBangTinhLuong;
        private IconButton btnThem, btnSua, btnXoa, btnLamMoi, btnXuatExcel, btnXuatPDF, btnPrev, btnNext;



        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblPage = new Label();
            txtSearch = new Guna2TextBox();
            dtpNgayLoc = new Guna2DateTimePicker();
            dgvBangTinhLuong = new Guna2DataGridView();
            btnThem = new IconButton();
            btnSua = new IconButton();
            btnXoa = new IconButton();
            btnLamMoi = new IconButton();
            btnXuatExcel = new IconButton();
            btnXuatPDF = new IconButton();
            btnPrev = new IconButton();
            btnNext = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvBangTinhLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin Bảng tính lương";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblPage
            // 
            lblPage.Font = new Font("Segoe UI", 10F);
            lblPage.Location = new Point(557, 587);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(100, 30);
            lblPage.TabIndex = 1;
            lblPage.Text = "Trang 1/1";
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(20, 54);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm mã NV...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(250, 36);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtpNgayLoc
            // 
            dtpNgayLoc.Checked = true;
            dtpNgayLoc.CustomFormat = "MM/yyyy";
            dtpNgayLoc.CustomizableEdges = customizableEdges3;
            dtpNgayLoc.Font = new Font("Segoe UI", 9F);
            dtpNgayLoc.Format = DateTimePickerFormat.Custom;
            dtpNgayLoc.Location = new Point(1152, 40);
            dtpNgayLoc.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpNgayLoc.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpNgayLoc.Name = "dtpNgayLoc";
            dtpNgayLoc.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpNgayLoc.ShowUpDown = true;
            dtpNgayLoc.Size = new Size(115, 36);
            dtpNgayLoc.TabIndex = 3;
            dtpNgayLoc.Value = new DateTime(2025, 4, 1, 16, 25, 21, 247);
            dtpNgayLoc.ValueChanged += dtpNgayLoc_ValueChanged;
            // 
            // dgvBangTinhLuong
            // 
            dgvBangTinhLuong.AllowUserToAddRows = false;
            dgvBangTinhLuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBangTinhLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBangTinhLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBangTinhLuong.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBangTinhLuong.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBangTinhLuong.GridColor = Color.FromArgb(231, 229, 255);
            dgvBangTinhLuong.Location = new Point(20, 97);
            dgvBangTinhLuong.Name = "dgvBangTinhLuong";
            dgvBangTinhLuong.ReadOnly = true;
            dgvBangTinhLuong.RowHeadersVisible = false;
            dgvBangTinhLuong.RowHeadersWidth = 51;
            dgvBangTinhLuong.Size = new Size(1247, 478);
            dgvBangTinhLuong.TabIndex = 4;
            dgvBangTinhLuong.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBangTinhLuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBangTinhLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBangTinhLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBangTinhLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBangTinhLuong.ThemeStyle.BackColor = Color.White;
            dgvBangTinhLuong.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBangTinhLuong.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBangTinhLuong.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBangTinhLuong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvBangTinhLuong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBangTinhLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBangTinhLuong.ThemeStyle.HeaderStyle.Height = 29;
            dgvBangTinhLuong.ThemeStyle.ReadOnly = true;
            dgvBangTinhLuong.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBangTinhLuong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBangTinhLuong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBangTinhLuong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBangTinhLuong.ThemeStyle.RowsStyle.Height = 29;
            dgvBangTinhLuong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBangTinhLuong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Blue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.IconChar = IconChar.Add;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = IconFont.Auto;
            btnThem.IconSize = 20;
            btnThem.Location = new Point(20, 656);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 50);
            btnThem.TabIndex = 5;
            btnThem.Text = " Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Green;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.IconChar = IconChar.Edit;
            btnSua.IconColor = Color.White;
            btnSua.IconFont = IconFont.Auto;
            btnSua.IconSize = 20;
            btnSua.Location = new Point(226, 655);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 50);
            btnSua.TabIndex = 6;
            btnSua.Text = " Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.IconChar = IconChar.Trash;
            btnXoa.IconColor = Color.White;
            btnXoa.IconFont = IconFont.Auto;
            btnXoa.IconSize = 20;
            btnXoa.Location = new Point(450, 657);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 50);
            btnXoa.TabIndex = 7;
            btnXoa.Text = " Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Orange;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.IconChar = IconChar.SyncAlt;
            btnLamMoi.IconColor = Color.White;
            btnLamMoi.IconFont = IconFont.Auto;
            btnLamMoi.IconSize = 20;
            btnLamMoi.Location = new Point(677, 657);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 50);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = " Làm mới";
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.SeaGreen;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.IconChar = IconChar.FileExcel;
            btnXuatExcel.IconColor = Color.White;
            btnXuatExcel.IconFont = IconFont.Auto;
            btnXuatExcel.IconSize = 20;
            btnXuatExcel.Location = new Point(899, 657);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(122, 51);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = " Excel";
            btnXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.BackColor = Color.IndianRed;
            btnXuatPDF.FlatStyle = FlatStyle.Flat;
            btnXuatPDF.ForeColor = Color.White;
            btnXuatPDF.IconChar = IconChar.FilePdf;
            btnXuatPDF.IconColor = Color.White;
            btnXuatPDF.IconFont = IconFont.Auto;
            btnXuatPDF.IconSize = 20;
            btnXuatPDF.Location = new Point(1140, 657);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(127, 51);
            btnXuatPDF.TabIndex = 10;
            btnXuatPDF.Text = " PDF";
            btnXuatPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatPDF.UseVisualStyleBackColor = false;
            btnXuatPDF.Click += btnXuatPDF_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gray;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.ForeColor = Color.White;
            btnPrev.IconChar = IconChar.None;
            btnPrev.IconColor = Color.Black;
            btnPrev.IconFont = IconFont.Auto;
            btnPrev.Location = new Point(1168, 581);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 36);
            btnPrev.TabIndex = 11;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.White;
            btnNext.IconChar = IconChar.None;
            btnNext.IconColor = Color.Black;
            btnNext.IconFont = IconFont.Auto;
            btnNext.Location = new Point(1214, 581);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 36);
            btnNext.TabIndex = 12;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // BangTinhLuongControl
            // 
            Controls.Add(lblTitle);
            Controls.Add(lblPage);
            Controls.Add(txtSearch);
            Controls.Add(dtpNgayLoc);
            Controls.Add(dgvBangTinhLuong);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnXuatPDF);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Name = "BangTinhLuongControl";
            Size = new Size(1312, 728);
            Load += BangTinhLuongControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBangTinhLuong).EndInit();
            ResumeLayout(false);
        }
    }
}
