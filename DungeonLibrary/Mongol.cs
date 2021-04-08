using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Mongol : Opponents
    {
        public Mongol(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
           
        }

        public Mongol()
        {
            MaxLife = 40;
            MaxDamage = 12;
            Name = "Mongol";
            Life = 30;
            HitChance = 20;
            Block = 15;
            MinDamage = 4;
            Description = "This should be easy";
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            return calculatedBlock;
        }

    }
}
