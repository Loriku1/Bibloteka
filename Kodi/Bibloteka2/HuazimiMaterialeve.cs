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
    public partial class HuazimiMaterialeve : Form
    {
        public HuazimiMaterialeve()
        {
            InitializeComponent();
        }

        private void btnRegjistroHuazimin_Click(object sender, EventArgs e)
        {
            // Merr të dhënat nga forma
            int klientiID = Convert.ToInt32(comboBoxKlienti.SelectedValue);
            int materialiID = Convert.ToInt32(comboBoxMateriali.SelectedValue);
            DateTime dataHuazimit = dateTimePickerHuazimi.Value;
            DateTime dataKthimit = dateTimePickerKthimi.Value;
            decimal tarifaDenimi = numericUpDownTarifa.Value;

            // Marrim lidhjen nga app.config
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Huazimet (Klienti_ID, Material_ID, Data_Huazimit, Data_Kthimit, Tarifa_Denimi) " +
                               "VALUES (@KlientiID, @MaterialiID, @DataHuazimit, @DataKthimit, @TarifaDenimi)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KlientiID", klientiID);
                command.Parameters.AddWithValue("@MaterialiID", materialiID);
                command.Parameters.AddWithValue("@DataHuazimit", dataHuazimit);
                command.Parameters.AddWithValue("@DataKthimit", dataKthimit);
                command.Parameters.AddWithValue("@TarifaDenimi", tarifaDenimi);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Huazimi u regjistrua me sukses!");

                    // Pastrimi i inputeve pas regjistrimit
                    comboBoxKlienti.SelectedIndex = -1;
                    comboBoxMateriali.SelectedIndex = -1;
                    dateTimePickerHuazimi.Value = DateTime.Now;
                    dateTimePickerKthimi.Value = DateTime.Now.AddDays(7); // Vendos një vlerë të paracaktuar
                    numericUpDownTarifa.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë regjistrimit të huazimit: " + ex.Message);
                }
            }

        }

        private void HuazimiMaterialeve_Load(object sender, EventArgs e)
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

            // Ngarkoni materialet në comboBoxMateriali
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryMaterialet = "SELECT Material_ID, Titulli FROM Materialet_Bibliografike";
                SqlDataAdapter adapterMaterialet = new SqlDataAdapter(queryMaterialet, connection);
                System.Data.DataTable dtMaterialet = new System.Data.DataTable();
                adapterMaterialet.Fill(dtMaterialet);
                comboBoxMateriali.DisplayMember = "Titulli";
                comboBoxMateriali.ValueMember = "Material_ID";
                comboBoxMateriali.DataSource = dtMaterialet;
            }
        }


    }
    
}
