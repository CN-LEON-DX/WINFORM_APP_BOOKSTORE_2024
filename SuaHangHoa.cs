using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BTL_WINFORM_2024
{
    public partial class SuaHangHoa : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public SuaHangHoa()
        {
            InitializeComponent();
            LoadDataIntoCB1();
            LoadDataIntoCB2();
        }
        private void EnableThemIfValid()
        {
            bool isMahangFilled = CB_MaMH.SelectedIndex != -1;
            bool isTenhangFilled = !string.IsNullOrEmpty(TB_TenMH.Text);
            bool isSLFilled = !string.IsNullOrEmpty(TB_Soluong.Text);
            bool isgiaFilled = !string.IsNullOrEmpty(TB_Giaban.Text);
            bool isdonvitinhFilled = !string.IsNullOrEmpty(TB_DVT.Text);
            bool isComboBoxSelected = CB_LoaiHH.SelectedIndex != -1;

            // Kích hoạt button nếu cả hai điều kiện đều đúng
            BT_Sua.Enabled = isMahangFilled && isTenhangFilled && isComboBoxSelected && isSLFilled && isdonvitinhFilled && isgiaFilled;
        }
        private void LoadDataIntoCB1()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sMaMH FROM tblHangHoa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CB_MaMH.Items.Add(reader["sMaMH"]).ToString();
                        }
                    }
                }

            }
        }
        private void LoadDataIntoCB2()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string querysl = "SELECT sTenHH FROM tblLoaiHangHoa ";
                using (SqlCommand cmd = new SqlCommand(querysl, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CB_LoaiHH.Items.Add(dr["sTenHH"].ToString());
                        }
                    }
                }
            }

        }
        private string LayTenLHtuMa(string MaLH)
        {
            string TenLH;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sTenHH FROM tblLoaiHangHoa WHERE sMaLH = @Ma";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Ma", MaLH);
                    object id = cmd.ExecuteScalar();
                    TenLH = id.ToString();
                }
            }

            return TenLH;
        }

        private void CB_MaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CB_MaMH.Text))
            {
                string MaMH = CB_MaMH.SelectedItem.ToString();
                string query = "SELECT * FROM tblHangHoa WHERE sMaMH = @ma";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ma", MaMH);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                TB_TenMH.Text = dr["sTenMH"].ToString();
                                TB_Giaban.Text = dr["fGia"].ToString();
                                TB_Soluong.Text = dr["fSoluong"].ToString();
                                TB_DVT.Text = dr["sDVT"].ToString();
                                string MaLH = dr["sMaLH"].ToString();
                                CB_LoaiHH.Text = LayTenLHtuMa(MaLH);
                            }

                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Lựa chọn mã hàng hóa để sửa đổi thông tin");
            }
            EnableThemIfValid();
        }

        private void TB_Giaban_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Giaban.Text))
            {
                // Kiểm tra xem dữ liệu nhập vào có phải là số hay không
                if (!float.TryParse(TB_Giaban.Text, out float number))
                {
                    // Nếu dữ liệu không phải là số, xóa ký tự vừa nhập và hiển thị thông báo
                    MessageBox.Show("Bạn chỉ được nhập số lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_Giaban.Text = TB_Giaban.Text.Substring(0, TB_Giaban.Text.Length - 1);
                    TB_Giaban.SelectionStart = TB_Giaban.Text.Length;
                    return;
                }

                // Kiểm tra xem số nhập vào có lớn hơn 0 hay không
                if (number <= 0)
                {
                    // Nếu số nhập vào không lớn hơn 0, hiển thị thông báo và xóa dữ liệu
                    MessageBox.Show("Bạn chỉ được nhập số nguyên lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_Giaban.Clear();
                    return;
                }
            }
            EnableThemIfValid();
        }

        private void TB_Soluong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Soluong.Text))
            {
                // Kiểm tra xem dữ liệu nhập vào có phải là số hay không
                if (!float.TryParse(TB_Soluong.Text, out float number))
                {
                    // Nếu dữ liệu không phải là số, xóa ký tự vừa nhập và hiển thị thông báo
                    MessageBox.Show("Bạn chỉ được nhập số lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_Soluong.Text = TB_Soluong.Text.Substring(0, TB_Soluong.Text.Length - 1);
                    TB_Soluong.SelectionStart = TB_Soluong.Text.Length;
                    return;
                }

                // Kiểm tra xem số nhập vào có lớn hơn 0 hay không
                if (number <= 0)
                {
                    // Nếu số nhập vào không lớn hơn 0, hiển thị thông báo và xóa dữ liệu
                    MessageBox.Show("Bạn chỉ được nhập số nguyên lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_Soluong.Clear();
                    return;
                }
            }
            EnableThemIfValid();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            CB_LoaiHH.SelectedIndex = -1;
            TB_TenMH.Clear();
            TB_Soluong.Clear();
            TB_DVT.Clear();
            TB_Giaban.Clear();
            CB_MaMH.SelectedIndex = -1;
        }

        private void CB_LoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableThemIfValid();
        }

        private void TB_TenMH_TextChanged(object sender, EventArgs e)
        {
            EnableThemIfValid();
        }

        private void TB_DVT_TextChanged(object sender, EventArgs e)
        {
            EnableThemIfValid();
        }
        private string LayMaLHtuTen(string TenLH)
        {
            string MaLH;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sMaLH FROM tblLoaiHangHoa WHERE sTenHH = @ten";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ten", TenLH);
                    object id = cmd.ExecuteScalar();
                    MaLH = id.ToString();
                }

            }
            return MaLH;
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            string MaMH = CB_MaMH.SelectedItem.ToString();
            string MaLH = LayMaLHtuTen(CB_LoaiHH.SelectedItem.ToString());
            string TenMH = TB_TenMH.Text;
            double Gia = Convert.ToDouble(TB_Giaban.Text);
            double Soluong = Convert.ToDouble(TB_Soluong.Text);
            string DVT = TB_DVT.Text;
            string query = "UPDATE tblHangHoa\r\nSET sMaLH = @malh,\r\n\tsTenMH = @tenmh,\r\n\tfGia = @gia,\r\n\tfSoluong = @so,\r\n\tsDVT = @dvt\r\nWHERE sMaMH = @mamh";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@malh", MaLH);
                    cmd.Parameters.AddWithValue("@tenmh", TenMH);
                    cmd.Parameters.AddWithValue("@gia", Gia);
                    cmd.Parameters.AddWithValue("@so", Soluong);
                    cmd.Parameters.AddWithValue("@dvt", DVT);
                    cmd.Parameters.AddWithValue("@mamh", MaMH);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }

            }
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_TenMH_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_TenMH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
                TB_TenMH.Focus();
            }
        }

        private void TB_DVT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_DVT.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
                TB_DVT.Focus();
            }
        }

        private void TB_Giaban_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Giaban.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
                TB_Giaban.Focus();
            }
        }

        private void TB_Soluong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Giaban.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
                TB_Giaban.Focus();
            }
        }
    }
}
