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
    public partial class frn_registarVIES : Form
    {
        public frn_registarVIES()
        {
            InitializeComponent();
        }

        private void tbl_porezniObveznikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_porezniObveznikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_porezniObveznik);

        }

        private void frn_registarVIES_Load(object sender, EventArgs e)
        {
            
            this.tbl_sifarnikIspostavaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikIspostava);
            
            this.tbl_sifarnikPodrucnihUredaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikPodrucnihUreda);
           
            

        }

        private void btn_traziOIB_Click(object sender, EventArgs e)
        {
            try
            {
                const int duljina = 11;
                string OIB = txtPretrazivanjeOIB.Text;

                int slova = 0;


                foreach (char c in OIB)
                    if (!Char.IsDigit(c))
                    {
                        slova+=1;
                    }
              
                    if (OIB.Length != duljina || slova!= 0)
                    {
                        MessageBox.Show("Greška. Molimo unesite OIB (11 znamenaka).");

                       

                    }

                    else 
                    {

                        this.tbl_porezniObveznikTableAdapter.FillByOIB(this.ds_porezniObveznik.tbl_porezniObveznik, OIB);

                        int brojRedova = int.Parse(tbl_porezniObveznikDataGridView.RowCount.ToString());

                        if (brojRedova < 1)
                        {
                            MessageBox.Show("Nije pronađen niti jedan porezni obveznik sa navedenim OIB-om.");

                        }

                    }
            }
            catch (System.Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
        }

        // odustajem
        private void txtPretrazivanjeOIB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPretrazivanjeOIB.Clear();
        }

        private void btn_prikaziSve_Click(object sender, EventArgs e)
        {
            this.tbl_porezniObveznikTableAdapter.Fill(this.ds_porezniObveznik.tbl_porezniObveznik);
        }

        private void btn_unosNovogObveznika_Click(object sender, EventArgs e)
        {
            frm_unosNovogObveznika noviUnos = new frm_unosNovogObveznika();
            noviUnos.Show();

        }

        private void tbl_porezniObveznikDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try 
            {
                if (e.RowIndex > -1)
                {
                    var ID = tbl_porezniObveznikDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    string OIB = tbl_porezniObveznikDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                    frm_detaljniPodaciObveznika noviDetaljniPodaci = new frm_detaljniPodaciObveznika();

                    noviDetaljniPodaci.Show();
                }
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
           
        }
    }
}
