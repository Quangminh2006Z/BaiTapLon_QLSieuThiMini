namespace BaiTapLon_QLSieuThiMini
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
<<<<<<< Updated upstream
=======
            lblTongTien_tab2 = new Label();
            lblSoLuongHoaDon_tab2 = new Label();
            label10 = new Label();
            dgvGioHang_tab2 = new DataGridView();
            colMaSP_tab2 = new DataGridViewTextBoxColumn();
            colTenSanPham_tab2 = new DataGridViewTextBoxColumn();
            colSoLuong_tab2 = new DataGridViewTextBoxColumn();
            colDonGia_tab2 = new DataGridViewTextBoxColumn();
            colThanhTien_tab2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblSanPham = new Label();
            label9 = new Label();
            cboSanPham_tab2 = new ComboBox();
            txtSoLuongMua_tab2 = new TextBox();
            btnThanhToan_tab2 = new Button();
            btnThemSanPham_tab2 = new Button();
>>>>>>> Stashed changes
            tabNhapHang = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableKhoHang = new DataGridView();
            ColumnMaSP = new DataGridViewTextBoxColumn();
            ColumnTenSP = new DataGridViewTextBoxColumn();
            ColumnForSoLuong = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            tableLichSuNhap = new DataGridView();
            CollumnForMaSP = new DataGridViewTextBoxColumn();
            CollumnForTenSP = new DataGridViewTextBoxColumn();
            CollumnForThanhTien = new DataGridViewTextBoxColumn();
            CollumnForNgay = new DataGridViewTextBoxColumn();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxForDonGia = new TextBox();
            textBoxForTenSP = new TextBox();
            textBoxForSoLuong = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxForMaSP = new TextBox();
            buttonAdd = new Button();
            tabControl1.SuspendLayout();
            tabNhapHang.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableKhoHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableLichSuNhap).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabNhapHang);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
<<<<<<< Updated upstream
            tabControl1.Size = new Size(1315, 723);
=======
            tabControl1.Size = new Size(1328, 740);
>>>>>>> Stashed changes
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
<<<<<<< Updated upstream
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1307, 690);
=======
            tabPage1.Controls.Add(dgvSanPhamDuocBan_tab1);
            tabPage1.Controls.Add(btnXoa_tab1);
            tabPage1.Controls.Add(btnThem_tab1);
            tabPage1.Controls.Add(btnSua_tab1);
            tabPage1.Controls.Add(btnTim_tab1);
            tabPage1.Controls.Add(txtTim_tab1);
            tabPage1.Controls.Add(tableLayoutPanel4);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1320, 702);
