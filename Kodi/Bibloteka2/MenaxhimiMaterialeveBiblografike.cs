using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka2
{
    public partial class MenaxhimiMaterialeveBiblografike : Form
    {
        public MenaxhimiMaterialeveBiblografike()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string titulli = txtTitulli.Text;
            string autori = txtAutori.Text;
            string bashkeAutoret = txtBashkeAutoret.Text;
            string botuesi = txtBotuesi.Text;
            DateTime dataPublikimit = dtpDataPublikimit.Value;
            string isbn = txtISBN.Text;
            string doi = txtDOI.Text;
            string llojiMaterialit = cmbLlojiMaterialit.SelectedItem.ToString();
            int kopjetDisponibile = (int)numKopjetDisponibile.Value;

            // Marrim lidhjen nga app.config
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Materialet_Bibliografike (Titulli, Autori, BashkeAutoret, Botuesi, Data_Publikimit, ISBN, DOI, Lloji_Materialit, Kopjet_Disponibile, Data_Shtuar) " +
                               "VALUES (@Titulli, @Autori, @BashkeAutoret, @Botuesi, @Data_Publikimit, @ISBN, @DOI, @Lloji_Materialit, @Kopjet_Disponibile, GETDATE())";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titulli", titulli);
                command.Parameters.AddWithValue("@Autori", autori);
                command.Parameters.AddWithValue("@BashkeAutoret", bashkeAutoret);
                command.Parameters.AddWithValue("@Botuesi", botuesi);
                command.Parameters.AddWithValue("@Data_Publikimit", dataPublikimit);
                command.Parameters.AddWithValue("@ISBN", isbn);
                command.Parameters.AddWithValue("@DOI", doi);
                command.Parameters.AddWithValue("@Lloji_Materialit", llojiMaterialit);
                command.Parameters.AddWithValue("@Kopjet_Disponibile", kopjetDisponibile);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Materiali u shtua me sukses!");

                    // Fshi vlerat nga inputet pas ruajtjes
                    txtTitulli.Clear();
                    txtAutori.Clear();
                    txtBashkeAutoret.Clear();
                    txtBotuesi.Clear();
                    txtISBN.Clear();
                    txtDOI.Clear();
                    numKopjetDisponibile.Value = 1;
                    cmbLlojiMaterialit.SelectedIndex = -1; // Heq selektimin nga dropdown

                    ShfaqMaterialet();  // Opsionale, refresh për të parë ndryshimet
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë shtimit të materialit: " + ex.Message);
                }
            }
        }


        private void MenaxhimiMaterialeveBiblografike_Load(object sender, EventArgs e)
        {
            ShfaqMaterialet();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;

            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Ju lutemi, vendosni ISBN e materialit që dëshironi të fshini.");
                return;
            }

            // Konfirmimi i fshirjes
            DialogResult result = MessageBox.Show("A jeni të sigurt që dëshironi të fshini këtë material?",
                                                  "Konfirmim",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            // Marrja e lidhjes nga app.config
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Materialet_Bibliografike WHERE ISBN = @ISBN";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ISBN", isbn);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Materiali u fshi me sukses!");
                        ShfaqMaterialet();

                        // Opsionale: Fshini përmbajtjen e textbox-ave pas fshirjes
                        txtTitulli.Clear();
                        txtAutori.Clear();
                        txtBashkeAutoret.Clear();
                        txtBotuesi.Clear();
                        txtISBN.Clear();
                        txtDOI.Clear();
                        numKopjetDisponibile.Value = 1;
                        cmbLlojiMaterialit.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Nuk u gjet asnjë material me këtë ISBN.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë fshirjes së materialit: " + ex.Message);
                }
            }
        }
        private void ShfaqMaterialet()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Material_ID, Titulli, Autori, BashkeAutoret, Botuesi, Data_Publikimit, ISBN, DOI, Lloji_Materialit, Kopjet_Disponibile FROM Materialet_Bibliografike";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtgKlientet.DataSource = dt;  // Lidhja e DataTable me DataGridView

                    // Opsionale: Vendos emrat e kolonave në DataGridView
                    dtgKlientet.Columns["Material_ID"].HeaderText = "ID";
                    dtgKlientet.Columns["Titulli"].HeaderText = "Titulli";
                    dtgKlientet.Columns["Autori"].HeaderText = "Autori";
                    dtgKlientet.Columns["BashkeAutoret"].HeaderText = "Bashkëautorët";
                    dtgKlientet.Columns["Botuesi"].HeaderText = "Botuesi";
                    dtgKlientet.Columns["Data_Publikimit"].HeaderText = "Data Publikimit";
                    dtgKlientet.Columns["ISBN"].HeaderText = "ISBN";
                    dtgKlientet.Columns["DOI"].HeaderText = "DOI";
                    dtgKlientet.Columns["Lloji_Materialit"].HeaderText = "Lloji";
                    dtgKlientet.Columns["Kopjet_Disponibile"].HeaderText = "Kopje Disponibile";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë marrjes së të dhënave: " + ex.Message);
                }
            }
        }


        private void panelMenaxhimi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTabela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgKlientet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
