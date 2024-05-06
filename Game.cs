using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Game
    {

        private Player player1;
        private Player player2;
        private String[,] board;
        private bool isStarted;
        private bool isEnd;
        private String winner = "";
        private List<int> winnigIndex;
        public Game()
        {
            isStarted = false;
            isEnd = false;
            
            player1 = new Player();
            player2 = new Player();
        }
        public Game(string p1, string p2)
        {
            winnigIndex = new List<int>();
            board = new String[3, 3];
            isStarted = false;
            isEnd = false;
            player1 = new Player(p1,"X",true);
            player2 = new Player(p2,"O",false);
            winner = "";
        }

        public string[,] getBoard() { return board; }
        public String checkWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 2]) && (board[i, 1] == board[i, 2]) && board[i,0]!=null)
                {
                    winner = player2.getKey().Equals(board[i, 0]) ? player2.getName() : player1.getName();
                    isEnd = true;
                    winnigIndex.Add(i * 3 + 1);
                    winnigIndex.Add(i * 3 + 2);
                    winnigIndex.Add(i * 3 + 3);
                    return board[i, 0];
                }

                if ((board[0, i] == board[1, i]) && (board[1, i] == board[2, i]) && board[0, i] != null)
                {
                    winner = player2.getKey().Equals(board[0, i]) ? player2.getName() : player1.getName();
                    isEnd = true;
                    winnigIndex.Add(i + 1);
                    winnigIndex.Add(i + 4);
                    winnigIndex.Add(i + 7);
                    return board[0, i];
                }
            }
            if ((board[0, 0] == board[2, 2]) && (board[1, 1] == board[2, 2]) && board[1, 1] != null)
            {
                winner = player2.getKey().Equals(board[1, 1]) ? player2.getName() : player1.getName();
                isEnd = true;

                winnigIndex.Add(1);
                winnigIndex.Add(5);
                winnigIndex.Add(9);
                return board[1, 1];
            }


            if ((board[2, 0] == board[1, 1]) && (board[1, 1] == board[0, 2]) && board[1, 1] != null)
            {
                winner = player2.getKey().Equals(board[1, 1]) ? player2.getName() : player1.getName();
                isEnd = true;

                winnigIndex.Add(3);
                winnigIndex.Add(5);
                winnigIndex.Add(7);
                return board[1, 1];
            }
            gameStatus();
            return "D";
        }
        public void StartGame()
        {
            isStarted = true;
        }
        public bool getIsStarted() { return isStarted; }
        public bool getIsEnd() { return isEnd; }
        public Player getPlayer1() { return player1; }
        public Player getPlayer2() { return player2; }

        public String getWinner() { return winner; }

        public List<int> getWinningIndex() { return this.winnigIndex; }
        public string play(int i, int j)
        {
            string key;
            if (player1.isTurn())
                key = player1.getKey();
            else key = player2.getKey();
            board[i, j] = key;
            player1.changeTurn();
            player2.changeTurn();
            return key;
        }

        public String getPlayerTurn(){
            return  player1.isTurn() ? player1.getName() : player2.getName();
        }
        public void gameStatus()
        {
            isEnd = true; 
            for(int i =0; i<3;i++)
                for(int j = 0;j<3;j++)
                {
                    if (board[i, j] == null || (!board[i, j].Equals("X") && !board[i, j].Equals("O")))
                    {
                        isEnd = false;
                    }
                }
        }
    }
}
