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
        private DataView dv_dgv = new DataView();
        private Timer timer = new Timer();
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        string currentID = "";
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
            dtgv_list_employee.Columns[0].HeaderText = "Mã nhân viên";
            dtgv_list_employee.Columns[1].HeaderText = "Họ và tên";
            dtgv_list_employee.Columns[2].HeaderText = "Giới tính";
            dtgv_list_employee.Columns[3].HeaderText = "Địa chỉ";
            dtgv_list_employee.Columns[4].HeaderText = "Số điện thọa";
            dtgv_list_employee.Columns[5].HeaderText = "Hệ số lương";
            dtgv_list_employee.Columns[6].HeaderText = "Ngày sinh";
            dtgv_list_employee.Columns[7].HeaderText = "Ngày vào làm";
            dtgv_list_employee.Columns[8].HeaderText = "Chức vụ";
            dtgv_list_employee.Columns[9].HeaderText = "Số CCCD";
            label_option_employee.ForeColor = ColorTranslator.FromHtml("#6633FF"); 
            panel_employee.Visible = true;
            panel_report.Visible = false;
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
                currentID = textBox_id.Text = selectedRow.Cells["sMaNV"].Value.ToString();
                tb_name.Text = selectedRow.Cells["sTenNV"].Value.ToString();
                DateTime birthday = (DateTime)selectedRow.Cells["dNgaySinh"].Value;
                // Sử dụng phương thức ToString để chỉ lấy ngày tháng năm
                tbBirthDay.Text = birthday.ToString("dd/MM/yyyy");
                tb_address.Text = selectedRow.Cells["sDiaChi"].Value.ToString();
                // Nếu giới tính là True thì là Nam flase là Nữ 
                bool sex = (bool)selectedRow.Cells["bGioiTinh"].Value;
                tbGender.Text = sex ? "Nam" : "Nữ";
                tbHSL.Text = selectedRow.Cells["fHSL"].Value.ToString();
                DateTime start_date = (DateTime)selectedRow.Cells["dNgayVaoLam"].Value;
                tbstart_date.Text = start_date.ToString("dd/MM/yyyy");
                label_possition.Text = selectedRow.Cells["sChucVu"].Value.ToString().ToLower();
                tbCCCD.Text = selectedRow.Cells["sCCCD"].Value.ToString();
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
                            currentID = row["sMaNV"].ToString();
                            tb_name.Text = row["sTenNV"].ToString();
                            DateTime birthday = (DateTime)row["dNgaySinh"];
                            // Sử dụng phương thức ToString để chỉ lấy ngày tháng năm
                            tbBirthDay.Text = birthday.ToString("dd/MM/yyyy");
                            tb_address.Text = row["sDiaChi"].ToString();
                            tbGender.Text = (bool)row["bGioiTinh"] ? "Nam" : "Nữ";
                            tbHSL.Text = row["fHSL"].ToString();
                            DateTime start_date = (DateTime)row["dNgayVaoLam"];
                            tbstart_date.Text = start_date.ToString("dd/MM/yyyy");
                            // Thêm các thông tin khác nếu cần
                            tbPhone.Text = row["sSoDT"].ToString();
                            tbCCCD.Text = row["sCCCD"].ToString();
                            label_possition.Text = row["sChucVu"].ToString().ToLower();

                            // Nếu tìm thấy thì cho datagridview focus vào mục đó và thay đổi selectedIndex ở mục đó luôn 
                            // viết hàm gì ......
                            ScrollToEmployeeRow(user_id);
                            // Tôi cần nếu tìm đến đâu mà người dùng chọn đến đâu thì gridView thay đổi cơ chứ không phải textBox là index đang selected ở bên trong gridview.
                        }
                        else
                        {
                            // Nếu không có dòng dữ liệu nào được trả về, đặt các Label về trạng thái rỗng
                            tb_name.Text = "";
                            tbBirthDay.Text = "";
                            tb_address.Text = "";
                            tbGender.Text = "";
                            tbHSL.Text = "";
                            tbstart_date.Text = "";
                            tbPhone.Text = "";
                            tbCCCD.Text = "";
                            // Thêm các Label khác nếu cần
                        }
                    }
                }
            }
            else
            {
                tb_name.Text = "";
                tbBirthDay.Text = "";
                tb_address.Text = "";
                tbGender.Text = "";
                tbHSL.Text = "";
                tbstart_date.Text = "";
                tbPhone.Text = "";
                tbCCCD.Text = "";
            }
        }

        private void ScrollToEmployeeRow(string user_id)
        {
            try
            {
                foreach (DataGridViewRow row in dtgv_list_employee.Rows)
                {
                    try
                    {
                        if (row.Cells["sMaNV"].Value != null)
                        {
                            if (row.Cells["sMaNV"].Value.ToString() == user_id)
                            {
                                // Cuộn đến dòng tương ứng
                                row.Selected = true;
                                dtgv_list_employee.CurrentCell = row.Cells[0];
                                dtgv_list_employee.FirstDisplayedScrollingRowIndex = row.Index;
                                break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    }
                    
            } catch(Exception e)
            {
                Console.WriteLine(e);
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
                string name = tb_name.Text.ToString();
                string birthday = tbBirthDay.Text.ToString();
                string phone = tbPhone.Text.ToString();

                string address = tb_address.Text.ToString();
                bool sex = tbGender.Text.ToString() == "Nam" ? true: false;
                string salary = tbHSL.Text.ToString();
                string posittion = label_possition.Text.ToString();
                string cccd = tbCCCD.Text.ToString();

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
            UpdateInfor(currentID);
            LoadDataTo_GridView_Employee();

        }

        private void UpdateInfor(string currentID)
        {
            string user_id = currentID;
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
                        currentID = row["sMaNV"].ToString();
                        tb_name.Text = row["sTenNV"].ToString();
                        DateTime birthDay = (DateTime)row["dNgaySinh"];
                        tbBirthDay.Text = birthDay.ToString("dd/MM/yyyy");
                        tb_address.Text = row["sDiaChi"].ToString();
                        tbGender.Text = (bool)row["bGioiTinh"] ? "Nam" : "Nữ";
                        tbHSL.Text = row["fHSL"].ToString();
                        DateTime start_date = (DateTime)row["dNgayVaoLam"];
                        tbstart_date.Text = start_date.ToString("dd/MM/yyyy");
                        // Thêm các thông tin khác nếu cần
                        tbPhone.Text = row["sSoDT"].ToString();
                        tbCCCD.Text = row["sCCCD"].ToString();
                        label_possition.Text = row["sChucVu"].ToString().ToLower();
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void click_arange_name(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM tblNhanVien ORDER BY sTenNV ASC";

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sắp xếp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void click_to_find(object sender, EventArgs e)
        {
            string filter = "sMaNV IS NOT NULL";
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()) && tb_name.Text.Trim() != "Trống ...")
            {
                filter += string.Format(" AND sTenNV LIKE '%{0}%'", tb_name.Text);
            }
            if (!string.IsNullOrEmpty(tbBirthDay.Text.Trim()) && tbBirthDay.Text.Trim() != "Trống ...")
            {
                filter += string.Format(" AND dNgaySinh LIKE '%{0}%'", tbBirthDay.Text);
            }
            if (!string.IsNullOrEmpty(tb_address.Text.Trim()) && tb_address.Text.Trim() != "Trống ...")
            {
                filter += string.Format("AND sDiaChi LIKE `%{0}%`", tb_address.Text);
            }
            if (!string.IsNullOrEmpty(tbPhone.Text.Trim()) && tbPhone.Text.Trim() != "Trống ...")
            {
                filter += string.Format("AND sSoDT LIKE `%{0}%`", tbPhone.Text);
            }
            if (!string.IsNullOrEmpty(tbCCCD.Text.Trim()) && tbCCCD.Text.Trim() != "Trống ...")
            {
                filter += string.Format("AND sCCCD LIKE `%{0}%`", tbCCCD.Text);
            }
            
            // Viết lại hàm này theo mẫu trên:
            //// Hàm showData sẽ lọc các bản ghi bên trong gridview với thông tin Mã nhân viên, tên nhân viên, ngày sinh, số điện thoại, 
            ShowData(filter);
        }

        private void ShowData(string filter = "")
        {
            string querySelect = "Select_All_Employee";
            using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                {
                    sqlCommand.CommandText = querySelect;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                dv_dgv = dataTable.DefaultView;
                                dtgv_list_employee.AutoGenerateColumns = false;
                                try
                                {
                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dv_dgv.RowFilter = filter;
                                    }
                                } catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    MessageBox.Show("Bản ghi đây thây");
                                }
                                
                                dtgv_list_employee.DataSource = dv_dgv;
                            }
                            else
                            {
                                MessageBox.Show("Khong co ban ghi nao");
                            }
                        }
                    }
                }
            }
        }

        private void button_edit_infor_Click(object sender, EventArgs e)
        {

        }

        private void label_possition_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tbBirthDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tb_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_employee_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tbstart_date_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label_manage_Click(object sender, EventArgs e)
        {
            // Thay đổi màu của label "Quản lý nhân viên" khi được click
            label_option_employee.ForeColor = ColorTranslator.FromHtml("#6633FF"); 

            // Đặt màu cho label "Báo cáo" khi không được click
            label_report.ForeColor = Color.White;

            // Hiện panel quản lý nhân viên và ẩn panel báo cáo
            panel_employee.Visible = true;
            panel_report.Visible = false;
        }

        private void label_report_Click(object sender, EventArgs e)
        {
            // Thay đổi màu của label "Báo cáo" khi được click
            label_report.ForeColor = ColorTranslator.FromHtml("#6633FF"); ;

            // Đặt màu cho label "Quản lý nhân viên" khi không được click
            label_option_employee.ForeColor = Color.White;

            // Hiện panel báo cáo và ẩn panel quản lý nhân viên
            panel_report.Visible = true;
            panel_employee.Visible = false;
        }

        private void click_makeCR_All_Employee(object sender, EventArgs e)
        {
            // chuyển sang form báo cáo
            string filter = "";
            FormBaoCao formReport = new FormBaoCao();
            formReport.Show();
            formReport.ShowReport("CR_DSNV.rpt", "Select_Infor_Employee_Report", filter);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string filter = "";
            FormBaoCao formReport = new FormBaoCao();
            formReport.Show();
            formReport.ShowReport("CR_DSNV_YEAR.rpt", "Select_StartYear_Employee_Report", filter);
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            // Form xác nhận đăng xuất.
            DialogResult result = MessageBox.Show("Xác nhận đăng xuất ?", "Thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DangNhapForm formLogin = new DangNhapForm();
                this.Close();
                formLogin.Show();
            }
        }

        private void Form_Closed(object sender, FormClosingEventArgs e)
        {
            // Đóng forrm
            DialogResult result = MessageBox.Show("Xác nhận thoát app ?", "Thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                // Nếu người dùng không xác nhận đóng, hủy thao tác đóng form
                e.Cancel = true;
            }
        }
    }
}
