public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere; //heeft de andere classes nodig
    public Monster MonsterLivingHere; //heeft de andere classes nodig

    public Location(int id, string name, string description, Quest quest, Monster monster)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.QuestAvailableHere = quest;
        this.MonsterLivingHere = monster;
    }

    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;
}