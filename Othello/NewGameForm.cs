using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class NewGameForm : Form
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public int Depth { get; set; }
        public int Difficulty { get; private set; }

        public NewGameForm()
        {
            InitializeComponent();

            lblLevelWhite.Visible = false;
            cbLevel.Visible = false;
            
            cbLevel.Visible = true;
            cbLevel.SelectedIndex = 0;

            cbPlayerBlack.SelectedIndex = 0;

            Depth = 4;
        }

        private void cbPlayerBlack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayerBlack.SelectedIndex != -1)
            {
                switch (cbLevel.SelectedIndex)
                {
                    case 0:
                        Depth = 4;
                        break;
                    case 1:
                        Depth = 6;
                        break;
                    case 2:
                        Depth = 6;
                        break;
                }

                if (cbPlayerBlack.SelectedIndex == 0)
                {
                    cbPlayerWhite.SelectedIndex = 1;

                    Player1 = new HumanPlayer(1);
                    Player2 = new AIPlayer(2, Depth);
                }
                else
                {
                    cbPlayerWhite.SelectedIndex = 0;

                    Player1 = new AIPlayer(1, Depth);
                    Player2 = new HumanPlayer(2);
                }
            }
        }

        private void cbPlayerWhite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayerWhite.SelectedIndex != -1)
            {
                if (cbPlayerWhite.SelectedIndex == 0)
                {
                    cbPlayerBlack.SelectedIndex = 1;
                }
                else
                {
                    cbPlayerBlack.SelectedIndex = 0;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel.SelectedIndex != -1)
            {
                Difficulty = cbLevel.SelectedIndex + 1;

                switch (cbLevel.SelectedIndex)
                {
                    case 0:
                        Depth = 4;
                        break;
                    case 1:
                        Depth = 6;
                        break;
                    case 2:
                        Depth = 6;
                        break;
                }
            }
        }



    }
}
