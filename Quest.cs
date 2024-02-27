using System.ComponentModel;

public class Quest
{

    public string Description;

    public int ID;
    
    public string Name;

    public Quest(string description, int id, string name)
    {
        this.Description = description;
        this.ID = id;
        this.Name = name;
    }

}