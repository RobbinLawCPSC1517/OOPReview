using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_DiceRollHigherGame
{
    class Player
    {
        private Dice playerDice = new Dice();

        public string PlayerName { get; set; }

        private int _PlayerDiceValue;
        public int PlayerDiceValue
        {
            get{return _PlayerDiceValue;}
            set{_PlayerDiceValue = value;}
        }

        public Player()
        {
            PlayerName = "Nameless Player";
            PlayerDiceValue = 0;
        }

        public Player(string playerName)
        {
            PlayerName = playerName;
            PlayerDiceValue = 0;
        }

        public Player(string playerName, int playerDiceValue)
        {
            PlayerName = playerName;
            PlayerDiceValue = playerDiceValue;
        }

        public void  PlayerRollDice()
        {
            playerDice.RollDice();
            PlayerDiceValue = playerDice.DiceValue;
        }
    }
}
