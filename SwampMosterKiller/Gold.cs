using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
     class Gold : Item
    {
        
        private int goldPerDrop;
        public int GoldPerDrop
        {
            get { return goldPerDrop; }
            set { goldPerDrop = value; }
        }

        Random gr = new Random();

        public Gold(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {
            int goldRandom = gr.Next(1, 5);
        }
    }
}
