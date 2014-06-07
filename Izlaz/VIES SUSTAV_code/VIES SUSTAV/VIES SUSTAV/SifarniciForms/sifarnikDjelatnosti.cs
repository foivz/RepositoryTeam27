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
    public partial class frm_sifarnikDjelatnosti : Form
    {
        public frm_sifarnikDjelatnosti()
        {
            InitializeComponent();
        }

        private void tbl_sifarnikDjelatnostiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_sifarnikDjelatnostiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_T27);

        }

        private void frm_sifarnikDjelatnosti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_T27.tbl_sifarnikDjelatnosti' table. You can move, or remove it, as needed.
            this.tbl_sifarnikDjelatnostiTableAdapter.Fill(this.ds_T27.tbl_sifarnikDjelatnosti);

        }
    }
}
