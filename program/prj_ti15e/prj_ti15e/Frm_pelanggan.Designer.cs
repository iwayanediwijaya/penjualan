namespace prj_ti15e
{
    partial class Frm_pelanggan
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
            this.txt_noTelepon = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_namaPelanggan = new System.Windows.Forms.TextBox();
            this.txt_kodePelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cariPelanggan = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_pelanggan = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_baru = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_pelanggan)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_noTelepon);
            this.groupBox1.Controls.Add(this.txt_alamat);
            this.groupBox1.Controls.Add(this.txt_namaPelanggan);
            this.groupBox1.Controls.Add(this.txt_kodePelanggan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // txt_noTelepon
            // 
            this.txt_noTelepon.Location = new System.Drawing.Point(133, 120);
            this.txt_noTelepon.Name = "txt_noTelepon";
            this.txt_noTelepon.Size = new System.Drawing.Size(160, 20);
            this.txt_noTelepon.TabIndex = 7;
            this.txt_noTelepon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(133, 86);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(308, 20);
            this.txt_alamat.TabIndex = 6;
            // 
            // txt_namaPelanggan
            // 
            this.txt_namaPelanggan.Location = new System.Drawing.Point(133, 53);
            this.txt_namaPelanggan.Name = "txt_namaPelanggan";
            this.txt_namaPelanggan.Size = new System.Drawing.Size(308, 20);
            this.txt_namaPelanggan.TabIndex = 5;
            // 
            // txt_kodePelanggan
            // 
            this.txt_kodePelanggan.Location = new System.Drawing.Point(133, 21);
            this.txt_kodePelanggan.Name = "txt_kodePelanggan";
            this.txt_kodePelanggan.Size = new System.Drawing.Size(160, 20);
            this.txt_kodePelanggan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No.Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pelanggan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cariPelanggan);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Data (Kode/Nama Pelanggan)";
            // 
            // txt_cariPelanggan
            // 
            this.txt_cariPelanggan.Location = new System.Drawing.Point(9, 28);
            this.txt_cariPelanggan.Name = "txt_cariPelanggan";
            this.txt_cariPelanggan.Size = new System.Drawing.Size(432, 20);
            this.txt_cariPelanggan.TabIndex = 0;
            this.txt_cariPelanggan.TextChanged += new System.EventHandler(this.txt_cariPelanggan_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_pelanggan);
            this.groupBox4.Location = new System.Drawing.Point(12, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 114);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Daftar Barang";
            // 
            // lst_pelanggan
            // 
            this.lst_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_pelanggan.Location = new System.Drawing.Point(9, 21);
            this.lst_pelanggan.Name = "lst_pelanggan";
            this.lst_pelanggan.Size = new System.Drawing.Size(432, 87);
            this.lst_pelanggan.TabIndex = 0;
            this.lst_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_pelanggan_CellClick);
            this.lst_pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_pelanggan_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_keluar);
            this.groupBox5.Controls.Add(this.btn_hapus);
            this.groupBox5.Controls.Add(this.btn_edit);
            this.groupBox5.Controls.Add(this.btn_simpan);
            this.groupBox5.Controls.Add(this.btn_baru);
            this.groupBox5.Location = new System.Drawing.Point(12, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Proses";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(373, 21);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(68, 23);
            this.btn_keluar.TabIndex = 4;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(274, 21);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(68, 23);
            this.btn_hapus.TabIndex = 3;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(178, 21);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(68, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(91, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(68, 23);
            this.btn_simpan.TabIndex = 1;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_baru
            // 
            this.btn_baru.Location = new System.Drawing.Point(7, 21);
            this.btn_baru.Name = "btn_baru";
            this.btn_baru.Size = new System.Drawing.Size(68, 23);
            this.btn_baru.TabIndex = 0;
            this.btn_baru.Text = "Baru";
            this.btn_baru.UseVisualStyleBackColor = true;
            this.btn_baru.Click += new System.EventHandler(this.btn_baru_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_pelanggan";
            this.Text = "Frm_pelanggan";
            this.Load += new System.EventHandler(this.Frm_pelanggan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_pelanggan)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_noTelepon;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_namaPelanggan;
        private System.Windows.Forms.TextBox txt_kodePelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cariPelanggan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_baru;
        private System.Windows.Forms.DataGridView lst_pelanggan;
        private System.Windows.Forms.Button button1;
    }
}