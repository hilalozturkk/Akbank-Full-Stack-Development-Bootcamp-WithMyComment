using MoviesExample.Business;
using MoviesExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesExample.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet] //if Get request come
        public IActionResult AllMovies()
        {
            MovieService dataService = new MovieService();
            var list = dataService.GetListResponseDTOs();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            MovieService dataService = new MovieService();
            var movie = dataService.GetMovieResponseDTO(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult AddProduct(Movie movie)
        {
            return CreatedAtAction(nameof(GetMovieById), new { id = 3 }, null);
        }


    }
}

