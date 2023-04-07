using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DES_CLIENTS_HOTELS
{
    internal class Classe_Client
    {
        private string nom_Client { set; get; }
        private string prenom_Client { set; get; }
        private string adresse_courriel_Client { set; get; }
        private string carte_credit_client { set; get; }
        private int num_chambre_Client { set; get; }
        public Classe_Client(string nom_Client, string prenom_Client,
                            string adresse_courriel_Client, string carte_credit_client,
                            int num_chambre_Client) 
        {
            this.nom_Client = nom_Client;
            this.prenom_Client= prenom_Client;
            this.adresse_courriel_Client= adresse_courriel_Client;
            this.carte_credit_client= carte_credit_client;
            this.num_chambre_Client= num_chambre_Client;
        }

    }
}
