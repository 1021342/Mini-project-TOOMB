class Player
{
    public int CurrentHitPoints = 100; //health player!!
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public const int MaximumHitPoints = 10; //damage player
    public readonly string Name;
    public List<string> Inventory = new List<string>();

    public Player(string Name, Location startinglocation, Weapon sword)
    {
        this.Name = Name;
        this.CurrentLocation = startinglocation;
        this.CurrentWeapon = sword;
    }
}

// //Vecht menu:
// class Program
// {
//     static void Main()
//     {
//         Enemy enemy = new Enemy("naam van het monster waar je tegen vecht");

//         while (true)
//         {
//             Console.WriteLine("\n===== Fight menu =====");
//             Console.WriteLine("1. See stats");
//             Console.WriteLine("2. Go to a different location");
//             Console.WriteLine("3. Fight");
//             Console.WriteLine("4. Quit game");

//             Console.Write("Kies een optie (1/2/3/4): ");
//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     ShowStats(player);
//                     break;
//                 case "2":
//                     Move();
//                     break;
//                 case "3":
//                     Fight(player, enemy);
//                     break;
//                 case "4":
//                     Console.WriteLine("Thanks for playing");
//                     return;
//                 default:
//                     Console.WriteLine("Please enter(1/2/3/4): ");
//                     break;
//             }
//         }
//     }
// }