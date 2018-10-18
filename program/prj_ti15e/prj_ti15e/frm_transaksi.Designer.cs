namespace prj_ti15e
{
    partial class frm_transaksi
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_noFaktur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cariPelanggan = new System.Windows.Forms.Button();
            this.txt_namaPelanggan = new System.Windows.Forms.TextBox();
            this.txt_kodePelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_tglFaktur = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_cariBarang = new System.Windows.Forms.Button();
            this.txt_totalHarga = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_namaBarang = new System.Windows.Forms.TextBox();
            this.txt_kodeBarang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_detail = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_totalBayar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_pencarianData = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lst_transaksi = new System.Windows.Forms.DataGridView();
            this.btn_baru = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_detail)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Faktur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Faktur";
            // 
            // txt_noFaktur
            // 
            this.txt_noFaktur.Enabled = false;
            this.txt_noFaktur.Location = new System.Drawing.Point(435, 4);
            this.txt_noFaktur.Name = "txt_noFaktur";
            this.txt_noFaktur.Size = new System.Drawing.Size(210, 20);
            this.txt_noFaktur.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cariPelanggan);
            this.groupBox1.Controls.Add(this.txt_namaPelanggan);
            this.groupBox1.Controls.Add(this.txt_kodePelanggan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pelanggan";
            // 
            // btn_cariPelanggan
            // 
            this.btn_cariPelanggan.Location = new System.Drawing.Point(258, 15);
            this.btn_cariPelanggan.Name = "btn_cariPelanggan";
            this.btn_cariPelanggan.Size = new System.Drawing.Size(75, 23);
            this.btn_cariPelanggan.TabIndex = 7;
            this.btn_cariPelanggan.Text = "---";
            this.btn_cariPelanggan.UseVisualStyleBackColor = true;
            this.btn_cariPelanggan.Click += new System.EventHandler(this.btn_cariPelanggan_Click);
            // 
            // txt_namaPelanggan
            // 
            this.txt_namaPelanggan.Enabled = false;
            this.txt_namaPelanggan.Location = new System.Drawing.Point(132, 47);
            this.txt_namaPelanggan.Name = "txt_namaPelanggan";
            this.txt_namaPelanggan.Size = new System.Drawing.Size(237, 20);
            this.txt_namaPelanggan.TabIndex = 6;
            // 
            // txt_kodePelanggan
            // 
            this.txt_kodePelanggan.Enabled = false;
            this.txt_kodePelanggan.Location = new System.Drawing.Point(132, 15);
            this.txt_kodePelanggan.Name = "txt_kodePelanggan";
            this.txt_kodePelanggan.Size = new System.Drawing.Size(100, 20);
            this.txt_kodePelanggan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kode Pelanggan";
            // 
            // dtm_tglFaktur
            // 
            this.dtm_tglFaktur.Location = new System.Drawing.Point(435, 36);
            this.dtm_tglFaktur.Name = "dtm_tglFaktur";
            this.dtm_tglFaktur.Size = new System.Drawing.Size(269, 20);
            this.dtm_tglFaktur.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kurang);
            this.groupBox2.Controls.Add(this.btn_tambah);
            this.groupBox2.Controls.Add(this.btn_cariBarang);
            this.groupBox2.Controls.Add(this.txt_totalHarga);
            this.groupBox2.Controls.Add(this.txt_qty);
            this.groupBox2.Controls.Add(this.txt_harga);
            this.groupBox2.Controls.Add(this.txt_stock);
            this.groupBox2.Controls.Add(this.txt_namaBarang);
            this.groupBox2.Controls.Add(this.txt_kodeBarang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 183);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Barang";
            // 
            // btn_kurang
            // 
            this.btn_kurang.Location = new System.Drawing.Point(309, 154);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(44, 23);
            this.btn_kurang.TabIndex = 20;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(253, 154);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(44, 23);
            this.btn_tambah.TabIndex = 19;
            this.btn_tambah.Text = "+";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_cariBarang
            // 
            this.btn_cariBarang.Location = new System.Drawing.Point(257, 14);
            this.btn_cariBarang.Name = "btn_cariBarang";
            this.btn_cariBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_cariBarang.TabIndex = 8;
            this.btn_cariBarang.Text = "---";
            this.btn_cariBarang.UseVisualStyleBackColor = true;
            this.btn_cariBarang.Click += new System.EventHandler(this.btn_cariBarang_Click);
            // 
            // txt_totalHarga
            // 
            this.txt_totalHarga.Enabled = false;
            this.txt_totalHarga.Location = new System.Drawing.Point(132, 157);
            this.txt_totalHarga.Name = "txt_totalHarga";
            this.txt_totalHarga.Size = new System.Drawing.Size(100, 20);
            this.txt_totalHarga.TabIndex = 18;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(132, 129);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 17;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // txt_harga
            // 
            this.txt_harga.Enabled = false;
            this.txt_harga.Location = new System.Drawing.Point(132, 103);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(100, 20);
            this.txt_harga.TabIndex = 16;
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
            this.txt_stock.Location = new System.Drawing.Point(132, 75);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 15;
            // 
            // txt_namaBarang
            // 
            this.txt_namaBarang.Enabled = false;
            this.txt_namaBarang.Location = new System.Drawing.Point(132, 49);
            this.txt_namaBarang.Name = "txt_namaBarang";
            this.txt_namaBarang.Size = new System.Drawing.Size(237, 20);
            this.txt_namaBarang.TabIndex = 14;
            // 
            // txt_kodeBarang
            // 
            this.txt_kodeBarang.Enabled = false;
            this.txt_kodeBarang.Location = new System.Drawing.Point(132, 17);
            this.txt_kodeBarang.Name = "txt_kodeBarang";
            this.txt_kodeBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_kodeBarang.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Harga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_detail);
            this.groupBox3.Location = new System.Drawing.Point(12, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daftar Belanja";
            // 
            // lst_detail
            // 
            this.lst_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_detail.Location = new System.Drawing.Point(6, 13);
            this.lst_detail.Name = "lst_detail";
            this.lst_detail.Size = new System.Drawing.Size(363, 118);
            this.lst_detail.TabIndex = 0;
            this.lst_detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_detail_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total Bayar";
            // 
            // txt_totalBayar
            // 
            this.txt_totalBayar.Location = new System.Drawing.Point(270, 477);
            this.txt_totalBayar.Name = "txt_totalBayar";
            this.txt_totalBayar.Size = new System.Drawing.Size(100, 20);
            this.txt_totalBayar.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_pencarianData);
            this.groupBox4.Location = new System.Drawing.Point(396, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 60);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pencarian Data (No Faktur)";
            // 
            // txt_pencarianData
            // 
            this.txt_pencarianData.Location = new System.Drawing.Point(6, 25);
            this.txt_pencarianData.Name = "txt_pencarianData";
            this.txt_pencarianData.Size = new System.Drawing.Size(302, 20);
            this.txt_pencarianData.TabIndex = 21;
            this.txt_pencarianData.TextChanged += new System.EventHandler(this.txt_pencarianData_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(396, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 287);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Daftar Transaksi";
            // 
            // lst_transaksi
            // 
            this.lst_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_transaksi.Location = new System.Drawing.Point(407, 145);
            this.lst_transaksi.Name = "lst_transaksi";
            this.lst_transaksi.Size = new System.Drawing.Size(297, 256);
            this.lst_transaksi.TabIndex = 1;
            this.lst_transaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_transaksi_CellClick);
            // 
            // btn_baru
            // 
            this.btn_baru.Location = new System.Drawing.Point(396, 431);
            this.btn_baru.Name = "btn_baru";
            this.btn_baru.Size = new System.Drawing.Size(75, 23);
            this.btn_baru.TabIndex = 19;
            this.btn_baru.Text = "Baru";
            this.btn_baru.UseVisualStyleBackColor = true;
            this.btn_baru.Click += new System.EventHandler(this.btn_baru_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(477, 431);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 23;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(558, 431);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 24;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(639, 431);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 25;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // frm_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 509);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_baru);
            this.Controls.Add(this.lst_transaksi);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txt_totalBayar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtm_tglFaktur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_noFaktur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_transaksi";
            this.Text = "frm_transaksi";
            this.Load += new System.EventHandler(this.frm_transaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_detail)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_noFaktur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cariPelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_tglFaktur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cariBarang;
        private System.Windows.Forms.TextBox txt_totalHarga;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_namaBarang;
        private System.Windows.Forms.TextBox txt_kodeBarang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView lst_detail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_totalBayar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_pencarianData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView lst_transaksi;
        private System.Windows.Forms.Button btn_baru;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_tambah;
        public System.Windows.Forms.TextBox txt_namaPelanggan;
        public System.Windows.Forms.TextBox txt_kodePelanggan;
    }
}