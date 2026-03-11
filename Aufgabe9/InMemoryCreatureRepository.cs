using System;
using System.Collections.Generic;
using System.Linq;

public class InMemoryCreatureRepository : ICreatureRepository
{
    private readonly List<Creature> _storage = new List<Creature>();

    public void Add(Creature creature) => _storage.Add(creature);

    public IEnumerable<Creature> GetAll() => _storage;

    public Creature GetByName(string name)
    {
        return _storage.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}