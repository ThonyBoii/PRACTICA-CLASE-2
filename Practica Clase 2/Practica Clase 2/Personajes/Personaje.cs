using Practica_Clase_2.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2
{
    abstract class Personaje
    {
        public string Name { get; set; }
        public int Life { get; set; }
        public int Force { get; set; }
        public int Defense { get; set; }

        public abstract void Attack(Enemy enemy);
        public void TakeDamage(int damage)
        {
            Life -= damage;
            if (Life < 0) Life = 0;
        }

    }

}
