namespace BTL_WINFORM_2024
{
    partial class FormBCDSHH
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
            this.ReportDSHH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportDSHH
            // 
            this.ReportDSHH.ActiveViewIndex = -1;
            this.ReportDSHH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportDSHH.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportDSHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportDSHH.Location = new System.Drawing.Point(0, 0);
            this.ReportDSHH.Name = "ReportDSHH";
            this.ReportDSHH.Size = new System.Drawing.Size(800, 450);
            this.ReportDSHH.TabIndex = 0;
            this.ReportDSHH.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormBCDSHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportDSHH);
            this.Name = "FormBCDSHH";
            this.Text = "Danh Sách Hàng Hóa";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportDSHH;
    }
}