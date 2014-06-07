using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.SifarniciForms
{
    public partial class frm_sifarnikIspostava : Form
    {
        public frm_sifarnikIspostava()
        {
            InitializeComponent();
        }

        private void tbl_sifarnikIspostavaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_sifarnikIspostavaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_T27);

        }

        private void frm_sifarnikIspostava_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_T27.tbl_sifarnikIspostava' table. You can move, or remove it, as needed.
            this.tbl_sifarnikIspostavaTableAdapter.Fill(this.ds_T27.tbl_sifarnikIspostava);

        }
    }
}
