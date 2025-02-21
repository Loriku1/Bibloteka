namespace Bibloteka2
{
    partial class MenaxhimiMaterialeveBiblografike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenaxhimiMaterialeveBiblografike));
            this.txtTitulli = new System.Windows.Forms.TextBox();
            this.txtAutori = new System.Windows.Forms.TextBox();
            this.txtBashkeAutoret = new System.Windows.Forms.TextBox();
            this.txtBotuesi = new System.Windows.Forms.TextBox();
            this.dtpDataPublikimit = new System.Windows.Forms.DateTimePicker();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtDOI = new System.Windows.Forms.TextBox();
            this.cmbLlojiMaterialit = new System.Windows.Forms.ComboBox();
            this.numKopjetDisponibile = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelMenaxhimi = new System.Windows.Forms.Panel();
            this.dtgKlientet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numKopjetDisponibile)).BeginInit();
            this.panelMenaxhimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKlientet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulli
            // 
            this.txtTitulli.Location = new System.Drawing.Point(70, 25);
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.Size = new System.Drawing.Size(100, 20);
            this.txtTitulli.TabIndex = 0;
            // 
            // txtAutori
            // 
            this.txtAutori.Location = new System.Drawing.Point(70, 66);
            this.txtAutori.Name = "txtAutori";
            this.txtAutori.Size = new System.Drawing.Size(100, 20);
            this.txtAutori.TabIndex = 1;
            // 
            // txtBashkeAutoret
            // 
            this.txtBashkeAutoret.Location = new System.Drawing.Point(70, 107);
            this.txtBashkeAutoret.Name = "txtBashkeAutoret";
            this.txtBashkeAutoret.Size = new System.Drawing.Size(100, 20);
            this.txtBashkeAutoret.TabIndex = 2;
            // 
            // txtBotuesi
            // 
            this.txtBotuesi.Location = new System.Drawing.Point(70, 141);
            this.txtBotuesi.Name = "txtBotuesi";
            this.txtBotuesi.Size = new System.Drawing.Size(100, 20);
            this.txtBotuesi.TabIndex = 3;
            // 
            // dtpDataPublikimit
            // 
            this.dtpDataPublikimit.Location = new System.Drawing.Point(335, 22);
            this.dtpDataPublikimit.Name = "dtpDataPublikimit";
            this.dtpDataPublikimit.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPublikimit.TabIndex = 4;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(335, 73);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtDOI
            // 
            this.txtDOI.Location = new System.Drawing.Point(335, 111);
            this.txtDOI.Name = "txtDOI";
            this.txtDOI.Size = new System.Drawing.Size(100, 20);
            this.txtDOI.TabIndex = 6;
            this.txtDOI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbLlojiMaterialit
            // 
            this.cmbLlojiMaterialit.FormattingEnabled = true;
            this.cmbLlojiMaterialit.Items.AddRange(new object[] {
            "Liber ",
            "Artikull"});
            this.cmbLlojiMaterialit.Location = new System.Drawing.Point(335, 148);
            this.cmbLlojiMaterialit.Name = "cmbLlojiMaterialit";
            this.cmbLlojiMaterialit.Size = new System.Drawing.Size(121, 21);
            this.cmbLlojiMaterialit.TabIndex = 7;
            // 
            // numKopjetDisponibile
            // 
            this.numKopjetDisponibile.Location = new System.Drawing.Point(668, 26);
            this.numKopjetDisponibile.Name = "numKopjetDisponibile";
            this.numKopjetDisponibile.Size = new System.Drawing.Size(120, 20);
            this.numKopjetDisponibile.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(705, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Titulli";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Autori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bashke\r\n Autoret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Botuesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(252, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data e \r\nPublikimit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(252, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(252, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "DOI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(251, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lloji i\r\n Materialit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(575, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kopjet\r\n Disponibile ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(564, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelMenaxhimi
            // 
            this.panelMenaxhimi.Controls.Add(this.txtTitulli);
            this.panelMenaxhimi.Controls.Add(this.btnSave);
            this.panelMenaxhimi.Controls.Add(this.btnDelete);
            this.panelMenaxhimi.Controls.Add(this.label1);
            this.panelMenaxhimi.Controls.Add(this.label9);
            this.panelMenaxhimi.Controls.Add(this.numKopjetDisponibile);
            this.panelMenaxhimi.Controls.Add(this.label2);
            this.panelMenaxhimi.Controls.Add(this.label8);
            this.panelMenaxhimi.Controls.Add(this.txtAutori);
            this.panelMenaxhimi.Controls.Add(this.cmbLlojiMaterialit);
            this.panelMenaxhimi.Controls.Add(this.label7);
            this.panelMenaxhimi.Controls.Add(this.label3);
            this.panelMenaxhimi.Controls.Add(this.label6);
            this.panelMenaxhimi.Controls.Add(this.txtDOI);
            this.panelMenaxhimi.Controls.Add(this.txtBashkeAutoret);
            this.panelMenaxhimi.Controls.Add(this.label5);
            this.panelMenaxhimi.Controls.Add(this.label4);
            this.panelMenaxhimi.Controls.Add(this.txtISBN);
            this.panelMenaxhimi.Controls.Add(this.txtBotuesi);
            this.panelMenaxhimi.Controls.Add(this.dtpDataPublikimit);
            this.panelMenaxhimi.Location = new System.Drawing.Point(0, 2);
            this.panelMenaxhimi.Name = "panelMenaxhimi";
            this.panelMenaxhimi.Size = new System.Drawing.Size(1111, 190);
            this.panelMenaxhimi.TabIndex = 20;
            this.panelMenaxhimi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenaxhimi_Paint);
            // 
            // dtgKlientet
            // 
            this.dtgKlientet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKlientet.Location = new System.Drawing.Point(16, 27);
            this.dtgKlientet.Name = "dtgKlientet";
            this.dtgKlientet.Size = new System.Drawing.Size(775, 175);
            this.dtgKlientet.TabIndex = 0;
            this.dtgKlientet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKlientet_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgKlientet);
            this.panel1.Location = new System.Drawing.Point(18, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 328);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenaxhimiMaterialeveBiblografike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1166, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenaxhimi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenaxhimiMaterialeveBiblografike";
            this.Text = "Menaxhimi i Materialeve Biblografike";
            this.Load += new System.EventHandler(this.MenaxhimiMaterialeveBiblografike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKopjetDisponibile)).EndInit();
            this.panelMenaxhimi.ResumeLayout(false);
            this.panelMenaxhimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKlientet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulli;
        private System.Windows.Forms.TextBox txtAutori;
        private System.Windows.Forms.TextBox txtBashkeAutoret;
        private System.Windows.Forms.TextBox txtBotuesi;
        private System.Windows.Forms.DateTimePicker dtpDataPublikimit;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtDOI;
        private System.Windows.Forms.ComboBox cmbLlojiMaterialit;
        private System.Windows.Forms.NumericUpDown numKopjetDisponibile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelMenaxhimi;
        private System.Windows.Forms.DataGridView dtgKlientet;
        private System.Windows.Forms.Panel panel1;
    }
}