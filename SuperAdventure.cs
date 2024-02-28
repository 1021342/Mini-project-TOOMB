class SuperAdventure
{
    public Monster CurrentMonster;
    public Player Player;

    public SuperAdventure(Monster currentmonster, Player player)
    {
        this.CurrentMonster = currentmonster;
        this.Player = player;
    }

    //Loops through possible quest, in case location contains one to be activated.
    public void CurrentQuest(Quest LocationQuest)
    {
        ActivateDialogueStart(LocationQuest.ID);

        for (int totalMonsters = 1; totalMonsters <= 3; totalMonsters++)
        {
            bool monsterKilled = false;
            while (monsterKilled == false)
            {
                //ATTACK SECTION
                Console.WriteLine($"Attack the {CurrentMonster.Name} with {Player.CurrentWeapon}? (yes/no)");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "yes")
                {
                    CurrentMonster.CurrentHitPoints -= Player.CurrentWeapon.MaximumDamage;
                }

                Player.CurrentHitPoints -= CurrentMonster.MaximumDamage;

                Console.WriteLine($"The HP of the {CurrentMonster.Name} is: {CurrentMonster.CurrentHitPoints}");
                Console.WriteLine($"Your current HP is: {Player.CurrentHitPoints}\n");

                //PLAYER WIN OR LOSE
                if (this.Player.CurrentHitPoints <= 0)
                {
                    Console.WriteLine($"The {CurrentMonster.Name} has killed you.");
                    Console.WriteLine($"You lost the game!");
                    monsterKilled = true;
                    Program.game = Loop.Exit("lost");
                    return;
                }
                else if (this.CurrentMonster.CurrentHitPoints <= 0)
                {
                    Console.WriteLine($"You killed {totalMonsters} {CurrentMonster.Name}(s)!");
                    if (totalMonsters == 3)
                    {
                        Quest.QuestCounter += 1;
                        ActivateDialogueEnd(LocationQuest.ID);
                    }
                    monsterKilled = true;
                }
            }
        }
    }

    public void ActivateDialogueStart(int QuestDialogue)
    {
        if (QuestDialogue == 1)
        {
            Console.WriteLine("You stumble upon the alchemist's hut. A frail old woman shuffles towards you\n");
            Console.WriteLine("Quest: Kill three rats in the alchemist's garden.\n");
        }
        else if (QuestDialogue == 2)
        {
            Console.WriteLine("The farmer begins to shout colorful language upon seeing you walk in through the gate");
            Console.WriteLine("While aiming his shotgun at you, he asks you what you're doing here.");
            Console.WriteLine("You try to remain calm, and explain that you're just passing by, and mean no harm.");
            Console.WriteLine("The farmer scoffs, and raises his gun slightly.");
            Console.WriteLine("He asks you for help exterminating the snakes that have been invading his field.");
            Console.WriteLine("You feel you have little choice.");
            Console.WriteLine("Quest: Kill three snakes in the farmer's field.\n");
        }
        else if (QuestDialogue == 3)
        {
            Console.WriteLine("You enter the spiders lair. A chill goes down your spine.");
            Console.WriteLine("Something rustles behind you. You freeze.");
            Console.WriteLine("You feel something brush against your leg. You swallow, hard.");
            Console.WriteLine("You carefully turn around, only to find 24 eyes staring back at you.");
            Console.WriteLine("One spider as large as a horsecart, two the size of a hog. Its minions, you assume.");
            Console.WriteLine("The spiders hiss, and start crawling towards you at high speeds, mandibles snapping.");
            Console.WriteLine("Quest: Kill the three spiders in the spider's lair.\n");
        }
    }

    public void ActivateDialogueEnd(int QuestDialogue)
    {
        if (QuestDialogue == 1)
        {
            Console.WriteLine("Quest completed: Kill three rats in the alchemist's garden.");
            Console.WriteLine("Item Obtained: Strength Potion.");
            Console.WriteLine("Downing the potion, you instantly feel more powerful.");
            Console.WriteLine("You feel like you could do more damage to monsters around you.\n");
        }
        else if (QuestDialogue == 2)
        {
            Console.WriteLine("The farmer starts to shout again, this time of glee.");
            Console.WriteLine("He thanks you for finally getting rid of those snakes, mentioning something about dinner");
            Console.WriteLine("You politely decline and insisting on a reward, the farmer pulls out a shield instead");
            Console.WriteLine("You thank him, and say you'll be on your way.\n");
            Console.WriteLine("Quest completed: Kill three snakes in the farmer's field.");
            Console.WriteLine("Item Obtained: Wooden Shield.\n");
        }
        else if (QuestDialogue == 3)
        {
            Console.WriteLine("You've won. Panting, you look down on the beasts.");
            Console.WriteLine("Their mangled bodies make you feel light-headed, but at least the threat is over.");
            Console.WriteLine("The townspeople will be free to enjoy their days once again.\n");
            Console.WriteLine("Quest completed: Kill the three spiders in the spider's lair.");
            Console.WriteLine("Thank you for playing!");
        }
    }

    public void ActivateDialogueGuard()
    {
        Console.WriteLine("HALT! A guardsman is standing in front of a large gate.");
        Console.WriteLine("He says that only men who have proven themselves may go past this point.\n");

        if (Quest.QuestCounter != 2)
        {
            Console.WriteLine("Maybe it's best to come back after you've helped some people out...");
            Console.WriteLine("Just two should do, right?\n");
            Console.WriteLine("Current objective: complete 2 quests.\n");
        }
        else
        {
            Console.WriteLine("You explain you've been trying your best to help around town.");
            Console.WriteLine("The guard mumbles something about hearing certain complaints had been pulled... must've been your doing.");
            Console.WriteLine("The guard relents, raising the halberd that was previously blocking your path.");
            Console.WriteLine("Go on, then.\n");
        }
    }
}