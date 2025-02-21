namespace Bibloteka2
{
    partial class KlientetAktive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientetAktive));
            this.dataGridViewActiveClients = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.labelSelectedPeriod = new System.Windows.Forms.Label();
            this.cmbStatusi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActiveClients
            // 
            this.dataGridViewActiveClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveClients.Location = new System.Drawing.Point(125, 179);
            this.dataGridViewActiveClients.Name = "dataGridViewActiveClients";
            this.dataGridViewActiveClients.Size = new System.Drawing.Size(636, 222);
            this.dataGridViewActiveClients.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(524, 83);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtro";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // labelSelectedPeriod
            // 
            this.labelSelectedPeriod.AutoSize = true;
            this.labelSelectedPeriod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelSelectedPeriod.Location = new System.Drawing.Point(221, 88);
            this.labelSelectedPeriod.Name = "labelSelectedPeriod";
            this.labelSelectedPeriod.Size = new System.Drawing.Size(87, 16);
            this.labelSelectedPeriod.TabIndex = 3;
            this.labelSelectedPeriod.Text = "Cakto Statusin";
            // 
            // cmbStatusi
            // 
            this.cmbStatusi.FormattingEnabled = true;
            this.cmbStatusi.Location = new System.Drawing.Point(364, 85);
            this.cmbStatusi.Name = "cmbStatusi";
            this.cmbStatusi.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusi.TabIndex = 4;
            // 
            // KlientetAktive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbStatusi);
            this.Controls.Add(this.labelSelectedPeriod);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridViewActiveClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlientetAktive";
            this.Text = "Klientet Aktive";
            this.Load += new System.EventHandler(this.KlientetAktive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActiveClients;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label labelSelectedPeriod;
        private System.Windows.Forms.ComboBox cmbStatusi;
    }
}