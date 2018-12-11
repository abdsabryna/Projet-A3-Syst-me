using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{

    class Menu
    {

        public Menu()
        {
            List<Plat> menu;
            menu = new List<Plat>();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("");
                menu.Add(new Plat("Plat " + i.ToString(), true));
                }
            Console.WriteLine(menu[2].getNom() + ", " + menu[2].getDisponibilite());
        }
    }
}
