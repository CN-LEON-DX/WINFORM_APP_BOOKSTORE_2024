
namespace BTL_WINFORM_2024
{
    partial class QuanLyHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgv_DSHD = new System.Windows.Forms.DataGridView();
            this.button_create_bill = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_name_employee = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.BT_XemCTHD = new System.Windows.Forms.Button();
            this.BT_XoaHD = new System.Windows.Forms.Button();
            this.BT_Timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TOP
            // 
            this.LB_TOP.AutoSize = true;
            this.LB_TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LB_TOP.Location = new System.Drawing.Point(29, 294);
            this.LB_TOP.Name = "LB_TOP";
            this.LB_TOP.Size = new System.Drawing.Size(188, 25);
            this.LB_TOP.TabIndex = 1;
            this.LB_TOP.Text = "Danh sách hóa đơn:";
            this.LB_TOP.Click += new System.EventHandler(this.LB_TOP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(47, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(520, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(520, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày lập:";
            // 
            // dtgv_DSHD
            // 
            this.dtgv_DSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DSHD.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgv_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSHD.Location = new System.Drawing.Point(33, 334);
            this.dtgv_DSHD.Name = "dtgv_DSHD";
            this.dtgv_DSHD.RowHeadersWidth = 51;
            this.dtgv_DSHD.RowTemplate.Height = 27;
            this.dtgv_DSHD.Size = new System.Drawing.Size(829, 163);
            this.dtgv_DSHD.TabIndex = 2;
            this.dtgv_DSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DSHD_CellClick);
            // 
            // button_create_bill
            // 
            this.button_create_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_bill.Location = new System.Drawing.Point(30, 226);
            this.button_create_bill.Name = "button_create_bill";
            this.button_create_bill.Size = new System.Drawing.Size(142, 41);
            this.button_create_bill.TabIndex = 3;
            this.button_create_bill.Text = "Tạo hóa đơn";
            this.button_create_bill.UseVisualStyleBackColor = true;
            this.button_create_bill.Click += new System.EventHandler(this.button_create_bill_Click);
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(198, 70);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(305, 30);
            this.tb_id.TabIndex = 4;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(646, 70);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(227, 30);
            this.tb_date.TabIndex = 4;
            // 
            // tb_name_employee
            // 
            this.tb_name_employee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_name_employee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name_employee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_name_employee.Location = new System.Drawing.Point(198, 170);
            this.tb_name_employee.Name = "tb_name_employee";
            this.tb_name_employee.Size = new System.Drawing.Size(305, 30);
            this.tb_name_employee.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(198, 120);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(305, 30);
            this.tb_name.TabIndex = 4;
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(646, 120);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(227, 30);
            this.tb_Phone.TabIndex = 4;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            // 
            // BT_XemCTHD
            // 
            this.BT_XemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_XemCTHD.Location = new System.Drawing.Point(198, 226);
            this.BT_XemCTHD.Name = "BT_XemCTHD";
            this.BT_XemCTHD.Size = new System.Drawing.Size(142, 41);
            this.BT_XemCTHD.TabIndex = 5;
            this.BT_XemCTHD.Text = "Xem chi tiết đơn";
            this.BT_XemCTHD.UseVisualStyleBackColor = true;
            this.BT_XemCTHD.Click += new System.EventHandler(this.BT_XemCTHD_Click);
            // 
            // BT_XoaHD
            // 
            this.BT_XoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_XoaHD.Location = new System.Drawing.Point(361, 226);
            this.BT_XoaHD.Name = "BT_XoaHD";
            this.BT_XoaHD.Size = new System.Drawing.Size(142, 41);
            this.BT_XoaHD.TabIndex = 7;
            this.BT_XoaHD.Text = "Xóa hóa đơn";
            this.BT_XoaHD.UseVisualStyleBackColor = true;
            this.BT_XoaHD.Click += new System.EventHandler(this.BT_XoaHD_Click);
            // 
            // BT_Timkiem
            // 
            this.BT_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Timkiem.Location = new System.Drawing.Point(524, 226);
            this.BT_Timkiem.Name = "BT_Timkiem";
            this.BT_Timkiem.Size = new System.Drawing.Size(142, 41);
            this.BT_Timkiem.TabIndex = 8;
            this.BT_Timkiem.Text = "Tìm kiếm";
            this.BT_Timkiem.UseVisualStyleBackColor = true;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(894, 520);
            this.Controls.Add(this.BT_Timkiem);
            this.Controls.Add(this.BT_XoaHD);
            this.Controls.Add(this.BT_XemCTHD);
            this.Controls.Add(this.tb_name_employee);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button_create_bill);
            this.Controls.Add(this.dtgv_DSHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_TOP);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(912, 567);
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgv_DSHD;
        private System.Windows.Forms.Button button_create_bill;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_name_employee;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Button BT_XemCTHD;
        private System.Windows.Forms.Button BT_XoaHD;
        private System.Windows.Forms.Button BT_Timkiem;
    }
}