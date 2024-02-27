public class Weapon
{
    public int ID;
    public int MaximumDamage;
    public string Name;

    public Weapon(int id, string name, int damage)
    {
        this.ID = id;
        this.MaximumDamage = damage;
        this.Name = name;
    }
}