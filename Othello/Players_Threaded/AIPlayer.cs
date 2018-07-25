using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    class AIPlayer : Player
    {
        public int Depth { get; internal set; }

        private int _points;

        public AIPlayer(int color, int depth)
            : base(color)
        {
            Depth = depth;
        }

        internal override int ThreadPlay(object move)
        {
//            Thread t = new Thread(Play);
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
            Game.Move move = (Game.Move) theMove;
            _points = 0;

            if (Game.GetInstance().BoardFull(Game.GetInstance().Board))
            {
                Game.GetInstance().TheEnd = true;
            }
            else
            {
                if (Game.GetInstance().Turn == 1)
                {
                    // 1st turn
                    move = MinMax.GetInstance().ChooseFirstMove(Game.GetInstance().Board, ColorPlayer);
                }
                else if (Game.GetInstance().Turn == 2)
                {
                    // 2nd turn
                    move = MinMax.GetInstance().BestSecondMove(Game.GetInstance().Board, ColorPlayer);
                }
                else
                {
                    switch (Game.GetInstance().Difficulty)
                    {
                        case 1:
                            move = MinMax.GetInstance().BestMove(Game.GetInstance().Board, ColorPlayer, Depth, Game.GetInstance().Block, false);
                            break;
                        case 2:
                            move = MinMax.GetInstance().BestMove(Game.GetInstance().Board, ColorPlayer, Depth, Game.GetInstance().Block, false);
                            break;
                        case 3:
                            move = MinMax.GetInstance().BestMove(Game.GetInstance().Board, ColorPlayer, Depth, Game.GetInstance().Block, true);
                            break;
                    }
                }

                if (move._row == -1)
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

//                    MessageBox.Show(string.Format("Best move: col:{0} - row:{1}", move._column, move._row));

                    _points = Game.GetInstance().Play(ref Game.GetInstance().Board, ColorPlayer, move);
                    
                }
            }

            return _points;
        }
    }
}
