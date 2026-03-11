using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Creature> hagridsStall = new List<Creature>();

        hagridsStall.Add(new Dragon("Norbert", 2));
        hagridsStall.Add(new Spider("Aragog", 50));
        hagridsStall.Add(new Phoenix("Fawkes", 100));

        Console.WriteLine("Hagrids Kreaturen machen Krach:");
        foreach (var tier in hagridsStall)
        {
            tier.MakeSound();
        }
    }
}