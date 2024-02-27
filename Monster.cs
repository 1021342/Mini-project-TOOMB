using System.Data.Common;

class Monster
{
    public int ID;
    public string Name;
    public float MaximumDamage;
    public float CurrentHitPoints;
    public float MaximumHitPoints;

    public Monster(int id, string name, float MaxD, float CurrHP, float MaxHP)
    {
        this.ID = id;
        this.Name = name;
        this.MaximumDamage = MaxD;
        this.CurrentHitPoints = CurrHP;
        this.MaximumHitPoints = MaxHP;
    }
}
