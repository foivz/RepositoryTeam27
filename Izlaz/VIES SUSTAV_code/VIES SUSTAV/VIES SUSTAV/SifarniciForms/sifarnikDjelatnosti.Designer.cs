namespace VIES_SUSTAV.SifarniciForms
{
    partial class frm_sifarnikDjelatnosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sifarnikDjelatnosti));
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.tbl_sifarnikDjelatnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sifarnikDjelatnostiTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_sifarnikDjelatnostiTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager();
            this.tbl_sifarnikDjelatnostiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikDjelatnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikDjelatnostiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sifarnikDjelatnostiBindingSource
            // 
            this.tbl_sifarnikDjelatnostiBindingSource.DataMember = "tbl_sifarnikDjelatnosti";
            this.tbl_sifarnikDjelatnostiBindingSource.DataSource = this.ds_T27;
            // 
            // tbl_sifarnikDjelatnostiTableAdapter
            // 
            this.tbl_sifarnikDjelatnostiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikDjelatnostiTableAdapter = this.tbl_sifarnikDjelatnostiTableAdapter;
            this.tableAdapterManager.tbl_sifarnikIspostavaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikObvezeTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikPodrucnihUredaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikVlasnistvaTableAdapter = null;
            this.tableAdapterManager.tbl_sifarnikZemljaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_T27TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_sifarnikDjelatnostiDataGridView
            // 
            this.tbl_sifarnikDjelatnostiDataGridView.AllowUserToAddRows = false;
            this.tbl_sifarnikDjelatnostiDataGridView.AllowUserToDeleteRows = false;
            this.tbl_sifarnikDjelatnostiDataGridView.AutoGenerateColumns = false;
            this.tbl_sifarnikDjelatnostiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_sifarnikDjelatnostiDataGridView.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.tbl_sifarnikDjelatnostiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbl_sifarnikDjelatnostiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_sifarnikDjelatnostiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbl_sifarnikDjelatnostiDataGridView.DataSource = this.tbl_sifarnikDjelatnostiBindingSource;
            this.tbl_sifarnikDjelatnostiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tbl_sifarnikDjelatnostiDataGridView.Name = "tbl_sifarnikDjelatnostiDataGridView";
            this.tbl_sifarnikDjelatnostiDataGridView.ReadOnly = true;
            this.tbl_sifarnikDjelatnostiDataGridView.Size = new System.Drawing.Size(503, 542);
            this.tbl_sifarnikDjelatnostiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sifraDjelatnosti";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nazivDjelatnosti";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Opis djelatnosti";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // frm_sifarnikDjelatnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(542, 566);
            this.Controls.Add(this.tbl_sifarnikDjelatnostiDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sifarnikDjelatnosti";
            this.Text = "Poslovne djelatnosti";
            this.Load += new System.EventHandler(this.frm_sifarnikDjelatnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikDjelatnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sifarnikDjelatnostiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_T27 ds_T27;
        private System.Windows.Forms.BindingSource tbl_sifarnikDjelatnostiBindingSource;
        private ds_T27TableAdapters.tbl_sifarnikDjelatnostiTableAdapter tbl_sifarnikDjelatnostiTableAdapter;
        private ds_T27TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_sifarnikDjelatnostiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}