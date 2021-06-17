using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesExample.Models
{
    public class MovieListResponseDTO
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public double ImdbRating { get; set; }
        public DateTime MovieMadeYear { get; set; }
    }
}
