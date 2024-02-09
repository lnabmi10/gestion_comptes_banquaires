using GestionComptesBanquaires.Crud.Methode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComptesBanquaires.Formulaire
{
    public partial class GestionnaireClient : Form
    {
        private GestionClient gestionClient;


        public GestionnaireClient()
        {
            InitializeComponent();
            Connection connexion = new Connection();
            gestionClient = new GestionClient(connexion);

            dataClients.CellClick += dataClients_CellClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les informations depuis les contrôles du formulaire
            int clientId = int.Parse(ClientId.Text);
            string nom = ClientNom.Text;
            string prenom = ClientPrenom.Text;
            string numeroTelephone = ClientTel.Text;

            // Ajouter le client en utilisant la méthode AjouterClient de la classe GestionnaireClient
            gestionClient.AjouterClient(clientId, nom, prenom, numeroTelephone);
            dataClients.DataSource = gestionClient.GetUpdatedClientsData();
        }

        private void GestionnaireClient_Load(object sender, EventArgs e)
        {
            dataClients.Columns.Clear();
            dataClients.DataSource = gestionClient.GetClientsData();
            ResetTextBoxes();

        }
        private void dataClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si l'utilisateur a cliqué sur une cellule de contenu (pas sur l'en-tête de colonne ou une cellule vide)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Récupérer les données du client sélectionné dans la ligne cliquée
                DataGridViewRow row = dataClients.Rows[e.RowIndex];
                int clientId = Convert.ToInt32(row.Cells["ClientId"].Value); // Récupérer l'ID du client
                string nom = row.Cells["Nom"].Value.ToString();
                string prenom = row.Cells["Prenom"].Value.ToString();
                string numeroTelephone = row.Cells["NumeroTelephone"].Value.ToString();

                // Afficher les données du client dans les TextBox appropriés
                ClientId.Text = clientId.ToString(); // Afficher l'ID du client
                ClientNom.Text = nom;
                ClientPrenom.Text = prenom;
                ClientTel.Text = numeroTelephone;

                // Activer le bouton "Modifier" et "Supprimer" et désactiver le bouton "Ajouter"
                modifierClient.Enabled = true;
                supprimerClient.Enabled = true;
                ajouterClient.Enabled = false;
            }
            else
            {
                // Si aucune ligne n'est sélectionnée, désactiver le bouton "Modifier" et "Supprimer"
                modifierClient.Enabled = false;
                supprimerClient.Enabled = false;
            }
        }

        private void modifierClient_Click(object sender, EventArgs e)
        {
            
                // Récupérer les informations modifiées depuis les TextBox
                int clientId = Convert.ToInt32(ClientId.Text);
                string nom = ClientNom.Text;
                string prenom = ClientPrenom.Text;
                string numeroTelephone = ClientTel.Text;

                // Mettre à jour les informations du client dans la base de données
                gestionClient.ModifierClient(clientId, nom, prenom, numeroTelephone);

                // Rafraîchir les données du DataGridView après la modification
                dataClients.DataSource = gestionClient.GetUpdatedClientsData();

                // Réinitialiser les TextBox
                ResetTextBoxes();
            
        }

        private void supprimerClient_Click(object sender, EventArgs e)
        {
            // Récupérer l'ID du client à supprimer depuis le TextBox
            int clientId = Convert.ToInt32(ClientId.Text);

            // Supprimer le client de la base de données
            gestionClient.SupprimerClient(clientId);

            // Rafraîchir les données du DataGridView après la suppression
            dataClients.DataSource = gestionClient.GetUpdatedClientsData();

            // Réinitialiser les TextBox
            ResetTextBoxes();
        }
        private void ResetTextBoxes()
        {
            ClientId.Text = string.Empty;
            ClientNom.Text = string.Empty;
            ClientPrenom.Text = string.Empty;
            ClientTel.Text = string.Empty;

            // Activer le bouton "Ajouter" et désactiver le bouton "Modifier" et "Supprimer"
            ajouterClient.Enabled = true;
            modifierClient.Enabled = false;
            supprimerClient.Enabled = false;
        }

        private void vider_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            // Afficher un MessageBox pour demander confirmation de fermeture
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir fermer le formulaire ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                // Fermer le formulaire si l'utilisateur répond "Oui"
                this.Close();
            }
        }
    }


    

}
