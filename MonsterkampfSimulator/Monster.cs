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
            if (_hp > 100f)
            {
                HP = 100;
            }
            else if (_hp < 30f)
            {
                HP = 30;
            }
            else

                HP = _hp;
            AP = _ap;
            DP = _dp;
        }

        public void TakeDamage(float _damageAmount)
        {
            float tempDMG;
            tempDMG = _damageAmount - DP;

            if (tempDMG < 0)
            {
                HP = HP;
            }
            else
            {
                HP = HP - tempDMG;
            }

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
