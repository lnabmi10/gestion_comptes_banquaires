using GestionComptesBanquaires.Crud.ClassesLogique;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComptesBanquaires.Crud.Methode
{
    internal class GestionClient
    {

        private Connection connexion; // Instance de la classe Connection pour établir la connexion avec la base de données

        public GestionClient(Connection connexion)
        {
            this.connexion = connexion;
        }

        // Méthode pour ajouter un client à la base de données
        public void AjouterClient(int clientId,string nom, string prenom, string numeroTelephone)
        {
            // Créer une nouvelle instance de la classe Client avec les données reçues depuis le formulaire
            Client nouveauClient = new Client(clientId,nom, prenom, numeroTelephone);


            // Ouvrir la connexion avec la base de données
            using (SqlConnection con = connexion.OuvrirConnexion())

            {
                if (con != null)
                {
                    string sql = "INSERT INTO Clients (ClientId, Nom, Prenom, NumeroTelephone) VALUES (@ClientId, @Nom, @Prenom, @NumeroTelephone)";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@ClientId", nouveauClient.ClientId);
                    command.Parameters.AddWithValue("@Nom", nouveauClient.Nom);
                    command.Parameters.AddWithValue("@Prenom", nouveauClient.Prenom);
                    command.Parameters.AddWithValue("@NumeroTelephone", nouveauClient.NumeroTelephone);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Client ajouté avec succès.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du client: " + ex.Message);
                    }
                }
            }
        }
    }
}
   
