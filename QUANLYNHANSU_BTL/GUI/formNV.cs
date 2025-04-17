using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class formNV : Form
    {
        private Button selectedButton = null; // Lưu button được chọn
        private NhanVienDTO nv; // Đối tượng lưu thông tin tài khoản



        public formNV(NhanVienDTO nv)
        {
            InitializeComponent();
            InitializeSidebarButtons();
            this.Load += formNV_Load;
            this.nv = nv; // Lưu thông tin tài khoản vào biến tk


        }



        private void InitializeSidebarButtons()
        {
            int yPosition = 100;

            // Cập nhật lại các button trong sidebar
            btnTrangChu = CreateSidebarButton("Trang chủ", "btnTrangChu", yPosition);
            btnThongTin = CreateSidebarButton("Thông tin", "btnThongTin", yPosition += 50);
            btnChamCong = CreateSidebarButton("Chấm công", "btnChamCong", yPosition += 50);
            btnBangLuong = CreateSidebarButton("Bảng lương", "btnBangLuong", yPosition += 50);
            btnHeThong = CreateSidebarButton("Hệ thống", "btnHeThong", yPosition += 50);

            pnlSidebar.Controls.AddRange(new Button[]
            {
                btnTrangChu, btnThongTin, btnChamCong, btnBangLuong, btnHeThong
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
                case "btnThongTin":
                   
                    ShowForm( new ThongTinNVForm(nv)); // Hiển thị form Thông tin nhân viên
                    break;
                case "btnChamCong":
                    ShowForm(new ChamCongNVForm(nv.MaNV)); // Form chấm công
                    break;
                case "btnBangLuong":
                    ShowForm(new BangLuongNVForm(nv.MaNV)); // Form bảng lương
                    break;
                case "btnHeThong":
                    ShowForm(new HeThongNVForm()); // Form hệ thống
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
            pnlMainContent.Controls.Clear(); // Xóa nội dung hiện tại trong panel
            pbBackground.Visible = false;   // Ẩn background (nếu có)

            form.TopLevel = false;          // Đảm bảo form là child form
            form.FormBorderStyle = FormBorderStyle.None; // Không có border
            form.Dock = DockStyle.Fill;     // Điền đầy panel
            pnlMainContent.Controls.Add(form);
            form.Show(); // Hiển thị form
        }


        private void formNV_Load(object sender, EventArgs e)
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
            this.Hide(); // Ẩn formNV tạm thời

            LoginForm loginForm = new LoginForm();
            var result = loginForm.ShowDialog(); // Giữ chương trình chạy ở đây

            if (result == DialogResult.OK)
            {
                this.Show(); // Nếu đăng nhập lại, hiện lại formNV
            }
            else
            {
                this.Close(); // Nếu người dùng tắt form đăng nhập
            }
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e) { }

        private void pbBackground_Click(object sender, EventArgs e) { }
    }
}
