using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public abstract class Unit : GameObject
    {
        public float Hp { get; set; }

        public Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
        {
            Hp = hp;
        }

        public bool IsAlive() => Hp > 0;

        public void ReceiveDamage(float damage)
        {
            Hp -= damage;
            if (Hp < 0) Hp = 0;
        }
    }

}
