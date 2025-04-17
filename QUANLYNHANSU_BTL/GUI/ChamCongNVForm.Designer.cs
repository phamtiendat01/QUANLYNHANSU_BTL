namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ChamCongNVForm : Form
    {
        public ChamCongNVForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            labelTitle = new Label();
            guna2ComboBoxThang = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2DataGridViewChamCong = new Guna.UI2.WinForms.Guna2DataGridView();
            lblDu = new Label();
            lblVang = new Label();
            lblKhac = new Label();
            btnPreviousPage = new Guna.UI2.WinForms.Guna2Button();
            btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            lblPageInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridViewChamCong).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(20, 58);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(303, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Chấm công nhân viên";
            // 
            // guna2ComboBoxThang
            // 
            guna2ComboBoxThang.BackColor = Color.Transparent;
            guna2ComboBoxThang.CustomizableEdges = customizableEdges1;
            guna2ComboBoxThang.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxThang.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxThang.FillColor = Color.FromArgb(255, 128, 0);
            guna2ComboBoxThang.FocusedColor = Color.Empty;
            guna2ComboBoxThang.Font = new Font("Segoe UI", 10F);
            guna2ComboBoxThang.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBoxThang.ItemHeight = 30;
            guna2ComboBoxThang.Location = new Point(1027, 58);
            guna2ComboBoxThang.Name = "guna2ComboBoxThang";
            guna2ComboBoxThang.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBoxThang.Size = new Size(120, 36);
            guna2ComboBoxThang.TabIndex = 1;
            guna2ComboBoxThang.SelectedIndexChanged += guna2ComboBoxThang_SelectedIndexChanged;
            // 
            // guna2DataGridViewChamCong
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridViewChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridViewChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridViewChamCong.ColumnHeadersHeight = 4;
            guna2DataGridViewChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridViewChamCong.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridViewChamCong.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewChamCong.Location = new Point(20, 100);
            guna2DataGridViewChamCong.Name = "guna2DataGridViewChamCong";
            guna2DataGridViewChamCong.RowHeadersVisible = false;
            guna2DataGridViewChamCong.RowHeadersWidth = 51;
            guna2DataGridViewChamCong.Size = new Size(1127, 368);
            guna2DataGridViewChamCong.TabIndex = 2;
            guna2DataGridViewChamCong.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridViewChamCong.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridViewChamCong.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridViewChamCong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridViewChamCong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridViewChamCong.ThemeStyle.BackColor = Color.White;
            guna2DataGridViewChamCong.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewChamCong.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridViewChamCong.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridViewChamCong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridViewChamCong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridViewChamCong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridViewChamCong.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridViewChamCong.ThemeStyle.ReadOnly = false;
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewChamCong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridViewChamCong.CellContentClick += guna2DataGridViewChamCong_CellContentClick;
            // 
            // lblDu
            // 
            lblDu.AutoSize = true;
            lblDu.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDu.ForeColor = Color.Green;
            lblDu.Location = new Point(20, 483);
            lblDu.Name = "lblDu";
            lblDu.Size = new Size(60, 24);
            lblDu.TabIndex = 3;
            lblDu.Text = "Đủ: 0";
            // 
            // lblVang
            // 
            lblVang.AutoSize = true;
            lblVang.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblVang.ForeColor = Color.Red;
            lblVang.Location = new Point(20, 525);
            lblVang.Name = "lblVang";
            lblVang.Size = new Size(82, 24);
            lblVang.TabIndex = 4;
            lblVang.Text = "Vắng: 0";
            // 
            // lblKhac
            // 
            lblKhac.AutoSize = true;
            lblKhac.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblKhac.ForeColor = Color.Orange;
            lblKhac.Location = new Point(20, 574);
            lblKhac.Name = "lblKhac";
            lblKhac.Size = new Size(82, 24);
            lblKhac.TabIndex = 5;
            lblKhac.Text = "Khác: 0";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = Color.Transparent;
            btnPreviousPage.CustomizableEdges = customizableEdges3;
            btnPreviousPage.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnPreviousPage.ForeColor = Color.Black;
            btnPreviousPage.Location = new Point(1060, 474);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPreviousPage.Size = new Size(36, 33);
            btnPreviousPage.TabIndex = 6;
            btnPreviousPage.Text = "<";
            btnPreviousPage.Click += BtnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.Transparent;
            btnNextPage.CustomizableEdges = customizableEdges5;
            btnNextPage.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.Black;
            btnNextPage.Location = new Point(1111, 474);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnNextPage.Size = new Size(36, 33);
            btnNextPage.TabIndex = 7;
            btnNextPage.Text = ">";
            btnNextPage.Click += BtnNextPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblPageInfo.ForeColor = Color.Black;
            lblPageInfo.Location = new Point(545, 483);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(106, 24);
            lblPageInfo.TabIndex = 8;
            lblPageInfo.Text = "Trang: 1/1";
            // 
            // ChamCongNVForm
            // 
            ClientSize = new Size(1224, 642);
            Controls.Add(labelTitle);
            Controls.Add(guna2ComboBoxThang);
            Controls.Add(guna2DataGridViewChamCong);
            Controls.Add(lblDu);
            Controls.Add(lblVang);
            Controls.Add(lblKhac);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageInfo);
            Name = "ChamCongNVForm";
            Text = "Chấm công nhân viên";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridViewChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTitle;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxThang;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewChamCong;
        private Label lblDu;
        private Label lblVang;
        private Label lblKhac;
        private Guna.UI2.WinForms.Guna2Button btnPreviousPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private Label lblPageInfo;
    }
}
