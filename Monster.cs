using System.Data.Common;

public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public float CurrentHitPoints;
    public float MaximumHitPoints;

    public Monster(int id, string name, int MaxD, float CurrHP, float MaxHP)
    {
        this.ID = id;
        this.Name = name;
        this.MaximumDamage = MaxD;
        this.CurrentHitPoints = CurrHP;
        this.MaximumHitPoints = MaxHP;
    }
}

