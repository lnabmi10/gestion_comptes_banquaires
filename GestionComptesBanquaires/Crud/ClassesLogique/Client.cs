using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComptesBanquaires.Crud.ClassesLogique
{
    internal class Client
    {

        // Propriétés de la classe Client
        public int ClientId;
        public string Nom;
        public string Prenom;
        public string NumeroTelephone;

        // Constructeur de la classe Client
        public Client(int clientId, string nom, string prenom, string numeroTelephone)
        {
            this.ClientId = clientId;
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumeroTelephone = numeroTelephone;
        }

        public Client() { }
    }
}
