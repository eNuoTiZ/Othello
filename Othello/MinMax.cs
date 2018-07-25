using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    internal class MinMax
    {
        private static MinMax _minMax;

        private static Game.Move _coupNul = new Game.Move(-1, -1);
        
        private int maxi = 1000; //maximum qui ne peut être atteint dans l'évaluation
        private int mini = -1000; //minimum qui ne peut être atteint dans l'évaluation
        private int victoire = 500; //le prix de la victoire
        private int defaite = -500; //le prix de la défaite
        private int matchnul = 0; //le prix du match nul
        private int coin = 50; //le prix d'un coins

        //private readonly Game _currentGame;

        private MinMax()
        {
            _coupNul._column = -1;
            _coupNul._row = -1;

            //_currentGame = Game.GetInstance();
        }

        public static MinMax GetInstance()
        {
            if (_minMax == null)
            {
                _minMax = new MinMax();
            }

            return _minMax;
        }

        private int GetOpponent(int color)
        {
            return color == 1 ? 2 : 1;
        }

        private bool LastMove(int[,] board, int opponent, bool block, Game.Move movePlayed)
        {
            return ((block) && movePlayed._column == -1) || (Game.GetInstance().BoardFull(board));
        }

        private int Eval(int[,] board, int playerColor)
        {
            int res = 0;
            int i = 0;
            while (i < 8)
            {
                int j = 0;
                while (j < 8)
                {
                    if (board[i,j] == playerColor)
                    {
                        res += coin;
                    }
                    else if (board[i,j] != Game.EmptyCell)
                    {
                        res = res - (3*coin);
                    }

                    j += 7;
                }

                i += 7;
            }

            return res;
        }

        private int EvalFin(int[,] board, int playerColor, Game.Move movePlayed)
        {
            int res = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (board[i,j] != Game.EmptyCell)
                    {
                        if (board[i, j] == playerColor)
                        {
                            res++;
                        }
                        else res--;
                    }
                }
            }

            if (res > 0)
            {
                return victoire;
            }
            if (res == 0)
            {
                return matchnul;
            }
            return defaite;

        }

        private int EvalMax(int[,] board, int player, int opponent, Game.Move move, int depth, int alpha,
            int profMobilite, bool block, bool difficult)
        {
            int[,] modifiedBoard = CopyArray(board);
            Game.Move eMove = new Game.Move(-1, -1);

            if (move._column != -1)
            {
                Game.GetInstance().PlayNew(board, out modifiedBoard, opponent, move);
            }

            if (LastMove(modifiedBoard, opponent, block, move))
            {
                return -EvalFin(modifiedBoard, opponent, move);
            }
            else
            {
                if (depth == 0)
                {
                    return Eval(modifiedBoard, player);
                }
                else
                {
                    if (move._row == -1) block = true;

                    int i = 0;
                    int val = mini;
                    while (i < 8 && val < alpha)
                    {
                        eMove._column = i;
                        int j = 0;

                        while (j < 8 && val < alpha)
                        {
                            eMove._row = j;
                            if (Game.GetInstance().IsSquarePlayable(modifiedBoard, player, eMove))
                            {
                                val = Math.Max(val,
                                    EvalMin(modifiedBoard, player, opponent, eMove, depth - 1, val, profMobilite, block,
                                        difficult));
                            }
                            j++;
                        }
                        i++;
                    }

                    if (val == mini)
                    {
                        val = EvalMin(modifiedBoard, player, opponent, _coupNul, depth - 1, val, profMobilite, block, difficult);
                    }

                    return val;
                }
            }
        }

        private int EvalMin(int[,] board, int player, int opponent, Game.Move move, int depth, int beta,
            int profMobilite, bool block, bool difficult)
        {
            int[,] modifiedBoard = CopyArray(board);
            Game.Move eMove = new Game.Move(-1, -1);

            if (move._column != -1)
            {
                Game.GetInstance().PlayNew(board, out modifiedBoard, player, move);
            }

            if (LastMove(modifiedBoard, player, block, move))
            {
                return EvalFin(modifiedBoard, player, move);
            }
            else
            {
                if (depth == 0)
                {
                    return Eval(modifiedBoard, player);
                }
                else
                {
                    if (move._row == -1) block = true;

                    int i = 0;
                    int val = maxi;
                    while (i < 8 && val > beta)
                    {
                        eMove._column = i;
                        int j = 0;

                        while (j < 8 && val > beta)
                        {
                            eMove._row = j;
                            if (Game.GetInstance().IsSquarePlayable(modifiedBoard, opponent, eMove))
                            {
                                val = Math.Min(val,
                                    EvalMax(modifiedBoard, player, opponent, eMove, depth - 1, val, profMobilite, block,
                                        difficult));
                            }
                            j++;
                        }
                        i++;
                    }

                    if (val == maxi)
                    {
                        val = EvalMax(modifiedBoard, player, opponent, _coupNul, depth - 1, val, profMobilite, block, difficult);
                    }
                    if (depth == profMobilite)
                    {
                        val = val - Game.GetInstance().NbPossibleMoves(modifiedBoard, opponent);
                        if (difficult)
                        {
                            val = val + Game.GetInstance().NbPossibleMoves(modifiedBoard, player);
                        }
                    }

                    return val;
                }
            }
        }

        internal Game.Move BestMove(int[,] board, int player, int depth, bool block, bool difficult)
        {
            Game.Move bestMove = new Game.Move(-1, -1);
            Game.Move eMove = new Game.Move(-1, -1);

            bestMove._column = -1;
            bestMove._row = -1;

            int mval = mini; // best move value

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //int[,] boardTemp = CopyArray(board);

                    eMove._column = i;
                    eMove._row = j;

                    int nbMoves = Game.GetInstance().NbPossibleMoves(board, player);

                    if (Game.GetInstance().IsSquarePlayable(board, player, eMove))
                    {
                        var val = EvalMin(board, player, GetOpponent(player), eMove, depth, mini, depth % 4, block, difficult); // value of the tested move

                        //TestBoardForm testForm = new TestBoardForm(board, val, eMove);
                        //testForm.Show();
                        
                        if (val > mval)
                        {
                            bestMove._column = eMove._column;
                            bestMove._row = eMove._row;
                            mval = val;
                        }
                    }
                }
            }

            return bestMove;
        }

        internal Game.Move ChooseFirstMove(int[,] board, int color)
        {
            Game.Move move = new Game.Move(-1, -1);
            
            List<Game.Move> listOfMoves = new List<Game.Move>();

            for (int i = 2; i < 5; i++)
            {
                for (int j = 2; j < 5; j++)
                {
                    move._column = i;
                    move._row = j;
                    if (Game.GetInstance().IsSquarePlayable(board, color, move))
                    {
                        listOfMoves.Add(move);
                    }
                }
            }

            Random rnd = new Random();
            int r = rnd.Next(listOfMoves.Count);

            return listOfMoves[r];
        }

        internal Game.Move BestSecondMove(int[,] board, int color)
        {
            int min = 60;
            int mobility;
            Game.Move bestMove = new Game.Move(-1, -1);
            Game.Move eMove = new Game.Move(-1, -1);

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    eMove._column = i;
                    eMove._row = j;
                    if (Game.GetInstance().IsSquarePlayable(board, color, eMove))
                    {
                        int[,] boardTemp2 = CopyArray(board);
                        //board.CopyTo(boardTemp2, 0);
                        
                        Game.GetInstance().Play(ref boardTemp2, color, eMove);
                        mobility = Game.GetInstance().NbPossibleMoves(boardTemp2, color);
                        if (mobility < min)
                        {
                            min = mobility;
                            bestMove._column = eMove._column;
                            bestMove._row = eMove._row;
                        }
                    }
                }
            }

            return bestMove;
        }

        private int[,] CopyArray(int[,] arrayFrom)
        {
            int[,] arrayTo = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arrayTo[i, j] = arrayFrom[i, j];
                }
            }

            return arrayTo;
        }
    
        
    }
}
