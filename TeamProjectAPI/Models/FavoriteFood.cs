namespace TeamProjectAPI.Models
{
    public class FavoriteFood
    {
        public int Id { get; set; }
        public required string FoodName { get; set; }
        public required string CuisineType { get; set; }
        public bool IsSpicy { get; set; }
        public int Calories { get; set; }
    }
}
