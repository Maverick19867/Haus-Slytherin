using System;

class Phoenix : Creature
{
    public Phoenix(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} singt ein magisches Lied und leuchtet hell auf!");
    }
}