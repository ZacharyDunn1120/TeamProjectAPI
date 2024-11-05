namespace TeamProjectAPI.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public required string HobbyName { get; set; }
        public required string Description { get; set; }
        public required string Frequency { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
