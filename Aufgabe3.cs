/*Gegeben:
class Basilisk
{
public int dangerLevel;
}

Warum ist das schlecht?
Es ist schlecht, weil die Gefahrstufe (dangerLevel) öffentlich zugänglich ist, 
was bedeutet, dass jeder Code außerhalb der Basilisk-Klasse sie direkt ändern kann.

*/

using System;

class Basilisk
{
    private int _dangerLevel;

    public int DangerLevel
    {
        get{ return _dangerLevel; }
        set
        {
            if (value >= 1 && value <= 10)
            {
                _dangerLevel = value;
            }
            else
            {
                System.Console.WriteLine("Fehler: DangerLevel muss zwischen 1 und 10 liegen.");

                _dangerLevel = 1;
            }
        }
    }

    public Basilisk(int level)
    {
        DangerLevel = level;
    }
}