namespace VIES_SUSTAV.SifarniciForms
{
    partial class frm_sifarnikObveze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sifarnikObveze));
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_sifarnikObvezeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikObvezeTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_sifarnikObvezeTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
            this.tbl_sifarnikObvezeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikObvezeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikObvezeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sifarnikObvezeBindingSource
            // 
            this.tbl_sifarnikObvezeBindingSource.DataMember = "tbl_sifarnikObveze";
            this.tbl_sifarnikObvezeBindingSource.DataSource = this.ds_T27;
            // 
            // tbl_sifarnikObvezeTableAdapter
            // 
            this.tbl_sifarnikObvezeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikDjelatnostiTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikIspostavaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikObvezeTableAdapter = this.tbl_sifarnikObvezeTableAdapter;
            this.tableAdapterManager.tbl_sifarnikPodrucnihUredaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikVlasnistvaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikZemljaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_sifarnikObvezeDataGridView
            // 
            this.tbl_sifarnikObvezeDataGridView.AllowUserToAddRows = false;
            this.tbl_sifarnikObvezeDataGridView.AllowUserToDeleteRows = false;
            this.tbl_sifarnikObvezeDataGridView.AutoGenerateColumns = false;
            this.tbl_sifarnikObvezeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_sifarnikObvezeDataGridView.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.tbl_sifarnikObvezeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_sifarnikObvezeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbl_sifarnikObvezeDataGridView.DataSource = this.tbl_sifarnikObvezeBindingSource;
            this.tbl_sifarnikObvezeDataGridView.Location = new System.Drawing.Point(26, 21);
            this.tbl_sifarnikObvezeDataGridView.Name = "tbl_sifarnikObvezeDataGridView";
            this.tbl_sifarnikObvezeDataGridView.Size = new System.Drawing.Size(433, 314);
            this.tbl_sifarnikObvezeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sifraObveze";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "opisObveze";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Vrsta obveze";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // frm_sifarnikObveze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(492, 366);
            this.Controls.Add(this.tbl_sifarnikObvezeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sifarnikObveze";
            this.Text = "Vrste porezne obveze";
            this.Load += new System.EventHandler(this.frm_sifarnikObveze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikObvezeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikObvezeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_T27 ds_T27;
        private System.Windows.Forms.BindingSource tbl_sifarnikObvezeBindingSource;
        private ds_T27TableAdapters.tbl_sifarnikObvezeTableAdapter tbl_sifarnikObvezeTableAdapter;
        private ds_T27TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_sifarnikObvezeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}