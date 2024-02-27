class SuperAdventure
{
    public Monster CurrentMonster;
    public Player ThePlayer;

    public SuperAdventure(string CurrentMonster, string ThePlayer)
    {
        this.CurrentMonster = CurrentMonster;
        this.ThePlayer = ThePlayer;
    }

    //Loops through possible quest, in case location contains one to be activated.
    public CurrentQuest()
    {
        Quest LocationQuest = ThePlayer.CurrentLocation.QuestAvailableHere;
        string monsterName = LocationQuest.ID switch
        {
            1 => "rat",
            2 => "snake",
            3 => "giant spider"
        }

        CurrentMonster = 
        for (int totalMonsters = 3; totalMonsters > 0; totalMonsters--)
        {
            Console.WriteLine($"Attack the {CurrentMonster} with {ThePlayer.CurrentWeapon}?");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                CurrentMonster.CurrentHitPoints -= ThePlayer.CurrentWeapon.MaximumDamage;
            }
        }
}