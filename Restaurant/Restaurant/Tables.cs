using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Tables
    {
        int etat;
        Boolean occupe;
        Boolean pain;
        Boolean eau;
        int nombre;
  

        public Tables(int etat, Boolean occupe, Boolean pain, Boolean eau, int nombre)

        {
            this.etat = etat;
            this.occupe = occupe;
            this.pain = pain;
            this.eau = eau;
            this.nombre = nombre; 
        }
    }
}
