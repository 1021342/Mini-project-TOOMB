class Player
{
    public int CurrentHitPoints = 0;
    public Location CurrentLocation = null; //location object of string?
    public Weapon CurrentWeapon = null; //weapon object of string?
    public const int MaximumHitPoints = 5;
    public readonly string Name;

    public Player(string Name)
    {
        this.Name = Name;
    }
}