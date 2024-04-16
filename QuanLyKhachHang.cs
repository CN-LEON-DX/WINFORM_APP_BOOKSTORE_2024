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

        private void cb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
