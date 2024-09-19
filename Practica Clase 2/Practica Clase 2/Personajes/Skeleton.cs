using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2.Personajes
{
    class Skeleton : Enemy
    {
        public string Name { get; } = "Goblin";
        public int Life { get; set; } = 50;
        public int Attack { get; } = 10;
        public int Defense { get; } = 5;

        public void AtacarJugador(Player player)
        {
            player.TakeDamage(Attack);
        }

        public void TakeDamage(int damage)
        {
            Life -= damage;
            if (Life < 0) Life = 0;
        }
    }
}
