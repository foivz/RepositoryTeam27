namespace VIES_SUSTAV.VIESForms
{
    partial class frm_pregledZP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_nazivObveznika;
            System.Windows.Forms.Label lbl_adresaLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label lbl_podrucniUred;
            System.Windows.Forms.Label lbl_poreznaIspostava;
            this.txt_razdoblje = new System.Windows.Forms.TextBox();
            this.lbl_NaslovVIES = new System.Windows.Forms.Label();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.pnl_pripadajuciVIES = new System.Windows.Forms.Panel();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.txt_IDizvjesca = new System.Windows.Forms.TextBox();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.nazivObveznikaTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.nazivIspostaveTextBox = new System.Windows.Forms.TextBox();
            this.nazivPodrucnogUredaTextBox = new System.Windows.Forms.TextBox();
            this.LookUpObveznikbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_ObveznikLookUpTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter();
            lbl_nazivObveznika = new System.Windows.Forms.Label();
            lbl_adresaLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            lbl_podrucniUred = new System.Windows.Forms.Label();
            lbl_poreznaIspostava = new System.Windows.Forms.Label();
            this.pnl_pripadajuciVIES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpObveznikbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_razdoblje
            // 
            this.txt_razdoblje.BackColor = System.Drawing.Color.Orange;
            this.txt_razdoblje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_razdoblje.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razdoblje.ForeColor = System.Drawing.Color.Navy;
            this.txt_razdoblje.Location = new System.Drawing.Point(304, 222);
            this.txt_razdoblje.Name = "txt_razdoblje";
            this.txt_razdoblje.ReadOnly = true;
            this.txt_razdoblje.Size = new System.Drawing.Size(82, 13);
            this.txt_razdoblje.TabIndex = 57;
            this.txt_razdoblje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_NaslovVIES
            // 
            this.lbl_NaslovVIES.BackColor = System.Drawing.Color.Orange;
            this.lbl_NaslovVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NaslovVIES.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NaslovVIES.ForeColor = System.Drawing.Color.Navy;
            this.lbl_NaslovVIES.Location = new System.Drawing.Point(2, 199);
            this.lbl_NaslovVIES.Name = "lbl_NaslovVIES";
            this.lbl_NaslovVIES.Size = new System.Drawing.Size(590, 44);
            this.lbl_NaslovVIES.TabIndex = 56;
            this.lbl_NaslovVIES.Text = "ZBIRNA PRIJAVA\r\nza razdoblje                ";
            this.lbl_NaslovVIES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(0, 9);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(590, 24);
            this.lbl_poreznaUprava.TabIndex = 55;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_pripadajuciVIES
            // 
            this.pnl_pripadajuciVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_pripadajuciVIES.Controls.Add(this.btn_zatvori);
            this.pnl_pripadajuciVIES.Controls.Add(this.txt_IDizvjesca);
            this.pnl_pripadajuciVIES.Controls.Add(this.oIBTextBox);
            this.pnl_pripadajuciVIES.Controls.Add(this.nazivObveznikaTextBox);
            this.pnl_pripadajuciVIES.Controls.Add(this.adresaTextBox);
            this.pnl_pripadajuciVIES.Controls.Add(this.nazivIspostaveTextBox);
            this.pnl_pripadajuciVIES.Controls.Add(this.nazivPodrucnogUredaTextBox);
            this.pnl_pripadajuciVIES.Controls.Add(lbl_nazivObveznika);
            this.pnl_pripadajuciVIES.Controls.Add(lbl_adresaLabel);
            this.pnl_pripadajuciVIES.Controls.Add(oIBLabel);
            this.pnl_pripadajuciVIES.Controls.Add(lbl_podrucniUred);
            this.pnl_pripadajuciVIES.Controls.Add(lbl_poreznaIspostava);
            this.pnl_pripadajuciVIES.Location = new System.Drawing.Point(12, 42);
            this.pnl_pripadajuciVIES.Name = "pnl_pripadajuciVIES";
            this.pnl_pripadajuciVIES.Size = new System.Drawing.Size(580, 154);
            this.pnl_pripadajuciVIES.TabIndex = 54;
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.Location = new System.Drawing.Point(466, 40);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(100, 45);
            this.btn_zatvori.TabIndex = 82;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = true;
            this.btn_zatvori.Click += new System.EventHandler(this.btn_zatvori_Click);
            // 
            // txt_IDizvjesca
            // 
            this.txt_IDizvjesca.Location = new System.Drawing.Point(496, 12);
            this.txt_IDizvjesca.Name = "txt_IDizvjesca";
            this.txt_IDizvjesca.Size = new System.Drawing.Size(70, 22);
            this.txt_IDizvjesca.TabIndex = 81;
            this.txt_IDizvjesca.Visible = false;
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.oIBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource, "OIB", true));
            this.oIBTextBox.ForeColor = System.Drawing.Color.Navy;
            this.oIBTextBox.Location = new System.Drawing.Point(188, 74);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.ReadOnly = true;
            this.oIBTextBox.Size = new System.Drawing.Size(183, 15);
            this.oIBTextBox.TabIndex = 72;
            // 
            // nazivObveznikaTextBox
            // 
            this.nazivObveznikaTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nazivObveznikaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivObveznikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource, "NazivObveznika", true));
            this.nazivObveznikaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivObveznikaTextBox.Location = new System.Drawing.Point(188, 99);
            this.nazivObveznikaTextBox.Name = "nazivObveznikaTextBox";
            this.nazivObveznikaTextBox.ReadOnly = true;
            this.nazivObveznikaTextBox.Size = new System.Drawing.Size(283, 15);
            this.nazivObveznikaTextBox.TabIndex = 74;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.adresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource, "Adresa", true));
            this.adresaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.adresaTextBox.Location = new System.Drawing.Point(188, 129);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.ReadOnly = true;
            this.adresaTextBox.Size = new System.Drawing.Size(283, 15);
            this.adresaTextBox.TabIndex = 76;
            // 
            // nazivIspostaveTextBox
            // 
            this.nazivIspostaveTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nazivIspostaveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivIspostaveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource, "nazivIspostave", true));
            this.nazivIspostaveTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivIspostaveTextBox.Location = new System.Drawing.Point(188, 45);
            this.nazivIspostaveTextBox.Name = "nazivIspostaveTextBox";
            this.nazivIspostaveTextBox.ReadOnly = true;
            this.nazivIspostaveTextBox.Size = new System.Drawing.Size(183, 15);
            this.nazivIspostaveTextBox.TabIndex = 78;
            // 
            // nazivPodrucnogUredaTextBox
            // 
            this.nazivPodrucnogUredaTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nazivPodrucnogUredaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivPodrucnogUredaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource, "nazivPodrucnogUreda", true));
            this.nazivPodrucnogUredaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivPodrucnogUredaTextBox.Location = new System.Drawing.Point(188, 16);
            this.nazivPodrucnogUredaTextBox.Name = "nazivPodrucnogUredaTextBox";
            this.nazivPodrucnogUredaTextBox.ReadOnly = true;
            this.nazivPodrucnogUredaTextBox.Size = new System.Drawing.Size(183, 15);
            this.nazivPodrucnogUredaTextBox.TabIndex = 80;
            // 
            // lbl_nazivObveznika
            // 
            lbl_nazivObveznika.AutoSize = true;
            lbl_nazivObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_nazivObveznika.ForeColor = System.Drawing.Color.Navy;
            lbl_nazivObveznika.Location = new System.Drawing.Point(40, 100);
            lbl_nazivObveznika.Name = "lbl_nazivObveznika";
            lbl_nazivObveznika.Size = new System.Drawing.Size(107, 14);
            lbl_nazivObveznika.TabIndex = 70;
            lbl_nazivObveznika.Text = "Naziv obveznika:";
            // 
            // lbl_adresaLabel
            // 
            lbl_adresaLabel.AutoSize = true;
            lbl_adresaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_adresaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_adresaLabel.Location = new System.Drawing.Point(40, 130);
            lbl_adresaLabel.Name = "lbl_adresaLabel";
            lbl_adresaLabel.Size = new System.Drawing.Size(53, 14);
            lbl_adresaLabel.TabIndex = 71;
            lbl_adresaLabel.Text = "Adresa:";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oIBLabel.ForeColor = System.Drawing.Color.Navy;
            oIBLabel.Location = new System.Drawing.Point(40, 75);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(33, 14);
            oIBLabel.TabIndex = 67;
            oIBLabel.Text = "OIB:";
            // 
            // lbl_podrucniUred
            // 
            lbl_podrucniUred.AutoSize = true;
            lbl_podrucniUred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_podrucniUred.ForeColor = System.Drawing.Color.Navy;
            lbl_podrucniUred.Location = new System.Drawing.Point(40, 12);
            lbl_podrucniUred.Name = "lbl_podrucniUred";
            lbl_podrucniUred.Size = new System.Drawing.Size(117, 14);
            lbl_podrucniUred.TabIndex = 68;
            lbl_podrucniUred.Text = "Područni Ured PU:";
            // 
            // lbl_poreznaIspostava
            // 
            lbl_poreznaIspostava.AutoSize = true;
            lbl_poreznaIspostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_poreznaIspostava.ForeColor = System.Drawing.Color.Navy;
            lbl_poreznaIspostava.Location = new System.Drawing.Point(40, 46);
            lbl_poreznaIspostava.Name = "lbl_poreznaIspostava";
            lbl_poreznaIspostava.Size = new System.Drawing.Size(124, 14);
            lbl_poreznaIspostava.TabIndex = 69;
            lbl_poreznaIspostava.Text = "Porezna Ispostava:";
            // 
            // LookUpObveznikbindingSource
            // 
            this.LookUpObveznikbindingSource.DataMember = "tbl_ObveznikLookUp";
            this.LookUpObveznikbindingSource.DataSource = this.ds_T27;
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ObveznikLookUpTableAdapter
            // 
            this.tbl_ObveznikLookUpTableAdapter.ClearBeforeFill = true;
            // 
            // frm_pregledZP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(602, 536);
            this.Controls.Add(this.txt_razdoblje);
            this.Controls.Add(this.lbl_NaslovVIES);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(this.pnl_pripadajuciVIES);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_pregledZP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled Zbirne prijave";
            this.Load += new System.EventHandler(this.frm_pregledZP_Load);
            this.pnl_pripadajuciVIES.ResumeLayout(false);
            this.pnl_pripadajuciVIES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpObveznikbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_razdoblje;
        private System.Windows.Forms.Label lbl_NaslovVIES;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.Panel pnl_pripadajuciVIES;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.TextBox txt_IDizvjesca;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.TextBox nazivObveznikaTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox nazivIspostaveTextBox;
        private System.Windows.Forms.TextBox nazivPodrucnogUredaTextBox;
        private System.Windows.Forms.BindingSource LookUpObveznikbindingSource;
        private ds_T27 ds_T27;
        private ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter tbl_ObveznikLookUpTableAdapter;
    }
}