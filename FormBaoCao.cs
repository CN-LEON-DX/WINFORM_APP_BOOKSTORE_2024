using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormBaoCao : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;

        public FormBaoCao()
        {
            InitializeComponent();
        }

        public void ShowReport(string name_report, string name_proc, string filter)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    comm.CommandText = name_proc;
                    comm.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = comm;
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            // Load data to report
                            ReportDocument report = new ReportDocument();
                            string path = string.Format("{0}\\BaoCao\\{1}",
                                Application.StartupPath, name_report);
                            report.Load(path);
                            report.Database.Tables[name_proc].SetDataSource(dt);

                            report.SetParameterValue("sNguoiLap", "Nguyễn Chính Siu");

                            crystalReportViewer1.ReportSource = report;
                            crystalReportViewer1.Refresh();
                        }
                    }
                }
            }
        }
  

        private void FormBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
