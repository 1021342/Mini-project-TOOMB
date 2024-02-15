class Player
{
    public int CurrentHitPoints;
    public string CurrentLocation; //location object of string?
    public string CurrentWeapon; //weapon object of string?
    public int MaximumHitPoints;
    public string Name;

    public Player(int CurrentHitPoints, string CurrentLocation, string CurrentWeapon, int MaximumHitPoints, string Name)
    {
        this.CurrentHitPoints = CurrentHitPoints;
        this.CurrentLocation = CurrentLocation;
        this.CurrentWeapon = CurrentWeapon;
        this.MaximumHitPoints = MaximumHitPoints;
        this.Name = Name;
    }
}