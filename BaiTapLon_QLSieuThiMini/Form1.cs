using Microsoft.Data.SqlClient;
using System.Data;

namespace BaiTapLon_QLSieuThiMini
{
    public partial class Form1 : Form
    {
        //Các biến tương tác csdl
        string connectedString =
@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSieuThi2;Integrated Security=True;TrustServerCertificate=True";
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
                //Lấy dư liệu từ Kho cho vào cb
                cbSanPham.DataSource = dtKhoHang;

                cbSanPham.DisplayMember = "TenSP";

                cbSanPham.ValueMember = "MaSP";

                //Lấy dữ liệu từ SanPhamDangBan
                SqlCommand cmdSanPhamBan =
                new SqlCommand("SELECT * FROM SanPhamDangBan", con);

                SqlDataAdapter adtSanPhamBan =
                new SqlDataAdapter(cmdSanPhamBan);

                adtSanPhamBan.Fill(dtSanPhamDangBan);



                //Đóng kết nối 
                con.Close();
                TaoBangGioHang_tab2();
                LoadSanPhamLenComboBox_tab2();
                CapNhatThongTinHoaDon_tab2();
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

                //Lấy nội dung từ textbox lưu vào các biến
                int thanhTien = soLuong * donGia;
                string maSP = textBoxForMaSP.Text.Trim();
                string tenSP = textBoxForTenSP.Text.Trim();
                string maPN = textBoxForMaPN.Text.Trim();
                DateTime ngayNhap = DateTime.Now;


                //Mảng lưu thông tin các mã sản phẩm sẵn có bằng cách duyệt qua các MaSP
                DataRow[] foundRowMaSP = dtKhoHang.Select($"MaSP = '{textBoxForMaSP.Text.Trim()}'");

