using MoviesExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesExample.Business
{
    public class MovieService
    {
        // This class will take data from DB,API,,,vs.
        public List<MovieListResponseDTO> GetListResponseDTOs()
        {
            MovieRepository repo = new MovieRepository();
            var movies = repo.GetAllMovies();

            List<MovieListResponseDTO> dtoList = new List<MovieListResponseDTO>();

            foreach (var item in movies)
            {
                //initialize ->

                var dto = new MovieListResponseDTO
                {

                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Name = item.Name,
                    ImdbRating = item.ImdbRating,
                    MovieMadeYear = item.MovieMadeYear
                };
                dtoList.Add(dto);
            }
            return dtoList;

        }
        public Movie GetMovieResponseDTO(int id)
        {
            MovieRepository repo = new MovieRepository();
            var movies = repo.GetAllMovies();
            //return true if the Id in the product is equal to the parameter id, otherwise return null.
            return movies.FirstOrDefault(p => p.Id == id);

        }
    }
}
