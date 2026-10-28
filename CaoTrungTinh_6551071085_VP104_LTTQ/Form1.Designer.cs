namespace CaoTrungTinh_6551071085_VP104_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbThongTinNhanVien = new GroupBox();
            txtLuong = new TextBox();
            txtTen = new TextBox();
            txtMaNV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gpThaoTac = new GroupBox();
            gpChucNang = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btn_Thoat = new Button();
            btnThem = new Button();
            gpDanhSach = new GroupBox();
            dataGridView1 = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colten = new DataGridViewTextBoxColumn();
            colLuong = new DataGridViewTextBoxColumn();
            gbThongTinNhanVien.SuspendLayout();
            gpThaoTac.SuspendLayout();
            gpChucNang.SuspendLayout();
            gpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbThongTinNhanVien
            // 
            gbThongTinNhanVien.Controls.Add(txtLuong);
            gbThongTinNhanVien.Controls.Add(txtTen);
            gbThongTinNhanVien.Controls.Add(txtMaNV);
            gbThongTinNhanVien.Controls.Add(label3);
            gbThongTinNhanVien.Controls.Add(label2);
            gbThongTinNhanVien.Controls.Add(label1);
            gbThongTinNhanVien.Location = new Point(12, 12);
            gbThongTinNhanVien.Name = "gbThongTinNhanVien";
            gbThongTinNhanVien.Size = new Size(486, 141);
            gbThongTinNhanVien.TabIndex = 0;
            gbThongTinNhanVien.TabStop = false;
            gbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(149, 105);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(305, 27);
            txtLuong.TabIndex = 5;
            txtLuong.KeyPress += txtLuong_KeyPress;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(149, 70);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(305, 27);
            txtTen.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(149, 37);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(305, 27);
            txtMaNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 108);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Lương Cơ bản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            // 
            // gpThaoTac
            // 
            gpThaoTac.Controls.Add(gpChucNang);
            gpThaoTac.Location = new Point(504, 12);
            gpThaoTac.Name = "gpThaoTac";
            gpThaoTac.Size = new Size(284, 141);
            gpThaoTac.TabIndex = 1;
            gpThaoTac.TabStop = false;
            gpThaoTac.Text = "Thao Tác";
            // 
            // gpChucNang
            // 
            gpChucNang.Controls.Add(btnXoa);
            gpChucNang.Controls.Add(btnSua);
            gpChucNang.Controls.Add(btn_Thoat);
            gpChucNang.Controls.Add(btnThem);
            gpChucNang.Location = new Point(6, 26);
            gpChucNang.Name = "gpChucNang";
            gpChucNang.Size = new Size(272, 109);
            gpChucNang.TabIndex = 0;
            gpChucNang.TabStop = false;
            gpChucNang.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(138, 61);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(28, 61);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(138, 26);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 1;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(28, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // gpDanhSach
            // 
            gpDanhSach.Controls.Add(dataGridView1);
            gpDanhSach.Location = new Point(12, 159);
            gpDanhSach.Name = "gpDanhSach";
            gpDanhSach.Size = new Size(776, 279);
            gpDanhSach.TabIndex = 2;
            gpDanhSach.TabStop = false;
            gpDanhSach.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMa, colten, colLuong });
            dataGridView1.Location = new Point(10, 24);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(762, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colMa
            // 
            colMa.DataPropertyName = "MaNhanVien";
            colMa.HeaderText = "Mã Nhân Viên";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            colMa.Width = 200;
            // 
            // colten
            // 
            colten.DataPropertyName = "TenNhanVien";
            colten.HeaderText = "Tên Nhân Viên";
            colten.MinimumWidth = 6;
            colten.Name = "colten";
            colten.Width = 200;
            // 
            // colLuong
            // 
            colLuong.DataPropertyName = "LuongCoBan";
            colLuong.HeaderText = "Lương Cơ Bản";
            colLuong.MinimumWidth = 6;
            colLuong.Name = "colLuong";
            colLuong.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpDanhSach);
            Controls.Add(gpThaoTac);
            Controls.Add(gbThongTinNhanVien);
            Name = "Form1";
            Text = "Quản lý Nhân Viên / Nhân sự - VP104";
            Load += Form1_Load;
            gbThongTinNhanVien.ResumeLayout(false);
            gbThongTinNhanVien.PerformLayout();
            gpThaoTac.ResumeLayout(false);
            gpChucNang.ResumeLayout(false);
            gpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTinNhanVien;
        private GroupBox gpThaoTac;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtLuong;
        private TextBox txtTen;
        private TextBox txtMaNV;
        private GroupBox gpChucNang;
        private Button btnThem;
        private Button btn_Thoat;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox gpDanhSach;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colten;
        private DataGridViewTextBoxColumn colLuong;
    }
}
