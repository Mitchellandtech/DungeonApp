using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using System.Threading;

namespace Dungeon
{
    class update
    {
        static void Main(string[] args)
        {
            Console.Title = "----Tomb of the Lost Souls----";

            #region Weapon
            Weapons Sword = new Weapons(1, 8, "Sword", 10, false);
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

                        Console.WriteLine(GetRoom());

                        Mongol m1 = new Mongol();
                        Mongol m2 = new Mongol("Genghis Khan", 65, 55, 35, 25, 10, 15, "The Most Feared", true);

                        Opponents[] opponents = { m1, m2 };
                        Random rand = new Random();
                        int randomNbr = rand.Next(opponents.Length);
                        Opponents opponent = opponents[randomNbr];

                        Console.WriteLine("\nYour Opponent: " + opponent.Name);

                        bool reload = false;
                        do
                        {
                            #region Menu

                            string action = "Please choose an action";
                            string[] option = { "Attack", "Run Away", "Player Info", "OP Info", "Exit" };
                            Menu choiceMenu = new Menu(action, option);
                            int userAction = choiceMenu.Run();
                            //Console.WriteLine("\nPlease choose an action:\n" +
                            //    "A) Attack\n" +
                            //    "R) Run Away\n" +
                            //    "P) Player Infro\n" +
                            //    "O) OP Info\n" +
                            //    "X) Exit\n");
                            #endregion


                            Console.Clear();
                            switch (userAction)
                            {
                                case 0:
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
                                case 1:
                                    Console.WriteLine("Run Away");
                                    Console.WriteLine($"{opponent.Name} attacks as you flee!");
                                    Combat.DoAttack(opponent, p1);
                                    Console.WriteLine();
                                    reload = true;
                                    break;
                                case 2:
                                    Console.WriteLine("Player Info");
                                    Console.WriteLine(p1);
                                    Console.WriteLine("Ops Defeated: " + score);
                                    break;
                                case 3:
                                    Console.WriteLine("OP Info");
                                    Console.WriteLine(opponent);
                                    break;

                                case 4:
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
                    }
                    if (userSelection == 2)
                    {
                        Player p3 = new Player("Ragnar Lodbrok", 55, 45, 55, 55, Race.Viking, Sword);
                        Console.Clear();
                        Console.WriteLine("ready...?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Fight!");
                    }

                    #region Menu
                    string actions = "Please choose an action";
                    string[] choices = { "Attack", "Run Away", "Player Info", "Opponent Info", "Exit" };
                    Menu optionsMenu = new Menu(actions, choices);
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
    }
}
