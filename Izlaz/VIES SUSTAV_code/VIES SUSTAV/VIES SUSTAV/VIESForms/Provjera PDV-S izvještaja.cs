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
    public partial class frm_ProvjeraPDV_S : Form
    {
        string passedInText;
        int passedInText2;
        string passedInText3;

        public frm_ProvjeraPDV_S(string OIB, int IDizvjesca, string razdoblje)
        {
            InitializeComponent();
            this.passedInText = OIB;
            this.passedInText2 = IDizvjesca;
            this.passedInText3 = razdoblje;
        }

        private void frm_ProvjeraPDV_S_Load(object sender, EventArgs e)
        {
            
            this.tbl_sifarnikZemljaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikZemlja);
            
            this.tbl_PdvSTableAdapter.FillByViesID(this.ds_PdvS.tbl_PdvS,passedInText2);
            
            this.tbl_ObveznikLookUpTableAdapter.FillObveznik(this.ds_T27.tbl_ObveznikLookUp);

            this.txt_IDizvjesca.Text = passedInText2.ToString();
            this.txt_razdoblje.Text = passedInText3;

        }

      
        private void btn_provjeri_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 1; i < this.tbl_PdvSDataGridView.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(tbl_PdvSDataGridView.Rows[i].Cells[5].Value);
                }

                this.txt_ukupnoPdvS.Text = sum.ToString();
            }

            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
