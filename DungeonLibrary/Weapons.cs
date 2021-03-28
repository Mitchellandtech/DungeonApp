using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapons
    {
        //fields 
        public int _minDamage;

        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                  
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1; 
                }//end else
            }//end set
        }//end MinDamage

        //CTORS
        public Weapons(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwohanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = Name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = IsTwoHanded;
        }

        //methods - 
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name, MinDamage, MaxDamage, BonusHitChance, IsTwoHanded ? "Two-Handed" : "One-Handed");     
        }


    }//end class
}//end namespace
