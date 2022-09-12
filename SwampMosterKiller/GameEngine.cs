using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return MovePlayer;
        }
    }
}
