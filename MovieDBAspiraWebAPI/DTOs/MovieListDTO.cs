namespace MovieDBAspiraWebAPI.DTOs
{
    public class MovieListDTO
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int? ReleaseYear { get; set; }
    }
}