>>>>>>> Stashed changes
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1307, 690);
=======
            tabPage1.Click += tabPage1_Click;
            // 
            // dgvSanPhamDuocBan_tab1
            // 
            dgvSanPhamDuocBan_tab1.AllowUserToAddRows = false;
            dgvSanPhamDuocBan_tab1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPhamDuocBan_tab1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPhamDuocBan_tab1.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen_tab1, colGia_tab1, colSoLuongBan_tab1 });
            dgvSanPhamDuocBan_tab1.Dock = DockStyle.Bottom;
            dgvSanPhamDuocBan_tab1.Location = new Point(4, 312);
            dgvSanPhamDuocBan_tab1.Margin = new Padding(4);
            dgvSanPhamDuocBan_tab1.Name = "dgvSanPhamDuocBan_tab1";
            dgvSanPhamDuocBan_tab1.ReadOnly = true;
            dgvSanPhamDuocBan_tab1.RowHeadersWidth = 51;
            dgvSanPhamDuocBan_tab1.Size = new Size(1312, 386);
            dgvSanPhamDuocBan_tab1.TabIndex = 28;
            dgvSanPhamDuocBan_tab1.CellClick += dgvSanPhamDuocBan_tab1_CellClick;
            dgvSanPhamDuocBan_tab1.CellContentClick += dgvSanPhamDuocBan_tab1_CellContentClick_1;
            // 
            // colMa
            // 
            colMa.HeaderText = "Mã sản phẩm";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            colMa.ReadOnly = true;
            // 
            // colTen_tab1
            // 
            colTen_tab1.HeaderText = "Tên sản phẩm";
            colTen_tab1.MinimumWidth = 6;
            colTen_tab1.Name = "colTen_tab1";
            colTen_tab1.ReadOnly = true;
            // 
            // colGia_tab1
            // 
            colGia_tab1.HeaderText = "Giá";
            colGia_tab1.MinimumWidth = 6;
            colGia_tab1.Name = "colGia_tab1";
            colGia_tab1.ReadOnly = true;
            // 
            // colSoLuongBan_tab1
            // 
            colSoLuongBan_tab1.HeaderText = "Số lượng bán";
            colSoLuongBan_tab1.MinimumWidth = 6;
            colSoLuongBan_tab1.Name = "colSoLuongBan_tab1";
            colSoLuongBan_tab1.ReadOnly = true;
            // 
            // btnXoa_tab1
            // 
            btnXoa_tab1.Anchor = AnchorStyles.Right;
            btnXoa_tab1.Font = new Font("Segoe UI", 10F);
            btnXoa_tab1.Location = new Point(1129, 132);
            btnXoa_tab1.Margin = new Padding(4);
            btnXoa_tab1.Name = "btnXoa_tab1";
            btnXoa_tab1.Size = new Size(179, 94);
            btnXoa_tab1.TabIndex = 24;
            btnXoa_tab1.TabStop = false;
            btnXoa_tab1.Text = "Xóa";
            btnXoa_tab1.UseVisualStyleBackColor = true;
            btnXoa_tab1.Click += btnXoa_tab1_Click;
            // 
            // btnThem_tab1
            // 
            btnThem_tab1.Anchor = AnchorStyles.Right;
            btnThem_tab1.Font = new Font("Segoe UI", 10F);
            btnThem_tab1.Location = new Point(746, 132);
            btnThem_tab1.Margin = new Padding(4);
            btnThem_tab1.Name = "btnThem_tab1";
            btnThem_tab1.Size = new Size(171, 94);
            btnThem_tab1.TabIndex = 22;
            btnThem_tab1.TabStop = false;
            btnThem_tab1.Text = "Thêm";
            btnThem_tab1.UseVisualStyleBackColor = true;
            btnThem_tab1.Click += btnThem_tab1_Click_1;
            // 
            // btnSua_tab1
            // 
            btnSua_tab1.Anchor = AnchorStyles.Right;
            btnSua_tab1.Font = new Font("Segoe UI", 10F);
            btnSua_tab1.Location = new Point(935, 132);
            btnSua_tab1.Margin = new Padding(4);
            btnSua_tab1.Name = "btnSua_tab1";
            btnSua_tab1.Size = new Size(186, 94);
            btnSua_tab1.TabIndex = 23;
            btnSua_tab1.TabStop = false;
            btnSua_tab1.Text = "Sửa";
            btnSua_tab1.UseVisualStyleBackColor = true;
            btnSua_tab1.Click += btnSua_Click;
            // 
            // btnTim_tab1
            // 
            btnTim_tab1.Anchor = AnchorStyles.Left;
            btnTim_tab1.Location = new Point(1175, 39);
            btnTim_tab1.Margin = new Padding(4);
            btnTim_tab1.Name = "btnTim_tab1";
            btnTim_tab1.Size = new Size(112, 42);
            btnTim_tab1.TabIndex = 26;
            btnTim_tab1.Text = "Tìm";
            btnTim_tab1.UseVisualStyleBackColor = true;
            btnTim_tab1.Click += btnTim_tab1_Click;
            // 
            // txtTim_tab1
            // 
            txtTim_tab1.Anchor = AnchorStyles.Left;
            txtTim_tab1.Location = new Point(746, 46);
            txtTim_tab1.Margin = new Padding(4);
            txtTim_tab1.Name = "txtTim_tab1";
            txtTim_tab1.PlaceholderText = "Tìm kiếm";
            txtTim_tab1.Size = new Size(379, 31);
            txtTim_tab1.TabIndex = 25;
            txtTim_tab1.TextChanged += txtTim_tab1_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.11928F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.88072F));
            tableLayoutPanel4.Controls.Add(cbSanPham, 1, 0);
            tableLayoutPanel4.Controls.Add(txtGia_tab1, 1, 1);
            tableLayoutPanel4.Controls.Add(txt_TenSanPhamtab1, 0, 0);
            tableLayoutPanel4.Controls.Add(soluong, 0, 1);
            tableLayoutPanel4.Controls.Add(label11, 0, 2);
            tableLayoutPanel4.Controls.Add(slban, 1, 2);
            tableLayoutPanel4.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel4.Location = new Point(4, 4);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.Size = new Size(720, 222);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // cbSanPham
            // 
            cbSanPham.Dock = DockStyle.Top;
            cbSanPham.FormattingEnabled = true;
            cbSanPham.Location = new Point(249, 4);
            cbSanPham.Margin = new Padding(4);
            cbSanPham.Name = "cbSanPham";
            cbSanPham.Size = new Size(467, 40);
            cbSanPham.TabIndex = 36;
            // 
            // txtGia_tab1
            // 
            txtGia_tab1.Dock = DockStyle.Top;
            txtGia_tab1.Location = new Point(249, 77);
            txtGia_tab1.Margin = new Padding(4);
            txtGia_tab1.Name = "txtGia_tab1";
            txtGia_tab1.Size = new Size(467, 39);
            txtGia_tab1.TabIndex = 1;
            // 
            // txt_TenSanPhamtab1
            // 
            txt_TenSanPhamtab1.AutoSize = true;
            txt_TenSanPhamtab1.Dock = DockStyle.Left;
            txt_TenSanPhamtab1.Font = new Font("Segoe UI", 12F);
            txt_TenSanPhamtab1.Location = new Point(4, 0);
            txt_TenSanPhamtab1.Margin = new Padding(4, 0, 4, 0);
            txt_TenSanPhamtab1.Name = "txt_TenSanPhamtab1";
            txt_TenSanPhamtab1.Size = new Size(163, 73);
            txt_TenSanPhamtab1.TabIndex = 31;
            txt_TenSanPhamtab1.Text = "Tên sản phẩm";
            // 
            // soluong
            // 
            soluong.AutoSize = true;
            soluong.Dock = DockStyle.Left;
            soluong.Font = new Font("Segoe UI", 12F);
            soluong.Location = new Point(4, 73);
            soluong.Margin = new Padding(4, 0, 4, 0);
            soluong.Name = "soluong";
            soluong.Size = new Size(48, 73);
            soluong.TabIndex = 10;
            soluong.Text = "Giá";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.Location = new Point(4, 146);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(157, 76);
            label11.TabIndex = 30;
            label11.Text = "Số lượng bán";
            // 
            // slban
            // 
            slban.Dock = DockStyle.Top;
            slban.Location = new Point(249, 150);
            slban.Margin = new Padding(4);
            slban.Name = "slban";
            slban.Size = new Size(467, 39);
            slban.TabIndex = 33;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblTongTien_tab2);
            tabPage2.Controls.Add(lblSoLuongHoaDon_tab2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(dgvGioHang_tab2);
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1320, 702);
>>>>>>> Stashed changes
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
<<<<<<< Updated upstream
=======
            // lblTongTien_tab2
            // 
            lblTongTien_tab2.AutoSize = true;
            lblTongTien_tab2.Location = new Point(801, 248);
            lblTongTien_tab2.Name = "lblTongTien_tab2";
            lblTongTien_tab2.Size = new Size(148, 25);
            lblTongTien_tab2.TabIndex = 5;
            lblTongTien_tab2.Text = "Tổng tiền: 0 VNĐ";
            // 
            // lblSoLuongHoaDon_tab2
            // 
            lblSoLuongHoaDon_tab2.AutoSize = true;
            lblSoLuongHoaDon_tab2.Location = new Point(441, 248);
            lblSoLuongHoaDon_tab2.Name = "lblSoLuongHoaDon_tab2";
            lblSoLuongHoaDon_tab2.Size = new Size(176, 25);
            lblSoLuongHoaDon_tab2.TabIndex = 4;
            lblSoLuongHoaDon_tab2.Text = "Số lượng hóa đơn: 0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 248);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 3;
            label10.Text = "Giỏ hàng";
            // 
            // dgvGioHang_tab2
            // 
            dgvGioHang_tab2.AllowUserToAddRows = false;
            dgvGioHang_tab2.AllowUserToDeleteRows = false;
            dgvGioHang_tab2.AllowUserToOrderColumns = true;
            dgvGioHang_tab2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGioHang_tab2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang_tab2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang_tab2.Columns.AddRange(new DataGridViewColumn[] { colMaSP_tab2, colTenSanPham_tab2, colSoLuong_tab2, colDonGia_tab2, colThanhTien_tab2 });
            dgvGioHang_tab2.Location = new Point(4, 304);
            dgvGioHang_tab2.Margin = new Padding(2);
            dgvGioHang_tab2.Name = "dgvGioHang_tab2";
            dgvGioHang_tab2.RowHeadersWidth = 62;
            dgvGioHang_tab2.Size = new Size(1308, 386);
            dgvGioHang_tab2.TabIndex = 2;
            // 
            // colMaSP_tab2
            // 
            colMaSP_tab2.HeaderText = "Mã SP";
            colMaSP_tab2.MinimumWidth = 8;
            colMaSP_tab2.Name = "colMaSP_tab2";
            // 
            // colTenSanPham_tab2
            // 
            colTenSanPham_tab2.HeaderText = "Tên sản phẩm";
            colTenSanPham_tab2.MinimumWidth = 8;
            colTenSanPham_tab2.Name = "colTenSanPham_tab2";
            // 
            // colSoLuong_tab2
            // 
            colSoLuong_tab2.HeaderText = "Số lượng";
            colSoLuong_tab2.MinimumWidth = 8;
            colSoLuong_tab2.Name = "colSoLuong_tab2";
            // 
            // colDonGia_tab2
            // 
            colDonGia_tab2.HeaderText = "Đơn giá";
            colDonGia_tab2.MinimumWidth = 8;
            colDonGia_tab2.Name = "colDonGia_tab2";
            // 
            // colThanhTien_tab2
            // 
            colThanhTien_tab2.HeaderText = "Thành tiền";
            colThanhTien_tab2.MinimumWidth = 8;
            colThanhTien_tab2.Name = "colThanhTien_tab2";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5658913F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.4237976F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2339039F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6811466F));
            tableLayoutPanel3.Controls.Add(lblSanPham, 0, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 1);
            tableLayoutPanel3.Controls.Add(cboSanPham_tab2, 1, 0);
            tableLayoutPanel3.Controls.Add(txtSoLuongMua_tab2, 1, 1);
            tableLayoutPanel3.Controls.Add(btnThanhToan_tab2, 3, 1);
            tableLayoutPanel3.Controls.Add(btnThemSanPham_tab2, 3, 0);
            tableLayoutPanel3.Location = new Point(8, 22);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1228, 199);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Dock = DockStyle.Fill;
            lblSanPham.Font = new Font("Segoe UI", 12F);
            lblSanPham.Location = new Point(2, 0);
            lblSanPham.Margin = new Padding(2, 0, 2, 0);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(285, 99);
            lblSanPham.TabIndex = 0;
            lblSanPham.Text = "Sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(2, 99);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(285, 100);
            label9.TabIndex = 1;
            label9.Text = "Số lượng mua";
            // 
            // cboSanPham_tab2
            // 
            cboSanPham_tab2.Dock = DockStyle.Fill;
            cboSanPham_tab2.FormattingEnabled = true;
            cboSanPham_tab2.Location = new Point(291, 2);
            cboSanPham_tab2.Margin = new Padding(2);
            cboSanPham_tab2.Name = "cboSanPham_tab2";
            cboSanPham_tab2.Size = new Size(492, 33);
            cboSanPham_tab2.TabIndex = 2;
            cboSanPham_tab2.SelectedIndexChanged += cboSanPham_tab2_SelectedIndexChanged;
            // 
            // txtSoLuongMua_tab2
            // 
            txtSoLuongMua_tab2.Dock = DockStyle.Fill;
            txtSoLuongMua_tab2.Location = new Point(291, 101);
            txtSoLuongMua_tab2.Margin = new Padding(2);
            txtSoLuongMua_tab2.Name = "txtSoLuongMua_tab2";
            txtSoLuongMua_tab2.Size = new Size(492, 31);
            txtSoLuongMua_tab2.TabIndex = 3;
            // 
            // btnThanhToan_tab2
            // 
            btnThanhToan_tab2.Dock = DockStyle.Fill;
            btnThanhToan_tab2.Location = new Point(1023, 101);
            btnThanhToan_tab2.Margin = new Padding(2);
            btnThanhToan_tab2.Name = "btnThanhToan_tab2";
            btnThanhToan_tab2.Size = new Size(203, 96);
            btnThanhToan_tab2.TabIndex = 1;
            btnThanhToan_tab2.Text = "Thanh toán";
            btnThanhToan_tab2.UseVisualStyleBackColor = true;
            btnThanhToan_tab2.Click += btnThanhToan_tab2_Click;
            // 
            // btnThemSanPham_tab2
            // 
            btnThemSanPham_tab2.Dock = DockStyle.Fill;
            btnThemSanPham_tab2.Location = new Point(1023, 2);
            btnThemSanPham_tab2.Margin = new Padding(2);
            btnThemSanPham_tab2.Name = "btnThemSanPham_tab2";
            btnThemSanPham_tab2.Size = new Size(203, 95);
            btnThemSanPham_tab2.TabIndex = 3;
            btnThemSanPham_tab2.Text = "Thêm sản phẩm";
            btnThemSanPham_tab2.UseVisualStyleBackColor = true;
            btnThemSanPham_tab2.Click += btnThemSanPham_tab2_Click;
            // 
