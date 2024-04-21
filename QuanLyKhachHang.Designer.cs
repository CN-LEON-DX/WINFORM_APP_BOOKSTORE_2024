
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_DanhSachKH = new System.Windows.Forms.DataGridView();
            this.sMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_MaKH = new System.Windows.Forms.ComboBox();
            this.tb_GioiTinh = new System.Windows.Forms.TextBox();
            this.tb_Sdt = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_TenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_DanhSachMua = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.bt_ThongKeEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachKH
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgv_DanhSachKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKH,
            this.sTenKH,
            this.sSoDT,
            this.sDiaChi,
            this.bGioiTinh,
            this.sEmail});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachKH.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DanhSachKH.Location = new System.Drawing.Point(19, 282);
            this.dgv_DanhSachKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DanhSachKH.Name = "dgv_DanhSachKH";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_DanhSachKH.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_DanhSachKH.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_DanhSachKH.RowTemplate.Height = 27;
            this.dgv_DanhSachKH.Size = new System.Drawing.Size(664, 137);
            this.dgv_DanhSachKH.TabIndex = 22;
            this.dgv_DanhSachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKH_CellClick);
            this.dgv_DanhSachKH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DanhSachKH_CellFormatting);
            // 
            // sMaKH
            // 
            this.sMaKH.DataPropertyName = "sMaKH";
            this.sMaKH.HeaderText = "Mã KH";
            this.sMaKH.Name = "sMaKH";
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenKH";
            this.sTenKH.HeaderText = "Họ và tên";
            this.sTenKH.Name = "sTenKH";
            // 
            // sSoDT
            // 
            this.sSoDT.DataPropertyName = "sSoDT";
            this.sSoDT.HeaderText = "Số điện thoại";
            this.sSoDT.Name = "sSoDT";
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.Name = "sDiaChi";
            // 
            // bGioiTinh
            // 
            this.bGioiTinh.DataPropertyName = "bGioiTinh";
            this.bGioiTinh.HeaderText = "Giới tính";
            this.bGioiTinh.Name = "bGioiTinh";
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.BackColor = System.Drawing.Color.White;
            this.cb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_MaKH.FormattingEnabled = true;
            this.cb_MaKH.Location = new System.Drawing.Point(171, 51);
            this.cb_MaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(186, 28);
            this.cb_MaKH.TabIndex = 21;
            this.cb_MaKH.SelectedIndexChanged += new System.EventHandler(this.cb_MaKH_SelectedIndexChanged);
            // 
            // tb_GioiTinh
            // 
            this.tb_GioiTinh.BackColor = System.Drawing.Color.White;
            this.tb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GioiTinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tb_GioiTinh.Location = new System.Drawing.Point(452, 100);
            this.tb_GioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.tb_GioiTinh.Name = "tb_GioiTinh";
            this.tb_GioiTinh.Size = new System.Drawing.Size(204, 26);
            this.tb_GioiTinh.TabIndex = 20;
            // 
            // tb_Sdt
            // 
            this.tb_Sdt.BackColor = System.Drawing.Color.White;
            this.tb_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sdt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tb_Sdt.Location = new System.Drawing.Point(485, 53);
            this.tb_Sdt.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Size = new System.Drawing.Size(171, 26);
            this.tb_Sdt.TabIndex = 19;
            this.tb_Sdt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.BackColor = System.Drawing.Color.White;
            this.tb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tb_DiaChi.Location = new System.Drawing.Point(101, 141);
            this.tb_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(256, 26);
            this.tb_DiaChi.TabIndex = 18;
            // 
            // tb_TenKH
            // 
            this.tb_TenKH.BackColor = System.Drawing.Color.White;
            this.tb_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenKH.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tb_TenKH.Location = new System.Drawing.Point(171, 94);
            this.tb_TenKH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TenKH.Name = "tb_TenKH";
            this.tb_TenKH.Size = new System.Drawing.Size(186, 26);
            this.tb_TenKH.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(2, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh sách khách hàng";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_ThongKe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThongKe.Location = new System.Drawing.Point(452, 199);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(94, 28);
            this.btn_ThongKe.TabIndex = 15;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_DanhSachMua
            // 
            this.btn_DanhSachMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_DanhSachMua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DanhSachMua.Location = new System.Drawing.Point(338, 199);
            this.btn_DanhSachMua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DanhSachMua.Name = "btn_DanhSachMua";
            this.btn_DanhSachMua.Size = new System.Drawing.Size(85, 28);
            this.btn_DanhSachMua.TabIndex = 14;
            this.btn_DanhSachMua.Text = "DS mua";
            this.btn_DanhSachMua.UseVisualStyleBackColor = true;
            this.btn_DanhSachMua.Click += new System.EventHandler(this.btn_DanhSachMua_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TimKiem.Location = new System.Drawing.Point(566, 199);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(96, 28);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.Location = new System.Drawing.Point(223, 199);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 28);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.Location = new System.Drawing.Point(124, 199);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 28);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them.Location = new System.Drawing.Point(19, 199);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 28);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(371, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(371, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(31, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quản lý khách hàng";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Email.Location = new System.Drawing.Point(371, 145);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(52, 20);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "Email:";
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.White;
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tb_Email.Location = new System.Drawing.Point(427, 142);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(229, 26);
            this.tb_Email.TabIndex = 20;
            // 
            // bt_ThongKeEmail
            // 
            this.bt_ThongKeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bt_ThongKeEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ThongKeEmail.Location = new System.Drawing.Point(452, 244);
            this.bt_ThongKeEmail.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ThongKeEmail.Name = "bt_ThongKeEmail";
            this.bt_ThongKeEmail.Size = new System.Drawing.Size(204, 28);
            this.bt_ThongKeEmail.TabIndex = 15;
            this.bt_ThongKeEmail.Text = "Thống kê theo email";
            this.bt_ThongKeEmail.UseVisualStyleBackColor = true;
            this.bt_ThongKeEmail.Click += new System.EventHandler(this.bt_ThongKeEmail_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(694, 431);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_DanhSachKH);
            this.Controls.Add(this.cb_MaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_GioiTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_TenKH);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.bt_ThongKeEmail);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_DanhSachMua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_TimKiem);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(710, 470);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_DanhSachMua;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Sdt;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_TenKH;
        private System.Windows.Forms.TextBox tb_GioiTinh;
        private System.Windows.Forms.ComboBox cb_MaKH;
        private System.Windows.Forms.DataGridView dgv_DanhSachKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button bt_ThongKeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
    }
}