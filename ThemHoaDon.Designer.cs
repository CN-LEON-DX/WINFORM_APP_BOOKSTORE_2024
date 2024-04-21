
namespace BTL_WINFORM_2024
{
    partial class ThemHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.btn_ThemMH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.bt_create_now = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.DTGR_BangHD = new System.Windows.Forms.DataGridView();
            this.LB_Giamgia = new System.Windows.Forms.Label();
            this.LB_Tong = new System.Windows.Forms.Label();
            this.TB_GiamGia = new System.Windows.Forms.TextBox();
            this.TB_Tong = new System.Windows.Forms.TextBox();
            this.CB_LoaiHang = new System.Windows.Forms.ComboBox();
            this.CB_MatHang = new System.Windows.Forms.ComboBox();
            this.BT_Xoa = new System.Windows.Forms.Button();
            this.BT_Xuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGR_BangHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập thông tin";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(174, 43);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(271, 30);
            this.tb_name.TabIndex = 11;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged_1);
            this.tb_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_name_Validating);
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(599, 43);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(196, 30);
            this.tb_Phone.TabIndex = 12;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            this.tb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Phone_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(470, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ:";
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(174, 95);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(271, 30);
            this.tb_address.TabIndex = 11;
            this.tb_address.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // btn_ThemMH
            // 
            this.btn_ThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_ThemMH.Location = new System.Drawing.Point(236, 257);
            this.btn_ThemMH.Name = "btn_ThemMH";
            this.btn_ThemMH.Size = new System.Drawing.Size(180, 35);
            this.btn_ThemMH.TabIndex = 13;
            this.btn_ThemMH.Text = "Thêm mặt hàng";
            this.btn_ThemMH.UseVisualStyleBackColor = true;
            this.btn_ThemMH.Click += new System.EventHandler(this.btn_ThemMH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thêm loại hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(23, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thêm mặt hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(470, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới tính:";
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdb_Nam.Location = new System.Drawing.Point(599, 103);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(61, 22);
            this.rdb_Nam.TabIndex = 16;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdb_Nu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdb_Nu.Location = new System.Drawing.Point(747, 99);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(48, 22);
            this.rdb_Nu.TabIndex = 16;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // bt_create_now
            // 
            this.bt_create_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bt_create_now.Location = new System.Drawing.Point(17, 257);
            this.bt_create_now.Name = "bt_create_now";
            this.bt_create_now.Size = new System.Drawing.Size(180, 35);
            this.bt_create_now.TabIndex = 17;
            this.bt_create_now.Text = "Tạo đơn hàng";
            this.bt_create_now.UseVisualStyleBackColor = true;
            this.bt_create_now.Click += new System.EventHandler(this.bt_create_now_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(470, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng:";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(562, 195);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(166, 30);
            this.tb_Quantity.TabIndex = 12;
            this.tb_Quantity.Text = "1";
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            // 
            // DTGR_BangHD
            // 
            this.DTGR_BangHD.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DTGR_BangHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGR_BangHD.Location = new System.Drawing.Point(17, 311);
            this.DTGR_BangHD.Name = "DTGR_BangHD";
            this.DTGR_BangHD.RowHeadersWidth = 51;
            this.DTGR_BangHD.RowTemplate.Height = 24;
            this.DTGR_BangHD.Size = new System.Drawing.Size(549, 198);
            this.DTGR_BangHD.TabIndex = 18;
            // 
            // LB_Giamgia
            // 
            this.LB_Giamgia.AutoSize = true;
            this.LB_Giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Giamgia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LB_Giamgia.Location = new System.Drawing.Point(586, 434);
            this.LB_Giamgia.Name = "LB_Giamgia";
            this.LB_Giamgia.Size = new System.Drawing.Size(84, 24);
            this.LB_Giamgia.TabIndex = 19;
            this.LB_Giamgia.Text = "Giảm giá";
            // 
            // LB_Tong
            // 
            this.LB_Tong.AutoSize = true;
            this.LB_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LB_Tong.Location = new System.Drawing.Point(586, 485);
            this.LB_Tong.Name = "LB_Tong";
            this.LB_Tong.Size = new System.Drawing.Size(90, 24);
            this.LB_Tong.TabIndex = 20;
            this.LB_Tong.Text = "Tổng tiền";
            // 
            // TB_GiamGia
            // 
            this.TB_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GiamGia.Location = new System.Drawing.Point(676, 431);
            this.TB_GiamGia.Name = "TB_GiamGia";
            this.TB_GiamGia.Size = new System.Drawing.Size(193, 28);
            this.TB_GiamGia.TabIndex = 21;
            // 
            // TB_Tong
            // 
            this.TB_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Tong.Location = new System.Drawing.Point(676, 482);
            this.TB_Tong.Name = "TB_Tong";
            this.TB_Tong.Size = new System.Drawing.Size(193, 28);
            this.TB_Tong.TabIndex = 22;
            // 
            // CB_LoaiHang
            // 
            this.CB_LoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LoaiHang.FormattingEnabled = true;
            this.CB_LoaiHang.Location = new System.Drawing.Point(174, 144);
            this.CB_LoaiHang.Name = "CB_LoaiHang";
            this.CB_LoaiHang.Size = new System.Drawing.Size(271, 30);
            this.CB_LoaiHang.TabIndex = 23;
            this.CB_LoaiHang.SelectedIndexChanged += new System.EventHandler(this.CB_LoaiHang_SelectedIndexChanged);
            // 
            // CB_MatHang
            // 
            this.CB_MatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MatHang.FormattingEnabled = true;
            this.CB_MatHang.Location = new System.Drawing.Point(174, 195);
            this.CB_MatHang.Name = "CB_MatHang";
            this.CB_MatHang.Size = new System.Drawing.Size(271, 30);
            this.CB_MatHang.TabIndex = 24;
            this.CB_MatHang.SelectedIndexChanged += new System.EventHandler(this.CB_MatHang_SelectedIndexChanged);
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BT_Xoa.Location = new System.Drawing.Point(474, 257);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(180, 35);
            this.BT_Xoa.TabIndex = 25;
            this.BT_Xoa.Text = "Xóa đơn hàng";
            this.BT_Xoa.UseVisualStyleBackColor = true;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // BT_Xuat
            // 
            this.BT_Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BT_Xuat.Location = new System.Drawing.Point(689, 257);
            this.BT_Xuat.Name = "BT_Xuat";
            this.BT_Xuat.Size = new System.Drawing.Size(180, 35);
            this.BT_Xuat.TabIndex = 26;
            this.BT_Xuat.Text = "Xuất hóa đơn";
            this.BT_Xuat.UseVisualStyleBackColor = true;
            this.BT_Xuat.Click += new System.EventHandler(this.BT_Xuat_Click);
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(901, 527);
            this.Controls.Add(this.BT_Xuat);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.CB_MatHang);
            this.Controls.Add(this.CB_LoaiHang);
            this.Controls.Add(this.TB_Tong);
            this.Controls.Add(this.TB_GiamGia);
            this.Controls.Add(this.LB_Tong);
            this.Controls.Add(this.LB_Giamgia);
            this.Controls.Add(this.DTGR_BangHD);
            this.Controls.Add(this.bt_create_now);
            this.Controls.Add(this.rdb_Nu);
            this.Controls.Add(this.rdb_Nam);
            this.Controls.Add(this.btn_ThemMH);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(932, 757);
            this.Name = "ThemHoaDon";
            this.Text = "Tạo hóa đơn";
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGR_BangHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Button btn_ThemMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.Button bt_create_now;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.DataGridView DTGR_BangHD;
        private System.Windows.Forms.Label LB_Giamgia;
        private System.Windows.Forms.Label LB_Tong;
        private System.Windows.Forms.TextBox TB_GiamGia;
        private System.Windows.Forms.TextBox TB_Tong;
        private System.Windows.Forms.ComboBox CB_LoaiHang;
        private System.Windows.Forms.ComboBox CB_MatHang;
        private System.Windows.Forms.Button BT_Xoa;
        private System.Windows.Forms.Button BT_Xuat;
    }
}