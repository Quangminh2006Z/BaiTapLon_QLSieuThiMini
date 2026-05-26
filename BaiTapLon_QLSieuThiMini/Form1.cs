using Microsoft.Data.SqlClient;
using System.Data;

namespace BaiTapLon_QLSieuThiMini
{
    public partial class Form1 : Form
    {
        string connectedString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSieuThi;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adt = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        
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

            con = new SqlConnection(connectedString);
            try
            {
                con.Open();
                // Thay đổi câu truy vấn để SQL tự tính Thành tiền = Số Lượng * Cột Giá Nhập (Tuỳ tên cột bạn đang lưu tên là gì, ở đây lấy theo SoLuongNhap và GiaNhap trong DB)
                cmd = new SqlCommand("Select *, (SoLuongNhap * GiaNhap) as ThanhTien from LichSuNhapHang", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                tableLichSuNhap.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
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
                decimal thanhTien = soLuong * donGia;

                // Thêm vào bảng Kho Hàng
                tableKhoHang.Rows.Add(textBoxForMaSP.Text, textBoxForTenSP.Text, textBoxForSoLuong.Text);

                // Ở đây, nếu tableLichSuNhap đã được set DataSource = dt, bạn phải thao tác add qua dt (kiểu dt.Rows.Add(...)) 
                // Thay vì tableLichSuNhap.Rows.Add() sẽ gây lỗi databinding.
                // Nếu chưa bind, code hiển thị sẽ như sau:
                // tableLichSuNhap.Rows.Add(textBoxForMaPN.Text, textBoxForMaSP.Text, textBoxForTenSP.Text, thanhTien, DateTime.Now.ToString("dd/MM/yyyy"));
            }
            else
            {
                MessageBox.Show("Số lượng và Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
