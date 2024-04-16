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
    public partial class FormBCDSHH : Form
    {
        private bool check;
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        public FormBCDSHH(bool check)
        {
            InitializeComponent();
            this.check = check;
            XuatBaoCaoTheoYC(check);

        }
        private void LoadBaoCaoDSHH()
        {
            string query = "LayDSHH";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            ReportDocument report = new ReportDocument();
                            string path = string.Format("{0}\\BaoCao\\{1}",
                                Application.StartupPath, "DanhSachHangHoa.rpt");
                            report.Load(path);
                            report.Database.Tables["LayDSHH"].SetDataSource(dt);
                            ReportDSHH.ReportSource = report;
                            ReportDSHH.Refresh();
                        }
                    }
                }
            }

        }
        private void LoadBCtheoLoai()
        {
            string query = "LocDStheoTL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            ReportDocument report = new ReportDocument();
                            string path = string.Format("{0}\\BaoCao\\{1}",
                                Application.StartupPath, "DanhSachHangHoaTheoLoai.rpt");
                            report.Load(path);
                            report.Database.Tables["LocDStheoTL"].SetDataSource(dt);
                            ReportDSHH.ReportSource = report;
                            ReportDSHH.Refresh();
                        }
                    }
                }
            }

        }
        private void XuatBaoCaoTheoYC(bool check)
        {
            if (check)
            {
                LoadBCtheoLoai();
            }
            else
            {
                LoadBaoCaoDSHH();
            }
        }
    }
}
