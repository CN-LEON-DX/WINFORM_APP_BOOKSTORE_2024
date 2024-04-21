namespace BTL_WINFORM_2024
{
    partial class XemCTDonHang
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
            this.LB_TongTien = new System.Windows.Forms.Label();
            this.TB_TongTien = new System.Windows.Forms.TextBox();
            this.LB_Giamgia = new System.Windows.Forms.Label();
            this.TB_GiamGia = new System.Windows.Forms.TextBox();
            this.DTGR_CTHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGR_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TongTien
            // 
            this.LB_TongTien.AutoSize = true;
            this.LB_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TongTien.Location = new System.Drawing.Point(408, 324);
            this.LB_TongTien.Name = "LB_TongTien";
            this.LB_TongTien.Size = new System.Drawing.Size(90, 24);
            this.LB_TongTien.TabIndex = 0;
            this.LB_TongTien.Text = "Tổng tiền";
            // 
            // TB_TongTien
            // 
            this.TB_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TongTien.Location = new System.Drawing.Point(511, 324);
            this.TB_TongTien.Name = "TB_TongTien";
            this.TB_TongTien.Size = new System.Drawing.Size(155, 28);
            this.TB_TongTien.TabIndex = 1;
            // 
            // LB_Giamgia
            // 
            this.LB_Giamgia.AutoSize = true;
            this.LB_Giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Giamgia.Location = new System.Drawing.Point(408, 271);
            this.LB_Giamgia.Name = "LB_Giamgia";
            this.LB_Giamgia.Size = new System.Drawing.Size(84, 24);
            this.LB_Giamgia.TabIndex = 2;
            this.LB_Giamgia.Text = "Giảm giá";
            this.LB_Giamgia.Click += new System.EventHandler(this.LB_Giamgia_Click);
            // 
            // TB_GiamGia
            // 
            this.TB_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GiamGia.Location = new System.Drawing.Point(511, 268);
            this.TB_GiamGia.Name = "TB_GiamGia";
            this.TB_GiamGia.Size = new System.Drawing.Size(155, 28);
            this.TB_GiamGia.TabIndex = 3;
            // 
            // DTGR_CTHD
            // 
            this.DTGR_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGR_CTHD.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DTGR_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGR_CTHD.Location = new System.Drawing.Point(12, 12);
            this.DTGR_CTHD.Name = "DTGR_CTHD";
            this.DTGR_CTHD.RowHeadersWidth = 51;
            this.DTGR_CTHD.RowTemplate.Height = 24;
            this.DTGR_CTHD.Size = new System.Drawing.Size(654, 234);
            this.DTGR_CTHD.TabIndex = 4;
            // 
            // XemCTDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.DTGR_CTHD);
            this.Controls.Add(this.TB_GiamGia);
            this.Controls.Add(this.LB_Giamgia);
            this.Controls.Add(this.TB_TongTien);
            this.Controls.Add(this.LB_TongTien);
            this.Name = "XemCTDonHang";
            this.Text = "Chi Tiết Đơn Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.DTGR_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TongTien;
        private System.Windows.Forms.TextBox TB_TongTien;
        private System.Windows.Forms.Label LB_Giamgia;
        private System.Windows.Forms.TextBox TB_GiamGia;
        private System.Windows.Forms.DataGridView DTGR_CTHD;
    }
}