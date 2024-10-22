using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una unidad Archer
            Archer archer = new Archer(1, "Arquero", 0, 0, 100);
            archer.Move(10, 20);
            archer.Attack(new Archer(2, "Enemigo", 30, 40, 80));

            // Crear una fortaleza
            Fort fort = new Fort(3, "Fortaleza", 50, 50, true);
            fort.Attack(archer);

            // Crear una casa móvil
            MobileHome mobileHome = new MobileHome(4, "Casa móvil", 5, 5, true);
            mobileHome.Move(15, 25);

            // Mensaje final para que el usuario vea la salida y pueda salir del programa
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }


}
