namespace EventEaseApp.Services
{
public class UserSessionService
{
    public string? UserName { get; set; }
    public bool IsRegistered { get; set; }
    public string? LastRegisteredEventName { get; set; }
    public List<int> AttendedEventIds { get; set; } = new();
}

}