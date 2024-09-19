using Practica_Clase_2.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2.ObjetosM
{
    interface Item
    {
        string Name { get; }
        void Use(Player player);
    }
}
