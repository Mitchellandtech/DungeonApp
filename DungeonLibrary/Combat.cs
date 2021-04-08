using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Characters attacker, Characters defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(1500);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDelt = attacker.CalcDamage();

                defender.Life -= damageDelt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDelt);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }//enddoattack

        public static void DoBattle(Player player, Opponents opponents)
        {
            DoAttack(player, opponents);

            if (opponents.Life > 0)
            {
                DoAttack(opponents, player);
            }
        }

    }
}
