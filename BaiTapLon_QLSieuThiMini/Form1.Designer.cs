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
            label8 = new Label();
            dgvSanPhamDuocBan_tab1 = new DataGridView();
            colTen_tab1 = new DataGridViewTextBoxColumn();
            colSoLuong_tab1 = new DataGridViewTextBoxColumn();
            colGia_tab1 = new DataGridViewTextBoxColumn();
            colSoLuongBan_tab1 = new DataGridViewTextBoxColumn();
            btnXoa_tab1 = new Button();
            btnThem_tab1 = new Button();
            btnSua_tab1 = new Button();
            btnTim_tab1 = new Button();
            txtTim_tab1 = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            cboTenSanPham_tab1 = new ComboBox();
            search = new Label();
            soluong = new Label();
            txtGia_tab1 = new TextBox();
            txt_TenSanPhamtab1 = new Label();
            txtSoLuong_tab1 = new TextBox();
            tabPage2 = new TabPage();
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
            tabNhapHang = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableKhoHang = new DataGridView();
            ColumnMaSP = new DataGridViewTextBoxColumn();
            ColumnTenSP = new DataGridViewTextBoxColumn();
            ColumnSoLuong = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            tableLichSuNhap = new DataGridView();
            ColumnForMaPN = new DataGridViewTextBoxColumn();
            ColumnForMaSP = new DataGridViewTextBoxColumn();
            ColumnForTenSP = new DataGridViewTextBoxColumn();
            ColumnForThanhTien = new DataGridViewTextBoxColumn();
            ColumnForNgay = new DataGridViewTextBoxColumn();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxForMaPN = new TextBox();
            labelForMaPN = new Label();
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
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamDuocBan_tab1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang_tab2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            tabControl1.Size = new Size(1328, 740);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
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
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý sản phẩm được bán ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(7, 260);
            label8.Name = "label8";
            label8.Size = new Size(206, 30);
            label8.TabIndex = 29;
            label8.Text = "Sản phẩm được bán";
            // 
            // dgvSanPhamDuocBan_tab1
            // 
            dgvSanPhamDuocBan_tab1.AllowUserToAddRows = false;
            dgvSanPhamDuocBan_tab1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPhamDuocBan_tab1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPhamDuocBan_tab1.Columns.AddRange(new DataGridViewColumn[] { colTen_tab1, colSoLuong_tab1, colGia_tab1, colSoLuongBan_tab1 });
            dgvSanPhamDuocBan_tab1.Dock = DockStyle.Bottom;
            dgvSanPhamDuocBan_tab1.Location = new Point(4, 312);
            dgvSanPhamDuocBan_tab1.Margin = new Padding(4);
            dgvSanPhamDuocBan_tab1.Name = "dgvSanPhamDuocBan_tab1";
            dgvSanPhamDuocBan_tab1.RowHeadersWidth = 51;
            dgvSanPhamDuocBan_tab1.Size = new Size(1312, 386);
            dgvSanPhamDuocBan_tab1.TabIndex = 28;
            // 
            // colTen_tab1
            // 
            colTen_tab1.HeaderText = "Tên sản phẩm";
            colTen_tab1.MinimumWidth = 6;
            colTen_tab1.Name = "colTen_tab1";
            // 
            // colSoLuong_tab1
            // 
            colSoLuong_tab1.HeaderText = "Số lượng sản phẩm";
            colSoLuong_tab1.MinimumWidth = 6;
            colSoLuong_tab1.Name = "colSoLuong_tab1";
            // 
            // colGia_tab1
            // 
            colGia_tab1.HeaderText = "Giá";
            colGia_tab1.MinimumWidth = 6;
            colGia_tab1.Name = "colGia_tab1";
            // 
            // colSoLuongBan_tab1
            // 
            colSoLuongBan_tab1.HeaderText = "Số lượng bán";
            colSoLuongBan_tab1.MinimumWidth = 6;
            colSoLuongBan_tab1.Name = "colSoLuongBan_tab1";
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
            // 
            // btnTim_tab1
            // 
            btnTim_tab1.Anchor = AnchorStyles.Left;
            btnTim_tab1.Location = new Point(1175, 39);
            btnTim_tab1.Margin = new Padding(4);
            btnTim_tab1.Name = "btnTim_tab1";
            btnTim_tab1.Size = new Size(113, 42);
            btnTim_tab1.TabIndex = 26;
            btnTim_tab1.Text = "Tìm";
            btnTim_tab1.UseVisualStyleBackColor = true;
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
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.119278F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.88072F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(cboTenSanPham_tab1, 1, 0);
            tableLayoutPanel4.Controls.Add(search, 0, 2);
            tableLayoutPanel4.Controls.Add(soluong, 0, 1);
            tableLayoutPanel4.Controls.Add(txtGia_tab1, 1, 2);
            tableLayoutPanel4.Controls.Add(txt_TenSanPhamtab1, 0, 0);
            tableLayoutPanel4.Controls.Add(txtSoLuong_tab1, 1, 1);
            tableLayoutPanel4.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel4.Location = new Point(4, 4);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(674, 229);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // cboTenSanPham_tab1
            // 
            cboTenSanPham_tab1.Dock = DockStyle.Top;
            cboTenSanPham_tab1.FormattingEnabled = true;
            cboTenSanPham_tab1.Location = new Point(233, 4);
            cboTenSanPham_tab1.Margin = new Padding(4);
            cboTenSanPham_tab1.Name = "cboTenSanPham_tab1";
            cboTenSanPham_tab1.Size = new Size(437, 40);
            cboTenSanPham_tab1.TabIndex = 3;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Dock = DockStyle.Left;
            search.Location = new Point(4, 152);
            search.Margin = new Padding(4, 0, 4, 0);
            search.Name = "search";
            search.Size = new Size(48, 77);
            search.TabIndex = 11;
            search.Text = "Giá";
            // 
            // soluong
            // 
            soluong.AutoSize = true;
            soluong.Dock = DockStyle.Left;
            soluong.Font = new Font("Segoe UI", 12F);
            soluong.Location = new Point(4, 76);
            soluong.Margin = new Padding(4, 0, 4, 0);
            soluong.Name = "soluong";
            soluong.Size = new Size(173, 76);
            soluong.TabIndex = 10;
            soluong.Text = "Số lượng thêm";
            // 
            // txtGia_tab1
            // 
            txtGia_tab1.Dock = DockStyle.Top;
            txtGia_tab1.Location = new Point(233, 156);
            txtGia_tab1.Margin = new Padding(4);
            txtGia_tab1.Name = "txtGia_tab1";
            txtGia_tab1.Size = new Size(437, 39);
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
            txt_TenSanPhamtab1.Size = new Size(163, 76);
            txt_TenSanPhamtab1.TabIndex = 9;
            txt_TenSanPhamtab1.Text = "Tên sản phẩm";
            // 
            // txtSoLuong_tab1
            // 
            txtSoLuong_tab1.Dock = DockStyle.Top;
            txtSoLuong_tab1.Location = new Point(233, 80);
            txtSoLuong_tab1.Margin = new Padding(4);
            txtSoLuong_tab1.Name = "txtSoLuong_tab1";
            txtSoLuong_tab1.Size = new Size(437, 39);
            txtSoLuong_tab1.TabIndex = 0;
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
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bán hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTongTien_tab2
            // 
            lblTongTien_tab2.AutoSize = true;
            lblTongTien_tab2.Location = new Point(814, 256);
            lblTongTien_tab2.Name = "lblTongTien_tab2";
            lblTongTien_tab2.Size = new Size(148, 25);
            lblTongTien_tab2.TabIndex = 5;
            lblTongTien_tab2.Text = "Tổng tiền: 0 VNĐ";
            // 
            // lblSoLuongHoaDon_tab2
            // 
            lblSoLuongHoaDon_tab2.AutoSize = true;
            lblSoLuongHoaDon_tab2.Location = new Point(381, 256);
            lblSoLuongHoaDon_tab2.Name = "lblSoLuongHoaDon_tab2";
            lblSoLuongHoaDon_tab2.Size = new Size(176, 25);
            lblSoLuongHoaDon_tab2.TabIndex = 4;
            lblSoLuongHoaDon_tab2.Text = "Số lượng hóa đơn: 0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 247);
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
            tabNhapHang.Padding = new Padding(4);
            tabNhapHang.Size = new Size(1320, 702);
            tabNhapHang.TabIndex = 2;
            tabNhapHang.Text = "Nhập hàng & thống kê";
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
            tableLayoutPanel2.Size = new Size(1295, 378);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableKhoHang
            // 
            tableKhoHang.AllowUserToAddRows = false;
            tableKhoHang.AllowUserToDeleteRows = false;
            tableKhoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableKhoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableKhoHang.Columns.AddRange(new DataGridViewColumn[] { ColumnMaSP, ColumnTenSP, ColumnSoLuong });
            tableKhoHang.Dock = DockStyle.Fill;
            tableKhoHang.GridColor = SystemColors.HighlightText;
            tableKhoHang.Location = new Point(4, 41);
            tableKhoHang.Margin = new Padding(4);
            tableKhoHang.Name = "tableKhoHang";
            tableKhoHang.ReadOnly = true;
            tableKhoHang.RowHeadersWidth = 51;
            tableKhoHang.Size = new Size(1287, 143);
            tableKhoHang.TabIndex = 9;
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
            // ColumnSoLuong
            // 
            ColumnSoLuong.HeaderText = "Số lượng tồn";
            ColumnSoLuong.MinimumWidth = 6;
            ColumnSoLuong.Name = "ColumnSoLuong";
            ColumnSoLuong.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 5);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(1287, 32);
            label6.TabIndex = 8;
            label6.Text = "Kho hàng: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 193);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(1287, 32);
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
            tableLichSuNhap.Columns.AddRange(new DataGridViewColumn[] { ColumnForMaPN, ColumnForMaSP, ColumnForTenSP, ColumnForThanhTien, ColumnForNgay });
            tableLichSuNhap.GridColor = SystemColors.HighlightText;
            tableLichSuNhap.Location = new Point(4, 229);
            tableLichSuNhap.Margin = new Padding(4);
            tableLichSuNhap.Name = "tableLichSuNhap";
            tableLichSuNhap.ReadOnly = true;
            tableLichSuNhap.RowHeadersWidth = 51;
            tableLichSuNhap.Size = new Size(1287, 145);
            tableLichSuNhap.TabIndex = 11;
            tableLichSuNhap.CellContentClick += dataGridView2_CellContentClick;
            // 
            // ColumnForMaPN
            // 
            ColumnForMaPN.HeaderText = "Mã Phiếu Nhập";
            ColumnForMaPN.MinimumWidth = 6;
            ColumnForMaPN.Name = "ColumnForMaPN";
            ColumnForMaPN.ReadOnly = true;
            // 
            // ColumnForMaSP
            // 
            ColumnForMaSP.HeaderText = "Mã sản phẩm";
            ColumnForMaSP.MinimumWidth = 6;
            ColumnForMaSP.Name = "ColumnForMaSP";
            ColumnForMaSP.ReadOnly = true;
            // 
            // ColumnForTenSP
            // 
            ColumnForTenSP.HeaderText = "Tên sản phẩm";
            ColumnForTenSP.MinimumWidth = 6;
            ColumnForTenSP.Name = "ColumnForTenSP";
            ColumnForTenSP.ReadOnly = true;
            // 
            // ColumnForThanhTien
            // 
            ColumnForThanhTien.HeaderText = "Thành tiền nhập (vnđ)";
            ColumnForThanhTien.MinimumWidth = 6;
            ColumnForThanhTien.Name = "ColumnForThanhTien";
            ColumnForThanhTien.ReadOnly = true;
            // 
            // ColumnForNgay
            // 
            ColumnForNgay.HeaderText = "Ngày nhập hàng";
            ColumnForNgay.MinimumWidth = 6;
            ColumnForNgay.Name = "ColumnForNgay";
            ColumnForNgay.ReadOnly = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 4);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1312, 39);
            label5.TabIndex = 7;
            label5.Text = "Nhập sản phẩm mới vào kho";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(textBoxForMaPN, 1, 2);
            tableLayoutPanel1.Controls.Add(labelForMaPN, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxForDonGia, 3, 1);
            tableLayoutPanel1.Controls.Add(textBoxForTenSP, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxForSoLuong, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxForMaSP, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAdd, 3, 2);
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(8, 61);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
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
            textBoxForDonGia.TabIndex = 8;
            // 
            // textBoxForTenSP
            // 
            textBoxForTenSP.Dock = DockStyle.Fill;
            textBoxForTenSP.Location = new Point(181, 79);
            textBoxForTenSP.Margin = new Padding(4);
            textBoxForTenSP.Name = "textBoxForTenSP";
            textBoxForTenSP.Size = new Size(406, 31);
            textBoxForTenSP.TabIndex = 7;
            // 
            // textBoxForSoLuong
            // 
            textBoxForSoLuong.Dock = DockStyle.Fill;
            textBoxForSoLuong.Location = new Point(772, 4);
            textBoxForSoLuong.Margin = new Padding(4);
            textBoxForSoLuong.Name = "textBoxForSoLuong";
            textBoxForSoLuong.Size = new Size(409, 31);
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
            label1.Size = new Size(169, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(595, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
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
            label3.Size = new Size(169, 32);
            label3.TabIndex = 3;
            label3.Text = "Tên sản phẩm: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(595, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 1;
            label4.Text = "Số lượng: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForMaSP
            // 
            textBoxForMaSP.Dock = DockStyle.Fill;
            textBoxForMaSP.Location = new Point(181, 4);
            textBoxForMaSP.Margin = new Padding(4);
            textBoxForMaSP.Name = "textBoxForMaSP";
            textBoxForMaSP.Size = new Size(406, 31);
            textBoxForMaSP.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(780, 162);
            buttonAdd.Margin = new Padding(12);
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
            ClientSize = new Size(1328, 740);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamDuocBan_tab1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang_tab2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private DataGridView tableLichSuNhap;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
        private TextBox textBoxForMaPN;
        private Label labelForMaPN;
        private Button btnThanhToan_tab2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblSanPham;
        private Label label9;
        private ComboBox cboSanPham_tab2;
        private TextBox txtSoLuongMua_tab2;
        private DataGridView dgvGioHang_tab2;
        private Button btnThemSanPham_tab2;
        private Button btnXoa_tab1;
        private Button btnThem_tab1;
        private Button btnSua_tab1;
        private Button btnTim_tab1;
        private TextBox txtTim_tab1;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox cboTenSanPham_tab1;
        private TextBox txtGia_tab1;
        private Label search;
        private Label soluong;
        private Label txt_TenSanPhamtab1;
        private TextBox txtSoLuong_tab1;
        private DataGridView dgvSanPhamDuocBan_tab1;
        private DataGridViewTextBoxColumn ColumnMaSP;
        private DataGridViewTextBoxColumn ColumnTenSP;
        private DataGridViewTextBoxColumn ColumnSoLuong;
        private DataGridViewTextBoxColumn ColumnForMaPN;
        private DataGridViewTextBoxColumn ColumnForMaSP;
        private DataGridViewTextBoxColumn ColumnForTenSP;
        private DataGridViewTextBoxColumn ColumnForThanhTien;
        private DataGridViewTextBoxColumn ColumnForNgay;
        private Label label8;
        private DataGridViewTextBoxColumn colTen_tab1;
        private DataGridViewTextBoxColumn colSoLuong_tab1;
        private DataGridViewTextBoxColumn colGia_tab1;
        private DataGridViewTextBoxColumn colSoLuongBan_tab1;
        private Label label10;
        private DataGridViewTextBoxColumn colMaSP_tab2;
        private DataGridViewTextBoxColumn colTenSanPham_tab2;
        private DataGridViewTextBoxColumn colSoLuong_tab2;
        private DataGridViewTextBoxColumn colDonGia_tab2;
        private DataGridViewTextBoxColumn colThanhTien_tab2;
        private Label lblTongTien_tab2;
        private Label lblSoLuongHoaDon_tab2;
    }
}
