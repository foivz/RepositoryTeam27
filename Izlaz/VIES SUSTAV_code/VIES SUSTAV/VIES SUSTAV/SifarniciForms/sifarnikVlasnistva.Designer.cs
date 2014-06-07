namespace VIES_SUSTAV.SifarniciForms
{
    partial class frm_sifarnikVlasnistva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sifarnikVlasnistva));
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_sifarnikVlasnistvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikVlasnistvaTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_sifarnikVlasnistvaTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
            this.tbl_sifarnikVlasnistvaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikVlasnistvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikVlasnistvaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sifarnikVlasnistvaBindingSource
            // 
            this.tbl_sifarnikVlasnistvaBindingSource.DataMember = "tbl_sifarnikVlasnistva";
            this.tbl_sifarnikVlasnistvaBindingSource.DataSource = this.ds_T27;
            // 
            // tbl_sifarnikVlasnistvaTableAdapter
            // 
            this.tbl_sifarnikVlasnistvaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikDjelatnostiTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikIspostavaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikObvezeTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikPodrucnihUredaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikVlasnistvaTableAdapter = this.tbl_sifarnikVlasnistvaTableAdapter;
            this.tableAdapterManager.tbl_sifarnikZemljaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_sifarnikVlasnistvaDataGridView
            // 
            this.tbl_sifarnikVlasnistvaDataGridView.AllowUserToAddRows = false;
            this.tbl_sifarnikVlasnistvaDataGridView.AllowUserToDeleteRows = false;
            this.tbl_sifarnikVlasnistvaDataGridView.AutoGenerateColumns = false;
            this.tbl_sifarnikVlasnistvaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_sifarnikVlasnistvaDataGridView.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.tbl_sifarnikVlasnistvaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbl_sifarnikVlasnistvaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_sifarnikVlasnistvaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbl_sifarnikVlasnistvaDataGridView.DataSource = this.tbl_sifarnikVlasnistvaBindingSource;
            this.tbl_sifarnikVlasnistvaDataGridView.Location = new System.Drawing.Point(29, 17);
            this.tbl_sifarnikVlasnistvaDataGridView.Name = "tbl_sifarnikVlasnistvaDataGridView";
            this.tbl_sifarnikVlasnistvaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbl_sifarnikVlasnistvaDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tbl_sifarnikVlasnistvaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sifraVlasnistva";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "opisVlasnnistva";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Vrsta vlasništva";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // frm_sifarnikVlasnistva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Controls.Add(this.tbl_sifarnikVlasnistvaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sifarnikVlasnistva";
            this.Text = "Vrste vlasništva";
            this.Load += new System.EventHandler(this.frm_sifarnikVlasnistva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikVlasnistvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikVlasnistvaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_T27 ds_T27;
        private System.Windows.Forms.BindingSource tbl_sifarnikVlasnistvaBindingSource;
        private ds_T27TableAdapters.tbl_sifarnikVlasnistvaTableAdapter tbl_sifarnikVlasnistvaTableAdapter;
        private ds_T27TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_sifarnikVlasnistvaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}