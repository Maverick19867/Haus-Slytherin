class DarkArtifact : IRateable
{
    public string name { get; set; }
    public int CurseIntensity { get; set; }
    public DatkArtifact(string name, int Intensity)
    {
        Name = name;
        CurseIntensity = Intensity;
    }

    public int GetDangerLevel() => CurseIntensity;
    public bool IsForbidden() => CurseIntensity > 5;
}