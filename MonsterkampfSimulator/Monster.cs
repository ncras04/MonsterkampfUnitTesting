using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterkampfSimulator
{
    public abstract class Monster
    {
        public float HP;
        public float AP;
        public float DP;

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

        public abstract void TakeDamage(float _damageAmount);


        public abstract void Attack(Monster _monster);
    }
}
