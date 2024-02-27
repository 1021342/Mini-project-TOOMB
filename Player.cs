class Player
{
    public int CurrentHitPoints;
    public string CurrentLocation; //location object of string?
    public string CurrentWeapon; //weapon object of string?
    public const int MaximumHitPoints = 5;
    public string Name;

    public Player(int CurrentHitPoints, string CurrentLocation, string CurrentWeapon, string Name)
    {
        this.CurrentHitPoints = CurrentHitPoints;
        this.CurrentLocation = CurrentLocation;
        this.CurrentWeapon = CurrentWeapon;
        this.Name = Name;
    }
}