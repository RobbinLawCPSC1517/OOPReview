using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_DiceRollHigherGame
{
    class Round
    {
        public int Player1Value { get; set; }
        public int Player2Value { get; set; }
        public string Winner { get; set; }

        public Round(Player player1, Player player2)
        {
            player1.PlayerRollDice();
            Player1Value = player1.PlayerDiceValue;
            player2.PlayerRollDice();
            Player2Value = player2.PlayerDiceValue;
            if (Player1Value > Player2Value)
            {
                Winner = player1.PlayerName;
            }
            else if (Player1Value < Player2Value)
            {
                Winner = player2.PlayerName;
            }
            else
            {
                Winner = "Draw";
            }
        }
    }
}
