using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02___Tarea01_Taller_3D
{
    internal class Sword:MeleeWeapon
    {
        public Sword(string name, float damage, float attackSpeed, float price) 
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
        }
    }
}
