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
       
 //declaring the variables for the class
        int heroX, heroY;
        private int hp;
        String heroSymbol;
        String info;

        //declaring the getters and setters for the hp, max hp and hero damage 
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxhp;

        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int heroDamage;

        public Hero(int _X, int _Y, TileType _TOT, string _Symbol, int _maxHp, int _Damage) : base(_X, _Y, _TOT)
        {
            heroX = _X;
            heroY = _Y;
            MAXHP = _maxHp;
            heroSymbol = _Symbol;
        }

        public int HERODAMAGE
        {
            get { return heroDamage; }
            set { heroDamage = value; }
        }


        //declaring the constructors and pulling the different variables 
        
        public Movement noMovement()
        {
            if (movement != Movement.Down)
            {
                return Movement.noMovement;
            }
            else if (movement != Movement.Up)
            {
                return Movement.noMovement;
            }
            else if (movement != Movement.Left)
            {
                return Movement.noMovement;
            }
            else if (movement != Movement.Right)
            {
                return Movement.noMovement;
            }
            else
            {
                return Movement.noMovement;
            }

        }
        //this method determines the how the players will move on the grid by either plussing or minussing values to move the player 
        public void move(Movement move)
        {
            switch (move)
            {
                case Movement.Up:
                    Y--;
                    break;
                case Movement.Down:
                    Y++;
                    break;
                case Movement.Left:
                    X--;
                    break;
                case Movement.Right:
                    X++;
                    break;
            }

            movement = move;
        }//store current move
        /*public override RetrunMove()
        {
        }*/
            //this method displayss the information related to this class
        public override string ToString()
        {
            info += "Player Stats:";
            info += "HP:" +"/" + "MaxHp:";
            info += "Damage: " + heroDamage;

            return info;
        }

        public int ReturnMove(Movement move)
        {
            return Convert.ToInt32(move);
        }

        public override int ReturnMove()
        {
            throw new NotImplementedException();
        }
    }
    }
}
