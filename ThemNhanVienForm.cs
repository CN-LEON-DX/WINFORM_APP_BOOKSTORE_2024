using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace BTL_WINFORM_2024
{
    public partial class ThemNhanVienForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        bool valid_name = false, valid_address = false, valid_cccd = false, valid_phone = false;
        public ThemNhanVienForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void valid_name_add(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                valid_name = false;
                //errorProvider.Icon = Properties.Resources.error;
                errorProvider.SetError(textBox_name, "Tên NV không để trống !");
            }
            else
            {
                errorProvider.Clear();
                valid_name = true;
            }
            if (EnableAddButtonIfAllValid() == true)
            {
                button_add_new.Enabled = true;
            }
            else
            {
                button_add_new.Enabled = false;
            }

        }
        private void valid_address_add(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_address.Text))
            {
                valid_address = false;
                //errorProvider.Icon = Properties.Resources.error;
                errorProvider.SetError(textBox_address, "Địa chỉ không để trống !");
            }
            else
            {
                errorProvider.Clear();
                valid_address = true;
            }
            if (EnableAddButtonIfAllValid() == true)
            {
                button_add_new.Enabled = true;
            }
            else
            {
                button_add_new.Enabled = false;
            }

        }
        private void valid_cccd_add(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_cccd.Text))
            {
                valid_cccd = false;
                //errorProvider.Icon = Properties.Resources.error;
                errorProvider.SetError(textBox_cccd, "CCCD không để trống !");
            }
            else
            {
                errorProvider.Clear();
                if (!Check_has_contain_12_charactor_is_alpha(textBox_cccd.Text.ToString()))
                {
                    valid_cccd = false;
                    errorProvider.SetError(textBox_cccd, "CCCD phải đủ 12 ký tự!");
                }
                else valid_cccd = true;
            }
            if (EnableAddButtonIfAllValid() == true)
            {
                button_add_new.Enabled = true;
            }
            else
            {
                button_add_new.Enabled = false;
            }

        }

        private bool Check_has_contain_12_charactor_is_alpha(string v)
        {
            string pattern = @"^[A-Za-z0-9]{12}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(v);
        }

        private bool EnableAddButtonIfAllValid()
        {
            return valid_name && valid_address && valid_cccd && valid_phone;
        }
        
        private void textBox_cccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là chữ cái từ A-Z hoặc số từ 0-9 không
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là chữ cái không
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Nếu không phải là chữ cái, ngăn không cho ký tự đó được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void textBox_cccd_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void click_add_new_emp(object sender, EventArgs e)
        {
            //- Công việc:
            //- Thực hiện thêm nhân viên mới vào CSDL với mã nhân viên là 
            // "NV0" + số lượng nhân viên  viên hiện tại + 1
            // Nếu ở radiobutton chọn nam thì -> đưa vào DB là 1 else 0
            // Sau đó đưa các thuộc tính khác vào !
            //- Hiển thị thông báo xác nhận thêm vào trước khi thêm vào DB
            // Tạo mã nhân viên mới dựa trên số lượng nhân viên hiện tại trong CSDL
            string newEmployeeID = GenerateNewEmployeeID();

            // Xác định giới tính của nhân viên dựa trên RadioButton được chọn
            int gender = radioButton_male.Checked ? 1 : 0;

            // Lấy thông tin từ các controls trên form
            string name = textBox_name.Text;
            string address = textBox_address.Text;
            string cccd = textBox_cccd.Text;
            DateTime birthday = dateTimePicker_birthday.Value;
            string position = comboBox1.SelectedItem.ToString();
            string phone = textBox_phone.Text;
            // - Thoi gian vao la ngay hom nay 
            DateTime start_date = DateTime.Now;

            // Hiển thị hộp thoại xác nhận trước khi thêm mới nhân viên vào CSDL
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện thêm mới nhân viên vào CSDL
                newEmployeeID = GenerateNewEmployeeID();
                Console.WriteLine(newEmployeeID);
                AddNewEmployeeToDatabase(newEmployeeID, name, gender, address, cccd, birthday, position, phone, start_date);

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm mới nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Các phương thức phụ trợ ở đây...

        public string GenerateNewEmployeeID()
        {
            // Lấy số cuối cùng của bản ghi hiện tại ví dụ: NV015 thì nhân viên tiếp theo bằng NV + 015 + 1 => NV016
            // Phải lấy được thông tin của bản ghi cuối.
            // Hàm này sẽ lấy thông tin mã nhân viên cuối của bản ghi.
            int lastIndex = GetLastIndex();
            // Tạo mã nhân viên mới
            string newEmployeeID = "NV" + (lastIndex + 1).ToString("D3");

            return newEmployeeID;
        }
        private int GetLastIndex()
        {
            int lastIndex = 0;
            string query = "SELECT TOP 1 sMaNV FROM tblNhanVien ORDER BY sMaNV DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string lastEmployeeID = reader["sMaNV"].ToString();
                        string indexString = lastEmployeeID.Substring(2); // Bỏ qua hai ký tự đầu tiên (chữ "NV")
                        lastIndex = int.Parse(indexString);
                    }
                }
            }

            return lastIndex;
        }




        private void valid_phone_number(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_phone.Text))
            {
                valid_phone = false;
                //errorProvider.Icon = Properties.Resources.error;
                errorProvider.SetError(textBox_phone, "SDT không để trống !");
            }
            else
            {
                errorProvider.Clear();
                valid_phone = true;
            }
            if (EnableAddButtonIfAllValid() == true)
            {
                button_add_new.Enabled = true;
            }
            else
            {
                button_add_new.Enabled = false;
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự không phải số được nhập vào TextBox
            }
        }

        private void click_exit_confirm(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            // Khi nhấn thì xóa thông tin của người dùng đã nhập
            radioButton_male.Checked =  true;

            // Lấy thông tin từ các controls trên form
            textBox_name.Text = "";
            textBox_address.Text  = "";
            textBox_cccd.Text = "";
            comboBox1.SelectedItem = 0;
            textBox_phone.Text = "";
        }

        private void button_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewEmployeeToDatabase(string employeeID, string name, int gender, string address, string cccd, DateTime birthday, string position, string phone,DateTime start_date)
        {
            // Thực hiện thêm mới nhân viên vào CSDL
            Console.WriteLine(employeeID);
            string query = "INSERT INTO tblNhanVien (sMaNV, sTenNV, bGioiTinh, sDiaChi, sSoDT, fHSL, dNgaySinh, dNgayVaoLam, sChucVu, sCCCD) VALUES (@sMaNV, @sTenNV, @bGioiTinh, @sDiaChi, @sSoDT, 4, @dNgaySinh, GETDATE(), @sChucVu, @sCCCD)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaNV", employeeID);
                    command.Parameters.AddWithValue("@sTenNV", name);
                    command.Parameters.AddWithValue("@bGioiTinh", gender);
                    command.Parameters.AddWithValue("@sDiaChi", address);
                    command.Parameters.AddWithValue("@sSoDT", phone);
                    command.Parameters.AddWithValue("@dNgaySinh", birthday);
                    command.Parameters.AddWithValue("@dNgayVaoLam", start_date);
                    command.Parameters.AddWithValue("@sChucVu", position);
                    command.Parameters.AddWithValue("@sCCCD", cccd);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
   
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ThemNhanVienForm_Load(object sender, EventArgs e)
        {
            radioButton_female.Checked = true;
            comboBox1.SelectedIndex = 0;
            button_add_new.Enabled = false;
        }
    }
}
