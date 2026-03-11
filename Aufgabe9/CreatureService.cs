public class CreatureService
{
    private readonly ICreatureRepository _repository;

    public CreatureService(ICreatureRepository repository)
    {
        _repository = repository;
    }

    public void AddCreature(Creature c)
    {
        if(string.IsNullOrEmpty(c.Name)) return;
        _repository.Add(c);
    }

    public IEnumerable<Creature> ListAll() => _repository.GetAll();
    
}