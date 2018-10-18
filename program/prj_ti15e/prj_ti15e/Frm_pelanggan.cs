using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//langkah 1. tambahkan library untuk koneksi database
using System.Data.SqlClient;

namespace prj_ti15e
{
    public partial class Frm_pelanggan : Form
    {
        //langkah 2. tambahkan fungsi String untuk koneksi database
        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //langkah 3. membuat prosedur bersih
        private void bersih()
        {
            txt_kodePelanggan.Text = "";
            txt_namaPelanggan.Text = "";
            txt_alamat.Text = "";
            txt_noTelepon.Text = "";
            txt_cariPelanggan.Text = "";

        }

        //langkah 4. membuat prosedur untuk koneksi ke tbl_barang
        private void koneksi_pelanggan()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_pelanggan ORDER BY kode_pelanggan", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_pelanggan");
                lst_pelanggan.DataSource = ds;
                lst_pelanggan.DataMember = "tbl_pelanggan";
                lst_pelanggan.Refresh();
                conn.Close();
            }
        }
        public Frm_pelanggan()
        {
            InitializeComponent();
            //langkah 5. memanggil koneksi dan bersih
            bersih();
            koneksi_pelanggan();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_pelanggan_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
             //langkah 7. membuat proses simpan

            //kondisi jika data belum lengkap
            if (txt_kodePelanggan.Text.Trim() == "" ||
                txt_namaPelanggan.Text.Trim() == "" ||
                txt_alamat.Text.Trim() == "" ||
                txt_noTelepon.Text.Trim() == "" )
                
            {
                //pesan data belum lengkap
                MessageBox.Show("Data Belum Lengkap", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //mempersiapkan sqlconnection
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO tbl_pelanggan VALUES('" +
                            txt_kodePelanggan.Text + "','" + 
                            txt_namaPelanggan.Text + "','" +
                            txt_alamat.Text + "','" +
                            txt_noTelepon.Text + "')", conn);
                        //buka koneksi
                        conn.Open();
                        //eksekusi perintah query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan", "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_pelanggan();

                    }
                    catch (Exception)
                    {
                        //jika data gagal disimpan
                        MessageBox.Show("Data Gagal Disimpan", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void lst_mahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lst_mahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void lst_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //langkah 8
            //menampilkan data dari list barang ke textbox, dll
            DataGridViewRow row = this.lst_pelanggan.Rows[e.RowIndex];
            txt_kodePelanggan.Text = row.Cells["kode_pelanggan"].Value.ToString();
            txt_namaPelanggan.Text = row.Cells["nama_pelanggan"].Value.ToString();
            txt_alamat.Text = row.Cells["alamat"].Value.ToString();
            txt_noTelepon.Text = row.Cells["no_telepon"].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //langkah 9. membuat proses edit

            //kondisi jika data belum lengkap
            if (txt_kodePelanggan.Text.Trim() == "" ||
                txt_namaPelanggan.Text.Trim() == "" ||
                txt_alamat.Text.Trim() == "" ||
                txt_noTelepon.Text.Trim() == "")
            {
                //pesan data belum lengkap
                MessageBox.Show("Pilih Data yang akan di edit", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        //proses ubah data
                        cmd = new SqlCommand("UPDATE tbl_pelanggan SET nama_pelanggan='" +
                            txt_namaPelanggan.Text + "', alamat='" +
                            txt_alamat.Text + "', no_telepon='" +
                            txt_noTelepon.Text + "' WHERE kode_Pelanggan='" +
                            txt_kodePelanggan.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diedit", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_pelanggan();
                    }
                    catch (Exception)
                    {
                        // jika Data gagal di edit
                        MessageBox.Show("Data Gagal di edit", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bersih();
                        koneksi_pelanggan();
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {

            // langkah 10 membuat proses hapus data
            if (txt_kodePelanggan.Text.Trim() == "" ||
                txt_namaPelanggan.Text.Trim() == "" ||
                txt_alamat.Text.Trim() == "" ||
                txt_noTelepon.Text.Trim() == "")
            {
                //pesan data belum lengkap
                MessageBox.Show("Pilih Data yang akan di Hapus", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Hapus Data " +
                txt_namaPelanggan.Text + "?", "Info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        // proses hapus
                        cmd = new SqlCommand("DELETE FROM tbl_pelanggan WHERE kode_pelanggan='" +
                            txt_kodePelanggan.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Di Hapus", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_pelanggan();
                    }
                    catch (Exception)
                    {
                        // jika Data gagal di Hapus
                        MessageBox.Show("Data Gagal di Hapus", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bersih();
                        koneksi_pelanggan();
                    }
                }
            }
        }

        private void txt_cariPelanggan_TextChanged(object sender, EventArgs e)
        {
            //langkah 11 proses pencarian data
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_pelanggan WHERE kode_pelanggan LIKE '%" +
                    txt_cariPelanggan.Text + "%' OR nama_pelangganLIKE '%" +
                    txt_cariPelanggan.Text +"%' ORDER BY kode_pelanggan", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_pelanggan");
                lst_pelanggan.DataSource = ds;
                lst_pelanggan.DataMember = "tbl_pelanggan";
                lst_pelanggan.Refresh();
                conn.Close();


            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            bersih();
            txt_kodePelanggan.Focus();
        }

        private void lst_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_report_pelanggan reportpelanggan = new frm_report_pelanggan();
            reportpelanggan.Show();
        }
    }
}

