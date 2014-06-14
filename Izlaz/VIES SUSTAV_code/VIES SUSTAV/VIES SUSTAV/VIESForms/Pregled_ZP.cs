using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.VIESForms
{
    public partial class frm_pregledZP : Form
    {
        string passedInText;
        int passedInText2;
        string passedInText3;

        public frm_pregledZP(string OIB, int IDizvjesca, string razdoblje)
        {
            InitializeComponent();
            this.passedInText = OIB;
            this.passedInText2 = IDizvjesca;
            this.passedInText3 = razdoblje;
        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_pregledZP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_T27.tbl_ObveznikLookUp' table. You can move, or remove it, as needed.
            this.tbl_ObveznikLookUpTableAdapter.FillObveznik(this.ds_T27.tbl_ObveznikLookUp);

        }


    }
}
