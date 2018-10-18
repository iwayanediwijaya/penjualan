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
    public partial class frm_report_pelanggan : Form
    {
        public frm_report_pelanggan()
        {
            InitializeComponent();
        }

        private void frm_report_pelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ti15eDataSet.tbl_pelanggan' table. You can move, or remove it, as needed.
            this.tbl_pelangganTableAdapter.Fill(this.db_ti15eDataSet.tbl_pelanggan);

            this.rv_pelanggan.RefreshReport();
        }
    }
}
