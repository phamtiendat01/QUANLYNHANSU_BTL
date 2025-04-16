using System;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;

namespace QUANLYNHANSU_BTL.GUI
{
    public class BangLuongApp
    {
        [STAThread]
        static void Main()
        {
            // Kiểm tra tham số dòng lệnh
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && args[1] == "--calculate-salary")
            {
                // Nếu có tham số --calculate-salary, thực hiện tính lương
                AutoSalaryCalculation.CheckAndCalculateSalary();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
