using System;

namespace SimpleDnD_AttackSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GameDie die = new GameDie();
            int result = die.RollGameDice(1, 20);
            Console.WriteLine(result);

            game.GetDamageModifier();

        }
    }
}
