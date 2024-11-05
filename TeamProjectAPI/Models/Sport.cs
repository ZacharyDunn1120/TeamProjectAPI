namespace TeamProjectAPI.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public required string SportName { get; set; }
        public required string TeamOrIndividual { get; set; } // E.g., "Team" or "Individual"
        public int PlayersCount { get; set; }
        public required string Season { get; set; } // E.g., "Winter", "Summer"
    }
}
