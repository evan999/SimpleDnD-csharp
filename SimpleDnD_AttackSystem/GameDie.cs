using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDnD_AttackSystem
{
    public class GameDie
    {
        public int value;
        public int numberOfSides; 
        Random random = new Random();

        public GameDie()
        {

        }

        public GameDie(int value, int numberOfSides)
        {
            this.value = value;
            this.numberOfSides = numberOfSides; 
        }

        public int RollGameDice(int value, int numberOfSides)
        { 
            int minValue = 1;
            value = random.Next(minValue, numberOfSides);
            return value;
        }
    }
}
