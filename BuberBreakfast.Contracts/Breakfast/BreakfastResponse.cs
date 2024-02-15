namespace BuberBreakfast.Contracts.Breakfast;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
)
{
    private Guid id;
    private object value;

    public BreakfastResponse(Guid id, object value)
    {
        this.id = id;
        this.value = value;
    }
}
