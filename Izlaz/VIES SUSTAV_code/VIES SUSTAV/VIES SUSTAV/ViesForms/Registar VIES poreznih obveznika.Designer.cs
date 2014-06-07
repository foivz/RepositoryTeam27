namespace VIES_SUSTAV.ViesForms
{
    partial class frn_registarVIES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frn_registarVIES));
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.lbl_porezniObveznik = new System.Windows.Forms.Label();
            this.ds_porezniObveznik = new VIES_SUSTAV.ds_porezniObveznik();
            this.tbl_porezniObveznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_porezniObveznikTableAdapter = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager();
            this.PodrucnibindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.tbl_sifarnikPodrucnihUredaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter();
            this.IspostavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikIspostavaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter();
            this.tbl_porezniObveznikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtPretrazivanjeOIB = new System.Windows.Forms.TextBox();
            this.lbl_OIB = new System.Windows.Forms.Label();
            this.btn_traziOIB = new System.Windows.Forms.Button();
            this.btn_poscisti = new System.Windows.Forms.Button();
            this.btn_prikaziSve = new System.Windows.Forms.Button();
            this.btn_unosNovogObveznika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodrucnibindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IspostavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(0, 0);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(1004, 33);
            this.lbl_poreznaUprava.TabIndex = 1;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_porezniObveznik
            // 
            this.lbl_porezniObveznik.BackColor = System.Drawing.Color.Orange;
            this.lbl_porezniObveznik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_porezniObveznik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porezniObveznik.ForeColor = System.Drawing.Color.Navy;
            this.lbl_porezniObveznik.Location = new System.Drawing.Point(0, 45);
            this.lbl_porezniObveznik.Name = "lbl_porezniObveznik";
            this.lbl_porezniObveznik.Size = new System.Drawing.Size(1004, 22);
            this.lbl_porezniObveznik.TabIndex = 33;
            this.lbl_porezniObveznik.Text = "Registar VIES poreznih obveznika";
            this.lbl_porezniObveznik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // IspostavaBindingSource
            // 
            this.IspostavaBindingSource.DataMember = "tbl_sifarnikIspostava";
            this.IspostavaBindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // tbl_sifarnikIspostavaTableAdapter
            // 
            this.tbl_sifarnikIspostavaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_porezniObveznikDataGridView
            // 
            this.tbl_porezniObveznikDataGridView.AllowUserToAddRows = false;
            this.tbl_porezniObveznikDataGridView.AllowUserToDeleteRows = false;
            this.tbl_porezniObveznikDataGridView.AutoGenerateColumns = false;
            this.tbl_porezniObveznikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_porezniObveznikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbl_porezniObveznikDataGridView.DataSource = this.tbl_porezniObveznikBindingSource;
            this.tbl_porezniObveznikDataGridView.Location = new System.Drawing.Point(153, 218);
            this.tbl_porezniObveznikDataGridView.Name = "tbl_porezniObveznikDataGridView";
            this.tbl_porezniObveznikDataGridView.Size = new System.Drawing.Size(647, 338);
            this.tbl_porezniObveznikDataGridView.TabIndex = 33;
            this.tbl_porezniObveznikDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_porezniObveznikDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OIB";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NazivObveznika";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Država";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Država";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PodrucniUredPU";
            this.dataGridViewTextBoxColumn2.DataSource = this.PodrucnibindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.DisplayMember = "nazivPodrucnogUreda";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Područni ured PU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "sifraPodrucnogUreda";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PoreznaIspostava";
            this.dataGridViewTextBoxColumn3.DataSource = this.IspostavaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nazivIspostave";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ispostava PU";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "sifraIspostave";
            // 
            // txtPretrazivanjeOIB
            // 
            this.txtPretrazivanjeOIB.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtPretrazivanjeOIB.ForeColor = System.Drawing.Color.Navy;
            this.txtPretrazivanjeOIB.Location = new System.Drawing.Point(70, 137);
            this.txtPretrazivanjeOIB.Name = "txtPretrazivanjeOIB";
            this.txtPretrazivanjeOIB.Size = new System.Drawing.Size(152, 22);
            this.txtPretrazivanjeOIB.TabIndex = 34;
            this.txtPretrazivanjeOIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPretrazivanjeOIB_KeyPress);
            // 
            // lbl_OIB
            // 
            this.lbl_OIB.AutoSize = true;
            this.lbl_OIB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OIB.Location = new System.Drawing.Point(12, 145);
            this.lbl_OIB.Name = "lbl_OIB";
            this.lbl_OIB.Size = new System.Drawing.Size(33, 14);
            this.lbl_OIB.TabIndex = 35;
            this.lbl_OIB.Text = "OIB:";
            // 
            // btn_traziOIB
            // 
            this.btn_traziOIB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traziOIB.Location = new System.Drawing.Point(250, 137);
            this.btn_traziOIB.Name = "btn_traziOIB";
            this.btn_traziOIB.Size = new System.Drawing.Size(90, 24);
            this.btn_traziOIB.TabIndex = 36;
            this.btn_traziOIB.Text = "Traži";
            this.btn_traziOIB.UseVisualStyleBackColor = true;
            this.btn_traziOIB.Click += new System.EventHandler(this.btn_traziOIB_Click);
            // 
            // btn_poscisti
            // 
            this.btn_poscisti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poscisti.Location = new System.Drawing.Point(355, 137);
            this.btn_poscisti.Name = "btn_poscisti";
            this.btn_poscisti.Size = new System.Drawing.Size(90, 24);
            this.btn_poscisti.TabIndex = 37;
            this.btn_poscisti.Text = "Počisti";
            this.btn_poscisti.UseVisualStyleBackColor = true;
            this.btn_poscisti.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_prikaziSve
            // 
            this.btn_prikaziSve.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prikaziSve.Location = new System.Drawing.Point(685, 158);
            this.btn_prikaziSve.Name = "btn_prikaziSve";
            this.btn_prikaziSve.Size = new System.Drawing.Size(115, 45);
            this.btn_prikaziSve.TabIndex = 38;
            this.btn_prikaziSve.Text = "Prikaži sve";
            this.btn_prikaziSve.UseVisualStyleBackColor = true;
            this.btn_prikaziSve.Click += new System.EventHandler(this.btn_prikaziSve_Click);
            // 
            // btn_unosNovogObveznika
            // 
            this.btn_unosNovogObveznika.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_unosNovogObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unosNovogObveznika.Location = new System.Drawing.Point(875, 83);
            this.btn_unosNovogObveznika.Name = "btn_unosNovogObveznika";
            this.btn_unosNovogObveznika.Size = new System.Drawing.Size(115, 55);
            this.btn_unosNovogObveznika.TabIndex = 39;
            this.btn_unosNovogObveznika.Text = "Unos novog poreznog obveznika";
            this.btn_unosNovogObveznika.UseVisualStyleBackColor = false;
            this.btn_unosNovogObveznika.Click += new System.EventHandler(this.btn_unosNovogObveznika_Click);
            // 
            // frn_registarVIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1002, 610);
            this.Controls.Add(this.btn_unosNovogObveznika);
            this.Controls.Add(this.btn_prikaziSve);
            this.Controls.Add(this.btn_poscisti);
            this.Controls.Add(this.btn_traziOIB);
            this.Controls.Add(this.lbl_OIB);
            this.Controls.Add(this.txtPretrazivanjeOIB);
            this.Controls.Add(this.tbl_porezniObveznikDataGridView);
            this.Controls.Add(this.lbl_porezniObveznik);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frn_registarVIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar VIES poreznih obveznika";
            this.Load += new System.EventHandler(this.frn_registarVIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodrucnibindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IspostavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_porezniObveznikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.Label lbl_porezniObveznik;
        private ds_porezniObveznik ds_porezniObveznik;
        private System.Windows.Forms.BindingSource tbl_porezniObveznikBindingSource;
        private ds_porezniObveznikTableAdapters.tbl_porezniObveznikTableAdapter tbl_porezniObveznikTableAdapter;
        private ds_porezniObveznikTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource PodrucnibindingSource;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter tbl_sifarnikPodrucnihUredaTableAdapter;
        private System.Windows.Forms.BindingSource IspostavaBindingSource;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikIspostavaTableAdapter tbl_sifarnikIspostavaTableAdapter;
        private System.Windows.Forms.DataGridView tbl_porezniObveznikDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtPretrazivanjeOIB;
        private System.Windows.Forms.Label lbl_OIB;
        private System.Windows.Forms.Button btn_traziOIB;
        private System.Windows.Forms.Button btn_poscisti;
        private System.Windows.Forms.Button btn_prikaziSve;
        private System.Windows.Forms.Button btn_unosNovogObveznika;
    }
}