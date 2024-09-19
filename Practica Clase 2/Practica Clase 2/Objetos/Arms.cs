using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2.ObjetosM
{

    // interface define qué métodos, propiedades o eventos debe implementar una clase

    interface Arms
    {
        string Name { get; }
        int Damage { get; }
    }
}
