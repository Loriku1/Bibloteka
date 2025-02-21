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
    public partial class HuazimetVonuara : Form
    {
        public HuazimetVonuara()
        {
            InitializeComponent();
        }

        private void HuazimetVonuara_Load(object sender, EventArgs e)
        {
            // Vendos periudhën e datës për filtrimin e huazimeve të vonuara
            dateTimePickerDelayedLoans.Value = DateTime.Now;
            // Pasi formë ngarkohet, filtroni me periudhën aktuale
            btnFilterDelayedLoans.PerformClick();
        }

        private void btnFilterDelayedLoans_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDelayedLoans.Value;
            int selectedMonth = selectedDate.Month;
            int selectedYear = selectedDate.Year;

            // Krijoni lidhjen me databazën
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query për të marrë huazimet e vonuara (Data_Pristinës duhet të jetë më herët se Data_Kthimit aktuale)
                string query = @"SELECT k.Emri, k.Mbiemri, m.Titulli, h.Data_Huazimit, h.Data_Kthimit, 
                        DATEDIFF(DAY, h.Data_Kthimit, GETDATE()) AS Vonesat
                 FROM Huazimet h
                 INNER JOIN Klientet k ON h.Klienti_ID = k.Klienti_ID
                 INNER JOIN Materialet_Bibliografike m ON h.Material_ID = m.Material_ID
                 WHERE h.Data_Kthimit < GETDATE() 
                 AND YEAR(h.Data_Huazimit) = @year 
                 AND MONTH(h.Data_Huazimit) = @month";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", selectedYear);
                command.Parameters.AddWithValue("@month", selectedMonth);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Vendos të dhënat në DataGridView
                dataGridViewDelayedLoans.DataSource = dataTable;
            }

            // Azhurnimi i etiketës për periudhën e filtruar
            labelSelectedPeriod.Text = $"Huazimet për: {selectedMonth}/{selectedYear}";
        }

        private void labelSelectedPeriod_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDelayedLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
