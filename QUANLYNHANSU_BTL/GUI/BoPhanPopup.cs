using System;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BoPhanPopup : Form
    {
        private BoPhanBLL boPhanBLL = new BoPhanBLL();
        private bool isEdit = false; // Kiểm tra chế độ thêm hay sửa
        private string maPB_Edit; // Lưu mã phòng ban khi sửa

        public BoPhanPopup()
        {
            InitializeComponent();
        }

        // Constructor cho chế độ sửa
        public BoPhanPopup(BoPhanDTO boPhan) : this()
        {
            isEdit = true;
            maPB_Edit = boPhan.MaPB;
            txtMaPB.Text = boPhan.MaPB;
            txtTenPB.Text = boPhan.TenPB;
            txtMaPB.ReadOnly = true; // Không cho phép sửa mã phòng ban
        }

        // ✅ Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text.Trim();
            string tenPB = txtTenPB.Text.Trim();

            if (string.IsNullOrEmpty(maPB) || string.IsNullOrEmpty(tenPB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BoPhanDTO boPhan = new BoPhanDTO { MaPB = maPB, TenPB = tenPB };

            if (isEdit)
            {
                boPhanBLL.CapNhatBoPhan(boPhan);
                MessageBox.Show("Cập nhật phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                boPhanBLL.ThemBoPhan(boPhan);
                MessageBox.Show("Thêm phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ✅ Nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoPhanPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
