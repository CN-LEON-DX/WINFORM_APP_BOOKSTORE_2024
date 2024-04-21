namespace BTL_WINFORM_2024
{
    partial class XuatHoaDon
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
            this.HoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // HoaDon
            // 
            this.HoaDon.ActiveViewIndex = -1;
            this.HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoaDon.Location = new System.Drawing.Point(0, 0);
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(800, 450);
            this.HoaDon.TabIndex = 0;
            this.HoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HoaDon);
            this.Name = "XuatHoaDon";
            this.Text = "Hóa Đơn";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer HoaDon;
    }
}