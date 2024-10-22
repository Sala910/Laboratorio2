using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public abstract class GameObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public GameObject(int id, string name, int x, int y)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
        }

        public abstract string GetName();
        public abstract int GetId();
        public abstract int GetX();
        public abstract int GetY();
    }

}
