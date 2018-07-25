using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public class Game
    {
        private static Game _game;

        internal const int EmptyCell = 0;
        private const int Black = 1;
        private const int White = 2;

        internal int Turn { get; set; }
        internal int PlayerTurn { get; set; }

        internal bool Block { get; set; }

        internal bool TheEnd { get; set; }

        internal Player[] Players { get; set; }

        internal int Difficulty { get; set; }

        public struct Move
        {
            public int _column;
            public int _row;

            public Move(int col, int row)
            {
                _column = col;
                _row = row;
            }
        }

        internal int[,] Board = new int[8,8];
        
        public static Game GetInstance()
        {
            return _game ?? (_game = new Game());
        }

        private Game()
        {
            NewGame();
        }

        public void NewGame()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = EmptyCell;
                }
            }

            Board[3, 3] = White;
            Board[4, 4] = White;
            Board[3, 4] = Black;
            Board[4, 3] = Black;

            Block = false;
            Turn = 1;
            PlayerTurn = 0;
            TheEnd = false;
        }

        public void InvertTurn()
        {
            PlayerTurn = (PlayerTurn + 1)%2;
        }

        public int FlipPiece(ref int[,]board, int x, int y, int dx, int dy, int color)
        {
            int nbFlippedPieces;
            x = x + dx;
            y = y + dy;

            if (x < 0 || x > 7 || y < 0 || y > 7 || y < 0 || board[x, y] == EmptyCell)
            {
                return -1;
            }

            if (board[x,y] == color)
            {
                nbFlippedPieces = 0;
            }
            else
            {
                nbFlippedPieces = FlipPiece(ref board, x, y, dx, dy, color);
                if (nbFlippedPieces > -1)
                {
                    nbFlippedPieces++;
                    board[x, y] = color;
                }
            }

            return nbFlippedPieces;
        }

        public int FlipPieceNew(int[,] board, out int[,] returnedBoard, int x, int y, int dx, int dy, int color)
        {
            int nbFlippedPieces;
            x = x + dx;
            y = y + dy;

            returnedBoard = CopyArray(board);

            if (x < 0 || x > 7 || y < 0 || y > 7 || y < 0 || returnedBoard[x, y] == EmptyCell)
            {
                return -1;
            }

            if (returnedBoard[x, y] == color)
            {
                nbFlippedPieces = 0;
            }
            else
            {
                nbFlippedPieces = FlipPieceNew(returnedBoard, out returnedBoard, x, y, dx, dy, color);
                if (nbFlippedPieces > -1)
                {
                    nbFlippedPieces++;
                    returnedBoard[x, y] = color;
                }
            }

            return nbFlippedPieces;
        }

        public int Play(ref int[,] board, int color, Move move)
        {
            int nbFlippedPieces = 0; // le nombre de pions retournés par la fonction récursive

            board[move._column, move._row] = color;

            for (int dx = -1; dx <= 1; dx++)
            {
                int dy = -1;
                while (dy < 2)
                {
                    // le nombre de pions retournés par la fonction récursive
                    var tempFlippedPieces = FlipPiece(ref board, move._column, move._row, dx, dy, color);
                    if (tempFlippedPieces > -1)
                    {
                        nbFlippedPieces += tempFlippedPieces;
                    }
                    if (dx == 0)
                    {
                        dy += 2;
                    }
                    else dy++;
                }
            }

            return nbFlippedPieces;
        }

        public int PlayNew(int[,] board, out int[,] returnedBoard, int color, Move move)
        {
            int nbFlippedPieces = 0; // le nombre de pions retournés par la fonction récursive

            returnedBoard = CopyArray(board);
            returnedBoard[move._column, move._row] = color;

            for (int dx = -1; dx <= 1; dx++)
            {
                int dy = -1;
                while (dy < 2)
                {
                    // le nombre de pions retournés par la fonction récursive
                    var tempFlippedPieces = FlipPieceNew(returnedBoard, out returnedBoard, move._column, move._row, dx, dy, color);
                    if (tempFlippedPieces > -1)
                    {
                        nbFlippedPieces += tempFlippedPieces;
                    }
                    if (dx == 0)
                    {
                        dy += 2;
                    }
                    else dy++;
                }
            }

            return nbFlippedPieces;
        }

        // function modifieOthellierAvecAnim({D/R}var othellier:TOthellier;{D}couleur:integer;{D}coupjoue:TCoup):integer;

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

        public bool IsSquarePlayable(int[,] board, int color, Move move)
        {
            if (board[move._column, move._row] == EmptyCell)
            {
                bool isPlayable = false;
                int dx = -1;
                while (dx < 2 && !isPlayable)
                {
                    int dy = -1;
                    while (dy < 2 && !isPlayable)
                    {
                        //isPlayable = FlipPiece(ref boardTemp, move._column, move._row, dx, dy, color) > 0;
                        
                        int[,] boardTemp; //CopyArray(board);
                        isPlayable = FlipPieceNew(board, out boardTemp, move._column, move._row, dx, dy, color) > 0;
                        
                        if (dx == 0)
                        {
                            dy += 2;
                        }
                        else dy++;
                    }
                    dx++;
                }
                return isPlayable;
            }

            return false;
        }

        public bool CanPlay(int[,] board, int color)
        {
            bool canPlay = false;

            Move tmpMove = new Move();

            int i = 0;
            while (i < 8 && !canPlay)
            {
                int j = 0;
                while (j < 8 && !canPlay)
                {
                    tmpMove._column = i;
                    tmpMove._row = j;
                    canPlay = IsSquarePlayable(board, color, tmpMove);

                    j++;
                }
                i++;
            }

            return canPlay;
        }

        public int NbPossibleMoves(int[,] board, int color)
        {
            int nbMoves = 0;

            Move tmpMove = new Move();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tmpMove._column = i;
                    tmpMove._row = j;
                    if (IsSquarePlayable(board, color, tmpMove))
                    {
                        nbMoves++;
                    }
                }
            }

            return nbMoves;
        }

        public bool BoardFull(int[,] board)
        {
            int i = 0;
            int j = 8;

            while (i < 8 && j == 8)
            {
                j = 0;
                while (j < 8 && board[i,j] != EmptyCell)
                {
                    j++;
                }
                i++;
            }

            return j == 8;
        }

        public void Winner(Player player1, Player player2)
        {
            if (player1.Score > player2.Score)
            {
                MessageBox.Show(string.Format("Black won! {0}-{1}", player1.Score, player2.Score));
            }
            if (player1.Score < player2.Score)
            {
                MessageBox.Show(string.Format("White won! {0}-{1}", player1.Score, player2.Score));
            }
            if (player1.Score == player2.Score)
            {
                MessageBox.Show(string.Format("It's a draw! {0}-{1}", player1.Score, player2.Score));
            }
        }
    }
}
