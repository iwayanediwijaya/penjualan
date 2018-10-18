namespace prj_ti15e
{
    partial class frm_report_barang
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
            this.rv_barang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_ti15eDataSet = new prj_ti15e.db_ti15eDataSet();
            this.tbl_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_barangTableAdapter = new prj_ti15e.db_ti15eDataSetTableAdapters.tbl_barangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_ti15eDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_barangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_barang
            // 
            this.rv_barang.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ds_barang";
            reportDataSource1.Value = this.tbl_barangBindingSource;
            this.rv_barang.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_barang.LocalReport.ReportEmbeddedResource = "prj_ti15e.Report1.rdlc";
            this.rv_barang.Location = new System.Drawing.Point(0, 0);
            this.rv_barang.Name = "rv_barang";
            this.rv_barang.Size = new System.Drawing.Size(678, 423);
            this.rv_barang.TabIndex = 0;
            // 
            // db_ti15eDataSet
            // 
            this.db_ti15eDataSet.DataSetName = "db_ti15eDataSet";
            this.db_ti15eDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_barangBindingSource
            // 
            this.tbl_barangBindingSource.DataMember = "tbl_barang";
            this.tbl_barangBindingSource.DataSource = this.db_ti15eDataSet;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // frm_report_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 423);
            this.Controls.Add(this.rv_barang);
            this.Name = "frm_report_barang";
            this.Text = "frm_report_barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_report_barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_ti15eDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_barangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_barang;
        private System.Windows.Forms.BindingSource tbl_barangBindingSource;
        private db_ti15eDataSet db_ti15eDataSet;
        private db_ti15eDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
    }
}