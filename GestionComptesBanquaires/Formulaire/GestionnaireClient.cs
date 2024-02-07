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
        }
    }
    
}
