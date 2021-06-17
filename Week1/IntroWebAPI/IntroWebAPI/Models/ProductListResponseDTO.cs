using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Models
{
    public class ProductListResponseDTO
    {//DTO -> Data Transfer Object
     //Only the features that the client will need are here
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }

    }
}
