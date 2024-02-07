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
        private int compteId;
        private int clientId;
        private decimal solde;
        private string typeCompte;
        private DateTime dateOuverture;

        // Constructeur de la classe Compte
        public Compte(int compteId, int clientId, decimal solde, string typeCompte, DateTime dateOuverture)
        {
            this.compteId = compteId;
            this.clientId = clientId;
            this.solde = solde;
            this.typeCompte = typeCompte;
            this.dateOuverture = dateOuverture;
        }
        public Compte() { }


    }
}
