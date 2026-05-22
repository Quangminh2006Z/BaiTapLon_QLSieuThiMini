using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_QLSieuThiMini
{
    public static class DatabaseHelper
    {
        // ================================================
        // Connection string dung chung cho ca nhom
        // Dung (localdb)\MSSQLLocalDB - co san khi cai VS
        // KHONG doi thanh ten may ca nhan
        // ================================================
        private static readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;" +
             "Initial Catalog=QLSieuThiMini;" +
             "Integrated Security=True;" +
             "Connect Timeout=30;";

        // Lay connection - moi nguoi dung trong form cua minh
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Kiem tra ket noi - goi khi khoi dong app
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Chay lenh INSERT / UPDATE / DELETE
        // Nguoi 1 va Nguoi 2 dung ham nay
        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi truy van: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return -1;
            }
        }

        // Chay lenh SELECT, tra ve DataTable
        // Dung de load vao DataGridView
        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    var table = new DataTable();
                    conn.Open();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi truy van: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
        }

        // Chay lenh SELECT, tra ve 1 gia tri duy nhat
        // Vi du: SELECT COUNT(*), SELECT SUM(TongTien)
        // Nguoi 3 dung ham nay cho thong ke
        public static object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi truy van: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
        }
    }
}