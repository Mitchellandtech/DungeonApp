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
            Weapons Sword = new Weapons(1, 8, "Sword", 10, false);
            Weapons katana = new Weapons(3, 15, "katana", 11, true);
            Weapons Spear = new Weapons(8, 22, "Spear", 20, true);


            #endregion



            string propmt = @" 
 (                                                                                    
 )\ )                             )        (  (                                       
(()/(   (               )      ( /( (      )\))(   '    )  (    (   (        (        
 /(_))  )\ )   (     ( /(  (   )\()))\ )  ((_)()\ )  ( /(  )(   )(  )\   (   )(   (   
(_))_  (()/(   )\ )  )(_)) )\ (_))/(()/(  _(())\_)() )(_))(()\ (()\((_)  )\ (()\  )\  
 |   \  )(_)) _(_/( ((_)_ ((_)| |_  )(_)) \ \((_)/ /((_)_  ((_) ((_)(_) ((_) ((_)((_) 
 | |) || || || ' \))/ _` |(_-<|  _|| || |  \ \/\/ / / _` || '_|| '_|| |/ _ \| '_|(_-< 
 |___/  \_, ||_||_| \__,_|/__/ \__| \_, |   \_/\_/  \__,_||_|  |_|  |_|\___/|_|  /__/ 
        |__/                        |__/                                              

You are Entering the League of the Dynasty Warriors . What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Start", "Turn Back" };
            Menu mainMenu = new Menu(propmt, options);
            int selectedIndex = mainMenu.Run();
            bool exit = false;
            Console.Clear();


            do
            {
                if (selectedIndex == 0)
                {
                    Console.WriteLine("Loading.....");
                    Thread.Sleep(500);
                    string prompt = "Choose your Character";
                    string[] character = { "Samuari", "Knight", "Viking" };
                    Menu characerMenu = new Menu(prompt, character);
                    int userSelection = characerMenu.Run();
                    

                    switch (userSelection)
                    {
                        case 0:
                            Player p1 = new Player("Samuari Jack", 70, 35, 40, 45, Race.Samuari, katana);
                            Console.Clear();
                            Console.WriteLine("Are you ready...?");
                            Thread.Sleep(3000);
                            break;

                        case 1:
                            Player p2 = new Player("King Arthur", 30, 55, 60, 60, Race.Knight, Spear);
                            Console.Clear();
                            Console.WriteLine("Are you ready...?");
                            Thread.Sleep(3000);
                            break;

                        case 2:
                            Player p3 = new Player("Ragnar Lodbrok", 55, 45, 55, 55, Race.Viking, Sword);
                            Console.Clear();
                            Console.WriteLine("Are you ready...?");
                            Thread.Sleep(3000);
                            break;
                             

                        default:
                            break;
                    }
                }
                else if (selectedIndex == 1)
                {
                    Console.WriteLine("I knew you were afraid");
                    exit = true;
                }
                        

                

                #region
                //static void Main(string[] args)
                //{


                //    //string propmt = "You are Entering the Vault of the Lost Souls. What would you like to do?";
                //    //string[] options = { "Turn Back", "Start" };
                //    //sss mainMenu = new ss(propmt, options);
                //    //mainMenu.DisplayOptions();

                //    //Console.WriteLine("Press any key to exit...");
                //    //Console.ReadKey(true);





                //    //    Console.Title = "-------------Vault Of The Lost Souls----------";
                //    //    Console.WriteLine("##   ####   #####   ##   ####");
                //    //    Console.WriteLine("#    #  #     #     #    #  #");
                //    //    Console.WriteLine("##   #  #     #     ##   #  #");
                //    //    Console.WriteLine("#    #  #     #     #    #");
                //    //    Console.WriteLine("##   #  #     #     ##   #");




                //    int score = 0;

                //    //TODO 1. Creat weapon

                //    //TODO 2. Create the Player

                //    //TODO 3. Create the outer do while loop that anages the entire game 

                //    bool exit = false;

                //    do
                //    {
                //        //TODO 4. Write a method for getting a room description


                //        //TODO 5. Crate a monster for the player to fight 

                //        // TODO 6. Create a loop for the main menu 


                //        #region Menu
                //        bool reload = false;
                //        do
                //        {
                //            Console.WriteLine("----------Please Choose an Action----------\n\n" +
                //         "A) Attack" + " R) Run Away" + " P) Player Info" + " M) Monster Info" + " X) Exit");

                //            ConsoleKey userChoice = Console.ReadKey(true).Key;
                //            Console.Clear();

                //            switch (userChoice)
                //            {
                //                case ConsoleKey.A:
                //                    //TODO 7. place attack logic
                //                    Console.WriteLine("Attack!");
                //                    break;

                //                case ConsoleKey.R:
                //                    //TODO 8. handle run awway logic
                //                    Console.WriteLine("RUN!!!");
                //                    Console.WriteLine();


                //                    reload = true;
                //                    break;

                //                case ConsoleKey.P:
                //                    Console.WriteLine("Player Info");
                //                    //TODO 9. PLAyer info - create player first
                //                    break;

                //                case ConsoleKey.M:
                //                    Console.WriteLine("Monster Info");
                //                    //TODO 10. Add monster info - create monster first
                //                    break;
                //                case ConsoleKey.X:
                //                case ConsoleKey.E:
                //                case ConsoleKey.Escape:
                //                    Console.WriteLine("Really? You're quitting already?");
                //                    exit = true;

                //                    break;


                //                default:
                //                    Console.WriteLine("Wrong key please try again");
                //                    break;
                //            }//ed switch

                //            //TODO 11 check the palayers life and handle if the player has died

                //        } while (!exit && !reload);

                //    } while (!exit);
                //    Console.WriteLine("Game Over\n" +
                //        "You defeated {0} monster.", score);
                //    #endregion




                //}//end main

                //private static string GetRoom()
                //{
                //    string[] rooms =
                //    {
                //       "The room is dark and musty with the smell of lost souls.",
                //       "his small chamber is a bloody mess. The corpse of a minotaur lies on the floor, its belly carved out. The creature's innards are largely missing, and yet you detect no other wounds. Bloody, froglike footprints track away from the corpse and out an open door.",
                //        "You've opened the door to a torture chamber. Several devices of degradation, pain, and death stand about the room, all of them showing signs of regular use. The wood of the rack is worn smooth by struggling bodies, and the iron maiden appears to be occupied by a corpse.",
                //        " A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog. Other details are difficult to make out, but some creature must be nearby, because it smells like a good soup is cooking.",
                //        "This room is a small antechamber before two titanic bronze doors. Each stands 20 feet tall and is about 7 feet wide. The double doors are peaked at their centers, but unlike many sets of double doors, their division isn't in the center. Instead, the crack between the doors resembles a crooked bolt of lightning, which a figure in a cloud carved in the stone above the door appears to be hurling. The lightning bolt strikes down roughly 2 feet to the right of center. The figure in the clouds is deliberately indistinct, but it appears male, having a beard and male proportions. The stroke of bronze electricity hits a tower that seems small compared to the figure. This tower cracks down the center, continuing the gap between the doors until it reaches the ground. To either side of the tower lie pastoral scenes of hillsides dotted with sheep. There doesn't appear to be a lock or handles.",
                //       "You open the door and before you is a dragon's hoard of treasure. Coins cover every inch of the room, and jeweled objects of precious metal jut up from the money like glittering islands in a sea of gold.",
                //        "The burble of water reaches your ears after you open the door to this room. You see the source of the noise in the far wall: a large fountain artfully carved to look like a seashell with the figure of a seacat spewing clear water into its basin.",
                //       "This small room contains several pieces of well-polished wood furniture. Eight ornate, high-backed chairs surround a long oval table, and a side table stands next to the far exit. All bear delicate carvings of various shapes. One bears carvings of skulls and bones, another is carved with shields and magic circles, and a third is carved with shapes like flames and lightning strokes.",
                //        "A strange ceiling is the focal point of the room before you. It's honeycombed with hundreds of holes about as wide as your head. They seem to penetrate the ceiling to some height beyond a couple feet, but you can't be sure from your vantage point.",
                //       "This room is a small antechamber before two titanic bronze doors. Each stands 20 feet tall and is about 7 feet wide. The double doors are peaked at their centers, but unlike many sets of double doors, their division isn't in the center. Instead, the crack between the doors resembles a crooked bolt of lightning, which a figure in a cloud carved in the stone above the door appears to be hurling. The lightning bolt strikes down roughly 2 feet to the right of center. The figure in the clouds is deliberately indistinct, but it appears male, having a beard and male proportions. The stroke of bronze electricity hits a tower that seems small compared to the figure. This tower cracks down the center, continuing the gap between the doors until it reaches the ground. To either side of the tower lie pastoral scenes of hillsides dotted with sheep. There doesn't appear to be a lock or handles.",
                //        "The door creaks open, which somewhat overshadows the sound of bubbling liquid. Before you is a room about which alchemists dream. Three tables bend beneath a clutter of bottles of liquid and connected glass piping. Several bookshelves stand nearby stuffed to overfilling with a jumble of books, jars, bottles, bags, and boxes. The alchemist who set this all up doesn't seem to be present, but a beaker of green fluid boils over a burner on one of the tables.",
                //    };

                //    Random rand = new Random();

                //    int indexNbr = rand.Next(rooms.Length);

                //    string room = rooms[indexNbr];


                //    return room;
                //}
                #endregion


            } while (!exit);
        //    ExitGame();
        }
    }//end class 
}//end name space
