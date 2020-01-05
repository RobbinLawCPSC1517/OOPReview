using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_DiceRollHigherGame
{
    class Dice
    {
        private Die die1 = new Die();
        private Die die2 = new Die();

        private int _DiceValue;
        public int DiceValue
        {
            get { return _DiceValue; }
            set { _DiceValue = value; }
        }
        public void RollDice()
        {
            die1.RollDie();
            die2.RollDie();
            DiceValue = die1.FaceValue + die2.FaceValue;
        }
    }
}
