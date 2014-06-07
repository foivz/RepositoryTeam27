namespace VIES_SUSTAV.SifarniciForms
{
    partial class frm_sifarnikZemalja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sifarnikZemalja));
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_sifarnikZemljaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikZemljaTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_sifarnikZemljaTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
            this.tbl_sifarnikZemljaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikZemljaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikZemljaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sifarnikZemljaBindingSource
            // 
            this.tbl_sifarnikZemljaBindingSource.DataMember = "tbl_sifarnikZemlja";
            this.tbl_sifarnikZemljaBindingSource.DataSource = this.ds_T27;
            // 
            // tbl_sifarnikZemljaTableAdapter
            // 
            this.tbl_sifarnikZemljaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikDjelatnostiTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikIspostavaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikObvezeTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikPodrucnihUredaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikVlasnistvaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikZemljaTableAdapter = this.tbl_sifarnikZemljaTableAdapter;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_sifarnikZemljaDataGridView
            // 
            this.tbl_sifarnikZemljaDataGridView.AllowUserToAddRows = false;
            this.tbl_sifarnikZemljaDataGridView.AllowUserToDeleteRows = false;
            this.tbl_sifarnikZemljaDataGridView.AutoGenerateColumns = false;
            this.tbl_sifarnikZemljaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_sifarnikZemljaDataGridView.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.tbl_sifarnikZemljaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbl_sifarnikZemljaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_sifarnikZemljaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbl_sifarnikZemljaDataGridView.DataSource = this.tbl_sifarnikZemljaBindingSource;
            this.tbl_sifarnikZemljaDataGridView.Location = new System.Drawing.Point(30, 23);
            this.tbl_sifarnikZemljaDataGridView.Name = "tbl_sifarnikZemljaDataGridView";
            this.tbl_sifarnikZemljaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_sifarnikZemljaDataGridView.Size = new System.Drawing.Size(300, 455);
            this.tbl_sifarnikZemljaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sifraZemlje";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 53;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nazivZemlje";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Zemlja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 63;
            // 
            // frm_sifarnikZemalja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(362, 516);
            this.Controls.Add(this.tbl_sifarnikZemljaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sifarnikZemalja";
            this.Text = "Zemlje Europske Unije";
            this.Load += new System.EventHandler(this.frm_sifarnikZemalja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikZemljaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikZemljaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_T27 ds_T27;
        private System.Windows.Forms.BindingSource tbl_sifarnikZemljaBindingSource;
        private ds_T27TableAdapters.tbl_sifarnikZemljaTableAdapter tbl_sifarnikZemljaTableAdapter;
        private ds_T27TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_sifarnikZemljaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}