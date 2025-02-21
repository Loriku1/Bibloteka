namespace Bibloteka2
{
    partial class HuazimetVonuara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuazimetVonuara));
            this.dataGridViewDelayedLoans = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDelayedLoans = new System.Windows.Forms.DateTimePicker();
            this.btnFilterDelayedLoans = new System.Windows.Forms.Button();
            this.labelSelectedPeriod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelayedLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDelayedLoans
            // 
            this.dataGridViewDelayedLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelayedLoans.Location = new System.Drawing.Point(48, 140);
            this.dataGridViewDelayedLoans.Name = "dataGridViewDelayedLoans";
            this.dataGridViewDelayedLoans.Size = new System.Drawing.Size(644, 132);
            this.dataGridViewDelayedLoans.TabIndex = 0;
            this.dataGridViewDelayedLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDelayedLoans_CellContentClick);
            // 
            // dateTimePickerDelayedLoans
            // 
            this.dateTimePickerDelayedLoans.CustomFormat = "MM/yyyy";
            this.dateTimePickerDelayedLoans.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDelayedLoans.Location = new System.Drawing.Point(277, 81);
            this.dateTimePickerDelayedLoans.Name = "dateTimePickerDelayedLoans";
            this.dateTimePickerDelayedLoans.ShowUpDown = true;
            this.dateTimePickerDelayedLoans.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDelayedLoans.TabIndex = 1;
            // 
            // btnFilterDelayedLoans
            // 
            this.btnFilterDelayedLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterDelayedLoans.Location = new System.Drawing.Point(510, 76);
            this.btnFilterDelayedLoans.Name = "btnFilterDelayedLoans";
            this.btnFilterDelayedLoans.Size = new System.Drawing.Size(75, 25);
            this.btnFilterDelayedLoans.TabIndex = 2;
            this.btnFilterDelayedLoans.Text = "Filtro";
            this.btnFilterDelayedLoans.UseVisualStyleBackColor = true;
            this.btnFilterDelayedLoans.Click += new System.EventHandler(this.btnFilterDelayedLoans_Click);
            // 
            // labelSelectedPeriod
            // 
            this.labelSelectedPeriod.AutoSize = true;
            this.labelSelectedPeriod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelSelectedPeriod.Location = new System.Drawing.Point(143, 85);
            this.labelSelectedPeriod.Name = "labelSelectedPeriod";
            this.labelSelectedPeriod.Size = new System.Drawing.Size(79, 16);
            this.labelSelectedPeriod.TabIndex = 3;
            this.labelSelectedPeriod.Text = "Cakto Daten";
            this.labelSelectedPeriod.Click += new System.EventHandler(this.labelSelectedPeriod_Click);
            // 
            // HuazimetVonuara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectedPeriod);
            this.Controls.Add(this.btnFilterDelayedLoans);
            this.Controls.Add(this.dateTimePickerDelayedLoans);
            this.Controls.Add(this.dataGridViewDelayedLoans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HuazimetVonuara";
            this.Text = "Huazimet e Vonuara";
            this.Load += new System.EventHandler(this.HuazimetVonuara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelayedLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDelayedLoans;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelayedLoans;
        private System.Windows.Forms.Button btnFilterDelayedLoans;
        private System.Windows.Forms.Label labelSelectedPeriod;
    }
}