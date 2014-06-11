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
    public partial class frm_detaljniPregled : Form
    {
        string passedInText;
        public frm_detaljniPregled(string text)
        {
            InitializeComponent();
            this.passedInText = text;

        }

        private void tbl_porezniObveznikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_porezniObveznikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_porezniObveznik);

        }

        
        private void Detaljni_pregled_Load(object sender, EventArgs e)
        {
           
            this.tbl_sifarnikAktivnostiTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikAktivnosti);
           
            this.tbl_sifarnikZemljaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikZemlja);
           
            this.tbl_sifarnikObvezeTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikObveze);
           
            this.tbl_sifarnikVlasnistvaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikVlasnistva);
            
            this.tbl_sifarnikDjelatnostiTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikDjelatnosti);
          
            this.tbl_sifarnikIspostavaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikIspostava);
            
            this.tbl_sifarnikPodrucnihUredaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikPodrucnihUreda);
            this.tbl_porezniObveznikTableAdapter.FillByOIB(this.ds_porezniObveznik.tbl_porezniObveznik,passedInText);

        }

        private void btn_azuriraj_Click(object sender, EventArgs e)
        {
           
            try
            {
                aktivacijaAzuriranja();                 
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        // aktivacija polja
        private void aktivacijaAzuriranja()
        {
            this.cbox_podrucni.Enabled = true;
            this.cbox_ispostave.Enabled = true;
            this.cbox_status.Enabled = true;
            this.txt_OIB.Enabled = false;
            this.pic_alert.Visible = true;
            this.txt_adresa.Enabled = true;
            this.cbox_Zemlja.Enabled = true;
            this.cbox_djelatnost.Enabled = true;
            this.txt_telefon.Enabled = true;
            this.txt_Email.Enabled = true;
            this.cbox_vlasnistvo.Enabled = true;
            this.cbox_obveza.Enabled = true;
            this.txt_korisnickoIme.Enabled = true;
            this.txt_zaporka.Enabled = true;
            this.txt_datumDateTimePicker.Enabled = true;
            this.btn_spremi.Visible = true;
            this.btn_azuriraj.Visible = false;
            this.btn_zatvori.Visible = false;
        }

        private void spremiZatvaranje()
        {
            this.cbox_podrucni.Enabled = false;
            this.cbox_ispostave.Enabled = false;
            this.cbox_status.Enabled = false;
            this.txt_OIB.Enabled = false;
            this.pic_alert.Visible = false;
            this.txt_adresa.Enabled = false;
            this.cbox_Zemlja.Enabled = false;
            this.cbox_djelatnost.Enabled = false;
            this.txt_telefon.Enabled = false;
            this.txt_Email.Enabled = false;
            this.cbox_vlasnistvo.Enabled = false;
            this.cbox_obveza.Enabled = false;
            this.txt_korisnickoIme.Enabled = false;
            this.txt_zaporka.Enabled = false;
            this.txt_datumDateTimePicker.Enabled = false;
            this.btn_spremi.Visible = false;
            this.btn_azuriraj.Visible = true;
            this.btn_zatvori.Visible = true;
        }
        private void pic_alert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OIB se ne može ažurirati! Izmjena OIB-a podrazumijeva unos novog poreznog obveznika!");
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            string eMail = this.txt_Email.Text;
            int imaMankey = eMail.IndexOf("@");
            int imaTocku = eMail.IndexOf(".");

            if (imaMankey == -1 || imaTocku == -1)
            {
                MessageBox.Show("Greška. Upišite točnu e-mail adresu.");
            }
        }

        private void btn_spremi_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Želite li spremiti podatke za ovog poreznog obveznika?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    this.Validate();
                    this.tbl_porezniObveznikBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.ds_porezniObveznik);


                    MessageBox.Show("Podaci su uspješno spremljeni");

                    spremiZatvaranje();
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            
       

        
        
    }
}
