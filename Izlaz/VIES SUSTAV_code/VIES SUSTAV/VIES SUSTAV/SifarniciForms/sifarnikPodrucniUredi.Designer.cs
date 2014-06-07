namespace VIES_SUSTAV.SifarniciForms
{
    partial class frm_sifarnikPodrucniUredi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sifarnikPodrucniUredi));
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_sifarnikPodrucnihUredaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikPodrucnihUredaTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
            this.tbl_sifarnikPodrucnihUredaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivPodrucnogUreda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lboxIspostavePU = new System.Windows.Forms.ListBox();
            this.lbl_Ispostave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikPodrucnihUredaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikPodrucnihUredaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sifarnikPodrucnihUredaBindingSource
            // 
            this.tbl_sifarnikPodrucnihUredaBindingSource.DataMember = "tbl_sifarnikPodrucnihUreda";
            this.tbl_sifarnikPodrucnihUredaBindingSource.DataSource = this.ds_T27;
            // 
            // tbl_sifarnikPodrucnihUredaTableAdapter
            // 
            this.tbl_sifarnikPodrucnihUredaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikDjelatnostiTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikIspostavaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikObvezeTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikPodrucnihUredaTableAdapter = this.tbl_sifarnikPodrucnihUredaTableAdapter;
            this.tableAdapterManager.tbl_sifarnikVlasnistvaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikZemljaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_sifarnikPodrucnihUredaDataGridView
            // 
            this.tbl_sifarnikPodrucnihUredaDataGridView.AllowUserToAddRows = false;
            this.tbl_sifarnikPodrucnihUredaDataGridView.AllowUserToDeleteRows = false;
            this.tbl_sifarnikPodrucnihUredaDataGridView.AutoGenerateColumns = false;
            this.tbl_sifarnikPodrucnihUredaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_sifarnikPodrucnihUredaDataGridView.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.tbl_sifarnikPodrucnihUredaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbl_sifarnikPodrucnihUredaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_sifarnikPodrucnihUredaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nazivPodrucnogUreda});
            this.tbl_sifarnikPodrucnihUredaDataGridView.DataSource = this.tbl_sifarnikPodrucnihUredaBindingSource;
            this.tbl_sifarnikPodrucnihUredaDataGridView.Location = new System.Drawing.Point(26, 21);
            this.tbl_sifarnikPodrucnihUredaDataGridView.Name = "tbl_sifarnikPodrucnihUredaDataGridView";
            this.tbl_sifarnikPodrucnihUredaDataGridView.RowTemplate.ReadOnly = true;
            this.tbl_sifarnikPodrucnihUredaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbl_sifarnikPodrucnihUredaDataGridView.Size = new System.Drawing.Size(393, 491);
            this.tbl_sifarnikPodrucnihUredaDataGridView.TabIndex = 1;
            this.tbl_sifarnikPodrucnihUredaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_sifarnikPodrucnihUredaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sifraPodrucnogUreda";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 53;
            // 
            // nazivPodrucnogUreda
            // 
            this.nazivPodrucnogUreda.DataPropertyName = "nazivPodrucnogUreda";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nazivPodrucnogUreda.DefaultCellStyle = dataGridViewCellStyle2;
            this.nazivPodrucnogUreda.HeaderText = "Naziv ureda";
            this.nazivPodrucnogUreda.Name = "nazivPodrucnogUreda";
            this.nazivPodrucnogUreda.Width = 89;
            // 
            // lboxIspostavePU
            // 
            this.lboxIspostavePU.BackColor = System.Drawing.Color.Gainsboro;
            this.lboxIspostavePU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxIspostavePU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxIspostavePU.FormattingEnabled = true;
            this.lboxIspostavePU.ItemHeight = 16;
            this.lboxIspostavePU.Location = new System.Drawing.Point(449, 60);
            this.lboxIspostavePU.Name = "lboxIspostavePU";
            this.lboxIspostavePU.Size = new System.Drawing.Size(231, 416);
            this.lboxIspostavePU.TabIndex = 2;
            // 
            // lbl_Ispostave
            // 
            this.lbl_Ispostave.BackColor = System.Drawing.Color.Orange;
            this.lbl_Ispostave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ispostave.Location = new System.Drawing.Point(446, 21);
            this.lbl_Ispostave.Name = "lbl_Ispostave";
            this.lbl_Ispostave.Size = new System.Drawing.Size(224, 24);
            this.lbl_Ispostave.TabIndex = 3;
            this.lbl_Ispostave.Text = "Pripadajuće porezne ispostave:";
            this.lbl_Ispostave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_sifarnikPodrucniUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(692, 566);
            this.Controls.Add(this.lbl_Ispostave);
            this.Controls.Add(this.lboxIspostavePU);
            this.Controls.Add(this.tbl_sifarnikPodrucnihUredaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sifarnikPodrucniUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Područni Uredi Porezne Uprave";
            this.Load += new System.EventHandler(this.frm_sifarnikPodrucniUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikPodrucnihUredaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikPodrucnihUredaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_T27 ds_T27;
        private System.Windows.Forms.BindingSource tbl_sifarnikPodrucnihUredaBindingSource;
        private ds_T27TableAdapters.tbl_sifarnikPodrucnihUredaTableAdapter tbl_sifarnikPodrucnihUredaTableAdapter;
        private ds_T27TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_sifarnikPodrucnihUredaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPodrucnogUreda;
        private System.Windows.Forms.ListBox lboxIspostavePU;
        private System.Windows.Forms.Label lbl_Ispostave;
    }
}