using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class defensive : Base_stats
    {
        public override int attack(int a)
        {
            return base.attack(15);
        }

        public override int defence(int d)
        {
            return base.defence(25);
        }
    }
}
