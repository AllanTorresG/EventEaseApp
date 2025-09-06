    public class EventModel // Blueprint for event data
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public string Location { get; set; } =string.Empty;
    }
    
     public class RegistrationModel // New class for registration data
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }

public static class EventData // Simulated data source
{
    public static List<EventModel> EventsList { get; } = new()
    {
        new EventModel { Id = 1, Name = "Blazor Workshop", Date = new DateOnly(2025, 9, 10), Location = "Online" },
        new EventModel { Id = 2, Name = "Tech Conference", Date = new DateOnly(2025, 10, 5), Location = "New York" },
        new EventModel { Id = 3, Name = "Community Meetup", Date = new DateOnly(2025, 11, 15), Location = "San Francisco" }
    };
}

