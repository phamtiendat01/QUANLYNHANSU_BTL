using System;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.DTO;
using QUANLYNHANSU_BTL.BLL;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ChamCongPopup : Form
    {
        private readonly LoaiCongBLL loaiCongBLL = new LoaiCongBLL();
        private ChamCongBLL chamCongBLL = new ChamCongBLL();
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private bool laSua = false;
        private ChamCong duLieuChinhSua;

        public ChamCongPopup()
        {
            InitializeComponent();

        }

        public ChamCongPopup(ChamCong chamCong) : this()
        {
            laSua = true;
            duLieuChinhSua = chamCong;
            GanDuLieuLenForm(chamCong);
        }

        private void GanDuLieuLenForm(ChamCong cc)
        {
            txtMaNV.Text = cc.MaNV;
            txtHoTen.Text = nhanVienBLL.LayHoTen(cc.MaNV);
            dtpNgay.Value = cc.Ngay;
            cmbLoaiCong.SelectedItem = cc.MaLoaiCong + " - " + loaiCongBLL.LayTenLoaiCong(cc.MaLoaiCong);
            cmbTrangThai.SelectedItem = cc.TrangThai;
            timeGioVao.Value = DateTime.Today.Add(cc.GioVao);
            timeGioRa.Value = DateTime.Today.Add(cc.GioRa);
            txtSoGioTangCa.Text = cc.TangCa.ToString();
            txtGhiChu.Text = cc.GhiChu;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (cmbTrangThai.SelectedIndex == 0 || cmbLoaiCong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            ChamCong cc = new ChamCong
            {
                MaNV = txtMaNV.Text.Trim(),
                Ngay = dtpNgay.Value.Date,
                MaLoaiCong = cmbLoaiCong.SelectedItem.ToString().Split('-')[0].Trim(),
                TrangThai = cmbTrangThai.SelectedItem.ToString(),
                GioVao = timeGioVao.Value.TimeOfDay,
                GioRa = timeGioRa.Value.TimeOfDay,
                TangCa = int.TryParse(txtSoGioTangCa.Text.Trim(), out int tc) ? tc : 0,
                GhiChu = txtGhiChu.Text.Trim()
            };

            bool ketQua;
            if (laSua)
            {
                cc.MaCC = duLieuChinhSua.MaCC;
                ketQua = chamCongBLL.CapNhat(cc);
            }
            else
            {
                ketQua = chamCongBLL.Them(cc);
            }

            if (ketQua)
            {
                MessageBox.Show("Lưu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu!");
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            if (!string.IsNullOrEmpty(ma))
            {
                txtHoTen.Text = nhanVienBLL.LayHoTen(ma);
            }
        }
        private void ChamCongPopup_Load(object sender, EventArgs e)
        {
            // Đây là nơi để xử lý logic ban đầu khi form popup load
            // Ví dụ: load dữ liệu dropdown, hiển thị thông tin cần chỉnh sửa nếu là sửa

            if (duLieuChinhSua != null)
            {
                GanDuLieuLenForm(duLieuChinhSua);
            }

            // Load các loại công cho combobox
            var dsLoaiCong = loaiCongBLL.LayTatCa();
            foreach (var loai in dsLoaiCong)
            {
                cmbLoaiCong.Items.Add(loai.MaLoaiCong + " - " + loai.TenLoaiCong);
            }
        }


        private void cmbLoaiCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cmbLoaiCong.SelectedItem.ToString().Split('-')[0].Trim();
            switch (loai)
            {
                case "C": cmbTrangThai.SelectedItem = "Đúng giờ"; break;
                case "V": cmbTrangThai.SelectedItem = "Không phép"; break;
                case "P":
                case "L":
                case "TS":
                case "K":
                case "CT": cmbTrangThai.SelectedItem = "Có phép"; break;
                case "NP": cmbTrangThai.SelectedItem = "Không phép"; break;
                case "OT": cmbTrangThai.SelectedItem = "Đúng giờ"; break;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form popup
        }


        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}