namespace prj_ti15e
{
    partial class frm_cariBarang
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.txt_pencariandata = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_barang = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_batal);
            this.groupBox2.Controls.Add(this.txt_pencariandata);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Data (Kode / Nama Barang)";
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(426, 17);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(69, 23);
            this.btn_batal.TabIndex = 11;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // txt_pencariandata
            // 
            this.txt_pencariandata.Location = new System.Drawing.Point(11, 19);
            this.txt_pencariandata.Name = "txt_pencariandata";
            this.txt_pencariandata.Size = new System.Drawing.Size(409, 20);
            this.txt_pencariandata.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_barang);
            this.groupBox4.Location = new System.Drawing.Point(5, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 137);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Daftar Barang";
            // 
            // lst_barang
            // 
            this.lst_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_barang.Location = new System.Drawing.Point(9, 19);
            this.lst_barang.Name = "lst_barang";
            this.lst_barang.Size = new System.Drawing.Size(484, 112);
            this.lst_barang.TabIndex = 0;
            this.lst_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_barang_CellClick);
            this.lst_barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_barang_CellContentClick);
            // 
            // frm_cariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 213);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_cariBarang";
            this.Text = "Form Cari Barang";
            this.Load += new System.EventHandler(this.frm_cariBarang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_pencariandata;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView lst_barang;

    }
}