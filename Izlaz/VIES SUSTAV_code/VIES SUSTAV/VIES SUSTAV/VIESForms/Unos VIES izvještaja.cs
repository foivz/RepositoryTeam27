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
    public partial class frm_UnosVIES : Form
    {
        public frm_UnosVIES()
        {
            InitializeComponent();
        }

        private void frm_UnosVIES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_ViesUnos.GetID' table. You can move, or remove it, as needed.
            this.getIDTableAdapter.Fill(this.ds_ViesUnos.GetID);
            // TODO: This line of code loads data into the 'ds_ViesUnos.tbl_VIESizvjestaj' table. You can move, or remove it, as needed.
            this.tbl_VIESizvjestajTableAdapter1.Fill(this.ds_ViesUnos.tbl_VIESizvjestaj);
            this.tbt_sifarnikStatusaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbt_sifarnikStatusa);
            
            this.tbl_ObveznikLookUpTableAdapter.FillObveznik(this.ds_T27.tbl_ObveznikLookUp);
            
            this.tbl_VIESizvjestajTableAdapter.Fill(this.ds_T27.tbl_VIESizvjestaj);
          
           

        }

        private void tbl_VIESizvjestajBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_VIESizvjestajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_T27);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string OIB = (this.comboBox1.SelectedValue.ToString());
                this.txt_spremanjeOIB.Text = OIB;
            }
            catch (SystemException except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void txt_stjecanje_Validating(object sender, CancelEventArgs e)
        {
            int num;

            bool isNum = int.TryParse(txt_stjecanje.Text.Trim(), out num);

            if (!isNum)
            {
                MessageBox.Show("Greška! Potrebno je unijeti brojčanu vrijednost.");
            }
        }

        private void txt_isporuke_Validating(object sender, CancelEventArgs e)
        {
            int num;
            bool isNum = int.TryParse(txt_isporuke.Text.Trim(), out num);

            if (!isNum)
            {
                MessageBox.Show("Greška! Potrebno je unijeti brojčanu vrijednost.");
            }
        }

        private void btn_spremi_Click(object sender, EventArgs e)
        {
            this.txt_status.Text =("1");

            try
            {

                if (MessageBox.Show("Želite li spremiti unjete podatke?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    var razdoblje = Convert.ToDateTime(this.txt_RazdobljedateTimePicker.Text.ToString());
                    int stjecanje = int.Parse(this.txt_stjecanje.Text.ToString());
                    int isporuke = int.Parse(this.txt_isporuke.Text.ToString());
                    var date = Convert.ToDateTime(this.txt_datumUnosa.Text.ToString());

                    this.tbl_VIESizvjestajTableAdapter.Insert(this.txt_OIB.Text.ToString(), razdoblje, stjecanje, isporuke, date, this.txt_status.Text.ToString());

                    MessageBox.Show("Podaci su uspješno spremljeni.");

                    int noviID = (int.Parse(ctxt_zadnjiID.Text.ToString()) + 1);
                    this.txt_ID.Text = noviID.ToString();
                 }
            }
            catch (SystemException except)
            {
                MessageBox.Show(except.Message);
            }



        }

        private void pbox_addPdvS_Click(object sender, EventArgs e)
        {
            try
            {
                int IdVies = int.Parse(this.txt_ID.Text.ToString());
                int prethodniId = int.Parse(this.ctxt_zadnjiID.Text.ToString());
                if (IdVies - prethodniId == 1)
                {
                    string OIB = txt_OIB.Text;
                    string IDizvjesca = txt_ID.Text;
                    string razdoblje = txt_RazdobljedateTimePicker.Text;

                    frm_unosPdvS noviIzvjestajPdvS = new frm_unosPdvS(OIB, IDizvjesca, razdoblje);
                    noviIzvjestajPdvS.Show();
                    this.pbox_PdvsOK.Visible = true;
                    this.pbox_PdvsEdit.Visible = true;
                    this.pbox_PdvsProvjeri.Visible = true;
                    this.pbox_addPdvS.Visible = false;
                    this.pbx_pdvsDodan.Visible = true;
                    this.lbl_pdvsDodan.Visible = true;
                }
                else
                {
                    MessageBox.Show("Spremite VIES izvješće prije nastavka.");
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_PdvsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
                int IDizvjesca = int.Parse(txt_ID.Text.ToString());
                string razdoblje = txt_RazdobljedateTimePicker.Text;

                frm_PregledPdvS noviPregledPdvS = new frm_PregledPdvS(OIB, IDizvjesca, razdoblje);
                noviPregledPdvS.Show();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_PdvsProvjeri_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
                int IDizvjesca = int.Parse(txt_ID.Text.ToString());
                string razdoblje = txt_RazdobljedateTimePicker.Text;

                frm_ProvjeraPDV_S novaProvjeraPdvS = new frm_ProvjeraPDV_S (OIB, IDizvjesca, razdoblje);
                novaProvjeraPdvS.Show();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        

      
       

        
        
    }
}
