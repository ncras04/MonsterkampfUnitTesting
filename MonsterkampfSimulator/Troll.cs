using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterkampfSimulator
{
    public class Troll : Monster
    {
        public Troll(float _hp, float _ap, float _dp) : base(_hp, _ap, _dp)
        {
        }

        public override void Attack(Monster _monster)
        {
            if (!_monster.Equals(this))
            {
                float damageAmount = AP;
                _monster.TakeDamage(damageAmount);
            }
            else Console.WriteLine("Stop hitting your own kind!");
        }

        public override void TakeDamage(float _damageAmount)
        {
            float tempDMG;
            tempDMG = _damageAmount - DP;
            if (tempDMG < 0)
            {
                //nothing
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
    }
}
