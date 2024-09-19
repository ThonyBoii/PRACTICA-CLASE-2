using Practica_Clase_2.ObjetosM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_2.Personajes
{
    class Player : Personaje
    {
        public List<Item> Items { get; private set; }
        public Arms CurrentWeapon { get; set; }

        public Player(string nombre, int vida, int fuerza, int defensa)
        {
            Name = nombre;
            Life = vida;
            Force = fuerza;
            Defense = defensa;
            Items = new List<Item>();
        }

        public override void Attack(Enemy enemy)
        {
            int damage = (CurrentWeapon != null) ? Force + CurrentWeapon.Damage : Force;
            enemy.TakeDamage(damage);
        }

        public void UseItem(Item item)
        {
            item.Use(this);
            Items.Remove(item);
        }
    }
}
