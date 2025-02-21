namespace Bibloteka2
{
    partial class MenaxhimiPagesav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenaxhimiPagesav));
            this.comboBoxKlienti = new System.Windows.Forms.ComboBox();
            this.numericUpDownShuma = new System.Windows.Forms.NumericUpDown();
            this.comboBoxLlojiPageses = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPagesa = new System.Windows.Forms.DateTimePicker();
            this.btnRegjistroPagesen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShuma)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxKlienti
            // 
            this.comboBoxKlienti.FormattingEnabled = true;
            this.comboBoxKlienti.Location = new System.Drawing.Point(418, 58);
            this.comboBoxKlienti.Name = "comboBoxKlienti";
            this.comboBoxKlienti.Size = new System.Drawing.Size(200, 21);
            this.comboBoxKlienti.TabIndex = 0;
            this.comboBoxKlienti.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlienti_SelectedIndexChanged);
            // 
            // numericUpDownShuma
            // 
            this.numericUpDownShuma.Location = new System.Drawing.Point(418, 130);
            this.numericUpDownShuma.Name = "numericUpDownShuma";
            this.numericUpDownShuma.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownShuma.TabIndex = 1;
            // 
            // comboBoxLlojiPageses
            // 
            this.comboBoxLlojiPageses.FormattingEnabled = true;
            this.comboBoxLlojiPageses.Location = new System.Drawing.Point(418, 192);
            this.comboBoxLlojiPageses.Name = "comboBoxLlojiPageses";
            this.comboBoxLlojiPageses.Size = new System.Drawing.Size(200, 21);
            this.comboBoxLlojiPageses.TabIndex = 2;
            // 
            // dateTimePickerPagesa
            // 
            this.dateTimePickerPagesa.Location = new System.Drawing.Point(418, 245);
            this.dateTimePickerPagesa.Name = "dateTimePickerPagesa";
            this.dateTimePickerPagesa.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPagesa.TabIndex = 3;
            // 
            // btnRegjistroPagesen
            // 
            this.btnRegjistroPagesen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegjistroPagesen.Location = new System.Drawing.Point(418, 303);
            this.btnRegjistroPagesen.Name = "btnRegjistroPagesen";
            this.btnRegjistroPagesen.Size = new System.Drawing.Size(75, 23);
            this.btnRegjistroPagesen.TabIndex = 4;
            this.btnRegjistroPagesen.Text = "Save";
            this.btnRegjistroPagesen.UseVisualStyleBackColor = true;
            this.btnRegjistroPagesen.Click += new System.EventHandler(this.btnRegjistroPagesen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(225, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zgjedh Klientin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(225, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shuma e Pageses";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(225, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lloji i Pageses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(225, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data e Pageses";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegjistroPagesen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerPagesa);
            this.panel1.Controls.Add(this.comboBoxKlienti);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxLlojiPageses);
            this.panel1.Controls.Add(this.numericUpDownShuma);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 9;
            // 
            // MenaxhimiPagesav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenaxhimiPagesav";
            this.Text = "Menaxhimi i Pagesav";
            this.Load += new System.EventHandler(this.MenaxhimiPagesav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShuma)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKlienti;
        private System.Windows.Forms.NumericUpDown numericUpDownShuma;
        private System.Windows.Forms.ComboBox comboBoxLlojiPageses;
        private System.Windows.Forms.DateTimePicker dateTimePickerPagesa;
        private System.Windows.Forms.Button btnRegjistroPagesen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}