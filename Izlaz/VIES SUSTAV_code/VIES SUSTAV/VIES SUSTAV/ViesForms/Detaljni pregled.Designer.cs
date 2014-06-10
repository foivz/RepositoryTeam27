namespace VIES_SUSTAV.ViesForms
{
    partial class frm_detaljniPregled
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
            System.Windows.Forms.Label podrucniUredPULabel;
            System.Windows.Forms.Label poreznaIspostavaLabel;
            System.Windows.Forms.Label nazivObveznikaLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label državaLabel;
            System.Windows.Forms.Label djelatnostLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label oblikVlasnistvaLabel;
            System.Windows.Forms.Label vrstaObvezeLabel;
            System.Windows.Forms.Label korisnickoImeLabel;
            System.Windows.Forms.Label zaporkaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_detaljniPregled));
            this.ds_porezniObveznik = new VIES_SUSTAV.ds_porezniObveznik();
            this.tbl_porezniObveznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_porezniObveznikTableAdapter = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager();
            this.txt_OIB = new System.Windows.Forms.TextBox();
            this.txt_nazivObveznika = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_korisnickoIme = new System.Windows.Forms.TextBox();
            this.txt_zaporka = new System.Windows.Forms.TextBox();
            this.txt_datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_podaci = new System.Windows.Forms.Label();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.tblsifarnikPodrucnihUredaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikPodrucnihUredaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter();
            this.cbox_podrucni = new System.Windows.Forms.ComboBox();
            this.cbox_ispostave = new System.Windows.Forms.ComboBox();
            this.tblsifarnikIspostavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikIspostavaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter();
            this.cbox_djelatnost = new System.Windows.Forms.ComboBox();
            this.tblsifarnikDjelatnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikDjelatnostiTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikDjelatnostiTableAdapter();
            this.cbox_vlasnistvo = new System.Windows.Forms.ComboBox();
            this.tblsifarnikVlasnistvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikVlasnistvaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikVlasnistvaTableAdapter();
            this.cbox_obveza = new System.Windows.Forms.ComboBox();
            this.tblsifarnikObvezeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikObvezeTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikObvezeTableAdapter();
            this.btn_azuriraj = new System.Windows.Forms.Button();
            this.cbox_Zemlja = new System.Windows.Forms.ComboBox();
            this.tblsifarnikZemljaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikZemljaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter();
            this.tblsifarnikAktivnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikAktivnostiTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikAktivnostiTableAdapter();
            this.pic_alert = new System.Windows.Forms.PictureBox();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.txt_podrucni = new System.Windows.Forms.TextBox();
            this.txt_ispostava = new System.Windows.Forms.TextBox();
            this.txt_zemlja = new System.Windows.Forms.TextBox();
            this.txt_djelatnost = new System.Windows.Forms.TextBox();
            this.txt_vlasnistvo = new System.Windows.Forms.TextBox();
            this.txt_obveza = new System.Windows.Forms.TextBox();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.cbox_status = new System.Windows.Forms.ComboBox();
            oIBLabel = new System.Windows.Forms.Label();
            podrucniUredPULabel = new System.Windows.Forms.Label();
            poreznaIspostavaLabel = new System.Windows.Forms.Label();
            nazivObveznikaLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            državaLabel = new System.Windows.Forms.Label();
            djelatnostLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            oblikVlasnistvaLabel = new System.Windows.Forms.Label();
            vrstaObvezeLabel = new System.Windows.Forms.Label();
            korisnickoImeLabel = new System.Windows.Forms.Label();
            zaporkaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikPodrucnihUredaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikIspostavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikDjelatnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikVlasnistvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikObvezeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikZemljaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikAktivnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_alert)).BeginInit();
            this.SuspendLayout();
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(34, 176);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(33, 14);
            oIBLabel.TabIndex = 1;
            oIBLabel.Text = "OIB:";
            // 
            // podrucniUredPULabel
            // 
            podrucniUredPULabel.AutoSize = true;
            podrucniUredPULabel.Location = new System.Drawing.Point(34, 45);
            podrucniUredPULabel.Name = "podrucniUredPULabel";
            podrucniUredPULabel.Size = new System.Drawing.Size(117, 14);
            podrucniUredPULabel.TabIndex = 3;
            podrucniUredPULabel.Text = "Podrucni Ured PU:";
            // 
            // poreznaIspostavaLabel
            // 
            poreznaIspostavaLabel.AutoSize = true;
            poreznaIspostavaLabel.ForeColor = System.Drawing.Color.Navy;
            poreznaIspostavaLabel.Location = new System.Drawing.Point(34, 73);
            poreznaIspostavaLabel.Name = "poreznaIspostavaLabel";
            poreznaIspostavaLabel.Size = new System.Drawing.Size(124, 14);
            poreznaIspostavaLabel.TabIndex = 5;
            poreznaIspostavaLabel.Text = "Porezna Ispostava:";
            // 
            // nazivObveznikaLabel
            // 
            nazivObveznikaLabel.AutoSize = true;
            nazivObveznikaLabel.Location = new System.Drawing.Point(34, 206);
            nazivObveznikaLabel.Name = "nazivObveznikaLabel";
            nazivObveznikaLabel.Size = new System.Drawing.Size(108, 14);
            nazivObveznikaLabel.TabIndex = 7;
            nazivObveznikaLabel.Text = "Naziv Obveznika:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(34, 234);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(53, 14);
            adresaLabel.TabIndex = 9;
            adresaLabel.Text = "Adresa:";
            // 
            // državaLabel
            // 
            državaLabel.AutoSize = true;
            državaLabel.Location = new System.Drawing.Point(34, 262);
            državaLabel.Name = "državaLabel";
            državaLabel.Size = new System.Drawing.Size(52, 14);
            državaLabel.TabIndex = 11;
            državaLabel.Text = "Država:";
            // 
            // djelatnostLabel
            // 
            djelatnostLabel.AutoSize = true;
            djelatnostLabel.Location = new System.Drawing.Point(34, 290);
            djelatnostLabel.Name = "djelatnostLabel";
            djelatnostLabel.Size = new System.Drawing.Size(75, 14);
            djelatnostLabel.TabIndex = 13;
            djelatnostLabel.Text = "Djelatnost:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(34, 337);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(56, 14);
            telefonLabel.TabIndex = 15;
            telefonLabel.Text = "Telefon:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(34, 365);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(46, 14);
            e_mailLabel.TabIndex = 17;
            e_mailLabel.Text = "e mail:";
            // 
            // oblikVlasnistvaLabel
            // 
            oblikVlasnistvaLabel.AutoSize = true;
            oblikVlasnistvaLabel.Location = new System.Drawing.Point(34, 410);
            oblikVlasnistvaLabel.Name = "oblikVlasnistvaLabel";
            oblikVlasnistvaLabel.Size = new System.Drawing.Size(106, 14);
            oblikVlasnistvaLabel.TabIndex = 19;
            oblikVlasnistvaLabel.Text = "Oblik Vlasnistva:";
            // 
            // vrstaObvezeLabel
            // 
            vrstaObvezeLabel.AutoSize = true;
            vrstaObvezeLabel.Location = new System.Drawing.Point(34, 438);
            vrstaObvezeLabel.Name = "vrstaObvezeLabel";
            vrstaObvezeLabel.Size = new System.Drawing.Size(91, 14);
            vrstaObvezeLabel.TabIndex = 21;
            vrstaObvezeLabel.Text = "Vrsta Obveze:";
            // 
            // korisnickoImeLabel
            // 
            korisnickoImeLabel.AutoSize = true;
            korisnickoImeLabel.Location = new System.Drawing.Point(22, 507);
            korisnickoImeLabel.Name = "korisnickoImeLabel";
            korisnickoImeLabel.Size = new System.Drawing.Size(100, 14);
            korisnickoImeLabel.TabIndex = 23;
            korisnickoImeLabel.Text = "Korisnicko Ime:";
            // 
            // zaporkaLabel
            // 
            zaporkaLabel.AutoSize = true;
            zaporkaLabel.Location = new System.Drawing.Point(22, 535);
            zaporkaLabel.Name = "zaporkaLabel";
            zaporkaLabel.Size = new System.Drawing.Size(60, 14);
            zaporkaLabel.TabIndex = 25;
            zaporkaLabel.Text = "Zaporka:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(428, 515);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(93, 14);
            datumLabel.TabIndex = 27;
            datumLabel.Text = "Datum unosa:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(440, 129);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 14);
            statusLabel.TabIndex = 29;
            statusLabel.Text = "Status:";
            // 
            // ds_porezniObveznik
            // 
            this.ds_porezniObveznik.DataSetName = "ds_porezniObveznik";
            this.ds_porezniObveznik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_porezniObveznikBindingSource
            // 
            this.tbl_porezniObveznikBindingSource.DataMember = "tbl_porezniObveznik";
            this.tbl_porezniObveznikBindingSource.DataSource = this.ds_porezniObveznik;
            // 
            // tbl_porezniObveznikTableAdapter
            // 
            this.tbl_porezniObveznikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = this.tbl_porezniObveznikTableAdapter;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_OIB
            // 
            this.txt_OIB.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_OIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "OIB", true));
            this.txt_OIB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_OIB.Location = new System.Drawing.Point(164, 168);
            this.txt_OIB.Name = "txt_OIB";
            this.txt_OIB.Size = new System.Drawing.Size(233, 22);
            this.txt_OIB.TabIndex = 2;
            // 
            // txt_nazivObveznika
            // 
            this.txt_nazivObveznika.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nazivObveznika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "NazivObveznika", true));
            this.txt_nazivObveznika.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_nazivObveznika.Location = new System.Drawing.Point(164, 203);
            this.txt_nazivObveznika.Name = "txt_nazivObveznika";
            this.txt_nazivObveznika.Size = new System.Drawing.Size(348, 22);
            this.txt_nazivObveznika.TabIndex = 8;
            // 
            // txt_adresa
            // 
            this.txt_adresa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_adresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Adresa", true));
            this.txt_adresa.Enabled = false;
            this.txt_adresa.ForeColor = System.Drawing.Color.Navy;
            this.txt_adresa.Location = new System.Drawing.Point(164, 231);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(348, 22);
            this.txt_adresa.TabIndex = 10;
            // 
            // txt_telefon
            // 
            this.txt_telefon.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_telefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Telefon", true));
            this.txt_telefon.Enabled = false;
            this.txt_telefon.ForeColor = System.Drawing.Color.Navy;
            this.txt_telefon.Location = new System.Drawing.Point(164, 334);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(233, 22);
            this.txt_telefon.TabIndex = 16;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "e_mail", true));
            this.txt_Email.Enabled = false;
            this.txt_Email.ForeColor = System.Drawing.Color.Navy;
            this.txt_Email.Location = new System.Drawing.Point(164, 362);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(233, 22);
            this.txt_Email.TabIndex = 18;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_korisnickoIme
            // 
            this.txt_korisnickoIme.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_korisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "KorisnickoIme", true));
            this.txt_korisnickoIme.Enabled = false;
            this.txt_korisnickoIme.ForeColor = System.Drawing.Color.Navy;
            this.txt_korisnickoIme.Location = new System.Drawing.Point(144, 504);
            this.txt_korisnickoIme.Name = "txt_korisnickoIme";
            this.txt_korisnickoIme.Size = new System.Drawing.Size(151, 22);
            this.txt_korisnickoIme.TabIndex = 24;
            // 
            // txt_zaporka
            // 
            this.txt_zaporka.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_zaporka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Zaporka", true));
            this.txt_zaporka.Enabled = false;
            this.txt_zaporka.ForeColor = System.Drawing.Color.Navy;
            this.txt_zaporka.Location = new System.Drawing.Point(144, 532);
            this.txt_zaporka.Name = "txt_zaporka";
            this.txt_zaporka.Size = new System.Drawing.Size(151, 22);
            this.txt_zaporka.TabIndex = 26;
            // 
            // txt_datumDateTimePicker
            // 
            this.txt_datumDateTimePicker.CalendarForeColor = System.Drawing.Color.Navy;
            this.txt_datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_porezniObveznikBindingSource, "Datum", true));
            this.txt_datumDateTimePicker.Enabled = false;
            this.txt_datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_datumDateTimePicker.Location = new System.Drawing.Point(402, 532);
            this.txt_datumDateTimePicker.Name = "txt_datumDateTimePicker";
            this.txt_datumDateTimePicker.Size = new System.Drawing.Size(139, 22);
            this.txt_datumDateTimePicker.TabIndex = 28;
            // 
            // lbl_podaci
            // 
            this.lbl_podaci.BackColor = System.Drawing.Color.Orange;
            this.lbl_podaci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_podaci.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_podaci.ForeColor = System.Drawing.Color.Navy;
            this.lbl_podaci.Location = new System.Drawing.Point(-4, 105);
            this.lbl_podaci.Name = "lbl_podaci";
            this.lbl_podaci.Size = new System.Drawing.Size(545, 24);
            this.lbl_podaci.TabIndex = 44;
            this.lbl_podaci.Text = "Podaci o poreznom obvezniku - detaljni podaci";
            this.lbl_podaci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(-4, 3);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(545, 24);
            this.lbl_poreznaUprava.TabIndex = 43;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-25, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "-------------------------------------------------------------\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ds_sifarnici_lookUp
            // 
            this.ds_sifarnici_lookUp.DataSetName = "ds_sifarnici_lookUp";
            this.ds_sifarnici_lookUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsifarnikPodrucnihUredaBindingSource
            // 
            this.tblsifarnikPodrucnihUredaBindingSource.DataMember = "tbl_sifarnikPodrucnihUreda";
            this.tblsifarnikPodrucnihUredaBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikPodrucnihUredaTableAdapter
            // 
            this.tbl_sifarnikPodrucnihUredaTableAdapter.ClearBeforeFill = true;
            // 
            // cbox_podrucni
            // 
            this.cbox_podrucni.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_podrucni.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "PodrucniUredPU", true));
            this.cbox_podrucni.DataSource = this.tblsifarnikPodrucnihUredaBindingSource;
            this.cbox_podrucni.DisplayMember = "nazivPodrucnogUreda";
            this.cbox_podrucni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_podrucni.Enabled = false;
            this.cbox_podrucni.ForeColor = System.Drawing.Color.Navy;
            this.cbox_podrucni.FormattingEnabled = true;
            this.cbox_podrucni.Location = new System.Drawing.Point(164, 42);
            this.cbox_podrucni.Name = "cbox_podrucni";
            this.cbox_podrucni.Size = new System.Drawing.Size(233, 22);
            this.cbox_podrucni.TabIndex = 47;
            this.cbox_podrucni.ValueMember = "sifraPodrucnogUreda";
            // 
            // cbox_ispostave
            // 
            this.cbox_ispostave.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_ispostave.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "PoreznaIspostava", true));
            this.cbox_ispostave.DataSource = this.tblsifarnikIspostavaBindingSource;
            this.cbox_ispostave.DisplayMember = "nazivIspostave";
            this.cbox_ispostave.Enabled = false;
            this.cbox_ispostave.ForeColor = System.Drawing.Color.Navy;
            this.cbox_ispostave.FormattingEnabled = true;
            this.cbox_ispostave.Location = new System.Drawing.Point(164, 70);
            this.cbox_ispostave.Name = "cbox_ispostave";
            this.cbox_ispostave.Size = new System.Drawing.Size(233, 22);
            this.cbox_ispostave.TabIndex = 48;
            this.cbox_ispostave.ValueMember = "sifraIspostave";
            // 
            // tblsifarnikIspostavaBindingSource
            // 
            this.tblsifarnikIspostavaBindingSource.DataMember = "tbl_sifarnikIspostava";
            this.tblsifarnikIspostavaBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikIspostavaTableAdapter
            // 
            this.tbl_sifarnikIspostavaTableAdapter.ClearBeforeFill = true;
            // 
            // cbox_djelatnost
            // 
            this.cbox_djelatnost.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_djelatnost.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Djelatnost", true));
            this.cbox_djelatnost.DataSource = this.tblsifarnikDjelatnostiBindingSource;
            this.cbox_djelatnost.DisplayMember = "nazivDjelatnosti";
            this.cbox_djelatnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_djelatnost.Enabled = false;
            this.cbox_djelatnost.ForeColor = System.Drawing.Color.Navy;
            this.cbox_djelatnost.FormattingEnabled = true;
            this.cbox_djelatnost.Location = new System.Drawing.Point(164, 290);
            this.cbox_djelatnost.Name = "cbox_djelatnost";
            this.cbox_djelatnost.Size = new System.Drawing.Size(366, 22);
            this.cbox_djelatnost.TabIndex = 49;
            this.cbox_djelatnost.ValueMember = "sifraDjelatnosti";
            // 
            // tblsifarnikDjelatnostiBindingSource
            // 
            this.tblsifarnikDjelatnostiBindingSource.DataMember = "tbl_sifarnikDjelatnosti";
            this.tblsifarnikDjelatnostiBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikDjelatnostiTableAdapter
            // 
            this.tbl_sifarnikDjelatnostiTableAdapter.ClearBeforeFill = true;
            // 
            // cbox_vlasnistvo
            // 
            this.cbox_vlasnistvo.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_vlasnistvo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "OblikVlasnistva", true));
            this.cbox_vlasnistvo.DataSource = this.tblsifarnikVlasnistvaBindingSource;
            this.cbox_vlasnistvo.DisplayMember = "opisVlasnnistva";
            this.cbox_vlasnistvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_vlasnistvo.Enabled = false;
            this.cbox_vlasnistvo.ForeColor = System.Drawing.Color.Navy;
            this.cbox_vlasnistvo.FormattingEnabled = true;
            this.cbox_vlasnistvo.Location = new System.Drawing.Point(164, 402);
            this.cbox_vlasnistvo.Name = "cbox_vlasnistvo";
            this.cbox_vlasnistvo.Size = new System.Drawing.Size(182, 22);
            this.cbox_vlasnistvo.TabIndex = 50;
            this.cbox_vlasnistvo.ValueMember = "sifraVlasnistva";
            // 
            // tblsifarnikVlasnistvaBindingSource
            // 
            this.tblsifarnikVlasnistvaBindingSource.DataMember = "tbl_sifarnikVlasnistva";
            this.tblsifarnikVlasnistvaBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikVlasnistvaTableAdapter
            // 
            this.tbl_sifarnikVlasnistvaTableAdapter.ClearBeforeFill = true;
            // 
            // cbox_obveza
            // 
            this.cbox_obveza.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_obveza.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "VrstaObveze", true));
            this.cbox_obveza.DataSource = this.tblsifarnikObvezeBindingSource;
            this.cbox_obveza.DisplayMember = "opisObveze";
            this.cbox_obveza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_obveza.Enabled = false;
            this.cbox_obveza.ForeColor = System.Drawing.Color.Navy;
            this.cbox_obveza.FormattingEnabled = true;
            this.cbox_obveza.Location = new System.Drawing.Point(164, 430);
            this.cbox_obveza.Name = "cbox_obveza";
            this.cbox_obveza.Size = new System.Drawing.Size(182, 22);
            this.cbox_obveza.TabIndex = 51;
            this.cbox_obveza.ValueMember = "sifraObveze";
            // 
            // tblsifarnikObvezeBindingSource
            // 
            this.tblsifarnikObvezeBindingSource.DataMember = "tbl_sifarnikObveze";
            this.tblsifarnikObvezeBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikObvezeTableAdapter
            // 
            this.tbl_sifarnikObvezeTableAdapter.ClearBeforeFill = true;
            // 
            // btn_azuriraj
            // 
            this.btn_azuriraj.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_azuriraj.Location = new System.Drawing.Point(430, 407);
            this.btn_azuriraj.Name = "btn_azuriraj";
            this.btn_azuriraj.Size = new System.Drawing.Size(100, 45);
            this.btn_azuriraj.TabIndex = 52;
            this.btn_azuriraj.Text = "Ažuriraj";
            this.btn_azuriraj.UseVisualStyleBackColor = false;
            this.btn_azuriraj.Click += new System.EventHandler(this.btn_azuriraj_Click);
            // 
            // cbox_Zemlja
            // 
            this.cbox_Zemlja.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_Zemlja.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Država", true));
            this.cbox_Zemlja.DataSource = this.tblsifarnikZemljaBindingSource;
            this.cbox_Zemlja.DisplayMember = "nazivZemlje";
            this.cbox_Zemlja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Zemlja.Enabled = false;
            this.cbox_Zemlja.ForeColor = System.Drawing.Color.Navy;
            this.cbox_Zemlja.FormattingEnabled = true;
            this.cbox_Zemlja.Location = new System.Drawing.Point(164, 259);
            this.cbox_Zemlja.Name = "cbox_Zemlja";
            this.cbox_Zemlja.Size = new System.Drawing.Size(233, 22);
            this.cbox_Zemlja.TabIndex = 53;
            this.cbox_Zemlja.ValueMember = "sifraZemlje";
            // 
            // tblsifarnikZemljaBindingSource
            // 
            this.tblsifarnikZemljaBindingSource.DataMember = "tbl_sifarnikZemlja";
            this.tblsifarnikZemljaBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikZemljaTableAdapter
            // 
            this.tbl_sifarnikZemljaTableAdapter.ClearBeforeFill = true;
            // 
            // tblsifarnikAktivnostiBindingSource
            // 
            this.tblsifarnikAktivnostiBindingSource.DataMember = "tbl_sifarnikAktivnosti";
            this.tblsifarnikAktivnostiBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikAktivnostiTableAdapter
            // 
            this.tbl_sifarnikAktivnostiTableAdapter.ClearBeforeFill = true;
            // 
            // pic_alert
            // 
            this.pic_alert.Image = global::VIES_SUSTAV.Properties.Resources.alert;
            this.pic_alert.Location = new System.Drawing.Point(136, 166);
            this.pic_alert.Name = "pic_alert";
            this.pic_alert.Size = new System.Drawing.Size(25, 29);
            this.pic_alert.TabIndex = 61;
            this.pic_alert.TabStop = false;
            this.pic_alert.Visible = false;
            this.pic_alert.Click += new System.EventHandler(this.pic_alert_Click);
            // 
            // btn_spremi
            // 
            this.btn_spremi.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_spremi.Location = new System.Drawing.Point(431, 339);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(100, 45);
            this.btn_spremi.TabIndex = 62;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = false;
            this.btn_spremi.Visible = false;
            this.btn_spremi.Click += new System.EventHandler(this.btn_spremi_Click);
            // 
            // txt_podrucni
            // 
            this.txt_podrucni.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_podrucni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "PodrucniUredPU", true));
            this.txt_podrucni.Enabled = false;
            this.txt_podrucni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_podrucni.ForeColor = System.Drawing.Color.Orange;
            this.txt_podrucni.Location = new System.Drawing.Point(402, 42);
            this.txt_podrucni.Name = "txt_podrucni";
            this.txt_podrucni.Size = new System.Drawing.Size(61, 22);
            this.txt_podrucni.TabIndex = 63;
            this.txt_podrucni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ispostava
            // 
            this.txt_ispostava.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_ispostava.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "PoreznaIspostava", true));
            this.txt_ispostava.Enabled = false;
            this.txt_ispostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ispostava.ForeColor = System.Drawing.Color.Orange;
            this.txt_ispostava.Location = new System.Drawing.Point(402, 70);
            this.txt_ispostava.Name = "txt_ispostava";
            this.txt_ispostava.Size = new System.Drawing.Size(61, 22);
            this.txt_ispostava.TabIndex = 64;
            this.txt_ispostava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_zemlja
            // 
            this.txt_zemlja.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_zemlja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Država", true));
            this.txt_zemlja.Enabled = false;
            this.txt_zemlja.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zemlja.ForeColor = System.Drawing.Color.Orange;
            this.txt_zemlja.Location = new System.Drawing.Point(403, 259);
            this.txt_zemlja.Name = "txt_zemlja";
            this.txt_zemlja.Size = new System.Drawing.Size(61, 22);
            this.txt_zemlja.TabIndex = 66;
            this.txt_zemlja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_djelatnost
            // 
            this.txt_djelatnost.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_djelatnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Djelatnost", true));
            this.txt_djelatnost.Enabled = false;
            this.txt_djelatnost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_djelatnost.ForeColor = System.Drawing.Color.Orange;
            this.txt_djelatnost.Location = new System.Drawing.Point(469, 259);
            this.txt_djelatnost.Name = "txt_djelatnost";
            this.txt_djelatnost.Size = new System.Drawing.Size(61, 22);
            this.txt_djelatnost.TabIndex = 67;
            this.txt_djelatnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_djelatnost.Visible = false;
            // 
            // txt_vlasnistvo
            // 
            this.txt_vlasnistvo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_vlasnistvo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "OblikVlasnistva", true));
            this.txt_vlasnistvo.Enabled = false;
            this.txt_vlasnistvo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vlasnistvo.ForeColor = System.Drawing.Color.Orange;
            this.txt_vlasnistvo.Location = new System.Drawing.Point(352, 402);
            this.txt_vlasnistvo.Name = "txt_vlasnistvo";
            this.txt_vlasnistvo.Size = new System.Drawing.Size(61, 22);
            this.txt_vlasnistvo.TabIndex = 68;
            this.txt_vlasnistvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_obveza
            // 
            this.txt_obveza.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_obveza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "VrstaObveze", true));
            this.txt_obveza.Enabled = false;
            this.txt_obveza.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obveza.ForeColor = System.Drawing.Color.Orange;
            this.txt_obveza.Location = new System.Drawing.Point(352, 430);
            this.txt_obveza.Name = "txt_obveza";
            this.txt_obveza.Size = new System.Drawing.Size(61, 22);
            this.txt_obveza.TabIndex = 69;
            this.txt_obveza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_zatvori.Location = new System.Drawing.Point(431, 339);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(100, 45);
            this.btn_zatvori.TabIndex = 71;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = false;
            this.btn_zatvori.Visible = false;
            this.btn_zatvori.Click += new System.EventHandler(this.btn_zatvori_Click);
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Status", true));
            this.txt_status.Location = new System.Drawing.Point(424, 174);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(68, 22);
            this.txt_status.TabIndex = 72;
            this.txt_status.Visible = false;
            // 
            // cbox_status
            // 
            this.cbox_status.BackColor = System.Drawing.Color.Gainsboro;
            this.cbox_status.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Status", true));
            this.cbox_status.DataSource = this.tblsifarnikAktivnostiBindingSource;
            this.cbox_status.DisplayMember = "opis aktivnosti";
            this.cbox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_status.Enabled = false;
            this.cbox_status.ForeColor = System.Drawing.Color.Red;
            this.cbox_status.FormattingEnabled = true;
            this.cbox_status.Location = new System.Drawing.Point(413, 146);
            this.cbox_status.Name = "cbox_status";
            this.cbox_status.Size = new System.Drawing.Size(117, 22);
            this.cbox_status.TabIndex = 73;
            this.cbox_status.ValueMember = "sifraAktivnosti";
            // 
            // frm_detaljniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(542, 574);
            this.Controls.Add(this.cbox_status);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.btn_zatvori);
            this.Controls.Add(this.txt_obveza);
            this.Controls.Add(this.txt_vlasnistvo);
            this.Controls.Add(this.txt_djelatnost);
            this.Controls.Add(this.txt_zemlja);
            this.Controls.Add(this.txt_ispostava);
            this.Controls.Add(this.txt_podrucni);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.pic_alert);
            this.Controls.Add(this.cbox_Zemlja);
            this.Controls.Add(this.btn_azuriraj);
            this.Controls.Add(this.cbox_obveza);
            this.Controls.Add(this.cbox_vlasnistvo);
            this.Controls.Add(this.cbox_djelatnost);
            this.Controls.Add(this.cbox_ispostave);
            this.Controls.Add(this.cbox_podrucni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_podaci);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(oIBLabel);
            this.Controls.Add(this.txt_OIB);
            this.Controls.Add(podrucniUredPULabel);
            this.Controls.Add(poreznaIspostavaLabel);
            this.Controls.Add(nazivObveznikaLabel);
            this.Controls.Add(this.txt_nazivObveznika);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(državaLabel);
            this.Controls.Add(djelatnostLabel);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(oblikVlasnistvaLabel);
            this.Controls.Add(vrstaObvezeLabel);
            this.Controls.Add(korisnickoImeLabel);
            this.Controls.Add(this.txt_korisnickoIme);
            this.Controls.Add(zaporkaLabel);
            this.Controls.Add(this.txt_zaporka);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.txt_datumDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_detaljniPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o poreznom obveznicu - detaljni pregled";
            this.Load += new System.EventHandler(this.Detaljni_pregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikPodrucnihUredaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikIspostavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikDjelatnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikVlasnistvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikObvezeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikZemljaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikAktivnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_alert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds_porezniObveznik ds_porezniObveznik;
        private System.Windows.Forms.BindingSource tbl_porezniObveznikBindingSource;
        private ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter tbl_porezniObveznikTableAdapter;
        private ds_porezniObveznikTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_OIB;
        private System.Windows.Forms.TextBox txt_nazivObveznika;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_korisnickoIme;
        private System.Windows.Forms.TextBox txt_zaporka;
        private System.Windows.Forms.DateTimePicker txt_datumDateTimePicker;
        private System.Windows.Forms.Label lbl_podaci;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.Label label1;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private System.Windows.Forms.BindingSource tblsifarnikPodrucnihUredaBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter tbl_sifarnikPodrucnihUredaTableAdapter;
        private System.Windows.Forms.ComboBox cbox_podrucni;
        private System.Windows.Forms.ComboBox cbox_ispostave;
        private System.Windows.Forms.BindingSource tblsifarnikIspostavaBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter tbl_sifarnikIspostavaTableAdapter;
        private System.Windows.Forms.ComboBox cbox_djelatnost;
        private System.Windows.Forms.BindingSource tblsifarnikDjelatnostiBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikDjelatnostiTableAdapter tbl_sifarnikDjelatnostiTableAdapter;
        private System.Windows.Forms.ComboBox cbox_vlasnistvo;
        private System.Windows.Forms.BindingSource tblsifarnikVlasnistvaBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikVlasnistvaTableAdapter tbl_sifarnikVlasnistvaTableAdapter;
        private System.Windows.Forms.ComboBox cbox_obveza;
        private System.Windows.Forms.BindingSource tblsifarnikObvezeBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikObvezeTableAdapter tbl_sifarnikObvezeTableAdapter;
        private System.Windows.Forms.Button btn_azuriraj;
        private System.Windows.Forms.ComboBox cbox_Zemlja;
        private System.Windows.Forms.BindingSource tblsifarnikZemljaBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter tbl_sifarnikZemljaTableAdapter;
        private System.Windows.Forms.BindingSource tblsifarnikAktivnostiBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikAktivnostiTableAdapter tbl_sifarnikAktivnostiTableAdapter;
        private System.Windows.Forms.PictureBox pic_alert;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.TextBox txt_podrucni;
        private System.Windows.Forms.TextBox txt_ispostava;
        private System.Windows.Forms.TextBox txt_zemlja;
        private System.Windows.Forms.TextBox txt_djelatnost;
        private System.Windows.Forms.TextBox txt_vlasnistvo;
        private System.Windows.Forms.TextBox txt_obveza;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.ComboBox cbox_status;
    }
}