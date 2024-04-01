﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02___Tarea01_Taller_3D
{
    internal class Weapon
    {
        protected string name;
        protected float damage;
        protected float attackSpeed;

        public virtual float GetDamagePerSecond()
        {
            return damage * attackSpeed;
        }
    }
}