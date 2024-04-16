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
    public partial class QuanLyHangHoa : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public QuanLyHangHoa()
        {
            InitializeComponent();
            LoadDataIntoDSHH();
        }
        private void LoadDataIntoDSHH()
        {
            string query = "SELECT * FROM tblHangHoa";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }
            DTG_DSHH.DataSource = dt;
            DTG_DSHH.Columns[0].HeaderText = "Mã hàng hóa";
            DTG_DSHH.Columns[1].HeaderText = "Mã loại hàng";
            DTG_DSHH.Columns[2].HeaderText = "Tên hàng hóa";
            DTG_DSHH.Columns[3].HeaderText = "Giá bán";
            DTG_DSHH.Columns[4].HeaderText = "Số lượng";
            DTG_DSHH.Columns[5].HeaderText = "Đơn vị tính";

        }


        private void QuanLyHangHoa_Load(object sender, EventArgs e)
        {

        }

        private void LB_TOP_Click(object sender, EventArgs e)
        {

        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (DTG_DSHH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in DTG_DSHH.SelectedRows)
                    {
                        string idToDelete = row.Cells["sMaMH"].Value.ToString();
                        string delete = "DELETE FROM tblHangHoa WHERE sMaMH = @ma ";
                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ma", idToDelete);
                            cmd.ExecuteNonQuery();
                        }
                        DTG_DSHH.Rows.Remove(row);
                    }
                    conn.Close();
                }
            }
        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            LoadDataIntoDSHH();
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            NhapHangHoa nhapHang = new NhapHangHoa();
            nhapHang.ShowDialog();
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            SuaHangHoa suaHangHoa = new SuaHangHoa();
            suaHangHoa.ShowDialog();
        }

        private void BT_Baocao_Click(object sender, EventArgs e)
        {
            bool check = RB_Boloc.Checked;
            FormBCDSHH formBCDSHH = new FormBCDSHH(check);
            formBCDSHH.ShowDialog();

        }
    }
}
