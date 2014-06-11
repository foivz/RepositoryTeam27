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
            // TODO: This line of code loads data into the 'ds_T27.tbl_ObveznikLookUp' table. You can move, or remove it, as needed.
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
                }
            }
            catch (SystemException except)
            {
                MessageBox.Show(except.Message);
            }



        }

        

        

      
       

        
        
    }
}
