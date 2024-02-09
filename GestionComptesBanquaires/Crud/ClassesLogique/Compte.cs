using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComptesBanquaires.Crud.ClassesLogique
{
    internal class Compte
    {
        // Propriétés privées de la classe Compte
        public int CompteId;
        public int ClientId;
        public decimal Solde;
        public string TypeCompte;
        public DateTime DateOuverture;

        // Constructeur de la classe Compte
        public Compte(int compteId, int clientId, decimal solde, string typeCompte, DateTime dateOuverture)
        {
            this.CompteId = compteId;
            this.ClientId = clientId;
            this.Solde = solde;
            this.TypeCompte = typeCompte;
            this.DateOuverture = dateOuverture;
        }
        public Compte() { }


    }
}
