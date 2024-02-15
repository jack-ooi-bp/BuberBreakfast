namespace BuberBreakfast.Contracts.Breakfast

public record CreateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTim,
    DateTime EndDateTime, 
    List<string>Savory,
    List<string>Sweet;
)