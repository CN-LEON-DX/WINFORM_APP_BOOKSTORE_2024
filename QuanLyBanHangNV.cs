using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WINFORM_2024
{
    public partial class QuanLyBanHangNV : Form
    {

        // Declare variable 
        private Form curentFormChild;
        public QuanLyBanHangNV()
        {
            InitializeComponent();
            OpenChildForm(new QuanLyHoaDon());
            bt_manage_bill.ForeColor = ColorTranslator.FromHtml("#6633FF");
        }
        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
           
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoSize = false;
            panel_group.Controls.Add(childForm);
            panel_group.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyBanHangNV_Load(object sender, EventArgs e)
        {

        }
        // PHẦN CODE QUẢN LÝ HÓA ĐƠN ....
        private void bt_manage_bill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyHoaDon());
            changeColor(1);
        }
        // PHẦN CODE QUẢN LÝ KHÁCH HÀNG....
        private void bt_manage_customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
            changeColor(2);

        }

        // PHẦN CODE QUẢN LÝ KHO HÀNG....
        private void bt_warehouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyHangHoa());
            changeColor(3);
        }

        public void changeColor(int which_button_clicked)
        {
            //- 1 Hóa đơn, 2-Khách Hàng, 3-Kho hàng
            bt_manage_bill.ForeColor = Color.White;
            bt_manage_customer.ForeColor = Color.White;
            bt_warehouse.ForeColor = Color.White;
            switch (which_button_clicked)
            {
                case 1:
                    bt_manage_bill.ForeColor = ColorTranslator.FromHtml("#6633FF");
                    break;
                case 2:
                    bt_manage_customer.ForeColor = ColorTranslator.FromHtml("#6633FF");
                    break;
                case 3:
                    bt_warehouse.ForeColor = ColorTranslator.FromHtml("#6633FF");
                    break;
            }
        }

        private void panel_group_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_logout_Click(object sender, EventArgs e)
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
    }
}
