﻿class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name:");
        string PlayerName = Console.ReadLine();

        Player player = new Player(PlayerName);
    }
}