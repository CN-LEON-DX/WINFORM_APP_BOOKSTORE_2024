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
    public partial class XemCTDonHang : Form
    {
        int SoHD;
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTl"].ConnectionString;
        public XemCTDonHang(int soHD)
        {
            InitializeComponent();
            SoHD = soHD;
            LoadDataintoDTGR(soHD);
            LayGiamGia(soHD);
            TinhTongTien();
        }
        private void LoadDataintoDTGR(int soHD)
        {
            string query = "XemCTDH";
            DataTable dt = new DataTable();
            using(SqlConnection  conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query,conn))
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaHD", soHD);
                    using(SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                    }
                }
            }
            DTGR_CTHD.DataSource = dt;
            DTGR_CTHD.Columns[0].HeaderText = "Mặt hàng";
            DTGR_CTHD.Columns[1].HeaderText = "Số lượng";
            DTGR_CTHD.Columns[2].HeaderText = "Giá bán";
            DTGR_CTHD.Columns[3].HeaderText = "Thành Tiền";

        }
        private void LayGiamGia(int soHD)
        {
            string query = "SELECT TOP 1 fGiamGia FROM tblCTHoaDon WHERE iSoHD = @Ma";
            using(SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query,conn))
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
            foreach(DataGridViewRow row in DTGR_CTHD.Rows)
            {
                object cellValue = row.Cells["ThanhTien"].Value;
                if(cellValue != null && cellValue.ToString() != "")
                {
                    double number;
                    if(double.TryParse(cellValue.ToString(), out number))
                    {
                       total += number;
                        
                    }
                }
            }
            if(sale > 0)
            {
                total = total * (1 - sale);

            }
            TB_TongTien.Text = total.ToString();
        }

        private void LB_Giamgia_Click(object sender, EventArgs e)
        {

        }
    }
}
