using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DES_CLIENTS_HOTELS
{
    internal class Classe_Hotel
    {
        private List<Classe_Client> Notre_Liste_Clients;

        internal List<Classe_Client> Notre_Liste_Clients1 
        { 
            get => Notre_Liste_Clients; 
            set => Notre_Liste_Clients = value; 
        }
        public Classe_Hotel() 
        {
            Notre_Liste_Clients = new List<Classe_Client>();
        }
        public void Ajout_Client(Classe_Client notre_Client)
        {
            Notre_Liste_Clients.Add(notre_Client);
        }
    }
}
