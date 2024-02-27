class Program
{
    public static void Main()
    {
        //GAME SETUP
        Console.WriteLine("Enter your name:");
        string PlayerName = Console.ReadLine();

        Player player = new Player(PlayerName);
        player.CurrentLocation = World.Locations[0];
        player.CurrentWeapon = World.Weapons[0];

        //GAME RUNNING LOOP
        while (true)
        {
            Console.WriteLine(new string('#', 30));
            Console.WriteLine("       Welcome to TOOMB");
            Console.WriteLine(new string('#', 30));
            Console.WriteLine("\nThe people in your town are being terrorized by giant spiders. You decide to do what you can to help.");

            Move(Compas());
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

        //REQUEST COMPASS
        string Compas()
        {
            string PossibleDirections = Directions(player);
            Console.WriteLine($""" 
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

From your current location you can go: {PossibleDirections}
Where do you want to go?
""");
            // ASK WHERE YOU WANT TO GO
            while (true)
            {
                string direction = Console.ReadLine().ToUpper();
                if (PossibleDirections.Contains(direction))
                {
                    return direction;
                }
                else
                {
                    Console.WriteLine("Invalid direction");
                }
            }
        }

        // MOVE TO THE NEW DIRECTION
        void Move(string direction)
        {
            //switch statement --> als je noord kiest, ga je naar player.CurrentLocation.LocationToNorth etc.
            switch (direction)
            {
                case "N": player.CurrentLocation = player.CurrentLocation.LocationToNorth; break;
                case "E": player.CurrentLocation = player.CurrentLocation.LocationToEast; break;
                case "S": player.CurrentLocation = player.CurrentLocation.LocationToSouth; break;
                case "W": player.CurrentLocation = player.CurrentLocation.LocationToWest; break;
                default: Console.WriteLine("Invalid direction"); break;
            }
        }
    }
}