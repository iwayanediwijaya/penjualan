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
    public partial class frm_barang : Form
    {

        //langkah 2. tambahkan fungsi String untuk koneksi database
        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //langkah 3. membuat prosedur bersih
        private void bersih()
        {
            txt_kodebarang.Text = "";
            txt_namabarang.Text = "";
            cbo_satuan.Text = "";
            txt_harga.Text = "";
            txt_stock.Text = "";
            txt_pencariandata.Text = "";

        }

        //langkah 4. membuat prosedur untuk koneksi ke tbl_barang
        private void koneksi_barang()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_barang ORDER BY kode_barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_barang");
                lst_barang.DataSource = ds;
                lst_barang.DataMember = "tbl_barang";
                lst_barang.Refresh();
                conn.Close();
            }
        }
        public frm_barang()
        {
            InitializeComponent();
            //langkah 5. memanggil koneksi dan bersih
            bersih();
            koneksi_barang();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            //langkah 6. membersihkan text
            bersih();
            txt_kodebarang.Focus();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            //langkah 7. membuat proses simpan

            //kondisi jika data belum lengkap
            if (txt_kodebarang.Text.Trim() == "" ||
                txt_namabarang.Text.Trim() == "" ||
                cbo_satuan.Text.Trim() == "" ||
                txt_harga.Text.Trim() == "" ||
                txt_stock.Text.Trim() == "")
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
                        cmd = new SqlCommand("INSERT INTO tbl_barang VALUES('" +
                            txt_kodebarang.Text + "','" +
                            txt_namabarang.Text + "','" +
                            cbo_satuan.Text + "','" +
                            txt_harga.Text + "','" +
                            txt_stock.Text + "')", conn);
                        //buka koneksi
                        conn.Open();
                        //eksekusi perintah query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan", "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_barang();

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

        private void lst_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lst_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //langkah 8
            //menampilkan data dari list barang ke textbox, dll
            DataGridViewRow row = this.lst_barang.Rows[e.RowIndex];
            txt_kodebarang.Text = row.Cells["kode_barang"].Value.ToString();
            txt_namabarang.Text = row.Cells["nama_barang"].Value.ToString();
            cbo_satuan.Text = row.Cells["satuan"].Value.ToString();
            txt_harga.Text = row.Cells["harga"].Value.ToString();
            txt_stock.Text = row.Cells["stock"].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //langkah 9. membuat proses edit

            //kondisi jika data belum lengkap
            if (txt_kodebarang.Text.Trim() == "" ||
                txt_namabarang.Text.Trim() == "" ||
                cbo_satuan.Text.Trim() == "" ||
                txt_harga.Text.Trim() == "" ||
                txt_stock.Text.Trim() == "")
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
                        cmd = new SqlCommand("UPDATE tbl_barang SET nama_barang='" +
                            txt_namabarang.Text + "', satuan='" +
                            cbo_satuan.Text + "', harga='" +
                            txt_harga.Text + "', stock='" +
                            txt_stock.Text + "' WHERE kode_barang='" +
                            txt_kodebarang.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diedit", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_barang();
                    }
                    catch (Exception)
                    {
                        // jika Data gagal di edit
                        MessageBox.Show("Data Gagal di edit", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bersih();
                        koneksi_barang();
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            // langkah 10 membuat proses hapus data
            if (txt_kodebarang.Text.Trim() == "" ||
                txt_namabarang.Text.Trim() == "" ||
               cbo_satuan.Text.Trim() == "" ||
               txt_harga.Text.Trim() == "" ||
               txt_stock.Text.Trim() == "")
            {
                //pesan data belum lengkap
                MessageBox.Show("Pilih Data yang akan di Hapus", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Hapus Data " +
                txt_namabarang.Text + "?", "Info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        // proses hapus
                        cmd = new SqlCommand("DELETE FROM tbl_barang WHERE kode_barang='" +
                            txt_kodebarang.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Di Hapus", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_barang();
                    }
                    catch (Exception)
                    {
                        // jika Data gagal di Hapus
                        MessageBox.Show("Data Gagal di Hapus", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bersih();
                        koneksi_barang();
                    }
                }
            }
        }

        private void txt_pencariandata_TextChanged(object sender, EventArgs e)
        {
            //langkah 11 proses pencarian data
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_barang WHERE kode_barang LIKE '%" +
                    txt_pencariandata.Text + "%' OR nama_barang LIKE '%" +
                    txt_pencariandata.Text + "%' OR satuan LIKE '%" +
                    txt_pencariandata.Text + "%' OR harga LIKE '%" +
                    txt_pencariandata.Text + "%' OR stock LIKE '%" +
                    txt_pencariandata.Text + "%' ORDER BY kode_barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_barang");
                lst_barang.DataSource = ds;
                lst_barang.DataMember = "tbl_barang";
                lst_barang.Refresh();
                conn.Close();


            }
        }

        private void txt_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void txt_namabarang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {
            frm_report_barang report = new frm_report_barang();
            report.Show();
        }

        private void frm_barang_Load(object sender, EventArgs e)
        {

        }
    }
}
