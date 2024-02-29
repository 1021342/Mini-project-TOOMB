using System.Security.Cryptography.X509Certificates;

class Program
{
    public static bool game = true;

    public static void Main()
    {
        
        //GAME SETUP
        Console.WriteLine("Enter your name:");
        string PlayerName = Console.ReadLine();

        Player player = new Player(PlayerName, World.Locations[0], World.Weapons[0]);

        Console.WriteLine(new string('#', 30));
        Console.WriteLine("       Welcome to TOOMB");
        Console.WriteLine(new string('#', 30));
        Console.WriteLine("\nThe people in your town are being terrorized by giant spiders. You decide to do what you can to help.\n");
        Compass();

        //GAME RUNNING LOOP
        while (game == true)
        {
            MainMenu();

            //Checks for available quest and activates it
            Quest AvailableQuest = player.CurrentLocation.QuestAvailableHere;
            if (AvailableQuest != null)
            {
                SuperAdventure adventure = new SuperAdventure(World.Monsters[AvailableQuest.ID - 1], player);
                adventure.CurrentQuest(AvailableQuest);
            }
            else if (player.CurrentLocation.ID == 3 && Quest.QuestCounter != 2)
            {
                SuperAdventure adventure = new SuperAdventure(null, player);
                adventure.ActivateDialogueGuard();
                player.CurrentLocation.ID = 2;
            }

            if (Quest.QuestCounter == 3)
            {
                game = Loop.Exit("won");
            }
        }

// OTHER METHODS

        // LOCATIONS YOU CAN GO BASED ON YOUR CURRENT LOCATION
        string Directions(Player player)
        {
            if (player.CurrentLocation.ID == 5 || player.CurrentLocation.ID == 4)
            {
                return "S";
            }
            else if (player.CurrentLocation.ID == 6 || player.CurrentLocation.ID == 3 || player.CurrentLocation.ID == 8)
            {
                return "E,W";
            }
            else if (player.CurrentLocation.ID == 7)
            {
                return "E";
            }
            else if (player.CurrentLocation.ID == 9)
            {
                return "W";
            }
            else if (player.CurrentLocation.ID == 1)
            {
                return "N";
            }
            else if (player.CurrentLocation.ID == 2)
            {
                return "N,E,S,W";
            }
            return null;
        }

        // COMPASS
        void Compass()
        {
            Console.WriteLine($""" 

===== Compass =====
You are here: {player.CurrentLocation.Name}
  P
  A
VFTGBS
  H

H: Your house (game start)
T: Town square
F: Farmer
V: Farmer’s field
A: Alchemist’s hut
P: Alchemist’s garden
G: Guard post
B: Bridge
S: Spider forest

""");
        }

        // MOVE TO THE NEW DIRECTION
        void Move()
        {
            string PossibleDirections = Directions(player);

            while (true)
            {
                Console.WriteLine("Where do you want to go?");
                Console.WriteLine($"From your current location you can go: {Directions(player)}");
                string direction = Console.ReadLine().ToUpper();

                if (PossibleDirections.Contains(direction) && direction.Length == 1)
                {
                    switch (direction)
                    {
                        case "N": player.CurrentLocation = player.CurrentLocation.LocationToNorth; break;
                        case "E": player.CurrentLocation = player.CurrentLocation.LocationToEast; break;
                        case "S": player.CurrentLocation = player.CurrentLocation.LocationToSouth; break;
                        case "W": player.CurrentLocation = player.CurrentLocation.LocationToWest; break;
                        default: Console.WriteLine("Invalid direction"); break;
                    }
                    break;
                }
            }
            Console.WriteLine($"You are now here: {player.CurrentLocation.Name}");
        }

        

        // MAIN MENU
        void MainMenu()
        {
            Console.WriteLine("""

===== Main menu =====
What do you want to do?

C: See the map
M: Move somewhere else
I: See inventory
Q: Quit the game

""");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "C")
            {
                Compass();
            }
            else if (choice == "M")
            {
                Move();
            }
            else if (choice == "I")
            {
                if (player.Inventory.Count == 0)
                {
                    Console.WriteLine("You don't have any items.");
                }
                else
                {
                    foreach (string item in player.Inventory)
                    {
                        Console.WriteLine("item");
                    }
                }
            }
            else if (choice == "Q")
            {
                game = Loop.Exit("quit");
            }
        }

    // END  OF MAIN!
    }
    // public static bool Crit_Calculator(int plyrlevel)
    // {
    //     float critChance = 0.0f;
    //     if (plyrlevel == 1)
    //     {
    //         critChance = 0.05f; // 5%
    //     }
    //     else if (plyrlevel == 2)
    //     {
    //         critChance = 0.1f; // 10%
    //     }
    //     else if (plyrlevel == 3)
    //     {
    //         critChance = 0.15f; // 15%
    //     }
    //     else
    //     {
    //         critChance = 0.2f; // 20% for levels 4 and above
    //     }

    //     float randValue = (float)new Random().NextDouble();
    //     // this can return either true or false; true = crit success, false = crit failed
    //     return randValue < critChance;
    // }
}