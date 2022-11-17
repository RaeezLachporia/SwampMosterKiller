using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    abstract class Enemy : Character
    {
        protected Random randomNumberGen = new Random();

        public Enemy(int _X, int _Y, TileType _TOT, int _enemyDmg, int _enemyHp, int _enemyMaxHp, char _Symbol) : base(_X, _Y, _TOT)
        {
            Damage = _enemyDmg;
            Hp = _enemyHp;
            MaxHp = _enemyMaxHp;
        }

        private int enemyDmg;

        public int EnemyDmg
        {
            get { return enemyDmg; }
            set { enemyDmg = value; }
        }

        public override String ToString()
        {
            return "EnemyClassName" + " at [" + X.ToString() + Y.ToString() + "]" + Damage;
        }

    }

    public class LeaderClass 
    {
        private int leaderlocate;

        public int LEADERLOCATE
        {
            get { return leaderlocate; }
            set { leaderlocate = value; }
        }

        public LeaderClass(int _X, int _Y, string _Symbol, int _enemyHp, int _enemyDamage) 
        {
            LeaderClass Leader = new LeaderClass(0, 0,  "L", 20, 2);

            
        }

        public override int ReturnMove()
        {
            throw new NotImplementedException();
        }
    }
}
