using System;
using System.Windows.Forms;
using System.Timers;  // Đảm bảo bạn thêm thư viện này để sử dụng Timer
using QUANLYNHANSU_BTL.BLL;
namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongForm : Form
    {
        private System.Windows.Forms.Timer timer;

        public BangLuongForm()
        {
            InitializeComponent();
            InitializeTimer();  // Khởi tạo Timer khi Form được tạo
            this.Load += BangLuongForm_Load;
        }

        private void BangLuongForm_Load(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0; // Chỉ định chọn tab đầu tiên khi load form
            TabControl_SelectedIndexChanged(tabControl, EventArgs.Empty);

            // Thêm các thao tác khởi tạo khi Form được tải
        }

        // Hàm khởi tạo Timer
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();  // Sử dụng Timer của Windows Forms
            timer.Interval = 24 * 60 * 60 * 1000; // Kiểm tra mỗi ngày một lần (24 giờ)
            timer.Tick += TimerElapsed;  // Sử dụng Tick thay vì Elapsed cho System.Windows.Forms.Timer
            timer.Start();
        }

        // Khi Timer hết thời gian (1 ngày) sẽ kiểm tra và tính lương
        private void TimerElapsed(object sender, EventArgs e)
        {
            AutoSalaryCalculation.CheckAndCalculateSalary();  // Kiểm tra và tính lương nếu là ngày cuối tháng
        }


        // Nếu muốn dừng timer khi form bị đóng
        private void BangLuongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        // Sự kiện cần xử lý khi Tab đổi
        private void tabBangLuong_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabBangLuong_Click_1(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}

