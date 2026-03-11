// Aufgabe 14 - Code Smells

// 14.1 Definier "Code Smell"
// Code Smell ist ein Begriff aus der Softwareentwicklung, der auf Anzeichen oder Muster in einem Code hinweist, 
// die auf potenzielle Probleme oder Schwächen in der Codequalität hindeuten. Es handelt sich um Indikatoren dafür, 
// dass der Code möglicherweise schwer zu warten, zu verstehen oder zu erweitern ist. Code Smells können verschiedene 
// Formen annehmen, wie z.B. duplizierter Code, lange Methoden, unklare Benennungen oder übermäßige Abhängigkeiten. 
// Das Erkennen von Code Smells ist wichtig, um die Wartbarkeit und Qualität des Codes zu verbessern und technische Schulden zu vermeiden.

// 14.2 Beispiele:
// God Class: Eine Klasse, die zu viele Verantwortlichkeiten hat und dadurch schwer zu verstehen und zu warten ist.
// Long Method: Eine Methode, die zu lang ist und dadurch schwer zu verstehen und zu warten ist.
// Duplicate Code: Code, der an mehreren Stellen im Projekt dupliziert ist, was zu Wartungsproblemen führen kann.


// 14.3 Finde 2 Beispiele
// Duplicate Code  Dragon.cs Spider.cs
// in Dragon.cs
using System.Security.Cryptography.X509Certificates;

if (string.IsNullOrEmpty(name)) throw new Exception("Name cannot be null or empty.");
//in Spider.cs
if (string.IsNullOrEmpty(name)) throw new Exception("Name cannot be null or empty.");

//Refactoring
// Verschieben der Logik in die Basisklasse Creature.cs
public abstract class Creature
{
    protected void ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty.");
        }
    }
}
