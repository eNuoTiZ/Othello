using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othello.Properties;

namespace Othello
{
    public partial class Form1 : Form
    {
        private const int Black = 1;
        private const int White = 2;

        private readonly Game _game;
        private Player[] _players;

        private PictureBox[,] tabPictureBox;

        public Form1()
        {
            InitializeComponent();

            loadingBox.Image = Resources.loading;
            loadingBox.Visible = false;

            tbPlayer1.Text = "Black";
            tbPlayer2.Text = "White";

            _game = Game.GetInstance();

            tabPictureBox = new PictureBox[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tabPictureBox[i, j] = new PictureBox
                    {
                        Parent = panelBoard,
                        Width = 45,
                        Height = 45,
                        Left = j*45,
                        Top = i*45,
                        Name = i + ";" + j,
                        Tag = i + ";" + j
                    };

                    tabPictureBox[i, j].Click += Square_Click;
                    tabPictureBox[i, j].MouseEnter += PictureBox_MouseEnter;
                    tabPictureBox[i, j].MouseLeave += PictureBox_MouseLeave;
                }
            }
            
            _players = new Player[2];

            NewGame(new HumanPlayer(Black), new AIPlayer(White, 4), 1);

            cbDisplayAvailableMoves.Checked = true;

        }

        void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                string[] coords = ((PictureBox) sender).Tag.ToString().Split(';');

                int col = Convert.ToInt32(coords[0]);
                int row = Convert.ToInt32(coords[1]);

                //statusLabel2.Text = "MouseLeave - " + pictureBox.Name;
                if (cbDisplayAvailableMoves.Checked && _game.Board[col, row] == 0 )
                {
                    pictureBox.Image = Resources.Background;
                }    
            }

        }

        void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null)
            {
                Game.Move move = new Game.Move(-1, -1);

                string[] coords = ((PictureBox) sender).Tag.ToString().Split(';');

                move._column = Convert.ToInt32(coords[0]);
                move._row = Convert.ToInt32(coords[1]);

                statusLabel.Text = string.Format("{0}-{1}", move._row, move._column);

                if (cbDisplayAvailableMoves.Checked && _game.IsSquarePlayable(_game.Board, _players[_game.PlayerTurn].ColorPlayer, move))
                {
                    pictureBox.Image = Resources.AvailableMove;
                }    
            }

        }

        void Square_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (!Game.GetInstance().TheEnd && pictureBox != null)
            {
                Game.Move move = new Game.Move(-1, -1);

                string[] coords = pictureBox.Tag.ToString().Split(';');

                move._column = Convert.ToInt32(coords[0]);
                move._row = Convert.ToInt32(coords[1]);

                if (move._column >= 0 && move._column < 8 && move._row >= 0 && move._row < 8)
                {
                    if (_game.IsSquarePlayable(_game.Board, _players[_game.PlayerTurn].ColorPlayer, move))
                    {
                        int points = Game.GetInstance().Play(ref Game.GetInstance().Board, _players[_game.PlayerTurn].ColorPlayer, move);

                        if (points > 0)
                        {
                            _players[_game.PlayerTurn].Score += points + 1;

                            Game.GetInstance().InvertTurn();
                            Game.GetInstance().Turn++;

                            _players[_game.PlayerTurn].Score -= points;

                            DrawBoard();
                        }
                        else
                        {
                            Game.GetInstance().InvertTurn();
                            Game.GetInstance().Turn++;
                        }

                        PlayAiThread();

                    }

                }
            }
        }

        private void NewGame(Player firstPlayer, Player secondPlayer, int difficulty)
        {
            _game.NewGame();
            _game.Difficulty = difficulty;

            _players[0] = firstPlayer;
            _players[1] = secondPlayer;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tabPictureBox[i, j].Image = Resources.Background;
                }
            }

            switch (_game.Difficulty)
            {
                case 1:
                    levelPic.Image = Resources.LevelEasy;
                    break;
                case 2:
                    levelPic.Image = Resources.LevelMedium;
                    break;
                case 3:
                    levelPic.Image = Resources.LevelHard;
                    break;
            }

            if (_players[0].GetType() == typeof(AIPlayer))
            {
                levelPic.Top = tbPlayer1.Top - 2;
            }
            else
            {
                levelPic.Top = tbPlayer2.Top - 2;
            }

            DrawBoard();
        }

        private void DrawBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (_game.Board[i,j])
                    {
                        case 0: // Empty cell
                            UpdatePictureBox(tabPictureBox[i, j], Resources.Background);
//                            tabPictureBox[i, j].Image = Resources.Background;
                            break;
                        case 1: // Black piece
                            UpdatePictureBox(tabPictureBox[i, j], Resources.BlackCoin);    
//                            tabPictureBox[i, j].Image = Resources.BlackCoin;
                            break;
                        case 2: // White piece
                            UpdatePictureBox(tabPictureBox[i, j], Resources.WhiteCoin);
//                            tabPictureBox[i, j].Image = Resources.WhiteCoin;
                            break;
                    }
                }
            }

            // Refresh score
            UpdateTextBox(tbScorePlayer1, _players[0].Score.ToString());
            UpdateTextBox(tbScorePlayer2, _players[1].Score.ToString());
