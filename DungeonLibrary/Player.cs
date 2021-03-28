using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Characters
    {
        public Race CharacterRace { get; set; }
        public Weapons EquiptmentWeapon { get; set; }

        //ctors
        //FQ CTOR - we dont want the ability to creat an empty player, so we only allow the creation of a player through this ctor
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapons equiptmentWeapon)
        {
            //  set MaxLife first , as life is dependant on its value
            MaxLife = maxLife;
            Name = name;
            Block = block;
            HitChance = hitChance;
            Life = life;
            CharacterRace = characterRace;
            EquiptmentWeapon = equiptmentWeapon;
        }
        //methods - ToString(), CalcDamage(), CalcHitChance() all be overridden 
        public override string ToString()
        {
            return string.Format("=-=- {0} =-=-\n" +
                "Life: {1} / {2}\n" +
                "Ht Chance: {3}%\n" +
                "Weapon:\n{4}\n" +
                "Block: {5}\n" +
                "Description: {6}\n",

                Name, Life, MaxLife, HitChance, EquiptmentWeapon, Block, CharacterRace);
        }

        public override int CalcDamage()
        {
            //The original return is 0 so we eremoved the base return ans write the following logic

            // Create a random object
            Random rand = new Random();
            //return a damage that is randomly decided upon
            int damage = rand.Next(EquiptmentWeapon.MinDamage, EquiptmentWeapon.MaxDamage + 1);
            //Return the damage variable withthe proper ampunt of damage included int he variable
            return damage;

        }//end calcDamage()


        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquiptmentWeapon.BonusHitChance;
        }//end CalcHitchance()
    }
}
