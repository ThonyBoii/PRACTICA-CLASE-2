using Practica_Clase_2.ObjetosM;
using Practica_Clase_2.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Héroe", 100, 20, 10);
            player.CurrentWeapon = new Sword();

            Skeleton skeleton = new Skeleton();
        }
    }
}
