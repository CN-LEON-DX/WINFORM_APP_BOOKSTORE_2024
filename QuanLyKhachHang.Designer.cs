
namespace BTL_WINFORM_2024
{
    partial class QuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachKH = new System.Windows.Forms.DataGridView();
            this.sMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_DanhSachMua = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_Sdt = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.cb_MaKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSachKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_ThongKe);
            this.groupBox1.Controls.Add(this.btn_DanhSachMua);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.lb_GioiTinh);
            this.groupBox1.Controls.Add(this.lb_Sdt);
            this.groupBox1.Controls.Add(this.lb_DiaChi);
            this.groupBox1.Controls.Add(this.lb_TenKH);
            this.groupBox1.Controls.Add(this.cb_MaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dgv_DanhSachKH
            // 
            this.dgv_DanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKH,
            this.sTenKH,
            this.sDiaChi,
            this.sSoDT,
            this.bGioiTinh});
            this.dgv_DanhSachKH.Location = new System.Drawing.Point(36, 352);
            this.dgv_DanhSachKH.Name = "dgv_DanhSachKH";
            this.dgv_DanhSachKH.RowHeadersWidth = 51;
            this.dgv_DanhSachKH.RowTemplate.Height = 24;
            this.dgv_DanhSachKH.Size = new System.Drawing.Size(852, 162);
            this.dgv_DanhSachKH.TabIndex = 17;
            // 
            // sMaKH
            // 
            this.sMaKH.DataPropertyName = "sMaKH";
            this.sMaKH.HeaderText = "Mã KH";
            this.sMaKH.MinimumWidth = 6;
            this.sMaKH.Name = "sMaKH";
            this.sMaKH.Width = 80;
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenKH";
            this.sTenKH.HeaderText = "Họ và tên";
            this.sTenKH.MinimumWidth = 6;
            this.sTenKH.Name = "sTenKH";
            this.sTenKH.Width = 125;
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.MinimumWidth = 6;
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.Width = 125;
            // 
            // sSoDT
            // 
            this.sSoDT.DataPropertyName = "sSoDT";
            this.sSoDT.HeaderText = "Số điện thoại";
            this.sSoDT.MinimumWidth = 6;
            this.sSoDT.Name = "sSoDT";
            this.sSoDT.Width = 150;
            // 
            // bGioiTinh
            // 
            this.bGioiTinh.DataPropertyName = "bGioiTinh";
            this.bGioiTinh.HeaderText = "Giới tính";
            this.bGioiTinh.MinimumWidth = 6;
            this.bGioiTinh.Name = "bGioiTinh";
            this.bGioiTinh.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh sách khách hàng";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(731, 257);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(114, 47);
            this.btn_ThongKe.TabIndex = 15;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_DanhSachMua
            // 
            this.btn_DanhSachMua.Location = new System.Drawing.Point(592, 257);
            this.btn_DanhSachMua.Name = "btn_DanhSachMua";
            this.btn_DanhSachMua.Size = new System.Drawing.Size(105, 47);
            this.btn_DanhSachMua.TabIndex = 14;
            this.btn_DanhSachMua.Text = "DS mua";
            this.btn_DanhSachMua.UseVisualStyleBackColor = true;
            this.btn_DanhSachMua.Click += new System.EventHandler(this.btn_DanhSachMua_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(453, 257);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(105, 47);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(314, 257);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 47);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(175, 257);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(105, 47);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(36, 257);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(105, 47);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Location = new System.Drawing.Point(541, 198);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(67, 26);
            this.lb_GioiTinh.TabIndex = 9;
            this.lb_GioiTinh.Text = "label9";
            // 
            // lb_Sdt
            // 
            this.lb_Sdt.AutoSize = true;
            this.lb_Sdt.Location = new System.Drawing.Point(574, 126);
            this.lb_Sdt.Name = "lb_Sdt";
            this.lb_Sdt.Size = new System.Drawing.Size(67, 26);
            this.lb_Sdt.TabIndex = 8;
            this.lb_Sdt.Text = "label8";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(165, 198);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(67, 26);
            this.lb_DiaChi.TabIndex = 7;
            this.lb_DiaChi.Text = "label7";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(233, 126);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(67, 26);
            this.lb_TenKH.TabIndex = 6;
            this.lb_TenKH.Text = "label6";
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.FormattingEnabled = true;
            this.cb_MaKH.Location = new System.Drawing.Point(227, 52);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(296, 34);
            this.cb_MaKH.TabIndex = 5;
            this.cb_MaKH.SelectedIndexChanged += new System.EventHandler(this.cb_MaKH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng: ";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 520);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(912, 567);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MaKH;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_Sdt;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_DanhSachMua;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_DanhSachKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioiTinh;
    }
}