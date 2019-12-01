using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MoviesDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public List<Movie> Movies { get; set; }

        public MoviesController()
        {
            Movies = new List<Movie>
            {
                new Movie { Id= 1, Title = "Jumanji", year = 1996 },
                new Movie { Id= 2, Title = "The good the bad and the ugly", year = 1996 },
                new Movie { Id= 3, Title = "The godfather", year = 1996 },
                new Movie { Id= 4, Title = "Inception", year = 1996 },
                new Movie { Id= 5, Title = "Office christmas party", year = 1996 },
            };
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
