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
        DataTable dtSanPhamDangBan = new DataTable();


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
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maSP = cbSanPham.SelectedValue.ToString();

            // Cập nhật DB
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string updateCmd = @"UPDATE SanPhamDangBan 
                            SET GiaBan = @GiaBan, SoLuongDangBan = @SoLuongBan
                            WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(updateCmd, con))
                {
                    cmd.Parameters.AddWithValue("@GiaBan", gia);
                    cmd.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
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

            // Cập nhật RAM
            DataRow[] foundGrid = dtSanPhamDangBan.Select($"MaSP = '{maSP}'");
            if (foundGrid.Length > 0)
            {
                foundGrid[0]["GiaBan"] = gia;
                foundGrid[0]["SoLuongDangBan"] = soLuongBan;
            }

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (con.State == ConnectionState.Closed) con.Open();

                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        string checkCmd = "SELECT COUNT(*) FROM SanPhamDangBan WHERE MaSP = @MaSP";
                        using (SqlCommand cmdCheck = new SqlCommand(checkCmd, con, trans))
                        {
                            cmdCheck.Parameters.AddWithValue("@MaSP", maSP);
                            int count = (int)cmdCheck.ExecuteScalar();

                            if (count > 0)
                            {
                                string updateCmd = @"UPDATE SanPhamDangBan 
                                            SET SoLuongDangBan = SoLuongDangBan + @SoLuongBan,
                                                GiaBan = @GiaBan
                                            WHERE MaSP = @MaSP";
                                using (SqlCommand cmdUpdate = new SqlCommand(updateCmd, con, trans))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@SoLuongBan", soLuongBan);

                                    cmdUpdate.Parameters.AddWithValue("@GiaBan", gia);
                                    cmdUpdate.Parameters.AddWithValue("@MaSP", maSP);
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string insertCmd = @"INSERT INTO SanPhamDangBan (MaSP, TenSP, GiaBan, SoLuongDangBan) 
                                            VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongBan)";
                                using (SqlCommand cmdInsert = new SqlCommand(insertCmd, con, trans))
                                {
                                    cmdInsert.Parameters.AddWithValue("@MaSP", maSP);
                                    cmdInsert.Parameters.AddWithValue("@TenSP", tenSP);
                                    cmdInsert.Parameters.AddWithValue("@GiaBan", gia);
                                    cmdInsert.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }

                            string updateKhoCmd = @"UPDATE SanPhamTrongKho 
                                           SET SoLuongTrongKho = SoLuongTrongKho - @SoLuongBan 
                                           WHERE MaSP = @MaSP";
                            using (SqlCommand cmdUpdateKho = new SqlCommand(updateKhoCmd, con, trans))
                            {
                                cmdUpdateKho.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                                cmdUpdateKho.Parameters.AddWithValue("@MaSP", maSP);
                                cmdUpdateKho.ExecuteNonQuery();
                            }

                            trans.Commit();
                        }
                    }
                    catch (Exception exTrans)
                    {
                        trans.Rollback();
                        throw exTrans;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu vào database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
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
            if (string.IsNullOrEmpty(maSP)) return;

            if (MessageBox.Show($"Xác nhận xóa sản phẩm {maSP}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

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

            if (string.IsNullOrWhiteSpace(keyword))
            {
                // Nếu trống thì hiện lại toàn bộ
                dtSanPhamDangBan.DefaultView.RowFilter = "";
                return;
            }

            // Lọc theo TenSP chứa từ khóa (không phân biệt hoa thường)
            dtSanPhamDangBan.DefaultView.RowFilter = $"TenSP LIKE '%{keyword}%'";
        }

        private void txtTim_tab1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim_tab1.Text))
                dtSanPhamDangBan.DefaultView.RowFilter = "";
        }
    }
}

