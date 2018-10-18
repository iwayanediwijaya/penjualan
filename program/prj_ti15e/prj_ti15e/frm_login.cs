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
    public partial class frm_login : Form
    {

        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;

        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "" || txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong");
            }
            else
            {
                SqlDataReader rd = null;
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    conn.Open();
                    cmd=new SqlCommand("SELECT * FROM tbl_login WHERE pengguna = '" +
                        txt_username.Text +"' and password = '" +
                        txt_password.Text +"'",conn);
                    cmd.ExecuteNonQuery();
                    rd = cmd.ExecuteReader();

                    // jika user dan password benar
                    if (rd.Read())
                    {
                        MessageBox.Show("Login Berhasil");
                        // aktifkan kembali menu
                        Form1.mdiobj.dataMasterToolStripMenuItem.Enabled = true;
                        Form1.mdiobj.transaksiToolStripMenuItem.Enabled = true;
                        Form1.mdiobj.cetakToolStripMenuItem.Enabled = true;
                        Form1.mdiobj.penggunaToolStripMenuItem.Enabled = true;
                        Form1.mdiobj.logoutToolStripMenuItem.Enabled = true;

                        this.Close();

                    }
                    else // jika user atau password salah
                    {
                        MessageBox.Show("Username atau Password salah !!!");
                        txt_username.Text = "";
                        txt_password.Text = "";
                        txt_username.Focus();
                    }
                }
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
