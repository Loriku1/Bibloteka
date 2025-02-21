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
    public partial class MenaxhimiPerdoruesveSistemit : Form
    {
        public MenaxhimiPerdoruesveSistemit()
        {
            InitializeComponent();
        }

        private void MenaxhimiPerdoruesveSistemit_Load(object sender, EventArgs e)
        {
            // Shto rollat e mundshëm në ComboBox
            comboBoxRole.Items.Add("Administrator");
            comboBoxRole.Items.Add("Bibliotekar");
            comboBoxRole.Items.Add("Përdorues");
            comboBoxRole.SelectedIndex = 0; // Vendos një rol të paracaktuar
        }

        private void btnAddOrUpdateUser_Click(object sender, EventArgs e)
        {
            // Merr të dhënat nga formë
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kontrollo nëse përdoruesi ekziston, dhe modifiko ose shto përdoruesin
                string query = "IF EXISTS (SELECT 1 FROM Perdoruesit WHERE Emri_Perdoruesit = @username) " +
                               "UPDATE Perdoruesit SET Fjalekalimi = @password, Roli = @role WHERE Emri_Perdoruesit = @username " +
                               "ELSE " +
                               "INSERT INTO Perdoruesit (Emri_Perdoruesit, Fjalekalimi, Roli) VALUES (@username, @password, @role)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

                command.ExecuteNonQuery();
                MessageBox.Show("Përdoruesi është regjistruar/modifikuar me sukses!");



                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Të gjitha fushat janë të detyrueshme.");
                    return;
                }


            }
        }
    }
}
