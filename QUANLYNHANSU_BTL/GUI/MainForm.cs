using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class MainForm : Form
    {
        private Button selectedButton = null; // Lưu button được chọn

        public MainForm()
        {
            InitializeComponent();
            InitializeSidebarButtons();
            this.Load += MainForm_Load;

        }

        private void InitializeSidebarButtons()
        {
            int yPosition = 100;

            btnTrangChu = CreateSidebarButton("Trang chủ", "btnTrangChu", yPosition);
            btnNhanVien = CreateSidebarButton("Nhân viên", "btnNhanVien", yPosition += 50);
            btnBoPhan = CreateSidebarButton("Bộ phận", "btnBoPhan", yPosition += 50);
            btnChamCong = CreateSidebarButton("Chấm công", "btnChamCong", yPosition += 50);
            btnBangLuong = CreateSidebarButton("Bảng lương", "btnBangLuong", yPosition += 50);
            btnBaoCao = CreateSidebarButton("Báo cáo", "btnBaoCao", yPosition += 50);
            btnHeThong = CreateSidebarButton("Hệ thống", "btnHeThong", yPosition += 50);

            pnlSidebar.Controls.AddRange(new Button[]
            {
                btnTrangChu, btnNhanVien, btnBoPhan, btnChamCong, btnBangLuong, btnBaoCao, btnHeThong
            });
        }

        private RoundedButton CreateSidebarButton(string text, string name, int y)
        {
            RoundedButton button = new RoundedButton();
            button.Text = text;
            button.Name = name;
            button.Size = new Size(180, 40);
            button.Location = new Point(20, y);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; // Không viền
            button.BackColor = Color.LightBlue; // Màu nền
            button.ForeColor = Color.Black; // Màu chữ
            button.Font = new Font("Arial", 10, FontStyle.Bold); // Chữ đậm
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(10, 0, 0, 0);
            button.BorderRadius = 15; // Điều chỉnh độ bo tròn
            button.TabStop = false; // Tắt khả năng focus


            button.Click += SidebarButton_Click;
            return button;
        }


        private void SidebarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Reset màu nút trước đó
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(180, 225, 255);
            }

            // Đổi màu khi click
            clickedButton.BackColor = Color.FromArgb(120, 180, 255);
            selectedButton = clickedButton;

            switch (clickedButton.Name)
            {
                case "btnTrangChu":
                    ShowHomePage();
                    break;
                case "btnNhanVien":
                    ShowForm(new NhanVienForm());
                    break;
                case "btnBoPhan":
                    ShowForm(new BoPhanForm());
                    break;
                case "btnChamCong":
                    ShowForm(new ChamCongForm());
                    break;
                case "btnBangLuong":
                    ShowForm(new BangLuongForm());
                    break;
                case "btnBaoCao":
                    ShowForm(new BaoCaoForm());
                    break;
                case "btnHeThong":
                    ShowForm(new HeThongForm());
                    break;
            }
        }

        private void ShowHomePage()
        {
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(pbBackground);
            pbBackground.Visible = true;
        }

        private void ShowForm(Form form)
        {
            pnlMainContent.Controls.Clear();
            pbBackground.Visible = false;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(form);
            form.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 1000; // Cập nhật mỗi giây
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            UpdateTimeDisplay(); // Cập nhật lần đầu
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            var now = DateTime.Now;
            var weekday = now.ToString("dddd"); // Thứ
            var date = now.ToString("dd/MM/yyyy");
            var time = now.ToString("HH:mm:ss");

            lblTime.Text = $"{weekday}, {date} - {time}";
        }
        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn MainForm tạm thời

            LoginForm loginForm = new LoginForm();
            var result = loginForm.ShowDialog(); // Giữ chương trình chạy ở đây

            if (result == DialogResult.OK)
            {
                this.Show(); // Nếu đăng nhập lại, hiện lại MainForm
            }
            else
            {
                this.Close(); // Nếu người dùng tắt form đăng nhập
            }
        }



        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
