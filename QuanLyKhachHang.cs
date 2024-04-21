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
                                // Tôi muốn thay đổi giới tính sang nam hoặc nữ thì làm ntn trong dt ?
                                //nếu bGioiTinh == true => Nam else Nữ 
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
                            tb_Email.Text = reader["sEmail"].ToString();
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (cb_MaKH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa thông tin");
            }
            else
            {
                string makh = cb_MaKH.Text.ToString();
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
                        tb_Email.Text = row["sEmail"].ToString();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string query = "Delete_Infor_Customer";
            if (cb_MaKH.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa");
            }
            else
            {
                string sMaKH_delete = cb_MaKH.SelectedItem.ToString();
                Console.WriteLine(sMaKH_delete);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@sMaKH_delete", sMaKH_delete);

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
                                    tb_Email.Text = "";
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
            string gioiTinh = tb_GioiTinh.Text.Trim().ToLower();
            string email = tb_Email.Text.Trim();

            string filter = ConstructFilter(hoTen, diaChi, soDienThoai, gioiTinh, email);
            ShowData(filter);
        }

        private string ConstructFilter(string hoTen, string diaChi, string soDienThoai, string gioiTinh, string email)
        {
            string filter = "1 = 1"; // Tạo một điều kiện luôn đúng để bắt đầu xây dựng filter

            if (!string.IsNullOrEmpty(hoTen))
            {
                filter += " AND sTenKH LIKE '%" + hoTen + "%'";
            }
            if (!string.IsNullOrEmpty(diaChi))
            {
                filter += " AND sDiaChi LIKE '%" + diaChi + "%'";
            }
            if (!string.IsNullOrEmpty(soDienThoai))
            {
                filter += " AND sSoDT LIKE '%" + soDienThoai + "%'";
            }
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                if (gioiTinh == "nam")
                    filter += " AND bGioiTinh = 1";
                else if (gioiTinh == "nữ")
                    filter += " AND bGioiTinh = 0";
            }
            if (!string.IsNullOrEmpty(email))
            {
                filter += " AND sEmail LIKE '%" + email + "%'";
            }

            return filter;
        }

        private void ShowData(string filter)
        {
            string querySelect = "SELECT * FROM tblKhachHang WHERE " + filter;

            using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnetion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgv_DanhSachKH.DataSource = table;
                    }
                }
            }
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

        private void dgv_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DanhSachKH.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_DanhSachKH.SelectedRows[0];
                cb_MaKH.Text = selectedRow.Cells["sMaKH"].Value.ToString();
                tb_TenKH.Text = selectedRow.Cells["sTenKH"].Value.ToString();
                tb_DiaChi.Text = selectedRow.Cells["sDiaChi"].Value.ToString();
                tb_Sdt.Text = selectedRow.Cells["sSoDT"].Value.ToString();
                bool gioiTinh = (bool)selectedRow.Cells["bGioiTinh"].Value;
                tb_GioiTinh.Text = gioiTinh ? "Nam" : "Nữ";
                tb_Email.Text = selectedRow.Cells["sEmail"].Value.ToString();
            }
        }

        private void bt_ThongKeEmail_Click(object sender, EventArgs e)
        {
            // chuyển sang form báo cáo
            string email = tb_Email.Text.ToString();
            string customer_name = tb_TenKH.Text.ToString();
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(customer_name))
            {
                FormBaoCao formReport = new FormBaoCao();
                formReport.Show();
                formReport.ShowReport_DS_Email("CR_DSMH_Email.rpt", "Select_Infor_Email_Report", email, customer_name);
            }else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng !.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
