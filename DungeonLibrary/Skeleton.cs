using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Skeleton : Opponents
    {
        public bool IsSkullKing { get; set; }

        public Skeleton(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isSkullKing) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsSkullKing = isSkullKing;
        }

        public Skeleton()
        {
            MaxLife = 40;
            MaxDamage = 12;
            Name = @"Skeleton
    _.-----------._
   .'             '.
  /                 \
 ; ;
 |                   |
 |                   |
 ; ;
  \ (`'--,    ,--'`) /
   \ \  _ )  (_ / /
    ) )(')/  \(')((
   (_ `""` /\ `""` _)
    \` -, /  \ ,-`/
     `\ / `""` \ /`
      |/\/\/\/\/\|
      |\        /|
      ; |/\/\/\| ;
       \`-`--`-`/
        \      /
         ',__,'
          q__p
          q__p
          q__p
          q__p";
            Life = 40;
            HitChance = 20;
            Block = 15;
            MinDamage = 4;
            Description = "This should be easy";
            IsSkullKing = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsSkullKing ? "SkullKing" : "Not SkullKing");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsSkullKing)
            {
                calculatedBlock += calculatedBlock / 5;
            }

            return calculatedBlock;
        }

    }
}
