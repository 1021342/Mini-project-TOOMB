using System.ComponentModel;

public class Quest
{

    public string Description;
    public int ID;
    public string Name;
    public static int QuestCounter = 0;

    static bool SnakeKilled = false;
    static bool RatsKilled = false;
    static bool SpidersKilled = false;

    public Quest(int id, string name, string description)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
    }

    public static void FarmersQuest()
    // Kill snakes in the farmer’s field (V)
    // Killing three snakes will complete the quest and give +2 def shield

    {
        Console.WriteLine("The farmer begins to shout colorful language upon seeing you walk in through the gate");
        Console.WriteLine("While aiming his shotgun at you, he asks you what you're doing here.");
        Console.WriteLine("You try to remain calm, and explain that you're just passing by, and mean no harm.");
        Console.WriteLine("The farmer scoffs, and raises his gun slightly.");
        Console.WriteLine("He asks you for help exterminating the snakes that have been invading his field.");
        Console.WriteLine("You feel you have little choice.");
        Console.WriteLine("Quest: Kill three snakes in the farmer's field.");

        int SnakeDeathCounter = 0;
        // implement snake death
        if (SnakeKilled)
        {
            SnakeDeathCounter += 1;
        }

            if (SnakeDeathCounter == 3)
            {
                Console.WriteLine("The farmer starts to shout again, this time of glee.");
                Console.WriteLine("He thanks you for finally getting rid of those snakes, mentioning something about dinner");
                Console.WriteLine("You politely decline and insisting on a reward, the farmer pulls out a shield instead");
                Console.WriteLine("You thank him, and say you'll be on your way.");
                Console.WriteLine("Quest completed: Kill three snakes in the farmer's field.");
                Console.WriteLine("Item Obtained: Wooden Shield.");
                QuestCounter += 1;
            }
            else if (SnakeDeathCounter <= 3)
            {
                Console.WriteLine($"{SnakeDeathCounter} out of 3 snakes have been killed.");
            }

    }

    public static void AlchemistsQuest()
    {
        // Kill rats in the alchemist’s garden (P)
        // Killing three rats will complete the quest and give +3 dmg strength potion
        Console.WriteLine("You stumble upon the alchemist's hut. A frail old woman shuffles towards you");
        Console.WriteLine("");
        Console.WriteLine("Quest: Kill three rats in the alchemist's garden.");
        // insert more dialogue later

        int RatDeathCounter = 0;
        // implement rat death
        if (RatsKilled)
        {
            RatDeathCounter += 1;
        }

            if (RatDeathCounter == 3)
            {
                Console.WriteLine("Quest completed: Kill three rats in the alchemist's garden.");
                Console.WriteLine("Item Obtained: Strength Potion.");
                Console.WriteLine("Downing the potion, you instantly feel more powerful.");
                Console.WriteLine("You feel like you could do more damage to monsters around you.");
                QuestCounter += 1;
            } 

            else if (RatDeathCounter <= 3)
            {
                Console.WriteLine($"{RatDeathCounter} out of 3 rats have been killed.");
            }
    }
    public static void SpiderQuest()
    // The main quest that lets the player win the game
    // The game is won when you have killed three spiders
    {
        Console.WriteLine("You enter the spiders liar. A chill goes down your spine.");
        Console.WriteLine("Something rustles behind you. You freeze.");
        Console.WriteLine("You feel something brush against your leg. You swallow, hard.");
        Console.WriteLine("You carefully turn around, only to find 24 eyes staring back at you.");
        Console.WriteLine("One spider as large as a horsecart, two the size of a hog. Its minions, you assume.");
        Console.WriteLine("The spiders hiss, and start crawling towards you at high speeds, mandibles snapping.");
        Console.WriteLine("Quest: Kill the three spiders in the spider's liar.");

        int SpiderDeathCounter = 0;
        // implement snake death
        if (SpidersKilled)
        {
            SpiderDeathCounter += 1;
        }

            if (SpiderDeathCounter == 3)
            {
                Console.WriteLine("You've won. Panting, you look down on the beasts.");
                Console.WriteLine("Their mangled bodies make you feel light-headed, but at least the threat is over.");
                Console.WriteLine("The townspeople will be free to enjoy their days once again.");
                Console.WriteLine("Quest completed: Kill the three spiders in the spider's lair.");
                Console.WriteLine("Thank you for playing!");
                Loop.Exit("won");
            } 

            else if (SpiderDeathCounter <= 3)
            {
                Console.WriteLine($"{SpiderDeathCounter} out of 3 spiders have been killed.");
            }
    }

    public static void GuardQuest()
    // get past the guard when you have two quests done
    {
        Console.WriteLine("HALT! A guardsman is standing in front of a large gate.");
        Console.WriteLine("He says that only men who have proven themselves may go past this point.");

        if (QuestCounter == 2)
        {
            Console.WriteLine("You explain you've been trying your best to help around town.");
            Console.WriteLine("The guard mumbles something about hearing certain complaints had been pulled... must've been your doing.");
            Console.WriteLine("The guard relents, raising the halberd that was previously blocking your path.");
            Console.WriteLine("Go on, then.");
        }
        else
        {
            Console.WriteLine("Maybe it's best to come back after you've helped some people out...");
            Console.WriteLine("Just two should do, right?");
        }

    }
}
