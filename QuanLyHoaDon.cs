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
    public partial class QuanLyHoaDon : Form
    {
        private string currentID;
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;

        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void LB_TOP_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataTo_GridView_Bill();
        }

        // LOAD DATA
        private void LoadDataTo_GridView_Bill()
        {
            string query = "Select_Infor_Bill_Customer";

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    // SỬA DATA TABLE SAO CHO NGÀY BÁN Ở ĐỊNH DẠNG DMY
                    dtgv_DSHD.DataSource = dataTable;
                    dtgv_DSHD.Columns["dNgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dtgv_DSHD.Columns[0].HeaderText = "Số hóa đơn";
                    dtgv_DSHD.Columns[1].HeaderText = "Tên khách hàng";
                    dtgv_DSHD.Columns[2].HeaderText = "Số điện thoại";
                    dtgv_DSHD.Columns[3].HeaderText = "Ngày lập";
                    dtgv_DSHD.Columns[4].HeaderText = "Nhân viên bán";
                   
                }
                
            }

            // Gán DataTable đã lấy được vào DataGridView
            dtgv_DSHD.DataSource = dataTable;
        }

        private void button_create_bill_Click(object sender, EventArgs e)
        {
            // Thêm vào một hóa đơn mới.
            ThemHoaDon form = new ThemHoaDon();
            form.ShowDialog();
        }

        private void dtgv_DSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dtgv_DSHD.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtgv_DSHD.SelectedRows[0];
                    currentID = tb_id.Text = selectedRow.Cells["iSoHD"].Value.ToString();
                    tb_name.Text = selectedRow.Cells["sTenKH"].Value.ToString();
                    tb_Phone.Text = selectedRow.Cells["sSoDT"].Value.ToString();
                    DateTime date = (DateTime)selectedRow.Cells["dNgayBan"].Value;
                    tb_date.Text = date.ToString("dd/MM/yyyy");
                    tb_name_employee.Text = selectedRow.Cells["sTenNV"].Value.ToString();
            }
        }
    }
}
