using System.Runtime.CompilerServices;

/* Aufgabe 11.1 Wann sollte man Exceptions verwenden?
 * Exceptions sollten verwendet werden, um unerwartete Fehler oder Ausnahmen zu behandeln, 
 * die während der Programmausführung auftreten können. Sie ermöglichen es, 
 * Fehler auf eine strukturierte Weise zu behandeln und den Code sauberer und wart
*/

class Program
{
    static void Main()
    {
        try
        {
            Creature basilisk = new Creature { Name = "Basolisk", DangerLevel = 15}
        }
        catch (DangerLevelException ex)
        {
            Console.WriteLine($"Sicherheitswarunung: {ex.Message}");
            Console.WriteLine($"Eingegangener Wert: {ex.InvalidLevel}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Programmende.");
        }
    }
}