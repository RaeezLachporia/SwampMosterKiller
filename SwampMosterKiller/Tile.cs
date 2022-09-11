using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    abstract class Tile
    {
        private int x;
         public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;
        public int Y 
        { 
            get { return y; }
            set { y = value; }
        }

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }

        public TileType TOT
        {
            get { return TOT; }
            set { TOT = value; }
        }

        public Tile(int _X, int _Y, TileType _TOT)
        {
            X = _X;
            Y = _Y;
            TOT = _TOT;
        }
    }

     class Obstacle :Tile 
    {
        public Obstacle(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {

        }
    }

    class emptyTile : Tile
    {
        public emptyTile(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {
        }
    }
}
