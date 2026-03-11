/* Aufgabe 6 SOLID Analyse
    * 6.1 Erkläre Single Responsibility Principle (SRP)
    * 6.2 Erkläre Open/Closed Principle (OCP)
    * 6.3 Erkläre Dependency Inversion Principle (DIP)
*/

/* 6.1 Single Responsibility Principle (SRP):
    Das Single Responsibility Principle besagt, dass eine Klasse nur eine einzige Verantwortlichkeit haben sollte.
    Das bedeutet, dass eine Klasse nur für eine bestimmte Funktion oder Aufgabe zuständig sein sollte.
    Wenn eine Klasse mehrere Verantwortlichkeiten hat, kann dies zu Problemen führen, 
    da Änderungen an einer Verantwortlichkeit Auswirkungen auf die anderen Verantwortlichkeiten haben können. 
    Durch die Einhaltung des SRP wird der Code modularer, leichter verständlich und wartbar.
*/

/* 6.2 Open/Closed Principle (OCP):
    Das Open/Closed Principle besagt, dass Software-Entitäten (Klassen, Module, Funktionen) offen für Erweiterungen, 
    aber geschlossen für Modifikationen sein sollten.
    Das bedeutet, dass man neue Funktionalitäten hinzufügen können sollte, ohne den bestehenden Code zu ändern.
    Durch die Einhaltung des OCP wird die Wartbarkeit und Erweiterbarkeit des Codes verbessert, 
    da Änderungen an bestehenden Funktionen vermieden werden und neue Funktionen einfach hinzugefügt werden können.
*/

/* 6.3 Dependency Inversion Principle (DIP):
    Das Dependency Inversion Principle besagt, dass hochrangige Module nicht von niederrangigen Modulen abhängen sollten, 
    sondern beide von Abstraktionen abhängen sollten. 
    Das bedeutet, dass die Abhängigkeiten zwischen den Modulen so gestaltet werden sollten, dass sie von Schnittstellen oder abstrakten Klassen abhängen, 
    anstatt von konkreten Implementierungen.
    Durch die Einhaltung des DIP wird die Flexibilität und Testbarkeit des Codes verbessert, 
    da Module leichter ausgetauscht oder erweitert werden können, ohne dass andere Module betroffen sind.
*/

/* 6.4 Finde ein Beispiel aus deinem Code.
    * OCP (Open/Closed Principle) - Beispiel: Meine List<Creature> in der Main -Methode ist perfect für Open-Closed.
    * Offen: Wenn Hagrid ein neues Tier bekommt, muss ich nur eine neue Klasse erstellen, die von Creature erbt, und sie der Liste hinzufügen.
    * Geschlossen: Ich muss die bestehenden Klassen nicht ändern, um neue Kreaturen hinzufügen, was die Wartbarkeit verbessert.

    *DIP (Dependency Inversion Principle) - Beispiel: Meine Liste<Creature> hängt nicht von der konkreten Klasse Basilisk ab, 
    sondern von dem Interface IRateable. Dadruch kann ich jederzeit neue bewertbare Objekte hinzufügen, 
    ohne die bestehenden Klassen zu ändern, was die Flexibilität erhöht.
*/
