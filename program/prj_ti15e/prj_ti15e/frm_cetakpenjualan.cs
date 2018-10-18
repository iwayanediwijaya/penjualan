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
    public partial class frm_cetakpenjualan : Form
    {
        public frm_cetakpenjualan()
        {
            InitializeComponent();
        }

        private void frm_cetakpenjualan_Load(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdb_seluruh_CheckedChanged(object sender, EventArgs e)
        {
            dtm_awal.Enabled = false;
            dtm_akhir.Enabled = false;
        }

        private void rdb_seleksi_CheckedChanged(object sender, EventArgs e)
        {
            dtm_awal.Enabled = true;
            dtm_akhir.Enabled = true;
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
