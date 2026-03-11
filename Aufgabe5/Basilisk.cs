class Basilisk : IRateable
{
    public int Danger { get; set; } = 10;

    public int GetDangerLevel() => Danger;
    public bool IsForbidden() => true;
}