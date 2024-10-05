using Microsoft.AspNetCore.Mvc;
using MovieDBAspiraWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieDBAspiraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = [
            new Movie() {
                Id = Guid.Parse("99d30d32-5b1f-486b-9dfd-151ecec1b5f0"),
                Title = "Ironman",
                ReleaseYear = 2006,
            },
            new Movie() {
                Id = Guid.Parse("b8344da8-0864-4b24-b9c4-88d10e6635af"),
                Title = "Spiderman",
                ReleaseYear = 2008,
            }
            ];

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movie Get(Guid id)
        {
            return movies.First(movie => movie.Id == id);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value);
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Movie updatedMovie)
        {
            int index = movies.FindIndex(movie => movie.Id == id);

            if (index == -1)
            {
                return;
            }

            movies[index] = updatedMovie;
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            movies.RemoveAll(movie => movie.Id == id);
        }
    }
}
