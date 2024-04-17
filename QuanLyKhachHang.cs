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
    public partial class QuanLyKhachHang : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["ConnectionStringBTL"]
            .ConnectionString;
        string currentID = "";
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection (connectionString))
                {
                    using(SqlCommand cmd = conn.CreateCommand ())
                    {
                        cmd.CommandText = "Select sMaKH from tblKhachHang";
                        conn.Open ();
                        using(SqlDataReader reader = cmd.ExecuteReader ())
                        {
                            while (reader.Read ())
                            {
                                cb_MaKH.Items.Add(reader["sMaKH"].ToString ());
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loaddatagridview()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "Select * from tblKhachHang";
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using(SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using(DataTable dt = new DataTable(sql))
                            {
                                adapter.Fill (dt);
                                dgv_DanhSachKH.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddatagridview();
        }

        /*private void cb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = cb_MaKH.SelectedItem.ToString ();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "Select * from tblKhachHang where sMaKH = @makh";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@makh", makh);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_TenKH.Text = reader["sTenKH"].ToString();
                            tb_DiaChi.Text = reader["sDiaChi"].ToString();
                            tb_Sdt.Text = reader["sSoDT"].ToString();
                            tb_GioiTinh.Text = (bool)reader["bGioiTinh"] ? "Nam" : "Nữ";
                        }
                    }
                }
            }
        }*/

        private void btn_DanhSachMua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_MaKH.Text))
            {
                MessageBox.Show("Chưa chọn mã khách hàng");
            }
            else
            {
                FormBaoCao f = new FormBaoCao();
                f.Show();
                f.ShowReportDSMuaHang(cb_MaKH.Text);
            }
            
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            FormBaoCao f = new FormBaoCao();
            f.Show();
            f.ShowReportDSMuaHang_Ngay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemKhachHang form = new ThemKhachHang();
            form.FormClosed += FormB_FormClosed;
            form.ShowDialog();
        }
        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            loaddatagridview();
            cb_MaKH.Items.Clear();
            loaddata();
        }
        private void cb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = cb_MaKH.SelectedItem.ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "Select * from tblKhachHang where sMaKH = @makh";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@makh", makh);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_TenKH.Text = reader["sTenKH"].ToString();
                            tb_DiaChi.Text = reader["sDiaChi"].ToString();
                            tb_Sdt.Text = reader["sSoDT"].ToString();
                            tb_GioiTinh.Text = (bool)reader["bGioiTinh"] ? "Nam" : "Nữ";
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(cb_MaKH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa thông tin");
            }
            else
            {
                string makh = cb_MaKH.ToString();
                string tenkh = tb_TenKH.Text.ToString();
                string sdt = tb_Sdt.Text.ToString();
                string diachi = tb_DiaChi.Text.ToString();
                bool gioitinh = tb_GioiTinh.Text.ToString() == "Nam" ? true : false;

                ChinhSuaThongTinKH form_next = new ChinhSuaThongTinKH(makh, tenkh, diachi, sdt, gioitinh);
                form_next.FormClosing += Form_next_FormClosing;
                form_next.ShowDialog();
            }
        }

        private void Form_next_FormClosing(object sender, FormClosingEventArgs e)
        {
            // sau khi chinh sua xong thi load lai form
            UpdateInfor(currentID);
            loaddatagridview();
        }

        private void UpdateInfor(string currentID)
        {
            string user_id = currentID;
            string query = "SELECT * FROM tblKhachHang WHERE sMaKH = @makh";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makh", user_id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0]; // Chỉ lấy dòng đầu tiên
                                                         // Hiển thị thông tin nhân viên trên các Label
                        currentID = row["sMaKH"].ToString();
                        tb_TenKH.Text = row["sTenKH"].ToString();
                        tb_DiaChi.Text = row["sDiaChi"].ToString();
                        tb_GioiTinh.Text = (bool)row["bGioiTinh"] ? "Nam" : "Nữ";
                        tb_Sdt.Text = row["sSoDT"].ToString();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(cb_MaKH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa");
            }
            else
            {
                string makh = cb_MaKH.Text;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            using (SqlCommand command = new SqlCommand("Delete from tblKhachHang where sMaKH = @makh", conn))
                            {
                                command.Parameters.AddWithValue("@makh", makh);

                                // Thực thi stored procedure
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Khách hàng đã được xóa thành công.", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loaddatagridview();
                                    cb_MaKH.Items.Clear();
                                    cb_MaKH.Text = "";
                                    tb_TenKH.Text = "";
                                    tb_DiaChi.Text = "";
                                    tb_Sdt.Text = "";
                                    tb_GioiTinh.Text = "";
                                    loaddata();
                                }
                                else
                                {
                                    MessageBox.Show("Xóa khách hàng không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string hoTen = tb_TenKH.Text.Trim();
            string diaChi = tb_DiaChi.Text.Trim();
            string soDienThoai = tb_Sdt.Text.Trim();
            string gioiTinh = tb_GioiTinh.Text.Trim().ToLower(); // Chuyển đổi giới tính thành chữ thường để đảm bảo tính nhất quán

            // Kiểm tra xem tất cả bốn ô nhập liệu có đều trống không
            if (string.IsNullOrEmpty(hoTen) && string.IsNullOrEmpty(diaChi) && string.IsNullOrEmpty(soDienThoai) && string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Không thực hiện tìm kiếm nếu không có tiêu chí nào được cung cấp
            }

            // Tiếp tục với quá trình tìm kiếm nếu có ít nhất một tiêu chí được cung cấp
            string query = "SELECT * FROM tblKhachHang WHERE";
            bool isFirstCondition = true;
            if (!string.IsNullOrEmpty(hoTen))
            {
                query += " sTenKH LIKE @hoTen";
                isFirstCondition = false;
            }
            if (!string.IsNullOrEmpty(diaChi))
            {
                if (!isFirstCondition)
                    query += " AND";
                query += " sDiaChi LIKE @diaChi";
                isFirstCondition = false;
            }
            if (!string.IsNullOrEmpty(soDienThoai))
            {
                if (!isFirstCondition)
                    query += " AND";
                query += " sSoDT LIKE @soDienThoai";
                isFirstCondition = false;
            }
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                if (!isFirstCondition)
                    query += " AND";
                // Xác định giới tính từ người dùng và chuyển đổi thành dữ liệu BIT tương ứng
                query += " bGioiTinh = @gioiTinh";
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();

            if (!string.IsNullOrEmpty(hoTen))
                adapter.SelectCommand.Parameters.AddWithValue("@hoTen", "%" + hoTen + "%");
            if (!string.IsNullOrEmpty(diaChi))
                adapter.SelectCommand.Parameters.AddWithValue("@diaChi", "%" + diaChi + "%");
            if (!string.IsNullOrEmpty(soDienThoai))
                adapter.SelectCommand.Parameters.AddWithValue("@soDienThoai", "%" + soDienThoai + "%");
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                // Ánh xạ giới tính từ chuỗi người dùng sang dữ liệu BIT
                if (gioiTinh == "nam")
                    adapter.SelectCommand.Parameters.AddWithValue("@gioiTinh", 1);
                else if (gioiTinh == "nữ")
                    adapter.SelectCommand.Parameters.AddWithValue("@gioiTinh", 0);
                else
                {
                    MessageBox.Show("Giới tính chỉ có thể là 'Nam' hoặc 'Nữ'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Không thực hiện tìm kiếm nếu giới tính không hợp lệ
                }
            }

            con.Open();
            adapter.Fill(table);
            con.Close();

            dgv_DanhSachKH.DataSource = table;
        }

        private void dgv_DanhSachKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = this.dgv_DanhSachKH.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Kiểm tra giá trị bit
                if (cell.Value != null && cell.Value is bool)
                {
                    bool gioiTinh = (bool)cell.Value;

                    // Chuyển đổi giá trị bit thành văn bản
                    if (gioiTinh)
                    {
                        e.Value = "Nam";
                    }
                    else
                    {
                        e.Value = "Nữ";
                    }
                }
            }
        }
    }
}
