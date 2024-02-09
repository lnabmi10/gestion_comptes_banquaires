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
    public partial class GestionnaireCompte : Form
    {


        private GestionCompte gestionCompte;

        public GestionnaireCompte()
        {
            InitializeComponent();
            Connection connexion = new Connection();
            gestionCompte = new GestionCompte(connexion);

            dataComptes.CellClick += dataComptes_CellContentClick;
        }

        private void ajouterCompte_Click(object sender, EventArgs e)
        {
            int compteId = int.Parse(CompteIdtext.Text);
            int clientId = int.Parse(CompteClientId.Text);
            decimal solde = decimal.Parse(CompteSolde.Text);
            string typeCompte = CompteType.Text;
            DateTime dateOuverture = CompteDateOuverture.Value;

            gestionCompte.AjouterCompte(compteId, clientId, solde, typeCompte, dateOuverture);
            dataComptes.DataSource = gestionCompte.GetUpdatedComptesData();
        }

        private void GestionnaireCompte_Load(object sender, EventArgs e)
        {
            dataComptes.Columns.Clear();
            dataComptes.DataSource = gestionCompte.GetComptesData();
            ResetTextBoxes();
        }

        private void dataComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataComptes.Rows[e.RowIndex];
                int CompteId = Convert.ToInt32(row.Cells["CompteId"].Value);
                int ClientId = Convert.ToInt32(row.Cells["ClientId"].Value);
                decimal Solde = Convert.ToDecimal(row.Cells["Solde"].Value);
                string TypeCompte = row.Cells["TypeCompte"].Value.ToString();
                DateTime DateOuverture = Convert.ToDateTime(row.Cells["DateOuverture"].Value);

                CompteIdtext.Text = CompteId.ToString();
                CompteClientId.Text = ClientId.ToString();
                CompteSolde.Text = Solde.ToString();
                CompteType.Text = TypeCompte;
                CompteDateOuverture.Value = DateOuverture;

                modifierCompte.Enabled = true;
                supprimerCompte.Enabled = true;
                ajouterCompte.Enabled = false;
            }
            else
            {
                modifierCompte.Enabled = false;
                supprimerCompte.Enabled = false;
            }
        }

        private void modifierCompte_Click_1(object sender, EventArgs e)
        {
            int compteId = Convert.ToInt32(CompteIdtext.Text);
            int clientId = Convert.ToInt32(CompteClientId.Text);
            decimal solde = decimal.Parse(CompteSolde.Text);
            string typeCompte = CompteType.Text;
            DateTime dateOuverture = CompteDateOuverture.Value;

            gestionCompte.ModifierCompte(compteId, clientId, solde, typeCompte, dateOuverture);
            dataComptes.DataSource = gestionCompte.GetUpdatedComptesData();
            ResetTextBoxes();
        }

        private void supprimerCompte_Click_1(object sender, EventArgs e)
        {
            int compteId = Convert.ToInt32(CompteIdtext.Text);
            gestionCompte.SupprimerCompte(compteId);
            dataComptes.DataSource = gestionCompte.GetUpdatedComptesData();
            ResetTextBoxes();
        }

        private void ResetTextBoxes()
        {
            CompteIdtext.Text = string.Empty;
            CompteClientId.Text = string.Empty;
            CompteSolde.Text = string.Empty;
            CompteType.Text = string.Empty;
            CompteDateOuverture.Value = DateTime.Now;

            ajouterCompte.Enabled = true;
            modifierCompte.Enabled = false;
            supprimerCompte.Enabled = false;
        }

        

        private void fermer_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir fermer le formulaire ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void vider_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }
    }
}
