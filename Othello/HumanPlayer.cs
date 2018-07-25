using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(int color)
            : base(color)
        {

        }

        internal override int Play(Game.Move move, out Game.Move returnedMove)
        {
            returnedMove = new Game.Move(move._column, move._row);

            int points = 0;
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
                        MessageBox.Show(string.Format("{0} cannot play!", Name));
                    }
                }
                else
                {
                    Game.GetInstance().Block = false;
                    //points = Game.GetInstance().Play(ref Game.GetInstance().Board, ColorPlayer, move);
                    
                }
            }
            return points;
        }

    }
}
