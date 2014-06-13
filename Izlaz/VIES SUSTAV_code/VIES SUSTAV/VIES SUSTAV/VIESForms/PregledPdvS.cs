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
    public partial class frm_PregledPdvS : Form
    {
        string passedInText;
        int passedInText2;
        string passedInText3;

        public frm_PregledPdvS(string OIB, int IDizvjesca, string razdoblje)
        {
            InitializeComponent();
            this.passedInText = OIB;
            this.passedInText2 = IDizvjesca;
            this.passedInText3 = razdoblje;
        }

        private void frm_PregledPdvS_Load(object sender, EventArgs e)
        {
           
            this.tbl_sifarnikZemljaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikZemlja);
            
            this.tbl_PdvSTableAdapter.FillByViesID(this.ds_PdvS.tbl_PdvS,passedInText2);
            
            this.tbl_ObveznikLookUpTableAdapter.FillObveznik(this.ds_T27.tbl_ObveznikLookUp);
            this.txt_IDizvjesca.Text = passedInText2.ToString();
            this.txt_razdoblje.Text = passedInText3;
        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbl_PdvSDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    this.tbl_PdvSDataGridView.Rows[e.RowIndex].Cells[0].Value = passedInText2;

                }
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navedenu izmjenu je potrebno SPREMITI!");
        }
    }
}
