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
            Weapons Axe = new Weapons(1, 8, @"Axe
 ,  /\  .  
 //`-||-'\\ 
(| -=||=- |)
 \\,-||-.// 
  `  ||  '  
     ||     
     ||     
     ||     
     ||     
     ||     
     ()", 10, false);
            Weapons katana = new Weapons(3, 15, @"katana
,_._._._._._._._._|__________________________________________________________,
|_|_|_|_|_|_|_|_|_|_________________________________________________________/
                  !", 11, true);
            Weapons Spear = new Weapons(8, 22, @"Spear
>>>>>>>_____________________\`-._
>>>>>>>                     /.-'", 20, true);

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
                        Player p1 = new Player("Samuari Jack", 70, 35, 40, 45, Race.Samuari, katana);
                        Console.Clear();
                        Console.WriteLine("ready...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine(GetRoom());

                        Mongol m1 = new Mongol();
                        Mongol m2 = new Mongol("Genghis Khan", 65, 55, 35, 25, 10, 15, "The Most Feared", true);
                        Loki l1 = new Loki();
                        Dragon d1 = new Dragon();

                        Opponents[] opponents = { m1, m2, l1 };
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

                    }
                    if (userSelection == 1)
                    {
                        Player p2 = new Player("King Arthur", 30, 55, 60, 60, Race.Knight, Spear);
                        Console.Clear();
                        Console.WriteLine("ready...?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine(GetRoom());

                        Mongol m1 = new Mongol();
                        Mongol m2 = new Mongol("Genghis Khan", 65, 55, 35, 25, 10, 15, "The Most Feared", true);
                        Loki l1 = new Loki();
                        Dragon d1 = new Dragon();

                        Opponents[] opponents = { m1, m2, l1 };
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


                    }
                   if (userSelection == 2)
                    {
                        Player p3 = new Player("Ragnar Lodbrok", 55, 45, 55, 55, Race.Viking, Axe);
                        Console.Clear();
                        Console.WriteLine("ready...?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine(GetRoom());

                        Mongol m1 = new Mongol();
                        Mongol m2 = new Mongol("Genghis Khan", 65, 55, 35, 25, 10, 15, "The Most Feared", true);
                        Loki l1 = new Loki();
                        Dragon d1 = new Dragon();

                        Opponents[] opponents = { m1, m2, l1 };
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
                    }
                    
                        #region Menu
                        //string actions = "Please choose an action";
                        //string[] choices = { "Attack", "Run Away", "Player Info", "Opponent Info", "Exit" };
                        //Menu optionsMenu = new Menu (actions, choices ); 
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
                 "The room is dark and musty with the smell of lost souls."
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
