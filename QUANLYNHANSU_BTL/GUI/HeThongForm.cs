﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class HeThongForm : Form
    {
        private readonly TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private List<TaiKhoanDTO> danhSachGoc = new List<TaiKhoanDTO>();
        private int pageSize = 10;
        private int currentPage = 1;

        public HeThongForm()
        {
            InitializeComponent();
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            danhSachGoc = taiKhoanBLL.GetAll();
            CapNhatDataGridView();
        }

        private void CapNhatDataGridView()
        {
            var dsHienThi = danhSachGoc
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvTaiKhoan.DataSource = dsHienThi;

            // Đặt lại thứ tự cột theo đúng trình tự trong cơ sở dữ liệu
            dgvTaiKhoan.Columns["MaNV"].DisplayIndex = 0;
            dgvTaiKhoan.Columns["TenDangNhap"].DisplayIndex = 1;
            dgvTaiKhoan.Columns["MatKhau"].DisplayIndex = 2;
            dgvTaiKhoan.Columns["HoTen"].DisplayIndex = 3;
            dgvTaiKhoan.Columns["VaiTro"].DisplayIndex = 4;
            dgvTaiKhoan.Columns["TrangThai"].DisplayIndex = 5;


            lblPage.Text = $"Trang {currentPage}/{Math.Ceiling((double)danhSachGoc.Count / pageSize)}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower().Trim();
            danhSachGoc = taiKhoanBLL.Search(keyword);

            currentPage = 1;
            CapNhatDataGridView();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                CapNhatDataGridView();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int maxPage = (int)Math.Ceiling((double)danhSachGoc.Count / pageSize);
            if (currentPage < maxPage)
            {
                currentPage++;
                CapNhatDataGridView();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            currentPage = 1;
            LoadTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var popup = new TaiKhoanPopupForm();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                taiKhoanBLL.Insert(popup.TaiKhoanDuocNhap);
                LoadTaiKhoan();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                var row = dgvTaiKhoan.SelectedRows[0];
                var tk = new TaiKhoanDTO
                {
                    TenDangNhap = row.Cells["TenDangNhap"].Value.ToString(),
                    MatKhau = row.Cells["MatKhau"].Value.ToString(),
                    HoTen = row.Cells["HoTen"].Value.ToString(),
                    VaiTro = row.Cells["VaiTro"].Value.ToString(),
                    TrangThai = (bool)row.Cells["TrangThai"].Value,
                    MaNV = row.Cells["MaNV"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["MaNV"].Value) : (int?)null
                };

                var popup = new TaiKhoanPopupForm( tk);
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    taiKhoanBLL.Update(popup.TaiKhoanDuocNhap);
                    LoadTaiKhoan();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var tenDangNhap = dgvTaiKhoan.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                    taiKhoanBLL.Delete(tenDangNhap);
                    LoadTaiKhoan();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HeThongForm_Load(object sender, EventArgs e)
        {

        }
    }
}