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
           
            this.tbl_sifarnikAktivnostiTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikAktivnosti);
            
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
                        this.tbl_porezniObveznikDataGridView.DataSource = this.ds_porezniObveznik.tbl_porezniObveznik;
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

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtPretrazivanjeOIB.Clear();
                this.tbl_porezniObveznikDataGridView.DataSource = null;
                this.tbl_porezniObveznikDataGridView.Refresh();
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        private void btn_prikaziSve_Click(object sender, EventArgs e)
        {
            this.tbl_porezniObveznikDataGridView.DataSource = this.ds_porezniObveznik.tbl_porezniObveznik;
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
                    string OIB = tbl_porezniObveznikDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                    frm_detaljniPregled noviDetaljniPregled = new frm_detaljniPregled(OIB);
                    noviDetaljniPregled.Show();
                }
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
           
        }

       
    }
}
