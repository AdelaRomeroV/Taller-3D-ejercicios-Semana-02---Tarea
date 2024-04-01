using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02___Tarea01_Taller_3D
{
    internal class Pistola:RangedWeapon
    {
        public Pistola(string name, float damage, float attackSpeed, float price, Bullet bullet)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.proyectiles = bullet;
        }
    }
}
