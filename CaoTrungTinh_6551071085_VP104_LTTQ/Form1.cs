using System.Globalization;
using CaoTrungTinh_6551071085_VP104_LTTQ.Models;
using Microsoft.EntityFrameworkCore;

namespace CaoTrungTinh_6551071085_VP104_LTTQ
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=DuLieu_NhanSu;Trusted_Connection=True;TrustServerCertificate=True";

        private bool dangTaiDuLieu;

        public Form1()
        {
            InitializeComponent();
        }

        private static DuLieu_NhanSuContext TaoContext()
        {
            var options = new DbContextOptionsBuilder<DuLieu_NhanSuContext>()
                .UseSqlServer(ConnectionString).Options;
            return new DuLieu_NhanSuContext(options);
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            TaiDanhSach();
            LamMoiNhapLieu();
        }

        private void TaiDanhSach()
        {
            try
            {
                dangTaiDuLieu = true;

                using var db = TaoContext();
                var danhSach = db.NhanViens
                    .AsNoTracking()
                    .OrderBy(nv => nv.MaNhanVien)
                    .ToList();
                dataGridView1.DataSource = danhSach;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không đọc được dữ liệu từ CSDL DuLieu_NhanSu.\n\n" + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        // làm mới 
        private void LamMoiNhapLieu()
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Clear();
            txtTen.Clear();
            txtLuong.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dangTaiDuLieu = true;
            dataGridView1.ClearSelection();
            dangTaiDuLieu = false;
            txtMaNV.Focus();
        }
       // Lương
        private void txtLuong_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;           
            if (char.IsDigit(e.KeyChar)) return;               
            if (e.KeyChar is ',' or '.') return;
            e.Handled = true;
        }
        // bảng
        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dangTaiDuLieu) return;
            if (dataGridView1.SelectedRows.Count != 1) return;
            if (dataGridView1.SelectedRows[0].DataBoundItem is not NhanVien nhanVien) return;
            txtMaNV.Text = nhanVien.MaNhanVien;
            txtTen.Text = nhanVien.TenNhanVien;
            txtLuong.Text = nhanVien.LuongCoBan;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        // kiểm tra
        private bool KiemTraNhap(string ma, string ten, out string luongChuanHoa)
        {
            luongChuanHoa = string.Empty;

            if (ma.Length == 0)
            {
                MessageBox.Show("Vui long nhập nhân viênn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }

            if (ma.Length > 10)
            {
                MessageBox.Show("Mã nhân viên max là 10 kí tự.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }

            if (ten.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nv.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }

            if (!ThuLayLuong(txtLuong.Text, out long luong))
            {
                MessageBox.Show("Lương cơ bản phải là > 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return false;
            }

            luongChuanHoa = luong.ToString("#,##0", CultureInfo.InvariantCulture);

            if (luongChuanHoa.Length > 12)
            {
                MessageBox.Show("Lương cơ bản max 12 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return false;
            }
            return true;
        }

        private static bool ThuLayLuong(string text, out long luong)
        {
            luong = 0;
            string chuSo = new string(text.Where(char.IsDigit).ToArray());
            if (chuSo.Length == 0) return false;
            return long.TryParse(chuSo, out luong) && luong > 0;
        }
        // thêm
        private void btnThem_Click(object? sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            string ten = txtTen.Text.Trim();
            if (!KiemTraNhap(ma, ten, out string luong)) return;
                using var db = TaoContext();

                if (db.NhanViens.Any(nv => nv.MaNhanVien == ma))
                {
                    MessageBox.Show($"Mã nhân viên này đã tồn tại.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNV.Focus();
                    return;
                }

                db.NhanViens.Add(new NhanVien
                {
                    MaNhanVien = ma,
                    TenNhanVien = ten,
                    LuongCoBan = luong
                });
                db.SaveChanges();
                TaiDanhSach();
                LamMoiNhapLieu();
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
         
        }
        // sửa
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1 ||
                dataGridView1.SelectedRows[0].DataBoundItem is not NhanVien dangChon)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trên danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maCu = dangChon.MaNhanVien;
            string maMoi = txtMaNV.Text.Trim();
            string ten = txtTen.Text.Trim();

            if (!KiemTraNhap(maMoi, ten, out string luong)) return;
            if (maMoi != maCu)
            {
                MessageBox.Show("Bị Trùng với nhânn viên cũ rùi",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            
                using var db = TaoContext();

                var nhanVien = db.NhanViens.Find(maCu);
                if (nhanVien == null)
                {
                    MessageBox.Show("Nhân viên đã bị bạn thay đổi rồi",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TaiDanhSach();
                    LamMoiNhapLieu();
                    return;
                }
                nhanVien.TenNhanVien = ten;
                nhanVien.LuongCoBan = luong;
                db.SaveChanges();
                TaiDanhSach();
                LamMoiNhapLieu();
                MessageBox.Show("Cập nhật nhân viênn thành công.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
        //xóa
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1 ||
                dataGridView1.SelectedRows[0].DataBoundItem is not NhanVien dangChon)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa trên danh sách.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var traLoi = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhân viên này không: \"{dangChon.TenNhanVien}\" ({dangChon.MaNhanVien})?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (traLoi != DialogResult.Yes) return;

            
                using var db = TaoContext();

                var nhanVien = db.NhanViens.Find(dangChon.MaNhanVien);
                if (nhanVien == null)
                {
                    MessageBox.Show("Bạn đã xóa nhân viên này rồi!.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TaiDanhSach();
                    LamMoiNhapLieu(); return;
                }
                db.NhanViens.Remove(nhanVien);
                db.SaveChanges();
                TaiDanhSach();
                LamMoiNhapLieu();
                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // thoát
        private void btn_Thoat_Click(object? sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Bạn có chắc muốn out?",
                "Xác nhận out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traLoi == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
