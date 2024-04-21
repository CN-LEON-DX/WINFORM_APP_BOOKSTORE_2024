using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WINFORM_2024
{
    public partial class ThemKhachHang : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["ConnectionStringBTL"]
            .ConnectionString;
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void AddNewClientToDatabase(string makh, string tenkh, string diachi, string sdt, int gioitinh)
        {
            string query = "INSERT INTO tblKhachHang (sMaKH, sTenKH, sDiaChi, sSoDT, bGioiTinh) VALUES (@makh, @tenkh, @diachi, @sdt, @gioitinh)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@makh", makh);
                    command.Parameters.AddWithValue("@tenkh", tenkh);
                    command.Parameters.AddWithValue("@gioitinh", gioitinh);
                    command.Parameters.AddWithValue("@diachi", diachi);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public string GenerateNewClientID()
        {
            int lastIndex = GetLastIndex();
            // Tạo mã khách hàng mới
            string newClientID = "KH" + (lastIndex + 1).ToString("D3");

            return newClientID;
        }
        private int GetLastIndex()
        {
            int lastIndex = 0;
            string query = "SELECT TOP 1 sMaKH FROM tblKhachHang ORDER BY sMaKH DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string lastClientID = reader["sMaKH"].ToString();
                        string indexString = lastClientID.Substring(2); // Bỏ qua hai ký tự đầu tiên (chữ "NV")
                        lastIndex = int.Parse(indexString);
                    }
                }
            }

            return lastIndex;
        }
        private void enable_btn_them()
        {
            if (string.IsNullOrEmpty(tb_TenKH.Text))
            {
                btn_Them.Enabled = false;
                return;
            }
            if (string.IsNullOrEmpty(tb_DiaChi.Text))
            {
                btn_Them.Enabled = false;
                return;
            }
            if (string.IsNullOrEmpty(tb_Sdt.Text))
            {
                btn_Them.Enabled = false;
                return;
            }
            btn_Them.Enabled = true;
            return;
        }

        private void tb_TenKH_TextChanged(object sender, EventArgs e)
        {
            enable_btn_them();
        }

        private void tb_DiaChi_TextChanged(object sender, EventArgs e)
        {
            enable_btn_them();
        }

        private void tb_Sdt_TextChanged(object sender, EventArgs e)
        {
            enable_btn_them();
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            rb_Nam.Checked = true;
            btn_Them.Enabled = false;
        }

        private void tb_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, hủy sự kiện KeyPress
                e.Handled = true;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            tb_TenKH.Text = "";
            tb_DiaChi.Text = "";
            tb_Sdt.Text = "";
            rb_Nam.Checked = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string makh = GenerateNewClientID();

            int gioitinh = rb_Nam.Checked ? 1 : 0;
            string tenkh = tb_TenKH.Text;
            string diachi = tb_DiaChi.Text;
            string sdt = tb_Sdt.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                makh = GenerateNewClientID();
                AddNewClientToDatabase(makh, tenkh, diachi, sdt, gioitinh);

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm mới khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
