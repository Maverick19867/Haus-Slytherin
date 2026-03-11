using System; 
using System.Collections.Generic;
using System.Linq;


/* Aufgabe 10.1 Durchschnittslevel berechnen */
double averageDanger  = creatures.Any() ? creatures.Average(c => c.DangerLevel) : 0;
Console.WriteLine($"Average Danger Level: {averageDanger}");

/* Aufgabe 10.2 Kreaturen nach Gefährlichkeit sortieren */
var mosteDangerous = creature.MaxBy(c => c.DangerLevel);
Console.WriteLine($"Most Dangerous Creature: {mostDangerous?.Name}");

/* Aufgabe 10.3 Filter für das DangerLevel >7 */
var eliteMonsters = creatures.Where(c => c.DangerLevel > 7).ToList();

/* Aufgabe 10.4 Kreaturen nach Name sortieren */
var sortedByName = creatures.OrderBy(c => c.Name).ToList();