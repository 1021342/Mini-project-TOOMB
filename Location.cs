class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere; //heeft de andere classes nodig
    public Monster MonsterLivingHere; //heeft de andere classes nodig
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;
}