using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02___Tarea01_Taller_3D
{
    internal class Bullet: Proyectiles
    {
       public Bullet(float damage, float price)
        {
            this.damage = damage;
            this.price = price;
        }
    }
}
