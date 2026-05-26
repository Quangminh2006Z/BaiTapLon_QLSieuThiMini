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
            dataGridView1 = new DataGridView();
            ColumnMaSPTheThanhToan = new DataGridViewTextBoxColumn();
            ColumnTenSanPhamTheThanhToan = new DataGridViewTextBoxColumn();
            ColumnSoLuongTheThanhToan = new DataGridViewTextBoxColumn();
            ColumnDonGiaTheThanhToan = new DataGridViewTextBoxColumn();
            ColumnThanhTienTheThanhToan = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblSanPham = new Label();
            label9 = new Label();
            comboBoxForTenSP = new ComboBox();
            textBoxForSoLuongMua = new TextBox();
            buttonThanhToanTab2 = new Button();
            buttonThemSanPhamTab2 = new Button();
            tabNhapHang = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableKhoHang = new DataGridView();
            ColumnMaSP = new DataGridViewTextBoxColumn();
            ColumnTenSP = new DataGridViewTextBoxColumn();
            ColumnForSoLuong = new DataGridViewTextBoxColumn();
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
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Size = new Size(1327, 740);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1319, 702);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1319, 702);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bán hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnMaSPTheThanhToan, ColumnTenSanPhamTheThanhToan, ColumnSoLuongTheThanhToan, ColumnDonGiaTheThanhToan, ColumnThanhTienTheThanhToan });
            dataGridView1.Location = new Point(4, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1311, 432);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnMaSPTheThanhToan
            // 
            ColumnMaSPTheThanhToan.HeaderText = "Mã SP";
            ColumnMaSPTheThanhToan.MinimumWidth = 8;
            ColumnMaSPTheThanhToan.Name = "ColumnMaSPTheThanhToan";
            // 
            // ColumnTenSanPhamTheThanhToan
            // 
            ColumnTenSanPhamTheThanhToan.HeaderText = "Tên sản phẩm";
            ColumnTenSanPhamTheThanhToan.MinimumWidth = 8;
            ColumnTenSanPhamTheThanhToan.Name = "ColumnTenSanPhamTheThanhToan";
            // 
            // ColumnSoLuongTheThanhToan
            // 
            ColumnSoLuongTheThanhToan.HeaderText = "Số lượng";
            ColumnSoLuongTheThanhToan.MinimumWidth = 8;
            ColumnSoLuongTheThanhToan.Name = "ColumnSoLuongTheThanhToan";
            // 
            // ColumnDonGiaTheThanhToan
            // 
            ColumnDonGiaTheThanhToan.HeaderText = "Đơn giá";
            ColumnDonGiaTheThanhToan.MinimumWidth = 8;
            ColumnDonGiaTheThanhToan.Name = "ColumnDonGiaTheThanhToan";
            // 
            // ColumnThanhTienTheThanhToan
            // 
            ColumnThanhTienTheThanhToan.HeaderText = "Thành tiền";
            ColumnThanhTienTheThanhToan.MinimumWidth = 8;
            ColumnThanhTienTheThanhToan.Name = "ColumnThanhTienTheThanhToan";
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
            tableLayoutPanel3.Controls.Add(comboBoxForTenSP, 1, 0);
            tableLayoutPanel3.Controls.Add(textBoxForSoLuongMua, 1, 1);
            tableLayoutPanel3.Controls.Add(buttonThanhToanTab2, 3, 1);
            tableLayoutPanel3.Controls.Add(buttonThemSanPhamTab2, 3, 0);
            tableLayoutPanel3.Location = new Point(8, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1227, 199);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Dock = DockStyle.Fill;
            lblSanPham.Font = new Font("Segoe UI", 12F);
            lblSanPham.Location = new Point(3, 0);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(283, 99);
            lblSanPham.TabIndex = 0;
            lblSanPham.Text = "Sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 99);
            label9.Name = "label9";
            label9.Size = new Size(283, 100);
            label9.TabIndex = 1;
            label9.Text = "Số lượng mua";
            // 
            // comboBoxForTenSP
            // 
            comboBoxForTenSP.Dock = DockStyle.Fill;
            comboBoxForTenSP.FormattingEnabled = true;
            comboBoxForTenSP.Location = new Point(292, 3);
            comboBoxForTenSP.Name = "comboBoxForTenSP";
            comboBoxForTenSP.Size = new Size(490, 33);
            comboBoxForTenSP.TabIndex = 2;
            // 
            // textBoxForSoLuongMua
            // 
            textBoxForSoLuongMua.Dock = DockStyle.Fill;
            textBoxForSoLuongMua.Location = new Point(292, 102);
            textBoxForSoLuongMua.Name = "textBoxForSoLuongMua";
            textBoxForSoLuongMua.Size = new Size(490, 31);
            textBoxForSoLuongMua.TabIndex = 3;
            // 
            // buttonThanhToanTab2
            // 
            buttonThanhToanTab2.Dock = DockStyle.Fill;
            buttonThanhToanTab2.Location = new Point(1024, 102);
            buttonThanhToanTab2.Name = "buttonThanhToanTab2";
            buttonThanhToanTab2.Size = new Size(200, 94);
            buttonThanhToanTab2.TabIndex = 1;
            buttonThanhToanTab2.Text = "Thanh toán";
            buttonThanhToanTab2.UseVisualStyleBackColor = true;
            // 
            // buttonThemSanPhamTab2
            // 
            buttonThemSanPhamTab2.Dock = DockStyle.Fill;
            buttonThemSanPhamTab2.Location = new Point(1024, 3);
            buttonThemSanPhamTab2.Name = "buttonThemSanPhamTab2";
            buttonThemSanPhamTab2.Size = new Size(200, 93);
            buttonThemSanPhamTab2.TabIndex = 3;
            buttonThemSanPhamTab2.Text = "Thêm sản phẩm";
            buttonThemSanPhamTab2.UseVisualStyleBackColor = true;
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
            tabNhapHang.Size = new Size(1319, 702);
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
            tableLayoutPanel2.Size = new Size(1295, 377);
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
            tableKhoHang.Location = new Point(4, 41);
            tableKhoHang.Margin = new Padding(4);
            tableKhoHang.Name = "tableKhoHang";
            tableKhoHang.ReadOnly = true;
            tableKhoHang.RowHeadersWidth = 51;
            tableKhoHang.Size = new Size(1287, 142);
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
            label7.Location = new Point(4, 192);
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
            tableLichSuNhap.Location = new Point(4, 228);
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
            ColumnForThanhTien.HeaderText = "Thành tiền nhập hàng";
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
            label5.Size = new Size(1311, 39);
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
            labelForMaPN.Font = new Font("Segoe UI", 12F);
            labelForMaPN.Location = new Point(4, 150);
            labelForMaPN.Margin = new Padding(4, 0, 4, 0);
            labelForMaPN.Name = "labelForMaPN";
            labelForMaPN.Size = new Size(169, 64);
            labelForMaPN.TabIndex = 10;
            labelForMaPN.Text = "Mã phiểu nhập: ";
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
            ClientSize = new Size(1327, 740);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn ColumnMaSP;
        private DataGridViewTextBoxColumn ColumnTenSP;
        private DataGridViewTextBoxColumn ColumnForSoLuong;
        private DataGridView tableLichSuNhap;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
        private TextBox textBoxForMaPN;
        private Label labelForMaPN;
        private DataGridViewTextBoxColumn ColumnForMaPN;
        private DataGridViewTextBoxColumn ColumnForMaSP;
        private DataGridViewTextBoxColumn ColumnForTenSP;
        private DataGridViewTextBoxColumn ColumnForThanhTien;
        private DataGridViewTextBoxColumn ColumnForNgay;
        private Button buttonThanhToanTab2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblSanPham;
        private Label label9;
        private ComboBox comboBoxForTenSP;
        private TextBox textBoxForSoLuongMua;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnMaSPTheThanhToan;
        private DataGridViewTextBoxColumn ColumnTenSanPhamTheThanhToan;
        private DataGridViewTextBoxColumn ColumnSoLuongTheThanhToan;
        private DataGridViewTextBoxColumn ColumnDonGiaTheThanhToan;
        private DataGridViewTextBoxColumn ColumnThanhTienTheThanhToan;
        private Button buttonThemSanPhamTab2;
    }
}
