﻿namespace BTL_WINFORM_2024
{
    partial class ChinhSuaThongTinKH
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_TenKh = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_Sdt = new System.Windows.Forms.TextBox();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh sửa thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // tb_TenKh
            // 
            this.tb_TenKh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.tb_TenKh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_TenKh.Location = new System.Drawing.Point(236, 141);
            this.tb_TenKh.Name = "tb_TenKh";
            this.tb_TenKh.Size = new System.Drawing.Size(254, 31);
            this.tb_TenKh.TabIndex = 6;
            this.tb_TenKh.TextChanged += new System.EventHandler(this.tb_TenKh_TextChanged);
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.tb_DiaChi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_DiaChi.Location = new System.Drawing.Point(236, 250);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(254, 31);
            this.tb_DiaChi.TabIndex = 7;
            this.tb_DiaChi.TextChanged += new System.EventHandler(this.tb_DiaChi_TextChanged);
            // 
            // tb_Sdt
            // 
            this.tb_Sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.tb_Sdt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Sdt.Location = new System.Drawing.Point(236, 359);
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Size = new System.Drawing.Size(254, 31);
            this.tb_Sdt.TabIndex = 8;
            this.tb_Sdt.TextChanged += new System.EventHandler(this.tb_Sdt_TextChanged);
            this.tb_Sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sdt_KeyPress);
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Location = new System.Drawing.Point(236, 469);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(74, 30);
            this.rb_Nam.TabIndex = 9;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Location = new System.Drawing.Point(383, 469);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(57, 30);
            this.rb_Nu.TabIndex = 10;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CapNhat.Location = new System.Drawing.Point(65, 547);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(200, 52);
            this.btn_CapNhat.TabIndex = 11;
            this.btn_CapNhat.Text = "Cập nhật thông tin";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Huy.Location = new System.Drawing.Point(373, 547);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(85, 52);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // ChinhSuaThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(565, 619);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.rb_Nu);
            this.Controls.Add(this.rb_Nam);
            this.Controls.Add(this.tb_Sdt);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_TenKh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChinhSuaThongTinKH";
            this.Text = "ChinhSuaThongTinKH";
            this.Load += new System.EventHandler(this.ChinhSuaThongTinKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_TenKh;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_Sdt;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Huy;
    }
}