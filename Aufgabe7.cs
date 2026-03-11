/* Aufgabe 7 God Class Refactoring
    *Gegeben:
    *CreatureManager
    *enthält:
    *CreateCreature
    *PrintCreature
    *Statistics
    *Validation
Database
*/

/*7.1 Warum ist das eine God Class?
    * Die CreatureManager-Klasse ist eine God Class, weil sie mehrere Verantwortlichkeiten hat. 
    * Sie ist verantwortlich für die Erstellung von Kreaturen, das Drucken von Kreatureninformationen, 
    * die Berechnung von Statistiken und die Validierung von Daten. Diese Vielzahl von Verantwortlichkeiten 
    * führt zu einer engen Kopplung und macht die Klasse schwer wartbar und erweiterbar.
*/

/*7.2 Aufteilung in Services
    * CreatureFactory - CreateCreature
    * CreatureRenderer - PrintCreature
    * StatisticsService - GetStatistics
    * Validator - Validation
    * CreatureRepository - SaveToDatabase
*/

/* Beispiel für eine Refactoring */

public class CreatureRepository
{
    public void Save(CreatureRepository c) => Console.WriteLine("Creature saved to database");

}

public class CreatureRenderer
{
    public void Display(Creature c) => Console.WriteLine($"Creature: {c.Name}, Type: {c.Type}");

}

public class CreatureController
{
    private readonly CreatureRepository _repository;
    private readonly CreatureRenderer _renderer;

    public CreatureController(CreatureRepository repository, CreatureRenderer renderer)
    {
        _repository = repository;
        _renderer = renderer;
    }

    public void HandleNewCreature(Creature c)
    {
        _repository.Save(c);
        _renderer.Display(c);
    }
}