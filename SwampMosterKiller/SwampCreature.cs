using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    class SwampCreature : Enemy
    {
        public SwampCreature(int _X, int _Y, TileType _TOT, int _enemyDmg, int _enemyHp, int _enemyMaxHp, char _Symbol) : base(_X, _Y, _TOT, 1, 10, 10, 'S')
        {
            
        }
    }
}
