using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Base_stats
    {
        public string name;

        private int hp;

        public virtual int attack(int a)
        {
            return 0;
        }
        
        public virtual int defence(int d)
        {
            return 0;
        }

        public bool alive()
        {
            return hp > 0;
        }

        public int GetHp()
        {
            return hp;
        }

    }
}
