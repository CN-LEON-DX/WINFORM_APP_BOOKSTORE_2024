
namespace BTL_WINFORM_2024
{
    partial class QuanLyHangHoa
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
            this.LB_TOP = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.BT_Refresh = new System.Windows.Forms.Button();
            this.RB_Boloc = new System.Windows.Forms.RadioButton();
            this.DTG_DSHH = new System.Windows.Forms.DataGridView();
            this.BT_Them = new System.Windows.Forms.Button();
            this.BT_Sua = new System.Windows.Forms.Button();
            this.BT_Xoa = new System.Windows.Forms.Button();
            this.BT_Baocao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_DSHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TOP
            // 
            this.LB_TOP.AutoSize = true;
            this.LB_TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOP.Location = new System.Drawing.Point(12, 9);
            this.LB_TOP.Name = "LB_TOP";
            this.LB_TOP.Size = new System.Drawing.Size(193, 25);
            this.LB_TOP.TabIndex = 0;
            this.LB_TOP.Text = "Danh sách hàng hóa";
            this.LB_TOP.Click += new System.EventHandler(this.LB_TOP_Click);
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(88, 69);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(160, 27);
            this.TB_Search.TabIndex = 2;
            // 
            // BT_Refresh
            // 
            this.BT_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Refresh.Location = new System.Drawing.Point(279, 67);
            this.BT_Refresh.Name = "BT_Refresh";
            this.BT_Refresh.Size = new System.Drawing.Size(176, 33);
            this.BT_Refresh.TabIndex = 3;
            this.BT_Refresh.Text = "Làm mới danh sách";
            this.BT_Refresh.UseVisualStyleBackColor = true;
            this.BT_Refresh.Click += new System.EventHandler(this.BT_Refresh_Click);
            // 
            // RB_Boloc
            // 
            this.RB_Boloc.AutoSize = true;
            this.RB_Boloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Boloc.Location = new System.Drawing.Point(464, 69);
            this.RB_Boloc.Name = "RB_Boloc";
            this.RB_Boloc.Size = new System.Drawing.Size(279, 28);
            this.RB_Boloc.TabIndex = 4;
            this.RB_Boloc.TabStop = true;
            this.RB_Boloc.Text = "Lọc danh sách theo loại hàng";
            this.RB_Boloc.UseVisualStyleBackColor = true;
            // 
            // DTG_DSHH
            // 
            this.DTG_DSHH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTG_DSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_DSHH.Location = new System.Drawing.Point(52, 133);
            this.DTG_DSHH.Name = "DTG_DSHH";
            this.DTG_DSHH.RowHeadersWidth = 51;
            this.DTG_DSHH.RowTemplate.Height = 24;
            this.DTG_DSHH.Size = new System.Drawing.Size(691, 326);
            this.DTG_DSHH.TabIndex = 5;
            // 
            // BT_Them
            // 
            this.BT_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Them.Location = new System.Drawing.Point(32, 484);
            this.BT_Them.Name = "BT_Them";
            this.BT_Them.Size = new System.Drawing.Size(165, 48);
            this.BT_Them.TabIndex = 6;
            this.BT_Them.Text = "Thêm mặt hàng";
            this.BT_Them.UseVisualStyleBackColor = true;
            this.BT_Them.Click += new System.EventHandler(this.BT_Them_Click);
            // 
            // BT_Sua
            // 
            this.BT_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Sua.Location = new System.Drawing.Point(231, 484);
            this.BT_Sua.Name = "BT_Sua";
            this.BT_Sua.Size = new System.Drawing.Size(140, 48);
            this.BT_Sua.TabIndex = 7;
            this.BT_Sua.Text = "Sửa thông tin";
            this.BT_Sua.UseVisualStyleBackColor = true;
            this.BT_Sua.Click += new System.EventHandler(this.BT_Sua_Click);
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Xoa.Location = new System.Drawing.Point(413, 484);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(152, 48);
            this.BT_Xoa.TabIndex = 8;
            this.BT_Xoa.Text = "Xóa mặt hàng";
            this.BT_Xoa.UseVisualStyleBackColor = true;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // BT_Baocao
            // 
            this.BT_Baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Baocao.Location = new System.Drawing.Point(603, 484);
            this.BT_Baocao.Name = "BT_Baocao";
            this.BT_Baocao.Size = new System.Drawing.Size(140, 48);
            this.BT_Baocao.TabIndex = 9;
            this.BT_Baocao.Text = "Xuất báo cáo";
            this.BT_Baocao.UseVisualStyleBackColor = true;
            this.BT_Baocao.Click += new System.EventHandler(this.BT_Baocao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_WINFORM_2024.Properties.Resources.magnifier;
            this.pictureBox1.Location = new System.Drawing.Point(47, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 552);
            this.Controls.Add(this.BT_Baocao);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.BT_Sua);
            this.Controls.Add(this.BT_Them);
            this.Controls.Add(this.DTG_DSHH);
            this.Controls.Add(this.RB_Boloc);
            this.Controls.Add(this.BT_Refresh);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_TOP);
            this.MaximumSize = new System.Drawing.Size(800, 599);
            this.Name = "QuanLyHangHoa";
            this.Text = "Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_DSHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TOP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_Refresh;
        private System.Windows.Forms.RadioButton RB_Boloc;
        private System.Windows.Forms.DataGridView DTG_DSHH;
        private System.Windows.Forms.Button BT_Them;
        private System.Windows.Forms.Button BT_Sua;
        private System.Windows.Forms.Button BT_Xoa;
        private System.Windows.Forms.Button BT_Baocao;
    }
}