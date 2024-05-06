using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Player
    {
        string name;
        string key;
        bool turn;
        public Player()
        {
            name = "";
            key = "";
        }
        public Player(string name,string key,bool turn){
            this.name = name;
            this.key = key;
            this.turn = turn;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public string getKey()
        {
            return this.key;
        }
        public void setMyTurn(bool turn)
        {
            this.turn = turn;
        }
        public bool isTurn() { return turn; }
        public void changeTurn()
        {
            this.turn = !turn;
        }

    }
}
