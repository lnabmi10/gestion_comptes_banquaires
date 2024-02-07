using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComptesBanquaires.Crud.ClassesLogique
{
    internal class Transaction
    {
        // Propriétés privées de la classe Transaction
        private int transactionId;
        private int compteId;
        private string typeTransaction;
        private decimal montant;
        private DateTime dateTransaction;

        // Constructeur de la classe Transaction
        public Transaction(int transactionId, int compteId, string typeTransaction, decimal montant, DateTime dateTransaction)
        {
            this.transactionId = transactionId;
            this.compteId = compteId;
            this.typeTransaction = typeTransaction;
            this.montant = montant;
            this.dateTransaction = dateTransaction;
        }

    }
}
