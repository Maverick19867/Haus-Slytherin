/* Aufgabe 2 Identifiziere OOP-Probleme
* class Dragon
    {
    public string name;
    public int danger;
    }

    Der Code verletzt das Prinzip der Kapselung.
    Jeder externe Code kann direkt auf die Felder "name" und "danger" zugreifen und sie ändern, was zu unerwartetem Verhalten führen kann.
    
    Fehlende Validierung: Es gibt keine Möglichkeit, die Werte von "name" und "danger" zu validieren, bevor sie gesetzt werden. 
    Zum Beispiel könnte "danger" einen negativen Wert annehmen, was keinen Sinn ergibt.

    Kein Schutz des Objektzustandes: Es gibt keine Mechanismen, um den Zustand des Objekts zu schützen.
    Zum Beispiel könnte jemand den Namen eines Drachen in einen leeren String ändern, was möglicherweise
    zu Problemen führen könnte, wenn der Name für die Identifikation des Drachens verwendet wird.
*/

/* Die Verbesserung mit PrintInfo:*/

class Dragon
{
    private int _danger;

    public string Name { get; set; }

    public int Danger
    {
        get => _danger;
        set
        {
            if (value < 0) _danger = 0;
            else _danger = value;
        }
    }

    public Dragon(string name, int danger)
    {
        Name = name;
        Danger = danger;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Danger: {Danger}");
    }
    
}
