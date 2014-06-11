using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.ViesForms
{
    public partial class frm_detaljniPodaciObveznika : Form
    {
        public frm_detaljniPodaciObveznika()
        {
            InitializeComponent();
        }

        private void frm_detaljniPodaciObveznika_Load(object sender, EventArgs e)
        {
            this.tbl_porezniObveznikTableAdapter.Fill(this.ds_porezniObveznik.tbl_porezniObveznik);
        }
    }
}
