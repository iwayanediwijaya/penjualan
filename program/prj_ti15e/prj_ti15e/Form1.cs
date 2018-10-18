using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_ti15e
{
    public partial class Form1 : Form
    {
        public static Form1 mdiobj; //untuk digunakan di form login

        public Form1()
        {
            InitializeComponent();
        }

        private void keluarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Keluar dari Aplikasi  ?", "Konfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // menampilkan form barang
            frm_barang formbarang = new frm_barang();
            formbarang.MdiParent = this;
            formbarang.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_transaksi frmtransaksi = new frm_transaksi();
            frmtransaksi.MdiParent = this;
            frmtransaksi.Show();
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_pelanggan frmpelanggan = new Frm_pelanggan();
            frmpelanggan.MdiParent = this;
            frmpelanggan.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mdiobj = this;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

          //  dataMasterToolStripMenuItem.Enabled = false;
          //  transaksiToolStripMenuItem.Enabled = false;
          //  cetakToolStripMenuItem.Enabled = false;
          //  pelangganToolStripMenuItem.Enabled = false;
           // logoutToolStripMenuItem.Enabled = false;

            frmlogout logout = new frmlogout();
            logout.ShowDialog();
        }

        private void laporanDataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_report_barang reportbarang = new frm_report_barang();
            reportbarang.Show();
        }

        private void ubahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ubahpassword ubahpassword = new frm_ubahpassword();
            ubahpassword.Show();
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cetakpenjualan ctkpenjualan = new frm_cetakpenjualan();
            ctkpenjualan.MdiParent = this;
            ctkpenjualan.Show();
        }

        private void laporanDataPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
