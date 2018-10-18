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
    public partial class frm_cariPelanggan : Form
    {
        //langkah 2. tambahkan fungsi String untuk koneksi database
        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        // buat variabel global
        public string kodepelanggan, namapelanggan = "";

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
        public frm_cariPelanggan()
        {
            InitializeComponent();
            koneksi_pelanggan();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            //langkah 11 proses pencarian data
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_pelanggan WHERE kode_pelanggan LIKE '%" +
                    txt_cari.Text + "%' OR nama_pelangganLIKE '%" +
                    txt_cari.Text + "%' ORDER BY kode_pelanggan", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_pelanggan");
                lst_pelanggan.DataSource = ds;
                lst_pelanggan.DataMember = "tbl_pelanggan";
                lst_pelanggan.Refresh();
                conn.Close();


            }
        }

        private void lst_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_transaksi frmtransaksi = new frm_transaksi();
            DataGridViewRow row = this.lst_pelanggan.Rows[e.RowIndex];

           kodepelanggan = row.Cells["kode_pelanggan"].Value.ToString();
           namapelanggan = row.Cells["nama_pelanggan"].Value.ToString();
            this.Close();
        }

        public string ambil_kode_pelanggan
        {
            get
            {
                return kodepelanggan;
            }
        }

        public string ambil_nama_pelanggan
        {
            get
            {
                return namapelanggan;
            }
        }

        private void frm_cariPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
