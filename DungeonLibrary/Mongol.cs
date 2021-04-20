using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Mongol : Opponents
    {
        public bool IsGenghisKhan { get; set; }

        public Mongol(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isGenghisKhan) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsGenghisKhan = isGenghisKhan;
        }

        public Mongol()
        {
            MaxLife = 40;
            MaxDamage = 12;
            Name = "Mongol";
            Life = 40;
            HitChance = 20;
            Block = 15;
            MinDamage = 4;
            Description = "This should be easy";
            IsGenghisKhan = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsGenghisKhan ? "Khan" : "Not Khan");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsGenghisKhan)
            {
                calculatedBlock += calculatedBlock / 5;
            }

            return calculatedBlock;
        }

    }
}
