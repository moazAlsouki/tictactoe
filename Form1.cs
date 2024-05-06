using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        private Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            game = new Game(player1TextBox.Text, player2TextBox.Text);
            game.StartGame();
            label1.Text = game.getPlayer1().getName() + " Is Turn";
            changeVisible(true);
            enableButtons(true);

            player1TextBox.Enabled = false;
            player2TextBox.Enabled = false;
            fillButton();
            buttonsColors(Color.White);
        }

        private void game_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text != "X" && b.Text != "O")
            {
                switch (b.Name)
                {
                    case "xo1":
                        b.Text = game.play(0, 0);
                        break;
                    case "xo2":
                        b.Text = game.play(0, 1);
                        break;
                    case "xo3":
                        b.Text = game.play(0, 2);
                        break;
                    case "xo4":
                        b.Text = game.play(1, 0);
                        break;
                    case "xo5":
                        b.Text = game.play(1, 1);
                        break;
                    case "xo6":
                        b.Text = game.play(1, 2);
                        break;
                    case "xo7":
                        b.Text = game.play(2, 0);
                        break;
                    case "xo8":
                        b.Text = game.play(2, 1);
                        break;
                    case "xo9":
                        b.Text = game.play(2, 2);
                        break;
                }
                if (b.Text == "X")
                    b.ForeColor = Color.Red;
                else b.ForeColor = Color.Blue;
                fillButton();
                isGameEnd();

                 
            }


        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            changeVisible(false);
            enableButtons(false);
            player1TextBox.Enabled = true;
            player2TextBox.Enabled = true;
            label1.Text = "Enter Players Name";
        }


        public void changeVisible(bool value)
        {
            xo1.Visible = value;
            xo2.Visible = value;
            xo3.Visible = value;
            xo4.Visible = value;
            xo5.Visible = value;
            xo6.Visible = value;
            xo7.Visible = value;
            xo8.Visible = value;
            xo9.Visible = value;
            RestartButton.Visible = value;
            
            StartButton.Visible = !value;
        }

        public void fillButton()
        {
            xo1.Text = game.getBoard()[0, 0];
            xo2.Text = game.getBoard()[0, 1];
            xo3.Text = game.getBoard()[0, 2];
            xo4.Text = game.getBoard()[1, 0];
            xo5.Text = game.getBoard()[1, 1];
            xo6.Text = game.getBoard()[1, 2];
            xo7.Text = game.getBoard()[2, 0];
            xo8.Text = game.getBoard()[2, 1];
            xo9.Text = game.getBoard()[2, 2];

        }
        public void isGameEnd()
        {
            game.checkWinner();
            if(game.getIsEnd())
            {
                if (game.getWinner().Equals(""))
                {
                    label1.Text = "Draw";
                    enableButtons(false);
                }
                else
                {
                    label1.Text = "The Winner Is " + game.getWinner();
                    colorButtons(Color.LawnGreen);
                }

            }
            else label1.Text = game.getPlayerTurn() + " Is Turn";

        }
        public void enableButtons(bool value)
        {
            xo1.Enabled = value;
            xo2.Enabled = value;
            xo3.Enabled = value;
            xo4.Enabled = value;
            xo5.Enabled = value;
            xo6.Enabled = value;
            xo7.Enabled = value;
            xo8.Enabled = value;
            xo9.Enabled = value;
        }

        public void buttonsColors(Color value){
            xo1.BackColor = value;
            xo2.BackColor = value;
            xo3.BackColor = value;
            xo4.BackColor = value;
            xo5.BackColor = value;
            xo6.BackColor = value;
            xo7.BackColor = value;
            xo8.BackColor = value;
            xo9.BackColor = value;
        }
        public void colorButtons(Color value)
        {
            enableButtons(false);

            foreach (int v in game.getWinningIndex())
            {
                switch (v)
                {
                    case 1:
                        xo1.BackColor = value;
                        xo1.Enabled = true; 
                        break;
                    case 2:
                        xo2.BackColor = value;
                        xo2.Enabled = true;
                        break;
                    case 3:
                        xo3.BackColor = value;
                        xo3.Enabled = true;
                        break;
                    case 4:
                        xo4.BackColor = value;
                        xo4.Enabled = true;
                        break;
                    case 5:
                        xo5.BackColor = value;
                        xo5.Enabled = true;
                        break;
                    case 6:
                        xo6.BackColor = value;
                        xo6.Enabled = true;
                        break;
                    case 7:
                        xo7.BackColor = value;
                        xo7.Enabled = true;
                        break;
                    case 8:
                        xo8.BackColor = value;
                        xo8.Enabled = true;
                        break;
                    case 9:
                        xo9.BackColor = value;
                        xo9.Enabled = true;
                        break;
                }
            }
        }

        private void xo2_Resize(object sender, EventArgs e)
        {

        }


    }
}
