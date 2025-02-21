using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka2
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null; // Ruajmë referencën e formës aktive

        private void LoadFormInPanel(Form form)
        {
            panelContainer.Controls.Clear(); // Fshij përmbajtjen e mëparshme
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            form.Show();

            // Ruaj emrin e formës aktive
            activeForm = form;

            // Rifresko panelin për të shfaqur emrin e formës
            panel1.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new MenaxhimiMaterialeveBiblografike());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new MenaxhimiKlienteve());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new MenaxhimiPagesav());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new MenaxhimiPerdoruesveSistemit());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new PagesatTotaleKlienteve());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new HuazimetVonuara());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new KlientetAktive());
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (activeForm != null)
            {
                using (Font font = new Font("Arial", 12, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    string formName = activeForm.Text; // Merr emrin e formës
                    e.Graphics.DrawString(formName, font, brush, new PointF(10, 10));
                }
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
