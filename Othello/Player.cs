using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    public abstract class Player
    {
//        internal enum PlayerColor
//        {
//            BLACK=1,
//            WHITE=2
//        }

        public int Score { get; internal set; }
        public int ColorPlayer { get; private set; }

//        public Game CurrentGame { get; set; }

        protected Player(int color/*, Game currentGame*/)
        {
            ColorPlayer = color;
            Score = 2;
//            CurrentGame = currentGame;
        }

        internal abstract int Play(Game.Move move, out Game.Move returnedMove);

        public string Name { get; set; }
        
    }
}
