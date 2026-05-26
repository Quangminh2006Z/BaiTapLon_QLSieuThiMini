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
            tabQuanLySanPham = new TabPage();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            gia = new Label();
            btnTim = new Button();
            txtTim = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            cboTenSP = new ComboBox();
            txtGia = new TextBox();
            search = new Label();
            soluong = new Label();
            ten = new Label();
            txtSoLuong = new TextBox();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
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
            sp = new DataGridViewTextBoxColumn();
            sl = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabQuanLySanPham.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabNhapHang.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableKhoHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableLichSuNhap).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQuanLySanPham);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabNhapHang);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1315, 723);
            tabControl1.TabIndex = 5;
            // 
            // tabQuanLySanPham
            // 
            tabQuanLySanPham.Controls.Add(btnXoa);
            tabQuanLySanPham.Controls.Add(btnThem);
            tabQuanLySanPham.Controls.Add(btnSua);
            tabQuanLySanPham.Controls.Add(gia);
            tabQuanLySanPham.Controls.Add(btnTim);
            tabQuanLySanPham.Controls.Add(txtTim);
            tabQuanLySanPham.Controls.Add(tableLayoutPanel3);
            tabQuanLySanPham.Controls.Add(dataGridView1);
            tabQuanLySanPham.Location = new Point(4, 29);
            tabQuanLySanPham.Name = "tabQuanLySanPham";
            tabQuanLySanPham.Padding = new Padding(3);
            tabQuanLySanPham.Size = new Size(1307, 690);
            tabQuanLySanPham.TabIndex = 0;
            tabQuanLySanPham.Text = "Quản lý sản phẩm";
            tabQuanLySanPham.UseVisualStyleBackColor = true;
            tabQuanLySanPham.Click += tabQuanLySanPham_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Right;
            btnXoa.Location = new Point(1156, 235);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 75);
            btnXoa.TabIndex = 18;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Right;
            btnThem.Location = new Point(861, 235);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 75);
            btnThem.TabIndex = 16;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Right;
            btnSua.Location = new Point(1004, 235);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(149, 75);
            btnSua.TabIndex = 17;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // gia
            // 
            gia.Anchor = AnchorStyles.Left;
            gia.AutoSize = true;
            gia.Location = new Point(8, 247);
            gia.Name = "gia";
            gia.Size = new Size(70, 20);
            gia.TabIndex = 21;
            gia.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Left;
            btnTim.Location = new Point(553, 235);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(106, 75);
            btnTim.TabIndex = 20;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Left;
            txtTim.Location = new Point(84, 244);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(463, 27);
            txtTim.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Controls.Add(cboTenSP, 1, 0);
            tableLayoutPanel3.Controls.Add(txtGia, 5, 0);
            tableLayoutPanel3.Controls.Add(search, 4, 0);
            tableLayoutPanel3.Controls.Add(soluong, 2, 0);
            tableLayoutPanel3.Controls.Add(ten, 0, 0);
            tableLayoutPanel3.Controls.Add(txtSoLuong, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1301, 226);
            tableLayoutPanel3.TabIndex = 13;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // cboTenSP
            // 
            cboTenSP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboTenSP.FormattingEnabled = true;
            cboTenSP.Location = new Point(219, 99);
            cboTenSP.Name = "cboTenSP";
            cboTenSP.Size = new Size(210, 28);
            cboTenSP.TabIndex = 3;
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGia.Location = new Point(1083, 99);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(215, 27);
            txtGia.TabIndex = 1;
            // 
            // search
            // 
            search.Anchor = AnchorStyles.Right;
            search.AutoSize = true;
            search.Location = new Point(1046, 103);
            search.Name = "search";
            search.Size = new Size(31, 20);
            search.TabIndex = 11;
            search.Text = "Giá";
            // 
            // soluong
            // 
            soluong.Anchor = AnchorStyles.Right;
            soluong.AutoSize = true;
            soluong.Location = new Point(576, 103);
            soluong.Name = "soluong";
            soluong.Size = new Size(69, 20);
            soluong.TabIndex = 10;
            soluong.Text = "Số lượng";
            // 
            // ten
            // 
            ten.Anchor = AnchorStyles.Right;
            ten.AutoSize = true;
            ten.Location = new Point(113, 103);
            ten.Name = "ten";
            ten.Size = new Size(100, 20);
            ten.TabIndex = 9;
            ten.Text = "Tên sản phẩm";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoLuong.Location = new Point(651, 99);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(210, 27);
            txtSoLuong.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sp, sl, cost });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1301, 371);
            dataGridView1.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1307, 690);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabNhapHang
            // 
            tabNhapHang.AutoScroll = true;
            tabNhapHang.BackColor = Color.LightGray;
            tabNhapHang.Controls.Add(tableLayoutPanel2);
            tabNhapHang.Controls.Add(label5);
            tabNhapHang.Controls.Add(tableLayoutPanel1);
            tabNhapHang.Location = new Point(4, 29);
            tabNhapHang.Name = "tabNhapHang";
            tabNhapHang.Padding = new Padding(3);
            tabNhapHang.Size = new Size(1307, 690);
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
            tableLayoutPanel2.Location = new Point(11, 223);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(1290, 433);
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
            tableKhoHang.Location = new Point(3, 46);
            tableKhoHang.Name = "tableKhoHang";
            tableKhoHang.ReadOnly = true;
            tableKhoHang.RowHeadersWidth = 51;
            tableKhoHang.Size = new Size(1284, 167);
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
            label6.Location = new Point(3, 15);
            label6.Name = "label6";
            label6.Size = new Size(1284, 28);
            label6.TabIndex = 8;
            label6.Text = "Kho hàng: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 231);
            label7.Name = "label7";
            label7.Size = new Size(1284, 28);
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
            tableLichSuNhap.Location = new Point(3, 262);
            tableLichSuNhap.Name = "tableLichSuNhap";
            tableLichSuNhap.ReadOnly = true;
            tableLichSuNhap.RowHeadersWidth = 51;
            tableLichSuNhap.Size = new Size(1284, 168);
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
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(1301, 31);
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
            tableLayoutPanel1.Location = new Point(6, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1202, 182);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // textBoxForDonGia
            // 
            textBoxForDonGia.Dock = DockStyle.Fill;
            textBoxForDonGia.Location = new Point(783, 63);
            textBoxForDonGia.Name = "textBoxForDonGia";
            textBoxForDonGia.Size = new Size(416, 27);
            textBoxForDonGia.TabIndex = 8;
            // 
            // textBoxForTenSP
            // 
            textBoxForTenSP.Dock = DockStyle.Fill;
            textBoxForTenSP.Location = new Point(183, 63);
            textBoxForTenSP.Name = "textBoxForTenSP";
            textBoxForTenSP.Size = new Size(414, 27);
            textBoxForTenSP.TabIndex = 7;
            // 
            // textBoxForSoLuong
            // 
            textBoxForSoLuong.Dock = DockStyle.Fill;
            textBoxForSoLuong.Location = new Point(783, 3);
            textBoxForSoLuong.Name = "textBoxForSoLuong";
            textBoxForSoLuong.Size = new Size(416, 27);
            textBoxForSoLuong.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(603, 60);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 3;
            label3.Text = "Tên sản phẩm: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(603, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 1;
            label4.Text = "Số lượng: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForMaSP
            // 
            textBoxForMaSP.Dock = DockStyle.Fill;
            textBoxForMaSP.Location = new Point(183, 3);
            textBoxForMaSP.Name = "textBoxForMaSP";
            textBoxForMaSP.Size = new Size(414, 27);
            textBoxForMaSP.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(10, 130);
            buttonAdd.Margin = new Padding(10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(5);
            buttonAdd.Size = new Size(160, 42);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Nhập hàng";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // sp
            // 
            sp.HeaderText = "Tên sản phẩm";
            sp.MinimumWidth = 6;
            sp.Name = "sp";
            sp.Width = 125;
            // 
            // sl
            // 
            sl.HeaderText = "Số lượng sản phẩm";
            sl.MinimumWidth = 6;
            sl.Name = "sl";
            sl.Width = 125;
            // 
            // cost
            // 
            cost.HeaderText = "Giá";
            cost.MinimumWidth = 6;
            cost.Name = "cost";
            cost.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1315, 723);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabQuanLySanPham.ResumeLayout(false);
            tabQuanLySanPham.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TabPage tabQuanLySanPham;
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
        private DataGridViewTextBoxColumn CollumnForMaSP;
        private DataGridViewTextBoxColumn CollumnForTenSP;
        private DataGridViewTextBoxColumn CollumnForThanhTien;
        private DataGridViewTextBoxColumn CollumnForNgay;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
        private ComboBox cboTenSP;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private DataGridView dataGridView1;
        private Label search;
        private Label soluong;
        private TableLayoutPanel tableLayoutPanel3;
        private Label ten;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Label gia;
        private Button btnTim;
        private TextBox txtTim;
        private DataGridViewTextBoxColumn sp;
        private DataGridViewTextBoxColumn sl;
        private DataGridViewTextBoxColumn cost;
    }
}