//            tbScorePlayer1.Text = _players[0].Score.ToString();
//            tbScorePlayer2.Text = _players[1].Score.ToString();
            //Refresh();
        }

        #region Delegates

        public delegate void UpdateTextBoxCallback(TextBox tb, string text);

        private void UpdateTextBox(TextBox tb, string text)
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new UpdateTextBoxCallback(UpdateTextBox), tb, text);
            }
            else
            {
                tb.Text = text;
            }
        }

        public delegate void UpdatePictureBoxCallback(PictureBox pb, Bitmap image);

        private void UpdatePictureBox(PictureBox pb, Bitmap image)
        {
            if (pb.InvokeRequired)
            {
                pb.Invoke(new UpdatePictureBoxCallback(UpdatePictureBox), pb, image);
            }
            else
            {
                pb.Image = image;
            }
        }

        #endregion


        private void PlayAiThread()
        {
            Cursor = Cursors.WaitCursor;
            loadingBox.Visible = true;
            panelBoard.Enabled = false;
            Refresh();

            Thread t = new Thread(PlayAi);
            t.Name = "MinMaxThread";
            t.Start();

            //t.Join(1);

            while (t.IsAlive)
            {
                Thread.Sleep(1);
            }

            DrawBoard();

            loadingBox.Visible = false;
            panelBoard.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void PlayAi()
        {
            if (!Game.GetInstance().TheEnd)
            {
//                Cursor = Cursors.WaitCursor;
//                loadingBox.Visible = true;
//                loadingBox.Refresh();

                int points = _players[_game.PlayerTurn].Play(new Game.Move(-1, -1));

                if (points == 0)
                {
                    // ai player cannot play, passes his turn

                    Game.GetInstance().InvertTurn();
                    Game.GetInstance().Turn++;
                }
                else
                {
                    _players[_game.PlayerTurn].Score += points + 1;

                    Game.GetInstance().InvertTurn();
                    Game.GetInstance().Turn++;

                    _players[_game.PlayerTurn].Score -= points;

//                    DrawBoard();
                }

                if (_game.NbPossibleMoves(_game.Board, _players[_game.PlayerTurn].ColorPlayer) == 0)
                {
                    if (_game.Block || _game.BoardFull(_game.Board))
                    {
                        _game.Winner(_players[0], _players[1]);    
                    }
                    else
                    {
                        _game.Block = true;
                        MessageBox.Show(string.Format("Player {0} cannot play!", _players[_game.PlayerTurn].ColorPlayer));

                        Game.GetInstance().InvertTurn();
                        Game.GetInstance().Turn++;

                        PlayAi();
                    }
                }

//                loadingBox.Visible = false;
//                loadingBox.Refresh();
//                Cursor = Cursors.Default;
            }
            else
            {
                Game.GetInstance().Winner(_players[0], _players[1]);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();

            if (newGameForm.ShowDialog() == DialogResult.OK)
            {
                NewGame(newGameForm.Player1, newGameForm.Player2, newGameForm.Difficulty);

                if (_players[0].GetType() == typeof(AIPlayer))
                {
                    ((AIPlayer)_players[0]).Depth = newGameForm.Depth;
                    PlayAi();
                }
                else
                {
                    ((AIPlayer)_players[1]).Depth = newGameForm.Depth;
                }
            }
        }
    }
}
