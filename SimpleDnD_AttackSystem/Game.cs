using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDnD_AttackSystem
{
    public class Game
    {
        bool isCriticalHit = false;
        bool isCriticalMiss = false;
        private int armorClass;

        public Game()
        {

        }

        public bool IsCriticalHitOrMiss(int value)
        {
            if (value == 20)
            {
                isCriticalHit = true;
                Console.WriteLine("Critical Hit!");
                return isCriticalHit;
            }
            else if (value == 1)
            {
                isCriticalMiss = true;
                Console.WriteLine("Critical Miss!");
                return isCriticalMiss;
            }
            else
            {
                return false;
            }
        }

        public string DamageDealt(string damage, int value)
        {
            
            //string damageX = damage[0];
            //string damageY = damage[1];

            return damage;
        }

        public int GetArmorClass()
        {
            Console.Write("Enter target's armor class: ");
            string input = Console.ReadLine();
            int armorClass = Convert.ToInt32(input);

            return armorClass;
        }

        public void GetDamageModifier()
        {
            Console.Write("Enter damage modifier (xdy): ");
            string input = Console.ReadLine();
            //string[] damage = input.Split(' ');
            //char numberOfDice = input[0];
            for(int index = 0; index < input.Length; index++)
            {
                if(input[index] == 'd')
                {
                    continue;
                }
            }
            //char[] damage = input.ToCharArray();
            //Console.WriteLine(input[2]);

            //int damageX = int.Parse(damage[0]);
            //int damageY = int.Parse(damage[2]);
            //Console.WriteLine(damageX);
            //Console.WriteLine(damageY);
            

            //return 0;
            
        }
    }
}
