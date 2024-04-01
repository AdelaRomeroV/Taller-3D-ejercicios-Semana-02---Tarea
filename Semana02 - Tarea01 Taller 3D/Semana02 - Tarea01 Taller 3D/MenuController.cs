using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02___Tarea01_Taller_3D
{
    internal class MenuController
    {
        private List<Weapon> weapon;

        public void Start()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Selecciona la opcion:\n ");

                Console.WriteLine("1. Agregar espada");
                Console.WriteLine("2. Agregar pistola");
                Console.WriteLine("3. Agregar arco");
                Console.WriteLine("4. Salir");

                string Option = Console.ReadLine();

                switch (Option)
                {
                    case "0":
                        continueFlag = false;
                        break;

                    case "1":
                        AddEspada();
                        break;

                    case "2":
                        AddArma();
                        break;

                    case "3":
                        AddArco();
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }          
            }
        }
        private void AddEspada()
        {
            Console.WriteLine("Introduce el nombre de la espada:\n ");
            string name = Console.ReadLine();

            Console.WriteLine("introduce el daño de la espada:\n ");
            float damage = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la velocidad de ataque de la espada: \n");
            float attackSpeed = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el precio de la espada:\n ");
            float price = float.Parse(Console.ReadLine());
        }

        private void AddArma() 
        {
            Console.WriteLine("Introduce el nombre del arma: \n");
            string name = Console.ReadLine();

            Console.WriteLine("Introduce el daño de la espalda: \n");
            float damage = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la velocidad de ataque: \n");
            float attackSpeed = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad de balas: \n");
            float bullet = float.Parse(Console.ReadLine());
        }

        private void AddArco()
        {
            Console.WriteLine("Introduce el nombre del arco: \n");
            string name = Console.ReadLine();

            Console.WriteLine("Introduce el daño de la arco: \n");
            float damage = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la velocidad de ataque: \n");
            float attackSpeed = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad de flechas: \n");
            float bullet = float.Parse(Console.ReadLine());
        }
    
    }
}
