using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesExample.Models
{
    public class Movie
    {
        //All movies related features are here ->
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public double ImdbRating { get; set; }
        public DateTime MovieMadeYear { get; set; }

        // 
        public string Genre { get; set; }
        public string Description { get; set; }
        public List<string> Stars { get; set; }
        public string Director { get; set; }

    }
}
