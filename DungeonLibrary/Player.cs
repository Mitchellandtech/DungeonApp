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

     
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapons equiptmentWeapon)
        {
     
            MaxLife = maxLife;
            Name = name;
            Block = block;
            HitChance = hitChance;
            Life = life;
            CharacterRace = characterRace;
            EquiptmentWeapon = equiptmentWeapon;
        }
      
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

            Random rand = new Random();
           
            int damage = rand.Next(EquiptmentWeapon.MinDamage, EquiptmentWeapon.MaxDamage + 1);
           
            return damage;

        }//end calcDamage()


        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquiptmentWeapon.BonusHitChance;
        }//end CalcHitchance()
    }
}
