namespace Bibloteka2
{
    partial class PagesatTotaleKlienteve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagesatTotaleKlienteve));
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.labelSelectedPeriod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(233, 169);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.Size = new System.Drawing.Size(293, 123);
            this.dataGridViewPayments.TabIndex = 0;
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.CustomFormat = "MM/yy";
            this.dateTimePickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilter.Location = new System.Drawing.Point(303, 72);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.ShowUpDown = true;
            this.dateTimePickerFilter.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(550, 73);
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
            this.labelSelectedPeriod.Location = new System.Drawing.Point(152, 72);
            this.labelSelectedPeriod.Name = "labelSelectedPeriod";
            this.labelSelectedPeriod.Size = new System.Drawing.Size(79, 16);
            this.labelSelectedPeriod.TabIndex = 3;
            this.labelSelectedPeriod.Text = "Cakto daten";
            // 
            // PagesatTotaleKlienteve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectedPeriod);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateTimePickerFilter);
            this.Controls.Add(this.dataGridViewPayments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PagesatTotaleKlienteve";
            this.Text = "Pagesat Totale te Klienteve";
            this.Load += new System.EventHandler(this.PagesatTotaleKlienteve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label labelSelectedPeriod;
    }
}