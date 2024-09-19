using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2.Personajes
{
    abstract class Enemy
    {
        string Name { get; }
        int Life { get; set; }
        int Attack { get; }
        int Defense { get; }

        public void AttackPlayer(Player player)
        { 
        }
        public void TakeDamage(int damage)
        {
            if (Life < 0) Life = 0;
        }
    }
}
