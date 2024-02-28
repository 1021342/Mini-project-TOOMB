public class Loop
{
    public static bool Exit(string reason)
        {
            if (reason == "won")
            {
                Console.WriteLine("Congrats! You won the game");
            }
            else if (reason == "lost")
            {
                Console.WriteLine("Better luck next time!");
            }
            else
            {
                Console.WriteLine("See you next time!");
            }

            return false;
        }
}