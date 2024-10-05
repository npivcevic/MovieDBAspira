using MovieDBAspiraWebAPI.DTOs;
using MovieDBAspiraWebAPI.Models;

namespace MovieDBAspiraWebAPI.Mappers
{
    public static class MovieMapper
    {
        public static MovieListDTO ToMovieListDTO(this Movie movie)
        {
            return new MovieListDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                ReleaseYear = movie.ReleaseYear,
            };
        }
    }
}
