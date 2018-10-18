namespace prj_ti15e
{
    partial class frm_ubahpassword
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_konfirmasipassword = new System.Windows.Forms.TextBox();
            this.txt_passwordbaru = new System.Windows.Forms.TextBox();
            this.txt_passwordlama = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_konfirmasipassword);
            this.groupBox1.Controls.Add(this.txt_passwordbaru);
            this.groupBox1.Controls.Add(this.txt_passwordlama);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubah Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ubah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_konfirmasipassword
            // 
            this.txt_konfirmasipassword.Location = new System.Drawing.Point(137, 124);
            this.txt_konfirmasipassword.Name = "txt_konfirmasipassword";
            this.txt_konfirmasipassword.Size = new System.Drawing.Size(196, 20);
            this.txt_konfirmasipassword.TabIndex = 7;
            this.txt_konfirmasipassword.TextChanged += new System.EventHandler(this.txt_konfirmasipassword_TextChanged);
            this.txt_konfirmasipassword.Leave += new System.EventHandler(this.txt_konfirmasipassword_Leave);
            // 
            // txt_passwordbaru
            // 
            this.txt_passwordbaru.Location = new System.Drawing.Point(137, 96);
            this.txt_passwordbaru.Name = "txt_passwordbaru";
            this.txt_passwordbaru.Size = new System.Drawing.Size(196, 20);
            this.txt_passwordbaru.TabIndex = 6;
            // 
            // txt_passwordlama
            // 
            this.txt_passwordlama.Location = new System.Drawing.Point(137, 64);
            this.txt_passwordlama.Name = "txt_passwordlama";
            this.txt_passwordlama.Size = new System.Drawing.Size(196, 20);
            this.txt_passwordlama.TabIndex = 5;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(137, 30);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(196, 20);
            this.txt_user.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konfirmasi Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Baru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password Lama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // frm_ubahpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 238);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ubahpassword";
            this.Text = "frm_ubahpassword";
            this.Load += new System.EventHandler(this.frm_ubahpassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_konfirmasipassword;
        private System.Windows.Forms.TextBox txt_passwordbaru;
        private System.Windows.Forms.TextBox txt_passwordlama;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}