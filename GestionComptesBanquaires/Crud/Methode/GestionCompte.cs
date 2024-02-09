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
    internal class GestionCompte
    {
        private Connection connexion;

        public GestionCompte(Connection connexion)
        {
            this.connexion = connexion;
        }

        // Méthode pour ajouter un compte à la base de données
        public void AjouterCompte(int compteId, int clientId, decimal solde, string typeCompte, DateTime dateOuverture)
        {
            Compte nouveauCompte = new Compte(compteId, clientId, solde, typeCompte, dateOuverture);

            using (SqlConnection con = connexion.OuvrirConnexion())
            {
                if (con != null)
                {
                    string sql = "INSERT INTO Comptes (CompteId, ClientId, Solde, TypeCompte, DateOuverture) VALUES (@CompteId, @ClientId, @Solde, @TypeCompte, @DateOuverture)";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@CompteId", nouveauCompte.CompteId);
                    command.Parameters.AddWithValue("@ClientId", nouveauCompte.ClientId);
                    command.Parameters.AddWithValue("@Solde", nouveauCompte.Solde);
                    command.Parameters.AddWithValue("@TypeCompte", nouveauCompte.TypeCompte);
                    command.Parameters.AddWithValue("@DateOuverture", nouveauCompte.DateOuverture);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Compte ajouté avec succès.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du compte: " + ex.Message);
                    }
                }
            }
        }

        // Méthode pour modifier un compte dans la base de données
        public void ModifierCompte(int compteId, int clientId, decimal solde, string typeCompte, DateTime dateOuverture)
        {
            using (SqlConnection connection = connexion.OuvrirConnexion())
            {
                if (connection != null)
                {
                    string sql = "UPDATE Comptes SET ClientId = @ClientId, Solde = @Solde, TypeCompte = @TypeCompte, DateOuverture = @DateOuverture WHERE CompteId = @CompteId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@Solde", solde);
                    command.Parameters.AddWithValue("@TypeCompte", typeCompte);
                    command.Parameters.AddWithValue("@DateOuverture", dateOuverture);
                    command.Parameters.AddWithValue("@CompteId", compteId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour supprimer un compte de la base de données
        public void SupprimerCompte(int compteId)
        {
            using (SqlConnection connection = connexion.OuvrirConnexion())
            {
                if (connection != null)
                {
                    string sql = "DELETE FROM Comptes WHERE CompteId = @CompteId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@CompteId", compteId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour obtenir les données des comptes
        public DataTable GetComptesData()
        {
            DataTable tableComptes = new DataTable();

            using (SqlConnection connection = connexion.OuvrirConnexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT * FROM Comptes";
                    SqlCommand command = new SqlCommand(sql, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(tableComptes);
                }
            }

            return tableComptes;
        }

        // Méthode pour obtenir les données des comptes mises à jour
        public DataTable GetUpdatedComptesData()
        {
            DataTable updatedComptesData = GetComptesData();
            return updatedComptesData;
        }
    }
}
