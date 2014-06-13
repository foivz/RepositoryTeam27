namespace VIES_SUSTAV.VIESForms
{
    partial class frm_PregledPdvS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PregledPdvS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txt_razdoblje = new System.Windows.Forms.TextBox();
            this.LookUpObveznikbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_ObveznikLookUpTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter();
            this.ds_PdvS = new VIES_SUSTAV.ds_PdvS();
            this.tbl_PdvSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PdvSTableAdapter = new VIES_SUSTAV.ds_PdvSTableAdapters.tbl_PdvSTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_PdvSTableAdapters.TableAdapterManager();
            this.tbl_PdvSDataGridView = new System.Windows.Forms.DataGridView();
            this.PdvSbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_PdvSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ZemljabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.tbl_sifarnikZemljaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_provjeri = new System.Windows.Forms.Label();
            this.pbox_PdvsProvjeri1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.PdvSbindingNavigator)).BeginInit();
            this.PdvSbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsProvjeri1)).BeginInit();
            this.SuspendLayout();
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
            // pnl_pripadajuciVIES
            // 
            this.pnl_pripadajuciVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_pripadajuciVIES.Controls.Add(this.panel1);
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
            this.pnl_pripadajuciVIES.Location = new System.Drawing.Point(13, 42);
            this.pnl_pripadajuciVIES.Name = "pnl_pripadajuciVIES";
            this.pnl_pripadajuciVIES.Size = new System.Drawing.Size(580, 154);
            this.pnl_pripadajuciVIES.TabIndex = 49;
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.Location = new System.Drawing.Point(473, 3);
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
            this.oIBTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.oIBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "OIB", true));
            this.oIBTextBox.ForeColor = System.Drawing.Color.Navy;
            this.oIBTextBox.Location = new System.Drawing.Point(188, 74);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.ReadOnly = true;
            this.oIBTextBox.Size = new System.Drawing.Size(183, 15);
            this.oIBTextBox.TabIndex = 72;
            // 
            // nazivObveznikaTextBox
            // 
            this.nazivObveznikaTextBox.BackColor = System.Drawing.Color.DarkGray;
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
            this.adresaTextBox.BackColor = System.Drawing.Color.DarkGray;
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
            this.nazivIspostaveTextBox.BackColor = System.Drawing.Color.DarkGray;
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
            this.nazivPodrucnogUredaTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.nazivPodrucnogUredaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivPodrucnogUredaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LookUpObveznikbindingSource1, "nazivPodrucnogUreda", true));
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
            this.txt_razdoblje.TabIndex = 52;
            this.txt_razdoblje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tbl_PdvSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_PdvSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_PdvSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbl_PdvSDataGridView.DataSource = this.tbl_PdvSBindingSource;
            this.tbl_PdvSDataGridView.Location = new System.Drawing.Point(13, 266);
            this.tbl_PdvSDataGridView.Name = "tbl_PdvSDataGridView";
            this.tbl_PdvSDataGridView.Size = new System.Drawing.Size(580, 284);
            this.tbl_PdvSDataGridView.TabIndex = 52;
            this.tbl_PdvSDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_PdvSDataGridView_RowLeave);
            // 
            // PdvSbindingNavigator
            // 
            this.PdvSbindingNavigator.AddNewItem = this.bindingNavigatorCountItem;
            this.PdvSbindingNavigator.BindingSource = this.tbl_PdvSBindingSource;
            this.PdvSbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.PdvSbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.PdvSbindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PdvSbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_PdvSBindingNavigatorSaveItem});
            this.PdvSbindingNavigator.Location = new System.Drawing.Point(0, 569);
            this.PdvSbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.PdvSbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.PdvSbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.PdvSbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.PdvSbindingNavigator.Name = "PdvSbindingNavigator";
            this.PdvSbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.PdvSbindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.PdvSbindingNavigator.TabIndex = 53;
            this.PdvSbindingNavigator.Text = "PDVSbindingNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // tbl_PdvSBindingNavigatorSaveItem
            // 
            this.tbl_PdvSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_PdvSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_PdvSBindingNavigatorSaveItem.Image")));
            this.tbl_PdvSBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbl_PdvSBindingNavigatorSaveItem.Name = "tbl_PdvSBindingNavigatorSaveItem";
            this.tbl_PdvSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_PdvSBindingNavigatorSaveItem.Text = "Save";
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
            // tbl_sifarnikZemljaTableAdapter
            // 
            this.tbl_sifarnikZemljaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbox_PdvsProvjeri1);
            this.panel1.Controls.Add(this.lbl_provjeri);
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(425, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 101);
            this.panel1.TabIndex = 83;
            // 
            // lbl_provjeri
            // 
            this.lbl_provjeri.Location = new System.Drawing.Point(3, 7);
            this.lbl_provjeri.Name = "lbl_provjeri";
            this.lbl_provjeri.Size = new System.Drawing.Size(142, 30);
            this.lbl_provjeri.TabIndex = 0;
            this.lbl_provjeri.Text = "Provjera vrijednosti PDV-S izvještaja";
            this.lbl_provjeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox_PdvsProvjeri1
            // 
            this.pbox_PdvsProvjeri1.Image = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsProvjeri1.Image")));
            this.pbox_PdvsProvjeri1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsProvjeri1.InitialImage")));
            this.pbox_PdvsProvjeri1.Location = new System.Drawing.Point(50, 41);
            this.pbox_PdvsProvjeri1.Name = "pbox_PdvsProvjeri1";
            this.pbox_PdvsProvjeri1.Size = new System.Drawing.Size(48, 48);
            this.pbox_PdvsProvjeri1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_PdvsProvjeri1.TabIndex = 65;
            this.pbox_PdvsProvjeri1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_VIES";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.FillWeight = 175.311F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Evidencijski broj";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Evidencijski broj VIES izvještaja _ NE UNOSI SE";
            this.dataGridViewTextBoxColumn2.Width = 119;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Zemlja_isporuke";
            this.dataGridViewTextBoxColumn3.DataSource = this.ZemljabindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nazivZemlje";
            this.dataGridViewTextBoxColumn3.FillWeight = 203.0457F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Zemlja isporuke";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Zemlja iz koje je roba isporučena";
            this.dataGridViewTextBoxColumn3.ValueMember = "sifraZemlje";
            this.dataGridViewTextBoxColumn3.Width = 116;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EU_isporucitelj";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.FillWeight = 10.82166F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID INO dobavljača";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Vat broj ino dobavljača";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vrijednost_stjecanja";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.FillWeight = 10.82166F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Vrijednost stjecanja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Vrijednost izražena na fakturi, bez poreza, iskazana u kunama";
            // 
            // frm_PregledPdvS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(613, 594);
            this.Controls.Add(this.PdvSbindingNavigator);
            this.Controls.Add(this.tbl_PdvSDataGridView);
            this.Controls.Add(this.txt_razdoblje);
            this.Controls.Add(this.lbl_NaslovVIES);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(this.pnl_pripadajuciVIES);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_PregledPdvS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled PDV-S izvještaja";
            this.Load += new System.EventHandler(this.frm_PregledPdvS_Load);
            this.pnl_pripadajuciVIES.ResumeLayout(false);
            this.pnl_pripadajuciVIES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpObveznikbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PdvS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PdvSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PdvSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PdvSbindingNavigator)).EndInit();
            this.PdvSbindingNavigator.ResumeLayout(false);
            this.PdvSbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZemljabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsProvjeri1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txt_razdoblje;
        private System.Windows.Forms.BindingSource LookUpObveznikbindingSource1;
        private ds_T27 ds_T27;
        private ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter tbl_ObveznikLookUpTableAdapter;
        private ds_PdvS ds_PdvS;
        private System.Windows.Forms.BindingSource tbl_PdvSBindingSource;
        private ds_PdvSTableAdapters.tbl_PdvSTableAdapter tbl_PdvSTableAdapter;
        private ds_PdvSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_PdvSDataGridView;
        private System.Windows.Forms.BindingNavigator PdvSbindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton tbl_PdvSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource ZemljabindingSource;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private ds_sifarnici_lookUpTableAdapters.tbl_sifarnikZemljaTableAdapter tbl_sifarnikZemljaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_provjeri;
        private System.Windows.Forms.PictureBox pbox_PdvsProvjeri1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}