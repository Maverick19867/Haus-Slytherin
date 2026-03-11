ICreatureRepository repo = new InMemoryCreatureRepository();
CreatureService service = new CreatureService(repo);

service.AddCreature(new Dragon("Norbert", 2));