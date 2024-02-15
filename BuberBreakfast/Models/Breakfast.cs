public class Breakfast
{
    private Guid guid;

    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Savory { get; }
    public List<string> Sweet { get; }

    private Breakfast(
        Guid id,
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime lastModifiedDateTime,
        List<string> savory,
        List<string> sweet
    )
    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savory = savory;
        Sweet = sweet;
    }

    public Breakfast(Guid guid, string name, string description, DateTime startDateTime, DateTime endDateTime, List<string> savory, List<string> sweet)
    {
        this.guid = guid;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        Savory = savory;
        Sweet = sweet;
    }
}
