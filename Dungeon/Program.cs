using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using DungeonLibrary;
using System.Threading;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "----Tomb of the Lost Souls----";

            #region Weapon
            Weapons Axe = new Weapons(1, 8, "Axe", 10, false);
            Weapons katana = new Weapons(3, 15, "katana", 11, true);
            Weapons Spear = new Weapons(8, 22, "Spear", 20, true);

            int score = 0;

            #endregion
           




            string propmt = @" 

                                                    (                  (                   
  *   )              )       (         )   )        )\ )           )   )\ )          (     
` )  /(      )    ( /(       )\ )   ( /(( /(   (   (()/(        ( /(  (()/(       (  )\    
 ( )(_)|    (     )\())   ( (()/(   )\())\()) ))\   /(_)) (  (  )\())  /(_)) (   ))\((_|   
(_(_()))\   )\  '((_)\    )\ /(_)) (_))((_)\ /((_) (_))   )\ )\(_))/  (_))   )\ /((_)_ )\  
|_   _((_)_((_)) | |(_)  ((_|_) _| | |_| |(_|_))   | |   ((_|(_) |_   / __| ((_|_))(| ((_) 
  | |/ _ \ '  \()| '_ \ / _ \|  _| |  _| ' \/ -_)  | |__/ _ (_-<  _|  \__ \/ _ \ || | (_-< 
  |_|\___/_|_|_| |_.__/ \___/|_|    \__|_||_\___|  |____\___/__/\__|  |___/\___/\_,_|_/__/ 
                                                                                           

                           ,--.
                          {    }
                          K,   }
                         /  `Y`
                    _   /   /
                   {_'-K.__/
                     `/-.__L._
                     /  ' /`\_}
                    /  ' /     
            ____   /  ' /
     ,-'~~~~    ~~/  ' /_
   ,'             ``~~~%%',
  (                     %  Y
 {                      %% I
{      -                 %  `.
|       ',                %  )
|        |   ,..__      __. Y
|    .,_./  Y ' / ^Y   J   )|
\           |' /   |   |   ||
 \          L_/    . _ (_,.'(
  \,   ,      ^^""' / |      )
    \_  \          /,L]     /
      '-_`-,       ` `   ./`
         `-(_            )
             ^^\..___,.--`

                                                                                      


You are Entering the Tomb of the lost souls . What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Start", "Turn Back" };
            Menu mainMenu = new Menu(propmt, options);
            int selectedIndex = mainMenu.Run();
            bool exit = false;
            Console.Clear();

            Console.WriteLine("Loading.....");
            Thread.Sleep(500);
            string prompt = "Choose your Character";
            string[] character = { "Samuari", "Knight", "Viking" };
            Menu characerMenu = new Menu(prompt, character);
            int userSelection = characerMenu.Run();

            do
            {
      
                if (selectedIndex == 0)
                {
                    

                    if (userSelection == 0)
                    {
                        Player p1 = new Player(@"Samuari Jack
                       /|
                      /'||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||
                     |  ||         __.--._
                     |  ||      /~~   __.-~\ _
                     |  ||  _.-~ / _---._ ~-\/~\
                     |  || // /  /~/  .-  \  /~-\
                     |  ||((( /(/_(.-(-~~~~~-)_/ |
                     |  || ) (( |_.----~~~~~-._\ /
                     |  ||    ) |              \_|
                     |  ||     (| =-_   _.-=-  |~)        ,
                     |  ||      | `~~ |   ~~'  |/~-._-'/'/_,
                     |  ||       \    |        /~-.__---~ , ,
                     |  ||       |   ~-''     || `\_~~~----~
                     |  ||_.ssSS$$\ -====-   / )\_  ~~--~
             ___.----|~~~|%$$$$$$/ \_    _.-~ /' )$s._
    __---~-~~        |   |%%$$$$/ /  ~~~~   /'  /$$$$$$$s__
  /~       ~\    ============$$/ /        /'  /$$$$$$$$$$$SS-.
/'      ./\\\\\\_( ~---._(_))$/ /       /'  /$$$$%$$$$$~      \
(      //////////(~-(..___)/$/ /      /'  /$$%$$%$$$$'         \
 \    |||||||||||(~-(..___)$/ /  /  /'  /$$$%$$$%$$$            |
  `-__ \\\\\\\\\\\(-.(_____) /  / /'  /$$$$%$$$$$%$             |
      ~~""""""""""-\.(____) /   /'  /$$$$$%%$$$$$$\_            /
                    $|===|||  /'  /$$$$$$$%%%$$$$$( ~         ,'|
                __  $|===|%\/'  /$$$$$$$$$$$%%%%$$|        ,''  |
               ///\ $|===|/'  /$$$$$$%$$$$$$$%%%%$(            /'
                \///\|===|  /$$$$$$$$$%%$$$$$$%%%%$\_-._       |
                 `\//|===| /$$$$$$$$$$$%%%$$$$$$-~~~    ~      /
                   `\|-~~(~~-`$$$$$$$$$%%%///////._       ._  |
                   (__--~(     ~\\\\\\\\\\\\\\\\\\\\        \ \
                   (__--~~(       \\\\\\\\\\\\\\\\\\|        \/
                    (__--~(       ||||||||||||||||||/       _/
                     (__.--._____//////////////////__..---~~
                     |   """"'''''           ___,,,,ss$$$%
                    ,%\__      __,,,\sssSS$$$$$$$$$$$$$$%%
                  ,%%%%$$$$$$$$$$\;;;;\$$$$$$$$$$$$$$$$%%%$.
                 ,%%%%%%$$$$$$$$$$%\;;;;\$$$$$$$$$$$$%%%$$$$
               ,%%%%%%%%$$$$$$$$$%$$$\;;;;\$$$$$$$$$%%$$$$$$,
              ,%%%%%%%%%$$$$$$$$%$$$$$$\;;;;\$$$$$$%%$$$$$$$$
             ,%%%%%%%%%%%$$$$$$%$$$$$$$$$\;;;;\$$$%$$$$$$$$$$$
             %%%%%%%%%%%%$$$$$$$$$$$$$$$$$$\;;;$$$$$$$$$$$$$$$
               ""==%%%%%%%$$$$$TuaXiong$$$$$$$$$$$$$$$$$$$SV"
                            , 70, 35, 40, 45, Race.Samuari, katana);
                        Console.Clear();
                        Console.WriteLine("ready...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine(GetRoom());

                        Skeleton m1 = new Skeleton();
                        Skeleton m2 = new Skeleton(@"Skull King
                            ,-.
       ___,---.__          /'|`\          __,---,___
    ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.
  ,'        |           ~'\     /`~           |        `.
 /      ___//              `. ,'          ,  , \___      \
|    ,-'   `-.__   _         |        ,    __,-'   `-.    |
|   /          /\_  `   .    |    ,      _/\          \   |
\  |           \ \`-.___ \   |   / ___,-'/ /           |  /
 \  \           | `._   `\\  |  //'   _,' |           /  /
  `-.\         /'  _ `---'' , . ``---' _  `\         /,-'
     ``       /     \    ,='/ \`=.    /     \       ''
             |__   /|\_,--.,-.--,--._/|\   __|
             /  `./  \\`\ |  |  | /,//' \,'  \
            /   /                         \   \
           /   /                           \   \
           |   |     /'\_\_\ | /_/_/`\     |   |
            \   \__, \_     `~'     _/ .__/   /
             `-._,-'   `-._______,-'   `-._,-'", 65, 55, 35, 25, 10, 15, "The Most Feared", true);
                        Loki l1 = new Loki();
                        Dragon d1 = new Dragon();
                        Werewolf w1 = new Werewolf();

                        Opponents[] opponents = { m1, m2, l1, d1, w1 };
                        Random rand = new Random();
                        int randomNbr = rand.Next(opponents.Length);
                        Opponents opponent = opponents[randomNbr];

                        Console.WriteLine("\nYour Opponent: " + opponent.Name);

                        bool reload = false;
                        do
                        {
                            #region Menu
                            Console.WriteLine("\nPlease choose an action:\n" +
                                "A) Attack\n" +
                                "R) Run Away\n" +
                                "P) Player Infro\n" +
                                "O) OP Info\n" +
                                "X) Exit\n");
                            #endregion


                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (userChoice)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine("Attack!");
                                    Combat.DoBattle(p1, opponent);
                                    if (opponent.Life <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nYou Killed {0}\n", opponent.Name);
                                        Console.ResetColor();
                                        reload = true;
                                        score++;
                                    }
                                    break;
                                case ConsoleKey.R:
                                    Console.WriteLine("Run Away");
                                    Console.WriteLine($"{opponent.Name} attacks as you flee!");
                                    Combat.DoAttack(opponent, p1);
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                    reload = true;
                                    break;
                                case ConsoleKey.P:
                                    Console.WriteLine("Player Info");
                                    Console.WriteLine(p1);
                                    Console.WriteLine("Ops Defeated: " + score);
                                    break;
                                case ConsoleKey.O:
                                    Console.WriteLine("OP Info");
                                    Console.WriteLine(opponent);
                                    break;
                                case ConsoleKey.X:
                                case ConsoleKey.E:
                                case ConsoleKey.Escape:
                                    Console.WriteLine("No one likes a quitter!");
                                    exit = true;

                                    break;

                                default:
                                    Console.WriteLine("You know thats the wrong key try again");
                                    break;
                            }//end switch

                            if (p1.Life <= 0)
                            {
                                Console.WriteLine("Dude...you Died!\a");
                                exit = true;
                            }
                        } while (!exit && !reload);
                        Console.Clear();
                    }
                    if (userSelection == 1)
                    {
                        Player p2 = new Player(@"King Arthur
      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            ,
  \_| |`-._/||          ,'|
    |  `-, / |         /  /
    |     || |        /  /
     `r-._||/   __   /  /
 __,-<_     )`-/  `./  /
'  \   `---'   \   /  /
    |           |./  /
    /           //  /
\_/' \         |/  /
 |    |   _,^-'/  /
 |    , ``  (\/  /_
  \,.->._    \X-=/^
  (  /   `-._//^`
   `Y-.____(__}
    |     {__)", 30, 55, 60, 60, Race.Knight, Spear);
                        Console.Clear();
                        Console.WriteLine("ready...?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        

                        Skeleton m1 = new Skeleton();
                        Skeleton m2 = new Skeleton(@"Skull King
                            ,-.
       ___,---.__          /'|`\          __,---,___
    ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.
  ,'        |           ~'\     /`~           |        `.
 /      ___//              `. ,'          ,  , \___      \
|    ,-'   `-.__   _         |        ,    __,-'   `-.    |
|   /          /\_  `   .    |    ,      _/\          \   |
\  |           \ \`-.___ \   |   / ___,-'/ /           |  /
 \  \           | `._   `\\  |  //'   _,' |           /  /
  `-.\         /'  _ `---'' , . ``---' _  `\         /,-'
     ``       /     \    ,='/ \`=.    /     \       ''
             |__   /|\_,--.,-.--,--._/|\   __|
             /  `./  \\`\ |  |  | /,//' \,'  \
            /   /                         \   \
           /   /                           \   \
           |   |     /'\_\_\ | /_/_/`\     |   |
            \   \__, \_     `~'     _/ .__/   /
             `-._,-'   `-._______,-'   `-._,-'", 65, 55, 35, 25, 10, 15, "The Most Feared", true);
                        Loki l1 = new Loki();
                        Dragon d1 = new Dragon();
                        Werewolf w1 = new Werewolf();

                        Opponents[] opponents = { m1, m2, l1, d1, w1 };
                        Random rand = new Random();
                        int randomNbr = rand.Next(opponents.Length);
                        Opponents opponent = opponents[randomNbr];

                        Console.WriteLine("\nYour Opponent: " + opponent.Name);

                        bool reload = false;
                        do
                        {
                            #region Menu
                            Console.WriteLine("\nPlease choose an action:\n" +
                                "A) Attack\n" +
                                "R) Run Away\n" +
                                "P) Player Infro\n" +
                                "O) OP Info\n" +
                                "X) Exit\n");
                            #endregion


                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (userChoice)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine("Attack!");
                                    Combat.DoBattle(p2, opponent);
                                    if (opponent.Life <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nYou Killed {0}\n", opponent.Name);
                                        Console.ResetColor();
                                        reload = true;
                                        score++;
                                    }
                                    break;
                                case ConsoleKey.R:
                                    Console.WriteLine("Run Away");
                                    Console.WriteLine($"{opponent.Name} attacks as you flee!");
                                    Combat.DoAttack(opponent, p2);
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                    reload = true;
                                    break;
                                case ConsoleKey.P:
                                    Console.WriteLine("Player Info");
                                    Console.WriteLine(p2);
                                    Console.WriteLine("Ops Defeated: " + score);
                                    break;
                                case ConsoleKey.O:
                                    Console.WriteLine("OP Info");
                                    Console.WriteLine(opponent);
                                    break;
                                case ConsoleKey.X:
                                case ConsoleKey.E:
                                case ConsoleKey.Escape:
                                    Console.WriteLine("No one likes a quitter!");
                                    exit = true;

                                    break;

                                default:
                                    Console.WriteLine("You know thats the wrong key try again");
                                    break;
                            }//end switch

                            if (p2.Life <= 0)
                            {
                                Console.WriteLine("Dude...you Died!\a");
                                exit = true;
                            }
                        } while (!exit && !reload);
                        Console.Clear();

                    }
                   if (userSelection == 2)
                    {
                        Player p3 = new Player(@"Ragnar Lodbrok
                     .-'`-.
                    / | |  \
                   /  | |   \
                  |___|_|__  |
                  ||<o>| <o>`|
                  ||   J_   )|
                  `|`-'__`-'|/
                   |  `--'  |
                 .-|        |_
              .-'  \     /  | |`-.
           .-'      `.     /| |   \
          /           ````' | |    \
         |_____             | |     L
      .-' ___   `-.         F F  |  |
    .'.-'  |  `-.  `.      J J   /  |
   / /|    |    |`.  \     | |   |/ |
  / / |    |    |  `. `.   F F   |  |
 J /  |    |    |    \  L J J    |  |
 FJ   |    |    |    |L J/ /     |   \
J |() | () | () | () | J L/      |   |
| F   | .-'_ \  |    |  LJ       | /  L
| L   | /    \\ |    |  | L      |    |
| L   ||     ):||    |  | |     /|     L
J |   ||:._.'::||    |  | |----' |     |
J |   |J:::::::||    |  | |    _/\     |
 LJ   | \:::::/ |    |  | |---'\  |    |
 J L  |  `-:-'  |    |  | F  | \  |    J
  LJ()| () | () | () |  F F  |  \  \--._L
  J \ |    |    |    | J J     \    |  |
   \ \|    |    |    | / /    |     |  |
    \ \    |    |    |/ /|     |    | .-'|
     `.`.  |    |   .'.' |     |    |/ /`L
       `.`-.____|.-'.-'  |     |    | <`. \
         `-.______.-'    |    \|    |_`::\ `.
          |  |           |     |    /   \::. \
          |--|           |     _.--|     `::\ `.
          |\\|-.____     |__.-'    |       \::. \
          | >||      `--' J        |        `::\ `.
          |//JJ        |   L       |          \::. \
          |< |J        |   |       (           `::\ `.
          |\\|J        |   /        )            \::. \
          |--|J        |   \       /              `::\ `.
          |  |L `      )   )` `' '|                 \::. \
          |  L \    '  /   / ' |  |                  `::\ |o
          F  F J``  -'|    | | |  |                    \:_|
          `-'  | ""   |    J `    |
               |      |     L     |
               |      |     \     |
               J      |      `.   |
                L     F       )`---\
                |    J        /     `.
                J    J       (        `-.
                `-.__/       `---.       `.
                |   J             `.       )
                /   |               `-----'
               /    F
              J    J
              J    |
               `-.-'", 55, 45, 55, 55, Race.Viking, Axe);
                        Console.Clear();
                        Console.WriteLine("ready...?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine(GetRoom());

                        Skeleton m1 = new Skeleton();
                        Skeleton m2 = new Skeleton(@"Skull King
                            ,-.
       ___,---.__          /'|`\          __,---,___
    ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.
  ,'        |           ~'\     /`~           |        `.
 /      ___//              `. ,'          ,  , \___      \
|    ,-'   `-.__   _         |        ,    __,-'   `-.    |
|   /          /\_  `   .    |    ,      _/\          \   |
\  |           \ \`-.___ \   |   / ___,-'/ /           |  /
 \  \           | `._   `\\  |  //'   _,' |           /  /
  `-.\         /'  _ `---'' , . ``---' _  `\         /,-'
     ``       /     \    ,='/ \`=.    /     \       ''
             |__   /|\_,--.,-.--,--._/|\   __|
             /  `./  \\`\ |  |  | /,//' \,'  \
            /   /                         \   \
           /   /                           \   \
           |   |     /'\_\_\ | /_/_/`\     |   |
            \   \__, \_     `~'     _/ .__/   /
             `-._,-'   `-._______,-'   `-._,-'", 65, 55, 35, 25, 10, 15, "The Most Feared", true);
                        Loki l1 = new Loki();
                        Dragon d1 = new Dragon();
                        Werewolf w1 = new Werewolf();

                        Opponents[] opponents = { m1, m2, l1, d1, w1 };
                        Random rand = new Random();
                        int randomNbr = rand.Next(opponents.Length);
                        Opponents opponent = opponents[randomNbr];
                        Console.WriteLine("\nYour Opponent: " + opponent.Name);
                        Console.Clear();

                        bool reload = false;
                        do

                        {
                            #region Menu
                            Console.WriteLine("\nPlease choose an action:\n" +
                                "A) Attack\n" +
                                "R) Run Away\n" +
                                "P) Player Infro\n" +
                                "O) OP Info\n" +
                                "X) Exit\n");
                            #endregion


                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            switch (userChoice)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine("Attack!");
                                    Combat.DoBattle(p3, opponent);
                                    if (opponent.Life <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nYou Killed {0}\n", opponent.Name);
                                        Console.ResetColor();
                                        reload = true;
                                        score++;
                                    }
                                    break;
                                case ConsoleKey.R:
                                    Console.WriteLine("Run Away");
                                    Console.WriteLine($"{opponent.Name} attacks as you flee!");
                                    Console.Clear();
                                    Combat.DoAttack(opponent, p3);
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                    reload = true;
                                    break;
                                case ConsoleKey.P:
                                    Console.WriteLine("Player Info");
                                    Console.WriteLine(p3);
                                    Console.WriteLine("Ops Defeated: " + score);
                                    break;
                                case ConsoleKey.O:
                                    Console.WriteLine("OP Info");
                                    Console.WriteLine(opponent);
                                    break;
                                case ConsoleKey.X:
                                case ConsoleKey.E:
                                case ConsoleKey.Escape:
                                    Console.WriteLine("No one likes a quitter!");
                                    exit = true;

                                    break;

                                default:
                                    Console.WriteLine("You know thats the wrong key try again");
                                    break;
                            }//end switch

                            if (p3.Life <= 0)
                            {
                                Console.WriteLine("Dude...you Died!\a");
                                exit = true;
                            }
                        } while (!exit && !reload);
                        Console.Clear();
                    }
                    
                        #region Menu

                }



                else if (selectedIndex == 1)
                {
                    Console.WriteLine("I knew you were afraid");
                    exit = true;
                }




                #endregion


            } while (!exit);
            
        }

        private static string GetRoom()
        {
            string[] rooms =
            {
                 "The room is dark and musty with the smell of lost souls.",
                  "his small chamber is a bloody mess. The corpse of a minotaur lies on the floor, its belly carved out. The creature's innards are largely missing, and yet you detect no other wounds. Bloody, froglike footprints track away from the corpse and out an open door.",
                "You've opened the door to a torture chamber. Several devices of degradation, pain, and death stand about the room, all of them showing signs of regular use. The wood of the rack is worn smooth by struggling bodies, and the iron maiden appears to be occupied by a corpse.",
                " A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog. Other details are difficult to make out, but some creature must be nearby, because it smells like a good soup is cooking.",
                "This room is a small antechamber before two titanic bronze doors. Each stands 20 feet tall and is about 7 feet wide. The double doors are peaked at their centers, but unlike many sets of double doors, their division isn't in the center. Instead, the crack between the doors resembles a crooked bolt of lightning, which a figure in a cloud carved in the stone above the door appears to be hurling. The lightning bolt strikes down roughly 2 feet to the right of center. The figure in the clouds is deliberately indistinct, but it appears male, having a beard and male proportions. The stroke of bronze electricity hits a tower that seems small compared to the figure. This tower cracks down the center, continuing the gap between the doors until it reaches the ground. To either side of the tower lie pastoral scenes of hillsides dotted with sheep. There doesn't appear to be a lock or handles.",
                "You open the door and before you is a dragon's hoard of treasure. Coins cover every inch of the room, and jeweled objects of precious metal jut up from the money like glittering islands in a sea of gold.",
                "The burble of water reaches your ears after you open the door to this room. You see the source of the noise in the far wall: a large fountain artfully carved to look like a seashell with the figure of a seacat spewing clear water into its basin.",
                "This small room contains several pieces of well-polished wood furniture. Eight ornate, high-backed chairs surround a long oval table, and a side table stands next to the far exit. All bear delicate carvings of various shapes. One bears carvings of skulls and bones, another is carved with shields and magic circles, and a third is carved with shapes like flames and lightning strokes.",
                "A strange ceiling is the focal point of the room before you. It's honeycombed with hundreds of holes about as wide as your head. They seem to penetrate the ceiling to some height beyond a couple feet, but you can't be sure from your vantage point.",
                "This room is a small antechamber before two titanic bronze doors. Each stands 20 feet tall and is about 7 feet wide. The double doors are peaked at their centers, but unlike many sets of double doors, their division isn't in the center. Instead, the crack between the doors resembles a crooked bolt of lightning, which a figure in a cloud carved in the stone above the door appears to be hurling. The lightning bolt strikes down roughly 2 feet to the right of center. The figure in the clouds is deliberately indistinct, but it appears male, having a beard and male proportions. The stroke of bronze electricity hits a tower that seems small compared to the figure. This tower cracks down the center, continuing the gap between the doors until it reaches the ground. To either side of the tower lie pastoral scenes of hillsides dotted with sheep. There doesn't appear to be a lock or handles.",
                "The door creaks open, which somewhat overshadows the sound of bubbling liquid. Before you is a room about which alchemists dream. Three tables bend beneath a clutter of bottles of liquid and connected glass piping. Several bookshelves stand nearby stuffed to overfilling with a jumble of books, jars, bottles, bags, and boxes. The alchemist who set this all up doesn't seem to be present, but a beaker of green fluid boils over a burner on one of the tables.",
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }
        //Console.WriteLine(GetRoom());

        // Mongol m1 = new Mongol();

        //Opponents[] opponents = { m1 };

        //Random rand = new Random();
        //int randomNbr = rand.Next(opponents.Length);
        //Opponents opponent = opponents[randomNbr];

        //Console.WriteLine("\nYour Opponent:" + opponent.Name);

    }//end class 
}//end name space
