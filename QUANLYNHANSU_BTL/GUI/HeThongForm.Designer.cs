using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class HeThongForm : Form
    {
        private Label lblTitle;
        private Label lblPage;
        private Guna2TextBox txtSearch;
        private Guna2DataGridView dgvTaiKhoan;
        private IconButton btnThem, btnSua, btnXoa, btnLamMoi;
        private IconButton btnPrev, btnNext;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblPage = new Label();
            txtSearch = new Guna2TextBox();
            dgvTaiKhoan = new Guna2DataGridView();
            btnThem = new IconButton();
            btnSua = new IconButton();
            btnXoa = new IconButton();
            btnLamMoi = new IconButton();
            btnPrev = new IconButton();
            btnNext = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(31, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin Tài khoản";
            // 
            // lblPage
            // 
            lblPage.Location = new Point(567, 578);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(92, 30);
            lblPage.TabIndex = 1;
            lblPage.Text = "Trang 1/1";
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(31, 71);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm tài khoản...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(301, 40);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTaiKhoan.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTaiKhoan.GridColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.Location = new Point(31, 118);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 24;
            dgvTaiKhoan.Size = new Size(1212, 448);
            dgvTaiKhoan.TabIndex = 3;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 30;
            dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Blue;
            btnThem.IconChar = IconChar.Add;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = IconFont.Auto;
            btnThem.IconSize = 20;
            btnThem.Location = new Point(326, 638);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 57);
            btnThem.TabIndex = 4;
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
            btnSua.Location = new Point(477, 638);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 57);
            btnSua.TabIndex = 5;
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
            btnXoa.Location = new Point(631, 638);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 57);
            btnXoa.TabIndex = 6;
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
            btnLamMoi.Location = new Point(791, 638);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(135, 57);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gray;
            btnPrev.IconChar = IconChar.None;
            btnPrev.IconColor = Color.Black;
            btnPrev.IconFont = IconFont.Auto;
            btnPrev.Location = new Point(1096, 570);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 36);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.IconChar = IconChar.None;
            btnNext.IconColor = Color.Black;
            btnNext.IconFont = IconFont.Auto;
            btnNext.Location = new Point(1142, 570);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 36);
            btnNext.TabIndex = 9;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // HeThongForm
            // 
            ClientSize = new Size(1279, 707);
            Controls.Add(lblTitle);
            Controls.Add(lblPage);
            Controls.Add(txtSearch);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Name = "HeThongForm";
            Load += HeThongForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }
    }
}
