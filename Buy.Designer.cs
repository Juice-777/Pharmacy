namespace Apteka
{
    partial class Buy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Group = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.cb_Provider = new System.Windows.Forms.ComboBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aptekaDB = new Apteka.AptekaDB();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Form = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cb_Art = new System.Windows.Forms.ComboBox();
            this.medicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_provider = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_form = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Art = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.medicamentsTableAdapter = new Apteka.AptekaDBTableAdapters.MedicamentsTableAdapter();
            this.providersTableAdapter = new Apteka.AptekaDBTableAdapters.ProvidersTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tb_Amount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Group);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buy);
            this.groupBox1.Controls.Add(this.cb_Provider);
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.tb_Total);
            this.groupBox1.Controls.Add(this.tb_Form);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.cb_Art);
            this.groupBox1.Controls.Add(this.lbl_provider);
            this.groupBox1.Controls.Add(this.lbl_price);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.lbl_form);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_Art);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(254, 160);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(100, 26);
            this.tb_Amount.TabIndex = 16;
            this.tb_Amount.TextChanged += new System.EventHandler(this.tb_Amount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount:";
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(79, 128);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(274, 26);
            this.tb_Group.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Group:";
            // 
            // btn_Buy
            // 
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Buy.Location = new System.Drawing.Point(278, 227);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(75, 23);
            this.btn_Buy.TabIndex = 12;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // cb_Provider
            // 
            this.cb_Provider.DataSource = this.providersBindingSource;
            this.cb_Provider.DisplayMember = "Name";
            this.cb_Provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Provider.FormattingEnabled = true;
            this.cb_Provider.Location = new System.Drawing.Point(79, 224);
            this.cb_Provider.Name = "cb_Provider";
            this.cb_Provider.Size = new System.Drawing.Size(193, 24);
            this.cb_Provider.TabIndex = 11;
            this.cb_Provider.ValueMember = "Name";
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.aptekaDB;
            // 
            // aptekaDB
            // 
            this.aptekaDB.DataSetName = "AptekaDB";
            this.aptekaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(254, 192);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(99, 26);
            this.tb_Price.TabIndex = 10;
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(79, 192);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(93, 26);
            this.tb_Total.TabIndex = 9;
            // 
            // tb_Form
            // 
            this.tb_Form.Location = new System.Drawing.Point(79, 160);
            this.tb_Form.Name = "tb_Form";
            this.tb_Form.Size = new System.Drawing.Size(93, 26);
            this.tb_Form.TabIndex = 8;
            this.tb_Form.TextChanged += new System.EventHandler(this.tb_Form_TextChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(79, 64);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(274, 58);
            this.tb_Name.TabIndex = 7;
            // 
            // cb_Art
            // 
            this.cb_Art.DataSource = this.medicamentsBindingSource;
            this.cb_Art.DisplayMember = "Art";
            this.cb_Art.FormattingEnabled = true;
            this.cb_Art.Location = new System.Drawing.Point(79, 31);
            this.cb_Art.Name = "cb_Art";
            this.cb_Art.Size = new System.Drawing.Size(141, 28);
            this.cb_Art.TabIndex = 6;
            this.cb_Art.ValueMember = "Art";
            this.cb_Art.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // medicamentsBindingSource
            // 
            this.medicamentsBindingSource.DataMember = "Medicaments";
            this.medicamentsBindingSource.DataSource = this.aptekaDB;
            // 
            // lbl_provider
            // 
            this.lbl_provider.AutoSize = true;
            this.lbl_provider.Location = new System.Drawing.Point(6, 224);
            this.lbl_provider.Name = "lbl_provider";
            this.lbl_provider.Size = new System.Drawing.Size(70, 20);
            this.lbl_provider.TabIndex = 5;
            this.lbl_provider.Text = "Provider:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(178, 192);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(48, 20);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(6, 192);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(48, 20);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_form
            // 
            this.lbl_form.AutoSize = true;
            this.lbl_form.Location = new System.Drawing.Point(6, 160);
            this.lbl_form.Name = "lbl_form";
            this.lbl_form.Size = new System.Drawing.Size(50, 20);
            this.lbl_form.TabIndex = 2;
            this.lbl_form.Text = "Form:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_Art
            // 
            this.lbl_Art.AutoSize = true;
            this.lbl_Art.Location = new System.Drawing.Point(6, 34);
            this.lbl_Art.Name = "lbl_Art";
            this.lbl_Art.Size = new System.Drawing.Size(57, 20);
            this.lbl_Art.TabIndex = 0;
            this.lbl_Art.Text = "Art. №:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicamentsTableAdapter
            // 
            this.medicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Buy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.Buy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_provider;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_form;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Art;
        private System.Windows.Forms.ComboBox cb_Provider;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Form;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cb_Art;
        private AptekaDB aptekaDB;
        private System.Windows.Forms.BindingSource medicamentsBindingSource;
        private AptekaDBTableAdapters.MedicamentsTableAdapter medicamentsTableAdapter;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private AptekaDBTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.TextBox tb_Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}