using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;
using System.Drawing;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class CongTacForm : Form
    {
        private Label lblTitle;
        private Guna2TextBox txtSearch;
        private Guna2DateTimePicker dtpFrom, dtpTo;
        private Guna2Button btnFilter;
        private Guna2DataGridView dgvCongTac; // Dùng Guna2DataGridView thay vì DataGridView
        private FlowLayoutPanel flowTienTrinh;
        private IconButton btnAdd, btnEdit, btnDelete, btnRefresh, btnExportExcel;
        private Label lblPageInfo;
        private IconButton btnPrevious, btnNext;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            txtSearch = new Guna2TextBox();
            dtpFrom = new Guna2DateTimePicker();
            dtpTo = new Guna2DateTimePicker();
            btnFilter = new Guna2Button();
            dgvCongTac = new Guna2DataGridView();
            flowTienTrinh = new FlowLayoutPanel();
            btnAdd = new IconButton();
            btnEdit = new IconButton();
            btnDelete = new IconButton();
            btnRefresh = new IconButton();
            btnExportExcel = new IconButton();
            lblPageInfo = new Label();
            btnPrevious = new IconButton();
            btnNext = new IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvCongTac).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(324, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tiến trình công tác";
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(350, 30);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm theo tên hoặc mã nhân viên...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(305, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Checked = true;
            dtpFrom.CustomizableEdges = customizableEdges3;
            dtpFrom.Font = new Font("Segoe UI", 9F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(713, 30);
            dtpFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpFrom.Size = new Size(150, 30);
            dtpFrom.TabIndex = 2;
            dtpFrom.Value = new DateTime(2025, 4, 24, 17, 10, 14, 366);
            // 
            // dtpTo
            // 
            dtpTo.Checked = true;
            dtpTo.CustomizableEdges = customizableEdges5;
            dtpTo.Font = new Font("Segoe UI", 9F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(869, 30);
            dtpTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTo.Size = new Size(150, 30);
            dtpTo.TabIndex = 3;
            dtpTo.Value = new DateTime(2025, 4, 24, 17, 10, 14, 409);
            // 
            // btnFilter
            // 
            btnFilter.CustomizableEdges = customizableEdges7;
            btnFilter.Font = new Font("Segoe UI", 9F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(1025, 30);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFilter.Size = new Size(50, 30);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "🔍";
            btnFilter.Click += btnFilter_Click;
            // 
            // dgvCongTac
            // 
            dgvCongTac.AllowUserToAddRows = false;
            dgvCongTac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCongTac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCongTac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCongTac.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCongTac.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCongTac.GridColor = Color.FromArgb(231, 229, 255);
            dgvCongTac.Location = new Point(20, 95);
            dgvCongTac.Name = "dgvCongTac";
            dgvCongTac.RowHeadersVisible = false;
            dgvCongTac.RowHeadersWidth = 51;
            dgvCongTac.Size = new Size(843, 503);
            dgvCongTac.TabIndex = 5;
            dgvCongTac.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCongTac.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCongTac.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCongTac.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCongTac.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCongTac.ThemeStyle.BackColor = Color.White;
            dgvCongTac.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCongTac.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCongTac.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCongTac.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCongTac.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCongTac.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCongTac.ThemeStyle.HeaderStyle.Height = 29;
            dgvCongTac.ThemeStyle.ReadOnly = false;
            dgvCongTac.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCongTac.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCongTac.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCongTac.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCongTac.ThemeStyle.RowsStyle.Height = 29;
            dgvCongTac.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCongTac.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCongTac.CellClick += dgvCongTac_CellClick;
            // 
            // flowTienTrinh
            // 
            flowTienTrinh.AutoScroll = true;
            flowTienTrinh.FlowDirection = FlowDirection.TopDown;
            flowTienTrinh.Location = new Point(886, 95);
            flowTienTrinh.Name = "flowTienTrinh";
            flowTienTrinh.Size = new Size(330, 389);
            flowTienTrinh.TabIndex = 6;
            flowTienTrinh.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(100, 88, 255);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = IconChar.CirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.Location = new Point(20, 657);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 55);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 140, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = IconChar.Edit;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = IconFont.Auto;
            btnEdit.IconSize = 20;
            btnEdit.Location = new Point(260, 657);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 55);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 69, 58);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.Location = new Point(514, 657);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 55);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(76, 175, 80);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = IconChar.SyncAlt;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = IconFont.Auto;
            btnRefresh.IconSize = 20;
            btnRefresh.Location = new Point(773, 657);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 55);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(0, 123, 255);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.IconChar = IconChar.FileExcel;
            btnExportExcel.IconColor = Color.White;
            btnExportExcel.IconFont = IconFont.Auto;
            btnExportExcel.IconSize = 20;
            btnExportExcel.Location = new Point(1010, 657);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(109, 55);
            btnExportExcel.TabIndex = 11;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageInfo.Location = new Point(333, 612);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(100, 28);
            lblPageInfo.TabIndex = 12;
            lblPageInfo.Text = "Trang 1/10";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(100, 88, 255);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.IconChar = IconChar.None;
            btnPrevious.IconColor = Color.White;
            btnPrevious.IconFont = IconFont.Auto;
            btnPrevious.IconSize = 20;
            btnPrevious.Location = new Point(713, 604);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(37, 40);
            btnPrevious.TabIndex = 13;
            btnPrevious.Text = "<";
            btnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(100, 88, 255);
            btnNext.ForeColor = Color.White;
            btnNext.IconChar = IconChar.None;
            btnNext.IconColor = Color.White;
            btnNext.IconFont = IconFont.Auto;
            btnNext.IconSize = 20;
            btnNext.Location = new Point(756, 604);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(37, 40);
            btnNext.TabIndex = 14;
            btnNext.Text = ">";
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // CongTacForm
            // 
            ClientSize = new Size(1250, 738);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(dtpFrom);
            Controls.Add(dtpTo);
            Controls.Add(btnFilter);
            Controls.Add(dgvCongTac);
            Controls.Add(flowTienTrinh);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnExportExcel);
            Controls.Add(lblPageInfo);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Name = "CongTacForm";
            Text = "Tiến trình công tác";
            Load += CongTacForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCongTac).EndInit();
            ResumeLayout(false);
        }
    }
}
