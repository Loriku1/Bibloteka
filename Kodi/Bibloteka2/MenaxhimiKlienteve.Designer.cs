namespace Bibloteka2
{
    partial class MenaxhimiKlienteve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenaxhimiKlienteve));
            this.txtEmriMbiemri = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.dtpDataLindjes = new System.Windows.Forms.DateTimePicker();
            this.cmbStatusiAnetaresise = new System.Windows.Forms.ComboBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelTeDhenat = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgTabela = new System.Windows.Forms.DataGridView();
            this.panelTeDhenat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmriMbiemri
            // 
            this.txtEmriMbiemri.Location = new System.Drawing.Point(163, 26);
            this.txtEmriMbiemri.Name = "txtEmriMbiemri";
            this.txtEmriMbiemri.Size = new System.Drawing.Size(100, 20);
            this.txtEmriMbiemri.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(163, 109);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(163, 147);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 3;
            // 
            // dtpDataLindjes
            // 
            this.dtpDataLindjes.Location = new System.Drawing.Point(488, 26);
            this.dtpDataLindjes.Name = "dtpDataLindjes";
            this.dtpDataLindjes.Size = new System.Drawing.Size(200, 20);
            this.dtpDataLindjes.TabIndex = 4;
            // 
            // cmbStatusiAnetaresise
            // 
            this.cmbStatusiAnetaresise.FormattingEnabled = true;
            this.cmbStatusiAnetaresise.Items.AddRange(new object[] {
            "Aktive",
            "Passiv"});
            this.cmbStatusiAnetaresise.Location = new System.Drawing.Point(488, 74);
            this.cmbStatusiAnetaresise.Name = "cmbStatusiAnetaresise";
            this.cmbStatusiAnetaresise.Size = new System.Drawing.Size(200, 21);
            this.cmbStatusiAnetaresise.TabIndex = 5;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveClient.Location = new System.Drawing.Point(613, 137);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClient.TabIndex = 6;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Emrin dhe Mbiemri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Emaili";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numri i telefonit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(370, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data e Lindjes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(370, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Statusi i Antaresise";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(373, 137);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelTeDhenat
            // 
            this.panelTeDhenat.Controls.Add(this.label1);
            this.panelTeDhenat.Controls.Add(this.btnSaveClient);
            this.panelTeDhenat.Controls.Add(this.btnEdit);
            this.panelTeDhenat.Controls.Add(this.txtEmriMbiemri);
            this.panelTeDhenat.Controls.Add(this.label6);
            this.panelTeDhenat.Controls.Add(this.cmbStatusiAnetaresise);
            this.panelTeDhenat.Controls.Add(this.label2);
            this.panelTeDhenat.Controls.Add(this.label5);
            this.panelTeDhenat.Controls.Add(this.txtEmail);
            this.panelTeDhenat.Controls.Add(this.dtpDataLindjes);
            this.panelTeDhenat.Controls.Add(this.label4);
            this.panelTeDhenat.Controls.Add(this.label3);
            this.panelTeDhenat.Controls.Add(this.txtTelefon);
            this.panelTeDhenat.Controls.Add(this.txtAdresa);
            this.panelTeDhenat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTeDhenat.Location = new System.Drawing.Point(0, 0);
            this.panelTeDhenat.Name = "panelTeDhenat";
            this.panelTeDhenat.Size = new System.Drawing.Size(1078, 184);
            this.panelTeDhenat.TabIndex = 14;
            this.panelTeDhenat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeDhenat_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgTabela);
            this.panel2.Location = new System.Drawing.Point(3, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 345);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtgTabela
            // 
            this.dtgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabela.Location = new System.Drawing.Point(127, 3);
            this.dtgTabela.Name = "dtgTabela";
            this.dtgTabela.Size = new System.Drawing.Size(642, 165);
            this.dtgTabela.TabIndex = 0;
            this.dtgTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTabela_CellContentClick);
            // 
            // MenaxhimiKlienteve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1078, 881);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTeDhenat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenaxhimiKlienteve";
            this.Text = "Menaxhimi i Klienteve";
            this.Load += new System.EventHandler(this.MenaxhimiKlienteve_Load);
            this.panelTeDhenat.ResumeLayout(false);
            this.panelTeDhenat.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmriMbiemri;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.DateTimePicker dtpDataLindjes;
        private System.Windows.Forms.ComboBox cmbStatusiAnetaresise;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelTeDhenat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgTabela;
    }
}