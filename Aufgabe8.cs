/* Aufgabe 8 - Service Layer Desing */

/* 8.1 und 8.2 */
using System;
using System.Collections.Generic;
using System.Linq;

public class CreatureService
{
    private readonly List<Creature> _creatures = new List<Creature>();

    public void AddCreature(Creature creature)
    {
        if (creature == null) return;
        _creatures.Add(creature);
        System.Console.WriteLine($"{creature.Name} added to the service.");
    }

    public Creature GetCreature(strng name)
    {
        return _creatures.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void RemoveCreature(string name)
    {
        var creature = GetCreature(name);
        if (creature != null)
        {
            _creatures.Remove(creature);
            System.Console.WriteLine($"{creature.Name} removed from the service.");
        }
        else
        {
            System.Console.WriteLine($"Creature with name {name} not found.");
        }
    }
}

/* 8.3 Warum gehört diese Logik nicht ins Model?
    * Die Logik für das Hinzufügen, Abrufen und Entfernen von Kreaturen gehört nicht ins Model, 
    * weil das Model in der Regel die Datenstruktur und die Geschäftslogik repräsentiert, 
    * während der Service Layer für die Verwaltung und Koordination dieser Logik verantwortlich ist. 
    * Das Model sollte sich auf die Definition der Kreatur und ihrer Eigenschaften konzentrieren, 
    * während der Service Layer die Interaktionen mit den Kreaturen verwaltet. Dadurch wird eine klare 
    * Trennung der Verantwortlichkeiten erreicht, was zu einem saubereren und wartbareren Code führt.
*/

/* 8.4 Vorteile eines Service Layers:
    * Trennung der Verantwortlichkeiten: Der Service Layer trennt die Geschäftslogik von der Datenzugriffsschicht, 
      was zu einem saubereren und wartbareren Code führt.
    * Wiederverwendbarkeit: Der Service Layer ermöglicht die Wiederverwendung von Geschäftslogik in 
      verschiedenen Teilen der Anwendung oder sogar in verschiedenen Anwendungen.
    * Testbarkeit: Durch die Trennung der Geschäftslogik im Service Layer wird das Testen einfacher, 
      da die Logik isoliert und unabhängig von anderen Komponenten getestet werden kann.
    * Flexibilität: Der Service Layer ermöglicht es, Änderungen an der Geschäftslogik vorzunehmen, 
      ohne die Datenzugriffsschicht oder andere Teile der Anwendung zu beeinflussen.
    * Skalierbarkeit: Ein gut gestalteter Service Layer kann dazu beitragen, die Skalierbarkeit 
      einer Anwendung zu verbessern, indem er die Last auf verschiedene Dienste verteilt und die Wartbarkeit erhöht.
*/