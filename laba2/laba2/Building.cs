using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public abstract class Building : GameObject
    {
        public bool Built { get; set; }

        public Building(int id, string name, int x, int y, bool built) : base(id, name, x, y)
        {
            Built = built;
        }

        public bool IsBuilt() => Built;
    }

}
