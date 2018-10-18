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
    public partial class frm_cariBarang : Form
    {
        //langkah 2. tambahkan fungsi String untuk koneksi database
        private static String strconn = "server=WAYAN\\SQLEXPRESS;Initial Catalog=db_ti15e;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        // buat variabel global
        public string kodebarang, namabarang, harga, stock = "";

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
        public frm_cariBarang()
        {
            InitializeComponent();
            koneksi_barang();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lst_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_transaksi frmtransaksi = new frm_transaksi();
            DataGridViewRow row = this.lst_barang.Rows[e.RowIndex];

            kodebarang = row.Cells["kode_barang"].Value.ToString();
            namabarang = row.Cells["nama_barang"].Value.ToString();
            harga = row.Cells["harga"].Value.ToString();
            stock = row.Cells["stock"].Value.ToString();
            this.Close();
        }

        public string ambil_kode_barang
        {
            get
            {
                return kodebarang;
            }
        }

        public string ambil_nama_barang
        {
            get
            {
                return namabarang;
            }
        }

        public string ambil_harga
        {
            get
            {
                return harga;
            }
        }
        public string ambil_stock
        {
            get
            {
                return stock;
            }
        }

        private void frm_cariBarang_Load(object sender, EventArgs e)
        {

        }
    }
}

