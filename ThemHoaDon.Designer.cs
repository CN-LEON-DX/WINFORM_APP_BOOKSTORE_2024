
namespace BTL_WINFORM_2024
{
    partial class ThemHoaDon
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.btn_ThemMH = new System.Windows.Forms.Button();
            this.cmb_LoaiHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_MatHang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.bt_create_now = new System.Windows.Forms.Button();
            this.bt_Cancel_Create = new System.Windows.Forms.Button();
            this.bt_Delete_infor = new System.Windows.Forms.Button();
            this.listView_MH = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.rtb_Bill = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập thông tin";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.Control;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(193, 84);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(238, 30);
            this.tb_name.TabIndex = 11;
            this.tb_name.Text = "...";
            this.tb_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_name_Validating);
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(594, 93);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(172, 30);
            this.tb_Phone.TabIndex = 12;
            this.tb_Phone.Text = "...";
            this.tb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Phone_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ:";
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.SystemColors.Control;
            this.tb_address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(122, 145);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(309, 30);
            this.tb_address.TabIndex = 11;
            this.tb_address.Text = "...";
            this.tb_address.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // btn_ThemMH
            // 
            this.btn_ThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_ThemMH.Location = new System.Drawing.Point(38, 425);
            this.btn_ThemMH.Name = "btn_ThemMH";
            this.btn_ThemMH.Size = new System.Drawing.Size(157, 37);
            this.btn_ThemMH.TabIndex = 13;
            this.btn_ThemMH.Text = "Thêm mặt hàng";
            this.btn_ThemMH.UseVisualStyleBackColor = true;
            this.btn_ThemMH.Click += new System.EventHandler(this.btn_ThemMH_Click);
            // 
            // cmb_LoaiHang
            // 
            this.cmb_LoaiHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LoaiHang.FormattingEnabled = true;
            this.cmb_LoaiHang.Items.AddRange(new object[] {
            "Sách",
            "Văn phòng phẩm",
            "Đồ lưu niệm"});
            this.cmb_LoaiHang.Location = new System.Drawing.Point(187, 221);
            this.cmb_LoaiHang.Name = "cmb_LoaiHang";
            this.cmb_LoaiHang.Size = new System.Drawing.Size(244, 28);
            this.cmb_LoaiHang.TabIndex = 14;
            this.cmb_LoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmb_LoaiHang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thêm loại hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thêm mặt hàng:";
            // 
            // cmb_MatHang
            // 
            this.cmb_MatHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MatHang.FormattingEnabled = true;
            this.cmb_MatHang.Location = new System.Drawing.Point(187, 277);
            this.cmb_MatHang.Name = "cmb_MatHang";
            this.cmb_MatHang.Size = new System.Drawing.Size(244, 28);
            this.cmb_MatHang.TabIndex = 15;
            this.cmb_MatHang.SelectedIndexChanged += new System.EventHandler(this.cmb_MatHang_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới tính:";
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.Location = new System.Drawing.Point(565, 155);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(61, 22);
            this.rdb_Nam.TabIndex = 16;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdb_Nu.Location = new System.Drawing.Point(654, 155);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(48, 22);
            this.rdb_Nu.TabIndex = 16;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // bt_create_now
            // 
            this.bt_create_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bt_create_now.Location = new System.Drawing.Point(227, 425);
            this.bt_create_now.Name = "bt_create_now";
            this.bt_create_now.Size = new System.Drawing.Size(161, 37);
            this.bt_create_now.TabIndex = 17;
            this.bt_create_now.Text = "Tạo đơn hàng";
            this.bt_create_now.UseVisualStyleBackColor = true;
            this.bt_create_now.Click += new System.EventHandler(this.bt_create_now_Click);
            // 
            // bt_Cancel_Create
            // 
            this.bt_Cancel_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bt_Cancel_Create.Location = new System.Drawing.Point(433, 425);
            this.bt_Cancel_Create.Name = "bt_Cancel_Create";
            this.bt_Cancel_Create.Size = new System.Drawing.Size(112, 37);
            this.bt_Cancel_Create.TabIndex = 17;
            this.bt_Cancel_Create.Text = "Hủy đơn";
            this.bt_Cancel_Create.UseVisualStyleBackColor = true;
            this.bt_Cancel_Create.Click += new System.EventHandler(this.bt_Cancel_Create_Click);
            // 
            // bt_Delete_infor
            // 
            this.bt_Delete_infor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bt_Delete_infor.Location = new System.Drawing.Point(594, 425);
            this.bt_Delete_infor.Name = "bt_Delete_infor";
            this.bt_Delete_infor.Size = new System.Drawing.Size(140, 37);
            this.bt_Delete_infor.TabIndex = 17;
            this.bt_Delete_infor.Text = "Xóa thông tin";
            this.bt_Delete_infor.UseVisualStyleBackColor = true;
            this.bt_Delete_infor.Click += new System.EventHandler(this.bt_Delete_infor_Click);
            // 
            // listView_MH
            // 
            this.listView_MH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_MH.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_MH.HideSelection = false;
            this.listView_MH.Location = new System.Drawing.Point(457, 249);
            this.listView_MH.Name = "listView_MH";
            this.listView_MH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_MH.Size = new System.Drawing.Size(309, 161);
            this.listView_MH.TabIndex = 18;
            this.listView_MH.UseCompatibleStateImageBehavior = false;
            this.listView_MH.View = System.Windows.Forms.View.List;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Danh sách thêm:";
            // 
            // rtb_Bill
            // 
            this.rtb_Bill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Bill.Location = new System.Drawing.Point(24, 526);
            this.rtb_Bill.Name = "rtb_Bill";
            this.rtb_Bill.Size = new System.Drawing.Size(751, 204);
            this.rtb_Bill.TabIndex = 19;
            this.rtb_Bill.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Đơn hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng:";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(131, 324);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(146, 30);
            this.tb_Quantity.TabIndex = 12;
            this.tb_Quantity.Text = "1";
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 754);
            this.Controls.Add(this.rtb_Bill);
            this.Controls.Add(this.listView_MH);
            this.Controls.Add(this.bt_Delete_infor);
            this.Controls.Add(this.bt_Cancel_Create);
            this.Controls.Add(this.bt_create_now);
            this.Controls.Add(this.rdb_Nu);
            this.Controls.Add(this.rdb_Nam);
            this.Controls.Add(this.cmb_MatHang);
            this.Controls.Add(this.cmb_LoaiHang);
            this.Controls.Add(this.btn_ThemMH);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(818, 801);
            this.Name = "ThemHoaDon";
            this.Text = "Tạo hóa đơn";
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Button btn_ThemMH;
        private System.Windows.Forms.ComboBox cmb_LoaiHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_MatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.Button bt_create_now;
        private System.Windows.Forms.Button bt_Cancel_Create;
        private System.Windows.Forms.Button bt_Delete_infor;
        private System.Windows.Forms.ListView listView_MH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtb_Bill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Quantity;
    }
}