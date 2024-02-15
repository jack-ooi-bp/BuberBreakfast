namespace BuberBreakfasts.Contracts.Breakfasts

public record UpsertBreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTim,
    DateTime EndDateTime, 
    List<string>Savory,
    List<string>Sweet;
)