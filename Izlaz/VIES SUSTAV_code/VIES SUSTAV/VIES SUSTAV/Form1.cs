using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV
{
    public partial class frm_Osnovna : Form
    {
        public frm_Osnovna()
        {
            InitializeComponent();
        }

        private void mi_sifarnikPodručnihUreda_MouseUp(object sender, MouseEventArgs e)
        {
            SifarniciForms.frm_sifarnikPodrucniUredi sifarnikPodrucnih = 
                new SifarniciForms.frm_sifarnikPodrucniUredi();
            sifarnikPodrucnih.MdiParent = this;
            sifarnikPodrucnih.WindowState = FormWindowState.Normal;
            sifarnikPodrucnih.Show();


        }

        private void mi_sifarnikIspostava_MouseUp(object sender, MouseEventArgs e)
        {
            SifarniciForms.frm_sifarnikIspostava sifarnikIspostave =
                new SifarniciForms.frm_sifarnikIspostava();
            sifarnikIspostave.MdiParent = this;
            sifarnikIspostave.WindowState = FormWindowState.Normal;
            sifarnikIspostave.Show();
        }

        private void mi_sifarnikDjelatnosti_MouseUp(object sender, MouseEventArgs e)
        {
            SifarniciForms.frm_sifarnikDjelatnosti sifarnikDjelatnosti =
                new SifarniciForms.frm_sifarnikDjelatnosti();
            sifarnikDjelatnosti.MdiParent = this;
            sifarnikDjelatnosti.WindowState = FormWindowState.Normal;
            sifarnikDjelatnosti.Show();
        }

        private void mi_sifarnikZemalja_MouseUp(object sender, MouseEventArgs e)
        {
            SifarniciForms.frm_sifarnikZemalja sifarnikZemalja =
                new SifarniciForms.frm_sifarnikZemalja();
            sifarnikZemalja.MdiParent = this;
            sifarnikZemalja.WindowState = FormWindowState.Normal;
            sifarnikZemalja.Show();
        }

        private void mi_sifarnikObveze_MouseUp(object sender, MouseEventArgs e)
        {
            SifarniciForms.frm_sifarnikObveze sifarnikObveze =
                new SifarniciForms.frm_sifarnikObveze();
            sifarnikObveze.MdiParent = this;
            sifarnikObveze.WindowState = FormWindowState.Normal;
            sifarnikObveze.Show();
        }

        private void mi_sifarnikVlasnistva_MouseUp(object sender, MouseEventArgs e)
        {
            SifarniciForms.frm_sifarnikVlasnistva sifarnikVlasnistva =
                new SifarniciForms.frm_sifarnikVlasnistva();
            sifarnikVlasnistva.MdiParent = this;
            sifarnikVlasnistva.WindowState = FormWindowState.Normal;
            sifarnikVlasnistva.Show();
                
        }

        private void mi_unosNovogObveznika_MouseUp(object sender, MouseEventArgs e)
        {
            ViesForms.frn_registarVIES novoPretrazivanje =
                new ViesForms.frn_registarVIES();
            novoPretrazivanje.MdiParent = this;
            novoPretrazivanje.WindowState = FormWindowState.Normal;
            novoPretrazivanje.Show();
        }

        private void mii_unosNovogVIESObveznika_MouseUp(object sender, MouseEventArgs e)
        {
            ViesForms.frm_unosNovogObveznika noviObveznik =
                           new ViesForms.frm_unosNovogObveznika();
            noviObveznik.MdiParent = this;
            noviObveznik.WindowState = FormWindowState.Normal;
            noviObveznik.Show();
        }

        // Obrisati
        private void mii_registarVIES_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void mii_unosNovogVIESObveznika_MouseUp_1(object sender, MouseEventArgs e)
        {
            ViesForms.frm_unosNovogObveznika noviObveznik =
                new ViesForms.frm_unosNovogObveznika();
            noviObveznik.MdiParent = this;
            noviObveznik.WindowState = FormWindowState.Normal;
            noviObveznik.Show();
        }

        private void mi_unosNovogObveznikaNovo_MouseUp(object sender, MouseEventArgs e)
        {
            ViesForms.frm_unosNovogObveznika noviObveznik =
                new ViesForms.frm_unosNovogObveznika();
            noviObveznik.MdiParent = this;
            noviObveznik.WindowState = FormWindowState.Normal;
            noviObveznik.Show();
        }
        

       
    }
}