                if (foundRowMaSP.Length > 0)
                {
                    // Lấy tên sản phẩm đang có sẵn trong kho
                    string tenSPCoSan = foundRowMaSP[0]["TenSP"].ToString();

                    // So sánh tên người dùng nhập và tên có sẵn (không phân biệt chữ hoa chữ thường)
                    if (!string.Equals(tenSPCoSan.Trim(), tenSP, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Mã sản phẩm '{maSP}' đã tồn tại trong kho với tên là:\n[{tenSPCoSan}]\n" 
                            + $"\nVui lòng nhập lại tên sản phẩm hoặc một mã sản phẩm khác!",
                                        "Tên sản phẩm không trùng khớp",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        // Chặn không cho lưu tiếp
                        return; 
                        
                    }
                }

                //Mảng lưu thông tin phiếu nhập nếu đã tồn tại
                DataRow[] foundRowMaPN = dtLichSuNhap.Select($"MaPN = '{maPN}'");
                if (foundRowMaPN.Length > 0)
                {
                    MessageBox.Show("Phiếu nhập đã tồn tại! Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                
                    DataRow newLichSuNhapRow = dtLichSuNhap.NewRow();
                    newLichSuNhapRow["MaPN"] = textBoxForMaPN.Text;
                    newLichSuNhapRow["MaSP"] = textBoxForMaSP.Text;
                    newLichSuNhapRow["TenSP"] = textBoxForTenSP.Text;
                    newLichSuNhapRow["ThanhTien"] = thanhTien;
                    newLichSuNhapRow["NgayNhap"] = DateTime.Now;
                    dtLichSuNhap.Rows.Add(newLichSuNhapRow);
                
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPhamDuocBan_tab1.CurrentRow == null) return;

            if (!int.TryParse(txtGia_tab1.Text, out int gia) ||
                !int.TryParse(slban.Text, out int soLuongBan) ||
                gia <= 0 || soLuongBan <= 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            string maSP = cbSanPham.SelectedValue.ToString();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = @"
        UPDATE SanPhamDangBan
        SET GiaBan = @GiaBan,
            SoLuongDangBan = @SoLuongBan
        WHERE MaSP = @MaSP";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@GiaBan", gia);
                cmd.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                cmd.ExecuteNonQuery();

                // Update RAM
                DataRow row =
                    dtSanPhamDangBan.Select($"MaSP = '{maSP}'")[0];

                row["GiaBan"] = gia;
                row["SoLuongDangBan"] = soLuongBan;

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            txtGia_tab1.Clear();
            slban.Clear();
            cbSanPham.SelectedIndex = 0;
        }

        private void btnThem_tab1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPhamDuocBan_tab1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_tab1_Click_1(object sender, EventArgs e)
        // Validate dữ liệu đầu vào
        {
            if (!int.TryParse(txtGia_tab1.Text, out int gia) ||
                !int.TryParse(slban.Text, out int soLuongBan))
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gia <= 0 || soLuongBan <= 0)
            {
                MessageBox.Show("Số lượng và giá phải > 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maSP = cbSanPham.SelectedValue.ToString();
            string tenSP = cbSanPham.Text;

            // Kiểm tra tồn kho RAM
            DataRow[] foundKho = dtKhoHang.Select($"MaSP = '{maSP}'");
            if (foundKho.Length == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongTon = Convert.ToInt32(foundKho[0]["SoLuongTrongKho"]);
            if (soLuongBan > soLuongTon)
            {
                MessageBox.Show($"Không đủ hàng! Tồn kho hiện tại: {soLuongTon}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu vào DB trước
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using SqlTransaction trans = con.BeginTransaction();

                // Kiểm tra sản phẩm đã tồn tại chưa
                string checkSql =
                    "SELECT COUNT(*) FROM SanPhamDangBan WHERE MaSP = @MaSP";

                SqlCommand cmdCheck = new SqlCommand(checkSql, con, trans);
                cmdCheck.Parameters.AddWithValue("@MaSP", maSP);

                int count = (int)cmdCheck.ExecuteScalar();

                // Nếu đã có -> UPDATE
                if (count > 0)
                {
                    string updateSql = @"
        UPDATE SanPhamDangBan
        SET SoLuongDangBan += @SoLuongBan,
            GiaBan = @GiaBan
        WHERE MaSP = @MaSP";

                    SqlCommand cmdUpdate = new SqlCommand(updateSql, con, trans);

                    cmdUpdate.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                    cmdUpdate.Parameters.AddWithValue("@GiaBan", gia);
                    cmdUpdate.Parameters.AddWithValue("@MaSP", maSP);

                    cmdUpdate.ExecuteNonQuery();
                }

                // Nếu chưa có -> INSERT
                else
                {
                    string insertSql = @"
        INSERT INTO SanPhamDangBan
        VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongBan)";

                    SqlCommand cmdInsert = new SqlCommand(insertSql, con, trans);

                    cmdInsert.Parameters.AddWithValue("@MaSP", maSP);
                    cmdInsert.Parameters.AddWithValue("@TenSP", tenSP);
                    cmdInsert.Parameters.AddWithValue("@GiaBan", gia);
                    cmdInsert.Parameters.AddWithValue("@SoLuongBan", soLuongBan);

                    cmdInsert.ExecuteNonQuery();
                }

                // Trừ kho
                string updateKhoSql = @"
    UPDATE SanPhamTrongKho
    SET SoLuongTrongKho -= @SoLuongBan
    WHERE MaSP = @MaSP";

                SqlCommand cmdKho = new SqlCommand(updateKhoSql, con, trans);

                cmdKho.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                cmdKho.Parameters.AddWithValue("@MaSP", maSP);

                cmdKho.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            // Cập nhật RAM sau khi DB thành công
            DataRow[] foundGrid = dtSanPhamDangBan.Select($"MaSP = '{maSP}'");
            if (foundGrid.Length > 0)
            {
                foundGrid[0]["SoLuongDangBan"] = Convert.ToInt32(foundGrid[0]["SoLuongDangBan"]) + soLuongBan;
                foundGrid[0]["GiaBan"] = gia;
            }
            else
            {
                DataRow newRow = dtSanPhamDangBan.NewRow();
                newRow["MaSP"] = maSP;
                newRow["TenSP"] = tenSP;
                newRow["GiaBan"] = gia;
                newRow["SoLuongDangBan"] = soLuongBan;
                dtSanPhamDangBan.Rows.Add(newRow);
            }

            // Trừ tồn kho RAM
            foundKho[0]["SoLuongTrongKho"] = soLuongTon - soLuongBan;

            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGia_tab1.Clear();
            slban.Clear();
            cbSanPham.SelectedIndex = 0;
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPhamDuocBan_tab1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_tab1_Click(object sender, EventArgs e)
        {
            if (dgvSanPhamDuocBan_tab1.CurrentRow == null) return;

            string maSP = dgvSanPhamDuocBan_tab1.CurrentRow.Cells["colMa"].Value?.ToString();
         

          

            // Xóa DB
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string deleteCmd = "DELETE FROM SanPhamDangBan WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(deleteCmd, con))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            // Xóa RAM
            DataRow[] foundGrid = dtSanPhamDangBan.Select($"MaSP = '{maSP}'");
            if (foundGrid.Length > 0)
                foundGrid[0].Delete();

            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGia_tab1.Clear();
            slban.Clear();
            cbSanPham.SelectedIndex = 0;
        }

        private void dgvSanPhamDuocBan_tab1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPhamDuocBan_tab1.Rows[e.RowIndex];

            string maSP = row.Cells["colMa"].Value?.ToString();
            cbSanPham.SelectedValue = maSP;
            txtGia_tab1.Text = row.Cells["colGia_tab1"].Value?.ToString();
            slban.Text = row.Cells["colSoLuongBan_tab1"].Value?.ToString();
        }

        private void btnTim_tab1_Click(object sender, EventArgs e)
        {
            string keyword = txtTim_tab1.Text.Trim();

            

            // Lọc theo TenSP chứa từ khóa (không phân biệt hoa thường)
            dtSanPhamDangBan.DefaultView.RowFilter = $"TenSP LIKE '%{keyword}%'";
        }

        private void txtTim_tab1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim_tab1.Text))
                dtSanPhamDangBan.DefaultView.RowFilter = "";
        }
        // Trọng Nghĩa 
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

                // Cập nhật tab 1 trước khi clear giỏ hàng
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

