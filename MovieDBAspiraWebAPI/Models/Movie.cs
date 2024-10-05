namespace MovieDBAspiraWebAPI.Models
{
    public class Movie
    {

        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int? ReleaseYear { get; set; }
    }
}
