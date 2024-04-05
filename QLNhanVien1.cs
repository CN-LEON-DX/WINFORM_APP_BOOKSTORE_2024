using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BTL_WINFORM_2024
{
    public partial class QLNhanVien1 : Form
    {
        private Timer timer = new Timer();
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public QLNhanVien1()
        {
            InitializeComponent();
            // Thiết lập AutoCompleteSource và AutoCompleteMode cho TextBox
            textBox_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick;
            timer.Start(); // Bắt đầu timer
            // Gọi phương thức để cài đặt dữ liệu gợi ý
            SetAutoComplete();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Lấy cả giờ và day month  year 
            label_current_time.Text = currentTime.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private void SetAutoComplete()
        {
            try
            {
                // Kết nối với cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Truy vấn để lấy danh sách các mã nhân viên
                    string query = "SELECT TOP 5 sMaNV FROM tblNhanVien";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo một AutoCompleteStringCollection để lưu trữ các mã nhân viên
                    AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

                    // Đọc từng mã nhân viên và thêm vào AutoCompleteStringCollection
                    while (reader.Read())
                    {
                        autoCompleteCollection.Add(reader["sMaNV"].ToString());
                    }

                    // Đặt AutoCompleteCustomSource cho TextBox
                    textBox_id.AutoCompleteCustomSource = autoCompleteCollection;

                    // Đóng kết nối
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label_sex_Click(object sender, EventArgs e)
        {

        }

        public void QL_Admin_Load(object sender, EventArgs e)
        {
            LoadDataTo_GridView_Employee();
        }

        private void LoadDataTo_GridView_Employee()
        {
            string query = "SELECT * FROM tblNhanVien";

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }

            // Gán DataTable đã lấy được vào DataGridView
            dtgv_list_employee.DataSource = dataTable;
        }

        private void click_check_infor_employee(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_list_employee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgv_list_employee.SelectedRows[0];
                textBox_id.Text = selectedRow.Cells["sMaNV"].Value.ToString();
                label_name.Text = selectedRow.Cells["sTenNV"].Value.ToString();
                DateTime birthday = (DateTime)selectedRow.Cells["dNgaySinh"].Value;
                // Sử dụng phương thức ToString để chỉ lấy ngày tháng năm
                label_birthday.Text = birthday.ToString("dd/MM/yyyy");
                textBox_address.Text = selectedRow.Cells["sDiaChi"].Value.ToString();
                // Nếu giới tính là True thì là Nam flase là Nữ 
                bool sex = (bool)selectedRow.Cells["bGioiTinh"].Value;
                label_sex.Text = sex ? "Nam" : "Nữ";
                label_salary.Text = selectedRow.Cells["fHSL"].Value.ToString();
                DateTime start_date = (DateTime)selectedRow.Cells["dNgayVaoLam"].Value;
                label_start_date.Text = start_date.ToString("dd/MM/yyyy");
                label_possition.Text = selectedRow.Cells["sChucVu"].Value.ToString().ToLower();
                label_cccd.Text = selectedRow.Cells["sCCCD"].Value.ToString();
            } 
        }

        private void click_add_new_employee(object sender, EventArgs e)
        {
            Form form = new ThemNhanVienForm();
            form.FormClosed += FormB_FormClosed;
            form.ShowDialog();
        }
        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataTo_GridView_Employee();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            string user_id = textBox_id.Text;

            if (check_exits_employee(user_id))
            {
                string query = "SELECT * FROM tblNhanVien WHERE sMaNV = @sMaNV";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@sMaNV", user_id);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0]; // Chỉ lấy dòng đầu tiên
                                                             // Hiển thị thông tin nhân viên trên các Label
                            label_name.Text = row["sTenNV"].ToString();
                            label_birthday.Text = row["dNgaySinh"].ToString();
                            textBox_address.Text = row["sDiaChi"].ToString();
                            label_sex.Text = (bool)row["bGioiTinh"] ? "Nam" : "Nữ";
                            label_salary.Text = row["fHSL"].ToString();
                            DateTime start_date = (DateTime)row["dNgayVaoLam"];
                            label_start_date.Text = start_date.ToString("dd/MM/yyyy");
                            // Thêm các thông tin khác nếu cần
                            label_phone_number.Text = row["sSoDT"].ToString();
                            label_cccd.Text = row["sCCCD"].ToString();
                            label_possition.Text = row["sChucVu"].ToString().ToLower();
                        }
                        else
                        {
                            // Nếu không có dòng dữ liệu nào được trả về, đặt các Label về trạng thái rỗng
                            label_name.Text = "";
                            label_birthday.Text = "";
                            textBox_address.Text = "";
                            label_sex.Text = "";
                            label_salary.Text = "";
                            label_start_date.Text = "";
                            label_phone_number.Text = "";
                            label_cccd.Text = "";
                            // Thêm các Label khác nếu cần
                        }
                    }
                }
            }
            else
            {
                label_name.Text = "";
                label_birthday.Text = "";
                textBox_address.Text = "";
                label_sex.Text = "";
                label_salary.Text = "";
                label_start_date.Text = "";
                label_phone_number.Text = "";
                label_cccd.Text = "";
            }
        }

        private bool check_exits_employee(string user_id)
        {
            bool check = false;
            string query = "SELECT COUNT(*) FROM tblNhanVien WHERE sMaNV = @sMaNV";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@sMaNV", user_id);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        check = true; // Mã nhân viên tồn tại trong cơ sở dữ liệu
                    }
                }
            }
            return check;
        }

       
        private void QLNhanVien1_Load(object sender, EventArgs e)
        {

        }

        

        private void QLNhanVien1_Load_1(object sender, EventArgs e)
        {

        }

        

        private void QLNhanVien1_Load_2(object sender, EventArgs e)
        {

        }

        

        private void QLNhanVien1_Load_3(object sender, EventArgs e)
        {

        }



        private void form_close_confirm(object sender, FormClosingEventArgs e)
        {

        }



        private void QLNhanVien1_Load_4(object sender, EventArgs e)
        {

        }

        private void click_delete_employee(object sender, EventArgs e)
        {
            if (dtgv_list_employee.SelectedRows.Count > 0)
            {
                int selectedIndex = dtgv_list_employee.SelectedRows[0].Index;
                string employeeID = dtgv_list_employee.Rows[selectedIndex].Cells["sMaNV"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string deleteProc = "usp_DeleteEmployee";
                            using (SqlCommand command = new SqlCommand("usp_DeleteEmployee", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@sMaNV", employeeID);

                                // Thực thi stored procedure
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    dtgv_list_employee.Rows.RemoveAt(selectedIndex);

                                    MessageBox.Show("Nhân viên đã được xóa thành công.", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Xóa nhân viên không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void click_editting_employee(object sender, EventArgs e)
        {
            if (dtgv_list_employee.SelectedRows.Count > 0)
            {
                int selectedIndex = dtgv_list_employee.SelectedRows[0].Index;

                string employeeID = dtgv_list_employee.Rows[selectedIndex].Cells["sMaNV"].Value.ToString();
                string name = dtgv_list_employee.Rows[selectedIndex].Cells["sTenNV"].Value.ToString();
                string birthday = dtgv_list_employee.Rows[selectedIndex].Cells["dNgaySinh"].Value.ToString();
                string phone = dtgv_list_employee.Rows[selectedIndex].Cells["sSoDT"].Value.ToString();

                string address = dtgv_list_employee.Rows[selectedIndex].Cells["sDiaChi"].Value.ToString();
                bool sex = (bool)dtgv_list_employee.Rows[selectedIndex].Cells["bGioiTinh"].Value;
                string salary = dtgv_list_employee.Rows[selectedIndex].Cells["fHSL"].Value.ToString();
                string posittion = dtgv_list_employee.Rows[selectedIndex].Cells["sChucVu"].Value.ToString();
                string cccd = dtgv_list_employee.Rows[selectedIndex].Cells["sCCCD"].Value.ToString();

                ChinhSuaThongTinNV form_next = new ChinhSuaThongTinNV(employeeID,name, birthday, address, sex, phone, salary, posittion, cccd);
                form_next.FormClosing += Form_next_FormClosing;
                form_next.ShowDialog();
            }
            else if (check_exits_employee(textBox_id.Text.ToString())) {
                string employeeID = textBox_id.ToString();
                label_name.Text = "";
                label_birthday.Text = "";
                textBox_address.Text = "";
                label_sex.Text = "";
                label_salary.Text = "";
                label_start_date.Text = "";
                label_phone_number.Text = "";
                label_cccd.Text = "";

                string name = label_name.Text.ToString();
                string birthday = label_birthday.Text.ToString();
                string phone = label_phone_number.Text.ToString();

                string address = textBox_address.Text.ToString();
                bool sex = label_sex.Text.ToString() == "Nam" ? true: false;
                string salary = label_salary.Text.ToString();
                string posittion = label_possition.Text.ToString();
                string cccd = label_cccd.Text.ToString();

                ChinhSuaThongTinNV form_next = new ChinhSuaThongTinNV(employeeID, name, birthday, address, sex, phone, salary, posittion, cccd);
                form_next.FormClosing += Form_next_FormClosing;
                form_next.ShowDialog();
            }
            else {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form_next_FormClosing(object sender, FormClosingEventArgs e)
        {
            // sau khi chinh sua xong thi load lai form
            label_name.Text = "";
            label_birthday.Text = "";
            textBox_address.Text = "";
            label_sex.Text = "";
            label_salary.Text = "";
            label_start_date.Text = "";
            label_phone_number.Text = "";
            LoadDataTo_GridView_Employee();

        }
    }
}