>>>>>>> Stashed changes
            // tabNhapHang
            // 
            tabNhapHang.AutoScroll = true;
            tabNhapHang.BackColor = Color.LightGray;
            tabNhapHang.Controls.Add(tableLayoutPanel2);
            tabNhapHang.Controls.Add(label5);
            tabNhapHang.Controls.Add(tableLayoutPanel1);
            tabNhapHang.Location = new Point(4, 34);
            tabNhapHang.Margin = new Padding(4);
            tabNhapHang.Name = "tabNhapHang";
<<<<<<< Updated upstream
            tabNhapHang.Padding = new Padding(3);
            tabNhapHang.Size = new Size(1307, 690);
=======
            tabNhapHang.Padding = new Padding(4);
            tabNhapHang.Size = new Size(1320, 702);
>>>>>>> Stashed changes
            tabNhapHang.TabIndex = 2;
            tabNhapHang.Text = "Nhập hàng & thống kê";
            tabNhapHang.Click += tabPage3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableKhoHang, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLichSuNhap, 0, 3);
            tableLayoutPanel2.Location = new Point(14, 279);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
<<<<<<< Updated upstream
            tableLayoutPanel2.Size = new Size(1290, 433);
=======
            tableLayoutPanel2.Size = new Size(1295, 378);
