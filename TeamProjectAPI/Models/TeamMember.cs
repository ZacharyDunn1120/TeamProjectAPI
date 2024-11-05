namespace TeamProjectAPI.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public required string CollegeProgram { get; set; }
        public required string YearInProgram { get; set; } // E.g., Freshman, Sophomore, etc.
    }
}
