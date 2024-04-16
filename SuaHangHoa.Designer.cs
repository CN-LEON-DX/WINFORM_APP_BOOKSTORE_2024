namespace BTL_WINFORM_2024
{
    partial class SuaHangHoa
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
            this.LB_TopSua = new System.Windows.Forms.Label();
            this.LB_MaMH = new System.Windows.Forms.Label();
            this.LB_DVT = new System.Windows.Forms.Label();
            this.LB_Loaihang = new System.Windows.Forms.Label();
            this.LB_Gia = new System.Windows.Forms.Label();
            this.LB_tenMH = new System.Windows.Forms.Label();
            this.LB_Soluong = new System.Windows.Forms.Label();
            this.CB_MaMH = new System.Windows.Forms.ComboBox();
            this.CB_LoaiHH = new System.Windows.Forms.ComboBox();
            this.TB_TenMH = new System.Windows.Forms.TextBox();
            this.TB_DVT = new System.Windows.Forms.TextBox();
            this.TB_Giaban = new System.Windows.Forms.TextBox();
            this.TB_Soluong = new System.Windows.Forms.TextBox();
            this.BT_Sua = new System.Windows.Forms.Button();
            this.BT_Xoa = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_TopSua
            // 
            this.LB_TopSua.AutoSize = true;
            this.LB_TopSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TopSua.Location = new System.Drawing.Point(195, 9);
            this.LB_TopSua.Name = "LB_TopSua";
            this.LB_TopSua.Size = new System.Drawing.Size(266, 25);
            this.LB_TopSua.TabIndex = 0;
            this.LB_TopSua.Text = "Chỉnh sửa thông tin mặt hàng";
            // 
            // LB_MaMH
            // 
            this.LB_MaMH.AutoSize = true;
            this.LB_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaMH.Location = new System.Drawing.Point(12, 46);
            this.LB_MaMH.Name = "LB_MaMH";
            this.LB_MaMH.Size = new System.Drawing.Size(119, 24);
            this.LB_MaMH.TabIndex = 1;
            this.LB_MaMH.Text = "Mã mặt hàng";
            // 
            // LB_DVT
            // 
            this.LB_DVT.AutoSize = true;
            this.LB_DVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DVT.Location = new System.Drawing.Point(354, 99);
            this.LB_DVT.Name = "LB_DVT";
            this.LB_DVT.Size = new System.Drawing.Size(98, 24);
            this.LB_DVT.TabIndex = 2;
            this.LB_DVT.Text = "Đơn vị tính";
            // 
            // LB_Loaihang
            // 
            this.LB_Loaihang.AutoSize = true;
            this.LB_Loaihang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Loaihang.Location = new System.Drawing.Point(354, 46);
            this.LB_Loaihang.Name = "LB_Loaihang";
            this.LB_Loaihang.Size = new System.Drawing.Size(93, 24);
            this.LB_Loaihang.TabIndex = 3;
            this.LB_Loaihang.Text = "Loại hàng";
            // 
            // LB_Gia
            // 
            this.LB_Gia.AutoSize = true;
            this.LB_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gia.Location = new System.Drawing.Point(12, 157);
            this.LB_Gia.Name = "LB_Gia";
            this.LB_Gia.Size = new System.Drawing.Size(75, 24);
            this.LB_Gia.TabIndex = 4;
            this.LB_Gia.Text = "Giá bán";
            // 
            // LB_tenMH
            // 
            this.LB_tenMH.AutoSize = true;
            this.LB_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tenMH.Location = new System.Drawing.Point(12, 99);
            this.LB_tenMH.Name = "LB_tenMH";
            this.LB_tenMH.Size = new System.Drawing.Size(127, 24);
            this.LB_tenMH.TabIndex = 5;
            this.LB_tenMH.Text = "Tên mặt hàng";
            // 
            // LB_Soluong
            // 
            this.LB_Soluong.AutoSize = true;
            this.LB_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Soluong.Location = new System.Drawing.Point(354, 157);
            this.LB_Soluong.Name = "LB_Soluong";
            this.LB_Soluong.Size = new System.Drawing.Size(86, 24);
            this.LB_Soluong.TabIndex = 6;
            this.LB_Soluong.Text = "Số lượng";
            // 
            // CB_MaMH
            // 
            this.CB_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MaMH.FormattingEnabled = true;
            this.CB_MaMH.Location = new System.Drawing.Point(152, 46);
            this.CB_MaMH.Name = "CB_MaMH";
            this.CB_MaMH.Size = new System.Drawing.Size(185, 30);
            this.CB_MaMH.TabIndex = 7;
            this.CB_MaMH.SelectedIndexChanged += new System.EventHandler(this.CB_MaMH_SelectedIndexChanged);
            // 
            // CB_LoaiHH
            // 
            this.CB_LoaiHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LoaiHH.FormattingEnabled = true;
            this.CB_LoaiHH.Location = new System.Drawing.Point(468, 46);
            this.CB_LoaiHH.Name = "CB_LoaiHH";
            this.CB_LoaiHH.Size = new System.Drawing.Size(202, 30);
            this.CB_LoaiHH.TabIndex = 8;
            this.CB_LoaiHH.SelectedIndexChanged += new System.EventHandler(this.CB_LoaiHH_SelectedIndexChanged);
            // 
            // TB_TenMH
            // 
            this.TB_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TenMH.Location = new System.Drawing.Point(152, 96);
            this.TB_TenMH.Name = "TB_TenMH";
            this.TB_TenMH.Size = new System.Drawing.Size(185, 28);
            this.TB_TenMH.TabIndex = 9;
            this.TB_TenMH.TextChanged += new System.EventHandler(this.TB_TenMH_TextChanged);
            this.TB_TenMH.Leave += new System.EventHandler(this.TB_TenMH_Leave);
            // 
            // TB_DVT
            // 
            this.TB_DVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DVT.Location = new System.Drawing.Point(468, 95);
            this.TB_DVT.Name = "TB_DVT";
            this.TB_DVT.Size = new System.Drawing.Size(202, 28);
            this.TB_DVT.TabIndex = 10;
            this.TB_DVT.TextChanged += new System.EventHandler(this.TB_DVT_TextChanged);
            this.TB_DVT.Leave += new System.EventHandler(this.TB_DVT_Leave);
            // 
            // TB_Giaban
            // 
            this.TB_Giaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Giaban.Location = new System.Drawing.Point(152, 157);
            this.TB_Giaban.Name = "TB_Giaban";
            this.TB_Giaban.Size = new System.Drawing.Size(185, 28);
            this.TB_Giaban.TabIndex = 11;
            this.TB_Giaban.TextChanged += new System.EventHandler(this.TB_Giaban_TextChanged);
            this.TB_Giaban.Leave += new System.EventHandler(this.TB_Giaban_Leave);
            // 
            // TB_Soluong
            // 
            this.TB_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Soluong.Location = new System.Drawing.Point(468, 157);
            this.TB_Soluong.Name = "TB_Soluong";
            this.TB_Soluong.Size = new System.Drawing.Size(202, 28);
            this.TB_Soluong.TabIndex = 12;
            this.TB_Soluong.TextChanged += new System.EventHandler(this.TB_Soluong_TextChanged);
            this.TB_Soluong.Leave += new System.EventHandler(this.TB_Soluong_Leave);
            // 
            // BT_Sua
            // 
            this.BT_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Sua.Location = new System.Drawing.Point(16, 216);
            this.BT_Sua.Name = "BT_Sua";
            this.BT_Sua.Size = new System.Drawing.Size(148, 60);
            this.BT_Sua.TabIndex = 13;
            this.BT_Sua.Text = "Sửa thông tin";
            this.BT_Sua.UseVisualStyleBackColor = true;
            this.BT_Sua.Click += new System.EventHandler(this.BT_Sua_Click);
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Xoa.Location = new System.Drawing.Point(189, 216);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(148, 60);
            this.BT_Xoa.TabIndex = 14;
            this.BT_Xoa.Text = "Xóa";
            this.BT_Xoa.UseVisualStyleBackColor = true;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Thoat.Location = new System.Drawing.Point(358, 216);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(148, 60);
            this.BT_Thoat.TabIndex = 15;
            this.BT_Thoat.Text = "Thoát\r\n";
            this.BT_Thoat.UseVisualStyleBackColor = true;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            // 
            // SuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.BT_Sua);
            this.Controls.Add(this.TB_Soluong);
            this.Controls.Add(this.TB_Giaban);
            this.Controls.Add(this.TB_DVT);
            this.Controls.Add(this.TB_TenMH);
            this.Controls.Add(this.CB_LoaiHH);
            this.Controls.Add(this.CB_MaMH);
            this.Controls.Add(this.LB_Soluong);
            this.Controls.Add(this.LB_tenMH);
            this.Controls.Add(this.LB_Gia);
            this.Controls.Add(this.LB_Loaihang);
            this.Controls.Add(this.LB_DVT);
            this.Controls.Add(this.LB_MaMH);
            this.Controls.Add(this.LB_TopSua);
            this.Name = "SuaHangHoa";
            this.Text = "Sửa thông tin mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TopSua;
        private System.Windows.Forms.Label LB_MaMH;
        private System.Windows.Forms.Label LB_DVT;
        private System.Windows.Forms.Label LB_Loaihang;
        private System.Windows.Forms.Label LB_Gia;
        private System.Windows.Forms.Label LB_tenMH;
        private System.Windows.Forms.Label LB_Soluong;
        private System.Windows.Forms.ComboBox CB_MaMH;
        private System.Windows.Forms.ComboBox CB_LoaiHH;
        private System.Windows.Forms.TextBox TB_TenMH;
        private System.Windows.Forms.TextBox TB_DVT;
        private System.Windows.Forms.TextBox TB_Giaban;
        private System.Windows.Forms.TextBox TB_Soluong;
        private System.Windows.Forms.Button BT_Sua;
        private System.Windows.Forms.Button BT_Xoa;
        private System.Windows.Forms.Button BT_Thoat;
    }
}