>>>>>>> Stashed changes
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableKhoHang
            // 
            tableKhoHang.AllowUserToAddRows = false;
            tableKhoHang.AllowUserToDeleteRows = false;
            tableKhoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableKhoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableKhoHang.Columns.AddRange(new DataGridViewColumn[] { ColumnMaSP, ColumnTenSP, ColumnForSoLuong });
            tableKhoHang.Dock = DockStyle.Fill;
            tableKhoHang.GridColor = SystemColors.HighlightText;
<<<<<<< Updated upstream
            tableKhoHang.Location = new Point(3, 46);
            tableKhoHang.Name = "tableKhoHang";
            tableKhoHang.ReadOnly = true;
            tableKhoHang.RowHeadersWidth = 51;
            tableKhoHang.Size = new Size(1284, 167);
=======
            tableKhoHang.Location = new Point(4, 41);
            tableKhoHang.Margin = new Padding(4);
            tableKhoHang.Name = "tableKhoHang";
            tableKhoHang.ReadOnly = true;
            tableKhoHang.RowHeadersWidth = 51;
            tableKhoHang.Size = new Size(1287, 143);
>>>>>>> Stashed changes
            tableKhoHang.TabIndex = 9;
            tableKhoHang.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnMaSP
            // 
            ColumnMaSP.HeaderText = "Mã sản phẩm";
            ColumnMaSP.MinimumWidth = 6;
            ColumnMaSP.Name = "ColumnMaSP";
            ColumnMaSP.ReadOnly = true;
            // 
            // ColumnTenSP
            // 
            ColumnTenSP.HeaderText = "Tên sản phẩm";
            ColumnTenSP.MinimumWidth = 6;
            ColumnTenSP.Name = "ColumnTenSP";
            ColumnTenSP.ReadOnly = true;
            // 
            // ColumnForSoLuong
            // 
            ColumnForSoLuong.HeaderText = "Số lượng tồn";
            ColumnForSoLuong.MinimumWidth = 6;
            ColumnForSoLuong.Name = "ColumnForSoLuong";
            ColumnForSoLuong.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            label6.Location = new Point(3, 15);
            label6.Name = "label6";
            label6.Size = new Size(1284, 28);
