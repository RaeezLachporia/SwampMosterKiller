using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace SwampMosterKiller
{
    class GameEngine :Map
    {
        private Map maps = new Map(5,8,3,9,6);

        public GameEngine(int _minWidth, int _maxWidth, int _minHeight, int _maxHeight, int _numEnemy) : base(_minWidth, _maxWidth, _minHeight, _maxHeight, _numEnemy)
        {
            
        }

        public bool MovePlayer(Character.Movement movement)
        {
            if (maps.PLAYERCHARACTER.ReturnMove(move) == Convert.ToInt32(move))
            {
                GAMEMAP.Create(Tile.TileType.Empty, GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y);

                GAMEMAP.PLAYERCHARACTER.move(move);
                GAMEMAP.MAPCONTAINER[GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y] = GAMEMAP.PLAYERCHARACTER;
                return true;
            }
            return false;
        }

        public void Save()
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("SwampMonsterKiller.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    // = (Map)bf.Deserialize(fsin);

                    Console.WriteLine();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Couldnt write to file ");
            }
        }

        public Boolean Load()
        {
            Boolean found = false;
            BinaryFormatter BR = new BinaryFormatter();
            FileStream fsin = new FileStream("SwampMonsterKiller.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    maps = (Map)BR.Deserialize(fsin);

                }
                found = true;
            }
            catch (Exception)
            {

                found = false;
            }
            return found;

        }

        public char enemy = 'G';
        public char Hero = 'H';
        public char Obstacle = 'X';
        public char emptyTile = '.';
    }
}
