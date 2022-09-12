using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    class Map
    {
        int[] YAxis;
        int[] XAxis;

        Hero H = new Hero();
        SwampCreature SW = new SwampCreature();
        public Tile[,] map;
        public Enemy[] enemies;
        int mapWidth;
        int mapHeight;
        int minWidth;
        int maxWidth;
        int minHeight;
        int maxHeight;
        int numEnemy;
        int borderConstraintX;
        int borderConstraintY;
        random r = new random();


        public Map (int _minWidth, int _maxWidth, int _minHeight, int _maxHeight, int _numEnemy)
        {
            minWidth = _minWidth;
            maxWidth = _maxWidth;
            minHeight = _minHeight;
            maxHeight = _maxHeight;
            numEnemy = _numEnemy;

            mapWidth = r.Next(minWidth, maxWidth);
            mapHeight = r.Next(minHeight, maxHeight);

            borderConstraintX = mapWidth + 2;
            borderConstraintY = mapHeight + 2;

            //map = new Tile[borderConstraintX, borderConstraintY];



            enemies = new Enemy[numEnemy];

        }

        public void updateVision()
        {

        }

        private Tile Create(Tile.TileType type)
        {
            int xPosition = r.Next(MinHeight, MaxHeight);
            int yPosition = r.Next(MinWidth, MaxWidth);

     
            if (type == Tile.TileType.Enemy)
            {
                return new SwampCreature(xPosition, yPosition, type, 'S', 1, 10);
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(xPosition, yPosition, type, 'H', 10, 10);
            }

            if (xPosition > mapHeight && yPosition > mapWidth)
            {
                return Create(type);
            }
            return new Hero(xPosition, yPosition, Tile.TileType.Hero, 'H', 10, 10);
        }
    }
}
