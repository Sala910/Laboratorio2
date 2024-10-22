using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class MobileHome : Building, IMoveable
    {
        public MobileHome(int id, string name, int x, int y, bool built) : base(id, name, x, y, built)
        {
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
