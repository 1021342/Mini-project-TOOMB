class Program
{
    public static void Main()
    {
        //GAME SETUP
        Console.WriteLine("Enter your name:");
        string PlayerName = Console.ReadLine();

        Player player = new Player(PlayerName);
        player.CurrentLocation = World.Locations[0];

        //GAME RUNNING LOOP
        while (true)
        {
            //
        }
    }
}