=======
            label6.Location = new Point(4, 5);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(1287, 32);
>>>>>>> Stashed changes
            label6.TabIndex = 8;
            label6.Text = "Kho hàng: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            label7.Location = new Point(3, 231);
            label7.Name = "label7";
            label7.Size = new Size(1284, 28);
=======
            label7.Location = new Point(4, 193);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(1287, 32);
>>>>>>> Stashed changes
            label7.TabIndex = 10;
            label7.Text = "Lịch sử nhập hàng:";
            // 
            // tableLichSuNhap
            // 
            tableLichSuNhap.AllowUserToAddRows = false;
            tableLichSuNhap.AllowUserToDeleteRows = false;
            tableLichSuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLichSuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableLichSuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLichSuNhap.Columns.AddRange(new DataGridViewColumn[] { CollumnForMaSP, CollumnForTenSP, CollumnForThanhTien, CollumnForNgay });
            tableLichSuNhap.GridColor = SystemColors.HighlightText;
<<<<<<< Updated upstream
            tableLichSuNhap.Location = new Point(3, 262);
            tableLichSuNhap.Name = "tableLichSuNhap";
            tableLichSuNhap.ReadOnly = true;
            tableLichSuNhap.RowHeadersWidth = 51;
            tableLichSuNhap.Size = new Size(1284, 168);
