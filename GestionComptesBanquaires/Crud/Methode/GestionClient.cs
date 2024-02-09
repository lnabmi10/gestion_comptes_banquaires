using GestionComptesBanquaires.Crud.ClassesLogique;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetClientsData()
        {
            DataTable tableClients = new DataTable();

            // Ouvrir la connexion avec la base de données
            using (SqlConnection connection = connexion.OuvrirConnexion())
            {
                if (connection != null)
                {
                    // Créer une commande SQL pour sélectionner toutes les données de la table Clients
                    string sql = "SELECT * FROM Clients";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Créer un SqlDataAdapter pour exécuter la commande et remplir un DataTable avec les résultats
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(tableClients);
                }
            }

            return tableClients;
        }
        public DataTable GetUpdatedClientsData()
        {
            // Récupérer les données mises à jour des clients
            DataTable updatedClientsData = GetClientsData();
            return updatedClientsData;
        }


        // Méthode pour modifier un client dans la base de données
        public void ModifierClient(int clientId, string nom, string prenom, string numeroTelephone)
        {
            // Ouvrir la connexion avec la base de données
            using (SqlConnection connection = connexion.OuvrirConnexion())
            {
                if (connection != null)
                {
                    // Créer une commande SQL pour mettre à jour les informations du client
                    string sql = "UPDATE Clients SET Nom = @Nom, Prenom = @Prenom, NumeroTelephone = @NumeroTelephone WHERE ClientId = @ClientId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@NumeroTelephone", numeroTelephone);
                    command.Parameters.AddWithValue("@ClientId", clientId);

                    // Exécuter la commande SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour supprimer un client de la base de données
        public void SupprimerClient(int clientId)
        {
            // Ouvrir la connexion avec la base de données
            using (SqlConnection connection = connexion.OuvrirConnexion())
            {
                if (connection != null)
                {
                    // Créer une commande SQL pour supprimer le client
                    string sql = "DELETE FROM Clients WHERE ClientId = @ClientId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ClientId", clientId);

                    // Exécuter la commande SQL
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
    