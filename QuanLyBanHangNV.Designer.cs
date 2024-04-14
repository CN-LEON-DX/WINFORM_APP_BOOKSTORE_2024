
namespace BTL_WINFORM_2024
{
    partial class QuanLyBanHangNV
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
            this.label_current_time = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_manage_bill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_manage_customer = new System.Windows.Forms.Button();
            this.bt_warehouse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_group = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trí tuệ";
            // 
            // label_current_time
            // 
            this.label_current_time.AutoSize = true;
            this.label_current_time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_time.ForeColor = System.Drawing.Color.White;
            this.label_current_time.Location = new System.Drawing.Point(618, 33);
            this.label_current_time.Name = "label_current_time";
            this.label_current_time.Size = new System.Drawing.Size(152, 28);
            this.label_current_time.TabIndex = 2;
            this.label_current_time.Text = "3: 47 3/20/2024";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(812, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 28);
            this.label12.TabIndex = 3;
            this.label12.Text = "Chào mừng !";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(51, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 4;
            // 
            // bt_manage_bill
            // 
            this.bt_manage_bill.FlatAppearance.BorderSize = 0;
            this.bt_manage_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_manage_bill.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_manage_bill.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_manage_bill.Location = new System.Drawing.Point(21, 26);
            this.bt_manage_bill.Name = "bt_manage_bill";
            this.bt_manage_bill.Size = new System.Drawing.Size(179, 48);
            this.bt_manage_bill.TabIndex = 5;
            this.bt_manage_bill.Text = "Quản lý đơn hàng";
            this.bt_manage_bill.UseVisualStyleBackColor = true;
            this.bt_manage_bill.Click += new System.EventHandler(this.bt_manage_bill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_current_time);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 100);
            this.panel1.TabIndex = 6;
            // 
            // bt_manage_customer
            // 
            this.bt_manage_customer.FlatAppearance.BorderSize = 0;
            this.bt_manage_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_manage_customer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_manage_customer.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_manage_customer.Location = new System.Drawing.Point(21, 119);
            this.bt_manage_customer.Name = "bt_manage_customer";
            this.bt_manage_customer.Size = new System.Drawing.Size(198, 49);
            this.bt_manage_customer.TabIndex = 5;
            this.bt_manage_customer.Text = "Quản lý khách hàng";
            this.bt_manage_customer.UseVisualStyleBackColor = true;
            this.bt_manage_customer.Click += new System.EventHandler(this.bt_manage_customer_Click);
            // 
            // bt_warehouse
            // 
            this.bt_warehouse.FlatAppearance.BorderSize = 0;
            this.bt_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_warehouse.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_warehouse.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_warehouse.Location = new System.Drawing.Point(21, 212);
            this.bt_warehouse.Name = "bt_warehouse";
            this.bt_warehouse.Size = new System.Drawing.Size(179, 47);
            this.bt_warehouse.TabIndex = 5;
            this.bt_warehouse.Text = "Quản lý kho hàng";
            this.bt_warehouse.UseVisualStyleBackColor = true;
            this.bt_warehouse.Click += new System.EventHandler(this.bt_warehouse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_manage_bill);
            this.panel2.Controls.Add(this.bt_manage_customer);
            this.panel2.Controls.Add(this.bt_warehouse);
            this.panel2.Location = new System.Drawing.Point(17, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 415);
            this.panel2.TabIndex = 7;
            // 
            // panel_group
            // 
            this.panel_group.Location = new System.Drawing.Point(255, 118);
            this.panel_group.Name = "panel_group";
            this.panel_group.Size = new System.Drawing.Size(828, 614);
            this.panel_group.TabIndex = 8;
            // 
            // QuanLyBanHangNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1095, 744);
            this.Controls.Add(this.panel_group);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(1113, 791);
            this.Name = "QuanLyBanHangNV";
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.QuanLyBanHangNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_current_time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_manage_bill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_manage_customer;
        private System.Windows.Forms.Button bt_warehouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_group;
    }
}