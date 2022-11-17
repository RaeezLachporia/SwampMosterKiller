using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    class Mage: Enemy
    {
        public Mage(int _X, int _Y, TileType _TOT, int _enemyDmg, int _enemyHp, int _enemyMaxHp, char _Symbol) : base(_X, _Y, _TOT, 5, 5, 5, 'M')
        {
            Damage = _enemyDmg;
            Hp = _enemyHp;
            MaxHp = _enemyMaxHp;
        }

        public override String ToString()
        {
            return "EnemyClassName" + " at [" + X.ToString() + Y.ToString() + "]" + Damage;
        }

        public override Movement returnMove(Movement move = Movement.noMovement)
        {
            throw new NotImplementedException();
        }

        public override CheckRange()
        {

        }

    }
}
