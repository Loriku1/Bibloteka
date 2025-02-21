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
    public partial class MenaxhimiPagesav : Form
    {
        public MenaxhimiPagesav()
        {
            InitializeComponent();
        }

        private void btnRegjistroPagesen_Click(object sender, EventArgs e)
        {
            // Merr të dhënat nga forma
            int klientiID = Convert.ToInt32(comboBoxKlienti.SelectedValue);
            decimal shumaPageses = numericUpDownShuma.Value;
            string llojiPageses = comboBoxLlojiPageses.SelectedItem.ToString();
            DateTime dataPageses = dateTimePickerPagesa.Value;

            // Marrim lidhjen nga app.config
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pagesat (Klienti_ID, Shuma, Data_Pageses, Lloji_Pageses) " +
                               "VALUES (@KlientiID, @ShumaPageses, @DataPageses, @LlojiPageses)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KlientiID", klientiID);
                command.Parameters.AddWithValue("@ShumaPageses", shumaPageses);
                command.Parameters.AddWithValue("@DataPageses", dataPageses);
                command.Parameters.AddWithValue("@LlojiPageses", llojiPageses);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Pagesa u regjistrua me sukses!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë regjistrimit të pagesës: " + ex.Message);
                }
            }
        }

        private void MenaxhimiPagesav_Load(object sender, EventArgs e)
        {
            // Ngarkoni klientët në comboBoxKlienti
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryKlientet = "SELECT Klienti_ID, CONCAT(Emri, ' ', Mbiemri) AS EmriMbiemri FROM Klientet WHERE AnetarAktiv = 1";
                SqlDataAdapter adapterKlientet = new SqlDataAdapter(queryKlientet, connection);
                System.Data.DataTable dtKlientet = new System.Data.DataTable();
                adapterKlientet.Fill(dtKlientet);
                comboBoxKlienti.DisplayMember = "EmriMbiemri";
                comboBoxKlienti.ValueMember = "Klienti_ID";
                comboBoxKlienti.DataSource = dtKlientet;
            }

            // Ngarkoni llojet e pagesave në comboBoxLlojiPageses
            comboBoxLlojiPageses.Items.Add("Pagesë mujore");
            comboBoxLlojiPageses.Items.Add("Dënim për vonesë");
            comboBoxLlojiPageses.SelectedIndex = 0; // Vendosim një opsion të paracaktuar
        
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKlienti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
