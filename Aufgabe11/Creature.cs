public class Creature
{
    
    private int _dangerLevel;
    public string Name { get; set; }

    public int DangerLevel
    {
        get => _dangerLevel;
        set
        {
            if (value > 10)
            {
                throw new DangerLevelException(value);
            }
            _dangerLevel = value;
        }
    }
}