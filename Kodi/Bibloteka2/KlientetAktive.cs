using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bibloteka2
{
    public partial class KlientetAktive : Form
    {
        public KlientetAktive()
        {
            InitializeComponent();
            // Mbush ComboBox me opsione
            cmbStatusi.Items.Add("Aktiv");
            cmbStatusi.Items.Add("Inaktiv");
            cmbStatusi.SelectedIndex = 0; // Zgjedh "Aktiv" si default
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Merr statusin e zgjedhur nga ComboBox
            int statusi = cmbStatusi.SelectedItem.ToString() == "Aktiv" ? 1 : 0;

            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query për të marrë klientët bazuar në statusin e zgjedhur
                string query = @"SELECT Emri, Mbiemri, Email, Telefon, Adresa, Data_Lindjes
                                 FROM Klientet 
                                 WHERE AnetarAktiv = @statusi";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@statusi", statusi);

                // Mbush DataGridView me të dhënat e marra
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewActiveClients.DataSource = dataTable;
            }

            // Azhurnimi i etiketës për statusin e zgjedhur
            labelSelectedPeriod.Text = $"Klientët: {cmbStatusi.SelectedItem}";
        }

        private void KlientetAktive_Load(object sender, EventArgs e)
        {
            // Filtro klientët aktivë në ngarkimin e parë
            btnFilter.PerformClick();
        }
    }
}
