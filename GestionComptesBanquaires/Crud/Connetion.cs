using GestionComptesBanquaires;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComptesBanquaires
{
    class Connection
    {

        // Chaîne de connexion à la base de données

        private string connectionString = "Data Source=DESKTOP-I8H2H57;Initial Catalog=Gestion_de_Comptes_Bancaires;Integrated Security=True";

        public Connection() { }

        public SqlConnection OuvrirConnexion()
        {
            // Création d'une nouvelle connexion SQL avec la chaîne de connexion par défaut
            SqlConnection connect = new SqlConnection(connectionString);
            
                try
                {
                    // Ouvrir la connexion
                    connect.Open();
                    MessageBox.Show("Connexion ouverte avec succès.");
                return connect;
            }
                catch (SqlException ex)
                {
                    // Gérer les erreurs de connexion
                    MessageBox.Show("Erreur de connexion à la base de données: " + ex.Message);
                  return null;
                }
        }


        
    }
}