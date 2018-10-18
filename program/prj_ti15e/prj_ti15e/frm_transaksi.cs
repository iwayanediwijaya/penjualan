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
    public partial class frm_transaksi : Form
    {
        //langkah 2. tambahkan fungsi String untuk koneksi database
        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        //variabel total bayar
        int subtotal = 0;
        int tharga = 0;

        //langkah 3. membuat prosedur bersih
        private void bersih_seluruh()
        {
            txt_noFaktur.Text = "";
            dtm_tglFaktur.Text = "";
            txt_kodePelanggan.Text = "";
            txt_namaPelanggan.Text = "";
            txt_kodeBarang.Text = "";
            txt_namaBarang.Text = "";
            txt_stock.Text = "0";
            txt_harga.Text = "0";
            txt_qty.Text = "0";
            txt_totalHarga.Text = "0";
            txt_totalBayar.Text = "0";
            txt_pencarianData.Text = "";
        }

        private void bersih_transaksi() 
        {
            txt_kodeBarang.Text = "";
            txt_namaBarang.Text = "";
            txt_stock.Text = "0";
            txt_harga.Text = "0";
            txt_qty.Text = "0";
            txt_totalHarga.Text = "0";
        }

        // prosedur koneksi ke detail transaksi
        private void koneksi_detail_transaksi() 
        {
            using(SqlConnection conn = new SqlConnection(strconn)) 
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM vw_detail_transaksi WHERE no_faktur='" + txt_noFaktur.Text + "' ORDER BY no_faktur", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds,"vw_detail_transaksi");
                lst_detail.DataSource=ds;
                lst_detail.DataMember="vw_detail_transaksi";

                lst_detail.AllowUserToAddRows = false;
             //   lst_detail.Columns[1].HeaderText = "Kode Barang";
             //   lst_detail.Columns[2].HeaderText = "Nama Barang";
              //  lst_detail.Columns[4].HeaderText = "Harga";
              //  lst_detail.Columns[6].HeaderText = "Qty";
              //  lst_detail.Columns[7].HeaderText = "Total Harga";

              //  lst_detail.Columns[0].Visible = false;
              //  lst_detail.Columns[3].Visible = false;
             //   lst_detail.Columns[5].Visible = false;
                lst_detail.Refresh();
                conn.Close();
            }
            }

        private void koneksi_transaksi()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM vw_transaksi ORDER BY no_faktur", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "vw_transaksi");
                lst_transaksi.DataSource = ds;
                lst_transaksi.DataMember = "vw_transaksi";

                lst_transaksi.AllowUserToAddRows = false;

                lst_transaksi.Refresh();
                conn.Close();
            }
        }

        // prosedur untuk membuat no faktur secara otomatis
        private void autonumber()
        {
            long hitung;
            string urut;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT no_faktur FROM tbl_transaksi WHERE no_faktur IN(SELECT MAX(no_faktur) " +
                    "FROM tbl_transaksi) ORDER BY no_faktur DESC", conn);
                rd = cmd.ExecuteReader();
                rd.Read();

                // jika record ditemukan
                if (rd.HasRows)
                {
                    // menambahkan data ke field
                    hitung = Convert.ToInt16(rd[0].ToString().Substring(
                        rd["no_faktur"].ToString().Length - 4, 4)) + 1;
                    string joinstr = "0000" + hitung;
                    // menampilkan 4 karakter kanan terakhir
                    urut = "F" + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    // jika data tidak di temukan
                    urut = "F0001";
                }
                rd.Close();
                txt_noFaktur.Text = urut;
                conn.Close();
            }
        }

        // prosedur hapus transaksi
        private void hapus_transaksi()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                cmd = new SqlCommand("DELETE FROM tbl_transaksi WHERE no_faktur='" +
                    txt_noFaktur.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // prosedur hapus detail transaksi
        private void hapus_detail_transaksi()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                cmd = new SqlCommand("DELETE FROM tbl_detail_transaksi WHERE no_faktur='" +
                    txt_noFaktur.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }



        public frm_transaksi()
        {
            InitializeComponent();
            bersih_seluruh();
            koneksi_detail_transaksi();
            koneksi_transaksi();
            autonumber();
            totalBayar();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cariPelanggan_Click(object sender, EventArgs e)
        {
            frm_cariPelanggan frmcaripelanggan = new frm_cariPelanggan();

            frmcaripelanggan.ShowDialog();
            txt_kodePelanggan.Text = frmcaripelanggan.ambil_kode_pelanggan;
            txt_namaPelanggan.Text = frmcaripelanggan.namapelanggan;
        }

        private void btn_cariBarang_Click(object sender, EventArgs e)
        {
            frm_cariBarang frmbarang = new frm_cariBarang();
            frmbarang.ShowDialog();
            txt_kodeBarang.Text = frmbarang.ambil_kode_barang;
            txt_namaBarang.Text = frmbarang.ambil_nama_barang;
            txt_harga.Text = frmbarang.ambil_harga;
            txt_stock.Text = frmbarang.ambil_stock;
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float harga, qty, total_harga;
                harga = float.Parse(txt_harga.Text);
                qty = float.Parse(txt_qty.Text);
                total_harga = qty * harga;
                txt_totalHarga.Text = System.Convert.ToString(total_harga);
            }
            catch
            { }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (txt_noFaktur.Text.Trim() == "" |
                txt_kodePelanggan.Text.Trim() == "" |
                txt_namaPelanggan.Text.Trim() == "" |
                txt_kodeBarang.Text.Trim() == "" |
                txt_qty.Text.Trim() == "")
            {
                MessageBox.Show("Lengkapi Data Transaksi");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                       
                        // simpan data ke detail transaksi
                        cmd = new SqlCommand("INSERT INTO tbl_detail_transaksi VALUES('" +
                            txt_noFaktur.Text + "','" +
                            txt_kodeBarang.Text + "','" +
                            txt_qty.Text + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Tersimpan");
                        koneksi_detail_transaksi();
                        bersih_transaksi();
                        totalBayar();
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        // jika data gagal di simpan
                        MessageBox.Show("No Faktur dan Kode Barang sudah ada di transaksi ini");
                    }
                }
            }
        }

        private void lst_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.lst_detail.Rows[e.RowIndex];
                txt_noFaktur.Text = row.Cells["no_faktur"].Value.ToString();
                txt_kodeBarang.Text = row.Cells["kode_barang"].Value.ToString();
                txt_namaBarang.Text = row.Cells["nama_barang"].Value.ToString();
                txt_harga.Text = row.Cells["harga"].Value.ToString();
                txt_stock.Text = row.Cells["stock"].Value.ToString();
                txt_qty.Text = row.Cells["qty"].Value.ToString();
                txt_totalHarga.Text = row.Cells["total_harga"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            if (txt_noFaktur.Text.Trim() == "" ||
              txt_kodeBarang.Text.Trim() == "" ||
              txt_namaBarang.Text.Trim() == "" ||
              txt_harga.Text.Trim() == "" |
                txt_stock.Text.Trim()== "" |
                txt_qty.Text.Trim() == "" |
                txt_totalHarga.Text.Trim() == "")
            {
                //pesan data belum lengkap
                MessageBox.Show("Pilih Data yang akan di Hapus", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Hapus Data " +
                txt_namaBarang.Text + "?", "Info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        // proses hapus
                        cmd = new SqlCommand("DELETE FROM tbl_detail_transaksi WHERE no_faktur='" +
                            txt_noFaktur.Text + "' AND kode_barang ='" +
                                txt_kodeBarang.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Di Hapus", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih_transaksi();
                        koneksi_detail_transaksi();
                        totalBayar();
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        // jika Data gagal di Hapus
                        MessageBox.Show("Data Gagal di Hapus", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                       bersih_transaksi();
                        koneksi_detail_transaksi();
                    }
                }
            }
        }

        private void txt_pencarianData_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM vw_detail_transaksi WHERE no_faktur LIKE '%" +
                    txt_pencarianData.Text + "%' ORDER BY no_faktur", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "vw_transaksi");
                lst_detail.DataSource = ds;
                lst_detail.DataMember = "vw_transaksi";
                lst_detail.Refresh();
                conn.Close();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            // simpan data ke transaksi
            if (txt_noFaktur.Text.Trim() == "" |
                txt_kodePelanggan.Text.Trim() == "" |
                txt_totalBayar.Text == "0")
            {
                MessageBox.Show("Lengkapi data Transaksi");
            }
            else
            {

                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        // simpan data
                        cmd = new SqlCommand("INSERT INTO tbl_transaksi VALUES ('" +
                            txt_noFaktur.Text + "', '" +
                            dtm_tglFaktur.Text + "', '" +
                            txt_kodePelanggan.Text + "', '"+
                            txt_totalBayar.Text + "')", conn);

                        conn.Open();
                        //eksekusi perintah query
                        cmd.ExecuteNonQuery();
             
                        MessageBox.Show("Data Berhasil Disimpan", "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi_transaksi();
                        bersih_seluruh();
                        autonumber();
                        koneksi_detail_transaksi();
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        //jika data gagal disimpan
                        MessageBox.Show("Data Gagal Disimpan", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

// method total Bayar per no faktur
private void totalBayar() 
{

    string total;
    using (SqlConnection conn = new SqlConnection(strconn))
    {
        conn.Open();
        cmd = new SqlCommand("SELECT SUM(total_harga) AS total_bayar from vw_detail_transaksi WHERE no_faktur='" + txt_noFaktur.Text + "' GROUP BY no_faktur", conn);
        rd = cmd.ExecuteReader();
        rd.Read();
        // jika data di temukan
        if (rd.HasRows)
        {
            // ambil nilai total bayar
            total = Convert.ToString(rd["total_bayar"]);
            // tampilkan total bayar di txt_totalbayar
            txt_totalBayar.Text = total;
        }
        rd.Close();
        conn.Close();


    }
}
private void btn_baru_Click(object sender, EventArgs e)
      {
          bersih_seluruh();
          koneksi_detail_transaksi();
          koneksi_transaksi();
          autonumber();
          totalBayar();
      }

private void lst_transaksi_CellClick(object sender, DataGridViewCellEventArgs e)
      {
          DataGridViewRow row = lst_transaksi.Rows[e.RowIndex];
          txt_noFaktur.Text = row.Cells["no_faktur"].Value.ToString();
          dtm_tglFaktur.Text = row.Cells["tgl_faktur"].Value.ToString();
          txt_kodePelanggan.Text = row.Cells["kode_pelanggan"].Value.ToString();
          txt_namaPelanggan.Text = row.Cells["nama_pelanggan"].Value.ToString();
          koneksi_detail_transaksi();
          totalBayar();

        
      }

private void btn_hapus_Click(object sender, EventArgs e)
{
    if (txt_noFaktur.Text.Trim() == "" ||
             txt_kodePelanggan.Text.Trim() == "" ||
             txt_namaPelanggan.Text.Trim() == "" ||
               dtm_tglFaktur.Text.Trim() == "")
    {
        //pesan data belum lengkap
        MessageBox.Show("Pilih Data yang akan di Hapus", "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else if (MessageBox.Show("Hapus Data " +
        txt_noFaktur.Text + "?", "Info",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
        using (SqlConnection conn = new SqlConnection(strconn))
        {
            try
            {
                // proses hapus 
                conn.Open();
                cmd = new SqlCommand("select * FROM tbl_transaksi WHERE no_faktur='" +
                    txt_noFaktur.Text + "'", conn);
                rd = cmd.ExecuteReader();
              // jika data ditemukan
                if (rd.Read())
                {
                    // panggil prosedur hapus
                    hapus_transaksi();
                    hapus_detail_transaksi();
                }
                MessageBox.Show("Data Berhasil Di Hapus", "Info",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih_seluruh();
                autonumber();
                koneksi_detail_transaksi();
                koneksi_transaksi();
                conn.Close();
            }
            catch (Exception)
            {
                // jika Data gagal di Hapus
                MessageBox.Show("Data Gagal di Hapus", "Info",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }
    }
}

private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
{
    const char delete = (char)8;
    e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
}

private void frm_transaksi_Load(object sender, EventArgs e)
{

}
    }
}