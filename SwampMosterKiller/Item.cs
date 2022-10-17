using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    abstract class Item : Tile
    {
        protected Item(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {

        }

        public override string ToString()
        {
            return "the Item is " + TileType.Weapon;
        }

    }
}
