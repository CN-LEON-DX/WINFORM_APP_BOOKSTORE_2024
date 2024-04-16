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
    public partial class NhapHangHoa : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public NhapHangHoa()
        {
            InitializeComponent();
            BT_Themmoi.Enabled = false;
            LoadDataIntoCBLH();
        }
        private void EnableThemIfValid()
        {
            bool isTenhangFilled = !string.IsNullOrEmpty(TB_TenMH.Text);
            bool isSLFilled = !string.IsNullOrEmpty(TB_Soluong.Text);
            bool isgiaFilled = !string.IsNullOrEmpty(TB_Gia.Text);
            bool isdonvitinhFilled = !string.IsNullOrEmpty(TB_DVT.Text);
            bool isComboBoxSelected = CB_LoaiHang.SelectedIndex != -1;

            // Kích hoạt button nếu cả hai điều kiện đều đúng
            BT_Themmoi.Enabled = isTenhangFilled && isComboBoxSelected && isSLFilled && isdonvitinhFilled && isgiaFilled;
        }
        private void LoadDataIntoCBLH()
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
                            CB_LoaiHang.Items.Add(dr["sTenHH"].ToString());
                        }
                    }
                }
            }
        }

        private void TB_Gia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Gia.Text))
            {
                // Kiểm tra xem dữ liệu nhập vào có phải là số hay không
                if (!float.TryParse(TB_Gia.Text, out float number))
                {
                    // Nếu dữ liệu không phải là số, xóa ký tự vừa nhập và hiển thị thông báo
                    MessageBox.Show("Bạn chỉ được nhập số lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_Gia.Text = TB_Gia.Text.Substring(0, TB_Gia.Text.Length - 1);
                    TB_Gia.SelectionStart = TB_Gia.Text.Length;
                    return;
                }

                // Kiểm tra xem số nhập vào có lớn hơn 0 hay không
                if (number <= 0)
                {
                    // Nếu số nhập vào không lớn hơn 0, hiển thị thông báo và xóa dữ liệu
                    MessageBox.Show("Bạn chỉ được nhập số nguyên lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_Gia.Clear();
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
        private int Laymacuoicung()
        {
            int lastIndex = 0;
            string query = "SELECT TOP 1 sMaMH FROM tblHangHoa ORDER BY sMaMH DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string MaMHcuoi = reader["sMaMH"].ToString();
                        string indexString = MaMHcuoi.Substring(2); // Bỏ qua hai ký tự đầu tiên (chữ "NV")
                        lastIndex = int.Parse(indexString);
                    }
                }
            }

            return lastIndex;
        }
        private string TaoMaMHTD()
        {
            int lastIndex = Laymacuoicung();
            // Tạo mã nhân viên mới
            string MaMHmoi = "MH" + (lastIndex + 1).ToString("D3");

            return MaMHmoi;
        }
        private string LayMaloaihangtuten(string tenLH)
        {
            string MaLH;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sMaLH FROM tblLoaiHangHoa WHERE sTenHH = @ten";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ten", tenLH);
                    object id = cmd.ExecuteScalar();
                    MaLH = id.ToString();
                }

            }
            return MaLH;
        }

        private void BT_Themmoi_Click(object sender, EventArgs e)
        {
            string MaMH = TaoMaMHTD();
            string MaLH = LayMaloaihangtuten(CB_LoaiHang.SelectedItem.ToString());
            // Xử lý mã loại hàng
            string TenMH = TB_TenMH.Text.ToString();
            int Gia = Convert.ToInt32(TB_Gia.Text);
            int Soluong = Convert.ToInt32(TB_Soluong.Text);
            string DVT = TB_DVT.Text.ToString();
            string query = "INSERT INTO tblHangHoa VALUES(@ma,@loai,@ten,@gia,@soluong,@dvt)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ma", MaMH);
                    cmd.Parameters.AddWithValue("@ten", TenMH);
                    cmd.Parameters.AddWithValue("@loai", MaLH);
                    cmd.Parameters.AddWithValue("@gia", Gia);
                    cmd.Parameters.AddWithValue("@soluong", Soluong);
                    cmd.Parameters.AddWithValue("@dvt", DVT);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }

                }
            }
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            CB_LoaiHang.SelectedIndex = -1;
            TB_TenMH.Clear();
            TB_Soluong.Clear();
            TB_Gia.Clear();
            TB_DVT.Clear();
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_LoaiHang_DropDownClosed(object sender, EventArgs e)
        {
            if (CB_LoaiHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn loại hàng");
                CB_LoaiHang.Focus();
            }
        }

        private void TB_TenMH_TextChanged(object sender, EventArgs e)
        {
            EnableThemIfValid();
        }

        private void TB_DVT_TextChanged(object sender, EventArgs e)
        {
            EnableThemIfValid();
        }

        private void CB_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableThemIfValid();
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
                MessageBox.Show("Bạn chưa nhập đơn vị tính");
                TB_DVT.Focus();
            }
        }

        private void TB_Soluong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Soluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
                TB_Soluong.Focus();
            }
        }

        private void TB_Gia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Gia.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
                TB_Gia.Focus();
            }
        }
    }
}
