namespace BuberBreakfast.Contracts.Breakfast

public record UpsertBreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTim,
    DateTime EndDateTime, 
    List<string>Savory,
    List<string>Sweet;
)