using System;

class Spider : Creature
{
    public Spider(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} krabbelt an der Wand und macht: Klick-klick!");
    }
}