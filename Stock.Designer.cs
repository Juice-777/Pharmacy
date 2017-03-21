namespace Apteka
{
    partial class Stock
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
            this.buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aptekaDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aptekaDB = new Apteka.AptekaDB();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buyTableAdapter = new Apteka.AptekaDBTableAdapters.BuyTableAdapter();
            this.saleTableAdapter = new Apteka.AptekaDBTableAdapters.SaleTableAdapter();
            this.aptekaDB1 = new Apteka.AptekaDB();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aptekaDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buyBindingSource
            // 
            this.buyBindingSource.DataMember = "Buy";
            this.buyBindingSource.DataSource = this.aptekaDBBindingSource;
            // 
            // aptekaDBBindingSource
            // 
            this.aptekaDBBindingSource.DataSource = this.aptekaDB;
            this.aptekaDBBindingSource.Position = 0;
            // 
            // aptekaDB
            // 
            this.aptekaDB.DataSetName = "AptekaDB";
            this.aptekaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(377, 247);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_2);
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.aptekaDBBindingSource;
            // 
            // buyBindingSource1
            // 
            this.buyBindingSource1.DataMember = "Buy";
            this.buyBindingSource1.DataSource = this.aptekaDB;
            // 
            // buyTableAdapter
            // 
            this.buyTableAdapter.ClearBeforeFill = true;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // aptekaDB1
            // 
            this.aptekaDB1.DataSetName = "AptekaDB";
            this.aptekaDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.artDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buyBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(448, 229);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // artDataGridViewTextBoxColumn
            // 
            this.artDataGridViewTextBoxColumn.DataPropertyName = "Art";
            this.artDataGridViewTextBoxColumn.HeaderText = "Art";
            this.artDataGridViewTextBoxColumn.Name = "artDataGridViewTextBoxColumn";
            this.artDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // buyBindingSource2
            // 
            this.buyBindingSource2.DataMember = "Buy";
            this.buyBindingSource2.DataSource = this.aptekaDBBindingSource;
            // 
            // aptekaDBBindingSource1
            // 
            this.aptekaDBBindingSource1.DataSource = this.aptekaDB;
            this.aptekaDBBindingSource1.Position = 0;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(279, 248);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.Text = "ReLoad table";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 290);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDBBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource aptekaDBBindingSource;
        private AptekaDB aptekaDB;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.BindingSource buyBindingSource;
        private AptekaDBTableAdapters.BuyTableAdapter buyTableAdapter;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private AptekaDBTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.BindingSource buyBindingSource1;
        private AptekaDB aptekaDB1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aptekaDBBindingSource1;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.BindingSource buyBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}