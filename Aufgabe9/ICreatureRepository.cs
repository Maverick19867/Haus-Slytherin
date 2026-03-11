using System.Collections.Generic;
using System.Runtime.CompilerServices;

public interface ICreatureRepository
{
    void AddCreature(Creature creature);
    IEnumerable<Creature> GetAllCreatures();
    Creature GetByName(string name);
}