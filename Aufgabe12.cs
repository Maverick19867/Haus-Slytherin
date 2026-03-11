/* Aufgabe 12 Architektur Analyse 
Projektstruktur:
Models
Services
Repositories
*/

/* 12.1 Warum ist diese Struktur sinnvoll?
Diese Struktur ist sinnvoll, weil sie die Verantwortlichkeiten klar trennt und die Wartbarkeit des Codes verbessert.
- Models: Hier werden die Datenstrukturen und Geschäftsobjekte definiert. Es enthält Klassen, 
  die die Daten repräsentieren, mit denen die Anwendung arbeitet.
- Services: Hier werden die Geschäftslogik und die Anwendungslogik implementiert. Es enthält Klassen, 
  die die Hauptfunktionen der Anwendung ausführen, wie z.B. die Verarbeitung von Daten, die Durchführung 
  von Berechnungen oder die Koordination von Aktionen.
- Repositories: Hier werden die Datenzugriffslogik und die Interaktion mit der Datenbank implementiert. 
  Es enthält Klassen, die für das Abrufen, Speichern, Aktualisieren und Löschen von Daten verantwortlich sind.
*/


/*12.2 Welche Klasse gehört wohin?
Models: Dragon, Spider, Basilisk (Der Bauplan oder das Skelett)
Repositories: ICreatureRepository, SQLRepository (Der Lagerverwalter, holt/speichert Daten)
Services: CreatureSerivce, StatisticsService (Der Koordinator, entscheidet was mit Daten passiert.)
*/

/* 12.3 Erstelle eine Beispielstruktur

HogwartsProject/
│
├── Models/                 # Nur Datenstrukturen
│   ├── Creature.cs
│   ├── Dragon.cs
│   └── Phoenix.cs
│
├── Repositories/           # Nur Datenzugriff (Speichern/Laden)
│   ├── ICreatureRepository.cs
│   └── InMemoryRepository.cs
│
├── Services/               # Logik und Berechnungen
│   ├── CreatureService.cs
│   └── StatisticsService.cs
│
├── Exceptions/             # Fehlerbehandlung
│   └── DangerLevelException.cs
│
└── Program.cs              # Der Startpunkt der Anwendung

*/

/* 12.4 Erkläre Vorteile
    * Gerine Kopplung, wenn du eine Interface nutzt ist es dem Service egal woher die Daten Stammen(SQL, Datenbank, Textdatei)
    * Einfaches Testen, man kann die CreatureService testen ohne eine echte Datenbank zu besitzen, in dem man ein "Fake-Repository" nutzt.
    * Teamarbeit: Entwickler A kann neue Models erstellen während Entwickler B die Logik von Service verbessert, ohne das sie in derselben Datei arbeiten.
    * Skalierbarkeit: Wenn das Projekt wächst findet man Klassen sofort wieder anstatt 5000 Zeilen Code zu durchsuchen.