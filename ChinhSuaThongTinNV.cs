using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BTL_WINFORM_2024
{
    public partial class ChinhSuaThongTinNV : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        bool valid_name = false, valid_address = false, valid_cccd = false, valid_phone = false;
        string id, name, birthday, address,phone, salary, posittion,  cccd;
        bool sex;
        private void ChinhSuaThongTinNV_Load(object sender, EventArgs e)
        {
            textBox_name.Text = name;
            comboBox1.Text = posittion;
            textBox_address.Text = address;
            if (sex == true)
            {
                radioButton_male.Checked = true;
                radioButton_female.Checked = false;

            }
            else
            {
                radioButton_male.Checked = false;
                radioButton_female.Checked = true;
            }
            textBox_cccd.Text = cccd;
            textBox_phone.Text = phone;
            dateTimePicker_birthday.Text = birthday;
            textBox_salary.Text = salary;
        }

        public ChinhSuaThongTinNV(string id, string name,string birthday, string address, bool sex,string phone, string salary, string posittion, string cccd)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.address = address;
            this.sex = sex;
            this.salary = salary;
            this.phone = phone;
            this.posittion = posittion;
            this.cccd = cccd;
            InitializeComponent();
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

        private void click_rb_femal(object sender, EventArgs e)
        {
            radioButton_female.Checked = true;
            radioButton_male.Checked = false;
        }

        private void click_male(object sender, EventArgs e)
        {
            radioButton_male.Checked = true;
            radioButton_female.Checked = false;
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

        private void click_update_emp(object sender, EventArgs e)
        {
           // Cap nhat thong tin
           // id la ma nhan vien

            // Xác định giới tính của nhân viên dựa trên RadioButton được chọn
            int gender = radioButton_male.Checked ? 1 : 0;

            // Lấy thông tin từ các controls trên form
            string name = textBox_name.Text;
            string address = textBox_address.Text;
            string cccd = textBox_cccd.Text;
            DateTime birthday = dateTimePicker_birthday.Value;
            string position = comboBox1.SelectedItem.ToString();
            string phone = textBox_phone.Text;
            string salary = textBox_salary.Text;
            // - Thoi gian vao la ngay hom nay 
            DateTime start_date = DateTime.Now;

            // Hiển thị hộp thoại xác nhận trước khi thêm mới nhân viên vào CSDL
            DialogResult result = MessageBox.Show("Bạn có chắc sửa tt nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Tạo câu lệnh SQL UPDATE
                    string updateQuery = "UPDATE tblNhanVien SET sTenNV = @TenNV, sDiaChi = @DiaChi, sCCCD = @CCCD, dNgaySinh = @NgaySinh, sChucVu = @ChucVu, sSoDT = @SDT, bGioiTinh = @GioiTinh, fHSL = @HSL WHERE sMaNV = @MaNV";

                    // Mở kết nối đến cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Tạo đối tượng SqlCommand và thiết lập tham số cho câu lệnh SQL
                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            command.Parameters.AddWithValue("@MaNV", id);
                            command.Parameters.AddWithValue("@TenNV", name);
                            command.Parameters.AddWithValue("@DiaChi", address);
                            command.Parameters.AddWithValue("@CCCD", cccd);
                            command.Parameters.AddWithValue("@NgaySinh", birthday);
                            command.Parameters.AddWithValue("@ChucVu", position);
                            command.Parameters.AddWithValue("@SDT", phone);
                            command.Parameters.AddWithValue("@HSL", salary );
                            command.Parameters.AddWithValue("@GioiTinh", gender);

                            // Thực thi câu lệnh SQL UPDATE
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không có nhân viên nào được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                
            }
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
    }
}