=======
            tableLichSuNhap.Location = new Point(4, 229);
            tableLichSuNhap.Margin = new Padding(4);
            tableLichSuNhap.Name = "tableLichSuNhap";
            tableLichSuNhap.ReadOnly = true;
            tableLichSuNhap.RowHeadersWidth = 51;
            tableLichSuNhap.Size = new Size(1287, 145);
>>>>>>> Stashed changes
            tableLichSuNhap.TabIndex = 11;
            tableLichSuNhap.CellContentClick += dataGridView2_CellContentClick;
            // 
            // CollumnForMaSP
            // 
            CollumnForMaSP.HeaderText = "Mã sản phẩm";
            CollumnForMaSP.MinimumWidth = 6;
            CollumnForMaSP.Name = "CollumnForMaSP";
            CollumnForMaSP.ReadOnly = true;
            // 
            // CollumnForTenSP
            // 
            CollumnForTenSP.HeaderText = "Tên sản phẩm";
            CollumnForTenSP.MinimumWidth = 6;
            CollumnForTenSP.Name = "CollumnForTenSP";
            CollumnForTenSP.ReadOnly = true;
            // 
            // CollumnForThanhTien
            // 
            CollumnForThanhTien.HeaderText = "Thành tiền nhập hàng";
            CollumnForThanhTien.MinimumWidth = 6;
            CollumnForThanhTien.Name = "CollumnForThanhTien";
            CollumnForThanhTien.ReadOnly = true;
            // 
            // CollumnForNgay
            // 
            CollumnForNgay.HeaderText = "Ngày nhập hàng";
            CollumnForNgay.MinimumWidth = 6;
            CollumnForNgay.Name = "CollumnForNgay";
            CollumnForNgay.ReadOnly = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 4);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
