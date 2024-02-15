namespace BuberBreakfast.Contracts.Breakfast
public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTim,
    DateTime EndDateTime, 
    List<string>Savory,
    List<string>Sweet;
)