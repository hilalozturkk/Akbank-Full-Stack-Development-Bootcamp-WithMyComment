using MoviesExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesExample.Business
{
    public class MovieRepository
    {
        public List<Movie> GetAllMovies()
        {

            List<Movie> movies = new List<Movie>()
            {//fake data
                new Movie
                {
                    Id = 1,
                    Name="The Shawshank Redemption",
                    ImageUrl="/picture1.jpf",
                    ImdbRating=9.3,
                    MovieMadeYear=new DateTime(1994),
                    Genre = "Drama",
                    Director="Frank Drabont",
                    Description="Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."

                },
                     new Movie
                {
                    Id = 2,
                    Name=" The Godfather",
                    ImageUrl="/picture1.jpf",
                    ImdbRating=9.2,
                    MovieMadeYear=new DateTime(1972),
                    Genre = "Drama , Crime",
                    Director="Francis Ford Coppola",
                    Description="An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son."

                }
            };
            return movies;


        }
    }
}
