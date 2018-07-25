using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    internal class HumanPlayer : Player
    {
        private int _points;

        public HumanPlayer(int color)
            : base(color)
        {

        }

        internal override int ThreadPlay(object move)
        {
//            Thread t = new Thread(theMove => Play(theMove));
//            t.Start(move);
//
//            while (t.IsAlive)
//            {
//                Thread.Sleep(1);
//            }

            return _points;
        }

        internal override int Play(object theMove)
        {
            Game.Move move = (Game.Move)theMove;
            _points = 0;

            if (Game.GetInstance().BoardFull(Game.GetInstance().Board))
            {
                Game.GetInstance().TheEnd = true;
            }
            else
            {
                bool canPlay = Game.GetInstance().CanPlay(Game.GetInstance().Board, ColorPlayer);

                if (!canPlay)
                {
                    if (Game.GetInstance().Block)
                    {
                        Game.GetInstance().TheEnd = true;
                    }
                    else
                    {
                        Game.GetInstance().Block = true;
                        MessageBox.Show(string.Format("Player {0} cannot play!", ColorPlayer));
                    }
                }
                else
                {
                    Game.GetInstance().Block = false;
                    //points = Game.GetInstance().Play(ref Game.GetInstance().Board, ColorPlayer, move);
                    
                }
            }

            return _points;
        }

        
    }
}
