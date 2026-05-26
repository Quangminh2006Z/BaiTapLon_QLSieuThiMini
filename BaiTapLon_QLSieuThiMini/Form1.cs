using Microsoft.Data.SqlClient;
using System.Data;

namespace BaiTapLon_QLSieuThiMini
{
    public partial class Form1 : Form
    {
        //Các biến tương tác csdl
        string connectedString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adt = new SqlDataAdapter();
        SqlCommand cmd;

        //Các biến lưu thông tin các bảng
        DataTable dtLichSuNhap = new DataTable();
        DataTable dtKhoHang = new DataTable();
        
        public Form1()
        {
            InitializeComponent();

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
                SqlCommand cmdKhoHang = new SqlCommand("Select * from SanPhamTrongKho",con);
                SqlDataAdapter adtKhoHang = new SqlDataAdapter(cmdKhoHang);
                adtKhoHang.Fill(dtKhoHang);
                tableKhoHang.DataSource = dtKhoHang;

                //Đóng kết nối 
                con.Close();
            }
            catch(Exception ex)
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
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            // Ép kiểu để tính Thành Tiền
            if (int.TryParse(textBoxForSoLuong.Text, out int soLuong) && int.TryParse(textBoxForDonGia.Text, out int donGia))
            {
                int thanhTien = soLuong * donGia;
                string maSP = textBoxForMaSP.Text.Trim();
                string tenSP = textBoxForTenSP.Text.Trim();
                string maPN = textBoxForMaPN.Text.Trim();
                DateTime ngayNhap = DateTime.Now;
                //Mảng lưu thông tin các mã sản phẩm sẵn có bằng cách duyệt qua các MaSP
                DataRow[] foundRowMaSP = dtKhoHang.Select($"MaSP = '{textBoxForMaSP.Text.Trim()}'");

                //Nếu mã sản phẩm đã tồn tại ( Mảng tìm được >0 sản phẩm)
                if(foundRowMaSP.Length > 0) {

                // Nếu sản phẩm đã tồn tại, tiến hành cộng dồn số lượng

                int soLuongHienTai = Convert.ToInt32(foundRowMaSP[0]["SoLuongTrongKho"]);
                foundRowMaSP[0]["SoLuongTrongKho"] = soLuongHienTai + soLuong;
                MessageBox.Show("Vì sản phẩm đã có sẵn, số lượng tồn được cộng thêm!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Phiếu nhập sẽ không được thêm vào bảng", "Mã phiếu nhập đã tồn tại!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { 
                DataRow newLichSuNhapRow = dtLichSuNhap.NewRow();
                newLichSuNhapRow["MaPN"] = textBoxForMaPN.Text;
                newLichSuNhapRow["MaSP"] = textBoxForMaSP.Text;
                newLichSuNhapRow["TenSP"] = textBoxForTenSP.Text;
                newLichSuNhapRow["ThanhTien"] = thanhTien;
                newLichSuNhapRow["NgayNhap"] = DateTime.Now;
                dtLichSuNhap.Rows.Add(newLichSuNhapRow);
                }
                MessageBox.Show("Dữ liệu đã được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
