using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bibloteka2
{
    public partial class BiblotekarForm : Form
    {
        public BiblotekarForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null; // Store the active form

        private void LoadFormInPanel(Form form)
        {
            panelContainer.Controls.Clear(); // Clear previous content
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            form.Show();

            // Store reference to the active form
            activeForm = form;

            // Refresh panel to show form name
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
            LoadFormInPanel(new HuazimiMaterialeve());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new PagesatTotaleKlienteve());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new HuazimetVonuara());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (activeForm != null)
            {
                using (Font font = new Font("Arial", 12, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    string formName = activeForm.Text; // Get the active form's name
                    e.Graphics.DrawString(formName, font, brush, new PointF(10, 10));
                }
            }
        }

        private void BiblotekarForm_Load(object sender, EventArgs e)
        {

        }

        // Optional panelContainer paint event if needed for custom drawing (currently not used)
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            // Add custom logic if needed
        }
    }
}
