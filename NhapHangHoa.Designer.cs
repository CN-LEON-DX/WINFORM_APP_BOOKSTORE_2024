namespace BTL_WINFORM_2024
{
    partial class NhapHangHoa
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
            this.LB_TOPNhap = new System.Windows.Forms.Label();
            this.TB_LoaiHang = new System.Windows.Forms.Label();
            this.LB_TenMH = new System.Windows.Forms.Label();
            this.LB_Gia = new System.Windows.Forms.Label();
            this.LB_DVT = new System.Windows.Forms.Label();
            this.LB_Soluong = new System.Windows.Forms.Label();
            this.CB_LoaiHang = new System.Windows.Forms.ComboBox();
            this.TB_TenMH = new System.Windows.Forms.TextBox();
            this.TB_DVT = new System.Windows.Forms.TextBox();
            this.TB_Soluong = new System.Windows.Forms.TextBox();
            this.TB_Gia = new System.Windows.Forms.TextBox();
            this.BT_Themmoi = new System.Windows.Forms.Button();
            this.BT_Xoa = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_TOPNhap
            // 
            this.LB_TOPNhap.AutoSize = true;
            this.LB_TOPNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOPNhap.Location = new System.Drawing.Point(208, 9);
            this.LB_TOPNhap.Name = "LB_TOPNhap";
            this.LB_TOPNhap.Size = new System.Drawing.Size(205, 26);
            this.LB_TOPNhap.TabIndex = 0;
            this.LB_TOPNhap.Text = "Nhập Mặt Hàng Mới";
            // 
            // TB_LoaiHang
            // 
            this.TB_LoaiHang.AutoSize = true;
            this.TB_LoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LoaiHang.Location = new System.Drawing.Point(12, 53);
            this.TB_LoaiHang.Name = "TB_LoaiHang";
            this.TB_LoaiHang.Size = new System.Drawing.Size(126, 24);
            this.TB_LoaiHang.TabIndex = 1;
            this.TB_LoaiHang.Text = "Tên loại hàng";
            // 
            // LB_TenMH
            // 
            this.LB_TenMH.AutoSize = true;
            this.LB_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TenMH.Location = new System.Drawing.Point(12, 108);
            this.LB_TenMH.Name = "LB_TenMH";
            this.LB_TenMH.Size = new System.Drawing.Size(127, 24);
            this.LB_TenMH.TabIndex = 2;
            this.LB_TenMH.Text = "Tên mặt hàng";
            // 
            // LB_Gia
            // 
            this.LB_Gia.AutoSize = true;
            this.LB_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gia.Location = new System.Drawing.Point(12, 166);
            this.LB_Gia.Name = "LB_Gia";
            this.LB_Gia.Size = new System.Drawing.Size(75, 24);
            this.LB_Gia.TabIndex = 3;
            this.LB_Gia.Text = "Giá bán";
            // 
            // LB_DVT
            // 
            this.LB_DVT.AutoSize = true;
            this.LB_DVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DVT.Location = new System.Drawing.Point(374, 53);
            this.LB_DVT.Name = "LB_DVT";
            this.LB_DVT.Size = new System.Drawing.Size(98, 24);
            this.LB_DVT.TabIndex = 4;
            this.LB_DVT.Text = "Đơn vị tính";
            // 
            // LB_Soluong
            // 
            this.LB_Soluong.AutoSize = true;
            this.LB_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Soluong.Location = new System.Drawing.Point(374, 108);
            this.LB_Soluong.Name = "LB_Soluong";
            this.LB_Soluong.Size = new System.Drawing.Size(86, 24);
            this.LB_Soluong.TabIndex = 5;
            this.LB_Soluong.Text = "Số lượng";
            // 
            // CB_LoaiHang
            // 
            this.CB_LoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LoaiHang.FormattingEnabled = true;
            this.CB_LoaiHang.Location = new System.Drawing.Point(144, 50);
            this.CB_LoaiHang.Name = "CB_LoaiHang";
            this.CB_LoaiHang.Size = new System.Drawing.Size(190, 30);
            this.CB_LoaiHang.TabIndex = 6;
            this.CB_LoaiHang.SelectedIndexChanged += new System.EventHandler(this.CB_LoaiHang_SelectedIndexChanged);
            this.CB_LoaiHang.DropDownClosed += new System.EventHandler(this.CB_LoaiHang_DropDownClosed);
            // 
            // TB_TenMH
            // 
            this.TB_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TenMH.Location = new System.Drawing.Point(145, 108);
            this.TB_TenMH.Name = "TB_TenMH";
            this.TB_TenMH.Size = new System.Drawing.Size(189, 28);
            this.TB_TenMH.TabIndex = 7;
            this.TB_TenMH.TextChanged += new System.EventHandler(this.TB_TenMH_TextChanged);
            this.TB_TenMH.Leave += new System.EventHandler(this.TB_TenMH_Leave);
            // 
            // TB_DVT
            // 
            this.TB_DVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DVT.Location = new System.Drawing.Point(478, 50);
            this.TB_DVT.Name = "TB_DVT";
            this.TB_DVT.Size = new System.Drawing.Size(189, 28);
            this.TB_DVT.TabIndex = 8;
            this.TB_DVT.TextChanged += new System.EventHandler(this.TB_DVT_TextChanged);
            this.TB_DVT.Leave += new System.EventHandler(this.TB_DVT_Leave);
            // 
            // TB_Soluong
            // 
            this.TB_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Soluong.Location = new System.Drawing.Point(478, 108);
            this.TB_Soluong.Name = "TB_Soluong";
            this.TB_Soluong.Size = new System.Drawing.Size(189, 28);
            this.TB_Soluong.TabIndex = 9;
            this.TB_Soluong.TextChanged += new System.EventHandler(this.TB_Soluong_TextChanged);
            this.TB_Soluong.Leave += new System.EventHandler(this.TB_Soluong_Leave);
            // 
            // TB_Gia
            // 
            this.TB_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Gia.Location = new System.Drawing.Point(144, 166);
            this.TB_Gia.Name = "TB_Gia";
            this.TB_Gia.Size = new System.Drawing.Size(189, 28);
            this.TB_Gia.TabIndex = 10;
            this.TB_Gia.TextChanged += new System.EventHandler(this.TB_Gia_TextChanged);
            this.TB_Gia.Leave += new System.EventHandler(this.TB_Gia_Leave);
            // 
            // BT_Themmoi
            // 
            this.BT_Themmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Themmoi.Location = new System.Drawing.Point(17, 215);
            this.BT_Themmoi.Name = "BT_Themmoi";
            this.BT_Themmoi.Size = new System.Drawing.Size(152, 57);
            this.BT_Themmoi.TabIndex = 11;
            this.BT_Themmoi.Text = "Thêm mới";
            this.BT_Themmoi.UseVisualStyleBackColor = true;
            this.BT_Themmoi.Click += new System.EventHandler(this.BT_Themmoi_Click);
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Xoa.Location = new System.Drawing.Point(203, 215);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(152, 57);
            this.BT_Xoa.TabIndex = 12;
            this.BT_Xoa.Text = "Xóa";
            this.BT_Xoa.UseVisualStyleBackColor = true;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Thoat.Location = new System.Drawing.Point(378, 215);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(152, 57);
            this.BT_Thoat.TabIndex = 13;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = true;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            // 
            // NhapHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.BT_Themmoi);
            this.Controls.Add(this.TB_Gia);
            this.Controls.Add(this.TB_Soluong);
            this.Controls.Add(this.TB_DVT);
            this.Controls.Add(this.TB_TenMH);
            this.Controls.Add(this.CB_LoaiHang);
            this.Controls.Add(this.LB_Soluong);
            this.Controls.Add(this.LB_DVT);
            this.Controls.Add(this.LB_Gia);
            this.Controls.Add(this.LB_TenMH);
            this.Controls.Add(this.TB_LoaiHang);
            this.Controls.Add(this.LB_TOPNhap);
            this.Name = "NhapHangHoa";
            this.Text = "Nhập hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TOPNhap;
        private System.Windows.Forms.Label TB_LoaiHang;
        private System.Windows.Forms.Label LB_TenMH;
        private System.Windows.Forms.Label LB_Gia;
        private System.Windows.Forms.Label LB_DVT;
        private System.Windows.Forms.Label LB_Soluong;
        private System.Windows.Forms.ComboBox CB_LoaiHang;
        private System.Windows.Forms.TextBox TB_TenMH;
        private System.Windows.Forms.TextBox TB_DVT;
        private System.Windows.Forms.TextBox TB_Soluong;
        private System.Windows.Forms.TextBox TB_Gia;
        private System.Windows.Forms.Button BT_Themmoi;
        private System.Windows.Forms.Button BT_Xoa;
        private System.Windows.Forms.Button BT_Thoat;
    }
}