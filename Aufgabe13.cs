/* Aufgabe 13 - Coupling & Cohesion 
    *13.1 Erkläre Kopplung 
     beschreibt den Grad der Abhängikeit zwischen verschiedenen Klassen. Es wird in Starke und Lose Kopplung unterschieden.
     Starke Kopplung bedeutet, dass eine Klasse stark von einer anderen Klasse abhängig ist, während lose Kopplung bedeutet, 
     dass die Klassen unabhängig voneinander arbeiten können.
     Starke Kopplung kann zu Problemen führen, da Änderungen an einer Klasse Auswirkungen auf andere Klassen haben können, 
     während lose Kopplung die Wartbarkeit und Flexibilität des Codes verbessert. 
    
    *13.2 Erkläre Kohäsion
     beschreibt den Grad, zu dem die Elemente einer Klasse zusammenarbeiten, um eine einzelne Aufgabe zu erfüllen. 
     Hohe Kohäsion bedeutet, dass eine Klasse gut definierte Verantwortlichkeiten hat und ihre Methoden eng miteinander 
     verbunden sind. Niedrige Kohäsion kann dazu führen, dass eine Klasse viele unterschiedliche Aufgaben übernimmt, 
     was die Wartbarkeit und Verständlichkeit des Codes erschwert.

    *13.3 Finde Beispiele in deinem Code
     Die Klasse DangerLevelException. Sie hat nur eine einzige Aufgabe, Informationen über eine 
     spezifischen Fehler bereitzustellen. Jede Methode darin dient diese Zweck

    *13.4 Verbessere Design
    Beispiel vorher:
    */

    public class CreatureService
{
    private InMemoryRepository _repo = new InMemoryRepository();

}

/*
    Beispiel nachher:
    */

    public class CreatureService
{
    private IRepository _repo;

    public CreatureService(IRepository repo)
    {
        _repo = repo;
    }

}





