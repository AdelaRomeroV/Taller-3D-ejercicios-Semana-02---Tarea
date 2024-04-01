using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02___Tarea01_Taller_3D
{
    internal class Bow:RangedWeapon
    {
        public Bow(string name, float damage, float attackSpeed, float price, Arrow arrow)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.proyectiles = arrow;
        }
    }
}
