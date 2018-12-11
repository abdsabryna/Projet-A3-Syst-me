using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class MaitreHotel
    {

        private MaitreHotel instance;

        private double chiffreAffaire;

        private MaitreHotel()
        {
            chiffreAffaire = 0;
        }

           // Singleton

        public MaitreHotel getInstance()
        {
            if (instance == null)
            {
                instance = new MaitreHotel();
            }
            return instance;
        }

        public void accueuillirClient()
        {

        }

        public void placerClient()
        {

        }

        public double getChiffreAffaire()
        {
            return this.chiffreAffaire;
        }

        public void setChiffreAffaire(double paiement)
        {
            this.chiffreAffaire = paiement;
        }


    }
}
