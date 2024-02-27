class Weapon
{
    public int ID;
    public int MaximumDamage;
    public string Name;

    public Weapon(int id, int damage, string name)
    {
        this.ID = id;
        this.MaximumDamage = damage;
        this.Name = name;
    }
}