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
    public partial class MenaxhimiKlienteve : Form
    {
        public MenaxhimiKlienteve()
        {
            InitializeComponent();
        }

        private void MenaxhimiKlienteve_Load(object sender, EventArgs e)
        {
            // Përdorim një metodë për të mbushur tabelën e klientëve kur forma ngarkohet
            LoadClientData();
            // Përdorim një metodë për të mbushur tabelën e klientëve kur forma ngarkohet
            dtgTabela.ReadOnly = true;

            // Aktivizojmë shiritin e lëvizjes horizontale dhe vertikale, nëse është e nevojshme
            dtgTabela.ScrollBars = ScrollBars.Both; // Mund të përdorësh ScrollBars.Vertical ose ScrollBars.Horizontal nëse dëshiron vetëm një lloj shirit lëvizjeje
        }

        private void LoadClientData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Klienti_ID, Emri, Mbiemri, Data_Lindjes, Email, Telefon, Adresa, AnetarAktiv FROM Klientet";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dtgTabela.DataSource = dataTable; // Lidhim DataTable me DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë ngarkimit të të dhënave: " + ex.Message);
                }
            }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            string fullName = txtEmriMbiemri.Text;
            string[] nameParts = fullName.Split(new char[] { ' ' }, 2);
            string emri = nameParts.Length > 0 ? nameParts[0] : "";
            string mbiemri = nameParts.Length > 1 ? nameParts[1] : "";

            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string adresa = txtAdresa.Text;
            DateTime dataLindjes = dtpDataLindjes.Value;
            bool statusiAnetaresise = cmbStatusiAnetaresise.SelectedItem.ToString().Trim().Equals("Aktive", StringComparison.OrdinalIgnoreCase);
            int statusiAnetaresiseDb = statusiAnetaresise ? 1 : 0;

            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Klientet (Emri, Mbiemri, Data_Lindjes, Email, Telefon, Adresa, AnetarAktiv) " +
                               "VALUES (@Emri, @Mbiemri, @DataLindjes, @Email, @Telefon, @Adresa, @AnetarAktiv)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Emri", emri);
                command.Parameters.AddWithValue("@Mbiemri", mbiemri);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DataLindjes", dataLindjes);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Adresa", adresa);
                command.Parameters.AddWithValue("@AnetarAktiv", statusiAnetaresiseDb);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Klienti u regjistrua me sukses!");
                    LoadClientData(); // Refresh the data grid
                    ClearInputFields();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë regjistrimit të klientit: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string fullName = txtEmriMbiemri.Text;
            string[] nameParts = fullName.Split(new char[] { ' ' }, 2);
            string emri = nameParts.Length > 0 ? nameParts[0] : "";
            string mbiemri = nameParts.Length > 1 ? nameParts[1] : "";

            if (string.IsNullOrWhiteSpace(emri) || string.IsNullOrWhiteSpace(mbiemri))
            {
                MessageBox.Show("Ju lutem, vendosni Emrin dhe Mbiemrin për të përditësuar një klient.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string querySelect = "SELECT Data_Lindjes, Email, Telefon, Adresa, AnetarAktiv FROM Klientet WHERE Emri = @Emri AND Mbiemri = @Mbiemri";

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Emri", emri);
                commandSelect.Parameters.AddWithValue("@Mbiemri", mbiemri);

                try
                {
                    connection.Open();
                    SqlDataReader reader = commandSelect.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Asnjë klient nuk u gjet me këtë emër dhe mbiemër. Kontrolloni të dhënat.");
                        return;
                    }

                    // Fetch existing values
                    DateTime oldDataLindjes = reader["Data_Lindjes"] != DBNull.Value ? Convert.ToDateTime(reader["Data_Lindjes"]) : DateTime.Now;
                    string oldEmail = reader["Email"].ToString();
                    string oldTelefon = reader["Telefon"].ToString();
                    string oldAdresa = reader["Adresa"].ToString();
                    bool oldAnetarAktiv = Convert.ToBoolean(reader["AnetarAktiv"]);

                    reader.Close(); // Close reader before updating

                    // Use new values if entered, otherwise keep old values
                    DateTime dataLindjes = dtpDataLindjes.Value != DateTime.MinValue ? dtpDataLindjes.Value : oldDataLindjes;
                    string email = !string.IsNullOrWhiteSpace(txtEmail.Text) ? txtEmail.Text : oldEmail;
                    string telefon = !string.IsNullOrWhiteSpace(txtTelefon.Text) ? txtTelefon.Text : oldTelefon;
                    string adresa = !string.IsNullOrWhiteSpace(txtAdresa.Text) ? txtAdresa.Text : oldAdresa;
                    int statusiAnetaresiseDb = cmbStatusiAnetaresise.SelectedItem != null ?
                        (cmbStatusiAnetaresise.SelectedItem.ToString().Trim().Equals("Aktive", StringComparison.OrdinalIgnoreCase) ? 1 : 0)
                        : (oldAnetarAktiv ? 1 : 0);

                    // Update Query
                    string queryUpdate = @"UPDATE Klientet 
                     SET Data_Lindjes = @DataLindjes, Email = @Email, Telefon = @Telefon, 
                         Adresa = @Adresa, AnetarAktiv = @AnetarAktiv 
                     WHERE Emri = @Emri AND Mbiemri = @Mbiemri";

                    SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection);
                    commandUpdate.Parameters.AddWithValue("@Emri", emri);
                    commandUpdate.Parameters.AddWithValue("@Mbiemri", mbiemri);
                    commandUpdate.Parameters.AddWithValue("@Email", email);
                    commandUpdate.Parameters.AddWithValue("@DataLindjes", dataLindjes);
                    commandUpdate.Parameters.AddWithValue("@Telefon", telefon);
                    commandUpdate.Parameters.AddWithValue("@Adresa", adresa);
                    commandUpdate.Parameters.AddWithValue("@AnetarAktiv", statusiAnetaresiseDb);

                    int rowsAffected = commandUpdate.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Të dhënat e klientit u përditësuan me sukses!");
                        LoadClientData(); // Përsëri ngarkojmë të dhënat pas përditësimit të klientit
                        ClearInputFields();
                    }
                    else
                        MessageBox.Show("Asnjë klient nuk u përditësua. Kontrolloni të dhënat.");
                }
                catch (Exception ex)
                {   
                    MessageBox.Show("Gabim gjatë përditësimit të klientit: " + ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void panelTeDhenat_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void dtgTabela_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ClearInputFields()
        {
            txtEmriMbiemri.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtAdresa.Text = "";
            dtpDataLindjes.Value = DateTime.Now; // Reset to current date
            cmbStatusiAnetaresise.SelectedIndex = -1; // Clear selection
        }
    }
}
