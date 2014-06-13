namespace VIES_SUSTAV.VIESForms
{
    partial class frm_ProvjeraPDV_S
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_pripadajuciVIES = new System.Windows.Forms.Panel();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.txt_IDizvjesca = new System.Windows.Forms.TextBox();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.LookUpObveznikbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.nazivObveznikaTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.nazivIspostaveTextBox = new System.Windows.Forms.TextBox();
            this.nazivPodrucnogUredaTextBox = new System.Windows.Forms.TextBox();
            this.txt_razdoblje = new System.Windows.Forms.TextBox();
            this.lbl_NaslovVIES = new System.Windows.Forms.Label();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.tbl_ObveznikLookUpTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter();
            this.ds_PdvS = new VIES_SUSTAV.ds_PdvS();
            this.tbl_PdvSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PdvSTableAdapter = new VIES_SUSTAV.ds_PdvSTableAdapters.tbl_PdvSTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_PdvSTableAdapters.TableAdapterManager();
            this.tbl_PdvSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ZemljabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_sifarnikZemljaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter();
            this.lbl_ukupnoPDV_S = new System.Windows.Forms.Label();
            this.txt_ukupnoPdvS = new System.Windows.Forms.TextBox();
            this.btn_provjeri = new System.Windows.Forms.Button();
            lbl_nazivObveznika = new System.Windows.Forms.Label();
            lbl_adresaLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            lbl_podrucniUred = new System.Windows.Forms.Label();
            lbl_poreznaIspostava = new System.Windows.Forms.Label();
            this.pnl_pripadajuciVIES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpObveznikbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PdvS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PdvSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PdvSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            this.SuspendLayout();
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
            // pnl_pripadajuciVIES
            // 
            this.pnl_pripadajuciVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_pripadajuciVIES.Controls.Add(this.btn_provjeri);
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
            this.pnl_pripadajuciVIES.Location = new System.Drawing.Point(7, 40);
            this.pnl_pripadajuciVIES.Name = "pnl_pripadajuciVIES";
            this.pnl_pripadajuciVIES.Size = new System.Drawing.Size(586, 154);
            this.pnl_pripadajuciVIES.TabIndex = 47;
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.Location = new System.Drawing.Point(479, 3);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(100, 45);
            this.btn_zatvori.TabIndex = 82;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = true;
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
            this.oIBTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.oIBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "OIB", true));
            this.oIBTextBox.ForeColor = System.Drawing.Color.Navy;
            this.oIBTextBox.Location = new System.Drawing.Point(188, 74);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.ReadOnly = true;
            this.oIBTextBox.Size = new System.Drawing.Size(183, 15);
            this.oIBTextBox.TabIndex = 72;
            // 
            // LookUpObveznikbindingSource1
            // 
            this.LookUpObveznikbindingSource1.DataMember = "tbl_ObveznikLookUp";
            this.LookUpObveznikbindingSource1.DataSource = this.ds_T27;
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazivObveznikaTextBox
            // 
            this.nazivObveznikaTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nazivObveznikaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivObveznikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "NazivObveznika", true));
            this.nazivObveznikaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivObveznikaTextBox.Location = new System.Drawing.Point(188, 99);
            this.nazivObveznikaTextBox.Name = "nazivObveznikaTextBox";
            this.nazivObveznikaTextBox.ReadOnly = true;
            this.nazivObveznikaTextBox.Size = new System.Drawing.Size(283, 15);
            this.nazivObveznikaTextBox.TabIndex = 74;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.adresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "Adresa", true));
            this.adresaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.adresaTextBox.Location = new System.Drawing.Point(188, 129);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.ReadOnly = true;
            this.adresaTextBox.Size = new System.Drawing.Size(283, 15);
            this.adresaTextBox.TabIndex = 76;
            // 
            // nazivIspostaveTextBox
            // 
            this.nazivIspostaveTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nazivIspostaveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivIspostaveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "nazivIspostave", true));
            this.nazivIspostaveTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivIspostaveTextBox.Location = new System.Drawing.Point(188, 45);
            this.nazivIspostaveTextBox.Name = "nazivIspostaveTextBox";
            this.nazivIspostaveTextBox.ReadOnly = true;
            this.nazivIspostaveTextBox.Size = new System.Drawing.Size(183, 15);
            this.nazivIspostaveTextBox.TabIndex = 78;
            // 
            // nazivPodrucnogUredaTextBox
            // 
            this.nazivPodrucnogUredaTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nazivPodrucnogUredaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivPodrucnogUredaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "nazivPodrucnogUreda", true));
            this.nazivPodrucnogUredaTextBox.ForeColor = System.Drawing.Color.Navy;
            this.nazivPodrucnogUredaTextBox.Location = new System.Drawing.Point(188, 16);
            this.nazivPodrucnogUredaTextBox.Name = "nazivPodrucnogUredaTextBox";
            this.nazivPodrucnogUredaTextBox.ReadOnly = true;
            this.nazivPodrucnogUredaTextBox.Size = new System.Drawing.Size(183, 15);
            this.nazivPodrucnogUredaTextBox.TabIndex = 80;
            // 
            // txt_razdoblje
            // 
            this.txt_razdoblje.BackColor = System.Drawing.Color.Orange;
            this.txt_razdoblje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_razdoblje.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razdoblje.ForeColor = System.Drawing.Color.Navy;
            this.txt_razdoblje.Location = new System.Drawing.Point(305, 222);
            this.txt_razdoblje.Name = "txt_razdoblje";
            this.txt_razdoblje.ReadOnly = true;
            this.txt_razdoblje.Size = new System.Drawing.Size(82, 13);
            this.txt_razdoblje.TabIndex = 52;
            this.txt_razdoblje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_NaslovVIES
            // 
            this.lbl_NaslovVIES.BackColor = System.Drawing.Color.Orange;
            this.lbl_NaslovVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NaslovVIES.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NaslovVIES.ForeColor = System.Drawing.Color.Navy;
            this.lbl_NaslovVIES.Location = new System.Drawing.Point(3, 199);
            this.lbl_NaslovVIES.Name = "lbl_NaslovVIES";
            this.lbl_NaslovVIES.Size = new System.Drawing.Size(590, 44);
            this.lbl_NaslovVIES.TabIndex = 51;
            this.lbl_NaslovVIES.Text = "MJESEČNI IZVJEŠTAJ PDV-S\r\nza razdoblje                ";
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
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(590, 24);
            this.lbl_poreznaUprava.TabIndex = 50;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_ObveznikLookUpTableAdapter
            // 
            this.tbl_ObveznikLookUpTableAdapter.ClearBeforeFill = true;
            // 
            // ds_PdvS
            // 
            this.ds_PdvS.DataSetName = "ds_PdvS";
            this.ds_PdvS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PdvSBindingSource
            // 
            this.tbl_PdvSBindingSource.DataMember = "tbl_PdvS";
            this.tbl_PdvSBindingSource.DataSource = this.ds_PdvS;
            // 
            // tbl_PdvSTableAdapter
            // 
            this.tbl_PdvSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_PdvSTableAdapter = this.tbl_PdvSTableAdapter;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_PdvSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_PdvSDataGridView
            // 
            this.tbl_PdvSDataGridView.AutoGenerateColumns = false;
            this.tbl_PdvSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_PdvSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbl_PdvSDataGridView.DataSource = this.tbl_PdvSBindingSource;
            this.tbl_PdvSDataGridView.Location = new System.Drawing.Point(12, 246);
            this.tbl_PdvSDataGridView.Name = "tbl_PdvSDataGridView";
            this.tbl_PdvSDataGridView.Size = new System.Drawing.Size(581, 200);
            this.tbl_PdvSDataGridView.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_VIES";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Evidencijski broj";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Evidencijski broj zaprimanja VIES izvještaja.";
            this.dataGridViewTextBoxColumn2.Width = 119;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Zemlja_isporuke";
            this.dataGridViewTextBoxColumn3.DataSource = this.ZemljabindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nazivZemlje";
            this.dataGridViewTextBoxColumn3.HeaderText = "Zemlja isporuke";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Zemlja iz koje je roba isporučena";
            this.dataGridViewTextBoxColumn3.ValueMember = "sifraZemlje";
            this.dataGridViewTextBoxColumn3.Width = 116;
            // 
            // ZemljabindingSource
            // 
            this.ZemljabindingSource.DataMember = "tbl_sifarnikZemlja";
            this.ZemljabindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ds_sifarnici_lookUp
            // 
            this.ds_sifarnici_lookUp.DataSetName = "ds_sifarnici_lookUp";
            this.ds_sifarnici_lookUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EU_isporucitelj";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID INO isporučitelja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Vat broj stranog dobavljača";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vrijednost_stjecanja";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Vrijednost stjecanja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Vrijednost sa ino faktura, bez poreza u kunama. Cijeli broj, bez decimala.";
            // 
            // tbl_sifarnikZemljaTableAdapter
            // 
            this.tbl_sifarnikZemljaTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_ukupnoPDV_S
            // 
            this.lbl_ukupnoPDV_S.AutoSize = true;
            this.lbl_ukupnoPDV_S.Location = new System.Drawing.Point(194, 464);
            this.lbl_ukupnoPDV_S.Name = "lbl_ukupnoPDV_S";
            this.lbl_ukupnoPDV_S.Size = new System.Drawing.Size(212, 14);
            this.lbl_ukupnoPDV_S.TabIndex = 53;
            this.lbl_ukupnoPDV_S.Text = "UKUPNA VRIJEDNOST STJECANJA:";
            // 
            // txt_ukupnoPdvS
            // 
            this.txt_ukupnoPdvS.Location = new System.Drawing.Point(412, 461);
            this.txt_ukupnoPdvS.Name = "txt_ukupnoPdvS";
            this.txt_ukupnoPdvS.Size = new System.Drawing.Size(181, 22);
            this.txt_ukupnoPdvS.TabIndex = 54;
            // 
            // btn_provjeri
            // 
            this.btn_provjeri.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_provjeri.Location = new System.Drawing.Point(446, 69);
            this.btn_provjeri.Name = "btn_provjeri";
            this.btn_provjeri.Size = new System.Drawing.Size(131, 45);
            this.btn_provjeri.TabIndex = 83;
            this.btn_provjeri.Text = "Provjeri izvještaj";
            this.btn_provjeri.UseVisualStyleBackColor = false;
            this.btn_provjeri.Click += new System.EventHandler(this.btn_provjeri_Click);
            // 
            // frm_ProvjeraPDV_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(613, 536);
            this.Controls.Add(this.txt_ukupnoPdvS);
            this.Controls.Add(this.lbl_ukupnoPDV_S);
            this.Controls.Add(this.tbl_PdvSDataGridView);
            this.Controls.Add(this.txt_razdoblje);
            this.Controls.Add(this.lbl_NaslovVIES);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(this.pnl_pripadajuciVIES);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_ProvjeraPDV_S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provjera PDV-S izvještaja";
            this.Load += new System.EventHandler(this.frm_ProvjeraPDV_S_Load);
            this.pnl_pripadajuciVIES.ResumeLayout(false);
            this.pnl_pripadajuciVIES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpObveznikbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PdvS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PdvSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PdvSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_pripadajuciVIES;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.TextBox txt_IDizvjesca;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.TextBox nazivObveznikaTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox nazivIspostaveTextBox;
        private System.Windows.Forms.TextBox nazivPodrucnogUredaTextBox;
        private System.Windows.Forms.TextBox txt_razdoblje;
        private System.Windows.Forms.Label lbl_NaslovVIES;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.BindingSource LookUpObveznikbindingSource1;
        private ds_T27 ds_T27;
        private ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter tbl_ObveznikLookUpTableAdapter;
        private ds_PdvS ds_PdvS;
        private System.Windows.Forms.BindingSource tbl_PdvSBindingSource;
        private ds_PdvSTableAdapters.tbl_PdvSTableAdapter tbl_PdvSTableAdapter;
        private ds_PdvSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_PdvSDataGridView;
        private System.Windows.Forms.BindingSource ZemljabindingSource;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter tbl_sifarnikZemljaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lbl_ukupnoPDV_S;
        private System.Windows.Forms.TextBox txt_ukupnoPdvS;
        private System.Windows.Forms.Button btn_provjeri;
    }
}