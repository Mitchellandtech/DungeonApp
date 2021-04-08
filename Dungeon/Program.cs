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
            Console.Title = "----Dynasty Warriors----";

            #region Weapon
            Weapons Sword = new Weapons(1, 8, "Sword", 10, false);
            Weapons katana = new Weapons(3, 15, "katana", 11, true);
            Weapons Spear = new Weapons(8, 22, "Spear", 20, true);

            int score = 0;

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
                Console.WriteLine(GetRoom());

                Mongol m1 = new Mongol();

                Opponents[] opponents = { m1 };

                Random rand = new Random();
                int randomNbr = rand.Next(opponents.Length);
                Opponents opponent = opponents[randomNbr];

                Console.WriteLine("\nYour Opponent:" + opponent.Name);


                if (selectedIndex == 0)
                {
                    Console.WriteLine("Loading.....");
                    Thread.Sleep(500);
                    string prompt = "Choose your Character";
                    string[] character = { "Samuari", "Knight", "Viking" };
                    Menu characerMenu = new Menu(prompt, character);
                    int userSelection = characerMenu.Run();


                    if (userSelection == 0)
                    {
                        Player p1 = new Player("Samuari Jack", 70, 35, 40, 45, Race.Samuari, katana);
                        Console.Clear();
                        Console.WriteLine("ready...?");
                        Thread.Sleep(3000);
                        Console.WriteLine("Fight!");

                    }
                    else if (userSelection == 1)
                    {
                        Player p2 = new Player("King Arthur", 30, 55, 60, 60, Race.Knight, Spear);
                        Console.Clear();
                        Console.WriteLine("Are you ready...?");
                        Thread.Sleep(3000);
                    }
                    else if (userSelection == 2)
                    {
                        Player p3 = new Player("Ragnar Lodbrok", 55, 45, 55, 55, Race.Viking, Sword);
                        Console.Clear();
                        Console.WriteLine("Are you ready...?");
                        Thread.Sleep(3000);
                    }

                        #region Menu
                        string actions = "Please choose an action";
                        string[] choices = { "Attack", "Run Away", "Player Info", "Opponent Info", "Exit" };
                        Menu optionsMenu = new Menu (actions, choices ); 
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

    }//end class 
}//end name space
