public class Player
{
    public int CurrentHitPoints = 0;
    public string CurrentLocation = null; //location object of string?
    public string CurrentWeapon = null; //weapon object of string?
    public const int MaximumHitPoints = 5;
    public readonly string Name;

    public Player(string Name)
    {
        this.Name = Name;
    }
}