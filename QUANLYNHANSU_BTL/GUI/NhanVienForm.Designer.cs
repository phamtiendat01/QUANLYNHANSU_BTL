using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class NhanVienForm : Form
    {
        private Label lblTitle, lblPage;
        private Guna2TextBox txtSearch;
        private Guna2ComboBox cmbFilter;
        private Guna2DataGridView dgvNhanVien;
        private IconButton btnThem, btnSua, btnXoa, btnLamMoi, btnXuatExcel, btnLoc, btnPrev, btnNext;

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
            cmbFilter = new Guna2ComboBox();
            dgvNhanVien = new Guna2DataGridView();
            btnThem = new IconButton();
            btnSua = new IconButton();
            btnXoa = new IconButton();
            btnLamMoi = new IconButton();
            btnXuatExcel = new IconButton();
            btnLoc = new IconButton();
            btnPrev = new IconButton();
            btnNext = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(290, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin nhân viên";
            // 
            // lblPage
            // 
            lblPage.Font = new Font("Segoe UI", 10F);
            lblPage.Location = new Point(597, 551);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(96, 34);
            lblPage.TabIndex = 4;
            lblPage.Text = "Trang 1/5";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 8;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(20, 70);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(250, 36);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = Color.Transparent;
            cmbFilter.BorderRadius = 8;
            cmbFilter.CustomizableEdges = customizableEdges3;
            cmbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FocusedColor = Color.Empty;
            cmbFilter.Font = new Font("Segoe UI", 10F);
            cmbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cmbFilter.ItemHeight = 30;
            cmbFilter.Items.AddRange(new object[] { "Tất cả", "Nhân viên", "Quản lý", "Giám đốc" });
            cmbFilter.Location = new Point(280, 70);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbFilter.Size = new Size(180, 36);
            cmbFilter.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.GridColor = Color.FromArgb(231, 229, 255);
            dgvNhanVien.Location = new Point(20, 120);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1251, 425);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.AliceBlue;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvNhanVien.ThemeStyle.BackColor = Color.White;
            dgvNhanVien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.ThemeStyle.HeaderStyle.Height = 29;
            dgvNhanVien.ThemeStyle.ReadOnly = true;
            dgvNhanVien.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvNhanVien.ThemeStyle.RowsStyle.Height = 29;
            dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = Color.LightBlue;
            dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Blue;
            btnThem.ForeColor = Color.White;
            btnThem.IconChar = IconChar.Add;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = IconFont.Auto;
            btnThem.IconSize = 24;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(20, 602);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 59);
            btnThem.TabIndex = 5;
            btnThem.Text = " Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += BtnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Green;
            btnSua.ForeColor = Color.White;
            btnSua.IconChar = IconChar.Edit;
            btnSua.IconColor = Color.White;
            btnSua.IconFont = IconFont.Auto;
            btnSua.IconSize = 24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(280, 602);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 59);
            btnSua.TabIndex = 6;
            btnSua.Text = " Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += BtnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.White;
            btnXoa.IconChar = IconChar.Trash;
            btnXoa.IconColor = Color.White;
            btnXoa.IconFont = IconFont.Auto;
            btnXoa.IconSize = 24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(553, 602);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(149, 59);
            btnXoa.TabIndex = 7;
            btnXoa.Text = " Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += BtnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Orange;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.IconChar = IconChar.Refresh;
            btnLamMoi.IconColor = Color.White;
            btnLamMoi.IconFont = IconFont.Auto;
            btnLamMoi.IconSize = 24;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(864, 602);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(144, 59);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = " Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += BtnLamMoi_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkGreen;
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.IconChar = IconChar.FileExcel;
            btnXuatExcel.IconColor = Color.White;
            btnXuatExcel.IconFont = IconFont.Auto;
            btnXuatExcel.IconSize = 24;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(1124, 602);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(144, 59);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = " Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += BtnXuatExcel_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.Gray;
            btnLoc.ForeColor = Color.White;
            btnLoc.IconChar = IconChar.Filter;
            btnLoc.IconColor = Color.White;
            btnLoc.IconFont = IconFont.Auto;
            btnLoc.IconSize = 24;
            btnLoc.Location = new Point(470, 70);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(45, 36);
            btnLoc.TabIndex = 10;
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gray;
            btnPrev.ForeColor = Color.White;
            btnPrev.IconChar = IconChar.None;
            btnPrev.IconColor = Color.Black;
            btnPrev.IconFont = IconFont.Auto;
            btnPrev.Location = new Point(1098, 551);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(50, 36);
            btnPrev.TabIndex = 11;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.ForeColor = Color.White;
            btnNext.IconChar = IconChar.None;
            btnNext.IconColor = Color.Black;
            btnNext.IconFont = IconFont.Auto;
            btnNext.Location = new Point(1154, 551);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(50, 36);
            btnNext.TabIndex = 12;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += BtnNext_Click;
            // 
            // NhanVienForm
            // 
            ClientSize = new Size(1280, 707);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(cmbFilter);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblPage);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnLoc);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Name = "NhanVienForm";
            Load += NhanVienForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }
    }
}
