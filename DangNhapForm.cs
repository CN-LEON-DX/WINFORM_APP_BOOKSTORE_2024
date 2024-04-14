using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;
namespace BTL_WINFORM_2024
{
    public partial class DangNhapForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBTL"].ConnectionString;
        private Timer timer;
        public DangNhapForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100; // 1 giây
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Chào admin !");
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {

            
        }

        private void click_text_clear(object sender, EventArgs e)
        {
            tb_Acc.Clear();
        }
        private void click_text_clear_pass(object sender, EventArgs e)
        {
            tb_Pass.Clear();
        }

        
        private void click_login(object sender, EventArgs e)
        {
            string user_acc = tb_Acc.Text.Trim();
            string pass_acc = tb_Pass.Text;

            int who_using = -1; 
            if (user_acc.Length == 0 || pass_acc.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu !");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TOP 1 iRole FROM tblTaiKhoan WHERE sTenTK = @user_acc AND sMatKhau = @pass_acc";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@user_acc", user_acc);
                        command.Parameters.AddWithValue("@pass_acc", pass_acc);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            who_using = Convert.ToInt32(result);
                            timer.Start();
                            Form form_next;
                            switch (who_using)
                            {
                                case 1:
                                    // Admin
                                    form_next = new QLNhanVien1();
                                    form_next.Show();
                                    this.Hide();
                                    // Form Đăng nhập hiện tại sẽ bị đóng 
                                    break;
                                case 2:
                                    // Employee
                                    form_next = new QuanLyBanHangNV();
                                    form_next.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu hoặc tài khoản !");
                        }
                    }
                }
            }

        }

        private void click_reset_password(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ admin để lấy lại mật khẩu !", "Lấy lại mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void click_enter_confirm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                click_login(sender, e);
            }
        }
    }
}
