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
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace BTL_WINFORM_2024
{
    public partial class XuatHoaDon : Form
    {
        int SoHD;
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public XuatHoaDon(int soHD)
        {
            InitializeComponent();
            SoHD = soHD;
            XuatHoaDonKH(soHD);
        }
        private void XuatHoaDonKH(int soHD)
        {
            string query = "InHD";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iSoHD", soHD);
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            ReportDocument report = new ReportDocument();
                            string path = string.Format("{0}\\{1}",
                                Application.StartupPath, "HoaDonKhach.rpt");
                            report.Load(path);
                            report.Database.Tables["InHD"].SetDataSource(dt);
                            HoaDon.ReportSource = report;
                            HoaDon.Refresh();
                        }
                    }
                }
            }

        }
    }
}
