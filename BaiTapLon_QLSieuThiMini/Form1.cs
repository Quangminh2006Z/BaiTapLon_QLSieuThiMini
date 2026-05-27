using Microsoft.Data.SqlClient;
using System.Data;

namespace BaiTapLon_QLSieuThiMini
{
    public partial class Form1 : Form
    {
        //Các biến tương tác csdl
        string connectedString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSieuThi;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adt = new SqlDataAdapter();
        SqlCommand cmd;

        //Các biến lưu thông tin các bảng
        DataTable dtLichSuNhap = new DataTable();
        DataTable dtKhoHang = new DataTable();
        DataTable dtGioHang = new DataTable();

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(connectedString);
            TaoBangGioHang();
            LoadSanPhamLenComboBoxBanHang();
            btnThemSanPham_tab2.Click += btnThemSanPham_tab2_Click;
            //Nguyẽn vũ quang minh
            // Tắt tự động tạo cột
            tableLichSuNhap.AutoGenerateColumns = false;
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

                //Đóng kết nối 
                con.Close();
            }
            catch (Exception ex)
            {
                //Phát hiện lỗi khi kết nối cơ sở dữ liệu
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            //Kiểm tra không để trống dữ liệu
            if (string.IsNullOrWhiteSpace(textBoxForMaSP.Text)
                || string.IsNullOrWhiteSpace(textBoxForTenSP.Text)
                || string.IsNullOrWhiteSpace(textBoxForSoLuong.Text)
                || string.IsNullOrWhiteSpace(textBoxForDonGia.Text)
                || string.IsNullOrWhiteSpace(textBoxForMaPN.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Ép kiểu để tính Thành Tiền
            if (int.TryParse(textBoxForSoLuong.Text, out int soLuong) && int.TryParse(textBoxForDonGia.Text, out int donGia))
            {
                if (soLuong <= 0 || donGia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương!", "Thông báo");
                    return;
                }
                int thanhTien = soLuong * donGia;
                string maSP = textBoxForMaSP.Text.Trim();
                string tenSP = textBoxForTenSP.Text.Trim();
                string maPN = textBoxForMaPN.Text.Trim();
                DateTime ngayNhap = DateTime.Now;
                //Mảng lưu thông tin các mã sản phẩm sẵn có bằng cách duyệt qua các MaSP
                DataRow[] foundRowMaSP = dtKhoHang.Select($"MaSP = '{textBoxForMaSP.Text.Trim()}'");

                //Thêm dữ liệu được nhập vào database
                try
                {
                    //Mở kết nối database
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //Mở transaction với CSDL
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            //Lệnh checkCmd truy vấn lấy ra số lượng mã sản phẩm tương đồng với MaSP được nhập trong kho
                            string checkCmdText = "SELECT COUNT(*) FROM SanPhamTrongKho WHERE MaSP = @MaSP";
                            using (SqlCommand cmdCheck = new SqlCommand(checkCmdText, con, trans))
                            {
                                //Gán maSP lấy từ textBox(đặt ở trên) gán cho lệnh checkCmdText
                                cmdCheck.Parameters.AddWithValue("@MaSP", maSP);
                                //Lấy số được trả về từ lệnh checkCmd bằng lệnh ExecuteScalar, đặt cho biến int
                                int count = (int)cmdCheck.ExecuteScalar();

                                //Trường hợp tìm thấy mã sản phẩm có sẵn trùng khớp với mã sản phẩm vừa được nhập
                                if (count > 0)
                                {
                                    string updateSoLuongCmd = "UPDATE SanPhamTrongKho SET SoLuongTrongKho = SoLuongTrongKho + @SoLuong WHERE MaSP = @MaSP";
                                    using (SqlCommand cmdUpdateSoLuong = new SqlCommand(updateSoLuongCmd, con, trans))
                                    {
                                        cmdUpdateSoLuong.Parameters.AddWithValue("@SoLuong", soLuong);
                                        cmdUpdateSoLuong.Parameters.AddWithValue("@MaSP", maSP);
                                        cmdUpdateSoLuong.ExecuteNonQuery();
                                    }
                                }

                                //Trường hợp mã sản phẩm vừa được nhập là mới
                                else
                                {
                                    string insertCmd = "INSERT INTO SanPhamTrongKho (MaSP,TenSP,SoLuongTrongKho) VALUES (@MaSP,@TenSP,@SoLuong)";
                                    using (SqlCommand cmdInsert = new SqlCommand(insertCmd, con, trans))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@MaSP", maSP);
                                        cmdInsert.Parameters.AddWithValue("@TenSP", tenSP);
                                        cmdInsert.Parameters.AddWithValue("@SoLuong", soLuong);
                                        cmdInsert.ExecuteNonQuery();
                                    }
                                }

                                //Lưu vào LichSuNhapHang
                                if (foundRowMaSP.Length == 0)
                                {

                                    string insertLichSuNhapCmd = "INSERT INTO LichSuNhapHang(MaPN, MaSP,TenSP,SoLuongNhap, NgayNhap,GiaNhap) VALUES (@MaPN,@MaSP,@TenSP,@SoLuongNhap, @NgayNhap,@GiaNhap)";
                                    using (SqlCommand cmdInsertLichSuNhapCmd = new SqlCommand(insertLichSuNhapCmd, con, trans))
                                    {
                                        cmdInsertLichSuNhapCmd.Parameters.AddWithValue("@MaPN", maPN);
                                        cmdInsertLichSuNhapCmd.Parameters.AddWithValue("@MaSP", maSP);
                                        cmdInsertLichSuNhapCmd.Parameters.AddWithValue("@TenSP", tenSP);
                                        cmdInsertLichSuNhapCmd.Parameters.AddWithValue("@SoLuongNhap", soLuong);
                                        cmdInsertLichSuNhapCmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                                        cmdInsertLichSuNhapCmd.Parameters.AddWithValue("@GiaNhap", donGia);
                                        cmdInsertLichSuNhapCmd.ExecuteNonQuery();

                                    }
                                }

                                trans.Commit();
                                MessageBox.Show(
                                    "Dữ liệu đã được lưu thành công vào cơ sở dữ liệu!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception exTransaction)
                        {
                            trans.Rollback();
                            throw exTransaction;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu vào database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }


                //Nếu mã sản phẩm đã tồn tại ( Mảng tìm được >0 sản phẩm)
                if (foundRowMaSP.Length > 0)
                {

                    // Nếu sản phẩm đã tồn tại, tiến hành cộng dồn số lượng

                    int soLuongHienTai = Convert.ToInt32(foundRowMaSP[0]["SoLuongTrongKho"]);
                    foundRowMaSP[0]["SoLuongTrongKho"] = soLuongHienTai + soLuong;
                    MessageBox.Show("Vì mã sản phẩm đã có sẵn, số lượng hàng trong kho sẽ được cộng thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataRow newKhoHangRow = dtKhoHang.NewRow();
                    newKhoHangRow["MaSP"] = textBoxForMaSP.Text;
                    newKhoHangRow["TenSP"] = textBoxForTenSP.Text;
                    newKhoHangRow["SoLuongTrongKho"] = soLuong;
                    dtKhoHang.Rows.Add(newKhoHangRow);
                }


                //Thêm vào bảng lịch sử nhập
                DataRow[] foundRowMaPN = dtLichSuNhap.Select($"MaPN = '{textBoxForMaPN.Text.Trim()}'");

                if (foundRowMaPN.Length > 0)
                {
                    MessageBox.Show("Phiếu nhập sẽ không được tạo vì đã có mã phiếu nhập tồn tại!", "Mã phiếu nhập đã tồn tại!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataRow newLichSuNhapRow = dtLichSuNhap.NewRow();
                    newLichSuNhapRow["MaPN"] = textBoxForMaPN.Text;
                    newLichSuNhapRow["MaSP"] = textBoxForMaSP.Text;
                    newLichSuNhapRow["TenSP"] = textBoxForTenSP.Text;
                    newLichSuNhapRow["ThanhTien"] = thanhTien;
                    newLichSuNhapRow["NgayNhap"] = DateTime.Now;
                    dtLichSuNhap.Rows.Add(newLichSuNhapRow);
                }
                MessageBox.Show("Dữ liệu đã được thêm vào bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxForDonGia.Clear();
                textBoxForMaPN.Clear();
                textBoxForMaSP.Clear();
                textBoxForSoLuong.Clear();
                textBoxForTenSP.Clear();
            }
            else
            {
                MessageBox.Show("Số lượng và Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Nguyen Vu Quang Minh
        #region Nguyen Trong Nghia - Tab Ban Hang

        DataTable dtSanPhamDangBan = new DataTable();

        private void LoadSanPhamLenComboBoxBanHang()
        {
            if (con == null)
            {
                con = new SqlConnection(connectedString);
            }

            dtSanPhamDangBan.Clear();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

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
                adt.Fill(dtSanPhamDangBan);

                cboSanPham_tab2.DataSource = dtSanPhamDangBan;
                cboSanPham_tab2.DisplayMember = "TenSP";
                cboSanPham_tab2.ValueMember = "MaSP";
                cboSanPham_tab2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ComboBox bán hàng: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnThemSanPham_tab2_Click(object sender, EventArgs e)
        {
            if (cboSanPham_tab2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuongMua_tab2.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng mua!");
                return;
            }

            if (!int.TryParse(txtSoLuongMua_tab2.Text.Trim(), out int soLuongMua))
            {
                MessageBox.Show("Số lượng mua phải là số nguyên!");
                return;
            }

            if (soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua phải lớn hơn 0!");
                return;
            }

            DataRowView selectedRow = cboSanPham_tab2.SelectedItem as DataRowView;

            if (selectedRow == null)
            {
                MessageBox.Show("Dữ liệu sản phẩm không hợp lệ!");
                return;
            }

            string maSP = selectedRow["MaSP"].ToString();
            string tenSP = selectedRow["TenSP"].ToString();
            int soLuongDangBan = Convert.ToInt32(selectedRow["SoLuongDangBan"]);
            int giaBan = Convert.ToInt32(selectedRow["GiaBan"]);

            DataRow[] foundRows = dtGioHang.Select($"MaSP = '{maSP}'");

            int soLuongDaCoTrongGio = 0;

            if (foundRows.Length > 0)
            {
                soLuongDaCoTrongGio = Convert.ToInt32(foundRows[0]["SoLuong"]);
            }

            if (soLuongDaCoTrongGio + soLuongMua > soLuongDangBan)
            {
                MessageBox.Show("Không được bán vượt quá số lượng sản phẩm đang bán!");
                return;
            }

            if (foundRows.Length > 0)
            {
                int soLuongMoi = soLuongDaCoTrongGio + soLuongMua;

                foundRows[0]["SoLuong"] = soLuongMoi;
                foundRows[0]["ThanhTien"] = soLuongMoi * giaBan;
            }
            else
            {
                DataRow newRow = dtGioHang.NewRow();

                newRow["MaSP"] = maSP;
                newRow["TenSP"] = tenSP;
                newRow["SoLuong"] = soLuongMua;
                newRow["DonGia"] = giaBan;
                newRow["ThanhTien"] = soLuongMua * giaBan;

                dtGioHang.Rows.Add(newRow);
            }
            CapNhatThongTinHoaDon();
            txtSoLuongMua_tab2.Clear();
            cboSanPham_tab2.SelectedIndex = -1;
        }
        private void TaoBangGioHang()
        {
            dtGioHang.Columns.Add("MaSP", typeof(string));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(int));

            dgvGioHang_tab2.AutoGenerateColumns = false;

            colMaSP_tab2.DataPropertyName = "MaSP";
            colTenSanPham_tab2.DataPropertyName = "TenSP";
            colSoLuong_tab2.DataPropertyName = "SoLuong";
            colDonGia_tab2.DataPropertyName = "DonGia";
            colThanhTien_tab2.DataPropertyName = "ThanhTien";

            dgvGioHang_tab2.DataSource = dtGioHang;
        }
        private void CapNhatThongTinHoaDon()
        {
            int soDongSanPham = dtGioHang.Rows.Count;
            int tongTien = 0;

            foreach (DataRow row in dtGioHang.Rows)
            {
                tongTien += Convert.ToInt32(row["ThanhTien"]);
            }

            lblSoLuongHoaDon_tab2.Text = "Số mặt hàng: " + soDongSanPham;
            lblTongTien_tab2.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
        }
        private int LayTongTienHoaDon()
        {
            int tongTien = 0;

            foreach (DataRow row in dtGioHang.Rows)
            {
                tongTien += Convert.ToInt32(row["ThanhTien"]);
            }

            return tongTien;
        }
        #endregion

        private void btnThanhToan_tab2_Click(object sender, EventArgs e)
        { 
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Cảnh báo");
                return;
            }

            string maHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            DateTime ngayIn = DateTime.Now;
            int tongTien = LayTongTienHoaDon();

            try
            {
                if (con == null)
                {
                    con = new SqlConnection(connectedString);
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        // 1. Lưu hóa đơn
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

                        // 2. Trừ số lượng sản phẩm đang bán
                        foreach (DataRow row in dtGioHang.Rows)
                        {
                            string maSP = row["MaSP"].ToString();
                            int soLuongMua = Convert.ToInt32(row["SoLuong"]);

                            string updateSoLuongSql = @"
                        UPDATE SanPhamDangBan
                        SET SoLuongDangBan = SoLuongDangBan - @SoLuongMua
                        WHERE MaSP = @MaSP
                        AND SoLuongDangBan >= @SoLuongMua";

                            using (SqlCommand cmdUpdate = new SqlCommand(updateSoLuongSql, con, trans))
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

                        MessageBox.Show(
                            "Thanh toán thành công!\nMã hóa đơn: " + maHD,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        dtGioHang.Clear();
                        CapNhatThongTinHoaDon();

                        txtSoLuongMua_tab2.Clear();
                        cboSanPham_tab2.SelectedIndex = -1;

                        LoadSanPhamLenComboBoxBanHang();
                    }
                    catch (Exception exTrans)
                    {
                        trans.Rollback();

                        MessageBox.Show(
                            "Lỗi khi thanh toán: " + exTrans.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi kết nối database: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }


}

