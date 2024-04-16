
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_name_employee = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TOP
            // 
            this.LB_TOP.AutoSize = true;
            this.LB_TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOP.Location = new System.Drawing.Point(25, 312);
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
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày lập:";
            // 
            // dtgv_DSHD
            // 
            this.dtgv_DSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DSHD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSHD.Location = new System.Drawing.Point(29, 355);
            this.dtgv_DSHD.Name = "dtgv_DSHD";
            this.dtgv_DSHD.RowHeadersWidth = 51;
            this.dtgv_DSHD.RowTemplate.Height = 27;
            this.dtgv_DSHD.Size = new System.Drawing.Size(725, 173);
            this.dtgv_DSHD.TabIndex = 2;
            this.dtgv_DSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DSHD_CellClick);
            // 
            // button_create_bill
            // 
            this.button_create_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_bill.Location = new System.Drawing.Point(26, 240);
            this.button_create_bill.Name = "button_create_bill";
            this.button_create_bill.Size = new System.Drawing.Size(124, 44);
            this.button_create_bill.TabIndex = 3;
            this.button_create_bill.Text = "Tạo hóa đơn";
            this.button_create_bill.UseVisualStyleBackColor = true;
            this.button_create_bill.Click += new System.EventHandler(this.button_create_bill_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(172, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xem chi tiết";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(320, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(471, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(618, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "Xuất hóa đơn";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.Control;
            this.tb_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(173, 74);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(267, 30);
            this.tb_id.TabIndex = 4;
            this.tb_id.Text = "...";
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.SystemColors.Control;
            this.tb_date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(550, 74);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(199, 30);
            this.tb_date.TabIndex = 4;
            this.tb_date.Text = "...";
            // 
            // tb_name_employee
            // 
            this.tb_name_employee.BackColor = System.Drawing.SystemColors.Control;
            this.tb_name_employee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name_employee.Location = new System.Drawing.Point(190, 181);
            this.tb_name_employee.Name = "tb_name_employee";
            this.tb_name_employee.Size = new System.Drawing.Size(299, 30);
            this.tb_name_employee.TabIndex = 4;
            this.tb_name_employee.Text = "...";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.Control;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(202, 128);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(228, 30);
            this.tb_name.TabIndex = 4;
            this.tb_name.Text = "...";
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(580, 129);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(162, 30);
            this.tb_Phone.TabIndex = 4;
            this.tb_Phone.Text = "...";
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tb_name_employee);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.MaximumSize = new System.Drawing.Size(800, 600);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_name_employee;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_Phone;
    }
}