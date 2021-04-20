using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Opponents
    {
        public Dragon(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {

        }
        
        public Dragon()
        {
            MaxLife = 40;
            MaxDamage = 25;
            Name = @"Dragon
           /                            )
          (                             |\
         /|                              \\
        //                                \\
       ///                                 \|
      /( \                                  )\
      \\  \_                               //)
       \\  :\__                           ///
        \\     )                         // \
         \\:  /                         // |/
          \\ / \                       //  \
           /)   \   ___..-'           (|  \_|
          //     /   _.'              \ \  \
         /|       \ \________          \ | /
        (| _ _  __/          '-.       ) /.'
         \\ .  '-.__            \_    / / \
          \\_'.     > --._ '.     \  / / /
           \ \      \     \  \     .' /.'
            \ \  '._ /     \ )    / .' |
             \ \_     \_   |    .'_/ __/
              \  \      \_ |   / /  _/ \_
               \  \       / _.' /  /     \
               \   |     /.'   / .'       '-,_
                \   \  .'   _.'_/             \
   /\    /\      ) ___(    /_.'           \    |
  | _\__// \    (.'      _/               |    |
  \/_  __  /--'`    ,                   __/    /
  (_ ) /b)  \  '.   :            \___.-'_/ \__/
  /:/:  ,     ) :        (      /_.'__/-'|_ _ /
 /:/: __/\ >  __,_.----.__\    /        (/(/(/
(_(,_/V .'/--'    _/  __/ |   /
 VvvV  //`    _.-' _.'     \   \
   n_n//     (((/->/        |   /
   '--'         ~='          \  |
                              | |_,,,
                              \  \  /
                               '.__)";
            Life = 40;
            HitChance = 35;
            Block = 30;
            MinDamage = 4;
            Description = "The Trickster";
        }

    }
}
