using System.ComponentModel;

public class Quest
{

    public string Description;

    public int ID;
    
    public string Name;

    public Quest(int id, string description, string name)
    {
        this.Description = description;
        this.ID = id;
        this.Name = name;
    }

}