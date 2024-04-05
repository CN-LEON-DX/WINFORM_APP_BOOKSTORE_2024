namespace BTL_WINFORM_2024
{
    partial class ThemNhanVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNhanVienForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_cccd = new System.Windows.Forms.TextBox();
            this.button_add_new = new System.Windows.Forms.Button();
            this.button_exits = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.label_posittion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(95, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thêm mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(95, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(95, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton_male.Location = new System.Drawing.Point(235, 251);
            this.radioButton_male.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(74, 30);
            this.radioButton_male.TabIndex = 3;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Nam";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(95, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton_female.Location = new System.Drawing.Point(345, 251);
            this.radioButton_female.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(57, 30);
            this.radioButton_female.TabIndex = 4;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Nữ";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(95, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số CCCD";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(235, 151);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(248, 27);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.valid_name_add);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(95, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày sinh";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(235, 201);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(248, 27);
            this.textBox_address.TabIndex = 2;
            this.textBox_address.Validating += new System.ComponentModel.CancelEventHandler(this.valid_address_add);
            // 
            // textBox_cccd
            // 
            this.textBox_cccd.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cccd.Location = new System.Drawing.Point(235, 306);
            this.textBox_cccd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cccd.Name = "textBox_cccd";
            this.textBox_cccd.Size = new System.Drawing.Size(248, 27);
            this.textBox_cccd.TabIndex = 5;
            this.textBox_cccd.TextChanged += new System.EventHandler(this.textBox_cccd_TextChanged);
            this.textBox_cccd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cccd_KeyPress);
            this.textBox_cccd.Validating += new System.ComponentModel.CancelEventHandler(this.valid_cccd_add);
            // 
            // button_add_new
            // 
            this.button_add_new.BackColor = System.Drawing.Color.White;
            this.button_add_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_new.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_new.Location = new System.Drawing.Point(100, 541);
            this.button_add_new.Name = "button_add_new";
            this.button_add_new.Size = new System.Drawing.Size(101, 35);
            this.button_add_new.TabIndex = 7;
            this.button_add_new.Text = "Thêm mới";
            this.button_add_new.UseVisualStyleBackColor = false;
            this.button_add_new.Click += new System.EventHandler(this.click_add_new_emp);
            // 
            // button_exits
            // 
            this.button_exits.BackColor = System.Drawing.Color.White;
            this.button_exits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exits.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exits.Location = new System.Drawing.Point(387, 541);
            this.button_exits.Name = "button_exits";
            this.button_exits.Size = new System.Drawing.Size(96, 35);
            this.button_exits.TabIndex = 9;
            this.button_exits.Text = "Hủy bỏ";
            this.button_exits.UseVisualStyleBackColor = false;
            this.button_exits.Click += new System.EventHandler(this.button_exits_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(235, 541);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(108, 35);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Xóa thông tin";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_birthday.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(235, 355);
            this.dateTimePicker_birthday.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(248, 27);
            this.dateTimePicker_birthday.TabIndex = 13;
            this.dateTimePicker_birthday.Value = new System.DateTime(2024, 2, 26, 0, 0, 0, 0);
            // 
            // label_posittion
            // 
            this.label_posittion.AutoSize = true;
            this.label_posittion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_posittion.ForeColor = System.Drawing.SystemColors.Control;
            this.label_posittion.Location = new System.Drawing.Point(95, 412);
            this.label_posittion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_posittion.Name = "label_posittion";
            this.label_posittion.Size = new System.Drawing.Size(84, 26);
            this.label_posittion.TabIndex = 0;
            this.label_posittion.Text = "Chức vụ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quan lý",
            "Marketing",
            "IT"});
            this.comboBox1.Location = new System.Drawing.Point(235, 412);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 31);
            this.comboBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(95, 471);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số điện thoại";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(235, 471);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(248, 27);
            this.textBox_phone.TabIndex = 5;
            this.textBox_phone.TextChanged += new System.EventHandler(this.textBox_cccd_TextChanged);
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            this.textBox_phone.Validating += new System.ComponentModel.CancelEventHandler(this.valid_phone_number);
            // 
            // ThemNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(565, 619);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.button_exits);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_add_new);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_cccd);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_posittion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(583, 666);
            this.Name = "ThemNhanVienForm";
            this.Text = "Thêm mới nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.click_exit_confirm);
            this.Load += new System.EventHandler(this.ThemNhanVienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_cccd;
        private System.Windows.Forms.Button button_add_new;
        private System.Windows.Forms.Button button_exits;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.Label label_posittion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_phone;
    }
}