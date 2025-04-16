using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ChamCongForm : Form
    {
        private Label lblTitle;
        private Label lblPage;
        private Label lblClock;

        private Guna2TextBox txtSearch;
        private Guna2DateTimePicker dtpNgayLoc;
        private Guna2DataGridView dgvChamCong;

        private IconButton btnThem;
        private IconButton btnSua;
        private IconButton btnXoa;
        private IconButton btnLamMoi;
        private IconButton btnXuatExcel;
        private IconButton btnXuatPDF;
        private IconButton btnChamCongTuDong;
        private IconButton btnPrev;
        private IconButton btnNext;

        private System.Windows.Forms.Timer timerClock;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblPage = new Label();
            lblClock = new Label();
            txtSearch = new Guna2TextBox();
            dtpNgayLoc = new Guna2DateTimePicker();
            dgvChamCong = new Guna2DataGridView();
            btnThem = new IconButton();
            btnSua = new IconButton();
            btnXoa = new IconButton();
            btnLamMoi = new IconButton();
            btnXuatExcel = new IconButton();
            btnXuatPDF = new IconButton();
            btnChamCongTuDong = new IconButton();
            btnPrev = new IconButton();
            btnNext = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Chấm công nhân viên";
            // 
            // lblPage
            // 
            lblPage.Font = new Font("Segoe UI", 10F);
            lblPage.Location = new Point(572, 567);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(106, 30);
            lblPage.TabIndex = 14;
            lblPage.Text = "Trang 1/1";
            // 
            // lblClock
            // 
            lblClock.BackColor = Color.Transparent;
            lblClock.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblClock.ForeColor = Color.DimGray;
            lblClock.Location = new Point(950, 70);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(140, 30);
            lblClock.TabIndex = 1;
            lblClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(20, 77);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm mã NV...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(200, 36);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtpNgayLoc
            // 
            dtpNgayLoc.Checked = true;
            dtpNgayLoc.CustomizableEdges = customizableEdges11;
            dtpNgayLoc.Font = new Font("Segoe UI", 9F);
            dtpNgayLoc.Format = DateTimePickerFormat.Short;
            dtpNgayLoc.Location = new Point(1096, 70);
            dtpNgayLoc.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpNgayLoc.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpNgayLoc.Name = "dtpNgayLoc";
            dtpNgayLoc.ShadowDecoration.CustomizableEdges = customizableEdges12;
            dtpNgayLoc.Size = new Size(150, 36);
            dtpNgayLoc.TabIndex = 3;
            dtpNgayLoc.Value = new DateTime(2025, 3, 26, 16, 1, 14, 239);
            dtpNgayLoc.ValueChanged += dtpLoc_ValueChanged;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.AliceBlue;
            dgvChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvChamCong.ColumnHeadersHeight = 29;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvChamCong.DefaultCellStyle = dataGridViewCellStyle9;
            dgvChamCong.GridColor = Color.FromArgb(231, 229, 255);
            dgvChamCong.Location = new Point(20, 120);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.ReadOnly = true;
            dgvChamCong.RowHeadersVisible = false;
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(1226, 441);
            dgvChamCong.TabIndex = 4;
            dgvChamCong.ThemeStyle.AlternatingRowsStyle.BackColor = Color.AliceBlue;
            dgvChamCong.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvChamCong.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvChamCong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvChamCong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvChamCong.ThemeStyle.BackColor = Color.White;
            dgvChamCong.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvChamCong.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvChamCong.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChamCong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvChamCong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvChamCong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChamCong.ThemeStyle.HeaderStyle.Height = 29;
            dgvChamCong.ThemeStyle.ReadOnly = true;
            dgvChamCong.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvChamCong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChamCong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvChamCong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvChamCong.ThemeStyle.RowsStyle.Height = 29;
            dgvChamCong.ThemeStyle.RowsStyle.SelectionBackColor = Color.LightBlue;
            dgvChamCong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Blue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.IconChar = IconChar.Add;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = IconFont.Auto;
            btnThem.IconSize = 24;
            btnThem.Location = new Point(20, 647);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 51);
            btnThem.TabIndex = 5;
            btnThem.Text = " Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
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
            btnSua.IconSize = 24;
            btnSua.Location = new Point(194, 647);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(121, 49);
            btnSua.TabIndex = 6;
            btnSua.Text = " Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
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
            btnXoa.IconSize = 24;
            btnXoa.Location = new Point(386, 647);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 51);
            btnXoa.TabIndex = 7;
            btnXoa.Text = " Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Orange;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.IconChar = IconChar.Refresh;
            btnLamMoi.IconColor = Color.White;
            btnLamMoi.IconFont = IconFont.Auto;
            btnLamMoi.IconSize = 24;
            btnLamMoi.Location = new Point(572, 647);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 51);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = " Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
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
            btnXuatExcel.IconSize = 24;
            btnXuatExcel.Location = new Point(950, 648);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(121, 48);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = " Excel";
            btnXuatExcel.TextAlign = ContentAlignment.MiddleRight;
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
            btnXuatPDF.IconSize = 24;
            btnXuatPDF.Location = new Point(763, 647);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(121, 51);
            btnXuatPDF.TabIndex = 10;
            btnXuatPDF.Text = " PDF";
            btnXuatPDF.TextAlign = ContentAlignment.MiddleRight;
            btnXuatPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatPDF.UseVisualStyleBackColor = false;
            btnXuatPDF.Click += btnXuatPDF_Click;
            // 
            // btnChamCongTuDong
            // 
            btnChamCongTuDong.BackColor = Color.MediumSlateBlue;
            btnChamCongTuDong.FlatStyle = FlatStyle.Flat;
            btnChamCongTuDong.ForeColor = Color.White;
            btnChamCongTuDong.IconChar = IconChar.Robot;
            btnChamCongTuDong.IconColor = Color.White;
            btnChamCongTuDong.IconFont = IconFont.Auto;
            btnChamCongTuDong.IconSize = 24;
            btnChamCongTuDong.Location = new Point(1126, 645);
            btnChamCongTuDong.Name = "btnChamCongTuDong";
            btnChamCongTuDong.Size = new Size(120, 51);
            btnChamCongTuDong.TabIndex = 11;
            btnChamCongTuDong.Text = " Tự động";
            btnChamCongTuDong.TextAlign = ContentAlignment.MiddleRight;
            btnChamCongTuDong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChamCongTuDong.UseVisualStyleBackColor = false;
            btnChamCongTuDong.Click += btnChamCongTuDong_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gray;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.ForeColor = Color.White;
            btnPrev.IconChar = IconChar.None;
            btnPrev.IconColor = Color.Black;
            btnPrev.IconFont = IconFont.Auto;
            btnPrev.Location = new Point(1112, 567);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 36);
            btnPrev.TabIndex = 12;
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
            btnNext.Location = new Point(1158, 567);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 36);
            btnNext.TabIndex = 13;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ChamCongForm
            // 
            ClientSize = new Size(1282, 712);
            Controls.Add(lblTitle);
            Controls.Add(lblClock);
            Controls.Add(txtSearch);
            Controls.Add(dtpNgayLoc);
            Controls.Add(dgvChamCong);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnXuatPDF);
            Controls.Add(btnChamCongTuDong);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Name = "ChamCongForm";
            Text = "Chấm công nhân viên";
            Load += ChamCongForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
        }

        private void StartClock()
        {
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 1000;
            timerClock.Tick += (s, e) => lblClock.Text = "🕒 " + DateTime.Now.ToString("HH:mm:ss");
            timerClock.Start();
        }

        private void dtpNgayLoc_ValueChanged(object sender, EventArgs e)
        {
            // TODO: Load dữ liệu chấm công theo ngày được chọn
        }
    }
}