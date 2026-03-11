using System;

public class DangerLevelException : Exception
{
    public int InvalidLevel { get; }
    
    public DangerLevelException(int level)
        : base($"Kriitscher Fehler: Gefahrenlevel {level} is für Hogwarts nicht zulässig")
        {
            InvalidLevel = level;
        }
        
}