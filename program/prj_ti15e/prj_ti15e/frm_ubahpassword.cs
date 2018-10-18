using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace prj_ti15e
{
    public partial class frm_ubahpassword : Form
    {

        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;
        private SqlCommand cmd2;
       

        public frm_ubahpassword()
        {
            InitializeComponent();
        }

        private void frm_ubahpassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kondisi jika data belum lengkap
            if (txt_user.Text.Trim() == "" ||
                txt_passwordlama.Text.Trim() == "" ||
                txt_passwordbaru.Text.Trim() == "" ||
                txt_konfirmasipassword.Text.Trim() == "")
            {
                //pesan data belum lengkap
                MessageBox.Show("Lengkapi Data yang akan di ubah", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              SqlDataReader rd = null;
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        //proses ubah data
                        conn.Open();
                        cmd = new SqlCommand("SELECT * FROM tbl_login WHERE pengguna='" +
                            txt_user.Text + "' AND password='" +
                            txt_passwordlama.Text + "'", conn);
                      
                        cmd.ExecuteNonQuery();
                        rd = cmd.ExecuteReader();
                     
                       // jika user dan password benar
                        if (rd.Read())
                        {
                            using (SqlConnection conn2 = new SqlConnection(strconn))
                            {
                                // ubah password lama menjadi password baru
                                conn2.Open();
                                cmd2 = new SqlCommand("UPDATE tbl_login SET password='" +
                                    txt_passwordbaru.Text + "' WHERE pengguna='" +
                                    txt_user.Text + "'", conn2);
                                cmd2.ExecuteNonQuery();
                                conn2.Close();
                                MessageBox.Show("Password berhasil di ubah");
                                txt_user.Text = "";
                                txt_passwordlama.Text = "";
                                txt_passwordbaru.Text = "";
                                txt_konfirmasipassword.Text = "";
                                txt_user.Focus();
                               
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // jika Password gagal di ubah
                        MessageBox.Show("Password Gagal di ubah", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                       
                    }
                }
            }
        }

        private void txt_konfirmasipassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_konfirmasipassword_Leave(object sender, EventArgs e)
        {
            if (txt_konfirmasipassword.Text != txt_passwordbaru.Text)
            {
                MessageBox.Show("konfirmasi password harus sama dengan password baru");
                txt_konfirmasipassword.Text = "";
            }
        }
    }
}
