namespace VIES_SUSTAV.ViesForms
{
    partial class frm_unosNovogObveznika
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
            System.Windows.Forms.Label lbl_oIBLabel;
            System.Windows.Forms.Label lbl_podrucniUred;
            System.Windows.Forms.Label lbl_poreznaIspostava;
            System.Windows.Forms.Label lbl_nazivObveznika;
            System.Windows.Forms.Label lbl_adresaLabel;
            System.Windows.Forms.Label lbl_državaLabel;
            System.Windows.Forms.Label lbl_djelatnostLabel;
            System.Windows.Forms.Label lbl_telefonLabel;
            System.Windows.Forms.Label lbl_e_mailLabel;
            System.Windows.Forms.Label lbl_oblikVlasnistvaLabel;
            System.Windows.Forms.Label lbl_vrstaObvezeLabel;
            System.Windows.Forms.Label lbl_korisnickoIme;
            System.Windows.Forms.Label lbl_zaporka;
            System.Windows.Forms.Label lbl_datum;
            System.Windows.Forms.Label lbl_status;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_unosNovogObveznika));
            this.ds_porezniObveznik = new VIES_SUSTAV.ds_porezniObveznik();
            this.tbl_porezniObveznikTableAdapter = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter();
            this.dt_datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PodrucnibindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.tbl_sifarnikPodrucnihUredaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter();
            this.IspostavebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikIspostavaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.ZemljabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikZemljaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter();
            this.DjelatnostbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikDjelatnostiTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikDjelatnostiTableAdapter();
            this.VlasnistvobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikVlasnistvaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikVlasnistvaTableAdapter();
            this.ObvezabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikObvezeTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikObvezeTableAdapter();
            this.txt_sifraVlasnistva = new System.Windows.Forms.TextBox();
            this.txt_sifraObveze = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_podrucni = new System.Windows.Forms.ComboBox();
            this.cbox_Ispostava = new System.Windows.Forms.ComboBox();
            this.txt_OIB = new System.Windows.Forms.TextBox();
            this.txt_nazivObveznika = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.cbox_sifraDjelatnosti = new System.Windows.Forms.ComboBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_eMail = new System.Windows.Forms.TextBox();
            this.cbox_vlasnistvo = new System.Windows.Forms.ComboBox();
            this.cbox_Obveza = new System.Windows.Forms.ComboBox();
            this.txt_korisnickoIme = new System.Windows.Forms.TextBox();
            this.txt_Zaporka = new System.Windows.Forms.TextBox();
            this.cbox_aktivnost = new System.Windows.Forms.ComboBox();
            this.txt_podrucni = new System.Windows.Forms.TextBox();
            this.txt_Ispostava = new System.Windows.Forms.TextBox();
            this.txt_Zemlja = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Djelatnost = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_SpremiPorObv = new System.Windows.Forms.Button();
            this.btm_dodajNovi = new System.Windows.Forms.Button();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.tblsifarnikAktivnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikAktivnostiTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikAktivnostiTableAdapter();
            this.txt_aktivnost = new System.Windows.Forms.TextBox();
            this.tbl_porezniObveznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager();
            lbl_oIBLabel = new System.Windows.Forms.Label();
            lbl_podrucniUred = new System.Windows.Forms.Label();
            lbl_poreznaIspostava = new System.Windows.Forms.Label();
            lbl_nazivObveznika = new System.Windows.Forms.Label();
            lbl_adresaLabel = new System.Windows.Forms.Label();
            lbl_državaLabel = new System.Windows.Forms.Label();
            lbl_djelatnostLabel = new System.Windows.Forms.Label();
            lbl_telefonLabel = new System.Windows.Forms.Label();
            lbl_e_mailLabel = new System.Windows.Forms.Label();
            lbl_oblikVlasnistvaLabel = new System.Windows.Forms.Label();
            lbl_vrstaObvezeLabel = new System.Windows.Forms.Label();
            lbl_korisnickoIme = new System.Windows.Forms.Label();
            lbl_zaporka = new System.Windows.Forms.Label();
            lbl_datum = new System.Windows.Forms.Label();
            lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodrucnibindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IspostavebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnostbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VlasnistvobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObvezabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikAktivnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_oIBLabel
            // 
            lbl_oIBLabel.AutoSize = true;
            lbl_oIBLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_oIBLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_oIBLabel.Location = new System.Drawing.Point(22, 163);
            lbl_oIBLabel.Name = "lbl_oIBLabel";
            lbl_oIBLabel.Size = new System.Drawing.Size(33, 14);
            lbl_oIBLabel.TabIndex = 2;
            lbl_oIBLabel.Text = "OIB:";
            // 
            // lbl_podrucniUred
            // 
            lbl_podrucniUred.AutoSize = true;
            lbl_podrucniUred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_podrucniUred.ForeColor = System.Drawing.Color.Navy;
            lbl_podrucniUred.Location = new System.Drawing.Point(12, 56);
            lbl_podrucniUred.Name = "lbl_podrucniUred";
            lbl_podrucniUred.Size = new System.Drawing.Size(117, 14);
            lbl_podrucniUred.TabIndex = 4;
            lbl_podrucniUred.Text = "Područni Ured PU:";
            // 
            // lbl_poreznaIspostava
            // 
            lbl_poreznaIspostava.AutoSize = true;
            lbl_poreznaIspostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_poreznaIspostava.ForeColor = System.Drawing.Color.Navy;
            lbl_poreznaIspostava.Location = new System.Drawing.Point(12, 81);
            lbl_poreznaIspostava.Name = "lbl_poreznaIspostava";
            lbl_poreznaIspostava.Size = new System.Drawing.Size(124, 14);
            lbl_poreznaIspostava.TabIndex = 6;
            lbl_poreznaIspostava.Text = "Porezna Ispostava:";
            // 
            // lbl_nazivObveznika
            // 
            lbl_nazivObveznika.AutoSize = true;
            lbl_nazivObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_nazivObveznika.ForeColor = System.Drawing.Color.Navy;
            lbl_nazivObveznika.Location = new System.Drawing.Point(22, 193);
            lbl_nazivObveznika.Name = "lbl_nazivObveznika";
            lbl_nazivObveznika.Size = new System.Drawing.Size(107, 14);
            lbl_nazivObveznika.TabIndex = 8;
            lbl_nazivObveznika.Text = "Naziv obveznika:";
            // 
            // lbl_adresaLabel
            // 
            lbl_adresaLabel.AutoSize = true;
            lbl_adresaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_adresaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_adresaLabel.Location = new System.Drawing.Point(22, 223);
            lbl_adresaLabel.Name = "lbl_adresaLabel";
            lbl_adresaLabel.Size = new System.Drawing.Size(53, 14);
            lbl_adresaLabel.TabIndex = 10;
            lbl_adresaLabel.Text = "Adresa:";
            // 
            // lbl_državaLabel
            // 
            lbl_državaLabel.AutoSize = true;
            lbl_državaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_državaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_državaLabel.Location = new System.Drawing.Point(22, 286);
            lbl_državaLabel.Name = "lbl_državaLabel";
            lbl_državaLabel.Size = new System.Drawing.Size(52, 14);
            lbl_državaLabel.TabIndex = 12;
            lbl_državaLabel.Text = "Država:";
            // 
            // lbl_djelatnostLabel
            // 
            lbl_djelatnostLabel.AutoSize = true;
            lbl_djelatnostLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_djelatnostLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_djelatnostLabel.Location = new System.Drawing.Point(22, 316);
            lbl_djelatnostLabel.Name = "lbl_djelatnostLabel";
            lbl_djelatnostLabel.Size = new System.Drawing.Size(75, 14);
            lbl_djelatnostLabel.TabIndex = 14;
            lbl_djelatnostLabel.Text = "Djelatnost:";
            // 
            // lbl_telefonLabel
            // 
            lbl_telefonLabel.AutoSize = true;
            lbl_telefonLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_telefonLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_telefonLabel.Location = new System.Drawing.Point(22, 382);
            lbl_telefonLabel.Name = "lbl_telefonLabel";
            lbl_telefonLabel.Size = new System.Drawing.Size(56, 14);
            lbl_telefonLabel.TabIndex = 16;
            lbl_telefonLabel.Text = "Telefon:";
            // 
            // lbl_e_mailLabel
            // 
            lbl_e_mailLabel.AutoSize = true;
            lbl_e_mailLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_e_mailLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_e_mailLabel.Location = new System.Drawing.Point(22, 410);
            lbl_e_mailLabel.Name = "lbl_e_mailLabel";
            lbl_e_mailLabel.Size = new System.Drawing.Size(46, 14);
            lbl_e_mailLabel.TabIndex = 18;
            lbl_e_mailLabel.Text = "e mail:";
            // 
            // lbl_oblikVlasnistvaLabel
            // 
            lbl_oblikVlasnistvaLabel.AutoSize = true;
            lbl_oblikVlasnistvaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_oblikVlasnistvaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_oblikVlasnistvaLabel.Location = new System.Drawing.Point(14, 444);
            lbl_oblikVlasnistvaLabel.Name = "lbl_oblikVlasnistvaLabel";
            lbl_oblikVlasnistvaLabel.Size = new System.Drawing.Size(106, 14);
            lbl_oblikVlasnistvaLabel.TabIndex = 20;
            lbl_oblikVlasnistvaLabel.Text = "Oblik Vlasnistva:";
            // 
            // lbl_vrstaObvezeLabel
            // 
            lbl_vrstaObvezeLabel.AutoSize = true;
            lbl_vrstaObvezeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_vrstaObvezeLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_vrstaObvezeLabel.Location = new System.Drawing.Point(14, 472);
            lbl_vrstaObvezeLabel.Name = "lbl_vrstaObvezeLabel";
            lbl_vrstaObvezeLabel.Size = new System.Drawing.Size(91, 14);
            lbl_vrstaObvezeLabel.TabIndex = 22;
            lbl_vrstaObvezeLabel.Text = "Vrsta Obveze:";
            // 
            // lbl_korisnickoIme
            // 
            lbl_korisnickoIme.AutoSize = true;
            lbl_korisnickoIme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_korisnickoIme.ForeColor = System.Drawing.Color.Navy;
            lbl_korisnickoIme.Location = new System.Drawing.Point(12, 562);
            lbl_korisnickoIme.Name = "lbl_korisnickoIme";
            lbl_korisnickoIme.Size = new System.Drawing.Size(100, 14);
            lbl_korisnickoIme.TabIndex = 24;
            lbl_korisnickoIme.Text = "Korisnicko Ime:";
            // 
            // lbl_zaporka
            // 
            lbl_zaporka.AutoSize = true;
            lbl_zaporka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_zaporka.ForeColor = System.Drawing.Color.Navy;
            lbl_zaporka.Location = new System.Drawing.Point(12, 588);
            lbl_zaporka.Name = "lbl_zaporka";
            lbl_zaporka.Size = new System.Drawing.Size(60, 14);
            lbl_zaporka.TabIndex = 26;
            lbl_zaporka.Text = "Zaporka:";
            // 
            // lbl_datum
            // 
            lbl_datum.AutoSize = true;
            lbl_datum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_datum.ForeColor = System.Drawing.Color.Navy;
            lbl_datum.Location = new System.Drawing.Point(490, 615);
            lbl_datum.Name = "lbl_datum";
            lbl_datum.Size = new System.Drawing.Size(52, 14);
            lbl_datum.TabIndex = 28;
            lbl_datum.Text = "Datum:";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_status.ForeColor = System.Drawing.Color.Navy;
            lbl_status.Location = new System.Drawing.Point(12, 621);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new System.Drawing.Size(52, 14);
            lbl_status.TabIndex = 57;
            lbl_status.Text = "Status:";
           
            // 
            // ds_porezniObveznik
            // 
            this.ds_porezniObveznik.DataSetName = "ds_porezniObveznik";
            this.ds_porezniObveznik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_porezniObveznikTableAdapter
            // 
            this.tbl_porezniObveznikTableAdapter.ClearBeforeFill = true;
            // 
            // dt_datumDateTimePicker
            // 
            this.dt_datumDateTimePicker.CalendarForeColor = System.Drawing.Color.Navy;
            this.dt_datumDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
            this.dt_datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_porezniObveznikBindingSource, "Datum", true));
            this.dt_datumDateTimePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_datumDateTimePicker.Location = new System.Drawing.Point(435, 632);
            this.dt_datumDateTimePicker.Name = "dt_datumDateTimePicker";
            this.dt_datumDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.dt_datumDateTimePicker.TabIndex = 29;
            // 
            // PodrucnibindingSource
            // 
            this.PodrucnibindingSource.DataMember = "tbl_sifarnikPodrucnihUreda";
            this.PodrucnibindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ds_sifarnici_lookUp
            // 
            this.ds_sifarnici_lookUp.DataSetName = "ds_sifarnici_lookUp";
            this.ds_sifarnici_lookUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sifarnikPodrucnihUredaTableAdapter
            // 
            this.tbl_sifarnikPodrucnihUredaTableAdapter.ClearBeforeFill = true;
            // 
            // IspostavebindingSource
            // 
            this.IspostavebindingSource.DataMember = "tbl_sifarnikIspostava";
            this.IspostavebindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikIspostavaTableAdapter
            // 
            this.tbl_sifarnikIspostavaTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(0, 9);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(592, 24);
            this.lbl_poreznaUprava.TabIndex = 32;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZemljabindingSource
            // 
            this.ZemljabindingSource.DataMember = "tbl_sifarnikZemlja";
            this.ZemljabindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikZemljaTableAdapter
            // 
            this.tbl_sifarnikZemljaTableAdapter.ClearBeforeFill = true;
            // 
            // DjelatnostbindingSource
            // 
            this.DjelatnostbindingSource.DataMember = "tbl_sifarnikDjelatnosti";
            this.DjelatnostbindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikDjelatnostiTableAdapter
            // 
            this.tbl_sifarnikDjelatnostiTableAdapter.ClearBeforeFill = true;
            // 
            // VlasnistvobindingSource
            // 
            this.VlasnistvobindingSource.DataMember = "tbl_sifarnikVlasnistva";
            this.VlasnistvobindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikVlasnistvaTableAdapter
            // 
            this.tbl_sifarnikVlasnistvaTableAdapter.ClearBeforeFill = true;
            // 
            // ObvezabindingSource
            // 
            this.ObvezabindingSource.DataMember = "tbl_sifarnikObveze";
            this.ObvezabindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikObvezeTableAdapter
            // 
            this.tbl_sifarnikObvezeTableAdapter.ClearBeforeFill = true;
            // 
            // txt_sifraVlasnistva
            // 
            this.txt_sifraVlasnistva.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_sifraVlasnistva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VlasnistvobindingSource, "sifraVlasnistva", true));
            this.txt_sifraVlasnistva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifraVlasnistva.ForeColor = System.Drawing.Color.Orange;
            this.txt_sifraVlasnistva.Location = new System.Drawing.Point(393, 437);
            this.txt_sifraVlasnistva.Name = "txt_sifraVlasnistva";
            this.txt_sifraVlasnistva.Size = new System.Drawing.Size(63, 22);
            this.txt_sifraVlasnistva.TabIndex = 39;
            this.txt_sifraVlasnistva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sifraObveze
            // 
            this.txt_sifraObveze.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_sifraObveze.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObvezabindingSource, "sifraObveze", true));
            this.txt_sifraObveze.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifraObveze.ForeColor = System.Drawing.Color.Orange;
            this.txt_sifraObveze.Location = new System.Drawing.Point(393, 472);
            this.txt_sifraObveze.Name = "txt_sifraObveze";
            this.txt_sifraObveze.Size = new System.Drawing.Size(63, 22);
            this.txt_sifraObveze.TabIndex = 40;
            this.txt_sifraObveze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "-------------------------------------------------------------\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(0, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Podaci o poreznom obvezniku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_podrucni
            // 
            this.cbox_podrucni.BackColor = System.Drawing.Color.AliceBlue;
            this.cbox_podrucni.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "PodrucniUredPU", true));
            this.cbox_podrucni.DataSource = this.PodrucnibindingSource;
            this.cbox_podrucni.DisplayMember = "nazivPodrucnogUreda";
            this.cbox_podrucni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_podrucni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_podrucni.ForeColor = System.Drawing.Color.Navy;
            this.cbox_podrucni.FormattingEnabled = true;
            this.cbox_podrucni.Location = new System.Drawing.Point(153, 48);
            this.cbox_podrucni.Name = "cbox_podrucni";
            this.cbox_podrucni.Size = new System.Drawing.Size(243, 22);
            this.cbox_podrucni.TabIndex = 43;
            this.cbox_podrucni.ValueMember = "sifraPodrucnogUreda";
            this.cbox_podrucni.SelectedIndexChanged += new System.EventHandler(this.cbox_podrucni_SelectedIndexChanged);
            // 
            // cbox_Ispostava
            // 
            this.cbox_Ispostava.BackColor = System.Drawing.Color.AliceBlue;
            this.cbox_Ispostava.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "PoreznaIspostava", true));
            this.cbox_Ispostava.DataSource = this.IspostavebindingSource;
            this.cbox_Ispostava.DisplayMember = "nazivIspostave";
            this.cbox_Ispostava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Ispostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Ispostava.ForeColor = System.Drawing.Color.Navy;
            this.cbox_Ispostava.FormattingEnabled = true;
            this.cbox_Ispostava.Location = new System.Drawing.Point(153, 78);
            this.cbox_Ispostava.Name = "cbox_Ispostava";
            this.cbox_Ispostava.Size = new System.Drawing.Size(243, 22);
            this.cbox_Ispostava.TabIndex = 44;
            this.cbox_Ispostava.ValueMember = "sifraIspostave";
            // 
            // txt_OIB
            // 
            this.txt_OIB.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_OIB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OIB.ForeColor = System.Drawing.Color.Navy;
            this.txt_OIB.Location = new System.Drawing.Point(153, 158);
            this.txt_OIB.Name = "txt_OIB";
            this.txt_OIB.Size = new System.Drawing.Size(301, 22);
            this.txt_OIB.TabIndex = 45;
            this.txt_OIB.Leave += new System.EventHandler(this.txt_OIB_Leave);
            
            // 
            // txt_nazivObveznika
            // 
            this.txt_nazivObveznika.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_nazivObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nazivObveznika.ForeColor = System.Drawing.Color.Navy;
            this.txt_nazivObveznika.Location = new System.Drawing.Point(153, 186);
            this.txt_nazivObveznika.Name = "txt_nazivObveznika";
            this.txt_nazivObveznika.Size = new System.Drawing.Size(427, 22);
            this.txt_nazivObveznika.TabIndex = 46;
            // 
            // txt_adresa
            // 
            this.txt_adresa.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_adresa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresa.ForeColor = System.Drawing.Color.Navy;
            this.txt_adresa.Location = new System.Drawing.Point(154, 215);
            this.txt_adresa.Multiline = true;
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(427, 63);
            this.txt_adresa.TabIndex = 47;
            // 
            // cbox_sifraDjelatnosti
            // 
            this.cbox_sifraDjelatnosti.BackColor = System.Drawing.Color.FloralWhite;
            this.cbox_sifraDjelatnosti.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Djelatnost", true));
            this.cbox_sifraDjelatnosti.DataSource = this.DjelatnostbindingSource;
            this.cbox_sifraDjelatnosti.DisplayMember = "nazivDjelatnosti";
            this.cbox_sifraDjelatnosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_sifraDjelatnosti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_sifraDjelatnosti.ForeColor = System.Drawing.Color.Navy;
            this.cbox_sifraDjelatnosti.FormattingEnabled = true;
            this.cbox_sifraDjelatnosti.Location = new System.Drawing.Point(154, 316);
            this.cbox_sifraDjelatnosti.Name = "cbox_sifraDjelatnosti";
            this.cbox_sifraDjelatnosti.Size = new System.Drawing.Size(427, 22);
            this.cbox_sifraDjelatnosti.TabIndex = 50;
            this.cbox_sifraDjelatnosti.ValueMember = "sifraDjelatnosti";
            // 
            // txt_telefon
            // 
            this.txt_telefon.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_telefon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefon.ForeColor = System.Drawing.Color.Navy;
            this.txt_telefon.Location = new System.Drawing.Point(154, 374);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(304, 22);
            this.txt_telefon.TabIndex = 51;
          
            // 
            // txt_eMail
            // 
            this.txt_eMail.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_eMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eMail.ForeColor = System.Drawing.Color.Navy;
            this.txt_eMail.Location = new System.Drawing.Point(154, 402);
            this.txt_eMail.Name = "txt_eMail";
            this.txt_eMail.Size = new System.Drawing.Size(304, 22);
            this.txt_eMail.TabIndex = 52;
            this.txt_eMail.Leave += new System.EventHandler(this.txt_eMail_Leave);
            // 
            // cbox_vlasnistvo
            // 
            this.cbox_vlasnistvo.BackColor = System.Drawing.Color.FloralWhite;
            this.cbox_vlasnistvo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "OblikVlasnistva", true));
            this.cbox_vlasnistvo.DataSource = this.VlasnistvobindingSource;
            this.cbox_vlasnistvo.DisplayMember = "opisVlasnnistva";
            this.cbox_vlasnistvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_vlasnistvo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_vlasnistvo.ForeColor = System.Drawing.Color.Navy;
            this.cbox_vlasnistvo.FormattingEnabled = true;
            this.cbox_vlasnistvo.Location = new System.Drawing.Point(154, 436);
            this.cbox_vlasnistvo.Name = "cbox_vlasnistvo";
            this.cbox_vlasnistvo.Size = new System.Drawing.Size(229, 22);
            this.cbox_vlasnistvo.TabIndex = 53;
            this.cbox_vlasnistvo.ValueMember = "sifraVlasnistva";
            // 
            // cbox_Obveza
            // 
            this.cbox_Obveza.BackColor = System.Drawing.Color.FloralWhite;
            this.cbox_Obveza.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "VrstaObveze", true));
            this.cbox_Obveza.DataSource = this.ObvezabindingSource;
            this.cbox_Obveza.DisplayMember = "opisObveze";
            this.cbox_Obveza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Obveza.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Obveza.ForeColor = System.Drawing.Color.Navy;
            this.cbox_Obveza.FormattingEnabled = true;
            this.cbox_Obveza.Location = new System.Drawing.Point(153, 469);
            this.cbox_Obveza.Name = "cbox_Obveza";
            this.cbox_Obveza.Size = new System.Drawing.Size(229, 22);
            this.cbox_Obveza.TabIndex = 54;
            this.cbox_Obveza.ValueMember = "sifraObveze";
            // 
            // txt_korisnickoIme
            // 
            this.txt_korisnickoIme.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_korisnickoIme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_korisnickoIme.ForeColor = System.Drawing.Color.Navy;
            this.txt_korisnickoIme.Location = new System.Drawing.Point(118, 554);
            this.txt_korisnickoIme.Name = "txt_korisnickoIme";
            this.txt_korisnickoIme.Size = new System.Drawing.Size(174, 22);
            this.txt_korisnickoIme.TabIndex = 55;
            // 
            // txt_Zaporka
            // 
            this.txt_Zaporka.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_Zaporka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Zaporka.ForeColor = System.Drawing.Color.Navy;
            this.txt_Zaporka.Location = new System.Drawing.Point(118, 588);
            this.txt_Zaporka.Name = "txt_Zaporka";
            this.txt_Zaporka.Size = new System.Drawing.Size(174, 22);
            this.txt_Zaporka.TabIndex = 56;
            // 
            // cbox_aktivnost
            // 
            this.cbox_aktivnost.BackColor = System.Drawing.Color.FloralWhite;
            this.cbox_aktivnost.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Status", true));
            this.cbox_aktivnost.DataSource = this.tblsifarnikAktivnostiBindingSource;
            this.cbox_aktivnost.DisplayMember = "opis aktivnosti";
            this.cbox_aktivnost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_aktivnost.ForeColor = System.Drawing.Color.Crimson;
            this.cbox_aktivnost.FormattingEnabled = true;
            this.cbox_aktivnost.Location = new System.Drawing.Point(118, 621);
            this.cbox_aktivnost.Name = "cbox_aktivnost";
            this.cbox_aktivnost.Size = new System.Drawing.Size(122, 22);
            this.cbox_aktivnost.TabIndex = 58;
            this.cbox_aktivnost.ValueMember = "sifraAktivnosti";
          
            // 
            // txt_podrucni
            // 
            this.txt_podrucni.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_podrucni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PodrucnibindingSource, "sifraPodrucnogUreda", true));
            this.txt_podrucni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_podrucni.ForeColor = System.Drawing.Color.Orange;
            this.txt_podrucni.Location = new System.Drawing.Point(413, 49);
            this.txt_podrucni.Name = "txt_podrucni";
            this.txt_podrucni.Size = new System.Drawing.Size(61, 22);
            this.txt_podrucni.TabIndex = 59;
            this.txt_podrucni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Ispostava
            // 
            this.txt_Ispostava.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Ispostava.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IspostavebindingSource, "sifraIspostave", true));
            this.txt_Ispostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ispostava.ForeColor = System.Drawing.Color.Orange;
            this.txt_Ispostava.Location = new System.Drawing.Point(413, 81);
            this.txt_Ispostava.Name = "txt_Ispostava";
            this.txt_Ispostava.Size = new System.Drawing.Size(61, 22);
            this.txt_Ispostava.TabIndex = 60;
            this.txt_Ispostava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Zemlja
            // 
            this.txt_Zemlja.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Zemlja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ZemljabindingSource, "sifraZemlje", true));
            this.txt_Zemlja.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Zemlja.ForeColor = System.Drawing.Color.Orange;
            this.txt_Zemlja.Location = new System.Drawing.Point(367, 283);
            this.txt_Zemlja.Name = "txt_Zemlja";
            this.txt_Zemlja.Size = new System.Drawing.Size(61, 22);
            this.txt_Zemlja.TabIndex = 61;
            this.txt_Zemlja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Država", true));
            this.comboBox1.DataSource = this.ZemljabindingSource;
            this.comboBox1.DisplayMember = "nazivZemlje";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Navy;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 22);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "sifraZemlje";
            // 
            // txt_Djelatnost
            // 
            this.txt_Djelatnost.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Djelatnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DjelatnostbindingSource, "sifraDjelatnosti", true));
            this.txt_Djelatnost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Djelatnost.ForeColor = System.Drawing.Color.Orange;
            this.txt_Djelatnost.Location = new System.Drawing.Point(154, 346);
            this.txt_Djelatnost.Name = "txt_Djelatnost";
            this.txt_Djelatnost.Size = new System.Drawing.Size(61, 22);
            this.txt_Djelatnost.TabIndex = 63;
            this.txt_Djelatnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_status.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_status.Location = new System.Drawing.Point(342, 541);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(71, 15);
            this.txt_status.TabIndex = 64;
            this.txt_status.Visible = false;
            
            // 
            // btn_SpremiPorObv
            // 
            this.btn_SpremiPorObv.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_SpremiPorObv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SpremiPorObv.Location = new System.Drawing.Point(313, 537);
            this.btn_SpremiPorObv.Name = "btn_SpremiPorObv";
            this.btn_SpremiPorObv.Size = new System.Drawing.Size(100, 45);
            this.btn_SpremiPorObv.TabIndex = 65;
            this.btn_SpremiPorObv.Text = "Spremi";
            this.btn_SpremiPorObv.UseVisualStyleBackColor = false;
            this.btn_SpremiPorObv.Click += new System.EventHandler(this.btn_SpremiPorObv_Click);
            // 
            // btm_dodajNovi
            // 
            this.btm_dodajNovi.BackColor = System.Drawing.Color.Orange;
            this.btm_dodajNovi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_dodajNovi.Location = new System.Drawing.Point(313, 600);
            this.btm_dodajNovi.Name = "btm_dodajNovi";
            this.btm_dodajNovi.Size = new System.Drawing.Size(100, 45);
            this.btm_dodajNovi.TabIndex = 66;
            this.btm_dodajNovi.Text = "Dodaj novog obveznika";
            this.btm_dodajNovi.UseVisualStyleBackColor = false;
            this.btm_dodajNovi.Click += new System.EventHandler(this.btm_dodajNovi_Click);
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_zatvori.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zatvori.Location = new System.Drawing.Point(464, 537);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(100, 45);
            this.btn_zatvori.TabIndex = 67;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = false;
            this.btn_zatvori.Click += new System.EventHandler(this.btn_zatvori_Click);
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
            // txt_aktivnost
            // 
            this.txt_aktivnost.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_aktivnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsifarnikAktivnostiBindingSource, "sifraAktivnosti", true));
            this.txt_aktivnost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aktivnost.ForeColor = System.Drawing.Color.Orange;
            this.txt_aktivnost.Location = new System.Drawing.Point(244, 621);
            this.txt_aktivnost.Name = "txt_aktivnost";
            this.txt_aktivnost.Size = new System.Drawing.Size(48, 22);
            this.txt_aktivnost.TabIndex = 68;
            this.txt_aktivnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbl_porezniObveznikBindingSource
            // 
            this.tbl_porezniObveznikBindingSource.DataMember = "tbl_porezniObveznik";
            this.tbl_porezniObveznikBindingSource.DataSource = this.ds_porezniObveznik;
            this.tbl_porezniObveznikBindingSource.CurrentChanged += new System.EventHandler(this.tbl_porezniObveznikBindingSource_CurrentChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_unosNovogObveznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(592, 666);
            this.Controls.Add(this.txt_aktivnost);
            this.Controls.Add(this.btn_zatvori);
            this.Controls.Add(this.btm_dodajNovi);
            this.Controls.Add(this.btn_SpremiPorObv);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_Djelatnost);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Zemlja);
            this.Controls.Add(this.txt_Ispostava);
            this.Controls.Add(this.txt_podrucni);
            this.Controls.Add(this.cbox_aktivnost);
            this.Controls.Add(lbl_status);
            this.Controls.Add(this.txt_Zaporka);
            this.Controls.Add(this.txt_korisnickoIme);
            this.Controls.Add(this.cbox_Obveza);
            this.Controls.Add(this.cbox_vlasnistvo);
            this.Controls.Add(this.txt_eMail);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.cbox_sifraDjelatnosti);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_nazivObveznika);
            this.Controls.Add(this.txt_OIB);
            this.Controls.Add(this.cbox_Ispostava);
            this.Controls.Add(this.cbox_podrucni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifraObveze);
            this.Controls.Add(this.txt_sifraVlasnistva);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(lbl_oIBLabel);
            this.Controls.Add(lbl_podrucniUred);
            this.Controls.Add(lbl_poreznaIspostava);
            this.Controls.Add(lbl_nazivObveznika);
            this.Controls.Add(lbl_adresaLabel);
            this.Controls.Add(lbl_državaLabel);
            this.Controls.Add(lbl_djelatnostLabel);
            this.Controls.Add(lbl_telefonLabel);
            this.Controls.Add(lbl_e_mailLabel);
            this.Controls.Add(lbl_oblikVlasnistvaLabel);
            this.Controls.Add(lbl_vrstaObvezeLabel);
            this.Controls.Add(lbl_korisnickoIme);
            this.Controls.Add(lbl_zaporka);
            this.Controls.Add(lbl_datum);
            this.Controls.Add(this.dt_datumDateTimePicker);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 40);
            this.Name = "frm_unosNovogObveznika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVI POREZNI OBVEZNIK";
            this.Load += new System.EventHandler(this.frm_UnosNovogObveznika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodrucnibindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IspostavebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnostbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VlasnistvobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObvezabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsifarnikAktivnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds_porezniObveznik ds_porezniObveznik;
        private System.Windows.Forms.BindingSource tbl_porezniObveznikBindingSource;
        private ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter tbl_porezniObveznikTableAdapter;
        private ds_porezniObveznikTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dt_datumDateTimePicker;
        private System.Windows.Forms.BindingSource PodrucnibindingSource;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter tbl_sifarnikPodrucnihUredaTableAdapter;
        private System.Windows.Forms.BindingSource IspostavebindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter tbl_sifarnikIspostavaTableAdapter;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.BindingSource ZemljabindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter tbl_sifarnikZemljaTableAdapter;
        private System.Windows.Forms.BindingSource DjelatnostbindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikDjelatnostiTableAdapter tbl_sifarnikDjelatnostiTableAdapter;
        private System.Windows.Forms.BindingSource VlasnistvobindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikVlasnistvaTableAdapter tbl_sifarnikVlasnistvaTableAdapter;
        private System.Windows.Forms.BindingSource ObvezabindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikObvezeTableAdapter tbl_sifarnikObvezeTableAdapter;
        private System.Windows.Forms.TextBox txt_sifraVlasnistva;
        private System.Windows.Forms.TextBox txt_sifraObveze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_podrucni;
        private System.Windows.Forms.ComboBox cbox_Ispostava;
        private System.Windows.Forms.TextBox txt_OIB;
        private System.Windows.Forms.TextBox txt_nazivObveznika;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.ComboBox cbox_sifraDjelatnosti;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_eMail;
        private System.Windows.Forms.ComboBox cbox_vlasnistvo;
        private System.Windows.Forms.ComboBox cbox_Obveza;
        private System.Windows.Forms.TextBox txt_korisnickoIme;
        private System.Windows.Forms.TextBox txt_Zaporka;
        private System.Windows.Forms.ComboBox cbox_aktivnost;
        private System.Windows.Forms.TextBox txt_podrucni;
        private System.Windows.Forms.TextBox txt_Ispostava;
        private System.Windows.Forms.TextBox txt_Zemlja;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Djelatnost;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_SpremiPorObv;
        private System.Windows.Forms.Button btm_dodajNovi;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.BindingSource tblsifarnikAktivnostiBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikAktivnostiTableAdapter tbl_sifarnikAktivnostiTableAdapter;
        private System.Windows.Forms.TextBox txt_aktivnost;
    }
}