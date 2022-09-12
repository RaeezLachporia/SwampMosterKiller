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

        public override returnMove(Movement move = default(Movement))
        {
            bool canMove = false;

            int move = 0;

            MovementEnum Direction = MovementEnum.NoMovement;


            while (canMove == false)
            {
                move = r.Next(0, 5);
                canMove = true;



                if ((heroVision[move].ToString() != "Boundary") & (heroVision[move].ToString() != "Hero"))
                {
                    canMove = true;
                }
            }
            return (MovementEnum)move;
        }
    }

    class Hero : Character
    {
        public Hero(int _X, int _Y, TileType _TOT ,int _Damage, int _Hp, int _MaxHp, char _Symbol) : base(_X, _Y, _TOT,2,10,10,'H')
        {

        }

        public override ToString()
        {
            return "Hero" + "HP:" + Hp + "/" + MaxHp+"\n" + "damage" + Damage+ " [" + x.ToString() + y.ToString() + "]" ;
        }
    }
}
