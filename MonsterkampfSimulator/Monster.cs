using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterkampfSimulator
{
    public class Monster
    {
        public float HP { get; private set; }
        public float AP { get; private set; }
        public float DP { get; private set; }

        public Monster(float _hp, float _ap, float _dp)
        {
            HP = _hp;
            AP = _ap;
            DP = _dp;
        }

        public void TakeDamage(float _damageAmount)
        {
            HP = HP - (_damageAmount - DP);

            if (HP < 0)
            {
                HP = 0;
            }
        }

        public void Attack(Monster _monster)
        {
            float damageAmount = AP;
            _monster.TakeDamage(damageAmount);
        }
    }
}
