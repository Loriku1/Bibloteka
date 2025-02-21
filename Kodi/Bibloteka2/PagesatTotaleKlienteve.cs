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
    public partial class PagesatTotaleKlienteve : Form
    {
        public PagesatTotaleKlienteve()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Merr datën e zgjedhur nga DateTimePicker
            DateTime selectedDate = dateTimePickerFilter.Value;
            int selectedMonth = selectedDate.Month;
            int selectedYear = selectedDate.Year;

            // Përditësoni Label për periudhën që është filtruar
            labelSelectedPeriod.Text = $"Pagesat për: {selectedMonth}/{selectedYear}";

            // Krijoni lidhjen me databazën
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query për të marrë totalet e pagesave për secilin klient, të filtruar sipas muajit dhe vitit
                string query = @"SELECT k.Emri, k.Mbiemri, SUM(p.Shuma) AS TotalPagesa
                         FROM Klientet k
                         INNER JOIN Pagesat p ON k.Klienti_ID = p.Klienti_ID
                         WHERE YEAR(p.Data_Pageses) = @year AND MONTH(p.Data_Pageses) = @month
                         GROUP BY k.Emri, k.Mbiemri";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", selectedYear);
                command.Parameters.AddWithValue("@month", selectedMonth);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Vendos të dhënat në DataGridView
                dataGridViewPayments.DataSource = dataTable;

            }
        }

        private void PagesatTotaleKlienteve_Load(object sender, EventArgs e)
        {
            // Ngarko periudhën e paracaktuar (muaji dhe viti aktual)
            dateTimePickerFilter.Value = DateTime.Now;

            // Ngarko të dhënat për periudhën e paracaktuar
            btnFilter.PerformClick();
        }
    }
}
