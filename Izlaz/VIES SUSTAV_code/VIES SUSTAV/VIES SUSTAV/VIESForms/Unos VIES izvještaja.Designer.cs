namespace VIES_SUSTAV.VIESForms
{
    partial class frm_UnosVIES
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
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label razdoblje_izvještavanjaLabel;
            System.Windows.Forms.Label vrijednost_stjecanjaLabel;
            System.Windows.Forms.Label vrijednost_isporukaLabel;
            System.Windows.Forms.Label datum_unosaLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label lbl_podrucniUred;
            System.Windows.Forms.Label lbl_poreznaIspostava;
            System.Windows.Forms.Label lbl_nazivObveznika;
            System.Windows.Forms.Label lbl_adresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UnosVIES));
            this.lbl_NaslovVIES = new System.Windows.Forms.Label();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_VIESizvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VIESizvjestajTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_VIESizvjestajTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.txt_datumUnosa = new System.Windows.Forms.DateTimePicker();
            this.ObveznikLookUpbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ObveznikLookUpTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter();
            this.txt_podrucni = new System.Windows.Forms.TextBox();
            this.txt_ispostava = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_spremanjeOIB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_OIB = new System.Windows.Forms.TextBox();
            this.panelVIESizvjestaj = new System.Windows.Forms.Panel();
            this.txt_isporuke = new System.Windows.Forms.TextBox();
            this.txt_stjecanje = new System.Windows.Forms.TextBox();
            this.txt_RazdobljedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_spremi = new System.Windows.Forms.Button();
            oIBLabel = new System.Windows.Forms.Label();
            razdoblje_izvještavanjaLabel = new System.Windows.Forms.Label();
            vrijednost_stjecanjaLabel = new System.Windows.Forms.Label();
            vrijednost_isporukaLabel = new System.Windows.Forms.Label();
            datum_unosaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            lbl_podrucniUred = new System.Windows.Forms.Label();
            lbl_poreznaIspostava = new System.Windows.Forms.Label();
            lbl_nazivObveznika = new System.Windows.Forms.Label();
            lbl_adresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObveznikLookUpbindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelVIESizvjestaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(9, 12);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(33, 14);
            oIBLabel.TabIndex = 47;
            oIBLabel.Text = "OIB:";
            // 
            // razdoblje_izvještavanjaLabel
            // 
            razdoblje_izvještavanjaLabel.AutoSize = true;
            razdoblje_izvještavanjaLabel.Location = new System.Drawing.Point(19, 25);
            razdoblje_izvještavanjaLabel.Name = "razdoblje_izvještavanjaLabel";
            razdoblje_izvještavanjaLabel.Size = new System.Drawing.Size(154, 14);
            razdoblje_izvještavanjaLabel.TabIndex = 49;
            razdoblje_izvještavanjaLabel.Text = "Razdoblje izvještavanja:";
            // 
            // vrijednost_stjecanjaLabel
            // 
            vrijednost_stjecanjaLabel.AutoSize = true;
            vrijednost_stjecanjaLabel.Location = new System.Drawing.Point(19, 82);
            vrijednost_stjecanjaLabel.Name = "vrijednost_stjecanjaLabel";
            vrijednost_stjecanjaLabel.Size = new System.Drawing.Size(133, 14);
            vrijednost_stjecanjaLabel.TabIndex = 51;
            vrijednost_stjecanjaLabel.Text = "Vrijednost stjecanja:";
            // 
            // vrijednost_isporukaLabel
            // 
            vrijednost_isporukaLabel.AutoSize = true;
            vrijednost_isporukaLabel.Location = new System.Drawing.Point(19, 127);
            vrijednost_isporukaLabel.Name = "vrijednost_isporukaLabel";
            vrijednost_isporukaLabel.Size = new System.Drawing.Size(130, 14);
            vrijednost_isporukaLabel.TabIndex = 53;
            vrijednost_isporukaLabel.Text = "Vrijednost isporuka:";
            // 
            // datum_unosaLabel
            // 
            datum_unosaLabel.AutoSize = true;
            datum_unosaLabel.Location = new System.Drawing.Point(341, 186);
            datum_unosaLabel.Name = "datum_unosaLabel";
            datum_unosaLabel.Size = new System.Drawing.Size(93, 14);
            datum_unosaLabel.TabIndex = 55;
            datum_unosaLabel.Text = "Datum unosa:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(35, 525);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 14);
            statusLabel.TabIndex = 57;
            statusLabel.Text = "Status:";
            // 
            // lbl_podrucniUred
            // 
            lbl_podrucniUred.AutoSize = true;
            lbl_podrucniUred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_podrucniUred.ForeColor = System.Drawing.Color.Navy;
            lbl_podrucniUred.Location = new System.Drawing.Point(25, 47);
            lbl_podrucniUred.Name = "lbl_podrucniUred";
            lbl_podrucniUred.Size = new System.Drawing.Size(117, 14);
            lbl_podrucniUred.TabIndex = 61;
            lbl_podrucniUred.Text = "Područni Ured PU:";
            // 
            // lbl_poreznaIspostava
            // 
            lbl_poreznaIspostava.AutoSize = true;
            lbl_poreznaIspostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_poreznaIspostava.ForeColor = System.Drawing.Color.Navy;
            lbl_poreznaIspostava.Location = new System.Drawing.Point(25, 72);
            lbl_poreznaIspostava.Name = "lbl_poreznaIspostava";
            lbl_poreznaIspostava.Size = new System.Drawing.Size(124, 14);
            lbl_poreznaIspostava.TabIndex = 62;
            lbl_poreznaIspostava.Text = "Porezna Ispostava:";
            // 
            // lbl_nazivObveznika
            // 
            lbl_nazivObveznika.AutoSize = true;
            lbl_nazivObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_nazivObveznika.ForeColor = System.Drawing.Color.Navy;
            lbl_nazivObveznika.Location = new System.Drawing.Point(9, 37);
            lbl_nazivObveznika.Name = "lbl_nazivObveznika";
            lbl_nazivObveznika.Size = new System.Drawing.Size(107, 14);
            lbl_nazivObveznika.TabIndex = 65;
            lbl_nazivObveznika.Text = "Naziv obveznika:";
            // 
            // lbl_adresaLabel
            // 
            lbl_adresaLabel.AutoSize = true;
            lbl_adresaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_adresaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_adresaLabel.Location = new System.Drawing.Point(9, 67);
            lbl_adresaLabel.Name = "lbl_adresaLabel";
            lbl_adresaLabel.Size = new System.Drawing.Size(53, 14);
            lbl_adresaLabel.TabIndex = 66;
            lbl_adresaLabel.Text = "Adresa:";
            // 
            // lbl_NaslovVIES
            // 
            this.lbl_NaslovVIES.BackColor = System.Drawing.Color.Orange;
            this.lbl_NaslovVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NaslovVIES.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NaslovVIES.ForeColor = System.Drawing.Color.Navy;
            this.lbl_NaslovVIES.Location = new System.Drawing.Point(0, 208);
            this.lbl_NaslovVIES.Name = "lbl_NaslovVIES";
            this.lbl_NaslovVIES.Size = new System.Drawing.Size(592, 44);
            this.lbl_NaslovVIES.TabIndex = 44;
            this.lbl_NaslovVIES.Text = "MJESEČNI IZVJEŠTAJ\r\nVIES - POREZ NA DODANU VRIJEDNOST";
            this.lbl_NaslovVIES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(1, 9);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(592, 24);
            this.lbl_poreznaUprava.TabIndex = 43;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_VIESizvjestajBindingSource
            // 
            this.tbl_VIESizvjestajBindingSource.DataMember = "tbl_VIESizvjestaj";
            this.tbl_VIESizvjestajBindingSource.DataSource = this.ds_T27;
            // 
            // tbl_VIESizvjestajTableAdapter
            // 
            this.tbl_VIESizvjestajTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_PdvSTableAdapter = null;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikAktivnostiTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikDjelatnostiTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikIspostavaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikObvezeTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikPodrucnihUredaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikVlasnistvaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikZemljaTableAdapter = null;
            this.tableAdapterManager.tbl_VIESizvjestajTableAdapter = this.tbl_VIESizvjestajTableAdapter;
            this.tableAdapterManager.tbl_ZPTableAdapter = null;
            this.tableAdapterManager.tbt_sifarnikStatusaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VIESizvjestajBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(491, 78);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(73, 22);
            this.oIBTextBox.TabIndex = 48;
            this.oIBTextBox.Visible = false;
            // 
            // txt_datumUnosa
            // 
            this.txt_datumUnosa.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_VIESizvjestajBindingSource, "Datum unosa", true));
            this.txt_datumUnosa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_datumUnosa.Location = new System.Drawing.Point(454, 182);
            this.txt_datumUnosa.Name = "txt_datumUnosa";
            this.txt_datumUnosa.Size = new System.Drawing.Size(104, 22);
            this.txt_datumUnosa.TabIndex = 56;
            // 
            // ObveznikLookUpbindingSource1
            // 
            this.ObveznikLookUpbindingSource1.DataMember = "tbl_ObveznikLookUp";
            this.ObveznikLookUpbindingSource1.DataSource = this.ds_T27;
            // 
            // tbl_ObveznikLookUpTableAdapter
            // 
            this.tbl_ObveznikLookUpTableAdapter.ClearBeforeFill = true;
            // 
            // txt_podrucni
            // 
            this.txt_podrucni.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_podrucni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_podrucni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObveznikLookUpbindingSource1, "nazivPodrucnogUreda", true));
            this.txt_podrucni.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_podrucni.ForeColor = System.Drawing.Color.Navy;
            this.txt_podrucni.Location = new System.Drawing.Point(195, 46);
            this.txt_podrucni.Name = "txt_podrucni";
            this.txt_podrucni.ReadOnly = true;
            this.txt_podrucni.Size = new System.Drawing.Size(200, 17);
            this.txt_podrucni.TabIndex = 60;
            // 
            // txt_ispostava
            // 
            this.txt_ispostava.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_ispostava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ispostava.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObveznikLookUpbindingSource1, "nazivIspostave", true));
            this.txt_ispostava.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ispostava.ForeColor = System.Drawing.Color.Navy;
            this.txt_ispostava.Location = new System.Drawing.Point(195, 72);
            this.txt_ispostava.Name = "txt_ispostava";
            this.txt_ispostava.ReadOnly = true;
            this.txt_ispostava.Size = new System.Drawing.Size(200, 17);
            this.txt_ispostava.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_spremanjeOIB);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_adresa);
            this.panel1.Controls.Add(this.txt_naziv);
            this.panel1.Controls.Add(lbl_nazivObveznika);
            this.panel1.Controls.Add(lbl_adresaLabel);
            this.panel1.Controls.Add(this.txt_OIB);
            this.panel1.Controls.Add(oIBLabel);
            this.panel1.Controls.Add(this.oIBTextBox);
            this.panel1.Location = new System.Drawing.Point(14, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 102);
            this.panel1.TabIndex = 64;
            // 
            // txt_spremanjeOIB
            // 
            this.txt_spremanjeOIB.Location = new System.Drawing.Point(275, 6);
            this.txt_spremanjeOIB.Name = "txt_spremanjeOIB";
            this.txt_spremanjeOIB.Size = new System.Drawing.Size(122, 22);
            this.txt_spremanjeOIB.TabIndex = 70;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ObveznikLookUpbindingSource1;
            this.comboBox1.DisplayMember = "OIB";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(409, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 22);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.ValueMember = "OIB";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_adresa
            // 
            this.txt_adresa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_adresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObveznikLookUpbindingSource1, "Adresa", true));
            this.txt_adresa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresa.ForeColor = System.Drawing.Color.Navy;
            this.txt_adresa.Location = new System.Drawing.Point(179, 67);
            this.txt_adresa.Multiline = true;
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.ReadOnly = true;
            this.txt_adresa.Size = new System.Drawing.Size(306, 20);
            this.txt_adresa.TabIndex = 68;
            // 
            // txt_naziv
            // 
            this.txt_naziv.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_naziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_naziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObveznikLookUpbindingSource1, "NazivObveznika", true));
            this.txt_naziv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_naziv.ForeColor = System.Drawing.Color.Navy;
            this.txt_naziv.Location = new System.Drawing.Point(179, 34);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.ReadOnly = true;
            this.txt_naziv.Size = new System.Drawing.Size(200, 17);
            this.txt_naziv.TabIndex = 67;
            // 
            // txt_OIB
            // 
            this.txt_OIB.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_OIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObveznikLookUpbindingSource1, "OIB", true));
            this.txt_OIB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OIB.ForeColor = System.Drawing.Color.Navy;
            this.txt_OIB.Location = new System.Drawing.Point(179, 12);
            this.txt_OIB.Name = "txt_OIB";
            this.txt_OIB.ReadOnly = true;
            this.txt_OIB.Size = new System.Drawing.Size(200, 17);
            this.txt_OIB.TabIndex = 64;
            // 
            // panelVIESizvjestaj
            // 
            this.panelVIESizvjestaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVIESizvjestaj.Controls.Add(this.txt_isporuke);
            this.panelVIESizvjestaj.Controls.Add(this.txt_stjecanje);
            this.panelVIESizvjestaj.Controls.Add(this.txt_RazdobljedateTimePicker);
            this.panelVIESizvjestaj.Controls.Add(razdoblje_izvještavanjaLabel);
            this.panelVIESizvjestaj.Controls.Add(vrijednost_stjecanjaLabel);
            this.panelVIESizvjestaj.Controls.Add(vrijednost_isporukaLabel);
            this.panelVIESizvjestaj.Controls.Add(datum_unosaLabel);
            this.panelVIESizvjestaj.Controls.Add(this.txt_datumUnosa);
            this.panelVIESizvjestaj.Location = new System.Drawing.Point(14, 269);
            this.panelVIESizvjestaj.Name = "panelVIESizvjestaj";
            this.panelVIESizvjestaj.Size = new System.Drawing.Size(565, 211);
            this.panelVIESizvjestaj.TabIndex = 65;
            // 
            // txt_isporuke
            // 
            this.txt_isporuke.ForeColor = System.Drawing.Color.Navy;
            this.txt_isporuke.Location = new System.Drawing.Point(179, 119);
            this.txt_isporuke.Name = "txt_isporuke";
            this.txt_isporuke.Size = new System.Drawing.Size(200, 22);
            this.txt_isporuke.TabIndex = 59;
            this.txt_isporuke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_isporuke.Validating += new System.ComponentModel.CancelEventHandler(this.txt_isporuke_Validating);
            // 
            // txt_stjecanje
            // 
            this.txt_stjecanje.ForeColor = System.Drawing.Color.Navy;
            this.txt_stjecanje.Location = new System.Drawing.Point(179, 79);
            this.txt_stjecanje.Name = "txt_stjecanje";
            this.txt_stjecanje.Size = new System.Drawing.Size(200, 22);
            this.txt_stjecanje.TabIndex = 58;
            this.txt_stjecanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_stjecanje.Validating += new System.ComponentModel.CancelEventHandler(this.txt_stjecanje_Validating);
            // 
            // txt_RazdobljedateTimePicker
            // 
            this.txt_RazdobljedateTimePicker.CustomFormat = "MM-yyyy";
            this.txt_RazdobljedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_RazdobljedateTimePicker.Location = new System.Drawing.Point(196, 21);
            this.txt_RazdobljedateTimePicker.Name = "txt_RazdobljedateTimePicker";
            this.txt_RazdobljedateTimePicker.ShowUpDown = true;
            this.txt_RazdobljedateTimePicker.Size = new System.Drawing.Size(134, 22);
            this.txt_RazdobljedateTimePicker.TabIndex = 57;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(93, 517);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(96, 22);
            this.txt_status.TabIndex = 66;
            // 
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(411, 486);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(100, 45);
            this.btn_spremi.TabIndex = 67;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = true;
            this.btn_spremi.Click += new System.EventHandler(this.btn_spremi_Click);
            // 
            // frm_UnosVIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(648, 616);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.panelVIESizvjestaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ispostava);
            this.Controls.Add(lbl_podrucniUred);
            this.Controls.Add(lbl_poreznaIspostava);
            this.Controls.Add(this.txt_podrucni);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.lbl_NaslovVIES);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_UnosVIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VIES Izvještaj - unos";
            this.Load += new System.EventHandler(this.frm_UnosVIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObveznikLookUpbindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelVIESizvjestaj.ResumeLayout(false);
            this.panelVIESizvjestaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NaslovVIES;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private ds_T27 ds_T27;
        private System.Windows.Forms.BindingSource tbl_VIESizvjestajBindingSource;
        private ds_T27TableAdapters.tbl_VIESizvjestajTableAdapter tbl_VIESizvjestajTableAdapter;
        private ds_T27TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.DateTimePicker txt_datumUnosa;
        private System.Windows.Forms.BindingSource ObveznikLookUpbindingSource1;
        private ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter tbl_ObveznikLookUpTableAdapter;
        private System.Windows.Forms.TextBox txt_podrucni;
        private System.Windows.Forms.TextBox txt_ispostava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_OIB;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_spremanjeOIB;
        private System.Windows.Forms.Panel panelVIESizvjestaj;
        private System.Windows.Forms.DateTimePicker txt_RazdobljedateTimePicker;
        private System.Windows.Forms.TextBox txt_stjecanje;
        private System.Windows.Forms.TextBox txt_isporuke;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_spremi;
    }
}