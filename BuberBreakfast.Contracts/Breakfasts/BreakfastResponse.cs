namespace BuberBreakfasts.Contracts.Breakfasts
public record BreakfastsResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTim,
    DateTime EndDateTime, 
    List<string>Savory,
    List<string>Sweet;
)