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
    public partial class ThemHoaDon : Form
    {
        bool isValid_Name = false, isValid_Phone = false;
        int SoHD;
        ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public ThemHoaDon()
        {
            InitializeComponent();
            LoadDataIntoCBLH();
            bt_create_now.Enabled = false;
            btn_ThemMH.Enabled = false;
            rdb_Nam.Checked = true;
        }
        private void MoNut()
        {
            bool ten = !string.IsNullOrEmpty(tb_name.Text);
            bool diachi = !string.IsNullOrEmpty(tb_address.Text);
            bool sdt = !string.IsNullOrEmpty(tb_Phone.Text);
            bt_create_now.Enabled = ten && diachi && sdt;
        }
        private void MoNutThem()
        {
            bool loai = CB_LoaiHang.SelectedIndex != -1;
            bool mh = CB_MatHang.SelectedIndex != -1;
            bool soluong = !string.IsNullOrEmpty(tb_Quantity.Text);
            btn_ThemMH.Enabled = loai && mh && soluong;

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
        private void LoadDataIntoCBMatHang(string maLH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string querysl = "SELECT sTenMH FROM tblHangHoa WHERE sMaLH = @maLH ";
                using (SqlCommand cmd = new SqlCommand(querysl, conn))
                {
                    cmd.Parameters.AddWithValue("@maLH", maLH);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CB_MatHang.Items.Add(dr["sTenMH"].ToString());
                        }
                    }
                }
            }

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
        private string LayMaMHtuTen(string TenMH)
        {
            string MaMH;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sMaMH FROM tblHangHoa WHERE sTenMH = @ma";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ma", TenMH);
                    object id = cmd.ExecuteScalar();
                    MaMH = id.ToString();
                }
            }
            return MaMH;
        }
        private void LoadDataintoDTGR(int soHD)
        {
            string query = "XemCTDH";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaHD", soHD);
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                    }
                }
            }
            DTGR_BangHD.DataSource = dt;
            DTGR_BangHD.Columns[0].HeaderText = "Mặt hàng";
            DTGR_BangHD.Columns[1].HeaderText = "Số lượng";
            DTGR_BangHD.Columns[2].HeaderText = "Giá bán";
            DTGR_BangHD.Columns[3].HeaderText = "Thành Tiền";

        }
        private void LayGiamGia(int soHD)
        {
            string query = "SELECT TOP 1 fGiamGia FROM tblCTHoaDon WHERE iSoHD = @Ma";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", soHD);
                    object result = cmd.ExecuteScalar();
                    string magiamgia = result.ToString();
                    TB_GiamGia.Text = magiamgia;

                }
            }
        }
        private void TinhTongTien()
        {
            double total = 0;
            double sale = Convert.ToDouble(TB_GiamGia.Text);
            foreach (DataGridViewRow row in DTGR_BangHD.Rows)
            {
                object cellValue = row.Cells["ThanhTien"].Value;
                if (cellValue != null && cellValue.ToString() != "")
                {
                    double number;
                    if (double.TryParse(cellValue.ToString(), out number))
                    {
                        total += number;

                    }
                }
            }
            if (sale > 0)
            {
                total = total * (1 - sale);

            }
            TB_Tong.Text = total.ToString();
        }



        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            MoNut();
        }
       
        private void btn_ThemMH_Click(object sender, EventArgs e)
        {
            string maSP = LayMaMHtuTen(CB_MatHang.SelectedItem.ToString());
            int soluong = Convert.ToInt32(tb_Quantity.Text);
            string query = "NhapCTHD";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.Parameters.AddWithValue("@iSoHD", SoHD);
                    cmd.Parameters.AddWithValue("@Soluong", soluong);
                    cmd.ExecuteNonQuery();

                }
            }
            LoadDataintoDTGR(SoHD);
            LayGiamGia(SoHD);
            TinhTongTien();
        }

       
        private void tb_Phone_Validating(object sender, CancelEventArgs e)
        {
            string phone = tb_Phone.Text;
            bool isValid = true;
            // Kiểm tra xem chuỗi có chứa ký tự không phải số không
            if (phone.Any(c => !char.IsDigit(c)))
            {
                isValid = false;
                errorProvider.SetError(tb_Phone, "Số điện thoại chỉ được chứa số!");
            }
            // Kiểm tra xem chuỗi có đúng 12 hoặc ít hơn 12 ký tự không
            else if (phone.Length < 10 || phone.Length > 10)
            {
                isValid = false;
                errorProvider.SetError(tb_Phone, "Số điện thoại phải có 10 số");
            }

            if (!isValid)
            {
                isValid_Phone = false;
                e.Cancel = true;
            }
            else
            {
                isValid_Phone = true;
                errorProvider.SetError(tb_Phone, "");
            }
            
        }

        private void bt_create_now_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Lấy số hóa đơn mới từ cơ sở dữ liệu
                SoHD = LaySoHoaDonMoi();
                // Tạo đối tượng SqlCommand để thực thi stored procedure
                using (SqlCommand command = new SqlCommand("Create_Bill_For_Customer", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Thêm các tham số vào stored procedure
                    command.Parameters.AddWithValue("@iSoHD", SoHD);
                    command.Parameters.AddWithValue("@sTenKH", tb_name.Text);
                    command.Parameters.AddWithValue("@sDiaChi", tb_address.Text);
                    command.Parameters.AddWithValue("@sSoDT", tb_Phone.Text);
                    command.Parameters.AddWithValue("@bGioiTinh", rdb_Nam.Checked ? 1 : 0);

                    // Thực thi stored procedure
                    int rowsAffected = command.ExecuteNonQuery();
                    bool isSuccess = rowsAffected > 0;
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm hóa đơn.");
                    }
                    // Đóng kết nối sau khi thực thi xong
                    connection.Close();
                }
            }
        }
        public int LaySoHoaDonMoi()
        {
            int iSoHD = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MAX(iSoHD) FROM tblHoaDon", connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        iSoHD = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return iSoHD;
        }

        private void tb_name_TextChanged_1(object sender, EventArgs e)
        {
            MoNut();
        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {
            MoNut();
        }

        private void CB_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLH = LayMaLHtuTen(CB_LoaiHang.SelectedItem.ToString());
            LoadDataIntoCBMatHang(maLH);
            MoNutThem();
            MoNutThem();
        }

        private void CB_MatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoNutThem();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            MoNutThem();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin hiện tại không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "XoaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHD", SoHD);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa đơn hàng thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                    }
                }
            }

        }

        private void BT_Xuat_Click(object sender, EventArgs e)
        {
            XuatHoaDon hd = new XuatHoaDon(SoHD);
            hd.Show();
        }

        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                errorProvider.SetError(tb_name, "Tên không được để trống!");
                isValid_Name = false;
                e.Cancel = true; 
            }
            else
            {
                if (tb_name.Text.Any(char.IsDigit) || tb_name.Text.Any(char.IsPunctuation))
                {
                    errorProvider.SetError(tb_name, "Tên không được chứa số hoặc ký tự đặc biệt!");
                    e.Cancel = true;
                    isValid_Name = false;

                }
                else
                {
                    errorProvider.SetError(tb_name, "");
                    isValid_Name = true;
                }
            }
           
        }

    }
}
