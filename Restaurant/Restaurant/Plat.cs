using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Plat
    {
        private String nom;
        private Boolean disponibilite;

        public Plat(String nom, Boolean disponibilite)
        {
            this.nom = nom;
            this.disponibilite = disponibilite;
        }

        public String getNom()
        {
            return this.nom;
        }
        public Boolean getDisponibilite()
        {
            return this.disponibilite;
        }
    }
}
