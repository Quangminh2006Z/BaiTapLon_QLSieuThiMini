namespace BaiTapLon_QLSieuThiMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show(
                    "Khong ket noi duoc database!\n" +
                    "Hay chay file Database.sql trong SSMS truoc.",
                    "Loi ket noi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ket noi thanh cong!",
                                "OK",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
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
    }
}
