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
    public partial class frm_unosNovogObveznika : Form
    {
        public frm_unosNovogObveznika()
        {
            InitializeComponent();
        }

        private void tbl_porezniObveznikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_porezniObveznikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_porezniObveznik);

        }

        private void frm_UnosNovogObveznika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikAktivnosti' table. You can move, or remove it, as needed.
            this.tbl_sifarnikAktivnostiTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikAktivnosti);
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikObveze' table. You can move, or remove it, as needed.
            this.tbl_sifarnikObvezeTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikObveze);
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikVlasnistva' table. You can move, or remove it, as needed.
            this.tbl_sifarnikVlasnistvaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikVlasnistva);
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikDjelatnosti' table. You can move, or remove it, as needed.
            this.tbl_sifarnikDjelatnostiTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikDjelatnosti);
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikZemlja' table. You can move, or remove it, as needed.
            this.tbl_sifarnikZemljaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikZemlja);
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikIspostava' table. You can move, or remove it, as needed.
            this.tbl_sifarnikIspostavaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikIspostava);
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbl_sifarnikPodrucnihUreda' table. You can move, or remove it, as needed.
            this.tbl_sifarnikPodrucnihUredaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikPodrucnihUreda);
            // TODO: This line of code loads data into the 'ds_porezniObveznik.tbl_porezniObveznik' table. You can move, or remove it, as needed.
            this.tbl_porezniObveznikTableAdapter.Fill(this.ds_porezniObveznik.tbl_porezniObveznik);

        }

        private void tbl_porezniObveznikBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbox_podrucni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_podrucni.SelectedIndex > -1)
            {
                int sifraPodrucnog = int.Parse(cbox_podrucni.SelectedValue.ToString());

                this.tbl_sifarnikIspostavaTableAdapter.FillByPodrucni(this.ds_sifarnici_lookUp.tbl_sifarnikIspostava, sifraPodrucnog);

            }
        }

        // Provjera OIB-a
        private void txt_OIB_Leave(object sender, EventArgs e)
        {
            try
            {
                const int duljina = 11;
                string OIB =txt_OIB.Text;
                int slova = 0;
                
                foreach (char c in OIB)
                    if (!Char.IsDigit(c))
                    {
                        slova += 1;
                    }

                if (OIB.Length != duljina || slova != 0)
                {
                    MessageBox.Show("Greška. Molimo unesite OIB (11 znamenaka).");
                }

            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        

        private void txt_eMail_Leave(object sender, EventArgs e)
        {
            string eMail = txt_eMail.Text;
            int imaMankey = eMail.IndexOf("@");
            int imaTocku = eMail.IndexOf(".");

            if (imaMankey == -1 || imaTocku == -1)
            {
                MessageBox.Show("Greška. Upišite točnu e-mail adresu.");
            }
        }

               
        //Spremi poreznog obveznika
        private void btn_SpremiPorObv_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Želite li spremiti podatke za ovog poreznog obveznika?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    int podrucni = int.Parse(txt_podrucni.Text.ToString());
                    int ispostava = int.Parse(txt_Ispostava.Text.ToString());
                    int djelatnost = int.Parse(txt_Djelatnost.Text.ToString());
                    int vlasnistvo = int.Parse(txt_sifraVlasnistva.Text.ToString());
                    int obveza = int.Parse(txt_sifraObveze.Text.ToString());
                    int aktivnost = int.Parse(txt_aktivnost.Text.ToString());

                    this.tbl_porezniObveznikTableAdapter.Insert(this.txt_OIB.Text.ToString(), podrucni, ispostava, this.txt_nazivObveznika.Text.ToString(), this.txt_adresa.Text.ToString(), this.txt_Zemlja.Text.ToString(), djelatnost,
                        this.txt_telefon.Text.ToString(), this.txt_eMail.Text.ToString(), vlasnistvo, obveza, this.txt_korisnickoIme.Text.ToString(), this.txt_Zaporka.Text.ToString(), System.DateTime.Today,this.txt_aktivnost.Text.ToString());

                    MessageBox.Show("Podaci su uspješno spremljeni");
                }
            }

            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btm_dodajNovi_Click(object sender, EventArgs e)
        {

            this.txt_OIB.Clear();
            this.txt_nazivObveznika.Clear();
            this.txt_adresa.Clear();
            this.txt_telefon.Clear();
            this.txt_eMail.Clear();
            this.txt_korisnickoIme.Clear();
            this.txt_Zaporka.Clear();
            this.cbox_aktivnost.SelectedItem.Equals(0);

        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
