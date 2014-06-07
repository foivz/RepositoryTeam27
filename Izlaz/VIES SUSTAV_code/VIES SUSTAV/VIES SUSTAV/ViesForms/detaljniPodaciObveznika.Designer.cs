namespace VIES_SUSTAV.ViesForms
{
    partial class frm_detaljniPodaciObveznika
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
            System.Windows.Forms.Label korisnickoImeLabel;
            System.Windows.Forms.Label zaporkaLabel;
            System.Windows.Forms.Label datumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_detaljniPodaciObveznika));
            System.Windows.Forms.Label statusLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_porezniObveznikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.PodrucnibindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_sifarnikPodrucnihUredaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter();
            this.tbl_sifarnikVlasnistvaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikVlasnistvaTableAdapter();
            this.IspostavebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObvezabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VlasnistvobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikObvezeTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikObvezeTableAdapter();
            this.tbl_sifarnikDjelatnostiTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikDjelatnostiTableAdapter();
            this.tbl_sifarnikIspostavaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter();
            this.DjelatnostbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZemljabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_sifarnikZemljaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter();
            this.txt_sifraObveze = new System.Windows.Forms.TextBox();
            this.txt_sifraVlasnistva = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tbl_porezniObveznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_porezniObveznik = new VIES_SUSTAV.ds_porezniObveznik();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txt_ZemljaNaziv = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.cbox_ispostave = new System.Windows.Forms.ComboBox();
            this.cbox_podrucniUred = new System.Windows.Forms.ComboBox();
            this.txt_OIB = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.nazivObveznikaTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.tbl_porezniObveznikTableAdapter = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_porezniObveznikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.zaporkaTextBox = new System.Windows.Forms.TextBox();
            this.dt_datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
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
            korisnickoImeLabel = new System.Windows.Forms.Label();
            zaporkaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PodrucnibindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IspostavebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObvezabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VlasnistvobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnostbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingNavigator)).BeginInit();
            this.tbl_porezniObveznikBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_oIBLabel
            // 
            lbl_oIBLabel.AutoSize = true;
            lbl_oIBLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_oIBLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_oIBLabel.Location = new System.Drawing.Point(22, 159);
            lbl_oIBLabel.Name = "lbl_oIBLabel";
            lbl_oIBLabel.Size = new System.Drawing.Size(33, 14);
            lbl_oIBLabel.TabIndex = 44;
            lbl_oIBLabel.Text = "OIB:";
            // 
            // lbl_podrucniUred
            // 
            lbl_podrucniUred.AutoSize = true;
            lbl_podrucniUred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_podrucniUred.ForeColor = System.Drawing.Color.Navy;
            lbl_podrucniUred.Location = new System.Drawing.Point(12, 52);
            lbl_podrucniUred.Name = "lbl_podrucniUred";
            lbl_podrucniUred.Size = new System.Drawing.Size(117, 14);
            lbl_podrucniUred.TabIndex = 46;
            lbl_podrucniUred.Text = "Područni Ured PU:";
            // 
            // lbl_poreznaIspostava
            // 
            lbl_poreznaIspostava.AutoSize = true;
            lbl_poreznaIspostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_poreznaIspostava.ForeColor = System.Drawing.Color.Navy;
            lbl_poreznaIspostava.Location = new System.Drawing.Point(12, 77);
            lbl_poreznaIspostava.Name = "lbl_poreznaIspostava";
            lbl_poreznaIspostava.Size = new System.Drawing.Size(124, 14);
            lbl_poreznaIspostava.TabIndex = 47;
            lbl_poreznaIspostava.Text = "Porezna Ispostava:";
            // 
            // lbl_nazivObveznika
            // 
            lbl_nazivObveznika.AutoSize = true;
            lbl_nazivObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_nazivObveznika.ForeColor = System.Drawing.Color.Navy;
            lbl_nazivObveznika.Location = new System.Drawing.Point(22, 189);
            lbl_nazivObveznika.Name = "lbl_nazivObveznika";
            lbl_nazivObveznika.Size = new System.Drawing.Size(107, 14);
            lbl_nazivObveznika.TabIndex = 48;
            lbl_nazivObveznika.Text = "Naziv obveznika:";
            // 
            // lbl_adresaLabel
            // 
            lbl_adresaLabel.AutoSize = true;
            lbl_adresaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_adresaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_adresaLabel.Location = new System.Drawing.Point(22, 219);
            lbl_adresaLabel.Name = "lbl_adresaLabel";
            lbl_adresaLabel.Size = new System.Drawing.Size(53, 14);
            lbl_adresaLabel.TabIndex = 50;
            lbl_adresaLabel.Text = "Adresa:";
            // 
            // lbl_državaLabel
            // 
            lbl_državaLabel.AutoSize = true;
            lbl_državaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_državaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_državaLabel.Location = new System.Drawing.Point(22, 282);
            lbl_državaLabel.Name = "lbl_državaLabel";
            lbl_državaLabel.Size = new System.Drawing.Size(52, 14);
            lbl_državaLabel.TabIndex = 52;
            lbl_državaLabel.Text = "Država:";
            // 
            // lbl_djelatnostLabel
            // 
            lbl_djelatnostLabel.AutoSize = true;
            lbl_djelatnostLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_djelatnostLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_djelatnostLabel.Location = new System.Drawing.Point(22, 312);
            lbl_djelatnostLabel.Name = "lbl_djelatnostLabel";
            lbl_djelatnostLabel.Size = new System.Drawing.Size(75, 14);
            lbl_djelatnostLabel.TabIndex = 53;
            lbl_djelatnostLabel.Text = "Djelatnost:";
            // 
            // lbl_telefonLabel
            // 
            lbl_telefonLabel.AutoSize = true;
            lbl_telefonLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_telefonLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_telefonLabel.Location = new System.Drawing.Point(22, 378);
            lbl_telefonLabel.Name = "lbl_telefonLabel";
            lbl_telefonLabel.Size = new System.Drawing.Size(56, 14);
            lbl_telefonLabel.TabIndex = 54;
            lbl_telefonLabel.Text = "Telefon:";
            // 
            // lbl_e_mailLabel
            // 
            lbl_e_mailLabel.AutoSize = true;
            lbl_e_mailLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_e_mailLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_e_mailLabel.Location = new System.Drawing.Point(22, 406);
            lbl_e_mailLabel.Name = "lbl_e_mailLabel";
            lbl_e_mailLabel.Size = new System.Drawing.Size(46, 14);
            lbl_e_mailLabel.TabIndex = 56;
            lbl_e_mailLabel.Text = "e mail:";
            // 
            // lbl_oblikVlasnistvaLabel
            // 
            lbl_oblikVlasnistvaLabel.AutoSize = true;
            lbl_oblikVlasnistvaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_oblikVlasnistvaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_oblikVlasnistvaLabel.Location = new System.Drawing.Point(14, 440);
            lbl_oblikVlasnistvaLabel.Name = "lbl_oblikVlasnistvaLabel";
            lbl_oblikVlasnistvaLabel.Size = new System.Drawing.Size(106, 14);
            lbl_oblikVlasnistvaLabel.TabIndex = 58;
            lbl_oblikVlasnistvaLabel.Text = "Oblik Vlasnistva:";
            // 
            // lbl_vrstaObvezeLabel
            // 
            lbl_vrstaObvezeLabel.AutoSize = true;
            lbl_vrstaObvezeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_vrstaObvezeLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_vrstaObvezeLabel.Location = new System.Drawing.Point(14, 468);
            lbl_vrstaObvezeLabel.Name = "lbl_vrstaObvezeLabel";
            lbl_vrstaObvezeLabel.Size = new System.Drawing.Size(91, 14);
            lbl_vrstaObvezeLabel.TabIndex = 59;
            lbl_vrstaObvezeLabel.Text = "Vrsta Obveze:";
            // 
            // korisnickoImeLabel
            // 
            korisnickoImeLabel.AutoSize = true;
            korisnickoImeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            korisnickoImeLabel.ForeColor = System.Drawing.Color.Navy;
            korisnickoImeLabel.Location = new System.Drawing.Point(12, 533);
            korisnickoImeLabel.Name = "korisnickoImeLabel";
            korisnickoImeLabel.Size = new System.Drawing.Size(100, 14);
            korisnickoImeLabel.TabIndex = 60;
            korisnickoImeLabel.Text = "Korisnicko Ime:";
            // 
            // zaporkaLabel
            // 
            zaporkaLabel.AutoSize = true;
            zaporkaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zaporkaLabel.ForeColor = System.Drawing.Color.Navy;
            zaporkaLabel.Location = new System.Drawing.Point(12, 559);
            zaporkaLabel.Name = "zaporkaLabel";
            zaporkaLabel.Size = new System.Drawing.Size(60, 14);
            zaporkaLabel.TabIndex = 62;
            zaporkaLabel.Text = "Zaporka:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datumLabel.ForeColor = System.Drawing.Color.Navy;
            datumLabel.Location = new System.Drawing.Point(362, 533);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(52, 14);
            datumLabel.TabIndex = 64;
            datumLabel.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "Podaci o poreznom obvezniku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_porezniObveznikBindingNavigatorSaveItem
            // 
            this.tbl_porezniObveznikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_porezniObveznikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_porezniObveznikBindingNavigatorSaveItem.Image")));
            this.tbl_porezniObveznikBindingNavigatorSaveItem.Name = "tbl_porezniObveznikBindingNavigatorSaveItem";
            this.tbl_porezniObveznikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_porezniObveznikBindingNavigatorSaveItem.Text = "Save Data";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "-------------------------------------------------------------\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbl_sifarnikPodrucnihUredaTableAdapter
            // 
            this.tbl_sifarnikPodrucnihUredaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_sifarnikVlasnistvaTableAdapter
            // 
            this.tbl_sifarnikVlasnistvaTableAdapter.ClearBeforeFill = true;
            // 
            // IspostavebindingSource
            // 
            this.IspostavebindingSource.DataMember = "tbl_sifarnikIspostava";
            this.IspostavebindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ObvezabindingSource
            // 
            this.ObvezabindingSource.DataMember = "tbl_sifarnikObveze";
            this.ObvezabindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // VlasnistvobindingSource
            // 
            this.VlasnistvobindingSource.DataMember = "tbl_sifarnikVlasnistva";
            this.VlasnistvobindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikObvezeTableAdapter
            // 
            this.tbl_sifarnikObvezeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_sifarnikDjelatnostiTableAdapter
            // 
            this.tbl_sifarnikDjelatnostiTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_sifarnikIspostavaTableAdapter
            // 
            this.tbl_sifarnikIspostavaTableAdapter.ClearBeforeFill = true;
            // 
            // DjelatnostbindingSource
            // 
            this.DjelatnostbindingSource.DataMember = "tbl_sifarnikDjelatnosti";
            this.DjelatnostbindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ZemljabindingSource
            // 
            this.ZemljabindingSource.DataMember = "tbl_sifarnikZemlja";
            this.ZemljabindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // tbl_sifarnikZemljaTableAdapter
            // 
            this.tbl_sifarnikZemljaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_sifraObveze
            // 
            this.txt_sifraObveze.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_sifraObveze.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ObvezabindingSource, "sifraObveze", true));
            this.txt_sifraObveze.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifraObveze.ForeColor = System.Drawing.Color.Orange;
            this.txt_sifraObveze.Location = new System.Drawing.Point(394, 459);
            this.txt_sifraObveze.Name = "txt_sifraObveze";
            this.txt_sifraObveze.Size = new System.Drawing.Size(63, 22);
            this.txt_sifraObveze.TabIndex = 76;
            this.txt_sifraObveze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sifraVlasnistva
            // 
            this.txt_sifraVlasnistva.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_sifraVlasnistva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VlasnistvobindingSource, "sifraVlasnistva", true));
            this.txt_sifraVlasnistva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifraVlasnistva.ForeColor = System.Drawing.Color.Orange;
            this.txt_sifraVlasnistva.Location = new System.Drawing.Point(393, 433);
            this.txt_sifraVlasnistva.Name = "txt_sifraVlasnistva";
            this.txt_sifraVlasnistva.Size = new System.Drawing.Size(63, 22);
            this.txt_sifraVlasnistva.TabIndex = 75;
            this.txt_sifraVlasnistva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "VrstaObveze", true));
            this.comboBox4.DataSource = this.ObvezabindingSource;
            this.comboBox4.DisplayMember = "opisObveze";
            this.comboBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.Navy;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(154, 459);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(229, 22);
            this.comboBox4.TabIndex = 74;
            this.comboBox4.ValueMember = "sifraObveze";
            // 
            // tbl_porezniObveznikBindingSource
            // 
            this.tbl_porezniObveznikBindingSource.DataMember = "tbl_porezniObveznik";
            this.tbl_porezniObveznikBindingSource.DataSource = this.ds_porezniObveznik;
            // 
            // ds_porezniObveznik
            // 
            this.ds_porezniObveznik.DataSetName = "ds_porezniObveznik";
            this.ds_porezniObveznik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "OblikVlasnistva", true));
            this.comboBox3.DataSource = this.VlasnistvobindingSource;
            this.comboBox3.DisplayMember = "opisVlasnnistva";
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.Navy;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(154, 431);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 22);
            this.comboBox3.TabIndex = 73;
            this.comboBox3.ValueMember = "sifraVlasnistva";
            // 
            // txt_ZemljaNaziv
            // 
            this.txt_ZemljaNaziv.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_ZemljaNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ZemljabindingSource, "nazivZemlje", true));
            this.txt_ZemljaNaziv.ForeColor = System.Drawing.Color.Navy;
            this.txt_ZemljaNaziv.Location = new System.Drawing.Point(155, 281);
            this.txt_ZemljaNaziv.Name = "txt_ZemljaNaziv";
            this.txt_ZemljaNaziv.Size = new System.Drawing.Size(301, 20);
            this.txt_ZemljaNaziv.TabIndex = 72;
            this.txt_ZemljaNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DjelatnostbindingSource, "nazivDjelatnosti", true));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(154, 312);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 47);
            this.textBox1.TabIndex = 71;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Djelatnost", true));
            this.comboBox2.DataSource = this.DjelatnostbindingSource;
            this.comboBox2.DisplayMember = "sifraDjelatnosti";
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Navy;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 336);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 22);
            this.comboBox2.TabIndex = 70;
            this.comboBox2.ValueMember = "sifraDjelatnosti";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "Država", true));
            this.comboBox1.DataSource = this.ZemljabindingSource;
            this.comboBox1.DisplayMember = "sifraZemlje";
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Navy;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 22);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.ValueMember = "sifraZemlje";
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(0, 5);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(592, 24);
            this.lbl_poreznaUprava.TabIndex = 68;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_ispostave
            // 
            this.cbox_ispostave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_ispostave.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "PoreznaIspostava", true));
            this.cbox_ispostave.DataSource = this.IspostavebindingSource;
            this.cbox_ispostave.DisplayMember = "nazivIspostave";
            this.cbox_ispostave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_ispostave.ForeColor = System.Drawing.Color.Navy;
            this.cbox_ispostave.FormattingEnabled = true;
            this.cbox_ispostave.Location = new System.Drawing.Point(155, 75);
            this.cbox_ispostave.Name = "cbox_ispostave";
            this.cbox_ispostave.Size = new System.Drawing.Size(303, 22);
            this.cbox_ispostave.TabIndex = 67;
            this.cbox_ispostave.ValueMember = "sifraIspostave";
            // 
            // cbox_podrucniUred
            // 
            this.cbox_podrucniUred.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_podrucniUred.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_podrucniUred.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_porezniObveznikBindingSource, "PodrucniUredPU", true));
            this.cbox_podrucniUred.DataSource = this.PodrucnibindingSource;
            this.cbox_podrucniUred.DisplayMember = "nazivPodrucnogUreda";
            this.cbox_podrucniUred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_podrucniUred.ForeColor = System.Drawing.Color.Navy;
            this.cbox_podrucniUred.FormattingEnabled = true;
            this.cbox_podrucniUred.Location = new System.Drawing.Point(155, 43);
            this.cbox_podrucniUred.Name = "cbox_podrucniUred";
            this.cbox_podrucniUred.Size = new System.Drawing.Size(443, 22);
            this.cbox_podrucniUred.TabIndex = 66;
            this.cbox_podrucniUred.ValueMember = "sifraPodrucnogUreda";
            // 
            // txt_OIB
            // 
            this.txt_OIB.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_OIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "OIB", true));
            this.txt_OIB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OIB.ForeColor = System.Drawing.Color.Navy;
            this.txt_OIB.Location = new System.Drawing.Point(155, 150);
            this.txt_OIB.Name = "txt_OIB";
            this.txt_OIB.Size = new System.Drawing.Size(241, 22);
            this.txt_OIB.TabIndex = 45;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // nazivObveznikaTextBox
            // 
            this.nazivObveznikaTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.nazivObveznikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "NazivObveznika", true));
            this.nazivObveznikaTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivObveznikaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivObveznikaTextBox.Location = new System.Drawing.Point(155, 180);
            this.nazivObveznikaTextBox.Name = "nazivObveznikaTextBox";
            this.nazivObveznikaTextBox.Size = new System.Drawing.Size(303, 22);
            this.nazivObveznikaTextBox.TabIndex = 49;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Adresa", true));
            this.adresaTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.adresaTextBox.Location = new System.Drawing.Point(155, 210);
            this.adresaTextBox.Multiline = true;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(303, 57);
            this.adresaTextBox.TabIndex = 51;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Telefon", true));
            this.telefonTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonTextBox.ForeColor = System.Drawing.Color.Navy;
            this.telefonTextBox.Location = new System.Drawing.Point(154, 370);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(233, 22);
            this.telefonTextBox.TabIndex = 55;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "e_mail", true));
            this.e_mailTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mailTextBox.ForeColor = System.Drawing.Color.Navy;
            this.e_mailTextBox.Location = new System.Drawing.Point(154, 398);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(233, 22);
            this.e_mailTextBox.TabIndex = 57;
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbl_porezniObveznikBindingNavigator
            // 
            this.tbl_porezniObveznikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_porezniObveznikBindingNavigator.BindingSource = this.tbl_porezniObveznikBindingSource;
            this.tbl_porezniObveznikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_porezniObveznikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_porezniObveznikBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbl_porezniObveznikBindingNavigator.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_porezniObveznikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_porezniObveznikBindingNavigatorSaveItem});
            this.tbl_porezniObveznikBindingNavigator.Location = new System.Drawing.Point(0, 641);
            this.tbl_porezniObveznikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_porezniObveznikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_porezniObveznikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_porezniObveznikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_porezniObveznikBindingNavigator.Name = "tbl_porezniObveznikBindingNavigator";
            this.tbl_porezniObveznikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_porezniObveznikBindingNavigator.Size = new System.Drawing.Size(612, 25);
            this.tbl_porezniObveznikBindingNavigator.TabIndex = 43;
            this.tbl_porezniObveznikBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(46, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.korisnickoImeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "KorisnickoIme", true));
            this.korisnickoImeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeTextBox.ForeColor = System.Drawing.Color.Navy;
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(135, 525);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(156, 22);
            this.korisnickoImeTextBox.TabIndex = 61;
            // 
            // zaporkaTextBox
            // 
            this.zaporkaTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.zaporkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Zaporka", true));
            this.zaporkaTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaporkaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.zaporkaTextBox.Location = new System.Drawing.Point(135, 552);
            this.zaporkaTextBox.Name = "zaporkaTextBox";
            this.zaporkaTextBox.Size = new System.Drawing.Size(156, 22);
            this.zaporkaTextBox.TabIndex = 63;
            // 
            // dt_datumDateTimePicker
            // 
            this.dt_datumDateTimePicker.CalendarForeColor = System.Drawing.Color.Navy;
            this.dt_datumDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
            this.dt_datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_porezniObveznikBindingSource, "Datum", true));
            this.dt_datumDateTimePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_datumDateTimePicker.Location = new System.Drawing.Point(301, 555);
            this.dt_datumDateTimePicker.Name = "dt_datumDateTimePicker";
            this.dt_datumDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.dt_datumDateTimePicker.TabIndex = 65;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(97, 601);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 78;
            statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_porezniObveznikBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(143, 598);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 79;
            // 
            // frm_detaljniPodaciObveznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 666);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifraObveze);
            this.Controls.Add(this.txt_sifraVlasnistva);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.txt_ZemljaNaziv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(this.cbox_ispostave);
            this.Controls.Add(this.cbox_podrucniUred);
            this.Controls.Add(lbl_oIBLabel);
            this.Controls.Add(this.txt_OIB);
            this.Controls.Add(lbl_podrucniUred);
            this.Controls.Add(lbl_poreznaIspostava);
            this.Controls.Add(lbl_nazivObveznika);
            this.Controls.Add(this.nazivObveznikaTextBox);
            this.Controls.Add(lbl_adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(lbl_državaLabel);
            this.Controls.Add(lbl_djelatnostLabel);
            this.Controls.Add(lbl_telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(lbl_e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(lbl_oblikVlasnistvaLabel);
            this.Controls.Add(lbl_vrstaObvezeLabel);
            this.Controls.Add(this.tbl_porezniObveznikBindingNavigator);
            this.Controls.Add(korisnickoImeLabel);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(zaporkaLabel);
            this.Controls.Add(this.zaporkaTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.dt_datumDateTimePicker);
            this.Name = "frm_detaljniPodaciObveznika";
            this.Text = "Detaljni oodaci o obvezniku";
            this.Load += new System.EventHandler(this.frm_detaljniPodaciObveznika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PodrucnibindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IspostavebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObvezabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VlasnistvobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnostbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingNavigator)).EndInit();
            this.tbl_porezniObveznikBindingNavigator.ResumeLayout(false);
            this.tbl_porezniObveznikBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tbl_porezniObveznikBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource PodrucnibindingSource;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter tbl_sifarnikPodrucnihUredaTableAdapter;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikVlasnistvaTableAdapter tbl_sifarnikVlasnistvaTableAdapter;
        private System.Windows.Forms.BindingSource IspostavebindingSource;
        private System.Windows.Forms.BindingSource ObvezabindingSource;
        private System.Windows.Forms.BindingSource VlasnistvobindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikObvezeTableAdapter tbl_sifarnikObvezeTableAdapter;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikDjelatnostiTableAdapter tbl_sifarnikDjelatnostiTableAdapter;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter tbl_sifarnikIspostavaTableAdapter;
        private System.Windows.Forms.BindingSource DjelatnostbindingSource;
        private System.Windows.Forms.BindingSource ZemljabindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter tbl_sifarnikZemljaTableAdapter;
        private System.Windows.Forms.TextBox txt_sifraObveze;
        private System.Windows.Forms.TextBox txt_sifraVlasnistva;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource tbl_porezniObveznikBindingSource;
        private ds_porezniObveznik ds_porezniObveznik;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txt_ZemljaNaziv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.ComboBox cbox_ispostave;
        private System.Windows.Forms.ComboBox cbox_podrucniUred;
        private System.Windows.Forms.TextBox txt_OIB;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.TextBox nazivObveznikaTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter tbl_porezniObveznikTableAdapter;
        private ds_porezniObveznikTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingNavigator tbl_porezniObveznikBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox zaporkaTextBox;
        private System.Windows.Forms.DateTimePicker dt_datumDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}