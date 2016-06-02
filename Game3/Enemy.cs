using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3
{
    class Enemy
    {
        public int Health { get; set; }
        public int AttackDamage { get; set; }

        public Enemy(int cHealth, int cAttackDamage)
        {
            Health = cHealth;
            AttackDamage = cAttackDamage;
        }
    }
}
