using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othello.Properties;

namespace Othello
{
    public partial class TestBoardForm : Form
    {
        private int[,] _board;

        private PictureBox[,] tabPictureBox;


        public TestBoardForm(int[,] boardTemp, int val, Game.Move eMove)
        {
            InitializeComponent();
            _board = boardTemp;

            tabPictureBox = new PictureBox[8, 8];
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

                    //tabPictureBox[i, j].Click += Square_Click;
                    //tabPictureBox[i, j].MouseEnter += PictureBox_MouseEnter;
                    //tabPictureBox[i, j].MouseLeave += PictureBox_MouseLeave;
                }
            }

            lblCol.Text = eMove._column.ToString();
            lblRow.Text = eMove._row.ToString();
            lblVal.Text = val.ToString();

            DrawBoard();
        }

        private void DrawBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (_board[i, j])
                    {
                        case 0: // Empty cell
                            tabPictureBox[i, j].Image = Resources.Background;
                            break;
                        case 1: // Black piece
                            tabPictureBox[i, j].Image = Resources.BlackCoin;
                            break;
                        case 2: // White piece
                            tabPictureBox[i, j].Image = Resources.WhiteCoin;
                            break;
                    }
                }
            }



        }
    }
}
