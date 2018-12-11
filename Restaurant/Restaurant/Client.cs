using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Client
    {
        Boolean typeClient;
        Plat entreeClient;
        Plat platClient;
        Plat dessertClient;
        Boolean accompagnementClient;
        Boolean solicitationsClient;

        public Client(Boolean typeClient, Plat entreeClient, Plat platClient, Plat dessertCllient, Boolean accompagnementClient, Boolean solicitationsClient)
        {
            this.typeClient = typeClient;
            this.entreeClient = entreeClient;
            this.platClient = platClient;
            this.dessertClient = dessertCllient;
            this.accompagnementClient = accompagnementClient;
            this.solicitationsClient = solicitationsClient;
        }

        public void choisirEntree(Plat plat)
        {
            this.entreeClient = plat;
        }

        public void choisirPlat(Plat plat)
        {
            this.platClient = plat;
        }

        public void choisirDessert(Plat plat)
        {
            this.dessertClient = plat;
        }
    }


}
