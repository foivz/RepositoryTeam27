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
            System.Windows.Forms.Label iD_VIES_IzvješćaLabel;
            System.Windows.Forms.Label lbl_stariID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UnosVIES));
            this.lbl_NaslovVIES = new System.Windows.Forms.Label();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_VIESizvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VIESizvjestajTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_VIESizvjestajTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
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
            this.pnl_VIESizvjestaj = new System.Windows.Forms.Panel();
            this.txt_lookUpStatus = new System.Windows.Forms.TextBox();
            this.tbtsifarnikStatusaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.pnl_stjecanja = new System.Windows.Forms.Panel();
            this.pbox_PdvsProvjeri = new System.Windows.Forms.PictureBox();
            this.pbox_PdvsEdit = new System.Windows.Forms.PictureBox();
            this.pbox_PdvsOK = new System.Windows.Forms.PictureBox();
            this.pbox_addPdvS = new System.Windows.Forms.PictureBox();
            this.txt_stjecanje = new System.Windows.Forms.TextBox();
            this.lbl_PdvS = new System.Windows.Forms.Label();
            this.pnl_isporuke = new System.Windows.Forms.Panel();
            this.pbox_zpProvjeri = new System.Windows.Forms.PictureBox();
            this.pbox_zpEdit = new System.Windows.Forms.PictureBox();
            this.pbox_zpOK = new System.Windows.Forms.PictureBox();
            this.pbox_addZP = new System.Windows.Forms.PictureBox();
            this.txt_isporuke = new System.Windows.Forms.TextBox();
            this.lbl_zbirna = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_RazdobljedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.tbt_sifarnikStatusaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbt_sifarnikStatusaTableAdapter();
            this.pbox_dodatiAnalitiku = new System.Windows.Forms.PictureBox();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.ds_ViesUnos = new VIES_SUSTAV.ds_ViesUnos();
            this.tbl_VIESizvjestajBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VIESizvjestajTableAdapter1 = new VIES_SUSTAV.ds_ViesUnosTableAdapters.tbl_VIESizvjestajTableAdapter();
            this.tableAdapterManager1 = new VIES_SUSTAV.ds_ViesUnosTableAdapters.TableAdapterManager();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.getIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIDTableAdapter = new VIES_SUSTAV.ds_ViesUnosTableAdapters.GetIDTableAdapter();
            this.ctxt_zadnjiID = new System.Windows.Forms.TextBox();
            this.pbx_pdvsDodan = new System.Windows.Forms.PictureBox();
            this.lbl_pdvsDodan = new System.Windows.Forms.Label();
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
            iD_VIES_IzvješćaLabel = new System.Windows.Forms.Label();
            lbl_stariID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObveznikLookUpbindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_VIESizvjestaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtsifarnikStatusaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            this.pnl_stjecanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsProvjeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_addPdvS)).BeginInit();
            this.pnl_isporuke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpProvjeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_addZP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_dodatiAnalitiku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ViesUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pdvsDodan)).BeginInit();
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
            vrijednost_stjecanjaLabel.Location = new System.Drawing.Point(20, 25);
            vrijednost_stjecanjaLabel.Name = "vrijednost_stjecanjaLabel";
            vrijednost_stjecanjaLabel.Size = new System.Drawing.Size(133, 14);
            vrijednost_stjecanjaLabel.TabIndex = 51;
            vrijednost_stjecanjaLabel.Text = "Vrijednost stjecanja:";
            // 
            // vrijednost_isporukaLabel
            // 
            vrijednost_isporukaLabel.AutoSize = true;
            vrijednost_isporukaLabel.Location = new System.Drawing.Point(20, 27);
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
            statusLabel.Location = new System.Drawing.Point(20, 186);
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
            // iD_VIES_IzvješćaLabel
            // 
            iD_VIES_IzvješćaLabel.AutoSize = true;
            iD_VIES_IzvješćaLabel.Location = new System.Drawing.Point(11, 582);
            iD_VIES_IzvješćaLabel.Name = "iD_VIES_IzvješćaLabel";
            iD_VIES_IzvješćaLabel.Size = new System.Drawing.Size(179, 14);
            iD_VIES_IzvješćaLabel.TabIndex = 71;
            iD_VIES_IzvješćaLabel.Text = "Evidencijski broj zaprimanja:";
            // 
            // lbl_stariID
            // 
            lbl_stariID.AutoSize = true;
            lbl_stariID.Location = new System.Drawing.Point(431, 579);
            lbl_stariID.Name = "lbl_stariID";
            lbl_stariID.Size = new System.Drawing.Size(82, 14);
            lbl_stariID.TabIndex = 72;
            lbl_stariID.Text = "PrethodniID";
            // 
            // lbl_NaslovVIES
            // 
            this.lbl_NaslovVIES.BackColor = System.Drawing.Color.Orange;
            this.lbl_NaslovVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NaslovVIES.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NaslovVIES.ForeColor = System.Drawing.Color.Navy;
            this.lbl_NaslovVIES.Location = new System.Drawing.Point(0, 208);
            this.lbl_NaslovVIES.Name = "lbl_NaslovVIES";
            this.lbl_NaslovVIES.Size = new System.Drawing.Size(604, 44);
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
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(603, 24);
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
            // pnl_VIESizvjestaj
            // 
            this.pnl_VIESizvjestaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_lookUpStatus);
            this.pnl_VIESizvjestaj.Controls.Add(this.pnl_stjecanja);
            this.pnl_VIESizvjestaj.Controls.Add(this.pnl_isporuke);
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_status);
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_RazdobljedateTimePicker);
            this.pnl_VIESizvjestaj.Controls.Add(razdoblje_izvještavanjaLabel);
            this.pnl_VIESizvjestaj.Controls.Add(datum_unosaLabel);
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_datumUnosa);
            this.pnl_VIESizvjestaj.Controls.Add(statusLabel);
            this.pnl_VIESizvjestaj.Location = new System.Drawing.Point(14, 269);
            this.pnl_VIESizvjestaj.Name = "pnl_VIESizvjestaj";
            this.pnl_VIESizvjestaj.Size = new System.Drawing.Size(565, 211);
            this.pnl_VIESizvjestaj.TabIndex = 65;
            // 
            // txt_lookUpStatus
            // 
            this.txt_lookUpStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_lookUpStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lookUpStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbtsifarnikStatusaBindingSource, "Opis Statusa", true));
            this.txt_lookUpStatus.ForeColor = System.Drawing.Color.Red;
            this.txt_lookUpStatus.Location = new System.Drawing.Point(78, 183);
            this.txt_lookUpStatus.Name = "txt_lookUpStatus";
            this.txt_lookUpStatus.Size = new System.Drawing.Size(126, 15);
            this.txt_lookUpStatus.TabIndex = 68;
            this.txt_lookUpStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbtsifarnikStatusaBindingSource
            // 
            this.tbtsifarnikStatusaBindingSource.DataMember = "tbt_sifarnikStatusa";
            this.tbtsifarnikStatusaBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ds_sifarnici_lookUp
            // 
            this.ds_sifarnici_lookUp.DataSetName = "ds_sifarnici_lookUp";
            this.ds_sifarnici_lookUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_stjecanja
            // 
            this.pnl_stjecanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_stjecanja.Controls.Add(this.pbox_PdvsProvjeri);
            this.pnl_stjecanja.Controls.Add(this.pbox_PdvsEdit);
            this.pnl_stjecanja.Controls.Add(this.pbox_PdvsOK);
            this.pnl_stjecanja.Controls.Add(this.pbox_addPdvS);
            this.pnl_stjecanja.Controls.Add(this.txt_stjecanje);
            this.pnl_stjecanja.Controls.Add(vrijednost_stjecanjaLabel);
            this.pnl_stjecanja.Controls.Add(this.lbl_PdvS);
            this.pnl_stjecanja.Location = new System.Drawing.Point(-1, 61);
            this.pnl_stjecanja.Name = "pnl_stjecanja";
            this.pnl_stjecanja.Size = new System.Drawing.Size(565, 55);
            this.pnl_stjecanja.TabIndex = 63;
            // 
            // pbox_PdvsProvjeri
            // 
            this.pbox_PdvsProvjeri.Image = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsProvjeri.Image")));
            this.pbox_PdvsProvjeri.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsProvjeri.InitialImage")));
            this.pbox_PdvsProvjeri.Location = new System.Drawing.Point(524, 20);
            this.pbox_PdvsProvjeri.Name = "pbox_PdvsProvjeri";
            this.pbox_PdvsProvjeri.Size = new System.Drawing.Size(24, 24);
            this.pbox_PdvsProvjeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_PdvsProvjeri.TabIndex = 64;
            this.pbox_PdvsProvjeri.TabStop = false;
            this.pbox_PdvsProvjeri.Visible = false;
            this.pbox_PdvsProvjeri.Click += new System.EventHandler(this.pbox_PdvsProvjeri_Click);
            // 
            // pbox_PdvsEdit
            // 
            this.pbox_PdvsEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsEdit.Image")));
            this.pbox_PdvsEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsEdit.InitialImage")));
            this.pbox_PdvsEdit.Location = new System.Drawing.Point(491, 21);
            this.pbox_PdvsEdit.Name = "pbox_PdvsEdit";
            this.pbox_PdvsEdit.Size = new System.Drawing.Size(24, 24);
            this.pbox_PdvsEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_PdvsEdit.TabIndex = 63;
            this.pbox_PdvsEdit.TabStop = false;
            this.pbox_PdvsEdit.Visible = false;
            this.pbox_PdvsEdit.Click += new System.EventHandler(this.pbox_PdvsEdit_Click);
            // 
            // pbox_PdvsOK
            // 
            this.pbox_PdvsOK.Image = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsOK.Image")));
            this.pbox_PdvsOK.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsOK.InitialImage")));
            this.pbox_PdvsOK.Location = new System.Drawing.Point(454, 21);
            this.pbox_PdvsOK.Name = "pbox_PdvsOK";
            this.pbox_PdvsOK.Size = new System.Drawing.Size(24, 24);
            this.pbox_PdvsOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_PdvsOK.TabIndex = 62;
            this.pbox_PdvsOK.TabStop = false;
            this.pbox_PdvsOK.Visible = false;
            // 
            // pbox_addPdvS
            // 
            this.pbox_addPdvS.Image = global::VIES_SUSTAV.Properties.Resources.add2;
            this.pbox_addPdvS.Location = new System.Drawing.Point(418, 20);
            this.pbox_addPdvS.Name = "pbox_addPdvS";
            this.pbox_addPdvS.Size = new System.Drawing.Size(24, 24);
            this.pbox_addPdvS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_addPdvS.TabIndex = 61;
            this.pbox_addPdvS.TabStop = false;
            this.pbox_addPdvS.Click += new System.EventHandler(this.pbox_addPdvS_Click);
            // 
            // txt_stjecanje
            // 
            this.txt_stjecanje.ForeColor = System.Drawing.Color.Navy;
            this.txt_stjecanje.Location = new System.Drawing.Point(180, 22);
            this.txt_stjecanje.Name = "txt_stjecanje";
            this.txt_stjecanje.Size = new System.Drawing.Size(200, 22);
            this.txt_stjecanje.TabIndex = 58;
            this.txt_stjecanje.Text = "0";
            this.txt_stjecanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_stjecanje.Validating += new System.ComponentModel.CancelEventHandler(this.txt_stjecanje_Validating);
            // 
            // lbl_PdvS
            // 
            this.lbl_PdvS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PdvS.Location = new System.Drawing.Point(415, 6);
            this.lbl_PdvS.Name = "lbl_PdvS";
            this.lbl_PdvS.Size = new System.Drawing.Size(93, 19);
            this.lbl_PdvS.TabIndex = 60;
            this.lbl_PdvS.Text = "PDV-S Obrazac";
            // 
            // pnl_isporuke
            // 
            this.pnl_isporuke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_isporuke.Controls.Add(this.pbox_zpProvjeri);
            this.pnl_isporuke.Controls.Add(this.pbox_zpEdit);
            this.pnl_isporuke.Controls.Add(this.pbox_zpOK);
            this.pnl_isporuke.Controls.Add(this.pbox_addZP);
            this.pnl_isporuke.Controls.Add(this.txt_isporuke);
            this.pnl_isporuke.Controls.Add(this.lbl_zbirna);
            this.pnl_isporuke.Controls.Add(vrijednost_isporukaLabel);
            this.pnl_isporuke.Location = new System.Drawing.Point(-1, 115);
            this.pnl_isporuke.Name = "pnl_isporuke";
            this.pnl_isporuke.Size = new System.Drawing.Size(565, 55);
            this.pnl_isporuke.TabIndex = 62;
            // 
            // pbox_zpProvjeri
            // 
            this.pbox_zpProvjeri.Image = ((System.Drawing.Image)(resources.GetObject("pbox_zpProvjeri.Image")));
            this.pbox_zpProvjeri.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_zpProvjeri.InitialImage")));
            this.pbox_zpProvjeri.Location = new System.Drawing.Point(524, 19);
            this.pbox_zpProvjeri.Name = "pbox_zpProvjeri";
            this.pbox_zpProvjeri.Size = new System.Drawing.Size(24, 24);
            this.pbox_zpProvjeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_zpProvjeri.TabIndex = 72;
            this.pbox_zpProvjeri.TabStop = false;
            this.pbox_zpProvjeri.Visible = false;
            // 
            // pbox_zpEdit
            // 
            this.pbox_zpEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbox_zpEdit.Image")));
            this.pbox_zpEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_zpEdit.InitialImage")));
            this.pbox_zpEdit.Location = new System.Drawing.Point(491, 19);
            this.pbox_zpEdit.Name = "pbox_zpEdit";
            this.pbox_zpEdit.Size = new System.Drawing.Size(24, 24);
            this.pbox_zpEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_zpEdit.TabIndex = 71;
            this.pbox_zpEdit.TabStop = false;
            this.pbox_zpEdit.Visible = false;
            // 
            // pbox_zpOK
            // 
            this.pbox_zpOK.Image = ((System.Drawing.Image)(resources.GetObject("pbox_zpOK.Image")));
            this.pbox_zpOK.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_zpOK.InitialImage")));
            this.pbox_zpOK.Location = new System.Drawing.Point(454, 19);
            this.pbox_zpOK.Name = "pbox_zpOK";
            this.pbox_zpOK.Size = new System.Drawing.Size(24, 24);
            this.pbox_zpOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_zpOK.TabIndex = 70;
            this.pbox_zpOK.TabStop = false;
            this.pbox_zpOK.Visible = false;
            // 
            // pbox_addZP
            // 
            this.pbox_addZP.Image = global::VIES_SUSTAV.Properties.Resources.add2;
            this.pbox_addZP.Location = new System.Drawing.Point(418, 19);
            this.pbox_addZP.Name = "pbox_addZP";
            this.pbox_addZP.Size = new System.Drawing.Size(24, 24);
            this.pbox_addZP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_addZP.TabIndex = 69;
            this.pbox_addZP.TabStop = false;
            // 
            // txt_isporuke
            // 
            this.txt_isporuke.ForeColor = System.Drawing.Color.Navy;
            this.txt_isporuke.Location = new System.Drawing.Point(180, 19);
            this.txt_isporuke.Name = "txt_isporuke";
            this.txt_isporuke.Size = new System.Drawing.Size(200, 22);
            this.txt_isporuke.TabIndex = 59;
            this.txt_isporuke.Text = "0";
            this.txt_isporuke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_isporuke.Validating += new System.ComponentModel.CancelEventHandler(this.txt_isporuke_Validating);
            // 
            // lbl_zbirna
            // 
            this.lbl_zbirna.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zbirna.Location = new System.Drawing.Point(415, 4);
            this.lbl_zbirna.Name = "lbl_zbirna";
            this.lbl_zbirna.Size = new System.Drawing.Size(93, 19);
            this.lbl_zbirna.TabIndex = 61;
            this.lbl_zbirna.Text = "Zbirna prijava";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(210, 183);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(96, 22);
            this.txt_status.TabIndex = 66;
            this.txt_status.Visible = false;
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
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(479, 486);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(100, 45);
            this.btn_spremi.TabIndex = 67;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = true;
            this.btn_spremi.Click += new System.EventHandler(this.btn_spremi_Click);
            // 
            // tbt_sifarnikStatusaTableAdapter
            // 
            this.tbt_sifarnikStatusaTableAdapter.ClearBeforeFill = true;
            // 
            // pbox_dodatiAnalitiku
            // 
            this.pbox_dodatiAnalitiku.Image = global::VIES_SUSTAV.Properties.Resources.alert;
            this.pbox_dodatiAnalitiku.Location = new System.Drawing.Point(39, 500);
            this.pbox_dodatiAnalitiku.Name = "pbox_dodatiAnalitiku";
            this.pbox_dodatiAnalitiku.Size = new System.Drawing.Size(24, 24);
            this.pbox_dodatiAnalitiku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_dodatiAnalitiku.TabIndex = 70;
            this.pbox_dodatiAnalitiku.TabStop = false;
            // 
            // lbl_alert
            // 
            this.lbl_alert.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_alert.Location = new System.Drawing.Point(81, 500);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(350, 32);
            this.lbl_alert.TabIndex = 71;
            this.lbl_alert.Text = "Za unijete vrijednosti u stjecanja ili isporuke potrebno je spremiti izvještaj i " +
                "dodati pripadajuća analitička izvješća.";
            // 
            // ds_ViesUnos
            // 
            this.ds_ViesUnos.DataSetName = "ds_ViesUnos";
            this.ds_ViesUnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_VIESizvjestajBindingSource1
            // 
            this.tbl_VIESizvjestajBindingSource1.DataMember = "tbl_VIESizvjestaj";
            this.tbl_VIESizvjestajBindingSource1.DataSource = this.ds_ViesUnos;
            // 
            // tbl_VIESizvjestajTableAdapter1
            // 
            this.tbl_VIESizvjestajTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_VIESizvjestajTableAdapter = this.tbl_VIESizvjestajTableAdapter1;
            this.tableAdapterManager1.tbt_sifarnikStatusaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = VIES_SUSTAV.ds_ViesUnosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_ID
            // 
            this.txt_ID.ForeColor = System.Drawing.Color.Red;
            this.txt_ID.Location = new System.Drawing.Point(195, 579);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(69, 22);
            this.txt_ID.TabIndex = 72;
            this.txt_ID.Text = "0";
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getIDBindingSource
            // 
            this.getIDBindingSource.DataMember = "GetID";
            this.getIDBindingSource.DataSource = this.ds_ViesUnos;
            // 
            // getIDTableAdapter
            // 
            this.getIDTableAdapter.ClearBeforeFill = true;
            // 
            // ctxt_zadnjiID
            // 
            this.ctxt_zadnjiID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getIDBindingSource, "Column1", true));
            this.ctxt_zadnjiID.Location = new System.Drawing.Point(531, 571);
            this.ctxt_zadnjiID.Name = "ctxt_zadnjiID";
            this.ctxt_zadnjiID.Size = new System.Drawing.Size(43, 22);
            this.ctxt_zadnjiID.TabIndex = 73;
            // 
            // pbx_pdvsDodan
            // 
            this.pbx_pdvsDodan.Image = ((System.Drawing.Image)(resources.GetObject("pbx_pdvsDodan.Image")));
            this.pbx_pdvsDodan.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_pdvsDodan.InitialImage")));
            this.pbx_pdvsDodan.Location = new System.Drawing.Point(38, 530);
            this.pbx_pdvsDodan.Name = "pbx_pdvsDodan";
            this.pbx_pdvsDodan.Size = new System.Drawing.Size(24, 24);
            this.pbx_pdvsDodan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_pdvsDodan.TabIndex = 74;
            this.pbx_pdvsDodan.TabStop = false;
            this.pbx_pdvsDodan.Visible = false;
            // 
            // lbl_pdvsDodan
            // 
            this.lbl_pdvsDodan.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pdvsDodan.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_pdvsDodan.Location = new System.Drawing.Point(81, 529);
            this.lbl_pdvsDodan.Name = "lbl_pdvsDodan";
            this.lbl_pdvsDodan.Size = new System.Drawing.Size(139, 22);
            this.lbl_pdvsDodan.TabIndex = 75;
            this.lbl_pdvsDodan.Text = "Dodani PDV-S izvještaj";
            this.lbl_pdvsDodan.Visible = false;
            // 
            // frm_UnosVIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(602, 622);
            this.Controls.Add(this.lbl_pdvsDodan);
            this.Controls.Add(this.pbx_pdvsDodan);
            this.Controls.Add(lbl_stariID);
            this.Controls.Add(this.ctxt_zadnjiID);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(iD_VIES_IzvješćaLabel);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.pbox_dodatiAnalitiku);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.pnl_VIESizvjestaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ispostava);
            this.Controls.Add(lbl_podrucniUred);
            this.Controls.Add(lbl_poreznaIspostava);
            this.Controls.Add(this.txt_podrucni);
            this.Controls.Add(this.lbl_NaslovVIES);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_UnosVIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIES Izvještaj - unos";
            this.Load += new System.EventHandler(this.frm_UnosVIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObveznikLookUpbindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_VIESizvjestaj.ResumeLayout(false);
            this.pnl_VIESizvjestaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtsifarnikStatusaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            this.pnl_stjecanja.ResumeLayout(false);
            this.pnl_stjecanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsProvjeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_addPdvS)).EndInit();
            this.pnl_isporuke.ResumeLayout(false);
            this.pnl_isporuke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpProvjeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_addZP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_dodatiAnalitiku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ViesUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pdvsDodan)).EndInit();
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
        private System.Windows.Forms.Panel pnl_VIESizvjestaj;
        private System.Windows.Forms.DateTimePicker txt_RazdobljedateTimePicker;
        private System.Windows.Forms.TextBox txt_stjecanje;
        private System.Windows.Forms.TextBox txt_isporuke;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.TextBox txt_lookUpStatus;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private System.Windows.Forms.BindingSource tbtsifarnikStatusaBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbt_sifarnikStatusaTableAdapter tbt_sifarnikStatusaTableAdapter;
        private System.Windows.Forms.Label lbl_zbirna;
        private System.Windows.Forms.Label lbl_PdvS;
        private System.Windows.Forms.Panel pnl_isporuke;
        private System.Windows.Forms.Panel pnl_stjecanja;
        private System.Windows.Forms.PictureBox pbox_addPdvS;
        private System.Windows.Forms.PictureBox pbox_addZP;
        private System.Windows.Forms.PictureBox pbox_dodatiAnalitiku;
        private System.Windows.Forms.Label lbl_alert;
        private ds_ViesUnos ds_ViesUnos;
        private System.Windows.Forms.BindingSource tbl_VIESizvjestajBindingSource1;
        private ds_ViesUnosTableAdapters.tbl_VIESizvjestajTableAdapter tbl_VIESizvjestajTableAdapter1;
        private ds_ViesUnosTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.BindingSource getIDBindingSource;
        private ds_ViesUnosTableAdapters.GetIDTableAdapter getIDTableAdapter;
        private System.Windows.Forms.TextBox ctxt_zadnjiID;
        private System.Windows.Forms.PictureBox pbox_PdvsEdit;
        private System.Windows.Forms.PictureBox pbox_PdvsOK;
        private System.Windows.Forms.PictureBox pbox_zpEdit;
        private System.Windows.Forms.PictureBox pbox_zpOK;
        private System.Windows.Forms.PictureBox pbox_PdvsProvjeri;
        private System.Windows.Forms.PictureBox pbox_zpProvjeri;
        private System.Windows.Forms.PictureBox pbx_pdvsDodan;
        private System.Windows.Forms.Label lbl_pdvsDodan;
    }
}