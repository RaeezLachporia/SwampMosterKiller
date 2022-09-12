using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    abstract class Character : Tile
    {
        protected Character(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {
        }
        private int hp;
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxhp;

        public int MaxHp
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right,
        }
        public Tile[] heroVision = new Tile[4];
        public virtual void Attack()
        {

        }

        public Boolean isDead()
        {
            bool isDead = false;

            if (hp < 0 )
            {
                isDead = true;
            }
             return isDead;
        }

        public Boolean checkRange()
        {
            int range = 1;
            bool inRange = false;

            if (range ==1)
            {
                inRange = true;
            }
            return inRange;
        }

        private int DistanceTo()
        {
            int distanceToTarget = 0;
            return distanceToTarget;
        }

        private void Move(Movement move)
        {
            if (move==Movement.Up)
            {
                
            }
            if (move == Movement.Down)
            {

            }
            if (move == Movement.Right)
            {

            }
            if (move == Movement.Left)
            {

            }
            if (move == Movement.noMovement)
            {

            }
        }

        public abstract Movement returnMove(Movement move = 0);

        public abstract override string ToString();

    }
}