<<<<<<< Updated upstream
            label5.Size = new Size(1301, 31);
=======
            label5.Size = new Size(1312, 39);
>>>>>>> Stashed changes
            label5.TabIndex = 7;
            label5.Text = "Nhập sản phẩm mới vào kho";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(textBoxForDonGia, 3, 1);
            tableLayoutPanel1.Controls.Add(textBoxForTenSP, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxForSoLuong, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxForMaSP, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 2);
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(8, 61);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
<<<<<<< Updated upstream
            tableLayoutPanel1.Size = new Size(1202, 182);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // textBoxForDonGia
            // 
            textBoxForDonGia.Dock = DockStyle.Fill;
            textBoxForDonGia.Location = new Point(783, 63);
            textBoxForDonGia.Name = "textBoxForDonGia";
            textBoxForDonGia.Size = new Size(416, 27);
=======
            tableLayoutPanel1.Size = new Size(1185, 228);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // textBoxForMaPN
            // 
            textBoxForMaPN.Dock = DockStyle.Fill;
            textBoxForMaPN.Location = new Point(181, 154);
            textBoxForMaPN.Margin = new Padding(4);
            textBoxForMaPN.Name = "textBoxForMaPN";
            textBoxForMaPN.Size = new Size(406, 31);
            textBoxForMaPN.TabIndex = 11;
            // 
            // labelForMaPN
            // 
            labelForMaPN.AutoSize = true;
            labelForMaPN.Dock = DockStyle.Top;
            labelForMaPN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForMaPN.Location = new Point(4, 150);
            labelForMaPN.Margin = new Padding(4, 0, 4, 0);
            labelForMaPN.Name = "labelForMaPN";
            labelForMaPN.Size = new Size(169, 30);
            labelForMaPN.TabIndex = 10;
            labelForMaPN.Text = "Mã phiếu nhập: ";
            labelForMaPN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForDonGia
            // 
            textBoxForDonGia.Dock = DockStyle.Fill;
            textBoxForDonGia.Location = new Point(772, 79);
            textBoxForDonGia.Margin = new Padding(4);
            textBoxForDonGia.Name = "textBoxForDonGia";
            textBoxForDonGia.Size = new Size(409, 31);
>>>>>>> Stashed changes
            textBoxForDonGia.TabIndex = 8;
            // 
            // textBoxForTenSP
            // 
            textBoxForTenSP.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
            textBoxForTenSP.Location = new Point(183, 63);
            textBoxForTenSP.Name = "textBoxForTenSP";
            textBoxForTenSP.Size = new Size(414, 27);
=======
            textBoxForTenSP.Location = new Point(181, 79);
            textBoxForTenSP.Margin = new Padding(4);
            textBoxForTenSP.Name = "textBoxForTenSP";
            textBoxForTenSP.Size = new Size(406, 31);
>>>>>>> Stashed changes
            textBoxForTenSP.TabIndex = 7;
            // 
            // textBoxForSoLuong
            // 
            textBoxForSoLuong.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
            textBoxForSoLuong.Location = new Point(783, 3);
            textBoxForSoLuong.Name = "textBoxForSoLuong";
            textBoxForSoLuong.Size = new Size(416, 27);
=======
            textBoxForSoLuong.Location = new Point(772, 4);
            textBoxForSoLuong.Margin = new Padding(4);
            textBoxForSoLuong.Name = "textBoxForSoLuong";
            textBoxForSoLuong.Size = new Size(409, 31);
>>>>>>> Stashed changes
            textBoxForSoLuong.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
