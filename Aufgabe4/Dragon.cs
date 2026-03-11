using System.Runtime.CompilerServices;

class Dragon : Creature
{
    public Dragon(string name) : base(name){}
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars!");
    }
}