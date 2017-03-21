namespace Apteka
{
    partial class AddMedicament
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_Form = new System.Windows.Forms.ComboBox();
            this.cb_Group = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ArtNom = new System.Windows.Forms.TextBox();
            this.cb_Amount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cb_Form);
            this.groupBox1.Controls.Add(this.cb_Group);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.tb_ArtNom);
            this.groupBox1.Controls.Add(this.cb_Amount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new preparat:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(278, 190);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 62);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_Form
            // 
            this.cb_Form.FormattingEnabled = true;
            this.cb_Form.Items.AddRange(new object[] {
            "Box",
            "Boutle"});
            this.cb_Form.Location = new System.Drawing.Point(81, 190);
            this.cb_Form.Name = "cb_Form";
            this.cb_Form.Size = new System.Drawing.Size(191, 28);
            this.cb_Form.TabIndex = 9;
            this.cb_Form.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cb_Group
            // 
            this.cb_Group.FormattingEnabled = true;
            this.cb_Group.Items.AddRange(new object[] {
            "immunosuppressive",
            "ganglioplegic",
            "antitumor",
            "antiarrhythmic",
            "anticholinesterase",
            "anesthetic",
            "antitumor"});
            this.cb_Group.Location = new System.Drawing.Point(81, 156);
            this.cb_Group.Name = "cb_Group";
            this.cb_Group.Size = new System.Drawing.Size(191, 28);
            this.cb_Group.TabIndex = 8;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(81, 61);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(272, 89);
            this.tb_Name.TabIndex = 7;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // tb_ArtNom
            // 
            this.tb_ArtNom.Location = new System.Drawing.Point(81, 29);
            this.tb_ArtNom.Name = "tb_ArtNom";
            this.tb_ArtNom.Size = new System.Drawing.Size(107, 26);
            this.tb_ArtNom.TabIndex = 6;
            this.tb_ArtNom.TextChanged += new System.EventHandler(this.tb_ArtNom_TextChanged);
            // 
            // cb_Amount
            // 
            this.cb_Amount.FormattingEnabled = true;
            this.cb_Amount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "50",
            "100"});
            this.cb_Amount.Location = new System.Drawing.Point(81, 224);
            this.cb_Amount.Name = "cb_Amount";
            this.cb_Amount.Size = new System.Drawing.Size(191, 28);
            this.cb_Amount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Form:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Art №:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(377, 247);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // AddMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMedicament";
            this.Text = "AddMedicament";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ArtNom;
        private System.Windows.Forms.ComboBox cb_Amount;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_Form;
        private System.Windows.Forms.ComboBox cb_Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}