namespace BaiTapLon_QLSieuThiMini
{
    public partial class Form1 : Form
    {
<<<<<<< Updated upstream
        public Form1()
        {
            InitializeComponent();
=======
        //Các biến tương tác csdl
        string connectedString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSieuThi;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adt = new SqlDataAdapter();
        SqlCommand cmd;

        //Các biến lưu thông tin các bảng
        DataTable dtLichSuNhap = new DataTable();
        DataTable dtKhoHang = new DataTable();
        DataTable dtSanPhamDangBan = new DataTable();
        DataTable dtGioHang_tab2 = new DataTable();
        DataTable dtSanPhamBan_tab2 = new DataTable();

        public Form1()
        {
            InitializeComponent();

            // Tắt tự động tạo cột
            tableLichSuNhap.AutoGenerateColumns = false;
            dgvSanPhamDuocBan_tab1.AutoGenerateColumns = false;

            // Gắn tên cột trong CSDL vào các cột đã tạo sẵn
            tableLichSuNhap.Columns["ColumnForMaPN"].DataPropertyName = "MaPN";
            tableLichSuNhap.Columns["ColumnForMaSP"].DataPropertyName = "MaSP";
            tableLichSuNhap.Columns["ColumnForTenSP"].DataPropertyName = "TenSP";
            tableLichSuNhap.Columns["ColumnForThanhTien"].DataPropertyName = "ThanhTien";
            tableLichSuNhap.Columns["ColumnForNgay"].DataPropertyName = "NgayNhap";

            tableKhoHang.AutoGenerateColumns = false;
            tableKhoHang.Columns["ColumnMaSP"].DataPropertyName = "MaSP";
            tableKhoHang.Columns["ColumnTenSP"].DataPropertyName = "TenSP";
            tableKhoHang.Columns["ColumnSoLuong"].DataPropertyName = "SoLuongTrongKho";

            // Khởi tạo cấu trúc dtSanPhamDangBan
            dtSanPhamDangBan.Columns.Add("MaSP", typeof(string));
            dtSanPhamDangBan.Columns.Add("TenSP", typeof(string));

            dtSanPhamDangBan.Columns.Add("GiaBan", typeof(int));
            dtSanPhamDangBan.Columns.Add("SoLuongDangBan", typeof(int));

            dgvSanPhamDuocBan_tab1.DataSource = dtSanPhamDangBan;

            //Gắn DataPropertyName cho 5 cột design sẵn
            dgvSanPhamDuocBan_tab1.Columns["colMa"].DataPropertyName = "MaSP";
            dgvSanPhamDuocBan_tab1.Columns["colTen_tab1"].DataPropertyName = "TenSP";

            dgvSanPhamDuocBan_tab1.Columns["colGia_tab1"].DataPropertyName = "GiaBan";
            dgvSanPhamDuocBan_tab1.Columns["colSoLuongBan_tab1"].DataPropertyName = "SoLuongDangBan";
            con = new SqlConnection(connectedString);
            try
            {
                //Mở kết nối với CSDL
                con.Open();

                //Lấy dữ liệu từ LichSuNhapHang trong database
                SqlCommand cmdLichSuNhap = new SqlCommand("Select *, (SoLuongNhap * GiaNhap) as ThanhTien from LichSuNhapHang", con);
                adt = new SqlDataAdapter(cmdLichSuNhap);
                adt.Fill(dtLichSuNhap);
                tableLichSuNhap.DataSource = dtLichSuNhap;

                //Lấy dữ liệu từ SanPhamTrongKho trong database
                SqlCommand cmdKhoHang = new SqlCommand("Select * from SanPhamTrongKho", con);
                SqlDataAdapter adtKhoHang = new SqlDataAdapter(cmdKhoHang);
                adtKhoHang.Fill(dtKhoHang);
                tableKhoHang.DataSource = dtKhoHang;
                cbSanPham.DataSource = dtKhoHang;

                cbSanPham.DisplayMember = "TenSP";

                cbSanPham.ValueMember = "MaSP";

                //Lấy dữ liệu từ SanPhamDangBan
                SqlCommand cmdSanPhamBan =
                new SqlCommand("SELECT * FROM SanPhamDangBan", con);

                SqlDataAdapter adtSanPhamBan =
                new SqlDataAdapter(cmdSanPhamBan);

                adtSanPhamBan.Fill(dtSanPhamDangBan);
                TaoBangGioHang_tab2();
                LoadSanPhamLenComboBox_tab2();
                CapNhatThongTinHoaDon_tab2();


                //Đóng kết nối 
                con.Close();
            }
            catch (Exception ex)
            {
                TaoBangGioHang_tab2();
                LoadSanPhamLenComboBox_tab2();
                CapNhatThongTinHoaDon_tab2();
                //Phát hiện lỗi khi kết nối cơ sở dữ liệu
                MessageBox.Show(ex.Message);
            }
>>>>>>> Stashed changes
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {   

            if (string.IsNullOrWhiteSpace(textBoxForMaSP.Text)
                || string.IsNullOrWhiteSpace(textBoxForTenSP.Text)
                || string.IsNullOrWhiteSpace(textBoxForSoLuong.Text)
                || string.IsNullOrWhiteSpace(textBoxForDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            tableKhoHang.Rows.Add(textBoxForMaSP.Text, textBoxForTenSP.Text, textBoxForSoLuong.Text, textBoxForDonGia.Text);
            tableLichSuNhap.Rows.Add(textBoxForMaSP.Text, textBoxForTenSP.Text, textBoxForSoLuong.Text, textBoxForDonGia.Text);
        }

        private void cboSanPham_tab2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // ===============================
        // NGUYỄN TRỌNG NGHĨA - TAB BÁN HÀNG
        // ===============================

        private void TaoBangGioHang_tab2()
        {
            dtGioHang_tab2.Columns.Clear();

            dtGioHang_tab2.Columns.Add("MaSP", typeof(string));
            dtGioHang_tab2.Columns.Add("TenSP", typeof(string));
            dtGioHang_tab2.Columns.Add("SoLuong", typeof(int));
            dtGioHang_tab2.Columns.Add("DonGia", typeof(int));
            dtGioHang_tab2.Columns.Add("ThanhTien", typeof(int));

            dgvGioHang_tab2.AutoGenerateColumns = false;

            dgvGioHang_tab2.Columns["colMaSP_tab2"].DataPropertyName = "MaSP";
            dgvGioHang_tab2.Columns["colTenSanPham_tab2"].DataPropertyName = "TenSP";
            dgvGioHang_tab2.Columns["colSoLuong_tab2"].DataPropertyName = "SoLuong";
            dgvGioHang_tab2.Columns["colDonGia_tab2"].DataPropertyName = "DonGia";
            dgvGioHang_tab2.Columns["colThanhTien_tab2"].DataPropertyName = "ThanhTien";

            dgvGioHang_tab2.DataSource = dtGioHang_tab2;
        }

        private void LoadSanPhamLenComboBox_tab2()
        {
            dtSanPhamBan_tab2.Clear();

            try
            {
                if (con == null)
                    con = new SqlConnection(connectedString);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = @"
            SELECT 
                spdb.MaSP,
                spk.TenSP,
                spdb.SoLuongDangBan,
                spdb.GiaBan
            FROM SanPhamDangBan spdb
            JOIN SanPhamTrongKho spk
                ON spdb.MaSP = spk.MaSP
            WHERE spdb.SoLuongDangBan > 0";

                SqlDataAdapter adt = new SqlDataAdapter(sql, con);
                adt.Fill(dtSanPhamBan_tab2);

                cboSanPham_tab2.DataSource = dtSanPhamBan_tab2;
                cboSanPham_tab2.DisplayMember = "TenSP";
                cboSanPham_tab2.ValueMember = "MaSP";
                cboSanPham_tab2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load sản phẩm bán hàng: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnThemSanPham_tab2_Click(object sender, EventArgs e)
        {
            if (cboSanPham_tab2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Cảnh báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuongMua_tab2.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng mua!", "Cảnh báo");
                return;
            }

            if (!int.TryParse(txtSoLuongMua_tab2.Text.Trim(), out int soLuongMua))
            {
                MessageBox.Show("Số lượng mua phải là số nguyên!", "Lỗi");
                return;
            }

            if (soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua phải lớn hơn 0!", "Lỗi");
                return;
            }

            DataRowView selectedRow = cboSanPham_tab2.SelectedItem as DataRowView;

            if (selectedRow == null)
            {
                MessageBox.Show("Dữ liệu sản phẩm không hợp lệ!", "Lỗi");
                return;
            }

            string maSP = selectedRow["MaSP"].ToString();
            string tenSP = selectedRow["TenSP"].ToString();
            int soLuongDangBan = Convert.ToInt32(selectedRow["SoLuongDangBan"]);
            int donGia = Convert.ToInt32(selectedRow["GiaBan"]);

            DataRow[] foundRows = dtGioHang_tab2.Select($"MaSP = '{maSP.Replace("'", "''")}'");

            int soLuongDaCoTrongGio = 0;

            if (foundRows.Length > 0)
                soLuongDaCoTrongGio = Convert.ToInt32(foundRows[0]["SoLuong"]);

            if (soLuongDaCoTrongGio + soLuongMua > soLuongDangBan)
            {
                MessageBox.Show(
                    $"Không đủ hàng đang bán!\nĐang bán: {soLuongDangBan}\nĐã có trong giỏ: {soLuongDaCoTrongGio}",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (foundRows.Length > 0)
            {
                int soLuongMoi = soLuongDaCoTrongGio + soLuongMua;

                foundRows[0]["SoLuong"] = soLuongMoi;
                foundRows[0]["ThanhTien"] = soLuongMoi * donGia;
            }
            else
            {
                DataRow newRow = dtGioHang_tab2.NewRow();

                newRow["MaSP"] = maSP;
                newRow["TenSP"] = tenSP;
                newRow["SoLuong"] = soLuongMua;
                newRow["DonGia"] = donGia;
                newRow["ThanhTien"] = soLuongMua * donGia;

                dtGioHang_tab2.Rows.Add(newRow);
            }

            CapNhatThongTinHoaDon_tab2();

            txtSoLuongMua_tab2.Clear();
            cboSanPham_tab2.SelectedIndex = -1;
        }

        private void CapNhatThongTinHoaDon_tab2()
        {
            int tongSoLuong = 0;
            int tongTien = 0;

            foreach (DataRow row in dtGioHang_tab2.Rows)
            {
                tongSoLuong += Convert.ToInt32(row["SoLuong"]);
                tongTien += Convert.ToInt32(row["ThanhTien"]);
            }

            lblSoLuongHoaDon_tab2.Text = "Số lượng hóa đơn: " + tongSoLuong;
            lblTongTien_tab2.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
        }

        private int LayTongTienHoaDon_tab2()
        {
            int tongTien = 0;

            foreach (DataRow row in dtGioHang_tab2.Rows)
            {
                tongTien += Convert.ToInt32(row["ThanhTien"]);
            }

            return tongTien;
        }

        private void btnThanhToan_tab2_Click(object sender, EventArgs e)
        {
            if (dtGioHang_tab2.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Cảnh báo");
                return;
            }

            string maHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            DateTime ngayIn = DateTime.Now;
            int tongTien = LayTongTienHoaDon_tab2();

            try
            {
                if (con == null)
                    con = new SqlConnection(connectedString);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        string insertHoaDonSql = @"
                    INSERT INTO HoaDon(MaHD, NgayIn, TongTien)
                    VALUES (@MaHD, @NgayIn, @TongTien)";

                        using (SqlCommand cmdInsertHoaDon = new SqlCommand(insertHoaDonSql, con, trans))
                        {
                            cmdInsertHoaDon.Parameters.AddWithValue("@MaHD", maHD);
                            cmdInsertHoaDon.Parameters.AddWithValue("@NgayIn", ngayIn);
                            cmdInsertHoaDon.Parameters.AddWithValue("@TongTien", tongTien);
                            cmdInsertHoaDon.ExecuteNonQuery();
                        }

                        foreach (DataRow row in dtGioHang_tab2.Rows)
                        {
                            string maSP = row["MaSP"].ToString();
                            int soLuongMua = Convert.ToInt32(row["SoLuong"]);

                            string updateSanPhamDangBanSql = @"
                        UPDATE SanPhamDangBan
                        SET SoLuongDangBan = SoLuongDangBan - @SoLuongMua
                        WHERE MaSP = @MaSP
                        AND SoLuongDangBan >= @SoLuongMua";

                            using (SqlCommand cmdUpdate = new SqlCommand(updateSanPhamDangBanSql, con, trans))
                            {
                                cmdUpdate.Parameters.AddWithValue("@SoLuongMua", soLuongMua);
                                cmdUpdate.Parameters.AddWithValue("@MaSP", maSP);

                                int affectedRows = cmdUpdate.ExecuteNonQuery();

                                if (affectedRows == 0)
                                {
                                    throw new Exception("Sản phẩm mã " + maSP + " không đủ số lượng đang bán!");
                                }
                            }
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }

                MessageBox.Show(
                    "Thanh toán thành công!\nMã hóa đơn: " + maHD,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CapNhatTab1SauKhiThanhToan_tab2();
                dtGioHang_tab2.Clear();
                CapNhatThongTinHoaDon_tab2();

                txtSoLuongMua_tab2.Clear();
                cboSanPham_tab2.SelectedIndex = -1;

                LoadSanPhamLenComboBox_tab2();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thanh toán: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
           
        }
        private void CapNhatTab1SauKhiThanhToan_tab2()
        {
            foreach (DataRow rowGioHang in dtGioHang_tab2.Rows)
            {
                string maSP = rowGioHang["MaSP"].ToString();
                int soLuongMua = Convert.ToInt32(rowGioHang["SoLuong"]);

                DataRow[] foundRows = dtSanPhamDangBan.Select($"MaSP = '{maSP.Replace("'", "''")}'");

                if (foundRows.Length > 0)
                {
                    int soLuongDangBanHienTai = Convert.ToInt32(foundRows[0]["SoLuongDangBan"]);
                    int soLuongMoi = soLuongDangBanHienTai - soLuongMua;

                    if (soLuongMoi < 0)
                        soLuongMoi = 0;

                    foundRows[0]["SoLuongDangBan"] = soLuongMoi;
                }
            }

            dgvSanPhamDuocBan_tab1.Refresh();
        }

    }
}
