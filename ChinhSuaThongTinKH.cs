using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_WINFORM_2024
{
    public partial class ChinhSuaThongTinKH : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["ConnectionStringBTL"]
            .ConnectionString;
        string makh, tenkh, diachi, sdt;
        bool gioitinh;

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ChinhSuaThongTinKH(string makh, string tenkh, string diachi, string sdt, bool gioitinh)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
            InitializeComponent();
        }
        private void ChinhSuaThongTinKH_Load(object sender, EventArgs e)
        {
            tb_TenKh.Text = tenkh;
            tb_DiaChi.Text = diachi;
            tb_Sdt.Text = sdt;
            if (gioitinh == true)
            {
                rb_Nam.Checked = true;
                rb_Nu.Checked = false;

            }
            else
            {
                rb_Nam.Checked = false;
                rb_Nu.Checked = true;
            }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int gioitinh = rb_Nam.Checked ? 1 : 0;
            string tenkh = tb_TenKh.Text;
            string diachi = tb_DiaChi.Text;
            string sdt = tb_Sdt.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc sửa thông tin khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                    string updateQuery = "UPDATE tblKhachHang SET sTenKH = @tenkh, sDiaChi = @diachi, sSoDT = @sdt, bGioiTinh = @gioitinh WHERE sMaKH = @makh";

                    // Mở kết nối đến cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Tạo đối tượng SqlCommand và thiết lập tham số cho câu lệnh SQL
                        using (SqlCommand command = conn.CreateCommand())
                        {
                        command.CommandText = updateQuery;
                            command.Parameters.AddWithValue("@makh", makh);
                            command.Parameters.AddWithValue("@tenkh", tenkh);
                            command.Parameters.AddWithValue("@diachi", diachi);
                            command.Parameters.AddWithValue("@sdt", sdt);
                            command.Parameters.AddWithValue("gioitinh", gioitinh);
                            int a = command.ExecuteNonQuery();
                            if (a > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin khách hàng không thành công", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }
            }
        }

    }
}
