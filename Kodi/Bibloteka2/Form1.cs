using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Bibloteka2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Marrim lidhjen nga app.config
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Perdoruesit WHERE Emri_Perdoruesit = @username AND Fjalekalimi = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string role = reader["Roli"].ToString();
                        MessageBox.Show("Hyrje e suksesshme si " + role);

                        // Redirect to the corresponding form based on role
                        if (role == "Administrator")
                        {
                            // Hapen format për Administratorin
                            AdministratorForm adminForm = new AdministratorForm();
                            adminForm.Show();
                        }
                        else if (role == "Bibliotekar")
                        {
                            // Hapen format për Bibliotekarin
                            BiblotekarForm bibliotekarForm = new BiblotekarForm();
                            bibliotekarForm.Show();
                        }
                        else if (role == "Përdorues")
                        {
                            // Hapen format për Përdoruesin
                            PerdoruesiForm perdoruesForm = new PerdoruesiForm();
                            perdoruesForm.Show();
                        }

                        // Mbyllim formën e login pas hyrjes
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Emri i përdoruesit ose fjalëkalimi është gabim.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ndodhi një gabim: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
