namespace prj_ti15e
{
    partial class frm_report_pelanggan
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rv_pelanggan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_ti15eDataSet = new prj_ti15e.db_ti15eDataSet();
            this.tbl_pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pelangganTableAdapter = new prj_ti15e.db_ti15eDataSetTableAdapters.tbl_pelangganTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_ti15eDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pelangganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_pelanggan
            // 
            this.rv_pelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ds_pelanggan";
            reportDataSource1.Value = this.tbl_pelangganBindingSource;
            this.rv_pelanggan.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_pelanggan.LocalReport.ReportEmbeddedResource = "prj_ti15e.Report2.rdlc";
            this.rv_pelanggan.Location = new System.Drawing.Point(0, 0);
            this.rv_pelanggan.Name = "rv_pelanggan";
            this.rv_pelanggan.Size = new System.Drawing.Size(445, 401);
            this.rv_pelanggan.TabIndex = 0;
            // 
            // db_ti15eDataSet
            // 
            this.db_ti15eDataSet.DataSetName = "db_ti15eDataSet";
            this.db_ti15eDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pelangganBindingSource
            // 
            this.tbl_pelangganBindingSource.DataMember = "tbl_pelanggan";
            this.tbl_pelangganBindingSource.DataSource = this.db_ti15eDataSet;
            // 
            // tbl_pelangganTableAdapter
            // 
            this.tbl_pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // frm_report_pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 401);
            this.Controls.Add(this.rv_pelanggan);
            this.Name = "frm_report_pelanggan";
            this.Text = "frm_report_pelanggan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_report_pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_ti15eDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pelangganBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_pelanggan;
        private System.Windows.Forms.BindingSource tbl_pelangganBindingSource;
        private db_ti15eDataSet db_ti15eDataSet;
        private db_ti15eDataSetTableAdapters.tbl_pelangganTableAdapter tbl_pelangganTableAdapter;
    }
}