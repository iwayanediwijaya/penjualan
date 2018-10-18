namespace prj_ti15e
{
    partial class frm_cetakpenjualan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtm_akhir = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_awal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_seleksi = new System.Windows.Forms.RadioButton();
            this.rdb_seluruh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_cetak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtm_akhir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtm_awal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdb_seleksi);
            this.groupBox1.Controls.Add(this.rdb_seluruh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleksi Periode";
            // 
            // dtm_akhir
            // 
            this.dtm_akhir.Enabled = false;
            this.dtm_akhir.Location = new System.Drawing.Point(117, 107);
            this.dtm_akhir.Name = "dtm_akhir";
            this.dtm_akhir.Size = new System.Drawing.Size(152, 20);
            this.dtm_akhir.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sampai Tanggal";
            // 
            // dtm_awal
            // 
            this.dtm_awal.Enabled = false;
            this.dtm_awal.Location = new System.Drawing.Point(117, 76);
            this.dtm_awal.Name = "dtm_awal";
            this.dtm_awal.Size = new System.Drawing.Size(152, 20);
            this.dtm_awal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dari Tanggal";
            // 
            // rdb_seleksi
            // 
            this.rdb_seleksi.AutoSize = true;
            this.rdb_seleksi.Location = new System.Drawing.Point(6, 42);
            this.rdb_seleksi.Name = "rdb_seleksi";
            this.rdb_seleksi.Size = new System.Drawing.Size(59, 17);
            this.rdb_seleksi.TabIndex = 1;
            this.rdb_seleksi.TabStop = true;
            this.rdb_seleksi.Text = "Seleksi";
            this.rdb_seleksi.UseVisualStyleBackColor = true;
            this.rdb_seleksi.CheckedChanged += new System.EventHandler(this.rdb_seleksi_CheckedChanged);
            // 
            // rdb_seluruh
            // 
            this.rdb_seluruh.AutoSize = true;
            this.rdb_seluruh.Location = new System.Drawing.Point(6, 19);
            this.rdb_seluruh.Name = "rdb_seluruh";
            this.rdb_seluruh.Size = new System.Drawing.Size(61, 17);
            this.rdb_seluruh.TabIndex = 0;
            this.rdb_seluruh.TabStop = true;
            this.rdb_seluruh.Text = "Seluruh";
            this.rdb_seluruh.UseVisualStyleBackColor = true;
            this.rdb_seluruh.CheckedChanged += new System.EventHandler(this.rdb_seluruh_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_keluar);
            this.groupBox2.Controls.Add(this.btn_cetak);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 53);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proses";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(172, 19);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(90, 23);
            this.btn_keluar.TabIndex = 1;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_cetak
            // 
            this.btn_cetak.Location = new System.Drawing.Point(30, 19);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(91, 23);
            this.btn_cetak.TabIndex = 0;
            this.btn_cetak.Text = "Cetak";
            this.btn_cetak.UseVisualStyleBackColor = true;
            this.btn_cetak.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_cetakpenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 221);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_cetakpenjualan";
            this.Text = "Form Cetak Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cetakpenjualan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtm_akhir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_awal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_seleksi;
        private System.Windows.Forms.RadioButton rdb_seluruh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_cetak;

    }
}