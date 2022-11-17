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
        Random r = new Random();


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
            int xPosition = r.Next(minHeight, maxHeight);
            int yPosition = r.Next(minWidth, maxWidth);
            Random pick = new Random();

     
            if (type == Tile.TileType.Enemy)
            {
                int numForEnemy = pick.Next(1, 2);
                if (numForEnemy ==1)
                {
                    return new SwampCreature(xPosition, yPosition, type, 10, 1, 10, 'S');
                }
                else if (numForEnemy == 2)
                {
                    return new Mage(xPosition, yPosition, Tile.TileType.Enemy, 5, 5, 5, 'M');
                }
               
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(xPosition, yPosition, type, 10, 10, 10,'H');
            }

            if (xPosition > mapHeight && yPosition > mapWidth)
            {
                return Create(Tile.TileType.Barrier);
            }
            return new Hero(xPosition, yPosition, Tile.TileType.Hero, 10, 10, 10,'H');
        }

        public void generateMap()
        {
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    if (x == 0 || x == (mapWidth- 4) || y == 0 || y == mapHeight - 1)//BORDER
                    {
                        //create the barrier blocks that the player cant move past
                        Create(Tile.TileType.Barrier, x, y);

                    }
                    else
                    {
                        //creates empty tiles that the player can move around in
                        Create(Tile.TileType.Empty, x, y);

                    }
                }
            }
            Create(Tile.TileType.Hero);
            for (int e = 0; e < enemies[].Count; e++)
            {
                Create(Tile.TileType.Enemy);
            }

        }
    }
}
