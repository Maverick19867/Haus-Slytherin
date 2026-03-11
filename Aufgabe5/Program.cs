List<IReteable> sytherinAudit = new List<IReteable>
{
    new Basilisk(),
    new DarkArtifact("Tom Riddle's Diary", 9),
    new DarkArtifact("Verfluchtes Halsband", 4)
};

foreach (var item in sytherinAudit)
{
    Console.WriteLine($"Gefahr: {item.GetDangerLevel()} | Verboten: {item.IsForbidden()}");
}