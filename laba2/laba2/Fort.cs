using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Fort : Building, IAttacker
    {
        public Fort(int id, string name, int x, int y, bool built) : base(id, name, x, y, built)
        {
        }

        public void Attack(Unit unit)
        {
            Console.WriteLine($"{Name} dispara desde la fortaleza a {unit.GetName()}");
            unit.ReceiveDamage(15); // Ejemplo de daño
        }

        // Implementación de los métodos abstractos de GameObject
        public override string GetName()
        {
            return Name;
        }

        public override int GetId()
        {
            return Id;
        }

        public override int GetX()
        {
            return X;
        }

        public override int GetY()
        {
            return Y;
        }
    }

}
