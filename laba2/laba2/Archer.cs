using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Archer : Unit, IAttacker, IMoveable
    {
        public Archer(int id, string name, int x, int y, float hp) : base(id, name, x, y, hp)
        {
        }

        public void Attack(Unit unit)
        {
            Console.WriteLine($"{Name} ataca a {unit.GetName()}");
            unit.ReceiveDamage(10); // Ejemplo de daño
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"{Name} se mueve a la posición ({X}, {Y})");
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
