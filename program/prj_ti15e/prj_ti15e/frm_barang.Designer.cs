namespace prj_ti15e
{
    partial class frm_barang
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
            this.btn_cetak = new System.Windows.Forms.Button();
            this.cbo_satuan = new System.Windows.Forms.ComboBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_namabarang = new System.Windows.Forms.TextBox();
            this.txt_kodebarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_pencariandata = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_baru = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_barang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cetak);
            this.groupBox1.Controls.Add(this.cbo_satuan);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.txt_harga);
            this.groupBox1.Controls.Add(this.txt_namabarang);
            this.groupBox1.Controls.Add(this.txt_kodebarang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Barang";
            // 
            // btn_cetak
            // 
            this.btn_cetak.Location = new System.Drawing.Point(403, 138);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(77, 23);
            this.btn_cetak.TabIndex = 5;
            this.btn_cetak.Text = "Cetak";
            this.btn_cetak.UseVisualStyleBackColor = true;
            this.btn_cetak.Click += new System.EventHandler(this.btn_cetak_Click);
            // 
            // cbo_satuan
            // 
            this.cbo_satuan.FormattingEnabled = true;
            this.cbo_satuan.Items.AddRange(new object[] {
            "Unit",
            "Lusin",
            "Kotak"});
            this.cbo_satuan.Location = new System.Drawing.Point(111, 85);
            this.cbo_satuan.MaxLength = 15;
            this.cbo_satuan.Name = "cbo_satuan";
            this.cbo_satuan.Size = new System.Drawing.Size(250, 21);
            this.cbo_satuan.TabIndex = 9;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(111, 141);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(250, 20);
            this.txt_stock.TabIndex = 8;
            this.txt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress);
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(111, 113);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(250, 20);
            this.txt_harga.TabIndex = 7;
            this.txt_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_harga_KeyPress);
            // 
            // txt_namabarang
            // 
            this.txt_namabarang.Location = new System.Drawing.Point(111, 58);
            this.txt_namabarang.MaxLength = 40;
            this.txt_namabarang.Name = "txt_namabarang";
            this.txt_namabarang.Size = new System.Drawing.Size(369, 20);
            this.txt_namabarang.TabIndex = 6;
            this.txt_namabarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_namabarang_KeyPress);
            // 
            // txt_kodebarang
            // 
            this.txt_kodebarang.Location = new System.Drawing.Point(111, 28);
            this.txt_kodebarang.MaxLength = 10;
            this.txt_kodebarang.Name = "txt_kodebarang";
            this.txt_kodebarang.Size = new System.Drawing.Size(250, 20);
            this.txt_kodebarang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_pencariandata);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Data (Kode / Nama Barang)";
            // 
            // txt_pencariandata
            // 
            this.txt_pencariandata.Location = new System.Drawing.Point(9, 19);
            this.txt_pencariandata.Name = "txt_pencariandata";
            this.txt_pencariandata.Size = new System.Drawing.Size(471, 20);
            this.txt_pencariandata.TabIndex = 10;
            this.txt_pencariandata.TextChanged += new System.EventHandler(this.txt_pencariandata_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_keluar);
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.btn_simpan);
            this.groupBox3.Controls.Add(this.btn_baru);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proses";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(403, 19);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(84, 23);
            this.btn_keluar.TabIndex = 4;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(298, 19);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(84, 23);
            this.btn_hapus.TabIndex = 3;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(201, 19);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(84, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(111, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(84, 23);
            this.btn_simpan.TabIndex = 1;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_baru
            // 
            this.btn_baru.Location = new System.Drawing.Point(9, 19);
            this.btn_baru.Name = "btn_baru";
            this.btn_baru.Size = new System.Drawing.Size(84, 23);
            this.btn_baru.TabIndex = 0;
            this.btn_baru.Text = "Baru";
            this.btn_baru.UseVisualStyleBackColor = true;
            this.btn_baru.Click += new System.EventHandler(this.btn_baru_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_barang);
            this.groupBox4.Location = new System.Drawing.Point(12, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 137);
            this.groupBox4.TabIndex = 3;
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
            // frm_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 448);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_barang";
            this.Text = "Form Barang";
            this.Load += new System.EventHandler(this.frm_barang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_satuan;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_namabarang;
        private System.Windows.Forms.TextBox txt_kodebarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_pencariandata;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_baru;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView lst_barang;
        private System.Windows.Forms.Button btn_cetak;
    }
}