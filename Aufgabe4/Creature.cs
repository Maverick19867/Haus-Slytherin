abstract class Creature
{
    public string Name{ get; set; }
    public Creature(string name) {Name = name; }
    public abstract void MakeSound();
}