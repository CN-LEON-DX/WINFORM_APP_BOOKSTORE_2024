﻿namespace BTL_WINFORM_2024
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(349, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hóa đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(87, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(87, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(435, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Người lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(440, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện thoại KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(440, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSach,
            this.sTenSach,
            this.fGia,
            this.fSoLuong,
            this.sTacGia,
            this.sNXB});
            this.dataGridView1.Location = new System.Drawing.Point(61, 462);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(699, 228);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sMaSach
            // 
            this.sMaSach.HeaderText = "sMaSach";
            this.sMaSach.MinimumWidth = 6;
            this.sMaSach.Name = "sMaSach";
            this.sMaSach.Width = 125;
            // 
            // sTenSach
            // 
            this.sTenSach.HeaderText = "sTenSach";
            this.sTenSach.MinimumWidth = 6;
            this.sTenSach.Name = "sTenSach";
            this.sTenSach.Width = 125;
            // 
            // fGia
            // 
            this.fGia.HeaderText = "fGia";
            this.fGia.MinimumWidth = 6;
            this.fGia.Name = "fGia";
            this.fGia.Width = 125;
            // 
            // fSoLuong
            // 
            this.fSoLuong.HeaderText = "fSoLuong";
            this.fSoLuong.MinimumWidth = 6;
            this.fSoLuong.Name = "fSoLuong";
            this.fSoLuong.Width = 125;
            // 
            // sTacGia
            // 
            this.sTacGia.HeaderText = "sTacGia";
            this.sTacGia.MinimumWidth = 6;
            this.sTacGia.Name = "sTacGia";
            this.sTacGia.Width = 125;
            // 
            // sNXB
            // 
            this.sNXB.HeaderText = "sNXB";
            this.sNXB.MinimumWidth = 6;
            this.sNXB.Name = "sNXB";
            this.sNXB.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(117, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(298, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm mặt hàng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(564, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xóa thông tin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(203, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "HD000001";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(254, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nguyễn Chính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(613, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "0932743534";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(538, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "23, Định Công, Hà Nội";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(203, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "20/03/2024";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(56, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Danh sách đơn hàng";
            this.label13.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label14.Location = new System.Drawing.Point(538, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "NVBH0001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(810, 728);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Lập hóa đơn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNXB;
    }
}