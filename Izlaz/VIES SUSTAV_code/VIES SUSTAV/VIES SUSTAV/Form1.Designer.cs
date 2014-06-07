namespace VIES_SUSTAV
{
    partial class frm_Osnovna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Osnovna));
            this.ms_Osnovni = new System.Windows.Forms.MenuStrip();
            this.ms_Sifarnici = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sifarnikPodručnihUreda = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sifarnikIspostava = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sifarnikDjelatnosti = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sifarnikZemalja = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sifarnikObveze = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sifarnikVlasnistva = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_registarPoreznihObveznika = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_registarVIESNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_unosNovogObveznikaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Osnovni.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Osnovni
            // 
            this.ms_Osnovni.BackColor = System.Drawing.Color.Orange;
            this.ms_Osnovni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_Osnovni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Sifarnici,
            this.ms_registarPoreznihObveznika});
            this.ms_Osnovni.Location = new System.Drawing.Point(0, 0);
            this.ms_Osnovni.Name = "ms_Osnovni";
            this.ms_Osnovni.Size = new System.Drawing.Size(1012, 24);
            this.ms_Osnovni.TabIndex = 1;
            this.ms_Osnovni.Text = "ms_osnovni";
            // 
            // ms_Sifarnici
            // 
            this.ms_Sifarnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_sifarnikPodručnihUreda,
            this.mi_sifarnikIspostava,
            this.mi_sifarnikDjelatnosti,
            this.mi_sifarnikZemalja,
            this.mi_sifarnikObveze,
            this.mi_sifarnikVlasnistva});
            this.ms_Sifarnici.Name = "ms_Sifarnici";
            this.ms_Sifarnici.Size = new System.Drawing.Size(67, 20);
            this.ms_Sifarnici.Text = "Šifarnici";
            // 
            // mi_sifarnikPodručnihUreda
            // 
            this.mi_sifarnikPodručnihUreda.Name = "mi_sifarnikPodručnihUreda";
            this.mi_sifarnikPodručnihUreda.Size = new System.Drawing.Size(265, 22);
            this.mi_sifarnikPodručnihUreda.Text = "Šifarnik Područnih ureda PU";
            this.mi_sifarnikPodručnihUreda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_sifarnikPodručnihUreda_MouseUp);
            // 
            // mi_sifarnikIspostava
            // 
            this.mi_sifarnikIspostava.Name = "mi_sifarnikIspostava";
            this.mi_sifarnikIspostava.Size = new System.Drawing.Size(265, 22);
            this.mi_sifarnikIspostava.Text = "Šifarnik Ispostava PU";
            this.mi_sifarnikIspostava.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_sifarnikIspostava_MouseUp);
            // 
            // mi_sifarnikDjelatnosti
            // 
            this.mi_sifarnikDjelatnosti.Name = "mi_sifarnikDjelatnosti";
            this.mi_sifarnikDjelatnosti.Size = new System.Drawing.Size(265, 22);
            this.mi_sifarnikDjelatnosti.Text = "Šifarnik poslovnih djelatnosti";
            this.mi_sifarnikDjelatnosti.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_sifarnikDjelatnosti_MouseUp);
            // 
            // mi_sifarnikZemalja
            // 
            this.mi_sifarnikZemalja.Name = "mi_sifarnikZemalja";
            this.mi_sifarnikZemalja.Size = new System.Drawing.Size(265, 22);
            this.mi_sifarnikZemalja.Text = "Šifarnik zemalja EU";
            this.mi_sifarnikZemalja.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_sifarnikZemalja_MouseUp);
            // 
            // mi_sifarnikObveze
            // 
            this.mi_sifarnikObveze.Name = "mi_sifarnikObveze";
            this.mi_sifarnikObveze.Size = new System.Drawing.Size(265, 22);
            this.mi_sifarnikObveze.Text = "Šifarnik vrste obveze";
            this.mi_sifarnikObveze.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_sifarnikObveze_MouseUp);
            // 
            // mi_sifarnikVlasnistva
            // 
            this.mi_sifarnikVlasnistva.Name = "mi_sifarnikVlasnistva";
            this.mi_sifarnikVlasnistva.Size = new System.Drawing.Size(265, 22);
            this.mi_sifarnikVlasnistva.Text = "Šifarnik vrste vlasništva";
            this.mi_sifarnikVlasnistva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_sifarnikVlasnistva_MouseUp);
            // 
            // ms_registarPoreznihObveznika
            // 
            this.ms_registarPoreznihObveznika.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_registarVIESNovo,
            this.mi_unosNovogObveznikaNovo});
            this.ms_registarPoreznihObveznika.Name = "ms_registarPoreznihObveznika";
            this.ms_registarPoreznihObveznika.Size = new System.Drawing.Size(192, 20);
            this.ms_registarPoreznihObveznika.Text = "Registar poreznih obveznika";
            // 
            // mi_registarVIESNovo
            // 
            this.mi_registarVIESNovo.Name = "mi_registarVIESNovo";
            this.mi_registarVIESNovo.Size = new System.Drawing.Size(295, 22);
            this.mi_registarVIESNovo.Text = "Registar  VIES poreznih obveznika";
            this.mi_registarVIESNovo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_unosNovogObveznika_MouseUp);
            // 
            // mi_unosNovogObveznikaNovo
            // 
            this.mi_unosNovogObveznikaNovo.Name = "mi_unosNovogObveznikaNovo";
            this.mi_unosNovogObveznikaNovo.Size = new System.Drawing.Size(295, 22);
            this.mi_unosNovogObveznikaNovo.Text = "Unos novog obveznika";
            this.mi_unosNovogObveznikaNovo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mi_unosNovogObveznikaNovo_MouseUp);
            // 
            // frm_Osnovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 708);
            this.Controls.Add(this.ms_Osnovni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Osnovni;
            this.Name = "frm_Osnovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VIES SUSTAV";
            this.ms_Osnovni.ResumeLayout(false);
            this.ms_Osnovni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Osnovni;
        private System.Windows.Forms.ToolStripMenuItem ms_Sifarnici;
        private System.Windows.Forms.ToolStripMenuItem mi_sifarnikPodručnihUreda;
        private System.Windows.Forms.ToolStripMenuItem mi_sifarnikIspostava;
        private System.Windows.Forms.ToolStripMenuItem mi_sifarnikDjelatnosti;
        private System.Windows.Forms.ToolStripMenuItem mi_sifarnikZemalja;
        private System.Windows.Forms.ToolStripMenuItem mi_sifarnikObveze;
        private System.Windows.Forms.ToolStripMenuItem mi_sifarnikVlasnistva;
        private System.Windows.Forms.ToolStripMenuItem ms_registarPoreznihObveznika;
        private System.Windows.Forms.ToolStripMenuItem mi_registarVIESNovo;
        private System.Windows.Forms.ToolStripMenuItem mi_unosNovogObveznikaNovo;
    }
}

