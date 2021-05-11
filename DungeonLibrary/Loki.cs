using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Loki : Opponents
    {

        public Loki(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {

        }

        public Loki()
        {
            MaxLife = 40;
            MaxDamage = 25;
            Name = @"Loki
  ,/         \.
 ((           ))
  \`.       ,'/
   )')     (`(
 ,'`/       \,`.
(`-(         )-')
 \-'\,-'`-./`-/
  \-')     (`-/
  /`'       `'\
 (_       _  )
 | ( \     / ) |
 |  `.\   /,'  |
 |    `\ / '   |
 (             )
  \           /
   \         /
    `.     ,'
      `-.- '";
            Life = 40;
            HitChance = 35;
            Block = 30;
            MinDamage = 4;
            Description = "The Trickster";      
        }
        

    }
}
