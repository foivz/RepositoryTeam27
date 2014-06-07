using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.SifarniciForms
{
    public partial class frm_sifarnikPodrucniUredi : Form
    {
        public frm_sifarnikPodrucniUredi()
        {
            InitializeComponent();
        }

        private void tbl_sifarnikPodrucnihUredaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_sifarnikPodrucnihUredaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_T27);

        }

        private void frm_sifarnikPodrucniUredi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_T27.tbl_sifarnikPodrucnihUreda' table. You can move, or remove it, as needed.
            this.tbl_sifarnikPodrucnihUredaTableAdapter.Fill(this.ds_T27.tbl_sifarnikPodrucnihUreda);

        }

        // Sort pripadajućih poreznih ispostava
        private void tbl_sifarnikPodrucnihUredaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sifraPodrucnog = int.Parse(tbl_sifarnikPodrucnihUredaDataGridView.CurrentRow.Cells[0].Value.ToString());

            var MyDataContex = new dsT27DataContext();

            var Ispostave =
                from Područni in MyDataContex.tbl_sifarnikPodrucnihUredas
                join Ispostava in MyDataContex.tbl_sifarnikIspostavas
                on Područni.sifraPodrucnogUreda equals Ispostava.sifraPodrucnogUreda
                where Ispostava.sifraPodrucnogUreda == sifraPodrucnog
                select Ispostava;

            lboxIspostavePU.Items.Clear();

            foreach (var Ispostava in Ispostave)
            {
                lboxIspostavePU.Items.Add(Ispostava.nazivIspostave);
            }
        }
    }
}
