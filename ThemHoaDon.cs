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
        ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            btn_ThemMH.Enabled = false;
            bt_create_now.Enabled = false;
            cmb_LoaiHang.SelectedIndex = 0;
            cmb_MatHang.Enabled = false;
            tb_Quantity.Enabled = false;
            rdb_Nam.Checked = true;
            rdb_Nu.Checked = false;
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isValid_CreateBill()
        {
            return isValid_Phone && isValid_ListProduct() && isValid_Name;
        }
        private bool isValid_ListProduct()
        {
            return listView_MH.Items.Count > 0;
        }
        private void btn_ThemMH_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string name = tb_name.Text;
            string address = tb_address.Text;
            string phone = tb_Phone.Text;

            // Tạo một chuỗi để chứa thông tin từ ListView
            StringBuilder productList = new StringBuilder();

            // Duyệt qua từng mục trong ListView
            foreach (ListViewItem item in listView_MH.Items)
            {
                // Lấy tên mặt hàng từ mục hiện tại và thêm vào chuỗi
                productList.AppendLine(item.Text);
            }

            // Đưa thông tin vào RichTextBox
            rtb_Bill.AppendText($"--------------- HÓA ĐƠN------------------:\n");
            rtb_Bill.AppendText($"Tên khách hàng: {name}\n");
            rtb_Bill.AppendText($"Địa chỉ: {address}\n");
            rtb_Bill.AppendText($"Số điện thoại: {phone}\n");
            rtb_Bill.AppendText($"Danh sách mặt hàng:\n{productList.ToString()}");

            bt_create_now.Enabled = true;
        }

        private void cmb_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu click index = 1 -> Loai hàng
            //Lấy trong database tại bảng tblHangHoa tìm lấy các loại hàng có mã là LH001 -> đưa ra danh sách đưa vào combobox
            //2-> LH002
            //3-> LH003
            // rồi đửa vào comboBox
            //cmb_MatHang.
            // CLEAR CÁC THÔNG TIN BÊN TRONG COMBOBOX TRƯỚC KHI VÀO 
            cmb_MatHang.Items.Clear();
            tb_Quantity.Enabled = true;
            tb_Quantity.Text = "1";
            cmb_MatHang.Enabled = true;
            int index = cmb_LoaiHang.SelectedIndex;
            string sMaLH = "";
            string query = "Select_Name_Product";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (index == 0) sMaLH = "LH001";
                    else if (index == 1) sMaLH = "LH002";
                    else if (index == 2) sMaLH = "LH003";
                    else return;
                    cmd.Parameters.AddWithValue("@sMaLH", sMaLH);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_MatHang.Items.Add(reader["sTenMH"].ToString() );
                        }
                    }
                }
            }
        }

        private void cmb_MatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Click vào cái nào cái đấy sẽ lấy thông tin đưa vào listView 
            string selected_item = cmb_MatHang.SelectedItem.ToString();
            // Đưa vào listView ?
            ListViewItem item = new ListViewItem(selected_item + ", Số lượng: " + tb_Quantity.Text);
            listView_MH.Items.Add(item);
            if (isValid_CreateBill()) btn_ThemMH.Enabled = true;
            else btn_ThemMH.Enabled = false;
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
            else if (phone.Length < 12 || phone.Length > 14)
            {
                isValid = false;
                errorProvider.SetError(tb_Phone, "Số điện thoại phải có 12 số tới 14 số !");
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
            if (isValid_CreateBill()) btn_ThemMH.Enabled = true;
            else btn_ThemMH.Enabled = false;
        }

        private void bt_create_now_Click(object sender, EventArgs e)
        {
            // Thêm đơn hàng này thì cần truyền vào các tham số sau:
            // BẢNG HÓA ĐƠN
            // [iSoHD] -> TỤ tạo bên proc
            //,[sMaNV] -> Lấy mã nhân viên bán là NV003
            //,[sMaKH] -> check bên proc
            //,[dNgayBan] là lấy thời điểm hiện tại, ở dạng DMY

            // BẢNG CTHD
            //,[sMaMH] -> đưa danh sách mã mặt hàng vào nếu có nhiểu ở dạng list
            //,[fSoLuong] -> số lượng lấy ở listvew
            //,[fGiaBan] -> giá bán lấy bên databasse
            //,[fGiamGia] LẤY TỪ DATABASE RA. ĐƯA VÀO 


        }

        private void bt_Delete_infor_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận xóa thông tin hiện tại. xóa các textbox , xóa các listView, xóa tt bên trong richTextBox.
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin hiện tại không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Xóa các TextBox
                tb_name.Text = "...";
                tb_address.Text = "...";
                tb_Phone.Text = "...";

                // Xóa các mục trong ListView
                listView_MH.Items.Clear();

                // Xóa thông tin trong RichTextBox
                rtb_Bill.Clear();
                bt_create_now.Enabled = false;
                btn_ThemMH.Enabled = false;
            }
        }

        private void bt_Cancel_Create_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy tạo đơn ?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
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
            if (isValid_CreateBill()) btn_ThemMH.Enabled = true;
            else btn_ThemMH.Enabled = false;
        }

    }
}