<<<<<<< Updated upstream
            label1.Size = new Size(174, 28);
=======
            label1.Size = new Size(169, 32);
>>>>>>> Stashed changes
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
<<<<<<< Updated upstream
            label2.Location = new Point(603, 60);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
=======
            label2.Location = new Point(595, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
>>>>>>> Stashed changes
            label2.TabIndex = 2;
            label2.Text = "Đơn giá: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(4, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
<<<<<<< Updated upstream
            label3.Size = new Size(174, 28);
=======
            label3.Size = new Size(169, 32);
>>>>>>> Stashed changes
            label3.TabIndex = 3;
            label3.Text = "Tên sản phẩm: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F);
<<<<<<< Updated upstream
            label4.Location = new Point(603, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
=======
            label4.Location = new Point(595, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
>>>>>>> Stashed changes
            label4.TabIndex = 1;
            label4.Text = "Số lượng: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForMaSP
            // 
            textBoxForMaSP.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
            textBoxForMaSP.Location = new Point(183, 3);
            textBoxForMaSP.Name = "textBoxForMaSP";
            textBoxForMaSP.Size = new Size(414, 27);
=======
            textBoxForMaSP.Location = new Point(181, 4);
            textBoxForMaSP.Margin = new Padding(4);
            textBoxForMaSP.Name = "textBoxForMaSP";
            textBoxForMaSP.Size = new Size(406, 31);
>>>>>>> Stashed changes
            textBoxForMaSP.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            buttonAdd.Location = new Point(10, 130);
            buttonAdd.Margin = new Padding(10);
=======
            buttonAdd.Location = new Point(780, 162);
            buttonAdd.Margin = new Padding(12);
>>>>>>> Stashed changes
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(6);
            buttonAdd.Size = new Size(200, 52);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Nhập hàng";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
<<<<<<< Updated upstream
            ClientSize = new Size(1315, 723);
=======
            ClientSize = new Size(1328, 740);
>>>>>>> Stashed changes
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabNhapHang.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableKhoHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableLichSuNhap).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabNhapHang;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxForDonGia;
        private TextBox textBoxForTenSP;
        private TextBox textBoxForSoLuong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxForMaSP;
        private Label label5;
        private DataGridView tableKhoHang;
        private Label label6;
        private DataGridViewTextBoxColumn ColumnMaSP;
        private DataGridViewTextBoxColumn ColumnTenSP;
<<<<<<< Updated upstream
        private DataGridViewTextBoxColumn ColumnForSoLuong;
        private DataGridView tableLichSuNhap;
        private Label label7;
        private DataGridViewTextBoxColumn CollumnForMaSP;
        private DataGridViewTextBoxColumn CollumnForTenSP;
        private DataGridViewTextBoxColumn CollumnForThanhTien;
        private DataGridViewTextBoxColumn CollumnForNgay;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
=======
        private DataGridViewTextBoxColumn ColumnSoLuong;
        private DataGridViewTextBoxColumn ColumnForMaPN;
        private DataGridViewTextBoxColumn ColumnForMaSP;
        private DataGridViewTextBoxColumn ColumnForTenSP;
        private DataGridViewTextBoxColumn ColumnForThanhTien;
        private DataGridViewTextBoxColumn ColumnForNgay;
        private Label label10;
        private DataGridViewTextBoxColumn colMaSP_tab2;
        private DataGridViewTextBoxColumn colTenSanPham_tab2;
        private DataGridViewTextBoxColumn colSoLuong_tab2;
        private DataGridViewTextBoxColumn colDonGia_tab2;
        private DataGridViewTextBoxColumn colThanhTien_tab2;
        private Label label11;
        private Label txt_TenSanPhamtab1;
        private TextBox slban;
        private ComboBox cbSanPham;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colTen_tab1;
        private DataGridViewTextBoxColumn colGia_tab1;
        private DataGridViewTextBoxColumn colSoLuongBan_tab1;
        private Label lblTongTien_tab2;
        private Label lblSoLuongHoaDon_tab2;
>>>>>>> Stashed changes
    }
}
