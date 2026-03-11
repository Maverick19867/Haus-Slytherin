//Aufgabe 15 Architektur Review

//15.1 Analysiere dein Projekt.
// Das Projekt von einer einfachen Klasse zu einer 3-Tier-Architektur entwickelt. 
// Stärken: - Kapselung Daten sind durch Properties geschützt, was die Integrität der Daten gewährleistet.
//          - Abstraktion: Es werden Interfaces (ICreatureRepository, IRateable) genutzt was den Code flexibler und leichter testbar macht.
//          - Logik ist klar durch Service-Layer und Pattern getrennt, was die Wartbarkeit verbessert.

// Schwächen: - Instanziierung in der Program.cs werden die Services noch manuell mit new zusammengebaut
//            - Bei einigen Dateien könnten fehlende namespaces zu konflikten führen, wenn das Projekt wächst.

//15.2 Identifizierung von Verbesserungen und 15.3 Refactoring
// hinzufügen von Namespaces.

//Beispiel in Repositories/InMemoryRepository.cs
namespace HogwartsProject.Repositories
{
    public class InMemoryRepository : ICreatureRepository { ... }
}

//Beispiel in Services/CreatureServices.cs
namespace HogwartsProject.Services
{
    using HogwartsProject.Repositories;
    public class CreatureServices { ... }
}